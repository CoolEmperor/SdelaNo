﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Тест_курсач.Manager
{
    public partial class SelectRepairZakaz : UserControl
    {

        string connectionString = ConfigurationManager.ConnectionStrings["Тест_курсач.Properties.Settings.СделаНоConnectionString"].ConnectionString;

        int selectId;
        public SelectRepairZakaz(int selectId)
        {
            InitializeComponent();
            this.selectId = selectId;
            FillDataGridView();
        }
        private void FillDataGridView()
        {
            string query = $"SELECT * FROM ЗаказДляУчетаЗаказовНаРемонт Where ИдЗаказа = {selectId}";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable table = new DataTable();
                adapter.Fill(table);
                data1.DataSource = table;
            }

            string query1 = $@"SELECT * FROM МатериалыДляМастера";

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
        private void SelectRepairZakaz_Load(object sender, EventArgs e)
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
                        if (status == "На ремонте")
                        {
                            butStart.Visible = false;
                            textDisc.Visible = false;
                            label1.Visible = false;
                        }
                    }
                }
            }
        }
        private bool IsValidDecimal(string input)
        {
            string pattern = @"^[-+]?\d*\.?\d+$";
            return Regex.IsMatch(input, pattern);
        }
        private void butStart_Click(object sender, EventArgs e)
        {
            string cost = textDisc.Text;
            if (!IsValidDecimal(cost))
            {
                MessageBox.Show("Скидка должен быть числовым значением (десятичные числа указываются точкой).");
                return;
            }
            if(Convert.ToInt32(cost) > 70)
            {
                MessageBox.Show("Скидка может быть максимум 70 процентов.");
                return;
            }
            
            string query = $"UPDATE Заказ SET Статус = 'Готов к выдаче', Скидка = {cost},Дата_конца = @CurrentDate WHERE ИдЗаказа = {selectId};";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                command.Parameters.AddWithValue("@CurrentDate", DateTime.Today);
                command.ExecuteNonQuery();
            }
            label1.Visible = false;
            textDisc.Visible = false;
            butStart.Visible = false;
            MessageBox.Show("Заказ готов к выдаче");
        }
    }
}
