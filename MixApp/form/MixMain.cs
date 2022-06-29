using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;



namespace MixApp
{
    public partial class MixMain : Form
    {
        

        public MixMain()
        {
            InitializeComponent();
        }

        SqlConnection cnn = new(@"Data Source=DESKTOP-0VCPB7O;Initial Catalog=Mix_App;Integrated Security=True");
        string STT_KyThi = "";
        private void Btn_ThemKyThi_Click(object sender, EventArgs e)
        {
            //Form2 Child = new Form2();
            //Child.Message = txtValue.Text;
            //Child.Show();
            STT_KyThi = "Them";
            form.ThemKyThi f = new form.ThemKyThi();
            f.Message = STT_KyThi.ToString();
            f.ShowDialog();
        }

        private void Btn_SuaKyThi_Click(object sender, EventArgs e)
        {
            STT_KyThi = "Sua";
            form.ThemKyThi f = new form.ThemKyThi();
            f.Message = STT_KyThi.ToString();
            f.Message1 = Tb_KyThi.ToString();
            f.ShowDialog();
        }

        private void Btn_XoaKyThi_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn muốn xoá kỳ thi?", "Xoá kỳ thi", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                //do something
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
        }

        private void Btn_ThemDeThi_Click(object sender, EventArgs e)
        {
            form.ThemDeThi f = new();
            f.ShowDialog();
        }

        private void Btn_SuaDeThi_Click(object sender, EventArgs e)
        {
            form.ThemDeThi f = new();
            f.ShowDialog();
        }

        private void Btn_XoaDeThi_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn muốn đề thi đã chọn?", "Xoá đề thi", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                //do something
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
        }

        private void Btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_TaoDeThi_Click(object sender, EventArgs e)
        {
            form.DeThi f = new();
            f.ShowDialog();
        }
        public void DL_KyThi()
        {
            cnn.Open();
            string sql = "select * from Tb_KyThi";  // lay het du lieu trong bang sinh vien
            SqlCommand com = new(sql, cnn); //bat dau truy van
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new(com); //chuyen du lieu ve
            DataTable dt = new(); //tạo một kho ảo để lưu trữ dữ liệu
            da.Fill(dt);  // đổ dữ liệu vào kho
            cnn.Close();  // đóng kết nối
            dataGridView_Kythi.DataSource = dt; //đổ dữ liệu vào datagridview
        }
        public void DL_DeThi()
        {
            cnn.Open();
            string sql = "SELECT Tb_DeThi.MaDeThi, Tb_MonThi.TenMon, Tb_DeThi.ThoiGian, Tb_DeThi.SoCau FROM Tb_DeThi INNER JOIN Tb_MonThi ON Tb_DeThi.MaMon = Tb_MonThi.MaMon";  // lay het du lieu trong bang sinh vien
            SqlCommand com = new(sql, cnn); //bat dau truy van
            com.CommandType = CommandType.Text;
            SqlDataAdapter da1 = new(com); //chuyen du lieu ve
            DataTable dt = new(); //tạo một kho ảo để lưu trữ dữ liệu
            da1.Fill(dt);  // đổ dữ liệu vào kho
            cnn.Close();  // đóng kết nối
            dataGridView_DeThi.DataSource = dt; //đổ dữ liệu vào datagridview
        }

        public void MixMain_Load(object sender, EventArgs e)
        {
            DL_KyThi();
            DL_DeThi();
        }

        private void dataGridView_Kythi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //gets a collection that contains all the rows
                DataGridViewRow row = this.dataGridView_Kythi.Rows[e.RowIndex];
                //populate the textbox from specific value of the coordinates of column and row.
                Tb_KyThi.Text = row.Cells[1].Value.ToString();
                Btn_SuaKyThi.Enabled = true;
                Btn_XoaKyThi.Enabled = true;
            }
            
        }

        private void dataGridView_DeThi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //gets a collection that contains all the rows
                DataGridViewRow row = this.dataGridView_DeThi.Rows[e.RowIndex];
                //populate the textbox from specific value of the coordinates of column and row.
                Tb_MonThi.Text = row.Cells[1].Value.ToString();
                Btn_SuaDeThi.Enabled = true;
                Btn_XoaDeThi.Enabled = true;
            }
            
        }
    }
}
