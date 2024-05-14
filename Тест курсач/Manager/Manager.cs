using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Тест_курсач.Manager;

namespace СделаНо
{
    public partial class Manager : Form
    {
        private string fns1;
        public Manager(string fns)
        {
            InitializeComponent();
            fns1 = fns;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Здравствуйте, " + fns1);
            label3.Text = fns1;
        }

        private void Controler(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void butSpr_Click(object sender, EventArgs e)
        {
            Directory spr = new Directory();
            Controler(spr);
        }

        private void butNewZak_Click(object sender, EventArgs e)
        {
            NewZakaz spr = new NewZakaz();
            Controler(spr);
        }

        private void butZakDiag_Click(object sender, EventArgs e)
        {
            DiagnZakaz spr = new DiagnZakaz();
            Controler(spr);
        }

        private void butZakRep_Click(object sender, EventArgs e)
        {
            RepairZakaz spr = new RepairZakaz();
            Controler(spr);
        }


        private void butExit_Click(object sender, EventArgs e)
        {
			//Application.Exit();
			Authorization aut = new Authorization();
			aut.Show();
			this.Close();
		}

        private void butDel_Click(object sender, EventArgs e)
        {
            AcceptZakaz spr = new AcceptZakaz(fns1);
            Controler(spr);
        }

        private void Manager_Resize(object sender, EventArgs e)
        {

        }
    }
}
