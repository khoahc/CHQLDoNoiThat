using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CHQLDoNoiThat
{
    public partial class LoginForm : Form
    {
        private FormHomeStaff formHomeStaff;

        public LoginForm()
        {
            InitializeComponent();
        }
        private void btnLogin_MouseHover(object sender, EventArgs e)
        {
            btnLogin.BackColor = System.Drawing.Color.DodgerBlue;
        }


        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Close_MouseHover(object sender, EventArgs e)
        {
            btnClose.ForeColor = System.Drawing.Color.Red;
        }

        private void Close_MouseLeave(object sender, EventArgs e)
        {
            btnClose.ForeColor = System.Drawing.Color.White;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            
            formHomeStaff = new FormHomeStaff();
            formHomeStaff.Show();
            this.Hide();
        }
    }
}
