using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Тест_курсач
{
    public partial class Manager : Form
    {
        public Manager()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

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

        }

        private void butZakDiag_Click(object sender, EventArgs e)
        {

        }

        private void butZakRep_Click(object sender, EventArgs e)
        {

        }

        private void butDelZak_Click(object sender, EventArgs e)
        {

        }

        private void butExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
