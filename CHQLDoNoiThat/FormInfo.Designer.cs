
using System.Drawing;

namespace CHQLDoNoiThat
{
    partial class FormInfo
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
            this.btnTaiLai = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.cmbTinhTrang = new CHQLDoNoiThat.ComboBoxControl();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbChucVu = new CHQLDoNoiThat.ComboBoxControl();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPassword = new CHQLDoNoiThat.CustomControls.TextBoxControl();
            this.cmbGioiTinh = new CHQLDoNoiThat.ComboBoxControl();
            this.label10 = new System.Windows.Forms.Label();
            this.datePickerControlNgaySinh = new CHQLDoNoiThat.DatePickerControl();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCMND = new CHQLDoNoiThat.CustomControls.TextBoxControl();
            this.txtSDT = new CHQLDoNoiThat.CustomControls.TextBoxControl();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEmail = new CHQLDoNoiThat.CustomControls.TextBoxControl();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtId = new CHQLDoNoiThat.CustomControls.TextBoxControl();
            this.btnSua = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDiaChi = new CHQLDoNoiThat.CustomControls.TextBoxControl();
            this.lblIdLoaiSanPham = new System.Windows.Forms.Label();
            this.txtHoTen = new CHQLDoNoiThat.CustomControls.TextBoxControl();
            this.pictureBoxNhanVien = new System.Windows.Forms.PictureBox();
            this.btnTaiAnhDaiDien = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTaiLai
            // 
            this.btnTaiLai.AutoSize = true;
            this.btnTaiLai.BackColor = System.Drawing.Color.SteelBlue;
            this.btnTaiLai.FlatAppearance.BorderSize = 0;
            this.btnTaiLai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTaiLai.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaiLai.ForeColor = System.Drawing.Color.White;
            this.btnTaiLai.Location = new System.Drawing.Point(448, 516);
            this.btnTaiLai.Margin = new System.Windows.Forms.Padding(0);
            this.btnTaiLai.Name = "btnTaiLai";
            this.btnTaiLai.Size = new System.Drawing.Size(105, 40);
            this.btnTaiLai.TabIndex = 74;
            this.btnTaiLai.TabStop = false;
            this.btnTaiLai.Text = "Tải lại";
            this.btnTaiLai.UseVisualStyleBackColor = false;
            // 
            // btnLuu
            // 
            this.btnLuu.AutoSize = true;
            this.btnLuu.BackColor = System.Drawing.Color.SteelBlue;
            this.btnLuu.FlatAppearance.BorderSize = 0;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.Location = new System.Drawing.Point(639, 516);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(0);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(105, 40);
            this.btnLuu.TabIndex = 73;
            this.btnLuu.TabStop = false;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            // 
            // cmbTinhTrang
            // 
            this.cmbTinhTrang.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmbTinhTrang.BorderColor = System.Drawing.Color.SteelBlue;
            this.cmbTinhTrang.BorderSize = 1;
            this.cmbTinhTrang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cmbTinhTrang.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTinhTrang.ForeColor = System.Drawing.Color.SteelBlue;
            this.cmbTinhTrang.IconColor = System.Drawing.Color.SteelBlue;
            this.cmbTinhTrang.Items.AddRange(new object[] {
            "Còn làm",
            "Nghỉ việc"});
            this.cmbTinhTrang.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cmbTinhTrang.ListTextColor = System.Drawing.Color.SteelBlue;
            this.cmbTinhTrang.Location = new System.Drawing.Point(741, 334);
            this.cmbTinhTrang.MinimumSize = new System.Drawing.Size(130, 30);
            this.cmbTinhTrang.Name = "cmbTinhTrang";
            this.cmbTinhTrang.Padding = new System.Windows.Forms.Padding(1);
            this.cmbTinhTrang.Size = new System.Drawing.Size(152, 39);
            this.cmbTinhTrang.TabIndex = 71;
            this.cmbTinhTrang.Texts = "";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.SteelBlue;
            this.label11.Location = new System.Drawing.Point(621, 344);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(106, 28);
            this.label11.TabIndex = 70;
            this.label11.Text = "Tình trạng";
            // 
            // cmbChucVu
            // 
            this.cmbChucVu.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmbChucVu.BorderColor = System.Drawing.Color.SteelBlue;
            this.cmbChucVu.BorderSize = 1;
            this.cmbChucVu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cmbChucVu.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbChucVu.ForeColor = System.Drawing.Color.SteelBlue;
            this.cmbChucVu.IconColor = System.Drawing.Color.SteelBlue;
            this.cmbChucVu.Items.AddRange(new object[] {
            "Nhân viên",
            "Quản lý"});
            this.cmbChucVu.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cmbChucVu.ListTextColor = System.Drawing.Color.SteelBlue;
            this.cmbChucVu.Location = new System.Drawing.Point(741, 273);
            this.cmbChucVu.MinimumSize = new System.Drawing.Size(130, 30);
            this.cmbChucVu.Name = "cmbChucVu";
            this.cmbChucVu.Padding = new System.Windows.Forms.Padding(1);
            this.cmbChucVu.Size = new System.Drawing.Size(152, 39);
            this.cmbChucVu.TabIndex = 69;
            this.cmbChucVu.Texts = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.SteelBlue;
            this.label7.Location = new System.Drawing.Point(621, 282);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 28);
            this.label7.TabIndex = 68;
            this.label7.Text = "Chức vụ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.SteelBlue;
            this.label4.Location = new System.Drawing.Point(208, 391);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 28);
            this.label4.TabIndex = 67;
            this.label4.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.BorderColor = System.Drawing.Color.SteelBlue;
            this.txtPassword.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtPassword.BorderSize = 2;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.SteelBlue;
            this.txtPassword.Location = new System.Drawing.Point(325, 384);
            this.txtPassword.Multiline = false;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Padding = new System.Windows.Forms.Padding(7);
            this.txtPassword.PasswordChar = false;
            this.txtPassword.Size = new System.Drawing.Size(263, 39);
            this.txtPassword.TabIndex = 66;
            this.txtPassword.Texts = "";
            this.txtPassword.UnderlinedStyle = true;
            // 
            // cmbGioiTinh
            // 
            this.cmbGioiTinh.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmbGioiTinh.BorderColor = System.Drawing.Color.SteelBlue;
            this.cmbGioiTinh.BorderSize = 1;
            this.cmbGioiTinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cmbGioiTinh.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGioiTinh.ForeColor = System.Drawing.Color.SteelBlue;
            this.cmbGioiTinh.IconColor = System.Drawing.Color.SteelBlue;
            this.cmbGioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cmbGioiTinh.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.cmbGioiTinh.ListTextColor = System.Drawing.Color.SteelBlue;
            this.cmbGioiTinh.Location = new System.Drawing.Point(719, 70);
            this.cmbGioiTinh.MinimumSize = new System.Drawing.Size(130, 30);
            this.cmbGioiTinh.Name = "cmbGioiTinh";
            this.cmbGioiTinh.Padding = new System.Windows.Forms.Padding(1);
            this.cmbGioiTinh.Size = new System.Drawing.Size(224, 46);
            this.cmbGioiTinh.TabIndex = 65;
            this.cmbGioiTinh.Texts = "";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.SteelBlue;
            this.label10.Location = new System.Drawing.Point(208, 338);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 28);
            this.label10.TabIndex = 64;
            this.label10.Text = "Email";
            // 
            // datePickerControlNgaySinh
            // 
            this.datePickerControlNgaySinh.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.datePickerControlNgaySinh.BorderSize = 0;
            this.datePickerControlNgaySinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.datePickerControlNgaySinh.Location = new System.Drawing.Point(325, 201);
            this.datePickerControlNgaySinh.MinimumSize = new System.Drawing.Size(4, 35);
            this.datePickerControlNgaySinh.Name = "datePickerControlNgaySinh";
            this.datePickerControlNgaySinh.Size = new System.Drawing.Size(263, 35);
            this.datePickerControlNgaySinh.SkinColor = System.Drawing.Color.SteelBlue;
            this.datePickerControlNgaySinh.TabIndex = 63;
            this.datePickerControlNgaySinh.TextColor = System.Drawing.Color.White;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.SteelBlue;
            this.label8.Location = new System.Drawing.Point(621, 204);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 28);
            this.label8.TabIndex = 62;
            this.label8.Text = "CMND";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.SteelBlue;
            this.label9.Location = new System.Drawing.Point(208, 282);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 28);
            this.label9.TabIndex = 61;
            this.label9.Text = "Địa chỉ";
            // 
            // txtCMND
            // 
            this.txtCMND.BorderColor = System.Drawing.Color.SteelBlue;
            this.txtCMND.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtCMND.BorderSize = 2;
            this.txtCMND.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCMND.ForeColor = System.Drawing.Color.SteelBlue;
            this.txtCMND.Location = new System.Drawing.Point(719, 195);
            this.txtCMND.Multiline = false;
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Padding = new System.Windows.Forms.Padding(7);
            this.txtCMND.PasswordChar = false;
            this.txtCMND.Size = new System.Drawing.Size(224, 39);
            this.txtCMND.TabIndex = 60;
            this.txtCMND.Texts = "";
            this.txtCMND.UnderlinedStyle = true;
            // 
            // txtSDT
            // 
            this.txtSDT.BorderColor = System.Drawing.Color.SteelBlue;
            this.txtSDT.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtSDT.BorderSize = 2;
            this.txtSDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSDT.ForeColor = System.Drawing.Color.SteelBlue;
            this.txtSDT.Location = new System.Drawing.Point(719, 130);
            this.txtSDT.Multiline = false;
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Padding = new System.Windows.Forms.Padding(7);
            this.txtSDT.PasswordChar = false;
            this.txtSDT.Size = new System.Drawing.Size(224, 39);
            this.txtSDT.TabIndex = 59;
            this.txtSDT.Texts = "";
            this.txtSDT.UnderlinedStyle = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.SteelBlue;
            this.label5.Location = new System.Drawing.Point(621, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 28);
            this.label5.TabIndex = 58;
            this.label5.Text = "SDT";
            // 
            // txtEmail
            // 
            this.txtEmail.BorderColor = System.Drawing.Color.SteelBlue;
            this.txtEmail.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtEmail.BorderSize = 2;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.SteelBlue;
            this.txtEmail.Location = new System.Drawing.Point(325, 334);
            this.txtEmail.Multiline = false;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Padding = new System.Windows.Forms.Padding(7);
            this.txtEmail.PasswordChar = false;
            this.txtEmail.Size = new System.Drawing.Size(263, 39);
            this.txtEmail.TabIndex = 57;
            this.txtEmail.Texts = "";
            this.txtEmail.UnderlinedStyle = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SteelBlue;
            this.label3.Location = new System.Drawing.Point(621, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 28);
            this.label3.TabIndex = 56;
            this.label3.Text = "Giới tính";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SteelBlue;
            this.label2.Location = new System.Drawing.Point(208, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 28);
            this.label2.TabIndex = 55;
            this.label2.Text = "Id";
            // 
            // txtId
            // 
            this.txtId.BorderColor = System.Drawing.Color.SteelBlue;
            this.txtId.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtId.BorderSize = 2;
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.ForeColor = System.Drawing.Color.SteelBlue;
            this.txtId.Location = new System.Drawing.Point(325, 66);
            this.txtId.Multiline = false;
            this.txtId.Name = "txtId";
            this.txtId.Padding = new System.Windows.Forms.Padding(7);
            this.txtId.PasswordChar = false;
            this.txtId.Size = new System.Drawing.Size(263, 39);
            this.txtId.TabIndex = 54;
            this.txtId.Texts = "";
            this.txtId.UnderlinedStyle = true;
            // 
            // btnSua
            // 
            this.btnSua.AutoSize = true;
            this.btnSua.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSua.FlatAppearance.BorderSize = 0;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(248, 516);
            this.btnSua.Margin = new System.Windows.Forms.Padding(0);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(107, 40);
            this.btnSua.TabIndex = 53;
            this.btnSua.TabStop = false;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(208, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 28);
            this.label1.TabIndex = 52;
            this.label1.Text = "Ngày sinh";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.BorderColor = System.Drawing.Color.SteelBlue;
            this.txtDiaChi.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtDiaChi.BorderSize = 2;
            this.txtDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChi.ForeColor = System.Drawing.Color.SteelBlue;
            this.txtDiaChi.Location = new System.Drawing.Point(325, 280);
            this.txtDiaChi.Multiline = false;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Padding = new System.Windows.Forms.Padding(7);
            this.txtDiaChi.PasswordChar = false;
            this.txtDiaChi.Size = new System.Drawing.Size(263, 39);
            this.txtDiaChi.TabIndex = 51;
            this.txtDiaChi.Texts = "";
            this.txtDiaChi.UnderlinedStyle = true;
            // 
            // lblIdLoaiSanPham
            // 
            this.lblIdLoaiSanPham.AutoSize = true;
            this.lblIdLoaiSanPham.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdLoaiSanPham.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblIdLoaiSanPham.Location = new System.Drawing.Point(208, 125);
            this.lblIdLoaiSanPham.Name = "lblIdLoaiSanPham";
            this.lblIdLoaiSanPham.Size = new System.Drawing.Size(75, 28);
            this.lblIdLoaiSanPham.TabIndex = 50;
            this.lblIdLoaiSanPham.Text = "Họ tên";
            // 
            // txtHoTen
            // 
            this.txtHoTen.BorderColor = System.Drawing.Color.SteelBlue;
            this.txtHoTen.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtHoTen.BorderSize = 2;
            this.txtHoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoTen.ForeColor = System.Drawing.Color.SteelBlue;
            this.txtHoTen.Location = new System.Drawing.Point(325, 121);
            this.txtHoTen.Multiline = false;
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Padding = new System.Windows.Forms.Padding(7);
            this.txtHoTen.PasswordChar = false;
            this.txtHoTen.Size = new System.Drawing.Size(263, 39);
            this.txtHoTen.TabIndex = 49;
            this.txtHoTen.Texts = "";
            this.txtHoTen.UnderlinedStyle = true;
            // 
            // pictureBoxNhanVien
            // 
            this.pictureBoxNhanVien.Location = new System.Drawing.Point(20, 66);
            this.pictureBoxNhanVien.Name = "pictureBoxNhanVien";
            this.pictureBoxNhanVien.Size = new System.Drawing.Size(167, 193);
            this.pictureBoxNhanVien.TabIndex = 72;
            this.pictureBoxNhanVien.TabStop = false;
            this.pictureBoxNhanVien.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;

            // 
            // btnTaiAnhDaiDien
            // 
            this.btnTaiAnhDaiDien.AutoSize = true;
            this.btnTaiAnhDaiDien.BackColor = System.Drawing.Color.SteelBlue;
            this.btnTaiAnhDaiDien.FlatAppearance.BorderSize = 0;
            this.btnTaiAnhDaiDien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTaiAnhDaiDien.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaiAnhDaiDien.ForeColor = System.Drawing.Color.White;
            this.btnTaiAnhDaiDien.Location = new System.Drawing.Point(20, 272);
            this.btnTaiAnhDaiDien.Margin = new System.Windows.Forms.Padding(0);
            this.btnTaiAnhDaiDien.Name = "btnTaiAnhDaiDien";
            this.btnTaiAnhDaiDien.Size = new System.Drawing.Size(167, 40);
            this.btnTaiAnhDaiDien.TabIndex = 75;
            this.btnTaiAnhDaiDien.TabStop = false;
            this.btnTaiAnhDaiDien.Text = "Tải ảnh đại diện";
            this.btnTaiAnhDaiDien.UseVisualStyleBackColor = false;
            this.btnTaiAnhDaiDien.Click += new System.EventHandler(this.btnTaiAnhDaiDien_Click);
            // 
            // FormInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(963, 623);
            this.Controls.Add(this.btnTaiAnhDaiDien);
            this.Controls.Add(this.btnTaiLai);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.pictureBoxNhanVien);
            this.Controls.Add(this.cmbTinhTrang);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cmbChucVu);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.cmbGioiTinh);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.datePickerControlNgaySinh);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtCMND);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.lblIdLoaiSanPham);
            this.Controls.Add(this.txtHoTen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormInfo";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNhanVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTaiLai;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.PictureBox pictureBoxNhanVien;
        private ComboBoxControl cmbTinhTrang;
        private System.Windows.Forms.Label label11;
        private ComboBoxControl cmbChucVu;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private CustomControls.TextBoxControl txtPassword;
        private ComboBoxControl cmbGioiTinh;
        private System.Windows.Forms.Label label10;
        private DatePickerControl datePickerControlNgaySinh;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private CustomControls.TextBoxControl txtCMND;
        private CustomControls.TextBoxControl txtSDT;
        private System.Windows.Forms.Label label5;
        private CustomControls.TextBoxControl txtEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private CustomControls.TextBoxControl txtId;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Label label1;
        private CustomControls.TextBoxControl txtDiaChi;
        private System.Windows.Forms.Label lblIdLoaiSanPham;
        private CustomControls.TextBoxControl txtHoTen;
        private System.Windows.Forms.Button btnTaiAnhDaiDien;
    }
}