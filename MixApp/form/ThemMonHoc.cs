using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MixApp.form
{
    public partial class ThemMonHoc : Form
    {
        public ThemMonHoc()
        {
            InitializeComponent();
        }
        SqlConnection cnn = new(@"Data Source=DESKTOP-0VCPB7O;Initial Catalog=Mix_App;Integrated Security=True");
        string STT = "Sua";
        private void Btn_TroVe_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ThemMonHoc_Load(object sender, EventArgs e)
        {
            Data_MonHoc();
        }
        public void Data_MonHoc()
        {
            cnn.Open();
            string sql = "SELECT * FROM Tb_MonThi";  // lay het du lieu trong bang sinh vien
            SqlCommand com = new(sql, cnn); //bat dau truy van
            com.CommandType = CommandType.Text;
            SqlDataAdapter da1 = new(com); //chuyen du lieu ve
            //da1.SelectCommand.Parameters.AddWithValue("@MaMon", Cbb_MonThi.SelectedValue);
            //da1.SelectCommand.Parameters.AddWithValue("@MaKyThi", Cbb_KyThi.SelectedValue);
            DataTable dt = new(); //tạo một kho ảo để lưu trữ dữ liệu
            da1.Fill(dt);  // đổ dữ liệu vào kho
            cnn.Close();  // đóng kết nối
            Dgv_MonHoc.DataSource = dt; //đổ dữ liệu vào datagridview

        }

        private void Btn_CapNhat_Click(object sender, EventArgs e)
        {
            Data_MonHoc();
        }

        private void Btn_Them_Click(object sender, EventArgs e)
        {
            STT = "Them";
            Tb_MaMonHoc.Text = Tb_TenMonHoc.Text = null;
            Tb_MaMonHoc.Focus();
        }

        private void Dgv_MonHoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            STT = "Sua";
            if (e.RowIndex >= 0)
            {
                //gets a collection that contains all the rows
                DataGridViewRow row = this.Dgv_MonHoc.Rows[e.RowIndex];
                //populate the textbox from specific value of the coordinates of column and row.
                Tb_MaMonHoc.Text = row.Cells[0].Value.ToString();
                Tb_TenMonHoc.Text = row.Cells[1].Value.ToString();

            }
        }
        public void Them_MonHoc()
        {
            String st = "INSERT INTO Tb_MonThi(MaMon,TenMon) VALUES(@MaMon,@TenMon)";
            SqlCommand sqlcom = new(st, cnn);
            sqlcom.Parameters.AddWithValue("@MaMon", Tb_MaMonHoc.Text);
            sqlcom.Parameters.AddWithValue("@TenMon", Tb_TenMonHoc.Text);
            
            try
            {
                cnn.Open();
                sqlcom.ExecuteNonQuery();
                MessageBox.Show("Thêm Thành Công");
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message + "\nLỗi!\nTrùng mã!!!");
            }
            finally
            {
                cnn.Close();
            }
        }
//        UPDATE table_name
//SET column1 = value1, column2 = value2, ...
//WHERE condition;
        public void Sua_MonHoc()
        {
            String st = "UPDATE Tb_MonThi SET TenMon=@TenMon WHERE MaMon=@MaMon";
            SqlCommand sqlcom = new(st, cnn);
            sqlcom.Parameters.AddWithValue("@MaMon", Tb_MaMonHoc.Text);
            sqlcom.Parameters.AddWithValue("@TenMon", Tb_TenMonHoc.Text);

            try
            {
                cnn.Open();
                sqlcom.ExecuteNonQuery();
                MessageBox.Show("Sửa Thành Công");
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message + "\nLỗi!!!");
            }
            finally
            {
                cnn.Close();
            }
        }
        private void Btn_Luu_Click(object sender, EventArgs e)
        {
            if (Tb_MaMonHoc.Text != "" && Tb_TenMonHoc.Text != "" && STT == "Them")
            {
                Them_MonHoc();
                Data_MonHoc();
               
            }
            
            if(Tb_MaMonHoc.Text != "" && Tb_TenMonHoc.Text != "" && STT == "Sua")
            {
                Sua_MonHoc();
                Data_MonHoc();
            }

            if(Tb_MaMonHoc.Text == "" && Tb_TenMonHoc.Text == "")
            {
                MessageBox.Show("Mã kỳ thi và tên kỳ thi phải được điền!");
            }
            STT = "Sua";
        }

        private void Btn_Xoa_Click(object sender, EventArgs e)
        {
            String st = "DELETE Tb_MonThi WHERE MaMon=@MaMon";
            SqlCommand sqlcom = new(st, cnn);
            sqlcom.Parameters.AddWithValue("@MaMon", Tb_MaMonHoc.Text);
            //sqlcom.Parameters.AddWithValue("@TenMon", Tb_TenMonHoc.Text);

            try
            {
                cnn.Open();
                sqlcom.ExecuteNonQuery();
                MessageBox.Show("Xoá Thành Công");
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message + "\nLỗi!!!");
            }
            finally
            {
                cnn.Close();
            }
        }
    }
}
