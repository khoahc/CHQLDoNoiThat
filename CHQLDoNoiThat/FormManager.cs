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
    public partial class FormManager : Form
    {
        private Button currentButton;
        private Form activeForm;

        public FormManager()
        {
            InitializeComponent();
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.tableLayoutPanelDesktop.Controls.Add(childForm);
            this.tableLayoutPanelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitle.Text = childForm.Text;

        }

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = Color.FromArgb(152, 190, 240);
                }
            }
        }

        private void DisableButton()
        {
            foreach (Control previousBtn in tableLayoutPanelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.SteelBlue;
                }
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNhanVien_FManager_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new FormsManager.FormStaff(), sender);
        }

        private void btnKho_FManager_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new FormsManager.FormInventory(), sender);
        }

        private void btnLoaiSanPham_FManager_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new FormsManager.FormCategory(), sender);
        }

        private void btnSanPham_FManager_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new FormsManager.FormProduct(), sender);
        }

        private void btnTaoHoaDon_TManager_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new FormsManager.FormBill(), sender);
        }

        private void btnLichSuHoaDon_FManager_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new FormsManager.FormBillHistory(), sender);
        }

        private void tableLayoutPanelDesktop_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
