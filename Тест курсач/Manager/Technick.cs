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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Тест_курсач.Manager
{
    public partial class Technick : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["Тест_курсач.Properties.Settings.СделаНоConnectionString"].ConnectionString;
        public delegate void TechnickIdEventHandler(int id);
        public event TechnickIdEventHandler TechnickIdSelected;
        private Guna2TextBox textTypeEq;
        public int id;
        public Technick(Guna2TextBox textTypeEq, int id)
        {
            this.textTypeEq = textTypeEq;
            this.id = id;
            InitializeComponent();
        }

        private void butSelect_Click(object sender, EventArgs e)
        {
            textTypeEq.Text = data1.CurrentRow.Cells[1].Value.ToString();
            id = Convert.ToInt32(data1.CurrentRow.Cells[0].Value.ToString());

            TechnickIdSelected?.Invoke(id);

            this.Close();
        }
        private void FillDataGridView()
        {
            string query = "SELECT * FROM ВидТехникиДляМенеджера";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable table = new DataTable();
                adapter.Fill(table);
                data1.DataSource = table;
            }
        }
        private void Technick_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "сделаНоDataSet.ВидТехникиДляМенеджера". При необходимости она может быть перемещена или удалена.
            this.видТехникиДляМенеджераTableAdapter.Fill(this.сделаНоDataSet.ВидТехникиДляМенеджера);
            FillDataGridView();
        }
    }
}
