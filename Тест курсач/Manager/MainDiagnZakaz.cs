using System;
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
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace Тест_курсач.Manager
{
    public partial class MainDiagnZakaz : UserControl
    {
        string connectionString = ConfigurationManager.ConnectionStrings["Тест_курсач.Properties.Settings.СделаНоConnectionString"].ConnectionString;

        public event EventHandler<int> RowSelected;
        public int selectId;
        public MainDiagnZakaz()
        {
            InitializeComponent();
            FillDataGridView();
        }
        private void FillDataGridView()
        {
            string query = $"SELECT * FROM ЗаказДляУчетаЗаказовНаДиагностику Where Статус = 'Диагностика окончена' OR Статус = 'На диагностике'";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable table = new DataTable();
                adapter.Fill(table);
                data1.DataSource = table;
            }
        }
        private void MainDiagnRepair_Load(object sender, EventArgs e)
        {

        }

        private void data1_SelectionChanged(object sender, EventArgs e)
        {
            if (data1.SelectedRows.Count > 0)
            {
                selectId = (int)data1.CurrentRow.Cells[0].Value;
                RowSelected?.Invoke(this, selectId);
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            string query = $"SELECT * FROM ЗаказДляУчетаЗаказовНаДиагностику Where Статус = 'Диагностика окончена' OR Статус = 'На диагностике'";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable table = new DataTable();
                adapter.Fill(table);
                data1.DataSource = table;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            string query = $"SELECT * FROM ЗаказДляУчетаЗаказовНаДиагностику WHERE Статус = 'На диагностике'";
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
            string query = $"SELECT * FROM ЗаказДляУчетаЗаказовНаДиагностику WHERE Статус = 'Диагностика окончена'";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable table = new DataTable();
                adapter.Fill(table);
                data1.DataSource = table;
            }
        }
    }
}
