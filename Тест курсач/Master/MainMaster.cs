﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Тест_курсач.Master
{
    public partial class MainMaster : UserControl
    {
        int idsotr;
        public int selectId;
        public event EventHandler<int> RowSelected;
        string connectionString = ConfigurationManager.ConnectionStrings["Тест_курсач.Properties.Settings.СделаНоConnectionString"].ConnectionString;

        public MainMaster(int idsotr)
        {
            InitializeComponent();
            this.idsotr = idsotr;
            FillDataGridView();
        }
        private void FillDataGridView()
        {
            string query = $"SELECT * FROM ЗаказДляМастера WHERE ИдСотрудника = {idsotr} AND Статус NOT IN ('Выдан', 'Готов к выдаче')";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable table = new DataTable();
                adapter.Fill(table);
                data1.DataSource = table;
            }
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            FillDataGridView();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            string query = $"SELECT * FROM ЗаказДляМастера WHERE Статус = 'На диагностике' And ИдСотрудника = {idsotr}";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable table = new DataTable();
                adapter.Fill(table);
                data1.DataSource = table;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            string query = $"SELECT * FROM ЗаказДляМастера WHERE Статус = 'На ремонте' And ИдСотрудника = {idsotr}";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable table = new DataTable();
                adapter.Fill(table);
                data1.DataSource = table;
            }
        }

        private void MainMaster_Load(object sender, EventArgs e)
        {
            FillDataGridView();
        }
        
        private void data1_SelectionChanged(object sender, EventArgs e)
        {
            if (data1.SelectedRows.Count > 0)
            {
                selectId = (int)data1.CurrentRow.Cells[0].Value;
                RowSelected?.Invoke(this, selectId);
            }
        }
    }
}
