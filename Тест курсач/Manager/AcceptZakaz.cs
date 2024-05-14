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
    public partial class AcceptZakaz : UserControl
    {
        private int selectId;
        string fio;

		public AcceptZakaz(string fio)
		{
			InitializeComponent();
			butBack.Visible = false;
			this.fio = fio;
		}
		private void Controler(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }
        private void MainAcceptZakaz_RowSelected(object sender, int selectId)
        {
            this.selectId = selectId;
        }
        private void butZakaz_Click(object sender, EventArgs e)
        {
            butBack.Visible = true;
            butZakaz.Visible = false;
            SelectAcceptZakaz spr = new SelectAcceptZakaz(this.selectId, fio);
            Controler(spr);
        }

        private void butBack_Click(object sender, EventArgs e)
        {
            butBack.Visible = false;
            butZakaz.Visible = true;
            MainAcceptZakaz spr = new MainAcceptZakaz();
            spr.RowSelected += MainAcceptZakaz_RowSelected;
            Controler(spr);
        }

        private void AcceptZakaz_Load(object sender, EventArgs e)
        {
            MainAcceptZakaz spr = new MainAcceptZakaz();
            spr.RowSelected += MainAcceptZakaz_RowSelected;
            Controler(spr);
        }
    }
}
