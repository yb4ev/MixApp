using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MixApp.form;
using System.IO;
using Aspose.Words;
using Aspose.Words.Tables;
using System.Data.SqlClient;

namespace MixApp.form
{
    public partial class DanhSachCauHoi : Form
    {
        private string Stt = "";
        public DanhSachCauHoi()
        {
            InitializeComponent();
            
        }
        SqlConnection cnn = new(@"Data Source=DESKTOP-0VCPB7O;Initial Catalog=Mix_App;Integrated Security=True");
        private void Btn_TroVe_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_InDe_Click(object sender, EventArgs e)
        {
            
            Document doc = new Document("F:\\MixApp\\MixApp\\MixApp\\documentB.docx");
            DocumentBuilder builder = new DocumentBuilder(doc);
            string CauHoi,DA1,DA2,DA3,DA4;
            int i;
           

            for ( i = 1; i <= Dgv_CauHoi.Rows[i].Cells.Count; i++)
            {   
                CauHoi = Dgv_CauHoi.Rows[i].Cells["CauHoi"].Value.ToString();
                builder.Writeln("Câu " + i.ToString()+": " + CauHoi.ToString());
                DA1 = Dgv_CauHoi.Rows[i].Cells["DA1"].Value.ToString();
                builder.Writeln("A. "+DA1.ToString());
                DA2 = Dgv_CauHoi.Rows[i].Cells["DA2"].Value.ToString();
                builder.Writeln("B. "+DA2.ToString());
                DA3 = Dgv_CauHoi.Rows[i].Cells["DA3"].Value.ToString();
                builder.Writeln("C. "+DA3.ToString());
                DA4 = Dgv_CauHoi.Rows[i].Cells["DA4"].Value.ToString();
                builder.Writeln("D. "+DA4.ToString()+"\n");
            }




            // Save the document to disk.
            doc.Save("F:\\MixApp\\MixApp\\MixApp\\documentB.docx");
            
            MessageBox.Show("In thành công");



        }
        public void Data_CauHoi()
        {
            cnn.Open();
            string sql = "SELECT MaCauHoi,MaMon,CauHoi,DA1,DA2,DA3,DA4 FROM Tb_CauHoi";  // lay het du lieu trong bang sinh vien

            SqlCommand com = new(sql, cnn); //bat dau truy van
            com.CommandType = CommandType.Text;
            SqlDataAdapter da1 = new(com); //chuyen du lieu ve
            
            DataTable dt = new(); //tạo một kho ảo để lưu trữ dữ liệu
            da1.Fill(dt);  // đổ dữ liệu vào kho
            cnn.Close();  // đóng kết nối
            Dgv_CauHoi.DataSource = dt; //đổ dữ liệu vào datagridview

        }
        private void DanhSachCauHoi_Load(object sender, EventArgs e)
        {
            
            Data_DeThi();
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
        private void Dgv_CauHoi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //gets a collection that contains all the rows
                DataGridViewRow row = this.Dgv_CauHoi.Rows[e.RowIndex];
                //populate the textbox from specific value of the coordinates of column and row.
                Tb_MaCauHoi.Text = row.Cells[1].Value.ToString();
                Tb_MaKyThi.Text = row.Cells[0].Value.ToString();
                Tb_MaMonThi.Text = row.Cells[2].Value.ToString();
                Rtb_CauHoi.Text = row.Cells[3].Value.ToString();
                Tb_DA1.Text = row.Cells[4].Value.ToString();
                Tb_DA2.Text = row.Cells[5].Value.ToString();
                Tb_DA3.Text = row.Cells[6].Value.ToString();
                Tb_DA4.Text = row.Cells[7].Value.ToString();
            }
        }

        private void Btn_DaoDe_Click(object sender, EventArgs e)
        {
            //SELECT TOP 2 * FROM Tb_CauHoi ORDER BY NEWID()
            
                cnn.Open();
                string sql = "SELECT TOP "+num_CauHoi.Value+" MaCauHoi,MaMon,CauHoi,DA1,DA2,DA3,DA4 FROM Tb_CauHoi ORDER BY NEWID()";  // lay het du lieu trong bang sinh vien

                SqlCommand com = new(sql, cnn); //bat dau truy van
                com.CommandType = CommandType.Text;
                SqlDataAdapter da1 = new(com); //chuyen du lieu ve

                DataTable dt = new(); //tạo một kho ảo để lưu trữ dữ liệu
                da1.Fill(dt);  // đổ dữ liệu vào kho
                cnn.Close();  // đóng kết nối
                Dgv_CauHoi.DataSource = dt; //đổ dữ liệu vào datagridview

            
        }

        private void Btn_ChonDe_Click(object sender, EventArgs e)
        {
            cnn.Open();
            string sql = "SELECT MaKyThi,MaCauHoi,MaMon,CauHoi,DA1,DA2,DA3,DA4 FROM Tb_CauHoi Where MaDeThi=@MaDeThi";  // lay het du lieu trong bang sinh vien
            
            SqlCommand com = new(sql, cnn); //bat dau truy van
            com.Parameters.AddWithValue("@MaDeThi", Cbb_MaDeThi.Text);
            com.CommandType = CommandType.Text;
            SqlDataAdapter da1 = new(com); //chuyen du lieu ve

            DataTable dt = new(); //tạo một kho ảo để lưu trữ dữ liệu
            da1.Fill(dt);  // đổ dữ liệu vào kho
            cnn.Close();  // đóng kết nối
            Dgv_CauHoi.DataSource = dt; //đổ dữ liệu vào datagridview
        }

        private void Btn_ThemCauHoi_Click(object sender, EventArgs e)
        {
            Tb_MaCauHoi.Text = Rtb_CauHoi.Text = Tb_DA1.Text = Tb_DA2.Text = Tb_DA3.Text = Tb_DA4.Text = null;
            Stt = "Them";
            Btn_Luu.Enabled = true;
        }
        public void Them_CauHoi()
        {
            String st = "INSERT INTO Tb_CauHoi(MaCauHoi,MaKyThi,MaMon,MaDeThi,CauHoi,DA1,DA2,DA3,DA4) VALUES(@MaCauHoi,@MaKyThi,@MaMon,@MaDeThi,@CauHoi,@DA1,@DA2,@DA3,@DA4)";
            SqlCommand sqlcom = new(st, cnn);
            sqlcom.Parameters.AddWithValue("@MaCauHoi", Tb_MaCauHoi.Text);
            sqlcom.Parameters.AddWithValue("@MaKyThi", Tb_MaKyThi.Text);
            sqlcom.Parameters.AddWithValue("@MaMon", Tb_MaMonThi.Text);
            sqlcom.Parameters.AddWithValue("@MaDeThi", Cbb_MaDeThi.Text);
            sqlcom.Parameters.AddWithValue("@CauHoi", Rtb_CauHoi.Text);
            sqlcom.Parameters.AddWithValue("@DA1", Tb_DA1.Text);
            sqlcom.Parameters.AddWithValue("@DA2", Tb_DA2.Text);
            sqlcom.Parameters.AddWithValue("@DA3", Tb_DA3.Text);
            sqlcom.Parameters.AddWithValue("@DA4", Tb_DA4.Text);
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
        private void Load_Data()
        {
            cnn.Open();
            string sql = "SELECT MaKyThi,MaCauHoi,MaMon,CauHoi,DA1,DA2,DA3,DA4 FROM Tb_CauHoi Where MaDeThi=@MaDeThi";  // lay het du lieu trong bang sinh vien

            SqlCommand com = new(sql, cnn); //bat dau truy van
            com.Parameters.AddWithValue("@MaDeThi", Cbb_MaDeThi.Text);
            com.CommandType = CommandType.Text;
            SqlDataAdapter da1 = new(com); //chuyen du lieu ve

            DataTable dt = new(); //tạo một kho ảo để lưu trữ dữ liệu
            da1.Fill(dt);  // đổ dữ liệu vào kho
            cnn.Close();  // đóng kết nối
            Dgv_CauHoi.DataSource = dt; //đổ dữ liệu vào datagridview
            
        }
        public void Sua_KyThi()
        {
            String st = "UPDATE Tb_CauHoi SET CauHoi=@CauHoi,DA1=@DA1,DA2=@DA2,DA3=@DA3,DA4=@DA4 WHERE MaCauHoi=@MaCauHoi and MaKyThi=@MaKyThi and MaMon=@MaMon and MaDeThi = @MaDeThi";
            SqlCommand sqlcom = new(st, cnn);
            sqlcom.Parameters.AddWithValue("@CauHoi", Rtb_CauHoi.Text);
            sqlcom.Parameters.AddWithValue("@DA1", Tb_DA1.Text);
            sqlcom.Parameters.AddWithValue("@DA2", Tb_DA2.Text);
            sqlcom.Parameters.AddWithValue("@DA3", Tb_DA3.Text);
            sqlcom.Parameters.AddWithValue("@DA4", Tb_DA4.Text);
            sqlcom.Parameters.AddWithValue("@MaCauHoi", Tb_MaCauHoi.Text);
            sqlcom.Parameters.AddWithValue("@MaKyThi", Tb_MaKyThi.Text);
            sqlcom.Parameters.AddWithValue("@MaMon", Tb_MaMonThi.Text);
            sqlcom.Parameters.AddWithValue("@MaDeThi", Cbb_MaDeThi.Text);
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
        public void Xoa_CauHoi()
        {
            String st = "Delete from Tb_CauHoi WHERE MaCauHoi=@MaCauHoi and MaKyThi=@MaKyThi and MaMon=@MaMon and MaDeThi = @MaDeThi";
            SqlCommand sqlcom = new(st, cnn);
            sqlcom.Parameters.AddWithValue("@MaCauHoi", Tb_MaCauHoi.Text);
            sqlcom.Parameters.AddWithValue("@MaKyThi", Tb_MaKyThi.Text);
            sqlcom.Parameters.AddWithValue("@MaMon", Tb_MaMonThi.Text);
            sqlcom.Parameters.AddWithValue("@MaDeThi", Cbb_MaDeThi.Text);
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
        private void Btn_Luu_Click(object sender, EventArgs e)
        {
            if(Stt=="Them")
            {
                Them_CauHoi();
                Load_Data();
                Btn_Luu.Enabled = false;
                Stt = "";
            }
            else
            {
                Sua_KyThi();
                Load_Data();
                
            }    
        }

        private void Btn_Xoa_Click(object sender, EventArgs e)
        {
            Xoa_CauHoi();
            Load_Data();
        }
    }
}
