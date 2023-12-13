using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using СделаНо;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace Тест_курсач.Master
{
    public partial class SelectZakaz : UserControl
    {
        int selectId;
        string connectionString = "Data Source=DMITRYBUGAI-LAP\\SQLEXPRESS;Initial Catalog=СделаНо;Integrated Security=True";
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

            label6.Visible = false;
            textFindMat.Visible = false;

            label7.Visible = false;
            textFindWork.Visible = false;
            butRepair.Visible = false;
            butDiagn.Visible = false;
        }
        private void FillDataGridView()
        {
            string query = $"SELECT * FROM ЗаказДляМастера Where ИдЗаказа = {selectId}";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable table = new DataTable();
                adapter.Fill(table);
                data1.DataSource = table;
            }

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
        private void butWork_Click(object sender, EventArgs e)
        {
            label2.Visible = false;
            data3.Visible = false;
            butMat.Visible = false;
            butBack.Visible = true;

            label3.Visible = true;
            data4.Visible = true;

            label7.Visible = true;
            textFindWork.Visible = true;
            butDiagn.Visible = true;
            MessageBox.Show("Для добавление работы, кликните 2 раза по таблице 'Работы для добавления'. Для удаление, кликните 2 раза по таблице 'Требуемая работа'");            
        }

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

            label6.Visible = true;
            textFindMat.Visible = true;
            butMat.Visible = false;

            MessageBox.Show("Для добавление материала, кликните 2 раза таблице 'Материалы для добавления'. Для удаление, кликните 2 раза по таблице 'Требуемые материалы'");
        }

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

            label6.Visible = false;
            textFindMat.Visible = false;

            label7.Visible = false;
            textFindWork.Visible = false;

            butRepair.Visible = false;
            butDiagn.Visible = false;
            CheckZakaz();
        }
        //материалы
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
                    FillDataGridView();
                }
                
            }
        }
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

        private void AddMaterialToRequired(int materialID)
        {
            int quant = Convert.ToInt32(text1.Text);

            string insertQuery = $"INSERT INTO Затраченный_материал (ИдМатериала, ИдЗаказа, Количество) VALUES ({materialID}, {selectId}, {quant})";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(insertQuery, connection);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }
        private void data3_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int selectedMaterialID = Convert.ToInt32(data3.CurrentRow.Cells[0].Value);

                DeleteMaterialFromAdditional(selectedMaterialID);
                MessageBox.Show("Запись успешно удалена из таблицы Требуемые материалы");
                FillDataGridView();
            }
        }
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

        //работы
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
                    FillDataGridView();
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
            if (e.Button == MouseButtons.Left)
            {
                int selectedWorkID = Convert.ToInt32(data2.CurrentRow.Cells[0].Value);

                DeleteWorkFromAdditional(selectedWorkID);
                MessageBox.Show("Запись успешно удалена из таблицы Требуемые работы");
                FillDataGridView();
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

        private void textFindMat_TextChanged(object sender, EventArgs e)
        {
            string searchValue = textFindMat.Text.Trim(); // Получаем текст из TextBox для поиска

            if (!string.IsNullOrEmpty(searchValue))
            {
                материалыДляМастераBindingSource.Filter = string.Format("Название LIKE '%{0}%'", searchValue); // Фильтрация по заданному условию
            }
            else
            {
                материалыДляМастераBindingSource.Filter = ""; // Очищаем фильтр, чтобы отобразить все данные
            }
        }

        private void textFindWork_TextChanged(object sender, EventArgs e)
        {
            string searchValue = textFindWork.Text.Trim(); // Получаем текст из TextBox для поиска

            if (!string.IsNullOrEmpty(searchValue))
            {
                видремонтныхработBindingSource1.Filter = string.Format("Название LIKE '%{0}%'", searchValue); // Фильтрация по заданному условию
            }
            else
            {
                видремонтныхработBindingSource1.Filter = ""; // Очищаем фильтр, чтобы отобразить все данные
            }
        }

        private void SelectZakaz_Load(object sender, EventArgs e)
        {
            CheckZakaz();
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
                            label7.Visible = false;
                            textFindMat.Visible = false;
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
                        else if (status == "Ремонт окончен")
                        {
                            butWork.Visible = false;
                            butMat.Visible = false;
                        }
                    }
                }
            }
        }
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
            label7.Visible = false;
            textFindWork.Visible = false;
            data4.Visible = false;
            label3.Visible = false;
            butBack.Visible = false;
            butWork.Visible = false;
        }

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
            label6.Visible = false;
            textFindMat.Visible = false;
            text1.Visible = false;
            label5.Visible = false;
            data5.Visible = false;
            data2.Visible = true;
        }
    }
}
