
namespace MixApp.form
{
    partial class ThemKyThi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThemKyThi));
            this.label1 = new System.Windows.Forms.Label();
            this.Tb_MaKyThi = new System.Windows.Forms.TextBox();
            this.Btn_Luu = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Tb_TenKyThi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Rtb_GhiChu = new System.Windows.Forms.RichTextBox();
            this.Btn_TroVe = new System.Windows.Forms.Button();
            this.Dgv_KyThi = new System.Windows.Forms.DataGridView();
            this.MaKyThi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKyThi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Btn_Them = new System.Windows.Forms.Button();
            this.Btn_CapNhat = new System.Windows.Forms.Button();
            this.Btn_Xoa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_KyThi)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "THÊM/SỬA KỲ THI";
            // 
            // Tb_MaKyThi
            // 
            this.Tb_MaKyThi.Location = new System.Drawing.Point(106, 53);
            this.Tb_MaKyThi.Name = "Tb_MaKyThi";
            this.Tb_MaKyThi.Size = new System.Drawing.Size(183, 23);
            this.Tb_MaKyThi.TabIndex = 1;
            // 
            // Btn_Luu
            // 
            this.Btn_Luu.Location = new System.Drawing.Point(339, 524);
            this.Btn_Luu.Name = "Btn_Luu";
            this.Btn_Luu.Size = new System.Drawing.Size(75, 23);
            this.Btn_Luu.TabIndex = 4;
            this.Btn_Luu.Text = "Lưu";
            this.Btn_Luu.UseVisualStyleBackColor = true;
            this.Btn_Luu.Click += new System.EventHandler(this.Btn_Luu_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mã kỳ thi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tên kỳ thi";
            // 
            // Tb_TenKyThi
            // 
            this.Tb_TenKyThi.Location = new System.Drawing.Point(107, 82);
            this.Tb_TenKyThi.Name = "Tb_TenKyThi";
            this.Tb_TenKyThi.Size = new System.Drawing.Size(388, 23);
            this.Tb_TenKyThi.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ghi chú";
            // 
            // Rtb_GhiChu
            // 
            this.Rtb_GhiChu.Location = new System.Drawing.Point(107, 125);
            this.Rtb_GhiChu.Name = "Rtb_GhiChu";
            this.Rtb_GhiChu.Size = new System.Drawing.Size(388, 61);
            this.Rtb_GhiChu.TabIndex = 3;
            this.Rtb_GhiChu.Text = "";
            // 
            // Btn_TroVe
            // 
            this.Btn_TroVe.Location = new System.Drawing.Point(420, 524);
            this.Btn_TroVe.Name = "Btn_TroVe";
            this.Btn_TroVe.Size = new System.Drawing.Size(75, 23);
            this.Btn_TroVe.TabIndex = 5;
            this.Btn_TroVe.Text = "Trở về";
            this.Btn_TroVe.UseVisualStyleBackColor = true;
            this.Btn_TroVe.Click += new System.EventHandler(this.Btn_TroVe_Click);
            // 
            // Dgv_KyThi
            // 
            this.Dgv_KyThi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_KyThi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaKyThi,
            this.TenKyThi,
            this.GhiChu});
            this.Dgv_KyThi.Location = new System.Drawing.Point(107, 211);
            this.Dgv_KyThi.Name = "Dgv_KyThi";
            this.Dgv_KyThi.RowTemplate.Height = 25;
            this.Dgv_KyThi.Size = new System.Drawing.Size(388, 255);
            this.Dgv_KyThi.TabIndex = 8;
            this.Dgv_KyThi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_KyThi_CellClick);
            // 
            // MaKyThi
            // 
            this.MaKyThi.DataPropertyName = "MaKyThi";
            this.MaKyThi.HeaderText = "Mã kỳ thi";
            this.MaKyThi.Name = "MaKyThi";
            // 
            // TenKyThi
            // 
            this.TenKyThi.DataPropertyName = "TenKyThi";
            this.TenKyThi.HeaderText = "Tên kỳ thi";
            this.TenKyThi.Name = "TenKyThi";
            // 
            // GhiChu
            // 
            this.GhiChu.DataPropertyName = "GhiChu";
            this.GhiChu.HeaderText = "Ghi chú";
            this.GhiChu.Name = "GhiChu";
            // 
            // Btn_Them
            // 
            this.Btn_Them.Location = new System.Drawing.Point(96, 524);
            this.Btn_Them.Name = "Btn_Them";
            this.Btn_Them.Size = new System.Drawing.Size(75, 23);
            this.Btn_Them.TabIndex = 9;
            this.Btn_Them.Text = "Thêm mới";
            this.Btn_Them.UseVisualStyleBackColor = true;
            this.Btn_Them.Click += new System.EventHandler(this.Btn_Them_Click);
            // 
            // Btn_CapNhat
            // 
            this.Btn_CapNhat.Location = new System.Drawing.Point(177, 524);
            this.Btn_CapNhat.Name = "Btn_CapNhat";
            this.Btn_CapNhat.Size = new System.Drawing.Size(75, 23);
            this.Btn_CapNhat.TabIndex = 10;
            this.Btn_CapNhat.Text = "Cập nhật";
            this.Btn_CapNhat.UseVisualStyleBackColor = true;
            this.Btn_CapNhat.Click += new System.EventHandler(this.Btn_CapNhat_Click);
            // 
            // Btn_Xoa
            // 
            this.Btn_Xoa.Location = new System.Drawing.Point(258, 524);
            this.Btn_Xoa.Name = "Btn_Xoa";
            this.Btn_Xoa.Size = new System.Drawing.Size(75, 23);
            this.Btn_Xoa.TabIndex = 11;
            this.Btn_Xoa.Text = "Xoá";
            this.Btn_Xoa.UseVisualStyleBackColor = true;
            this.Btn_Xoa.Click += new System.EventHandler(this.Btn_Xoa_Click);
            // 
            // ThemKyThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 559);
            this.Controls.Add(this.Btn_Xoa);
            this.Controls.Add(this.Btn_CapNhat);
            this.Controls.Add(this.Btn_Them);
            this.Controls.Add(this.Dgv_KyThi);
            this.Controls.Add(this.Btn_TroVe);
            this.Controls.Add(this.Rtb_GhiChu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Tb_TenKyThi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Btn_Luu);
            this.Controls.Add(this.Tb_MaKyThi);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ThemKyThi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "THÊM KỲ THI";
            this.Load += new System.EventHandler(this.ThemKyThi_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ThemKyThi_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_KyThi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Tb_MaKyThi;
        private System.Windows.Forms.Button Btn_Luu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Tb_TenKyThi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox Rtb_GhiChu;
        private System.Windows.Forms.Button Btn_TroVe;
        private System.Windows.Forms.DataGridView Dgv_KyThi;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKyThi;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKyThi;
        private System.Windows.Forms.DataGridViewTextBoxColumn GhiChu;
        private System.Windows.Forms.Button Btn_Them;
        private System.Windows.Forms.Button Btn_CapNhat;
        private System.Windows.Forms.Button Btn_Xoa;
    }
}