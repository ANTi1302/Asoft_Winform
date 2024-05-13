using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        string connection = @"Data Source=DESKTOP;Initial Catalog=Asoft_Demo;User ID=sa;Password=sapassword";
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataTable data = new DataTable();


        public Form2()
        {

            InitializeComponent();
            label8.Text = "";
            label9.Text = "";
            label10.Text = "";
            label11.Text = "";
        }
        // Phương thức công khai để thiết lập giá trị cho textBox1
        public void SetTextBoxValue(string value)
        {
            textBox1.Text = value;
            textBox1.Enabled = false;
        }
        public void SetButtonDisnable()
        {
            button1.Enabled = false;
        }
        public void SetTextBoxValue1(string value)
        {
            textBox6.Text = value;
        }
        public string GetTextBoxValue1()
        {
            return textBox6.Text;
        }
        public void SetTextBoxValue2(string value)
        {
            textBox2.Text = value;
        }
        public string GetTextBoxValue2()
        {
            return textBox2.Text;
        }
        public void SetTextBoxValue3(string value)
        {
            textBox3.Text = value;
        }
        public string GetTextBoxValue3()
        {
            return textBox3.Text;
        }
        public void SetTextBoxValue4(string value)
        {
            textBox4.Text = value;
        }
        public string GetTextBoxValue4()
        {
            return textBox4.Text;
        }
        public void SetTextBoxValue5(string value)
        {
            textBox5.Text = value;
        }
        public string GetTextBoxValue5()
        {
            return textBox5.Text;
        }

        public void SetButton2(string value, EventHandler handler)
        {
            button2.Text = value;
            button2.Click += handler;
        }


        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // sử lý nút Thêm
        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.Text.Equals("Lưu"))
            {
                string txtMaNV = textBox1.Text.Trim().ToUpper();
                string txtHo = textBox2.Text;
                string txtEmail = textBox4.Text;
                string txtPass = textBox6.Text;
                string txtTel = textBox3.Text;
                string pattern = @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$";
                bool isError = false;

                // Kiểm tra xem địa chỉ email khớp với biểu thức chính quy không
                Match match = Regex.Match(txtEmail, pattern);

                if (string.IsNullOrWhiteSpace(txtMaNV))
                {

                    label8.Text = "Mã nhân viên không được để trống.";
                    isError = true;


                }
                else
                {
                    // Kiểm tra mã người dùng tồn tại hay chưa
                    con = new SqlConnection(connection);
                    con.Open();

                    string sqlSelect = "SELECT COUNT(*) FROM NguoiDung WHERE UserID = @UserID";
                    SqlCommand cmd = new SqlCommand(sqlSelect, con);
                    cmd.Parameters.AddWithValue("@UserID", txtMaNV);
                    int existingUserCount = (int)cmd.ExecuteScalar();


                    if (existingUserCount > 0)
                    {
                        label8.Text = "Mã người dùng đã tồn tại.";
                        isError = true;
                    }
                    else
                    {
                        label8.Text = "";
                    }

                    con.Close();

                }
                // kiểm tra tên rỗng
                if (string.IsNullOrWhiteSpace(txtHo))
                {


                    label9.Text = "Tên nhân viên không được để trống.";
                    isError = true;

                }
                else
                {
                    label9.Text = "";
                }
                // kiểm tra email hợp lệ
                if (!match.Success)
                {

                    label10.Text = "Email nhân viên không hợp lệ.";
                    isError = true;
                }
                else
                {
                    label10.Text = "";
                }


                if (!isError)
                {

                    int valueToSave = checkBox1.Checked ? 1 : 0;
                    con = new SqlConnection(connection);
                    con.Open();

                    string sqlInsert = "Insert into NguoiDung (UserID, UserName, Email, Password, Tel, Disable) Values ('" + txtMaNV + "',N' " + txtHo + "',N' " + txtEmail + "',N' " + txtPass + "',N' " + txtTel + "',N' " + valueToSave + "')";
                    cmd = new SqlCommand(sqlInsert, con);
                    cmd.ExecuteNonQuery();
                    con.Close();

                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label8.Text = "";
            label9.Text = "";
            label10.Text = "";
            label11.Text = "";

            textBox1.Text = "";
            textBox2.Text = "";
            textBox4.Text = "";
            textBox3.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";


        }
        private void txtNhapLaiMatKhau_Leave(object sender, EventArgs e)
        {
            // Kiểm tra xem mật khẩu và mật khẩu nhập lại có trùng nhau hay không
            if (textBox5.Text != textBox6.Text)
            {
                MessageBox.Show("Mật khẩu nhập lại không khớp. Vui lòng nhập lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox5.Focus(); // Di chuyển trỏ chuột đến TextBox nhập lại mật khẩu để người dùng có thể nhập lại
            }
        }

       
    }
}
