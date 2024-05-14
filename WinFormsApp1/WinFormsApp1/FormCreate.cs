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
    public partial class FormCreate : Form
    {
        string connection = @"Data Source=DESKTOP;Initial Catalog=Asoft_Demo;User ID=sa;Password=sapassword";
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataTable data = new DataTable();


        public FormCreate()
        {

            InitializeComponent();
            lblMaNV.Text = "";
            lblTenNV.Text = "";
            lblEmail.Text = "";
            lblMatKhau.Text = "";
        }
        // Phương thức công khai để thiết lập giá trị cho các textBox của form2 khi form1 muốn sử dụng
        public void SetTxtMaNVValue(string value)
        {
            txbMaNV.Text = value;
            //khóa mã khi nhấn Sửa
            txbMaNV.Enabled = false;
        }
        public void SetButtonDisnable()
        {
            btnNhapTiep.Enabled = false;
        }
        public void SetTxtNhapLaiMKValue(string value)
        {
            txbNhapLaiMK.Text = value;
        }
        public void SetTxtTenNV2(string value)
        {
            txbTenNV.Text = value;
        }
        public string GetTxtTenValue()
        {
            return txbTenNV.Text;
        }
        public void SetTxtSDTValue(string value)
        {
            txbSDT.Text = value;
        }
        public string GetTxbSDTValue3()
        {
            return txbSDT.Text;
        }
        public void SetTxtEmailValue(string value)
        {
            txbEmail.Text = value;
        }
        public string GetTxbEmailValue()
        {
            return txbEmail.Text;
        }
        public void SetTxtMKValue(string value)
        {
            txbMK.Text = value;
        }
        public string GetTxbMKValue()
        {
            return txbMK.Text;
        }
        // set lại nút Cập nhật
        public void SetBtnCapNhat(string value, EventHandler handler)
        {
            btnLuu.Text = value;
            btnLuu.Click += handler;
        }

        // xử lý nút Đóng
        private void btnClickClose(object sender, EventArgs e)
        {
            this.Close();
        }
        // sử lý nút Thêm
        private void btnThemNhanVien(object sender, EventArgs e)
        {
            if (btnLuu.Text.Equals("Lưu"))
            {
                string txtMaNV = txbMaNV.Text.Trim().ToUpper();
                string txtHo = txbTenNV.Text;
                string txtEmail = txbEmail.Text;
                string txtPass = txbNhapLaiMK.Text;
                string txtTel = txbSDT.Text;
                string pattern = @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$";
                bool isError = false;

                // Kiểm tra xem địa chỉ email khớp với biểu thức chính quy không
                Match match = Regex.Match(txtEmail, pattern);

                if (string.IsNullOrWhiteSpace(txtMaNV))
                {

                    lblMaNV.Text = "Mã nhân viên không được để trống.";
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
                        lblMaNV.Text = "Mã người dùng đã tồn tại.";
                        isError = true;
                    }
                    else
                    {
                        lblMaNV.Text = "";
                    }

                    con.Close();

                }
                // kiểm tra tên rỗng
                if (string.IsNullOrWhiteSpace(txtHo))
                {


                    lblTenNV.Text = "Tên nhân viên không được để trống.";
                    isError = true;

                }
                else
                {
                    lblTenNV.Text = "";
                }
                // kiểm tra email hợp lệ
                if (!match.Success)
                {

                    lblEmail.Text = "Email nhân viên không hợp lệ.";
                    isError = true;
                }
                else
                {
                    lblEmail.Text = "";
                }


                if (!isError)
                {

                    int valueToSave = checkBox1.Checked ? 1 : 0;
                    con = new SqlConnection(connection);
                    con.Open();
                    // câu lệnh thêm NguoiDung
                    string sqlInsert = "Insert into NguoiDung (UserID, UserName, Email, Password, Tel, Disable) Values ('" + txtMaNV + "',N' " + txtHo + "',N' " + txtEmail + "',N' " + txtPass + "',N' " + txtTel + "',N' " + valueToSave + "')";
                    cmd = new SqlCommand(sqlInsert, con);
                    cmd.ExecuteNonQuery();
                    con.Close();

                }
            }
        }
        // xử lý nút Nhập lại
        private void btnNhapLai(object sender, EventArgs e)
        {
            lblMaNV.Text = "";
            lblTenNV.Text = "";
            lblEmail.Text = "";
            lblMatKhau.Text = "";

            txbMaNV.Text = "";
            txbTenNV.Text = "";
            txbEmail.Text = "";
            txbSDT.Text = "";
            txbMK.Text = "";
            txbNhapLaiMK.Text = "";


        }

        //kiểm tra mật khẩu khi nhập lại
        private void txtNhapLaiMatKhau_Leave(object sender, EventArgs e)
        {
            // Kiểm tra xem mật khẩu và mật khẩu nhập lại có trùng nhau hay không
            if (txbMK.Text != txbNhapLaiMK.Text)
            {
                MessageBox.Show("Mật khẩu nhập lại không khớp. Vui lòng nhập lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbMK.Focus(); // Di chuyển trỏ chuột đến TextBox nhập lại mật khẩu để người dùng có thể nhập lại
            }
        }

       
    }
}
