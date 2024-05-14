using System.Data;
using System.Data.SqlClient;

namespace WinFormsApp1
{
    public partial class GridNhanVien : Form
    {
        // khai báo connect sql
        string connection = @"Data Source=DESKTOP;Initial Catalog=Asoft_Demo;User ID=sa;Password=sapassword";
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataTable data = new DataTable();
        FormCreate formToOpen1;
        string txtMa = null;
        string txtName = null;
        string txtPass = null;
        string txtEmail = null;
        string txtTel = null;
        public bool updateMode = false;
        public GridNhanVien()
        {
            InitializeComponent(); // Move InitializeComponent() to the beginning
            loadData();

        }
        //load data vào grid
        private void loadData()
        {
            con = new SqlConnection(connection);
            try
            {
                con.Open();
                cmd = new SqlCommand("select * from NguoiDung", con);
                adapter = new SqlDataAdapter(cmd);
                data = new DataTable(); // Initialize data DataTable
                adapter.Fill(data);
                dataGridView1.DataSource = data;
                dataGridView1.Columns["Password"].Visible = false;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close(); // Always close the connection, whether an exception occurs or not
            }
        }

        // sử lý nút đóng ứng dụng
        private void btnClickClose(object sender, EventArgs e)
        {
            Application.Exit();
        }
        // sử lý Thêm Ctrl + N
        private void themToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formToOpen = new FormCreate();

            // Hiển thị Form
            formToOpen.Show();
        }

        // xử lý chọn dòng
        private void clickMaNV(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            if (formToOpen1 == null || formToOpen1.IsDisposed)
            {
                formToOpen1 = new FormCreate();
            }

            txtMa = data.Rows[row]["UserID"].ToString();
            // set textBox vào formCreate khi nhấn chọn dòng của gridNhanVien
            formToOpen1.SetTxtMaNVValue(data.Rows[row]["UserID"].ToString());
            formToOpen1.SetTxtTenNV2(data.Rows[row]["UserName"].ToString());
            formToOpen1.SetTxtEmailValue(data.Rows[row]["Email"].ToString());
            formToOpen1.SetTxtSDTValue(data.Rows[row]["Tel"].ToString());
            formToOpen1.SetTxtMKValue(data.Rows[row]["Password"].ToString());
            formToOpen1.SetTxtNhapLaiMKValue(data.Rows[row]["Password"].ToString());
            formToOpen1.SetBtnCapNhat("Cập nhật", btnCapNhatFormCreate);
            // ẩn nút nhập lại
            formToOpen1.SetButtonDisnable();
            //formToOpen1.SetButton2Click(Button2ClickHandler);

        }
        // Xử lý sự kiện Click Cập nhật của form2
        private void btnCapNhatFormCreate(object sender, EventArgs e)
        {


            txtName = formToOpen1.GetTxtTenValue();
            txtEmail = formToOpen1.GetTxbEmailValue();
            txtTel = formToOpen1.GetTxbSDTValue3();
            txtPass = formToOpen1.GetTxbMKValue();
            con = new SqlConnection(connection);
            con.Open();

            //câu lệnh update
            string sqlInsert2 = ("update NguoiDung set UserName=N'" + txtName + "', Email=N'" + txtEmail + "', Tel=N'" + txtTel + "', Password='" + txtPass + "', Disable=1 where UserID= N'" + txtMa + "'");

            cmd = new SqlCommand(sqlInsert2, con);
            cmd.ExecuteNonQuery();

            con.Close();
        }
        // sử lý khi nhấn nút Sửa để mở form2
        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (formToOpen1 == null || formToOpen1.IsDisposed)
            {
                formToOpen1 = new FormCreate();
            }
            formToOpen1.Show();
        }
        // sử lý sự kiện xóa NguoiDung
        private void xoaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Bạn có muốn xóa?", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                con = new SqlConnection(connection);
                con.Open();

                string sqlInsert = ("delete from NguoiDung where UserID='" + txtMa + "'");
                cmd = new SqlCommand(sqlInsert, con);
                cmd.ExecuteNonQuery();

                con.Close();
                //load lại grid khi đã xóa dòng
                loadData();
            }
        }
        // sử lý nút Tải lại
        private void btbTaiLai(object sender, EventArgs e)
        {
            loadData();
        }

       
    }
}
