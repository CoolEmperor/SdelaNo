using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using Тест_курсач.Master;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace СделаНо
{
    public partial class MasterForm : Form
    {
        private int selectId;
        private string fns1;
        private int idsotr;
        public MasterForm(string fns, int idsotr)
        {
            InitializeComponent();
            this.fns1 = fns;
            this.idsotr = idsotr;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        public void MainMaster_RowSelected(object sender, int selectId)
        {
            this.selectId = selectId; 
        }
        private void Master_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Здравствуйте, " + fns1);
            label3.Text = fns1;

            MainMaster spr = new MainMaster(this.idsotr);
            spr.RowSelected += MainMaster_RowSelected;
            Controler(spr);
            
            butBack.Visible = false;
        }
        public void Controler(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void butZakaz_Click(object sender, EventArgs e)
        {
            butBack.Visible = true;
            butZakaz.Visible = false;

            SelectZakaz selectZakaz = new SelectZakaz(this.selectId);

            Controler(selectZakaz);
        }

        private void butExit_Click(object sender, EventArgs e)
        {
			//Application.Exit();
			Authorization aut = new Authorization();
			aut.Show();
			this.Close();
		}

        private void butBack_Click(object sender, EventArgs e)
        {
            butBack.Visible = false;
            butZakaz.Visible = true;
            MainMaster spr = new MainMaster(this.idsotr);
            spr.RowSelected += MainMaster_RowSelected;
            Controler(spr);
        }
    }
}
