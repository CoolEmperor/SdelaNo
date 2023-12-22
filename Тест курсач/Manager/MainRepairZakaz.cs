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

namespace Тест_курсач.Manager
{
    public partial class MainRepairZakaz : UserControl
    {
        string connectionString = ConfigurationManager.ConnectionStrings["Тест_курсач.Properties.Settings.СделаНоConnectionString"].ConnectionString;

        public event EventHandler<int> RowSelected;
        public int selectId;
        public MainRepairZakaz()
        {
            InitializeComponent();
            FillDataGridView();
        }
        private void FillDataGridView()
        {
            string query = $"SELECT * FROM ЗаказДляУчетаЗаказовНаРемонт Where Статус = 'Ремонт окончен' OR Статус = 'На ремонте'";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable table = new DataTable();
                adapter.Fill(table);
                data1.DataSource = table;
            }
        }

        private void MainRepairZakaz_Load(object sender, EventArgs e)
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
    }
}
