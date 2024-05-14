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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox3 = new TextBox();
            label3 = new Label();
            textBox4 = new TextBox();
            label4 = new Label();
            textBox5 = new TextBox();
            label5 = new Label();
            textBox6 = new TextBox();
            label6 = new Label();
            checkBox1 = new CheckBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
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
            // textBox1
            // 
            textBox1.Location = new Point(240, 27);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(238, 27);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(240, 85);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(238, 27);
            textBox2.TabIndex = 3;
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
            // textBox3
            // 
            textBox3.Location = new Point(240, 196);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(238, 27);
            textBox3.TabIndex = 5;
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
            // textBox4
            // 
            textBox4.Location = new Point(240, 140);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(238, 27);
            textBox4.TabIndex = 7;
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
            // textBox5
            // 
            textBox5.Location = new Point(240, 253);
            textBox5.Name = "textBox5";
            textBox5.PasswordChar = '*';
            textBox5.Size = new Size(238, 27);
            textBox5.TabIndex = 9;
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
            // textBox6
            // 
            textBox6.Location = new Point(240, 309);
            textBox6.Name = "textBox6";
            textBox6.PasswordChar = '*';
            textBox6.Size = new Size(238, 27);
            textBox6.TabIndex = 11;
            textBox6.Leave += txtNhapLaiMatKhau_Leave;
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
            // button1
            // 
            button1.Location = new Point(158, 390);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 13;
            button1.Text = "Nhập tiếp";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnNhapLai;
            // 
            // button2
            // 
            button2.Location = new Point(304, 390);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 14;
            button2.Text = "Lưu";
            button2.UseVisualStyleBackColor = true;
            button2.Click += btnThemNhanVien;
            // 
            // button3
            // 
            button3.Location = new Point(442, 390);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 15;
            button3.Text = "Đóng";
            button3.UseVisualStyleBackColor = true;
            button3.Click += btnClose;
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
            // label9
            // 
            lblTenNV.AutoSize = true;
            lblTenNV.Location = new Point(243, 117);
            lblTenNV.Name = "lblTenNV";
            lblTenNV.Size = new Size(49, 20);
            lblTenNV.TabIndex = 18;
            lblTenNV.Text = "lblTen";
            // 
            // label10
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(240, 173);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(63, 20);
            lblEmail.TabIndex = 19;
            lblEmail.Text = "lblEmail";
            // 
            // label11
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
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(checkBox1);
            Controls.Add(textBox6);
            Controls.Add(label6);
            Controls.Add(textBox5);
            Controls.Add(label5);
            Controls.Add(textBox4);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "FormCreate";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox3;
        private Label label3;
        private TextBox textBox4;
        private Label label4;
        private TextBox textBox5;
        private Label label5;
        private TextBox textBox6;
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
    }
}