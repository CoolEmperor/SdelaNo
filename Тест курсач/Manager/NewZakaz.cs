﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Тест_курсач.Manager
{
    public partial class NewZakaz : UserControl
    {
        string connectionString = "Data Source=DMITRYBUGAI-LAP\\SQLEXPRESS;Initial Catalog=СделаНо;Integrated Security=True";
        public NewZakaz()
        {
            InitializeComponent();
            FillComboMaster();
            FillComboTechnick();
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
        private void FillComboMaster()
        {
            string query = "SELECT ФИО, ИдСотрудника FROM Сотрудник WHERE Роль = 'Мастер'"; // SQL-запрос для выбора мастеров

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet, "Сотрудник");

                combomaster.DataSource = dataSet.Tables["Сотрудник"];
                combomaster.DisplayMember = "ФИО"; // Укажите имя поля, которое нужно отображать в комбо-боксе
                combomaster.ValueMember = "ИдСотрудника"; // Укажите имя поля, которое будет использоваться как значение
            }
        }
        private void FillComboTechnick()
        {
            string query = "SELECT Название, ИдВида FROM Вид_техники"; // SQL-запрос для выбора мастеров

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet, "Вид_техники");

                combotechnick.DataSource = dataSet.Tables["Вид_техники"];
                combotechnick.DisplayMember = "Название"; // Укажите имя поля, которое нужно отображать в комбо-боксе
                combotechnick.ValueMember = "ИдВида"; // Укажите имя поля, которое будет использоваться как значение
            }
        }
        private void butAcceptZakaz_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(textdate.Text) || string.IsNullOrWhiteSpace(combomaster.Text)
                        || string.IsNullOrWhiteSpace(combotechnick.Text) || string.IsNullOrWhiteSpace(textfio.Text)
                        || string.IsNullOrWhiteSpace(texttel.Text))
                {
                    MessageBox.Show("Пожалуйста, заполните все поля.");
                    return;
                }
                string date = textdate.Value.ToString();
                string master = combomaster.SelectedValue.ToString();
                string technic = combotechnick.SelectedValue.ToString();
                string FIO = textfio.Text;
                string tel = texttel.Text;

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

                        using (SqlCommand command = new SqlCommand("InsertZakaz", connection))
                        {
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.AddWithValue("@Дата", date);
                            command.Parameters.AddWithValue("@Мастер", master);
                            command.Parameters.AddWithValue("@ВидТехники", technic);
                            command.Parameters.AddWithValue("@ФИО", FIO);
                            command.Parameters.AddWithValue("@Телефон", tel);
                            command.Parameters.AddWithValue("@Статус", "На диагностике");

                            command.ExecuteNonQuery();
                        }

                        MessageBox.Show("Данные добавлены успешно.");
                    }
                }
                
                textfio.Clear();
                texttel.Clear();

            }
            catch (System.Data.SqlClient.SqlException)
            {
                MessageBox.Show("Заказ не может быть добавление!!!",
               "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void NewZakaz_Load(object sender, EventArgs e)
        {

        }
    }
}
