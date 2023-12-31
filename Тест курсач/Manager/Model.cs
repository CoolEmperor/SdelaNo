﻿using System;
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

namespace СделаНо
{
    public partial class Model : UserControl
    {
        string connectionString = ConfigurationManager.ConnectionStrings["Тест_курсач.Properties.Settings.СделаНоConnectionString"].ConnectionString;

        public Model()
        {
            InitializeComponent();
        }
        private void FillDataGridView()
        {
            string query = "SELECT * FROM Модель";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable table = new DataTable();
                adapter.Fill(table);
                data1.DataSource = table;
            }
        }
        private void ClearInputFields()
        {
            textName.Clear();
            textDesc.Clear();
        }
        private void butClear_Click(object sender, EventArgs e)
        {
            ClearInputFields();
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
            string desc = textDesc.Text;

            if(!IsValidText(desc))
            {
                MessageBox.Show("Описание должно начинаться с большой буквы и быть на русском языке.");
                return;
            }
            else
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("InsertModel", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@Название", name);
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
            if (string.IsNullOrWhiteSpace(textName.Text) || string.IsNullOrWhiteSpace(textDesc.Text))
            {
                MessageBox.Show("Пожалуйста, заполните все обязательные поля.");
                return;
            }

            string name = textName.Text;
            string desc = textDesc.Text;

            if(!IsValidText(desc))
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

                    using (SqlCommand command = new SqlCommand("UpdateModel", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@ИдТипа", selectedRowId);
                        command.Parameters.AddWithValue("@Название", name);
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
            int selectedModelId = (int)data1.CurrentRow.Cells[0].Value;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string checkQuery = "SELECT COUNT(*) FROM Вид_техники WHERE ИдМодели = @ИдМодели";

                using (SqlCommand checkCommand = new SqlCommand(checkQuery, connection))
                {
                    checkCommand.Parameters.AddWithValue("@ИдМодели", selectedModelId);

                    int count = (int)checkCommand.ExecuteScalar();

                    if (count > 0)
                    {
                        MessageBox.Show("Эта модель имеет зависимые данные и не может быть удалена.");
                    }
                    else
                    {
                        using (SqlCommand deleteCommand = new SqlCommand("DeleteModel", connection))
                        {
                            deleteCommand.CommandType = CommandType.StoredProcedure;
                            deleteCommand.Parameters.AddWithValue("@ИдМодели", selectedModelId);
                            deleteCommand.ExecuteNonQuery();
                        }

                        FillDataGridView();

                        MessageBox.Show("Данные удалены успешно.");
                    }
                }
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
                using (SqlCommand command = new SqlCommand("SortModel", connection))
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

        private void Model_Load(object sender, EventArgs e)
        {
            FillDataGridView();
        }

        private void data1_SelectionChanged(object sender, EventArgs e)
        {
            if (data1.CurrentRow != null)
            {
                textName.Text = data1.CurrentRow.Cells[1].Value.ToString();
                textDesc.Text = data1.CurrentRow.Cells[2].Value.ToString();
            }
        }

        private void textBoxFind_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string filterText = textBoxFind.Text;
                string findField = "Название";

                if (data1.DataSource is DataTable dataTable)
                {
                    if (!string.IsNullOrWhiteSpace(filterText))
                    {
                        dataTable.DefaultView.RowFilter = $"{findField} LIKE '{filterText}%'";
                    }
                    else
                    {
                        dataTable.DefaultView.RowFilter = string.Empty;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка фильтрации: {ex.Message}");
            }

        }
    }
}
