
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
using СделаНо;
using Word = Microsoft.Office.Interop.Word;

namespace Тест_курсач.Manager
{
    public partial class SelectAcceptZakaz : UserControl
    {
        string connectionString = ConfigurationManager.ConnectionStrings["Тест_курсач.Properties.Settings.СделаНоConnectionString"].ConnectionString;

        int selectId;
        string fio;
        public SelectAcceptZakaz(int selectId, string fio)
        {
            InitializeComponent();
            this.selectId = selectId;
            FillDataGridView();
            this.fio = fio;
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
			GenerateReport();
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

		private void ReplaceWordStub(string stubToReplace, string text, Word.Document wordDocument)
		{
			var range = wordDocument.Content;
			range.Find.ClearFormatting();
			range.Find.Execute(FindText: stubToReplace, ReplaceWith: text);
		}

		private readonly string TemplaterFileName = @"" + Application.StartupPath.ToString() + "\\Квитанция.docx";
		public void GenerateReport()
		{
			int rows;
			var ИД_заказа = data1.CurrentRow.Cells[0].Value;
			var ФИО_Клиента = data1.CurrentRow.Cells[8].Value;
			var Телефон_Клиента = data1.CurrentRow.Cells[9].Value;
			var Дата_принятия_заказа = data1.CurrentRow.Cells[1].Value;
			var Дата_начала_ремонта = data1.CurrentRow.Cells[2].Value;
			var Дата_конца_ремонта = data1.CurrentRow.Cells[3].Value;
            var ФИО_Менеджера = fio;
			var ФИО_Мастера = data1.CurrentRow.Cells[4].Value;

			var Стоимость_работ = data1.CurrentRow.Cells[11].Value;
			var Стоимость_материалов = data1.CurrentRow.Cells[10].Value;
			var Стоимость_заказа = data1.CurrentRow.Cells[12].Value;
			var Аванс = data1.CurrentRow.Cells[7].Value;
			double Необходимо_внести = Convert.ToDouble(Стоимость_заказа) - Convert.ToDouble(Аванс);

			var Вид_техники = "";
			var Описание_устройства = "";
			var Тип_устройства = "";
			var Модель_устройства = "";

			string query = @"
            SELECT 
                VT.Название AS 'Название',
                VT.Описание AS 'Описание',
                TU.Название AS 'НазваниеТипа',
                M.Название AS 'НазваниеМодели'
            FROM 
                Заказ Z
                JOIN Вид_техники VT ON Z.ИдВида = VT.ИдВида
                JOIN Тип_устройства TU ON VT.ИдТипа = TU.ИдТипа
                JOIN Модель M ON VT.ИдМодели = M.ИдМодели
            WHERE 
                Z.ИдЗаказа = @OrderId";

			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				SqlCommand command = new SqlCommand(query, connection);
				command.Parameters.AddWithValue("@OrderId", Convert.ToInt32(ИД_заказа));

				try
				{
					connection.Open();
					SqlDataReader reader = command.ExecuteReader();
					if (reader.HasRows)
					{
						while (reader.Read())
						{
							Вид_техники = reader["Название"].ToString();
							Описание_устройства = reader["Описание"].ToString();
							Тип_устройства = reader["НазваниеТипа"].ToString();
							Модель_устройства = reader["НазваниеМодели"].ToString();
						}
					}
					else
					{
						Console.WriteLine("Данные не найдены.");
					}
					reader.Close();
				}
				catch (Exception ex)
				{
					Console.WriteLine($"Ошибка: {ex.Message}");
				}
			}

			var wordapp = new Word.Application();
			var wordDocument = wordapp.Documents.Open(TemplaterFileName);

			wordapp.Visible = false;

			ReplaceWordStub("<ИД_заказа>", Convert.ToString(ИД_заказа), wordDocument);
			ReplaceWordStub("<ФИО_Клиента>", Convert.ToString(ФИО_Клиента), wordDocument);
			ReplaceWordStub("<Телефон_Клиента>", Convert.ToString(Телефон_Клиента), wordDocument);
			ReplaceWordStub("<Дата_принятия_заказа>", Convert.ToString(Дата_принятия_заказа), wordDocument);
			ReplaceWordStub("<Дата_начала_ремонта>", Convert.ToString(Дата_начала_ремонта), wordDocument);
			ReplaceWordStub("<Дата_конца_ремонта>", Convert.ToString(Дата_конца_ремонта), wordDocument);
			ReplaceWordStub("<ФИО_Менеджера>", Convert.ToString(ФИО_Менеджера), wordDocument);
			ReplaceWordStub("<ФИО_Мастера>", Convert.ToString(ФИО_Мастера), wordDocument);

			ReplaceWordStub("<Стоимость_работ>", Convert.ToString(Стоимость_работ), wordDocument);
			ReplaceWordStub("<Стоимость_материалов>", Convert.ToString(Стоимость_материалов), wordDocument);
			ReplaceWordStub("<Стоимость_заказа>", Convert.ToString(Стоимость_заказа), wordDocument);
			ReplaceWordStub("<Аванс>", Convert.ToString(Аванс), wordDocument);
			ReplaceWordStub("<Необходимо_внести>", Convert.ToString(Необходимо_внести), wordDocument);

			ReplaceWordStub("<Вид_техники>", Convert.ToString(Вид_техники), wordDocument);
			ReplaceWordStub("<Тип_устройства>", Convert.ToString(Тип_устройства), wordDocument);
			ReplaceWordStub("<Модель_устройства>", Convert.ToString(Модель_устройства), wordDocument);
			ReplaceWordStub("<Описание_устройства>", Convert.ToString(Описание_устройства), wordDocument);

			Word.Table compltb = wordDocument.Tables[1];
			rows = data3.Rows.Count;
			for (int i = 0; i < rows; i++)
			{
				Object oMissing = System.Reflection.Missing.Value;
				compltb.Rows.Add(ref oMissing);
			}
			for (int i = 0; i < data3.Rows.Count; i++)
			{
				compltb.Cell(i + 2, 1).Range.Text = data3.Rows[i].Cells[1].Value.ToString() + "\t";
				compltb.Cell(i + 2, 1).Range.Bold = 0;
				compltb.Cell(i + 2, 2).Range.Text = data3.Rows[i].Cells[3].Value.ToString() + "\t";
				compltb.Cell(i + 2, 2).Range.Bold = 0;
				compltb.Cell(i + 2, 3).Range.Text = data3.Rows[i].Cells[2].Value.ToString() + "\t";
				compltb.Cell(i + 2, 3).Range.Bold = 0;
			}

			Word.Table compltb1 = wordDocument.Tables[2];
			int rows1 = data2.Rows.Count;

			for (int i = 0; i < rows1; i++)
			{
				Object oMissing = System.Reflection.Missing.Value;
				compltb1.Rows.Add(ref oMissing);
			}

			for (int i = 0; i < data2.Rows.Count; i++)
			{
				compltb1.Cell(i + 3, 1).Range.Text = data2.Rows[i].Cells[1].Value.ToString() + "\t";
				compltb1.Cell(i + 3, 1).Range.Bold = 0;
				compltb1.Cell(i + 3, 2).Range.Text = data2.Rows[i].Cells[2].Value.ToString() + "\t";
				compltb1.Cell(i + 3, 2).Range.Bold = 0;
				compltb1.Cell(i + 3, 3).Range.Text = data2.Rows[i].Cells[3].Value.ToString() + "\t";
				compltb1.Cell(i + 3, 3).Range.Bold = 0;
				compltb1.Cell(i + 3, 4).Range.Text = (Convert.ToDouble(data2.Rows[i].Cells[3].Value) * Convert.ToDouble(data2.Rows[i].Cells[2].Value)).ToString() + "\t";
				compltb1.Cell(i + 3, 4).Range.Bold = 0;
			}

			SaveFileDialog saveFileDialog = new SaveFileDialog();
			saveFileDialog.Filter = "Word Documents (*.docx)|*.docx";
			saveFileDialog.FileName = "Название_файла.docx";
			if (saveFileDialog.ShowDialog() == DialogResult.OK)
			{
				wordDocument.SaveAs(saveFileDialog.FileName);
				wordapp.Visible = true;
			}
			else
			{
				wordDocument.Close(Word.WdSaveOptions.wdDoNotSaveChanges);
			}

			if (!wordapp.Visible)
			{
				wordDocument.Close(Word.WdSaveOptions.wdDoNotSaveChanges);
				wordapp.Quit();
			}
		}

		private void butReport_Click(object sender, EventArgs e)
        {
            GenerateReport();
        }
    }
}
