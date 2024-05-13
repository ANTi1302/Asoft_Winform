using System.Data;
using System.Data.SqlClient;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        // khai báo connect sql
        string connection = @"Data Source=DESKTOP;Initial Catalog=Asoft_Demo;User ID=sa;Password=sapassword";
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataTable data = new DataTable();
        Form2 formToOpen1;
        string txtMa = null;
        string txtName = null;
        string txtPass = null;
        string txtEmail = null;
        string txtTel = null;
        public bool updateMode = false;
        public Form1()
        {
            InitializeComponent(); // Move InitializeComponent() to the beginning
            loadData();

        }
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
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        // sử lý Thêm Ctrl + N
        private void themToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formToOpen = new Form2();

            // Hiển thị Form
            formToOpen.Show();
        }


        private void clickMaNV(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            if (formToOpen1 == null || formToOpen1.IsDisposed)
            {
                formToOpen1 = new Form2();
            }

            txtMa = data.Rows[row]["UserID"].ToString();
            formToOpen1.SetTextBoxValue(data.Rows[row]["UserID"].ToString());
            formToOpen1.SetTextBoxValue2(data.Rows[row]["UserName"].ToString());
            formToOpen1.SetTextBoxValue4(data.Rows[row]["Email"].ToString());
            formToOpen1.SetTextBoxValue3(data.Rows[row]["Tel"].ToString());
            formToOpen1.SetTextBoxValue5(data.Rows[row]["Password"].ToString());
            formToOpen1.SetTextBoxValue1(data.Rows[row]["Password"].ToString());
            formToOpen1.SetButton2("Cập nhật", Button2ClickHandler);
            formToOpen1.SetButtonDisnable();
            //formToOpen1.SetButton2Click(Button2ClickHandler);

        }
        private void Button2ClickHandler(object sender, EventArgs e)
        {
            // Xử lý sự kiện Click của button2 Cập nhật của form2

            txtName = formToOpen1.GetTextBoxValue2();
            txtEmail = formToOpen1.GetTextBoxValue4();
            txtTel = formToOpen1.GetTextBoxValue3();
            txtPass = formToOpen1.GetTextBoxValue5();
            con = new SqlConnection(connection);
            con.Open();

            string sqlInsert2 = ("update NguoiDung set UserName=N'" + txtName + "', Email=N'" + txtEmail + "', Tel=N'" + txtTel + "', Password='" + txtPass + "', Disable=1 where UserID= N'" + txtMa + "'");

            cmd = new SqlCommand(sqlInsert2, con);
            cmd.ExecuteNonQuery();

            con.Close();
        }
        private void xoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (formToOpen1 == null || formToOpen1.IsDisposed)
            {
                formToOpen1 = new Form2();
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
                loadData();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            loadData();
        }
    }
}
