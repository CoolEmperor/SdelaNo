using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using СделаНо;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Тест_курсач.Manager
{
    public partial class SelectDiagnZakaz : UserControl
    {
        string connectionString = "Data Source=DMITRYBUGAI-LAP\\SQLEXPRESS;Initial Catalog=СделаНо;Integrated Security=True";
        int selectId;
        public SelectDiagnZakaz(int selectId)
        {
            InitializeComponent();
            this.selectId = selectId;
            FillDataGridView();
        }

        private void butStart_Click(object sender, EventArgs e)
        {
            if (textAvans == null)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "UPDATE Заказ SET Статус = 'На ремонте', Дата_начала = @CurrentDate WHERE ИдЗаказа = @Id";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@CurrentDate", DateTime.Today);
                        command.Parameters.AddWithValue("@Id", selectId);

                        try
                        {
                            int rowsAffected = command.ExecuteNonQuery();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Ошибка при выполнении запроса: " + ex.Message);
                            // Дополнительная обработка исключения
                        }
                    }
                    label1.Visible = false;
                    textAvans.Visible = false;
                    butStart.Visible = false;
                    butEnd.Visible = false;
                    MessageBox.Show("Принятие в ремонт произведено");
                }
            }
            else if (textAvans != null)
            {
                string cost = textAvans.Text;
                if (!IsValidDecimal(cost))
                {
                    MessageBox.Show("Аванс должен быть числовым значением (десятичные числа указываются точкой).");
                    return;
                }
                else
                {
                    string query = $"UPDATE Заказ SET Статус = 'На ремонте', Аванс = {cost}, Дата_начала = @CurrentDate WHERE ИдЗаказа = {selectId};";

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        
                        SqlCommand command = new SqlCommand(query, connection);
                        connection.Open();
                        command.Parameters.AddWithValue("@CurrentDate", DateTime.Today);
                        command.ExecuteNonQuery();
                    }
                    label1.Visible = false;
                    textAvans.Visible = false;
                    butStart.Visible = false;
                    butEnd.Visible = false;
                    MessageBox.Show("Принятие в ремонт произведено");
                }
            }
            
        }
        private bool IsValidDecimal(string input)
        {
            string pattern = @"^[-+]?\d*\.?\d+$";
            return Regex.IsMatch(input, pattern);
        }
        private void butEnd_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Отказ от ремонта");
            string query = $"UPDATE Заказ SET Статус = 'Отказ в ремонте' WHERE ИдЗаказа = {selectId};";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                command.ExecuteNonQuery();
            }
            label1.Visible = false;
            textAvans.Visible = false;
            butStart.Visible = false;
            butEnd.Visible = false;
            MessageBox.Show("Отказ от ремонта произведен");
        }

        private void SelectDiagnZakaz_Load(object sender, EventArgs e)
        {
            CheckZakaz();
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
                        if (status == "На диагностике")
                        {
                            label1.Visible = false;
                            textAvans.Visible = false;
                            butStart.Visible = false;
                            butEnd.Visible = false;
                        }
                    }
                }
            }
        }
        private void FillDataGridView()
        {
            string query = $"SELECT * FROM ЗаказДляУчетаЗаказовНаДиагностику Where ИдЗаказа = {selectId}";

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
                SqlDataAdapter adapter = new SqlDataAdapter(query1, connection);
                DataTable table = new DataTable();
                adapter.Fill(table);
                data2.DataSource = table;
            }
        } 
    }
}
