
namespace CHQLDoNoiThat.FormsManager
{
    partial class FormCategory
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.dataGridViewChiTietHoaDon = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtIdLoaiSanPham = new CHQLDoNoiThat.CustomControls.TextBoxControl();
            this.lblIdLoaiSanPham = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTenLoaiSanPham = new CHQLDoNoiThat.CustomControls.TextBoxControl();
            this.btnThem_LoaiSanPham = new System.Windows.Forms.Button();
            this.btnSua_LoaiSanPham = new System.Windows.Forms.Button();
            this.btnXoa_LoaiSanPham = new System.Windows.Forms.Button();
            this.elipseControl1 = new ElipseToolDemo.ElipseControl();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChiTietHoaDon)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel12, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 760F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1040, 760);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.label11);
            this.panel12.Controls.Add(this.dataGridViewChiTietHoaDon);
            this.panel12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel12.Location = new System.Drawing.Point(523, 3);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(514, 754);
            this.panel12.TabIndex = 39;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.SteelBlue;
            this.label11.Location = new System.Drawing.Point(15, 30);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(481, 28);
            this.label11.TabIndex = 22;
            this.label11.Text = "Danh sách loại sản phẩm";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dataGridViewChiTietHoaDon
            // 
            this.dataGridViewChiTietHoaDon.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewChiTietHoaDon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewChiTietHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewChiTietHoaDon.Location = new System.Drawing.Point(12, 83);
            this.dataGridViewChiTietHoaDon.Name = "dataGridViewChiTietHoaDon";
            this.dataGridViewChiTietHoaDon.RowHeadersWidth = 51;
            this.dataGridViewChiTietHoaDon.RowTemplate.Height = 24;
            this.dataGridViewChiTietHoaDon.Size = new System.Drawing.Size(484, 620);
            this.dataGridViewChiTietHoaDon.TabIndex = 21;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.btnXoa_LoaiSanPham);
            this.panel3.Controls.Add(this.btnSua_LoaiSanPham);
            this.panel3.Controls.Add(this.btnThem_LoaiSanPham);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.txtTenLoaiSanPham);
            this.panel3.Controls.Add(this.lblIdLoaiSanPham);
            this.panel3.Controls.Add(this.txtIdLoaiSanPham);
            this.panel3.Location = new System.Drawing.Point(5, 192);
            this.panel3.Margin = new System.Windows.Forms.Padding(5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(510, 376);
            this.panel3.TabIndex = 5;
            // 
            // txtIdLoaiSanPham
            // 
            this.txtIdLoaiSanPham.BorderColor = System.Drawing.Color.SteelBlue;
            this.txtIdLoaiSanPham.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtIdLoaiSanPham.BorderSize = 2;
            this.txtIdLoaiSanPham.Location = new System.Drawing.Point(228, 49);
            this.txtIdLoaiSanPham.Multiline = false;
            this.txtIdLoaiSanPham.Name = "txtIdLoaiSanPham";
            this.txtIdLoaiSanPham.Padding = new System.Windows.Forms.Padding(7);
            this.txtIdLoaiSanPham.PasswordChar = false;
            this.txtIdLoaiSanPham.Size = new System.Drawing.Size(250, 32);
            this.txtIdLoaiSanPham.TabIndex = 0;
            this.txtIdLoaiSanPham.Texts = "";
            this.txtIdLoaiSanPham.UnderlinedStyle = true;
            // 
            // lblIdLoaiSanPham
            // 
            this.lblIdLoaiSanPham.AutoSize = true;
            this.lblIdLoaiSanPham.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdLoaiSanPham.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblIdLoaiSanPham.Location = new System.Drawing.Point(23, 53);
            this.lblIdLoaiSanPham.Name = "lblIdLoaiSanPham";
            this.lblIdLoaiSanPham.Size = new System.Drawing.Size(163, 28);
            this.lblIdLoaiSanPham.TabIndex = 8;
            this.lblIdLoaiSanPham.Text = "Id loại sản phẩm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(23, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 28);
            this.label1.TabIndex = 10;
            this.label1.Text = "Tên loại sản phẩm";
            // 
            // txtTenLoaiSanPham
            // 
            this.txtTenLoaiSanPham.BorderColor = System.Drawing.Color.SteelBlue;
            this.txtTenLoaiSanPham.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtTenLoaiSanPham.BorderSize = 2;
            this.txtTenLoaiSanPham.Location = new System.Drawing.Point(228, 149);
            this.txtTenLoaiSanPham.Multiline = false;
            this.txtTenLoaiSanPham.Name = "txtTenLoaiSanPham";
            this.txtTenLoaiSanPham.Padding = new System.Windows.Forms.Padding(7);
            this.txtTenLoaiSanPham.PasswordChar = false;
            this.txtTenLoaiSanPham.Size = new System.Drawing.Size(250, 32);
            this.txtTenLoaiSanPham.TabIndex = 9;
            this.txtTenLoaiSanPham.Texts = "";
            this.txtTenLoaiSanPham.UnderlinedStyle = true;
            // 
            // btnThem_LoaiSanPham
            // 
            this.btnThem_LoaiSanPham.AutoSize = true;
            this.btnThem_LoaiSanPham.BackColor = System.Drawing.Color.SteelBlue;
            this.btnThem_LoaiSanPham.FlatAppearance.BorderSize = 0;
            this.btnThem_LoaiSanPham.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem_LoaiSanPham.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem_LoaiSanPham.ForeColor = System.Drawing.Color.White;
            this.btnThem_LoaiSanPham.Location = new System.Drawing.Point(28, 246);
            this.btnThem_LoaiSanPham.Margin = new System.Windows.Forms.Padding(0);
            this.btnThem_LoaiSanPham.Name = "btnThem_LoaiSanPham";
            this.btnThem_LoaiSanPham.Size = new System.Drawing.Size(120, 40);
            this.btnThem_LoaiSanPham.TabIndex = 19;
            this.btnThem_LoaiSanPham.TabStop = false;
            this.btnThem_LoaiSanPham.Text = "Thêm";
            this.btnThem_LoaiSanPham.UseVisualStyleBackColor = false;
            // 
            // btnSua_LoaiSanPham
            // 
            this.btnSua_LoaiSanPham.AutoSize = true;
            this.btnSua_LoaiSanPham.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSua_LoaiSanPham.FlatAppearance.BorderSize = 0;
            this.btnSua_LoaiSanPham.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua_LoaiSanPham.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua_LoaiSanPham.ForeColor = System.Drawing.Color.White;
            this.btnSua_LoaiSanPham.Location = new System.Drawing.Point(184, 246);
            this.btnSua_LoaiSanPham.Margin = new System.Windows.Forms.Padding(0);
            this.btnSua_LoaiSanPham.Name = "btnSua_LoaiSanPham";
            this.btnSua_LoaiSanPham.Size = new System.Drawing.Size(120, 40);
            this.btnSua_LoaiSanPham.TabIndex = 20;
            this.btnSua_LoaiSanPham.TabStop = false;
            this.btnSua_LoaiSanPham.Text = "Sửa";
            this.btnSua_LoaiSanPham.UseVisualStyleBackColor = false;
            // 
            // btnXoa_LoaiSanPham
            // 
            this.btnXoa_LoaiSanPham.AutoSize = true;
            this.btnXoa_LoaiSanPham.BackColor = System.Drawing.Color.SteelBlue;
            this.btnXoa_LoaiSanPham.FlatAppearance.BorderSize = 0;
            this.btnXoa_LoaiSanPham.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa_LoaiSanPham.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa_LoaiSanPham.ForeColor = System.Drawing.Color.White;
            this.btnXoa_LoaiSanPham.Location = new System.Drawing.Point(338, 246);
            this.btnXoa_LoaiSanPham.Margin = new System.Windows.Forms.Padding(0);
            this.btnXoa_LoaiSanPham.Name = "btnXoa_LoaiSanPham";
            this.btnXoa_LoaiSanPham.Size = new System.Drawing.Size(120, 40);
            this.btnXoa_LoaiSanPham.TabIndex = 21;
            this.btnXoa_LoaiSanPham.TabStop = false;
            this.btnXoa_LoaiSanPham.Text = "Xóa";
            this.btnXoa_LoaiSanPham.UseVisualStyleBackColor = false;
            // 
            // elipseControl1
            // 
            this.elipseControl1.CornerRadius = 30;
            this.elipseControl1.TargetControl = this;
            // 
            // FormCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1040, 760);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCategory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loại sản phẩm";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChiTietHoaDon)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dataGridViewChiTietHoaDon;
        private CustomControls.TextBoxControl txtIdLoaiSanPham;
        private System.Windows.Forms.Label lblIdLoaiSanPham;
        private System.Windows.Forms.Label label1;
        private CustomControls.TextBoxControl txtTenLoaiSanPham;
        private System.Windows.Forms.Button btnXoa_LoaiSanPham;
        private System.Windows.Forms.Button btnSua_LoaiSanPham;
        private System.Windows.Forms.Button btnThem_LoaiSanPham;
        private ElipseToolDemo.ElipseControl elipseControl1;
    }
}