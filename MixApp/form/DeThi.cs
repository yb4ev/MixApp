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
    public partial class DeThi : Form
    {
        public DeThi()
        {
            InitializeComponent();
        }
        SqlConnection cnn = new(@"Data Source=DESKTOP-0VCPB7O;Initial Catalog=Mix_App;Integrated Security=True");
        private void DeThi_Load(object sender, EventArgs e)
        {
            Data_KyThi();
            Data_MonThi();
        }

        public void Data_KyThi()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Tb_KyThi", cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Cbb_KyThi.DataSource = dt;
            Cbb_KyThi.DisplayMember = "TenKyThi";
            Cbb_KyThi.ValueMember = "MaKyThi";
        }

        public void Data_MonThi()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Tb_MonThi", cnn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Cbb_MonThi.DataSource = dt;
            Cbb_MonThi.DisplayMember = "TenMon";
            Cbb_MonThi.ValueMember = "MaMon";
        }
        public void Data_DeThi()
        {
            cnn.Open();
            string sql = "SELECT * FROM Tb_DeThi where MaMon=@MaMon and MaKyThi=@MaKyThi";  // lay het du lieu trong bang sinh vien
            
            SqlCommand com = new(sql, cnn); //bat dau truy van
            com.CommandType = CommandType.Text;
            SqlDataAdapter da1 = new(com); //chuyen du lieu ve
            da1.SelectCommand.Parameters.AddWithValue("@MaMon", Cbb_MonThi.SelectedValue);
            da1.SelectCommand.Parameters.AddWithValue("@MaKyThi", Cbb_KyThi.SelectedValue);
            DataTable dt = new(); //tạo một kho ảo để lưu trữ dữ liệu
            da1.Fill(dt);  // đổ dữ liệu vào kho
            cnn.Close();  // đóng kết nối
            Dgv_DeThi.DataSource = dt; //đổ dữ liệu vào datagridview

        }

        private void Btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_LamMoi_Click(object sender, EventArgs e)
        {
            Data_KyThi();
            Data_MonThi();
            Dgv_DeThi.DataSource = null;
        }

        private void Btn_TimDe_Click(object sender, EventArgs e)
        {
            Data_DeThi();
        }

        private void Btn_ThemKyThi_Click(object sender, EventArgs e)
        {
            form.ThemKyThi f = new();
            f.ShowDialog();
        }

        private void Btn_ThemMon_Click(object sender, EventArgs e)
        {
            form.ThemMonHoc f = new();
            f.ShowDialog();
        }

        private void Dgv_DeThi_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            form.DanhSachCauHoi f = new();
            f.ShowDialog();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            form.ThemDeThi f = new();
            f.ShowDialog();
        }

        private void Dgv_DeThi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Btn_DeMoi_Click(object sender, EventArgs e)
        {
            form.ThemDeThi f = new();
            f.ShowDialog();
        }
    }
}
