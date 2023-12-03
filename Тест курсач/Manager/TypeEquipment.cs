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
    public partial class TypeEquipment : UserControl
    {
        string connectionString = "Data Source=DMITRYBUGAI-LAP\\SQLEXPRESS;Initial Catalog=СделаНо;Integrated Security=True";

        public TypeEquipment()
        {
            InitializeComponent();
        }

        private void TypeEquipment_Load(object sender, EventArgs e)
        {
            FillDataGridView();
            FillComboType();
            FillComboModel();
        }
        private void FillDataGridView()
        {
            string query = "SELECT * FROM ВидТехникиДляМенеджера";
            //string query = "SELECT * FROM [Вид_техники]";
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
        private bool IsValidName(string name)
        {
            string pattern = @"^[А-Я][а-я]+$";
            return Regex.IsMatch(name, pattern);
        }
        private bool IsValidText(string name)
        {
            string pattern = @"^[А-ЯЁ][а-яё\s,]+$";
            return Regex.IsMatch(name, pattern);
        }
        private void butAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textName.Text) || string.IsNullOrWhiteSpace(textDesc.Text)
                || string.IsNullOrWhiteSpace(comboModel.Text) || string.IsNullOrWhiteSpace(comboType.Text))
            {
                MessageBox.Show("Пожалуйста, заполните все обязательные поля.");
                return;
            }

            string name = textName.Text;
            string desc = textDesc.Text;
            string type = comboType.SelectedValue.ToString();
            string model = comboModel.SelectedValue.ToString();

            if (!IsValidName(name))
            {
                MessageBox.Show("Название должно начинаться с большой буквы и быть на русском языке.");
                return;
            }
            if (!IsValidText(desc))
            {
                MessageBox.Show("Описание должно начинаться с большой буквы и быть на русском языке.");
                return;
            }
            else
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("InsertTypeOfEquipment", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@Название", name);
                        command.Parameters.AddWithValue("@Описание", desc);
                        command.Parameters.AddWithValue("@ИдТипа", type);
                        command.Parameters.AddWithValue("@ИдМодели", model);

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
            string name = textName.Text;
            string desc = textDesc.Text;
            string type = comboType.SelectedValue.ToString();
            string model = comboModel.SelectedValue.ToString();

            if (!IsValidName(name))
            {
                MessageBox.Show("Название должно начинаться с большой буквы и быть на русском языке.");
                return;
            }
            if (!IsValidText(desc))
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

                    using (SqlCommand command = new SqlCommand("UpdateTypeOfEquipment", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@ИдВида", selectedRowId);
                        command.Parameters.AddWithValue("@Название", name);
                        command.Parameters.AddWithValue("@Описание", desc);
                        command.Parameters.AddWithValue("@ИдТипа", type);
                        command.Parameters.AddWithValue("@ИдМодели", model);

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

                using (SqlCommand command = new SqlCommand("DeleteTypeOfEquipment", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@ИдВида", selectedEmployeeId);
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
                using (SqlCommand command = new SqlCommand("SortTypeOfEquipment", connection))
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

        private void data1_SelectionChanged(object sender, EventArgs e)
        {
            int selectedEmployeeId;
            if (data1.CurrentRow != null && data1.CurrentRow.Cells[3].Value != null)
            {
                selectedEmployeeId = Convert.ToInt32(data1.CurrentRow.Cells[0].Value);

                textName.Text = data1.CurrentRow.Cells[1].Value.ToString();
                textDesc.Text = data1.CurrentRow.Cells[2].Value.ToString();
                comboType.Text = data1.CurrentRow.Cells[3].Value.ToString();
                comboModel.Text = data1.CurrentRow.Cells[4].Value.ToString();
            }
        }
        private void FillComboModel()
        {
            string query = "SELECT Название, ИдМодели FROM Модель"; // SQL-запрос для выбора мастеров

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet, "Модель");

                comboModel.DataSource = dataSet.Tables["Модель"];
                comboModel.DisplayMember = "Название"; // Укажите имя поля, которое нужно отображать в комбо-боксе
                comboModel.ValueMember = "ИдМодели"; // Укажите имя поля, которое будет использоваться как значение
            }
        }
        private void FillComboType()
        {
            string query = "SELECT Название, ИдТипа FROM Тип_устройства"; // SQL-запрос для выбора мастеров

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet, "Тип_устройства");

                comboType.DataSource = dataSet.Tables["Тип_устройства"];
                comboType.DisplayMember = "Название"; // Укажите имя поля, которое нужно отображать в комбо-боксе
                comboType.ValueMember = "ИдТипа"; // Укажите имя поля, которое будет использоваться как значение
            }
        }

        private void textBoxFind_TextChanged(object sender, EventArgs e)
        {
            string filterText = textBoxFind.Text;
            string findField = "Название";

            if (!string.IsNullOrWhiteSpace(filterText))
            {
                видТехникиДляМенеджераBindingSource.Filter = $"{findField} LIKE '{filterText}%'";
            }
            else
            {
                видТехникиДляМенеджераBindingSource.RemoveFilter(); // Очищаем фильтр, если строка поиска пуста
            }
        }
    }
}
