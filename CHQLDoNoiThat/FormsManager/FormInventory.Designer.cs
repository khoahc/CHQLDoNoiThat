
namespace CHQLDoNoiThat.FormsManager
{
    partial class FormInventory
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
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.txtGiaGoc = new CHQLDoNoiThat.CustomControls.TextBoxControl();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtId = new CHQLDoNoiThat.CustomControls.TextBoxControl();
            this.btnXoa_LoaiSanPham = new System.Windows.Forms.Button();
            this.btnSua_LoaiSanPham = new System.Windows.Forms.Button();
            this.btnThem_LoaiSanPham = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTenSanPham = new CHQLDoNoiThat.CustomControls.TextBoxControl();
            this.lblIdLoaiSanPham = new System.Windows.Forms.Label();
            this.txtSanPham = new CHQLDoNoiThat.CustomControls.TextBoxControl();
            this.textBoxControl1 = new CHQLDoNoiThat.CustomControls.TextBoxControl();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxControl4 = new CHQLDoNoiThat.CustomControls.TextBoxControl();
            this.datePickerControl1 = new CHQLDoNoiThat.DatePickerControl();
            this.cmbHoatDong = new CHQLDoNoiThat.ComboBoxControl();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.SteelBlue;
            this.label6.Location = new System.Drawing.Point(342, 306);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(344, 37);
            this.label6.TabIndex = 14;
            this.label6.Text = "Danh sách sản phẩm trong kho";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(14, 346);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(994, 345);
            this.dataGridView1.TabIndex = 13;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.cmbHoatDong);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.datePickerControl1);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.textBoxControl4);
            this.panel3.Controls.Add(this.textBoxControl1);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.txtGiaGoc);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.txtId);
            this.panel3.Controls.Add(this.btnXoa_LoaiSanPham);
            this.panel3.Controls.Add(this.btnSua_LoaiSanPham);
            this.panel3.Controls.Add(this.btnThem_LoaiSanPham);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.txtTenSanPham);
            this.panel3.Controls.Add(this.lblIdLoaiSanPham);
            this.panel3.Controls.Add(this.txtSanPham);
            this.panel3.Location = new System.Drawing.Point(14, 21);
            this.panel3.Margin = new System.Windows.Forms.Padding(5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(994, 280);
            this.panel3.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.SteelBlue;
            this.label5.Location = new System.Drawing.Point(328, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 28);
            this.label5.TabIndex = 29;
            this.label5.Text = "Lợi nhuận";
            // 
            // txtGiaGoc
            // 
            this.txtGiaGoc.BorderColor = System.Drawing.Color.SteelBlue;
            this.txtGiaGoc.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtGiaGoc.BorderSize = 2;
            this.txtGiaGoc.Location = new System.Drawing.Point(437, 10);
            this.txtGiaGoc.Multiline = false;
            this.txtGiaGoc.Name = "txtGiaGoc";
            this.txtGiaGoc.Padding = new System.Windows.Forms.Padding(7);
            this.txtGiaGoc.PasswordChar = false;
            this.txtGiaGoc.Size = new System.Drawing.Size(145, 32);
            this.txtGiaGoc.TabIndex = 27;
            this.txtGiaGoc.Texts = "";
            this.txtGiaGoc.UnderlinedStyle = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SteelBlue;
            this.label3.Location = new System.Drawing.Point(328, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 28);
            this.label3.TabIndex = 26;
            this.label3.Text = "Giá gốc";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SteelBlue;
            this.label2.Location = new System.Drawing.Point(14, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 28);
            this.label2.TabIndex = 23;
            this.label2.Text = "Id";
            // 
            // txtId
            // 
            this.txtId.BorderColor = System.Drawing.Color.SteelBlue;
            this.txtId.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtId.BorderSize = 2;
            this.txtId.Location = new System.Drawing.Point(159, 10);
            this.txtId.Multiline = false;
            this.txtId.Name = "txtId";
            this.txtId.Padding = new System.Windows.Forms.Padding(7);
            this.txtId.PasswordChar = false;
            this.txtId.Size = new System.Drawing.Size(162, 32);
            this.txtId.TabIndex = 22;
            this.txtId.Texts = "";
            this.txtId.UnderlinedStyle = true;
            // 
            // btnXoa_LoaiSanPham
            // 
            this.btnXoa_LoaiSanPham.AutoSize = true;
            this.btnXoa_LoaiSanPham.BackColor = System.Drawing.Color.SteelBlue;
            this.btnXoa_LoaiSanPham.FlatAppearance.BorderSize = 0;
            this.btnXoa_LoaiSanPham.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa_LoaiSanPham.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa_LoaiSanPham.ForeColor = System.Drawing.Color.White;
            this.btnXoa_LoaiSanPham.Location = new System.Drawing.Point(691, 211);
            this.btnXoa_LoaiSanPham.Margin = new System.Windows.Forms.Padding(0);
            this.btnXoa_LoaiSanPham.Name = "btnXoa_LoaiSanPham";
            this.btnXoa_LoaiSanPham.Size = new System.Drawing.Size(105, 40);
            this.btnXoa_LoaiSanPham.TabIndex = 21;
            this.btnXoa_LoaiSanPham.TabStop = false;
            this.btnXoa_LoaiSanPham.Text = "Xóa";
            this.btnXoa_LoaiSanPham.UseVisualStyleBackColor = false;
            // 
            // btnSua_LoaiSanPham
            // 
            this.btnSua_LoaiSanPham.AutoSize = true;
            this.btnSua_LoaiSanPham.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSua_LoaiSanPham.FlatAppearance.BorderSize = 0;
            this.btnSua_LoaiSanPham.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua_LoaiSanPham.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua_LoaiSanPham.ForeColor = System.Drawing.Color.White;
            this.btnSua_LoaiSanPham.Location = new System.Drawing.Point(456, 211);
            this.btnSua_LoaiSanPham.Margin = new System.Windows.Forms.Padding(0);
            this.btnSua_LoaiSanPham.Name = "btnSua_LoaiSanPham";
            this.btnSua_LoaiSanPham.Size = new System.Drawing.Size(107, 40);
            this.btnSua_LoaiSanPham.TabIndex = 20;
            this.btnSua_LoaiSanPham.TabStop = false;
            this.btnSua_LoaiSanPham.Text = "Sửa";
            this.btnSua_LoaiSanPham.UseVisualStyleBackColor = false;
            // 
            // btnThem_LoaiSanPham
            // 
            this.btnThem_LoaiSanPham.AutoSize = true;
            this.btnThem_LoaiSanPham.BackColor = System.Drawing.Color.SteelBlue;
            this.btnThem_LoaiSanPham.FlatAppearance.BorderSize = 0;
            this.btnThem_LoaiSanPham.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem_LoaiSanPham.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem_LoaiSanPham.ForeColor = System.Drawing.Color.White;
            this.btnThem_LoaiSanPham.Location = new System.Drawing.Point(218, 211);
            this.btnThem_LoaiSanPham.Margin = new System.Windows.Forms.Padding(0);
            this.btnThem_LoaiSanPham.Name = "btnThem_LoaiSanPham";
            this.btnThem_LoaiSanPham.Size = new System.Drawing.Size(103, 40);
            this.btnThem_LoaiSanPham.TabIndex = 19;
            this.btnThem_LoaiSanPham.TabStop = false;
            this.btnThem_LoaiSanPham.Text = "Thêm";
            this.btnThem_LoaiSanPham.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(14, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 28);
            this.label1.TabIndex = 10;
            this.label1.Text = "Số lượng";
            // 
            // txtTenSanPham
            // 
            this.txtTenSanPham.BorderColor = System.Drawing.Color.SteelBlue;
            this.txtTenSanPham.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtTenSanPham.BorderSize = 2;
            this.txtTenSanPham.Location = new System.Drawing.Point(159, 121);
            this.txtTenSanPham.Multiline = false;
            this.txtTenSanPham.Name = "txtTenSanPham";
            this.txtTenSanPham.Padding = new System.Windows.Forms.Padding(7);
            this.txtTenSanPham.PasswordChar = false;
            this.txtTenSanPham.Size = new System.Drawing.Size(162, 32);
            this.txtTenSanPham.TabIndex = 9;
            this.txtTenSanPham.Texts = "";
            this.txtTenSanPham.UnderlinedStyle = true;
            // 
            // lblIdLoaiSanPham
            // 
            this.lblIdLoaiSanPham.AutoSize = true;
            this.lblIdLoaiSanPham.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdLoaiSanPham.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblIdLoaiSanPham.Location = new System.Drawing.Point(14, 69);
            this.lblIdLoaiSanPham.Name = "lblIdLoaiSanPham";
            this.lblIdLoaiSanPham.Size = new System.Drawing.Size(139, 28);
            this.lblIdLoaiSanPham.TabIndex = 8;
            this.lblIdLoaiSanPham.Text = "Tên sản phẩm";
            // 
            // txtSanPham
            // 
            this.txtSanPham.BorderColor = System.Drawing.Color.SteelBlue;
            this.txtSanPham.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtSanPham.BorderSize = 2;
            this.txtSanPham.Location = new System.Drawing.Point(159, 65);
            this.txtSanPham.Multiline = false;
            this.txtSanPham.Name = "txtSanPham";
            this.txtSanPham.Padding = new System.Windows.Forms.Padding(7);
            this.txtSanPham.PasswordChar = false;
            this.txtSanPham.Size = new System.Drawing.Size(162, 32);
            this.txtSanPham.TabIndex = 0;
            this.txtSanPham.Texts = "";
            this.txtSanPham.UnderlinedStyle = true;
            // 
            // textBoxControl1
            // 
            this.textBoxControl1.BorderColor = System.Drawing.Color.SteelBlue;
            this.textBoxControl1.BorderFocusColor = System.Drawing.Color.HotPink;
            this.textBoxControl1.BorderSize = 2;
            this.textBoxControl1.Location = new System.Drawing.Point(437, 66);
            this.textBoxControl1.Multiline = false;
            this.textBoxControl1.Name = "textBoxControl1";
            this.textBoxControl1.Padding = new System.Windows.Forms.Padding(7);
            this.textBoxControl1.PasswordChar = false;
            this.textBoxControl1.Size = new System.Drawing.Size(145, 32);
            this.textBoxControl1.TabIndex = 30;
            this.textBoxControl1.Texts = "";
            this.textBoxControl1.UnderlinedStyle = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.SteelBlue;
            this.label8.Location = new System.Drawing.Point(328, 129);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 28);
            this.label8.TabIndex = 34;
            this.label8.Text = "Vat";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.SteelBlue;
            this.label9.Location = new System.Drawing.Point(595, 14);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 28);
            this.label9.TabIndex = 32;
            this.label9.Text = "Ngày nhập";
            // 
            // textBoxControl4
            // 
            this.textBoxControl4.BorderColor = System.Drawing.Color.SteelBlue;
            this.textBoxControl4.BorderFocusColor = System.Drawing.Color.HotPink;
            this.textBoxControl4.BorderSize = 2;
            this.textBoxControl4.Location = new System.Drawing.Point(437, 121);
            this.textBoxControl4.Multiline = false;
            this.textBoxControl4.Name = "textBoxControl4";
            this.textBoxControl4.Padding = new System.Windows.Forms.Padding(7);
            this.textBoxControl4.PasswordChar = false;
            this.textBoxControl4.Size = new System.Drawing.Size(145, 32);
            this.textBoxControl4.TabIndex = 31;
            this.textBoxControl4.Texts = "";
            this.textBoxControl4.UnderlinedStyle = true;
            // 
            // datePickerControl1
            // 
            this.datePickerControl1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.datePickerControl1.BorderSize = 0;
            this.datePickerControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.datePickerControl1.Location = new System.Drawing.Point(712, 14);
            this.datePickerControl1.MinimumSize = new System.Drawing.Size(0, 35);
            this.datePickerControl1.Name = "datePickerControl1";
            this.datePickerControl1.Size = new System.Drawing.Size(257, 35);
            this.datePickerControl1.SkinColor = System.Drawing.Color.SteelBlue;
            this.datePickerControl1.TabIndex = 37;
            this.datePickerControl1.TextColor = System.Drawing.Color.White;
            // 
            // cmbHoatDong
            // 
            this.cmbHoatDong.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmbHoatDong.BorderColor = System.Drawing.Color.SteelBlue;
            this.cmbHoatDong.BorderSize = 1;
            this.cmbHoatDong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cmbHoatDong.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbHoatDong.ForeColor = System.Drawing.Color.DimGray;
            this.cmbHoatDong.IconColor = System.Drawing.Color.SteelBlue;
            this.cmbHoatDong.Items.AddRange(new object[] {
            "Đang bán",
            "Tồn kho"});
            this.cmbHoatDong.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cmbHoatDong.ListTextColor = System.Drawing.Color.SteelBlue;
            this.cmbHoatDong.Location = new System.Drawing.Point(745, 70);
            this.cmbHoatDong.MinimumSize = new System.Drawing.Size(130, 30);
            this.cmbHoatDong.Name = "cmbHoatDong";
            this.cmbHoatDong.Padding = new System.Windows.Forms.Padding(1);
            this.cmbHoatDong.Size = new System.Drawing.Size(152, 30);
            this.cmbHoatDong.TabIndex = 39;
            this.cmbHoatDong.Texts = "";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.SteelBlue;
            this.label10.Location = new System.Drawing.Point(595, 70);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(106, 28);
            this.label10.TabIndex = 38;
            this.label10.Text = "Tình trạng";
            // 
            // FormInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1022, 713);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormInventory";
            this.Text = "Kho";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label5;
        private CustomControls.TextBoxControl txtGiaGoc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private CustomControls.TextBoxControl txtId;
        private System.Windows.Forms.Button btnXoa_LoaiSanPham;
        private System.Windows.Forms.Button btnSua_LoaiSanPham;
        private System.Windows.Forms.Button btnThem_LoaiSanPham;
        private System.Windows.Forms.Label label1;
        private CustomControls.TextBoxControl txtTenSanPham;
        private System.Windows.Forms.Label lblIdLoaiSanPham;
        private CustomControls.TextBoxControl txtSanPham;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private CustomControls.TextBoxControl textBoxControl4;
        private CustomControls.TextBoxControl textBoxControl1;
        private DatePickerControl datePickerControl1;
        private ComboBoxControl cmbHoatDong;
        private System.Windows.Forms.Label label10;
    }
}