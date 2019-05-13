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
    public partial class AdminLogin : Form1
    {
        public AdminLogin()
        {
            InitializeComponent();

        }

        private void AdminLogin_Load(object sender, EventArgs e)
        {


        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string sm = txtPassword.Text;

            Functions function = new Functions();
             function.Login("Admin", "User", sm);
            //if (reply == 1)
            //{
            //    //WorkForm wf = new WorkForm();
            //    //wf.Show();
            //    this.Hide();
            //}
            //else
            //    //{
            //    lblfbck.Show();
            //lblfbck.Text = "Invalid Login";
        }
    }
    }


