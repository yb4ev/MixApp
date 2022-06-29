
namespace MixApp.form
{
    partial class DanhSachCauHoi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DanhSachCauHoi));
            this.Dgv_CauHoi = new System.Windows.Forms.DataGridView();
            this.MaCauHoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaKyThi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CauHoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DA1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DA2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DA3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DA4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_Luu = new System.Windows.Forms.Button();
            this.Btn_TroVe = new System.Windows.Forms.Button();
            this.Btn_InDe = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Tb_MaCauHoi = new System.Windows.Forms.TextBox();
            this.Rtb_CauHoi = new System.Windows.Forms.RichTextBox();
            this.Tb_MaMonThi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Tb_DA1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Tb_DA2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Tb_DA3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Tb_DA4 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Btn_DaoDe = new System.Windows.Forms.Button();
            this.num_CauHoi = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.Cbb_MaDeThi = new System.Windows.Forms.ComboBox();
            this.Btn_ChonDe = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.Btn_ThemCauHoi = new System.Windows.Forms.Button();
            this.Tb_MaKyThi = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.Btn_Xoa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_CauHoi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_CauHoi)).BeginInit();
            this.SuspendLayout();
            // 
            // Dgv_CauHoi
            // 
            this.Dgv_CauHoi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_CauHoi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaCauHoi,
            this.MaKyThi,
            this.MaMon,
            this.CauHoi,
            this.DA1,
            this.DA2,
            this.DA3,
            this.DA4});
            this.Dgv_CauHoi.Location = new System.Drawing.Point(43, 326);
            this.Dgv_CauHoi.Name = "Dgv_CauHoi";
            this.Dgv_CauHoi.ReadOnly = true;
            this.Dgv_CauHoi.RowTemplate.Height = 25;
            this.Dgv_CauHoi.Size = new System.Drawing.Size(861, 274);
            this.Dgv_CauHoi.TabIndex = 0;
            this.Dgv_CauHoi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_CauHoi_CellClick);
            // 
            // MaCauHoi
            // 
            this.MaCauHoi.DataPropertyName = "MaCauHoi";
            this.MaCauHoi.HeaderText = "Mã câu hỏi";
            this.MaCauHoi.Name = "MaCauHoi";
            this.MaCauHoi.ReadOnly = true;
            this.MaCauHoi.Width = 75;
            // 
            // MaKyThi
            // 
            this.MaKyThi.DataPropertyName = "MaKyThi";
            this.MaKyThi.HeaderText = "Mã kỳ thi";
            this.MaKyThi.Name = "MaKyThi";
            this.MaKyThi.ReadOnly = true;
            // 
            // MaMon
            // 
            this.MaMon.DataPropertyName = "MaMon";
            this.MaMon.HeaderText = "Mã môn thi";
            this.MaMon.Name = "MaMon";
            this.MaMon.ReadOnly = true;
            this.MaMon.Width = 75;
            // 
            // CauHoi
            // 
            this.CauHoi.DataPropertyName = "CauHoi";
            this.CauHoi.HeaderText = "Câu hỏi";
            this.CauHoi.Name = "CauHoi";
            this.CauHoi.ReadOnly = true;
            this.CauHoi.Width = 200;
            // 
            // DA1
            // 
            this.DA1.DataPropertyName = "DA1";
            this.DA1.HeaderText = "Đáp án 1";
            this.DA1.Name = "DA1";
            this.DA1.ReadOnly = true;
            // 
            // DA2
            // 
            this.DA2.DataPropertyName = "DA2";
            this.DA2.HeaderText = "Đáp án 2";
            this.DA2.Name = "DA2";
            this.DA2.ReadOnly = true;
            // 
            // DA3
            // 
            this.DA3.DataPropertyName = "DA3";
            this.DA3.HeaderText = "Đáp án 3";
            this.DA3.Name = "DA3";
            this.DA3.ReadOnly = true;
            // 
            // DA4
            // 
            this.DA4.DataPropertyName = "DA4";
            this.DA4.HeaderText = "Đáp án 4";
            this.DA4.Name = "DA4";
            this.DA4.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Danh sách câu hỏi";
            // 
            // Btn_Luu
            // 
            this.Btn_Luu.Location = new System.Drawing.Point(608, 629);
            this.Btn_Luu.Name = "Btn_Luu";
            this.Btn_Luu.Size = new System.Drawing.Size(75, 23);
            this.Btn_Luu.TabIndex = 2;
            this.Btn_Luu.Text = "Lưu";
            this.Btn_Luu.UseVisualStyleBackColor = true;
            this.Btn_Luu.Click += new System.EventHandler(this.Btn_Luu_Click);
            // 
            // Btn_TroVe
            // 
            this.Btn_TroVe.Location = new System.Drawing.Point(828, 631);
            this.Btn_TroVe.Name = "Btn_TroVe";
            this.Btn_TroVe.Size = new System.Drawing.Size(75, 23);
            this.Btn_TroVe.TabIndex = 3;
            this.Btn_TroVe.Text = "Trở về";
            this.Btn_TroVe.UseVisualStyleBackColor = true;
            this.Btn_TroVe.Click += new System.EventHandler(this.Btn_TroVe_Click);
            // 
            // Btn_InDe
            // 
            this.Btn_InDe.Location = new System.Drawing.Point(367, 629);
            this.Btn_InDe.Name = "Btn_InDe";
            this.Btn_InDe.Size = new System.Drawing.Size(113, 23);
            this.Btn_InDe.TabIndex = 4;
            this.Btn_InDe.Text = "In đề";
            this.Btn_InDe.UseVisualStyleBackColor = true;
            this.Btn_InDe.Click += new System.EventHandler(this.Btn_InDe_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mã câu hỏi";
            // 
            // Tb_MaCauHoi
            // 
            this.Tb_MaCauHoi.Location = new System.Drawing.Point(50, 139);
            this.Tb_MaCauHoi.Name = "Tb_MaCauHoi";
            this.Tb_MaCauHoi.Size = new System.Drawing.Size(184, 23);
            this.Tb_MaCauHoi.TabIndex = 6;
            // 
            // Rtb_CauHoi
            // 
            this.Rtb_CauHoi.Location = new System.Drawing.Point(300, 102);
            this.Rtb_CauHoi.Name = "Rtb_CauHoi";
            this.Rtb_CauHoi.Size = new System.Drawing.Size(604, 80);
            this.Rtb_CauHoi.TabIndex = 7;
            this.Rtb_CauHoi.Text = "";
            // 
            // Tb_MaMonThi
            // 
            this.Tb_MaMonThi.Location = new System.Drawing.Point(50, 259);
            this.Tb_MaMonThi.Name = "Tb_MaMonThi";
            this.Tb_MaMonThi.Size = new System.Drawing.Size(184, 23);
            this.Tb_MaMonThi.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Mã môn thi";
            // 
            // Tb_DA1
            // 
            this.Tb_DA1.Location = new System.Drawing.Point(299, 203);
            this.Tb_DA1.Name = "Tb_DA1";
            this.Tb_DA1.Size = new System.Drawing.Size(270, 23);
            this.Tb_DA1.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(299, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Đáp án 1";
            // 
            // Tb_DA2
            // 
            this.Tb_DA2.Location = new System.Drawing.Point(623, 203);
            this.Tb_DA2.Name = "Tb_DA2";
            this.Tb_DA2.Size = new System.Drawing.Size(280, 23);
            this.Tb_DA2.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(623, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "Đáp án 2";
            // 
            // Tb_DA3
            // 
            this.Tb_DA3.Location = new System.Drawing.Point(299, 259);
            this.Tb_DA3.Name = "Tb_DA3";
            this.Tb_DA3.Size = new System.Drawing.Size(270, 23);
            this.Tb_DA3.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(299, 241);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 15);
            this.label6.TabIndex = 14;
            this.label6.Text = "Đáp án 3";
            // 
            // Tb_DA4
            // 
            this.Tb_DA4.Location = new System.Drawing.Point(623, 259);
            this.Tb_DA4.Name = "Tb_DA4";
            this.Tb_DA4.Size = new System.Drawing.Size(280, 23);
            this.Tb_DA4.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(623, 241);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 15);
            this.label7.TabIndex = 16;
            this.label7.Text = "Đáp án 4";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(304, 83);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 15);
            this.label8.TabIndex = 18;
            this.label8.Text = "Câu hỏi";
            // 
            // Btn_DaoDe
            // 
            this.Btn_DaoDe.Location = new System.Drawing.Point(169, 631);
            this.Btn_DaoDe.Name = "Btn_DaoDe";
            this.Btn_DaoDe.Size = new System.Drawing.Size(75, 23);
            this.Btn_DaoDe.TabIndex = 19;
            this.Btn_DaoDe.Text = "Chọn";
            this.Btn_DaoDe.UseVisualStyleBackColor = true;
            this.Btn_DaoDe.Click += new System.EventHandler(this.Btn_DaoDe_Click);
            // 
            // num_CauHoi
            // 
            this.num_CauHoi.Location = new System.Drawing.Point(43, 631);
            this.num_CauHoi.Name = "num_CauHoi";
            this.num_CauHoi.Size = new System.Drawing.Size(120, 23);
            this.num_CauHoi.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(43, 613);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 15);
            this.label9.TabIndex = 21;
            this.label9.Text = "Số lượng câu hỏi";
            // 
            // Cbb_MaDeThi
            // 
            this.Cbb_MaDeThi.FormattingEnabled = true;
            this.Cbb_MaDeThi.Location = new System.Drawing.Point(50, 60);
            this.Cbb_MaDeThi.Name = "Cbb_MaDeThi";
            this.Cbb_MaDeThi.Size = new System.Drawing.Size(144, 23);
            this.Cbb_MaDeThi.TabIndex = 25;
            // 
            // Btn_ChonDe
            // 
            this.Btn_ChonDe.Location = new System.Drawing.Point(200, 60);
            this.Btn_ChonDe.Name = "Btn_ChonDe";
            this.Btn_ChonDe.Size = new System.Drawing.Size(75, 23);
            this.Btn_ChonDe.TabIndex = 24;
            this.Btn_ChonDe.Text = "Chọn đề";
            this.Btn_ChonDe.UseVisualStyleBackColor = true;
            this.Btn_ChonDe.Click += new System.EventHandler(this.Btn_ChonDe_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(50, 42);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 15);
            this.label10.TabIndex = 23;
            this.label10.Text = "Mã đề thi";
            // 
            // Btn_ThemCauHoi
            // 
            this.Btn_ThemCauHoi.Location = new System.Drawing.Point(486, 631);
            this.Btn_ThemCauHoi.Name = "Btn_ThemCauHoi";
            this.Btn_ThemCauHoi.Size = new System.Drawing.Size(116, 23);
            this.Btn_ThemCauHoi.TabIndex = 26;
            this.Btn_ThemCauHoi.Text = "Thêm câu hỏi";
            this.Btn_ThemCauHoi.UseVisualStyleBackColor = true;
            this.Btn_ThemCauHoi.Click += new System.EventHandler(this.Btn_ThemCauHoi_Click);
            // 
            // Tb_MaKyThi
            // 
            this.Tb_MaKyThi.Location = new System.Drawing.Point(50, 203);
            this.Tb_MaKyThi.Name = "Tb_MaKyThi";
            this.Tb_MaKyThi.Size = new System.Drawing.Size(184, 23);
            this.Tb_MaKyThi.TabIndex = 28;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(50, 185);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 15);
            this.label11.TabIndex = 27;
            this.label11.Text = "Mã kỳ thi";
            // 
            // Btn_Xoa
            // 
            this.Btn_Xoa.Location = new System.Drawing.Point(689, 629);
            this.Btn_Xoa.Name = "Btn_Xoa";
            this.Btn_Xoa.Size = new System.Drawing.Size(75, 23);
            this.Btn_Xoa.TabIndex = 29;
            this.Btn_Xoa.Text = "Xoá";
            this.Btn_Xoa.UseVisualStyleBackColor = true;
            this.Btn_Xoa.Click += new System.EventHandler(this.Btn_Xoa_Click);
            // 
            // DanhSachCauHoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 685);
            this.Controls.Add(this.Btn_Xoa);
            this.Controls.Add(this.Tb_MaKyThi);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.Btn_ThemCauHoi);
            this.Controls.Add(this.Cbb_MaDeThi);
            this.Controls.Add(this.Btn_ChonDe);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.num_CauHoi);
            this.Controls.Add(this.Btn_DaoDe);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Tb_DA4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Tb_DA3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Tb_DA2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Tb_DA1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Tb_MaMonThi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Rtb_CauHoi);
            this.Controls.Add(this.Tb_MaCauHoi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Btn_InDe);
            this.Controls.Add(this.Btn_TroVe);
            this.Controls.Add(this.Btn_Luu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Dgv_CauHoi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DanhSachCauHoi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh sách câu hỏi";
            this.Load += new System.EventHandler(this.DanhSachCauHoi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_CauHoi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_CauHoi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Dgv_CauHoi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_Luu;
        private System.Windows.Forms.Button Btn_TroVe;
        private System.Windows.Forms.Button Btn_InDe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Tb_MaCauHoi;
        private System.Windows.Forms.RichTextBox Rtb_CauHoi;
        private System.Windows.Forms.TextBox Tb_MaMonThi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Tb_DA1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Tb_DA2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Tb_DA3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Tb_DA4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button Btn_DaoDe;
        private System.Windows.Forms.NumericUpDown num_CauHoi;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox Cbb_MaDeThi;
        private System.Windows.Forms.Button Btn_ChonDe;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button Btn_ThemCauHoi;
        private System.Windows.Forms.TextBox Tb_MaKyThi;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaCauHoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKyThi;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn CauHoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn DA1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DA2;
        private System.Windows.Forms.DataGridViewTextBoxColumn DA3;
        private System.Windows.Forms.DataGridViewTextBoxColumn DA4;
        private System.Windows.Forms.Button Btn_Xoa;
    }
}