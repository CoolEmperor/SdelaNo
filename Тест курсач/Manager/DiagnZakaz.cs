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
    public partial class DiagnZakaz : UserControl
    {
        public DiagnZakaz()
        {
            InitializeComponent();
            butBack.Visible = false;
        }

        private void DiagnZakaz_Load(object sender, EventArgs e)
        {

        }

        private void butZakaz_Click(object sender, EventArgs e)
        {
            butBack.Visible = true;
            butZakaz.Visible = false;
        }

        private void butBack_Click(object sender, EventArgs e)
        {
            butBack.Visible = false;
            butZakaz.Visible = true;
        }
    }
}
