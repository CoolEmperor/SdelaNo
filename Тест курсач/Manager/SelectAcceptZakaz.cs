
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using OfficeOpenXml;
using LicenseContext = OfficeOpenXml.LicenseContext;
using System.Configuration;

namespace Тест_курсач.Manager
{
    public partial class SelectAcceptZakaz : UserControl
    {
        string connectionString = ConfigurationManager.ConnectionStrings["Тест_курсач.Properties.Settings.СделаНоConnectionString"].ConnectionString;

        int selectId;
        public SelectAcceptZakaz(int selectId)
        {
            InitializeComponent();
            this.selectId = selectId;
            FillDataGridView();
        }
        private void FillDataGridView()
        {
            string query = $"SELECT * FROM ЗаказДляВыдачиЗаказов Where ИдЗаказа = {selectId}";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable table = new DataTable();
                adapter.Fill(table);
                data1.DataSource = table;
            }

            string query1 = $@"SELECT * FROM МатериалыДляМастера JOIN Затраченный_материал ON Затраченный_материал.ИдМатериала = МатериалыДляМастера.ИдМатериала WHERE Затраченный_материал.ИдЗаказа = {selectId}";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query1, connection);
                DataTable table = new DataTable();
                adapter.Fill(table);
                data2.DataSource = table;
            }
            string query2 = $@"SELECT Вид_ремонтных_работ.* FROM Вид_ремонтных_работ JOIN Работа ON Вид_ремонтных_работ.ИдРаботы = Работа.ИдРаботы WHERE Работа.ИдЗаказа = {selectId}";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query2, connection);
                DataTable table = new DataTable();
                adapter.Fill(table);
                data3.DataSource = table;
            }
        }
        private void CheckZakaz()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand zakazQuery = new SqlCommand($"SELECT ИдЗаказа, Статус FROM ЗаказДляВыдачиЗаказов WHERE ИдЗаказа = {selectId}", connection);

                using (SqlDataReader reader = zakazQuery.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        string status = reader["Статус"].ToString();
                        if (status == "Выдан")
                        {
                            butStart.Visible = false;
                        }
                        else if (status == "Готов к выдаче")
                        {
                            butReport.Visible = false;
                        }

                    }
                }
            }
        }
        private void SelectAcceptZakaz_Load(object sender, EventArgs e)
        {
            CheckZakaz();

        }

        private void butStart_Click(object sender, EventArgs e)
        {
            uppAccZakaz();
            report();
        }

        private void uppAccZakaz()
        {
            int lastReceiptNumber = 0;

            try
            {
                string query = "SELECT MAX(Номер_квитанции) AS Последний_номер FROM Заказ;";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        connection.Open();

                        object result = command.ExecuteScalar();

                        if (result != DBNull.Value)
                        {
                            lastReceiptNumber = Convert.ToInt32(result);
                        }
                        else
                        {
                            lastReceiptNumber = 1;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка: " + ex.Message);
            }

            string query1 = $"UPDATE Заказ SET Статус = 'Выдан', Номер_квитанции = @Номер_квитанции, Дата_выдачи = GETDATE() WHERE ИдЗаказа = {selectId};";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query1, connection);
                connection.Open();
                command.Parameters.AddWithValue("@Номер_квитанции", lastReceiptNumber);
                command.ExecuteNonQuery();
            }
        }

        private void report()
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            int orderId = selectId;

            string templateFilePath = "Квитанция.xlsx";

            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            saveFileDialog.Filter = "Excel файлы (*.xlsx)|*.xlsx|Все файлы (*.*)|*.*";
            saveFileDialog.FileName = "Квитанция.xlsx";
            DialogResult result = saveFileDialog.ShowDialog();
            string outputFilePath = "";
            if (result == DialogResult.OK)
            {
                outputFilePath = saveFileDialog.FileName;

                MessageBox.Show("Выбранный путь к файлу: " + outputFilePath);
            }
            else
            {
                MessageBox.Show("Пользователь отменил операцию выбора файла.");
            }

            try
            {
                FileInfo templateFile = new FileInfo(templateFilePath);
                using (ExcelPackage package = new ExcelPackage(templateFile))
                {
                    ExcelWorksheet worksheet = package.Workbook.Worksheets["Квитанция"];

                    string query = @"
                        SELECT 
                            З.ИдЗаказа, З.Номер_квитанции, З.Дата_принятия, З.Дата_начала, З.Дата_конца, З.Дата_выдачи, 
                            С.ФИО AS ФИОМастера, ВТ.Название AS НазваниеВида, З.Статус, З.Аванс, З.Скидка, З.ФИО_Клиента, З.Номер_телефона, 
                            З.Стоимость_материалов, З.Стоимость_работ, З.Общая_стоимость, 
                            М.Название AS НазваниеМодели, Т.Название AS НазваниеТипа,
                            РР.ИдРаботы, РР.Название AS НазваниеРаботы, РР.Описание AS ОписаниеРаботы, РР.Стоимость AS СтоимостьРаботы,
                            МТ.ИдМатериала, МТ.Название AS НазваниеМатериала, МТ.Стоимость AS СтоимостьМатериала, ЗМ.Количество AS КоличествоМатериала
                        FROM 
                            Заказ З
                        LEFT JOIN 
                            Вид_техники ВТ ON З.ИдВида = ВТ.ИдВида
                        LEFT JOIN 
                            Модель М ON ВТ.ИдМодели = М.ИдМодели
                        LEFT JOIN 
                            Тип_устройства Т ON ВТ.ИдТипа = Т.ИдТипа
                        LEFT JOIN 
                            Работа Р ON Р.ИдЗаказа = З.ИдЗаказа
                        LEFT JOIN 
                            Вид_ремонтных_работ РР ON Р.ИдРаботы = РР.ИдРаботы
                        LEFT JOIN 
                            Затраченный_материал ЗМ ON ЗМ.ИдЗаказа = З.ИдЗаказа
                        LEFT JOIN 
                            Материал МТ ON ЗМ.ИдМатериала = МТ.ИдМатериала
                        LEFT JOIN 
                            Сотрудник С ON З.ИдСотрудника = С.ИдСотрудника
                        WHERE 
                            З.ИдЗаказа = @OrderId;
                    ";

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@OrderId", orderId);
                            connection.Open();

                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                if (reader.HasRows)
                                {

                                    while (reader.Read())
                                    {
                                        worksheet.Cells["E1"].Value = reader["Номер_квитанции"].ToString();
                                        worksheet.Cells["C4"].Value = reader["ФИО_Клиента"].ToString();
                                        worksheet.Cells["C5"].Value = reader["Номер_телефона"].ToString();
                                        worksheet.Cells["C6"].Value = reader["НазваниеВида"].ToString();
                                        worksheet.Cells["C7"].Value = reader["НазваниеМодели"].ToString();
                                        worksheet.Cells["C8"].Value = reader["НазваниеТипа"].ToString();
                                        worksheet.Cells["E4"].Value = reader["Дата_принятия"].ToString();
                                        worksheet.Cells["E5"].Value = reader["Дата_начала"].ToString();
                                        worksheet.Cells["E6"].Value = reader["Дата_конца"].ToString();
                                        worksheet.Cells["E7"].Value = reader["Дата_выдачи"].ToString();
                                        worksheet.Cells["E8"].Value = reader["ФИОМастера"].ToString();
                                        worksheet.Cells["E9"].Value = reader["Скидка"].ToString();
                                        worksheet.Cells["E10"].Value = reader["Общая_стоимость"].ToString();

                                        Dictionary<int, string> works = new Dictionary<int, string>();
                                        Dictionary<int, string> materials = new Dictionary<int, string>();

                                        while (reader.Read())
                                        {

                                            if (!reader.IsDBNull(reader.GetOrdinal("НазваниеРаботы")))
                                            {
                                                int workId = Convert.ToInt32(reader["ИдРаботы"]); 
                                                string workInfo = $"{reader["НазваниеРаботы"]}, {reader["ОписаниеРаботы"]}, {reader["СтоимостьРаботы"]}";

                                                if (!works.ContainsKey(workId))
                                                {
                                                    works.Add(workId, workInfo);
                                                }
                                            }

                                            if (!reader.IsDBNull(reader.GetOrdinal("ИдМатериала")))
                                            {
                                                int materialId = Convert.ToInt32(reader["ИдМатериала"]);
                                                string materialInfo = $"{reader["НазваниеМатериала"]}, {reader["СтоимостьМатериала"]}"; /*, { reader["КоличествоМатериала"]}*/

                                                if (!materials.ContainsKey(materialId))
                                                {
                                                    materials.Add(materialId, materialInfo);
                                                }
                                            }
                                        }

                                        int rowWork = 14;
                                        int rowMaterial = 24;

                                        foreach (var work in works)
                                        {
                                            string[] workInfo = work.Value.Split(',');
                                            worksheet.Cells[rowWork, 2].Value = workInfo[0].Trim();
                                            worksheet.Cells[rowWork, 3].Value = workInfo[1].Trim();
                                            worksheet.Cells[rowWork, 4].Value = workInfo[2].Trim();
                                            rowWork++;
                                        }

                                        foreach (var material in materials)
                                        {
                                            string[] materialInfo = material.Value.Split(',');
                                            worksheet.Cells[rowMaterial, 2].Value = materialInfo[0].Trim();
                                            worksheet.Cells[rowMaterial, 4].Value = materialInfo[1].Trim();
                                            //worksheet.Cells[rowMaterial, 3].Value = materialInfo[2].Trim();
                                            rowMaterial++;
                                        }
                                    }

                                    package.SaveAs(new FileInfo(outputFilePath));
                                    MessageBox.Show("Отчет успешно сформирован в файле: " + outputFilePath);
                                }
                                else
                                {
                                    MessageBox.Show("Заказ с указанным идентификатором не найден.");
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }
        private void butReport_Click(object sender, EventArgs e)
        {
            report();
        }
    }
}
