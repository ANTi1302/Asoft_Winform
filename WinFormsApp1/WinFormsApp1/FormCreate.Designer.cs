namespace WinFormsApp1
{
    partial class FormCreate
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
            label1 = new Label();
            txbMaNV = new TextBox();
            txbTenNV = new TextBox();
            label2 = new Label();
            txbSDT = new TextBox();
            label3 = new Label();
            txbEmail = new TextBox();
            label4 = new Label();
            txbMK = new TextBox();
            label5 = new Label();
            txbNhapLaiMK = new TextBox();
            label6 = new Label();
            checkBox1 = new CheckBox();
            btnNhapTiep = new Button();
            btnLuu = new Button();
            btnClose = new Button();
            label7 = new Label();
            lblMaNV = new Label();
            lblTenNV = new Label();
            lblEmail = new Label();
            lblMatKhau = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(77, 27);
            label1.Name = "label1";
            label1.Size = new Size(97, 20);
            label1.TabIndex = 0;
            label1.Text = "Mã nhân viên";
            // 
            // txbMaNV
            // 
            txbMaNV.Location = new Point(240, 27);
            txbMaNV.Name = "txbMaNV";
            txbMaNV.Size = new Size(238, 27);
            txbMaNV.TabIndex = 1;
            // 
            // txbTenNV
            // 
            txbTenNV.Location = new Point(240, 85);
            txbTenNV.Name = "txbTenNV";
            txbTenNV.Size = new Size(238, 27);
            txbTenNV.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(77, 85);
            label2.Name = "label2";
            label2.Size = new Size(99, 20);
            label2.TabIndex = 2;
            label2.Text = "Tên nhân viên";
            // 
            // txbSDT
            // 
            txbSDT.Location = new Point(240, 196);
            txbSDT.Name = "txbSDT";
            txbSDT.Size = new Size(238, 27);
            txbSDT.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(77, 140);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 4;
            label3.Text = "Email";
            // 
            // txbEmail
            // 
            txbEmail.Location = new Point(240, 140);
            txbEmail.Name = "txbEmail";
            txbEmail.Size = new Size(238, 27);
            txbEmail.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(77, 203);
            label4.Name = "label4";
            label4.Size = new Size(97, 20);
            label4.TabIndex = 6;
            label4.Text = "Số điện thoại";
            // 
            // txbMK
            // 
            txbMK.Location = new Point(240, 253);
            txbMK.Name = "txbMK";
            txbMK.PasswordChar = '*';
            txbMK.Size = new Size(238, 27);
            txbMK.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(77, 253);
            label5.Name = "label5";
            label5.Size = new Size(70, 20);
            label5.TabIndex = 8;
            label5.Text = "Mật khẩu";
            // 
            // txbNhapLaiMK
            // 
            txbNhapLaiMK.Location = new Point(240, 309);
            txbNhapLaiMK.Name = "txbNhapLaiMK";
            txbNhapLaiMK.PasswordChar = '*';
            txbNhapLaiMK.Size = new Size(238, 27);
            txbNhapLaiMK.TabIndex = 11;
            txbNhapLaiMK.Leave += txtNhapLaiMatKhau_Leave;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(77, 309);
            label6.Name = "label6";
            label6.Size = new Size(130, 20);
            label6.TabIndex = 10;
            label6.Text = "Nhập lại mật khẩu";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(238, 355);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(127, 24);
            checkBox1.TabIndex = 12;
            checkBox1.Text = "Không hiển thị";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // btnNhapTiep
            // 
            btnNhapTiep.Location = new Point(158, 390);
            btnNhapTiep.Name = "btnNhapTiep";
            btnNhapTiep.Size = new Size(94, 29);
            btnNhapTiep.TabIndex = 13;
            btnNhapTiep.Text = "Nhập tiếp";
            btnNhapTiep.UseVisualStyleBackColor = true;
            btnNhapTiep.Click += btnNhapLai;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(304, 390);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(94, 29);
            btnLuu.TabIndex = 14;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnThemNhanVien;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(442, 390);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 29);
            btnClose.TabIndex = 15;
            btnClose.Text = "Đóng";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += this.btnClickClose;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(243, 57);
            label7.Name = "label7";
            label7.Size = new Size(0, 20);
            label7.TabIndex = 16;
            // 
            // lblMaNV
            // 
            lblMaNV.AutoSize = true;
            lblMaNV.Location = new Point(240, 62);
            lblMaNV.Name = "lblMaNV";
            lblMaNV.Size = new Size(67, 20);
            lblMaNV.TabIndex = 17;
            lblMaNV.Text = "lblMaNV";
            // 
            // lblTenNV
            // 
            lblTenNV.AutoSize = true;
            lblTenNV.Location = new Point(243, 117);
            lblTenNV.Name = "lblTenNV";
            lblTenNV.Size = new Size(49, 20);
            lblTenNV.TabIndex = 18;
            lblTenNV.Text = "lblTen";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(240, 173);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(63, 20);
            lblEmail.TabIndex = 19;
            lblEmail.Text = "lblEmail";
            // 
            // lblMatKhau
            // 
            lblMatKhau.AutoSize = true;
            lblMatKhau.Location = new Point(243, 339);
            lblMatKhau.Name = "lblMatKhau";
            lblMatKhau.Size = new Size(85, 20);
            lblMatKhau.TabIndex = 20;
            lblMatKhau.Text = "lblMatKhau";
            // 
            // FormCreate
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(653, 450);
            Controls.Add(lblMatKhau);
            Controls.Add(lblEmail);
            Controls.Add(lblTenNV);
            Controls.Add(lblMaNV);
            Controls.Add(label7);
            Controls.Add(btnClose);
            Controls.Add(btnLuu);
            Controls.Add(btnNhapTiep);
            Controls.Add(checkBox1);
            Controls.Add(txbNhapLaiMK);
            Controls.Add(label6);
            Controls.Add(txbMK);
            Controls.Add(label5);
            Controls.Add(txbEmail);
            Controls.Add(label4);
            Controls.Add(txbSDT);
            Controls.Add(label3);
            Controls.Add(txbTenNV);
            Controls.Add(label2);
            Controls.Add(txbMaNV);
            Controls.Add(label1);
            Name = "FormCreate";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txbMaNV;
        private TextBox txbTenNV;
        private Label label2;
        private TextBox txbSDT;
        private Label label3;
        private TextBox txbEmail;
        private Label label4;
        private TextBox txbMK;
        private Label label5;
        private TextBox txbNhapLaiMK;
        private Label label6;
        private CheckBox checkBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label7;
        private Label lblMaNV;
        private Label lblTenNV;
        private Label lblEmail;
        private Label lblMatKhau;
        private Button btnNhapTiep;
        private Button btnLuu;
        private Button btnClose;
    }
}