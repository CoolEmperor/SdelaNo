using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace Тест_курсач.Master
{
    public partial class SelectZakaz : UserControl
    {
        int selectId;
        string connectionString = ConfigurationManager.ConnectionStrings["Тест_курсач.Properties.Settings.СделаНоConnectionString"].ConnectionString;

		private bool isEditingMaterials = false;
		private bool isEditingWorks = false;
		private bool isMaterialDoubleClickEventActive = false;

		public SelectZakaz(int selectId)
        {
            InitializeComponent();
            this.selectId = selectId;
            FillDataGridView();
            butBack.Visible = false;

            label3.Visible = false;
            data4.Visible = false;

            label4.Visible = false;
            data5.Visible = false;
            label5.Visible = false;
            text1.Visible = false;

            butRepair.Visible = false;
            butDiagn.Visible = false;
        }
        
        //Заполнение таблиц
        private void FillData3GridView(int materialID)
        {
            string query = $@"SELECT МатериалыДляМастера.* 
                      FROM МатериалыДляМастера 
                      JOIN Затраченный_материал ON МатериалыДляМастера.ИдМатериала = Затраченный_материал.ИдМатериала 
                      WHERE Затраченный_материал.ИдМатериала = {materialID}";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable table = new DataTable();
                adapter.Fill(table);

                if (table.Rows.Count > 0)
                {
                    DataRow newRow = table.Rows[0];

                    // Находим индекс строки в таблице data3, соответствующей добавленному материалу
                    int rowIndex = -1;
                    foreach (DataGridViewRow row in data3.Rows)
                    {
                        if (Convert.ToInt32(row.Cells[0].Value) == materialID)
                        {
                            rowIndex = row.Index;
                            break;
                        }
                    }

                    // Если строка найдена, обновляем её данными из таблицы
                    if (rowIndex != -1)
                    {
                        foreach (DataGridViewCell cell in data3.Rows[rowIndex].Cells)
                        {
                            cell.Value = newRow[cell.OwningColumn.DataPropertyName];
                        }
                    }
                }
            }

            string query1 = $@"SELECT МатериалыДляМастера.* 
                      FROM МатериалыДляМастера 
                      JOIN Затраченный_материал ON МатериалыДляМастера.ИдМатериала = Затраченный_материал.ИдМатериала 
                      WHERE Затраченный_материал.ИдЗаказа = {selectId}";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query1, connection);
                DataTable table = new DataTable();
                adapter.Fill(table);
                data3.DataSource = table; // Устанавливаем обновленную таблицу как источник данных для data3
            }
        }

        private void FillData2GridView(int workID)
        {
            string query = $@"SELECT Вид_ремонтных_работ.* FROM Вид_ремонтных_работ JOIN Работа ON Вид_ремонтных_работ.ИдРаботы = Работа.ИдРаботы WHERE Работа.ИдРаботы = {workID}";


            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable table = new DataTable();
                adapter.Fill(table);

                if (table.Rows.Count > 0)
                {
                    DataRow newRow = table.Rows[0];

                    int rowIndex = -1;
                    foreach (DataGridViewRow row in data2.Rows)
                    {
                        if (Convert.ToInt32(row.Cells[0].Value) == workID)
                        {
                            rowIndex = row.Index;
                            break;
                        }
                    }

                    if (rowIndex != -1)
                    {
                        foreach (DataGridViewCell cell in data2.Rows[rowIndex].Cells)
                        {
                            cell.Value = newRow[cell.OwningColumn.DataPropertyName];
                        }
                    }
                }
            }

            string query1 = $@"SELECT Вид_ремонтных_работ.* FROM Вид_ремонтных_работ JOIN Работа ON Вид_ремонтных_работ.ИдРаботы = Работа.ИдРаботы WHERE Работа.ИдЗаказа = {selectId}";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter1 = new SqlDataAdapter(query1, connection);
                DataTable table1 = new DataTable();
                adapter1.Fill(table1);
                data2.DataSource = table1;
            }
        }
        private void FillData1GridView()
        {
            string query = $"SELECT * FROM ЗаказДляМастера Where ИдЗаказа = {selectId}";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable table = new DataTable();
                adapter.Fill(table);
                data1.DataSource = table;
            }
        }
        private void FillDataGridView()
        {
            FillData1GridView();


			string query1 = $@"SELECT Вид_ремонтных_работ.* FROM Вид_ремонтных_работ JOIN Работа ON Вид_ремонтных_работ.ИдРаботы = Работа.ИдРаботы WHERE Работа.ИдЗаказа = {selectId}";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter1 = new SqlDataAdapter(query1, connection);
                DataTable table1 = new DataTable();
                adapter1.Fill(table1);
                data2.DataSource = table1;
            }

            string query2 = $@"SELECT МатериалыДляМастера.* FROM МатериалыДляМастера JOIN Затраченный_материал ON МатериалыДляМастера.ИдМатериала = Затраченный_материал.ИдМатериала JOIN Заказ ON Затраченный_материал.ИдЗаказа = Заказ.ИдЗаказа Where Заказ.ИдЗаказа = {selectId}";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query2, connection);
                DataTable table = new DataTable();
                adapter.Fill(table);
                data3.DataSource = table;
            }
            string query3 = $@"SELECT * FROM Вид_ремонтных_работ";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter1 = new SqlDataAdapter(query3, connection);
                DataTable table1 = new DataTable();
                adapter1.Fill(table1);
                data4.DataSource = table1;
            }

            string query4 = $@"SELECT * FROM Материал";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query4, connection);
                DataTable table = new DataTable();
                adapter.Fill(table);
                data5.DataSource = table;
            }
        }

        //Добавление работ
        private void butWork_Click(object sender, EventArgs e)
        {
            butWork.Visible = false;
            label2.Visible = false;
            data3.Visible = false;
            butMat.Visible = false;
            butBack.Visible = true;

            label3.Visible = true;
            data4.Visible = true;

            //label7.Visible = true;
            //textFindWork.Visible = true;
            butDiagn.Visible = true;
            MessageBox.Show("Для добавление работы, кликните 2 раза по таблице 'Работы для добавления'. Для удаление, кликните 2 раза по таблице 'Требуемая работа'");

            data2.MouseDoubleClick += data2_MouseDoubleClick;

			isEditingWorks = true;
		}

        //Добавление материалов
        private void butMat_Click(object sender, EventArgs e)
        {
            butRepair.Visible = true;
            label1.Visible = false;
            data2.Visible = false;
            butWork.Visible = false;
            butBack.Visible = true;

            label4.Visible = true;
            data5.Visible = true;
            label5.Visible = true;
            text1.Visible = true;

            //label6.Visible = true;
            //textFindMat.Visible = true;
            butMat.Visible = false;

            MessageBox.Show("Для добавление материала, кликните 2 раза таблице 'Материалы для добавления'. Для удаление, кликните 2 раза по таблице 'Требуемые материалы'");
			
            if (!isMaterialDoubleClickEventActive)
			{
				data5.MouseDoubleClick += data5_MouseDoubleClick;
				isMaterialDoubleClickEventActive = true;
			}

			data3.MouseDoubleClick += data3_MouseDoubleClick;

			isEditingMaterials = true;
		}

        //Добавление выбранного материала
		private void data5_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				if (!int.TryParse(text1.Text, out int quantity))
				{
					MessageBox.Show("Введите корректное количество материалов.");
					return;
				}
				int selectedMaterialID = Convert.ToInt32(data5.CurrentRow.Cells[0].Value);

				bool materialExists = CheckIfMaterialExists(selectedMaterialID);

				if (materialExists)
				{
					MessageBox.Show("Запись уже существует в таблице Требуемые материалы");
				}
				else
				{
					AddMaterialToRequired(selectedMaterialID);
					MessageBox.Show("Запись успешно добавлена в таблицу Требуемые материалы");
					FillData3GridView(selectedMaterialID);
					FillData1GridView();

				}
			}
		}
        //Проверка на повтор
		private bool CheckIfMaterialExists(int materialID)
		{
			string query = $"SELECT COUNT(*) FROM Затраченный_материал WHERE ИдМатериала = {materialID} AND ИдЗаказа = {selectId}";

			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				SqlCommand command = new SqlCommand(query, connection);
				connection.Open();
				int count = Convert.ToInt32(command.ExecuteScalar());
				return count > 0;
			}
		}

        //Добавление материала
		private void AddMaterialToRequired(int materialID)
		{
			int quant = Convert.ToInt32(text1.Text);

			string insertQuery = $"INSERT INTO Затраченный_материал (ИдМатериала, ИдЗаказа, Количество) VALUES (@MaterialID, @OrderID, @Quantity)";

			try
			{
				using (SqlConnection connection = new SqlConnection(connectionString))
				{
					using (SqlCommand command = new SqlCommand(insertQuery, connection))
					{
						// Добавляем параметры
						command.Parameters.AddWithValue("@MaterialID", materialID);
						command.Parameters.AddWithValue("@OrderID", selectId);
						command.Parameters.AddWithValue("@Quantity", quant);

						connection.Open();
						command.ExecuteNonQuery();
					}
				}

				MessageBox.Show("Запись успешно добавлена в таблицу Требуемые материалы");
				FillData3GridView(materialID);
				FillData1GridView();
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Ошибка при добавлении материала: {ex.Message}");
			}
		}

        //Возврат
		private void butBack_Click(object sender, EventArgs e)
        {

            label2.Visible = true;
            data3.Visible = true;
            butMat.Visible = true;
            label1.Visible = true;
            data2.Visible = true;
            butWork.Visible = true;
            butBack.Visible = false;

            label3.Visible = false;
            data4.Visible = false;

            label4.Visible = false;
            data5.Visible = false;
            label5.Visible = false;
            text1.Visible = false;

            //label6.Visible = false;
            //textFindMat.Visible = false;

            //label7.Visible = false;
            //textFindWork.Visible = false;

            butRepair.Visible = false;
            butDiagn.Visible = false;
            CheckZakaz();
            data2.MouseDoubleClick -= data2_MouseDoubleClick;
            data3.MouseDoubleClick -= data3_MouseDoubleClick;
			if (isMaterialDoubleClickEventActive)
			{
				data5.MouseDoubleClick -= data5_MouseDoubleClick;
				isMaterialDoubleClickEventActive = false;
			}
			isEditingMaterials = false;
			isEditingWorks = false;
		}

        //Удаление материала
        
        private void data3_MouseDoubleClick(object sender, MouseEventArgs e)
        {
			if (!isEditingMaterials)
				return;

			if (e.Button == MouseButtons.Left)
            {
                int selectedMaterialID = Convert.ToInt32(data3.CurrentRow.Cells[0].Value);

                DeleteMaterialFromAdditional(selectedMaterialID);
                MessageBox.Show("Запись успешно удалена из таблицы Требуемые материалы");
                FillDataGridView();
                FillData1GridView();
            }
        }

        //Метод для удаления материала

        private void DeleteMaterialFromAdditional(int materialID)
        {
            string deleteQuery = $"DELETE FROM Затраченный_материал WHERE ИдМатериала = {materialID}";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(deleteQuery, connection);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        //Добавление работ

        private void data4_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int selectedWorkID = Convert.ToInt32(data4.CurrentRow.Cells[0].Value);

                bool workExists = CheckIfWorkExists(selectedWorkID);

                if (workExists)
                {
                    MessageBox.Show("Запись уже существует в таблице Требуемые работы");
                }
                else
                {
                    AddWorkToRequired(selectedWorkID);
                    MessageBox.Show("Запись успешно добавлена в таблицу Требуемые работы");
                    FillData2GridView(selectedWorkID);
                    FillData1GridView();
                }

            }
        }
        private bool CheckIfWorkExists(int workID)
        {
            string query = $"SELECT COUNT(*) FROM Работа WHERE ИдРаботы = {workID} AND ИдЗаказа = {selectId}";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                int count = Convert.ToInt32(command.ExecuteScalar());
                return count > 0;
            }
        }

        private void AddWorkToRequired(int workID)
        {
            string insertQuery = $"INSERT INTO Работа (ИдРаботы, ИдЗаказа) VALUES ({workID}, {selectId})";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(insertQuery, connection);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        private void data2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
			if (!isEditingWorks)
				return;

			if (e.Button == MouseButtons.Left)
            {
                if (data2.RowCount > 0)
                {
                    int selectedWorkID = Convert.ToInt32(data2.CurrentRow.Cells[0].Value);

                    DeleteWorkFromAdditional(selectedWorkID);
                    MessageBox.Show("Запись успешно удалена из таблицы Требуемые работы");
                    FillDataGridView();
                    FillData1GridView();
                }
                else
                {
                    MessageBox.Show("Отсутсвуют строки для удаления");
                }
            }
        }
        private void DeleteWorkFromAdditional(int workID)
        {

            string deleteQuery = $"DELETE FROM Работа WHERE ИдРаботы = {workID}";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(deleteQuery, connection);
                connection.Open();
                command.ExecuteNonQuery();
            }


        }

        //Проверка заказов

        private void SelectZakaz_Load(object sender, EventArgs e)
        {
            CheckZakaz();
			data2.MouseDoubleClick -= data2_MouseDoubleClick;
			data3.MouseDoubleClick -= data3_MouseDoubleClick;
		}
        private void CheckZakaz()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand zakazQuery = new SqlCommand($"SELECT ИдЗаказа, Статус FROM Заказ WHERE ИдЗаказа = {selectId}", connection);

                using (SqlDataReader reader = zakazQuery.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        string status = reader["Статус"].ToString();
                        if (status == "На диагностике")
                        {
                            data3.Visible = false;
                            label2.Visible = false;
                            //label7.Visible = false;
                            //textFindMat.Visible = false;
                            butMat.Visible = false;
                        }
                        else if (status == "На ремонте")
                        {
                            butWork.Visible = false;
                        }
                        else if (status == "Диагностика окончена")
                        {
                            butWork.Visible = false;
                            butMat.Visible = false;
                            data3.Visible = false;
                            label2.Visible = false;
                        }
                        else if (status == "Отказ в ремонте")
                        {
                            butWork.Visible = false;
                            butMat.Visible = false;
                        }
                        else if (status == "Ремонт окончен")
                        {
                            butWork.Visible = false;
                            butMat.Visible = false;
                        }
                    }
                }
            }
        }

        //Завершение диагностики

        private void butDiagn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Диагностика окончена");
            string query = $"UPDATE Заказ SET Статус = 'Диагностика окончена' WHERE ИдЗаказа = {selectId};";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                command.ExecuteNonQuery();
            }

            butDiagn.Visible = false;
            //label7.Visible = false;
            //textFindWork.Visible = false;
            data4.Visible = false;
            label3.Visible = false;
            butBack.Visible = false;
            butWork.Visible = false;

			isEditingMaterials = false;
			isEditingWorks = false;
		}

        //Завершение ремонта

        private void butRepair_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ремонт окончен");
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = $"UPDATE Заказ SET Статус = 'Ремонт окончен', Дата_конца = @CurrentDate WHERE ИдЗаказа = @Id";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@CurrentDate", DateTime.Today);
                    command.Parameters.AddWithValue("@Id", selectId);

                    command.ExecuteNonQuery();
                }
            }
            butBack.Visible = false;
            butRepair.Visible = false;
            //label6.Visible = false;
            //textFindMat.Visible = false;
            text1.Visible = false;
            label5.Visible = false;
            data5.Visible = false;
            data2.Visible = true;

			isEditingMaterials = false;
			isEditingWorks = false;
		}
    }
}
