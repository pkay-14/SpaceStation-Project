using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpaceStationForm
{
    public partial class AccountInterface : Form
    {
        public AccountInterface()
        {
            InitializeComponent();
        }

        private void BtnEmployee_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
           
        }

        private void BtnAdmin_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminLogin a1 = new AdminLogin();
            a1.Show();
            
        }
    }
}
