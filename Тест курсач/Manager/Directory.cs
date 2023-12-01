using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace СделаНо
{
    public partial class Directory : UserControl
    {
        public Directory()
        {
            InitializeComponent();
        }
        private void Controler(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }
        private void Spr1_Load(object sender, EventArgs e)
        {

        }

        private void butTech_Click(object sender, EventArgs e)
        {
            TypeEquipment spr = new TypeEquipment();
            Controler(spr);
        }

        private void butUs_Click(object sender, EventArgs e)
        {
            DeviceType spr = new DeviceType();
            Controler(spr);
        }

        private void butMod_Click(object sender, EventArgs e)
        {
            Model spr = new Model();
            Controler(spr);
        }

        private void butWork_Click(object sender, EventArgs e)
        {
            Work spr = new Work();
            Controler(spr);
        }

        private void butMat_Click(object sender, EventArgs e)
        {
            Material spr = new Material();
            Controler(spr);
        }

    }
}
