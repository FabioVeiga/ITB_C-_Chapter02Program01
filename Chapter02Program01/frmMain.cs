using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter02Program01
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        [STAThread]
        public static void Main()
        {
            frmMain main = new frmMain();
            Application.Run(main);
        }

        private void BtnDisplayOutput_Click(object sender, EventArgs e)
        {
            string buffer = "Mailing Label:" + Environment.NewLine + Environment.NewLine;
            buffer += "Name: " + txtName.Text + Environment.NewLine;
            buffer += "Address: " + txtAddress.Text + Environment.NewLine;
            buffer += "City: " + txtCity.Text + " State: " + txtState.Text + " Zip: " + txtZip.Text;
            txtDisplay.Text = buffer;
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
