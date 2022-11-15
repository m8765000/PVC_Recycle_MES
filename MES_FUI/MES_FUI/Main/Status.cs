using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MES_FUI.Main
{
    public partial class Status : Form
    {
        public Status()
        {
            InitializeComponent();
        }

        private void btn_Main_Click(object sender, EventArgs e)
        {
            Main_Form main = new Main_Form();
            main.Owner = this;
            main.Show();
            this.Visible = false;
        }
    }
}
