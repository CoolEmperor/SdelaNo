using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace СделаНо
{
    public partial class Work : UserControl
    {
        string connectionString = ConfigurationManager.ConnectionStrings["Тест_курсач.Properties.Settings.СделаНоConnectionString"].ConnectionString;
        public Work()
        {
            InitializeComponent();
        }
        private void FillDataGridView()
        {
            string query = "SELECT * FROM Вид_ремонтных_работ";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable table = new DataTable();
                adapter.Fill(table);
                data1.DataSource = table;
            }
        }
        private void Work_Load(object sender, EventArgs e)
        {
            FillDataGridView();
        }
        private void ClearInputFields()
        {
            textName.Clear();
            textCost.Clear();
            textDesc.Clear();
        }
        private void butClear_Click(object sender, EventArgs e)
        {
            ClearInputFields();
        }
        private bool IsValidDecimal(string input)
        {
            string pattern = @"^[-+]?\d*\.?\d+$";
            return Regex.IsMatch(input, pattern);
        }

        private bool IsValidName(string name)
        {
            string pattern = @"^([А-ЯA-Z])([а-яa-z]+)$";
            return Regex.IsMatch(name, pattern);
        }
        private bool IsValidText(string name)
        {
            string pattern = @"^[А-ЯЁ][а-яё\s,]+$";
            return Regex.IsMatch(name, pattern);
        }
        private void butAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textName.Text) || string.IsNullOrWhiteSpace(textDesc.Text))
            {
                MessageBox.Show("Пожалуйста, заполните все обязательные поля.");
                return;
            }

            string name = textName.Text;
            string cost = textCost.Text;
            string desc = textDesc.Text;

            if (!IsValidName(name))
            {
                MessageBox.Show("Название должно начинаться с большой буквы.");
                return;
            }
            else if (!IsValidDecimal(cost))
            {
                MessageBox.Show("Стоимость должно быть числовым значением (десятичные числа указываются точкой).");
                return;
            }
            else if (!IsValidText(desc))
            {
                MessageBox.Show("Описание должно начинаться с большой буквы и быть на русском языке.");
                return;
            }
            else
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("InsertWork", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@Название", name);
                        command.Parameters.AddWithValue("@Стоимость", cost);
                        command.Parameters.AddWithValue("@Описание", desc);

                        command.ExecuteNonQuery();
                    }

                    ClearInputFields();
                    FillDataGridView();

                    MessageBox.Show("Данные добавлены успешно.");
                }
            }
        }

        private void butEdit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textName.Text) || string.IsNullOrWhiteSpace(textCost.Text))
            {
                MessageBox.Show("Пожалуйста, заполните все обязательные поля.");
                return;
            }

            string name = textName.Text;
            string cost = textCost.Text;
            string desc = textDesc.Text;

            if (!IsValidName(name))
            {
                MessageBox.Show("Название должно начинаться с большой буквы.");
                return;
            }
            else if (!IsValidDecimal(cost))
            {
                MessageBox.Show("Стоимость должно быть числовым значением (десятичные числа указываются точкой).");
                return;
            }
            else if (!IsValidText(desc))
            {
                MessageBox.Show("Описание должно начинаться с большой буквы и быть на русском языке.");
                return;
            }
            else
            {
                int selectedRowId = (int)data1.CurrentRow.Cells[0].Value;

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("UpdateWork", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@ИдРаботы", selectedRowId);
                        command.Parameters.AddWithValue("@Название", name);
                        command.Parameters.AddWithValue("@Стоимость", cost);
                        command.Parameters.AddWithValue("@Описание", desc);

                        command.ExecuteNonQuery();
                    }

                    ClearInputFields();
                    FillDataGridView();

                    MessageBox.Show("Данные изменены успешно.");
                }
            }
        }

        private void butDelete_Click(object sender, EventArgs e)
        {
            int selectedEmployeeId = (int)data1.CurrentRow.Cells[0].Value;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("DeleteWork", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@ИдРаботы", selectedEmployeeId);

                    command.ExecuteNonQuery();
                }

                FillDataGridView();

                MessageBox.Show("Данные удалены успешно.");
            }
        }

        private void butSort_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string sortField = "Название";
                string sortOrder = comboBox2.Text;
                switch (sortOrder)
                {
                    case "По возрастанию":
                        sortOrder = "ASC";
                        break;
                    case "По убыванию":
                        sortOrder = "DESC";
                        break;
                }
                using (SqlCommand command = new SqlCommand("SortWork", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@SortField", sortField);
                    command.Parameters.AddWithValue("@SortOrder", sortOrder);

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    data1.DataSource = table;
                }

                MessageBox.Show("Данные отсортированы успешно.");
            }
        }

        private void textBoxFind_TextChanged(object sender, EventArgs e)
        {
            string filterText = textBoxFind.Text;
            string findField = "Название";

            if (!string.IsNullOrWhiteSpace(filterText))
            {
                видремонтныхработBindingSource.Filter = $"{findField} LIKE '{filterText}%'";
            }
            else
            {
                видремонтныхработBindingSource.RemoveFilter();
            }
        }

        private void data1_SelectionChanged(object sender, EventArgs e)
        {
            if (data1.CurrentRow != null)
            {
                textName.Text = data1.CurrentRow.Cells[1].Value.ToString();
                textCost.Text = data1.CurrentRow.Cells[2].Value.ToString();
                textDesc.Text = data1.CurrentRow.Cells[3].Value.ToString();
            }
        }
    }
}
