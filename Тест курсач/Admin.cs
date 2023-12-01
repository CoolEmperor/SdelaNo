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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace СделаНо
{
    
    public partial class Admin : Form
    {
        string connectionString = "Data Source=DMITRYBUGAI-LAP\\SQLEXPRESS;Initial Catalog=СделаНо;Integrated Security=True";
        private string fns1;
        public Admin(string fns)
        {
            InitializeComponent();
            fns1 = fns;
        }
        
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

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
            this.Close();
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

        private void butFind_Click(object sender, EventArgs e)
        {
            string filterText = textBoxFindFam.Text;
            сотрудникBindingSource.Filter = string.Format("ФИО LIKE '{0}%'", filterText);
        }

        private void butAll_Click(object sender, EventArgs e)
        {
            сотрудникBindingSource.RemoveFilter();
        }
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            int selectedEmployeeId;
            if (data1.SelectedRows.Count > 0)
            {
                selectedEmployeeId = Convert.ToInt32(data1.CurrentRow.Cells[0].Value);

                textFIO.Text = data1.CurrentRow.Cells[1].Value.ToString();
                textLogin.Text = data1.CurrentRow.Cells[2].Value.ToString();
                textPass.Text = data1.CurrentRow.Cells[3].Value.ToString();
                comboRole.Text = data1.CurrentRow.Cells[4].Value.ToString();
                textTel.Text = data1.CurrentRow.Cells[5].Value.ToString();
            }
        }
    }
}
