using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Тест_курсач.Master;

namespace Тест_курсач.Manager
{
    public partial class DiagnZakaz : UserControl
    {
        private int selectId;
        public DiagnZakaz()
        {
            InitializeComponent();
            butBack.Visible = false;
        }
        
        private void Controler(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }
        private void MainDiagnZakaz_RowSelected(object sender, int selectId)
        {
            this.selectId = selectId;
        }
        private void DiagnZakaz_Load(object sender, EventArgs e)
        {
            MainDiagnZakaz spr = new MainDiagnZakaz();
            
            spr.RowSelected += MainDiagnZakaz_RowSelected;
            Controler(spr);
        }

        private void butZakaz_Click(object sender, EventArgs e)
        {
            butBack.Visible = true;
            butZakaz.Visible = false;
            SelectDiagnZakaz spr = new SelectDiagnZakaz(this.selectId);
            Controler(spr);
        }

        private void butBack_Click(object sender, EventArgs e)
        {
            butBack.Visible = false;
            butZakaz.Visible = true;
            MainDiagnZakaz spr = new MainDiagnZakaz();
            spr.RowSelected += MainDiagnZakaz_RowSelected;
            Controler(spr);
        }
    }
}
