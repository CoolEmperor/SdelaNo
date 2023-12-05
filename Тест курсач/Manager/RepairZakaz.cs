using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Тест_курсач.Manager
{
    public partial class RepairZakaz : UserControl
    {
        private int selectId;
        public RepairZakaz()
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
        private void MainRepairZakaz_RowSelected(object sender, int selectId)
        {
            this.selectId = selectId;
        }
        private void butBack_Click(object sender, EventArgs e)
        {
            butBack.Visible = false;
            butZakaz.Visible = true;
            MainRepairZakaz spr = new MainRepairZakaz();
            spr.RowSelected += MainRepairZakaz_RowSelected;
            Controler(spr);
        }

        private void butZakaz_Click(object sender, EventArgs e)
        {
            butBack.Visible = true;
            butZakaz.Visible = false;
            SelectRepairZakaz spr = new SelectRepairZakaz(this.selectId);
            Controler(spr);
        }

        private void RepairZakaz_Load(object sender, EventArgs e)
        {
            MainRepairZakaz spr = new MainRepairZakaz();

            spr.RowSelected += MainRepairZakaz_RowSelected;
            Controler(spr);
        }

        private void panelContainer_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
