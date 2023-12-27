using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace СделаНо
{
    
    public partial class Admin : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["Тест_курсач.Properties.Settings.СделаНоConnectionString"].ConnectionString;
        //string connectionString = "Data Source=DMITRYBUGAI-LAP\\SQLEXPRESS;Initial Catalog=СделаНо;Integrated Security=True";
        private string fns1;
        public Admin(string fns)
        {
            InitializeComponent();
            fns1 = fns;
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "сделаНоDataSet.Сотрудник". При необходимости она может быть перемещена или удалена.
            this.сотрудникTableAdapter.Fill(this.сделаНоDataSet.Сотрудник);

            MessageBox.Show("Здравствуйте, " + fns1);
            label3.Text = fns1;
        }

        private void butExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void butClear_Click(object sender, EventArgs e)
        {
            textFIO.Clear();
            textLogin.Clear();
            textPass.Clear();
            textTel.Clear();
        }
        private void FillDataGridView()
        {
            string query = "SELECT * FROM Сотрудник";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable table = new DataTable();
                adapter.Fill(table);
                data1.DataSource = table;
            }
        }

        private bool IsValidName(string name)
        {
            string pattern = @"^[\p{L}\p{M}'\.\-]+ [\p{L}\p{M}'\.\-]+ [\p{L}\p{M}'\.\-]+$";
            return Regex.IsMatch(name, pattern);
        }

        private bool IsValidTelefon(string name)
        {
            string pattern = @"^\+375\d{2}\d{3}\d{2}\d{2}$";
            return Regex.IsMatch(name, pattern);
        }

        private void butAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(textFIO.Text) || string.IsNullOrWhiteSpace(textLogin.Text)
                        || string.IsNullOrWhiteSpace(textPass.Text)|| string.IsNullOrWhiteSpace(textTel.Text))
                {
                    MessageBox.Show("Пожалуйста, заполните все поля.");
                    return;
                }

                string FIO = textFIO.Text;
                string login = textLogin.Text;
                string pass = textPass.Text;
                string role = comboRole.Text;
                string tel = textTel.Text;

                if (!IsValidName(FIO))
                {
                    MessageBox.Show("ФИО должно: состоять из 3 слов, каждое слово начинаться с большой буквы и быть на русском языке.");
                    return;
                }
                else if (!IsValidTelefon(tel))
                {
                    MessageBox.Show("Номер телефона должен начинаться на +375 и состоять из 12 цифр");
                    return;
                }
                else
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        using (SqlCommand command = new SqlCommand("InsertEmployee", connection))
                        {
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.AddWithValue("@ФИО", FIO);
                            command.Parameters.AddWithValue("@Логин", login);
                            command.Parameters.AddWithValue("@Пароль", pass);
                            command.Parameters.AddWithValue("@Роль", role);
                            command.Parameters.AddWithValue("@Телефон", tel);

                            command.ExecuteNonQuery();
                        }

                        FillDataGridView();

                        MessageBox.Show("Данные добавлены успешно.");
                    }
                }
                
            }
            catch (System.Data.SqlClient.SqlException)
            {
                MessageBox.Show("Строка не может быть добавление!!!",
               "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void butEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(textFIO.Text) || string.IsNullOrWhiteSpace(textLogin.Text)
                    || string.IsNullOrWhiteSpace(textPass.Text) || string.IsNullOrWhiteSpace(textTel.Text))
                {
                    MessageBox.Show("Пожалуйста, заполните все поля.");
                    return;
                }
                int selectedEmployeeId = (int)data1.CurrentRow.Cells[0].Value;
                string FIO = textFIO.Text;
                string login = textLogin.Text;
                string pass = textPass.Text;
                string role = comboRole.Text;
                string tel = textTel.Text.ToString();

                if (!IsValidName(FIO))
                {
                    MessageBox.Show("ФИО должно: состоять из 3 слов, каждое слово начинаться с большой буквы и быть на русском языке.");
                    return;
                }
                else if (!IsValidTelefon(tel))
                {
                    MessageBox.Show("Номер телефона должен начинаться на +375 и состоять из 12 цифр");
                    return;
                }
                else
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        using (SqlCommand command = new SqlCommand("UpdateEmployee", connection))
                        {
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.AddWithValue("@ИдСотрудника", selectedEmployeeId);
                            command.Parameters.AddWithValue("@ФИО", FIO);
                            command.Parameters.AddWithValue("@Логин", login);
                            command.Parameters.AddWithValue("@Пароль", pass);
                            command.Parameters.AddWithValue("@Роль", role);
                            command.Parameters.AddWithValue("@Телефон", tel);

                            command.ExecuteNonQuery();
                        }
                        FillDataGridView();
                    }
                    MessageBox.Show("Данные изменены успешно.");
                }
            }
            catch (System.Data.SqlClient.SqlException)
            {
                MessageBox.Show("Строка не может быть добавление!!!",
               "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void butDelete_Click(object sender, EventArgs e)
        {

            try
            {
                int selectedEmployeeId = (int)data1.CurrentRow.Cells[0].Value;

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("DeleteEmployee", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@ИдСотрудника", selectedEmployeeId);
                        command.ExecuteNonQuery();
                    }

                    FillDataGridView();
                }

                MessageBox.Show("Данные удалены успешно.");
            }
            catch (System.Data.SqlClient.SqlException)
            {
                MessageBox.Show("Строка не может быть удалена!!!",
               "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void butSort_Click(object sender, EventArgs e)
        {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string sortField = "ФИО";
                    string sortOrder = comboBoxSort2.Text;

                    sortOrder = comboBoxSort2.Text;
                    switch (sortOrder)
                    {
                        case "По возрастанию":
                            sortOrder = "ASC";
                            break;
                        case "По убыванию":
                            sortOrder = "DESC";
                            break;
                    }

                    using (SqlCommand command = new SqlCommand("SortEmployees", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@SortField", sortField);
                        command.Parameters.AddWithValue("@SortOrder", sortOrder);

                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        data1.DataSource = table;
                    }

                    MessageBox.Show("Список отсортирован.");
                }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (data1.SelectedRows.Count > 0)
            {
                textFIO.Text = data1.CurrentRow.Cells[1].Value.ToString();
                textLogin.Text = data1.CurrentRow.Cells[2].Value.ToString();
                textPass.Text = data1.CurrentRow.Cells[3].Value.ToString();
                comboRole.Text = data1.CurrentRow.Cells[4].Value.ToString();
                textTel.Text = data1.CurrentRow.Cells[5].Value.ToString();
            }
        }

        private void textBoxFindFam_TextChanged(object sender, EventArgs e)
        {
            string filterText = textBoxFindFam.Text;
            string findField = "ФИО";

            if (!string.IsNullOrWhiteSpace(filterText))
            {
                сотрудникBindingSource.Filter = $"{findField} LIKE '{filterText}%'";
            }
            else
            {
                сотрудникBindingSource.RemoveFilter();
            }
        }

        private void textTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '(' && e.KeyChar != ')' && e.KeyChar != '-' && e.KeyChar != '+')
            //{
            //    e.Handled = true;
            //}
        }
   
        private const int MaxLength = 20;
        private void textTel_TextChanged(object sender, EventArgs e)
        {
            //string phoneNumber = textTel.Text.Replace("+", "").Replace("(", "").Replace(")", "").Replace("-", "");

            //if (phoneNumber.Length > 0 && phoneNumber[0] != '+' && phoneNumber[0] != '3' && phoneNumber[0] != '7' && phoneNumber[0] != '5') // Проверка на корректный код страны
            //{
            //    phoneNumber = "375" + phoneNumber; // Добавляем код страны по умолчанию
            //}
            //if (!phoneNumber.StartsWith("+")) // Добавляем плюс, если его еще нет в начале номера
            //{
            //    phoneNumber = "+" + phoneNumber;
            //}
         
            //if (phoneNumber.Length > 3) // Добавляем открывающую скобку после кода страны
            //{
            //    phoneNumber = phoneNumber.Insert(4, "(");
            //}
            //if (phoneNumber.Length > 7) // Добавляем закрывающую скобку после кода оператора
            //{
            //    phoneNumber = phoneNumber.Insert(7, ")");
            //}
            //if (phoneNumber.Length > 10) // Добавляем первый дефис после кода оператора
            //{
            //    phoneNumber = phoneNumber.Insert(10, "-");
            //}
            //if (phoneNumber.Length > 13) // Добавляем второй дефис после первых трех цифр номера
            //{
            //    phoneNumber = phoneNumber.Insert(13, "-");
            //}

            //if (phoneNumber.Length > MaxLength) // Ограничение длины номера телефона с маской
            //{
            //    phoneNumber = phoneNumber.Substring(0, MaxLength);
            //}


            //textTel.TextChanged -= textTel_TextChanged; // Удаляем обработчик временно
            //textTel.Text = phoneNumber;
            //textTel.SelectionStart = textTel.Text.Length; // Перемещаем курсор в конец текста
            //textTel.TextChanged += textTel_TextChanged; // Восстанавливаем обработчик
        }
    }
}
