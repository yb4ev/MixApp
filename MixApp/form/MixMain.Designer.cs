
namespace MixApp
{
    partial class MixMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView_Kythi = new System.Windows.Forms.DataGridView();
            this.MaKyThi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKyThi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView_DeThi = new System.Windows.Forms.DataGridView();
            this.MaDeThi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThoiGian = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoCau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_ThemKyThi = new System.Windows.Forms.Button();
            this.Tb_KyThi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Tb_MonThi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Btn_SuaKyThi = new System.Windows.Forms.Button();
            this.Btn_XoaKyThi = new System.Windows.Forms.Button();
            this.Btn_XoaDeThi = new System.Windows.Forms.Button();
            this.Btn_SuaDeThi = new System.Windows.Forms.Button();
            this.Btn_ThemDeThi = new System.Windows.Forms.Button();
            this.Btn_TaoDeThi = new System.Windows.Forms.Button();
            this.Btn_Thoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Kythi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_DeThi)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_Kythi
            // 
            this.dataGridView_Kythi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Kythi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaKyThi,
            this.TenKyThi,
            this.GhiChu});
            this.dataGridView_Kythi.Location = new System.Drawing.Point(12, 87);
            this.dataGridView_Kythi.Name = "dataGridView_Kythi";
            this.dataGridView_Kythi.ReadOnly = true;
            this.dataGridView_Kythi.RowTemplate.Height = 25;
            this.dataGridView_Kythi.Size = new System.Drawing.Size(322, 390);
            this.dataGridView_Kythi.TabIndex = 0;
            this.dataGridView_Kythi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Kythi_CellClick);
            // 
            // MaKyThi
            // 
            this.MaKyThi.DataPropertyName = "MaKyThi";
            this.MaKyThi.HeaderText = "Mã kỳ thi";
            this.MaKyThi.Name = "MaKyThi";
            this.MaKyThi.ReadOnly = true;
            // 
            // TenKyThi
            // 
            this.TenKyThi.DataPropertyName = "TenKyThi";
            this.TenKyThi.HeaderText = "Tên kỳ thi";
            this.TenKyThi.Name = "TenKyThi";
            this.TenKyThi.ReadOnly = true;
            // 
            // GhiChu
            // 
            this.GhiChu.DataPropertyName = "GhiChu";
            this.GhiChu.HeaderText = "Ghi chú";
            this.GhiChu.Name = "GhiChu";
            this.GhiChu.ReadOnly = true;
            // 
            // dataGridView_DeThi
            // 
            this.dataGridView_DeThi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_DeThi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaDeThi,
            this.TenMon,
            this.ThoiGian,
            this.SoCau});
            this.dataGridView_DeThi.Location = new System.Drawing.Point(353, 87);
            this.dataGridView_DeThi.Name = "dataGridView_DeThi";
            this.dataGridView_DeThi.ReadOnly = true;
            this.dataGridView_DeThi.RowTemplate.Height = 25;
            this.dataGridView_DeThi.Size = new System.Drawing.Size(726, 390);
            this.dataGridView_DeThi.TabIndex = 1;
            this.dataGridView_DeThi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_DeThi_CellClick);
            // 
            // MaDeThi
            // 
            this.MaDeThi.DataPropertyName = "MaDeThi";
            this.MaDeThi.HeaderText = "Mã đề thi";
            this.MaDeThi.Name = "MaDeThi";
            this.MaDeThi.ReadOnly = true;
            // 
            // TenMon
            // 
            this.TenMon.DataPropertyName = "TenMon";
            this.TenMon.HeaderText = "Tên môn thi";
            this.TenMon.Name = "TenMon";
            this.TenMon.ReadOnly = true;
            // 
            // ThoiGian
            // 
            this.ThoiGian.DataPropertyName = "ThoiGian";
            this.ThoiGian.HeaderText = "Thời gian thi";
            this.ThoiGian.Name = "ThoiGian";
            this.ThoiGian.ReadOnly = true;
            // 
            // SoCau
            // 
            this.SoCau.DataPropertyName = "SoCau";
            this.SoCau.HeaderText = "Số câu hỏi";
            this.SoCau.Name = "SoCau";
            this.SoCau.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "QUẢN LÝ KỲ THI - MÔN THI - ĐỀ THI";
            // 
            // Btn_ThemKyThi
            // 
            this.Btn_ThemKyThi.Location = new System.Drawing.Point(12, 505);
            this.Btn_ThemKyThi.Name = "Btn_ThemKyThi";
            this.Btn_ThemKyThi.Size = new System.Drawing.Size(75, 23);
            this.Btn_ThemKyThi.TabIndex = 3;
            this.Btn_ThemKyThi.Text = "Thêm";
            this.Btn_ThemKyThi.UseVisualStyleBackColor = true;
            this.Btn_ThemKyThi.Click += new System.EventHandler(this.Btn_ThemKyThi_Click);
            // 
            // Tb_KyThi
            // 
            this.Tb_KyThi.Location = new System.Drawing.Point(12, 58);
            this.Tb_KyThi.Name = "Tb_KyThi";
            this.Tb_KyThi.ReadOnly = true;
            this.Tb_KyThi.Size = new System.Drawing.Size(100, 23);
            this.Tb_KyThi.TabIndex = 4;
            this.Tb_KyThi.Text = "(Chưa chọn)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "KỲ THI ĐANG XỬ LÝ";
            // 
            // Tb_MonThi
            // 
            this.Tb_MonThi.Location = new System.Drawing.Point(353, 58);
            this.Tb_MonThi.Name = "Tb_MonThi";
            this.Tb_MonThi.ReadOnly = true;
            this.Tb_MonThi.Size = new System.Drawing.Size(486, 23);
            this.Tb_MonThi.TabIndex = 6;
            this.Tb_MonThi.Text = "(Chưa chọn)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(353, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "MÔN/ĐỀ THI ĐANG XỬ LÝ";
            // 
            // Btn_SuaKyThi
            // 
            this.Btn_SuaKyThi.Enabled = false;
            this.Btn_SuaKyThi.Location = new System.Drawing.Point(127, 505);
            this.Btn_SuaKyThi.Name = "Btn_SuaKyThi";
            this.Btn_SuaKyThi.Size = new System.Drawing.Size(75, 23);
            this.Btn_SuaKyThi.TabIndex = 8;
            this.Btn_SuaKyThi.Text = "Sửa";
            this.Btn_SuaKyThi.UseVisualStyleBackColor = true;
            this.Btn_SuaKyThi.Click += new System.EventHandler(this.Btn_SuaKyThi_Click);
            // 
            // Btn_XoaKyThi
            // 
            this.Btn_XoaKyThi.Enabled = false;
            this.Btn_XoaKyThi.Location = new System.Drawing.Point(241, 505);
            this.Btn_XoaKyThi.Name = "Btn_XoaKyThi";
            this.Btn_XoaKyThi.Size = new System.Drawing.Size(75, 23);
            this.Btn_XoaKyThi.TabIndex = 9;
            this.Btn_XoaKyThi.Text = "Xoá";
            this.Btn_XoaKyThi.UseVisualStyleBackColor = true;
            this.Btn_XoaKyThi.Click += new System.EventHandler(this.Btn_XoaKyThi_Click);
            // 
            // Btn_XoaDeThi
            // 
            this.Btn_XoaDeThi.Enabled = false;
            this.Btn_XoaDeThi.Location = new System.Drawing.Point(764, 505);
            this.Btn_XoaDeThi.Name = "Btn_XoaDeThi";
            this.Btn_XoaDeThi.Size = new System.Drawing.Size(75, 23);
            this.Btn_XoaDeThi.TabIndex = 12;
            this.Btn_XoaDeThi.Text = "Xoá";
            this.Btn_XoaDeThi.UseVisualStyleBackColor = true;
            this.Btn_XoaDeThi.Click += new System.EventHandler(this.Btn_XoaDeThi_Click);
            // 
            // Btn_SuaDeThi
            // 
            this.Btn_SuaDeThi.Enabled = false;
            this.Btn_SuaDeThi.Location = new System.Drawing.Point(666, 505);
            this.Btn_SuaDeThi.Name = "Btn_SuaDeThi";
            this.Btn_SuaDeThi.Size = new System.Drawing.Size(75, 23);
            this.Btn_SuaDeThi.TabIndex = 11;
            this.Btn_SuaDeThi.Text = "Sửa";
            this.Btn_SuaDeThi.UseVisualStyleBackColor = true;
            this.Btn_SuaDeThi.Click += new System.EventHandler(this.Btn_SuaDeThi_Click);
            // 
            // Btn_ThemDeThi
            // 
            this.Btn_ThemDeThi.Location = new System.Drawing.Point(568, 505);
            this.Btn_ThemDeThi.Name = "Btn_ThemDeThi";
            this.Btn_ThemDeThi.Size = new System.Drawing.Size(75, 23);
            this.Btn_ThemDeThi.TabIndex = 10;
            this.Btn_ThemDeThi.Text = "Thêm";
            this.Btn_ThemDeThi.UseVisualStyleBackColor = true;
            this.Btn_ThemDeThi.Click += new System.EventHandler(this.Btn_ThemDeThi_Click);
            // 
            // Btn_TaoDeThi
            // 
            this.Btn_TaoDeThi.Location = new System.Drawing.Point(1004, 505);
            this.Btn_TaoDeThi.Name = "Btn_TaoDeThi";
            this.Btn_TaoDeThi.Size = new System.Drawing.Size(75, 23);
            this.Btn_TaoDeThi.TabIndex = 13;
            this.Btn_TaoDeThi.Text = "Tạo/In đề";
            this.Btn_TaoDeThi.UseVisualStyleBackColor = true;
            this.Btn_TaoDeThi.Click += new System.EventHandler(this.Btn_TaoDeThi_Click);
            // 
            // Btn_Thoat
            // 
            this.Btn_Thoat.Location = new System.Drawing.Point(1004, 577);
            this.Btn_Thoat.Name = "Btn_Thoat";
            this.Btn_Thoat.Size = new System.Drawing.Size(75, 23);
            this.Btn_Thoat.TabIndex = 14;
            this.Btn_Thoat.Text = "Thoát";
            this.Btn_Thoat.UseVisualStyleBackColor = true;
            this.Btn_Thoat.Click += new System.EventHandler(this.Btn_Thoat_Click);
            // 
            // MixMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 612);
            this.Controls.Add(this.Btn_Thoat);
            this.Controls.Add(this.Btn_TaoDeThi);
            this.Controls.Add(this.Btn_XoaDeThi);
            this.Controls.Add(this.Btn_SuaDeThi);
            this.Controls.Add(this.Btn_ThemDeThi);
            this.Controls.Add(this.Btn_XoaKyThi);
            this.Controls.Add(this.Btn_SuaKyThi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Tb_MonThi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Tb_KyThi);
            this.Controls.Add(this.Btn_ThemKyThi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView_DeThi);
            this.Controls.Add(this.dataGridView_Kythi);
            this.MinimizeBox = false;
            this.Name = "MixMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MixApp";
            this.Load += new System.EventHandler(this.MixMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Kythi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_DeThi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_Kythi;
        private System.Windows.Forms.DataGridView dataGridView_DeThi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_ThemKyThi;
        private System.Windows.Forms.TextBox Tb_KyThi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Tb_MonThi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Btn_SuaKyThi;
        private System.Windows.Forms.Button Btn_XoaKyThi;
        private System.Windows.Forms.Button Btn_XoaDeThi;
        private System.Windows.Forms.Button Btn_SuaDeThi;
        private System.Windows.Forms.Button Btn_ThemDeThi;
        private System.Windows.Forms.Button Btn_TaoDeThi;
        private System.Windows.Forms.Button Btn_Thoat;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDeThi;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThoiGian;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoCau;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKyThi;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKyThi;
        private System.Windows.Forms.DataGridViewTextBoxColumn GhiChu;
    }
}

