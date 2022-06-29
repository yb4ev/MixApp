using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MixApp.form
{
    public partial class ThemDeThi : Form
    {
        public ThemDeThi()
        {
            InitializeComponent();
        }
        SqlConnection cnn = new(@"Data Source=DESKTOP-0VCPB7O;Initial Catalog=Mix_App;Integrated Security=True");
        string STT = "Sua";
        private void ThemDeThi_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void Btn_TroVe_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_ThemSua_MonHoc_Click(object sender, EventArgs e)
        {
            form.ThemMonHoc f = new();
            f.ShowDialog();
        }

        private void Btn_TaoDe_Click(object sender, EventArgs e)
        {
            form.DanhSachCauHoi f = new();
            f.ShowDialog();
        }

        private void Btn_Luu_Click(object sender, EventArgs e)
        {
            if(STT=="Them")
            {
                Them_De_Thi();
                Data_DeThi();
            }    
            if(STT=="Sua")
            {
                Sua_De_Thi();
                Data_DeThi();
            }    
            STT = "Sua";
        }

        private void ThemDeThi_Load(object sender, EventArgs e)
        {
            Data_DeThi();
            Data_MonHoc();
            Data_KyThi();
        }

        public void Data_KyThi()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Tb_KyThi", cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Cbb_MaKyThi.DataSource = dt;
            Cbb_MaKyThi.DisplayMember = "MaKyThi";
            Cbb_MaKyThi.ValueMember = "MaKyThi";
        }
        public void Data_DeThi()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Tb_DeThi", cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Cbb_MaDeThi.DataSource = dt;
            Cbb_MaDeThi.DisplayMember = "MaDeThi";
            Cbb_MaDeThi.ValueMember = "MaDeThi";
        }
        public void Data_MonHoc()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Tb_MonThi", cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Cbb_MonHoc.DataSource = dt;
            Cbb_MonHoc.DisplayMember = "TenMon";
            Cbb_MonHoc.ValueMember = "MaMon";
        }
        private void Btn_DeMoi_Click(object sender, EventArgs e)
        {
            Cbb_MaDeThi.Text = Cbb_MonHoc.Text = null;
            numCauHoi.Value = num_ThoiGian.Value = 0;
            Tb_GhiChu1.Text = Tb_GhiChu2.Text = null;
            STT = "Them";

        }

        public void Them_De_Thi()
        {
            String st = "INSERT INTO Tb_DeThi(MaDeThi,MaKyThi,MaMon,ThoiGian,SoCau,GhiChu1,GhiChu2) VALUES(@MaDeThi,@MaKyThi,@MaMon,@ThoiGian,@SoCau,@GhiChu1,@GhiChu2)";
            SqlCommand sqlcom = new(st, cnn);
            sqlcom.Parameters.AddWithValue("@MaDeThi", Cbb_MaDeThi.Text);
            sqlcom.Parameters.AddWithValue("@MaKyThi", Cbb_MaKyThi.Text);
            sqlcom.Parameters.AddWithValue("@MaMon", Cbb_MonHoc.SelectedValue);
            sqlcom.Parameters.AddWithValue("@ThoiGian", num_ThoiGian.Value);
            sqlcom.Parameters.AddWithValue("@SoCau", numCauHoi.Value);
            sqlcom.Parameters.AddWithValue("@Ghichu1", Tb_GhiChu1.Text);
            sqlcom.Parameters.AddWithValue("@Ghichu2", Tb_GhiChu1.Text);
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
        public void Sua_De_Thi()
        {
            String st = "UPDATE Tb_DeThi SET ThoiGian=@ThoiGian, SoCau=@SoCau, Ghichu1=@Ghichu1, Ghichu2=@Ghichu2 WHERE MaDeThi=@MaDeThi and MaKyThi=@MaKyThi and MaMon=@MaMon";
            SqlCommand sqlcom = new(st, cnn);
            sqlcom.Parameters.AddWithValue("@MaDeThi", Cbb_MaDeThi.Text);
            sqlcom.Parameters.AddWithValue("@MaKyThi", Cbb_MaKyThi.Text);
            sqlcom.Parameters.AddWithValue("@MaMon", Cbb_MonHoc.SelectedValue);
            sqlcom.Parameters.AddWithValue("@ThoiGian", num_ThoiGian.Value);
            sqlcom.Parameters.AddWithValue("@SoCau", numCauHoi.Value);
            sqlcom.Parameters.AddWithValue("@Ghichu1", Tb_GhiChu1.Text);
            sqlcom.Parameters.AddWithValue("@Ghichu2", Tb_GhiChu1.Text);
            try
            {
                cnn.Open();
                sqlcom.ExecuteNonQuery();
                MessageBox.Show("Sửa Thành Công");
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message + "\nLỗiS!\nTrùng mã!!!");
            }
            finally
            {
                cnn.Close();
            }
        }
        public void Xoa_De_Thi()
        {
            String st = "Delete Tb_DeThi Where MaDeThi=@MaDeThi";
            SqlCommand sqlcom = new(st, cnn);
            sqlcom.Parameters.AddWithValue("@MaDeThi", Cbb_MaDeThi.Text);
            //sqlcom.Parameters.AddWithValue("@MaKyThi", Cbb_MaKyThi.Text);
            //sqlcom.Parameters.AddWithValue("@MaMon", Cbb_MonHoc.SelectedValue);
            //sqlcom.Parameters.AddWithValue("@ThoiGian", num_ThoiGian.Text);
            //sqlcom.Parameters.AddWithValue("@SoCau", numCauHoi.Text);
            //sqlcom.Parameters.AddWithValue("@Ghichu1", Tb_GhiChu1.Text);
            //sqlcom.Parameters.AddWithValue("@Ghichu2", Tb_GhiChu1.Text);
            try
            {
                cnn.Open();
                sqlcom.ExecuteNonQuery();
                MessageBox.Show("Xoá Thành Công");
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
        private void Btn_ChonDe_Click(object sender, EventArgs e)
        {
            
            
            //SqlDataAdapter da = new SqlDataAdapter(st, cnn);
           
           
           
           

            //TxtGiaxuat.Text = dt1.Rows[0]["Giaxuat"].ToString().Trim();
            cnn.Open();
            string st = "SELECT  dbo.Tb_DeThi.MaKyThi,dbo.Tb_DeThi.MaDeThi, dbo.Tb_DeThi.ThoiGian, dbo.Tb_DeThi.SoCau, dbo.Tb_DeThi.Ghichu1, dbo.Tb_DeThi.Ghichu2, dbo.Tb_MonThi.TenMon FROM  dbo.Tb_DeThi INNER JOIN dbo.Tb_MonThi ON dbo.Tb_DeThi.MaMon = dbo.Tb_MonThi.MaMon WHERE        (dbo.Tb_DeThi.MaDeThi = @MaDeThi)";
            SqlCommand cmt1 = new SqlCommand(st, cnn)
            {
                CommandType = CommandType.Text
            };
            cmt1.Parameters.AddWithValue("@MaDeThi", Cbb_MaDeThi.Text);
             //bat dau truy van  
            SqlDataAdapter da1 = new(cmt1); //chuyen du lieu ve
            DataTable dt = new(); //tạo một kho ảo để lưu trữ dữ liệu
            da1.Fill(dt);  // đổ dữ liệu vào kho
            SqlDataReader DR1 = cmt1.ExecuteReader();
            if (DR1.Read())
            {
            Cbb_MonHoc.Text = DR1["TenMon"].ToString();
            Tb_GhiChu1.Text = DR1["Ghichu1"].ToString();
            Tb_GhiChu2.Text = DR1["Ghichu2"].ToString();
                numCauHoi.Text = DR1["SoCau"].ToString();
                num_ThoiGian.Text = DR1["ThoiGian"].ToString();
                Cbb_MaKyThi.Text = DR1["MaKyThi"].ToString();
            }
            cnn.Close();  // đóng kết nối
            
            //Tb_GhiChu1.Text = dt.
                //["GhiChu1"].ToString().Trim();
            //dataGridView_DeThi.DataSource = dt; //đổ dữ liệu vào datagridview
        }

        private void Btn_Xoa_Click(object sender, EventArgs e)
        {
            Xoa_De_Thi();
            Data_DeThi();
        }
    }
}
