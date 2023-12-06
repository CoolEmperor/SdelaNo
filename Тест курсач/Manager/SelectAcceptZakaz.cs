using iTextSharp.text;
using iTextSharp.text.pdf;
using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using OfficeOpenXml;
using LicenseContext = OfficeOpenXml.LicenseContext;

namespace Тест_курсач.Manager
{
    public partial class SelectAcceptZakaz : UserControl
    {
        string connectionString = "Data Source=DMITRYBUGAI-LAP\\SQLEXPRESS;Initial Catalog=СделаНо;Integrated Security=True";
        int selectId;
        public SelectAcceptZakaz(int selectId)
        {
            InitializeComponent();
            this.selectId = selectId;
            FillDataGridView();
        }
        private void FillDataGridView()
        {
            string query = $"SELECT * FROM ЗаказДляУчетаЗаказовНаРемонт Where ИдЗаказа = {selectId}";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable table = new DataTable();
                adapter.Fill(table);
                data1.DataSource = table;
            }

            string query1 = $@"SELECT * FROM МатериалыДляМастера";

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
                SqlCommand zakazQuery = new SqlCommand($"SELECT ИдЗаказа, Статус FROM ЗаказДляУчетаЗаказовНаДиагностику WHERE ИдЗаказа = {selectId}", connection);

                using (SqlDataReader reader = zakazQuery.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        string status = reader["Статус"].ToString();
                        if (status == "Выдан")
                        {
                            butStart.Visible = false;
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
            MessageBox.Show("Заказ выдан");
            string query = $"UPDATE Заказ SET Статус = 'Выдан', Дата_выдачи = GETDATE() WHERE ИдЗаказа = {selectId};";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        private void butReport_Click(object sender, EventArgs e)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            int orderId = selectId;

            // Путь к вашему Excel-шаблону
            string templateFilePath = "C:\\Users\\dimas\\OneDrive\\Рабочий стол\\Тест курсач\\Квитанция.xlsx";
            string outputFilePath = "C:\\Users\\dimas\\OneDrive\\Рабочий стол\\Тест курсач\\Отчет_Заказ_" + orderId + ".xlsx";

            try
            {
                FileInfo templateFile = new FileInfo(templateFilePath);
                using (ExcelPackage package = new ExcelPackage(templateFile))
                {
                    ExcelWorksheet worksheet = package.Workbook.Worksheets["Квитанция"]; // Укажите название листа в файле Excel

                    string query = @"
                        SELECT 
                            З.ИдЗаказа, З.Номер_квитанции, З.Дата_принятия, З.Дата_начала, З.Дата_конца, З.Дата_выдачи, 
                            С.ФИО AS ФИОМастера, ВТ.Название AS НазваниеВида, З.Статус, З.Аванс, З.Скидка, З.ФИО_Клиента, З.Номер_телефона, 
                            З.Стоимость_материалов, З.Стоимость_работ, З.Общая_стоимость, 
                            М.Название AS НазваниеМодели, Т.Название AS НазваниеТипа,
                            РР.Название AS НазваниеРаботы, РР.Описание AS ОписаниеРаботы, РР.Стоимость AS СтоимостьРаботы,
                            МТ.Название AS НазваниеМатериала, МТ.Стоимость AS СтоимостьМатериала, ЗМ.Количество AS КоличествоМатериала
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
                                    int rowWork = 14; // Начало строк для записи информации о работах
                                    int rowMaterial = 24; // Начало строк для записи информации о материалах

                                    while (reader.Read())
                                    {

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
                                        reader.NextResult();
                                        do
                                        {
                                            worksheet.Cells[rowWork, 2].Value = reader["НазваниеРаботы"].ToString();
                                            worksheet.Cells[rowWork, 3].Value = reader["ОписаниеРаботы"].ToString();
                                            worksheet.Cells[rowWork, 4].Value = reader["СтоимостьРаботы"].ToString();
                                            rowWork++;
                                        } while (reader.Read());
                                        reader.NextResult();
                                        do
                                        {
                                            worksheet.Cells[rowMaterial, 2].Value = reader["НазваниеМатериала"].ToString();
                                            worksheet.Cells[rowMaterial, 4].Value = reader["СтоимостьМатериала"].ToString();
                                            worksheet.Cells[rowMaterial, 3].Value = reader["КоличествоМатериала"].ToString();
                                            rowMaterial++;
                                        } while (reader.Read());

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
    }
}
