namespace SpaceStationForm
{
    partial class AdminLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblfbck = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblfirsname
            // 
            this.lblfirsname.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfirsname.Location = new System.Drawing.Point(217, 126);
            this.lblfirsname.Size = new System.Drawing.Size(175, 36);
            this.lblfirsname.Text = "Admin User";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(333, 60);
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(71, 200);
            // 
            // txtFirstname
            // 
            this.txtFirstname.Location = new System.Drawing.Point(465, 26);
            this.txtFirstname.Visible = false;
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(465, 58);
            this.txtSurname.Visible = false;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(203, 198);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(111, 298);
            this.btnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(380, 298);
            // 
            // lblfbck
            // 
            this.lblfbck.AutoSize = true;
            this.lblfbck.BackColor = System.Drawing.Color.Honeydew;
            this.lblfbck.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfbck.ForeColor = System.Drawing.Color.Red;
            this.lblfbck.Location = new System.Drawing.Point(237, 9);
            this.lblfbck.Name = "lblfbck";
            this.lblfbck.Size = new System.Drawing.Size(0, 36);
            this.lblfbck.TabIndex = 9;
            this.lblfbck.Visible = false;
            // 
            // AdminLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 484);
            this.Controls.Add(this.lblfbck);
            this.MaximizeBox = false;
            this.Name = "AdminLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Space Station";
            this.Load += new System.EventHandler(this.AdminLogin_Load);
            this.Controls.SetChildIndex(this.lblfirsname, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txtFirstname, 0);
            this.Controls.SetChildIndex(this.lblHead, 0);
            this.Controls.SetChildIndex(this.txtSurname, 0);
            this.Controls.SetChildIndex(this.txtPassword, 0);
            this.Controls.SetChildIndex(this.btnLogin, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.lblfbck, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblfbck;
    }
}