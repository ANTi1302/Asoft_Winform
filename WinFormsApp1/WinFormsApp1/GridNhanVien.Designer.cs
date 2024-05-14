namespace WinFormsApp1
{
    partial class GridNhanVien
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            ToolStripMenuItem themToolStripMenuItem;
            dataGridView1 = new DataGridView();
            maNV = new DataGridViewTextBoxColumn();
            hoTen = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            Tel = new DataGridViewTextBoxColumn();
            Password = new DataGridViewTextBoxColumn();
            Disable = new DataGridViewCheckBoxColumn();
            button1 = new Button();
            contextMenuStrip1 = new ContextMenuStrip(components);
            xoaToolStripMenuItem = new ToolStripMenuItem();
            xoaToolStripMenuItem1 = new ToolStripMenuItem();
            btnClose = new Button();
            button3 = new Button();
            button4 = new Button();
            themToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // themToolStripMenuItem
            // 
            themToolStripMenuItem.Name = "themToolStripMenuItem";
            themToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.N;
            themToolStripMenuItem.Size = new Size(168, 24);
            themToolStripMenuItem.Text = "Thêm";
            themToolStripMenuItem.Click += themToolStripMenuItem_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { maNV, hoTen, Email, Tel, Password, Disable });
            dataGridView1.Location = new Point(1, 24);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(798, 300);
            dataGridView1.TabIndex = 0;
            dataGridView1.RowEnter += clickMaNV;
            // 
            // maNV
            // 
            maNV.DataPropertyName = "UserID";
            maNV.HeaderText = "Mã nhân viên";
            maNV.MinimumWidth = 6;
            maNV.Name = "maNV";
            maNV.Width = 125;
            // 
            // hoTen
            // 
            hoTen.DataPropertyName = "UserName";
            hoTen.HeaderText = "Tên nhân viên";
            hoTen.MinimumWidth = 6;
            hoTen.Name = "hoTen";
            hoTen.Width = 125;
            // 
            // Email
            // 
            Email.DataPropertyName = "Email";
            Email.HeaderText = "Email";
            Email.MinimumWidth = 6;
            Email.Name = "Email";
            Email.Width = 125;
            // 
            // Tel
            // 
            Tel.DataPropertyName = "Tel";
            Tel.HeaderText = "Số điện thoại";
            Tel.MinimumWidth = 6;
            Tel.Name = "Tel";
            Tel.Width = 125;
            // 
            // Password
            // 
            Password.HeaderText = "Password";
            Password.MinimumWidth = 6;
            Password.Name = "Password";
            Password.Width = 125;
            // 
            // Disable
            // 
            Disable.DataPropertyName = "Disable";
            Disable.HeaderText = "Không hiển thị";
            Disable.MinimumWidth = 6;
            Disable.Name = "Disable";
            Disable.Width = 125;
            // 
            // button1
            // 
            button1.ContextMenuStrip = contextMenuStrip1;
            button1.Location = new Point(536, 386);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 1;
            button1.Text = "Thực hiện";
            button1.UseVisualStyleBackColor = true;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { themToolStripMenuItem, xoaToolStripMenuItem, xoaToolStripMenuItem1 });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(169, 76);
            // 
            // xoaToolStripMenuItem
            // 
            xoaToolStripMenuItem.Name = "xoaToolStripMenuItem";
            xoaToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.E;
            xoaToolStripMenuItem.Size = new Size(168, 24);
            xoaToolStripMenuItem.Text = "Sửa";
            xoaToolStripMenuItem.Click += editToolStripMenuItem_Click;
            // 
            // xoaToolStripMenuItem1
            // 
            xoaToolStripMenuItem1.Name = "xoaToolStripMenuItem1";
            xoaToolStripMenuItem1.ShortcutKeys = Keys.Control | Keys.D;
            xoaToolStripMenuItem1.Size = new Size(168, 24);
            xoaToolStripMenuItem1.Text = "Xóa";
            xoaToolStripMenuItem1.Click += xoaToolStripMenuItem1_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(636, 386);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 29);
            btnClose.TabIndex = 2;
            btnClose.Text = "Đóng";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClickClose;
            // 
            // button3
            // 
            button3.Location = new Point(53, 386);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 3;
            button3.Text = "Trợ giúp";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(153, 386);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 4;
            button4.Text = "Tải lại";
            button4.UseVisualStyleBackColor = true;
            button4.Click += btbTaiLai;
            // 
            // GridNhanVien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(btnClose);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Name = "GridNhanVien";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button1;
        private Button btnClose;
        private Button button3;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem themToolStripMenuItem;
        private ToolStripMenuItem xoaToolStripMenuItem;
        private ToolStripMenuItem xoaToolStripMenuItem1;
        private DataGridViewTextBoxColumn maNV;
        private DataGridViewTextBoxColumn hoTen;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn Tel;
        private DataGridViewTextBoxColumn Password;
        private DataGridViewCheckBoxColumn Disable;
        private Button button4;
    }
}
