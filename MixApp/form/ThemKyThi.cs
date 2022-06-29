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
    public partial class ThemKyThi : Form
    {
        public ThemKyThi()
        {
            InitializeComponent();
        }
        SqlConnection cnn = new(@"Data Source=DESKTOP-0VCPB7O;Initial Catalog=Mix_App;Integrated Security=True");
        private string _message;
        public string _message1;
        string STT = "Sua";

        private void ThemKyThi_Load(object sender, EventArgs e)
        {
            Data_KyThi();
            //if(_message == "Them")
            //{
            //    Tb_MaKyThi.ReadOnly = false;
            //}

            //if(_message =="Sua")
            //{
            //    DL_KyThi();
            //    Tb_TenKyThi.Select();  
            //}    
        }
        public string Message
        {
            get { return _message; }
            set { _message = value; }
        }

        public string Message1
        {
            get { return _message1; }
            set { _message1 = value; }
        }

        private void ThemKyThi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
        public void Them_Ky_Thi()
        {
            String st = "INSERT INTO Tb_KyThi(MaKyThi,TenKyThi,GhiChu) VALUES(@MaKyThi,@TenKyThi,@GhiChu)";
            SqlCommand sqlcom = new(st, cnn);
            sqlcom.Parameters.AddWithValue("@MaKyThi", Tb_MaKyThi.Text);
            sqlcom.Parameters.AddWithValue("@TenKyThi", Tb_TenKyThi.Text);
            sqlcom.Parameters.AddWithValue("@GhiChu", Rtb_GhiChu.Text);
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
        private void Btn_TroVe_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Luu_Click(object sender, EventArgs e)
        {
            if (Tb_MaKyThi.Text != "" && STT == "Them")
            {
                Them_Ky_Thi();
                Data_KyThi();
                
            }
            if (Tb_MaKyThi.Text !=  "" && STT == "Sua")
            {
                Sua_KyThi();
                Data_KyThi();
            }
            if (Tb_MaKyThi.Text == "")
            {
                MessageBox.Show("Mã kỳ thi phải được điền!");
            }
            STT = "Sua";
        }



        public void Data_KyThi()
        {
            cnn.Open();
            string sql = "SELECT * FROM Tb_KyThi";  // lay het du lieu trong bang sinh vien

            SqlCommand com = new(sql, cnn); //bat dau truy van
            com.CommandType = CommandType.Text;
            SqlDataAdapter da1 = new(com); //chuyen du lieu ve         
            DataTable dt = new(); //tạo một kho ảo để lưu trữ dữ liệu
            da1.Fill(dt);  // đổ dữ liệu vào kho
            cnn.Close();  // đóng kết nối
            Dgv_KyThi.DataSource = dt; //đổ dữ liệu vào datagridview

        }

        private void Dgv_KyThi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //gets a collection that contains all the rows
                DataGridViewRow row = this.Dgv_KyThi.Rows[e.RowIndex];
                //populate the textbox from specific value of the coordinates of column and row.
                Tb_MaKyThi.Text = row.Cells[0].Value.ToString();
                Tb_TenKyThi.Text = row.Cells[1].Value.ToString();
                Rtb_GhiChu.Text = row.Cells[2].Value.ToString();
                //Btn_SuaKyThi.Enabled = true;
                //Btn_XoaKyThi.Enabled = true;
            }
        }

        private void Btn_Them_Click(object sender, EventArgs e)
        {
            STT = "Them";
            Tb_MaKyThi.Text = Tb_TenKyThi.Text = Rtb_GhiChu.Text = null;
            Tb_MaKyThi.Focus();
        }
        public void Sua_KyThi()
        {
            String st = "UPDATE Tb_KyThi SET TenKyThi=@TenKyThi, GhiChu=@GhiChu WHERE MaKyThi=@MaKyThi";
            SqlCommand sqlcom = new(st, cnn);
            sqlcom.Parameters.AddWithValue("@MaKyThi", Tb_MaKyThi.Text);
            sqlcom.Parameters.AddWithValue("@TenKyThi", Tb_TenKyThi.Text);
            sqlcom.Parameters.AddWithValue("@GhiChu", Rtb_GhiChu.Text);
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

        private void Btn_CapNhat_Click(object sender, EventArgs e)
        {
            Data_KyThi();
        }

        private void Btn_Xoa_Click(object sender, EventArgs e)
        {
            String st = "Delete from Tb_KyThi WHERE MaKyThi=@MaKyThi";
            SqlCommand sqlcom = new(st, cnn);
            sqlcom.Parameters.AddWithValue("@MaKyThi", Tb_MaKyThi.Text);
            
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

