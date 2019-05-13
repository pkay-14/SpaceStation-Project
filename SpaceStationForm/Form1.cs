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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            
            string firstname = txtFirstname.Text;
            string surnaeme = txtSurname.Text;
            string password = txtPassword.Text;

            string sm = txtPassword.Text;
            if (firstname != "Admin" && surnaeme != "User")
            {
                Functions function = new Functions();
                int reply = function.Login("Admin", "User", sm);
                if (reply == 1)
                {
                    WorkForm wf = new WorkForm();
                    wf.Show();
                    this.Hide();
                }
                else
                {
                    lblfeedbck.Show();
                    lblfeedbck.Text = "Invalid Login";
                }
            }
            else
            {
                lblfeedbck.Show();
                lblfeedbck.Text = "Cannot Login in as Admin";
            }
        
    }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            AccountInterface a1 = new AccountInterface();
            a1.Show();
        }
    }
}
