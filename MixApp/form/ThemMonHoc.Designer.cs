
namespace MixApp.form
{
    partial class ThemMonHoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThemMonHoc));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Tb_MaMonHoc = new System.Windows.Forms.TextBox();
            this.Btn_Luu = new System.Windows.Forms.Button();
            this.Btn_TroVe = new System.Windows.Forms.Button();
            this.Tb_TenMonHoc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Btn_CapNhat = new System.Windows.Forms.Button();
            this.Btn_Them = new System.Windows.Forms.Button();
            this.Dgv_MonHoc = new System.Windows.Forms.DataGridView();
            this.MaMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Btn_Xoa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_MonHoc)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thêm/Sửa môn học";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã môn học";
            // 
            // Tb_MaMonHoc
            // 
            this.Tb_MaMonHoc.Location = new System.Drawing.Point(94, 69);
            this.Tb_MaMonHoc.Name = "Tb_MaMonHoc";
            this.Tb_MaMonHoc.Size = new System.Drawing.Size(237, 23);
            this.Tb_MaMonHoc.TabIndex = 2;
            // 
            // Btn_Luu
            // 
            this.Btn_Luu.Location = new System.Drawing.Point(372, 264);
            this.Btn_Luu.Name = "Btn_Luu";
            this.Btn_Luu.Size = new System.Drawing.Size(75, 23);
            this.Btn_Luu.TabIndex = 3;
            this.Btn_Luu.Text = "Lưu";
            this.Btn_Luu.UseVisualStyleBackColor = true;
            this.Btn_Luu.Click += new System.EventHandler(this.Btn_Luu_Click);
            // 
            // Btn_TroVe
            // 
            this.Btn_TroVe.Location = new System.Drawing.Point(372, 487);
            this.Btn_TroVe.Name = "Btn_TroVe";
            this.Btn_TroVe.Size = new System.Drawing.Size(75, 23);
            this.Btn_TroVe.TabIndex = 4;
            this.Btn_TroVe.Text = "Trở về";
            this.Btn_TroVe.UseVisualStyleBackColor = true;
            this.Btn_TroVe.Click += new System.EventHandler(this.Btn_TroVe_Click);
            // 
            // Tb_TenMonHoc
            // 
            this.Tb_TenMonHoc.Location = new System.Drawing.Point(95, 98);
            this.Tb_TenMonHoc.Name = "Tb_TenMonHoc";
            this.Tb_TenMonHoc.Size = new System.Drawing.Size(237, 23);
            this.Tb_TenMonHoc.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tên môn học";
            // 
            // Btn_CapNhat
            // 
            this.Btn_CapNhat.Location = new System.Drawing.Point(372, 192);
            this.Btn_CapNhat.Name = "Btn_CapNhat";
            this.Btn_CapNhat.Size = new System.Drawing.Size(75, 23);
            this.Btn_CapNhat.TabIndex = 12;
            this.Btn_CapNhat.Text = "Cập nhật";
            this.Btn_CapNhat.UseVisualStyleBackColor = true;
            this.Btn_CapNhat.Click += new System.EventHandler(this.Btn_CapNhat_Click);
            // 
            // Btn_Them
            // 
            this.Btn_Them.Location = new System.Drawing.Point(372, 133);
            this.Btn_Them.Name = "Btn_Them";
            this.Btn_Them.Size = new System.Drawing.Size(75, 23);
            this.Btn_Them.TabIndex = 11;
            this.Btn_Them.Text = "Thêm mới";
            this.Btn_Them.UseVisualStyleBackColor = true;
            this.Btn_Them.Click += new System.EventHandler(this.Btn_Them_Click);
            // 
            // Dgv_MonHoc
            // 
            this.Dgv_MonHoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_MonHoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaMon,
            this.TenMon});
            this.Dgv_MonHoc.Location = new System.Drawing.Point(13, 133);
            this.Dgv_MonHoc.Name = "Dgv_MonHoc";
            this.Dgv_MonHoc.ReadOnly = true;
            this.Dgv_MonHoc.RowTemplate.Height = 25;
            this.Dgv_MonHoc.Size = new System.Drawing.Size(319, 377);
            this.Dgv_MonHoc.TabIndex = 13;
            this.Dgv_MonHoc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_MonHoc_CellClick);
            // 
            // MaMon
            // 
            this.MaMon.DataPropertyName = "MaMon";
            this.MaMon.HeaderText = "Mã môn học";
            this.MaMon.Name = "MaMon";
            this.MaMon.ReadOnly = true;
            // 
            // TenMon
            // 
            this.TenMon.DataPropertyName = "TenMon";
            this.TenMon.HeaderText = "Tên môn học";
            this.TenMon.Name = "TenMon";
            this.TenMon.ReadOnly = true;
            // 
            // Btn_Xoa
            // 
            this.Btn_Xoa.Location = new System.Drawing.Point(372, 322);
            this.Btn_Xoa.Name = "Btn_Xoa";
            this.Btn_Xoa.Size = new System.Drawing.Size(75, 23);
            this.Btn_Xoa.TabIndex = 14;
            this.Btn_Xoa.Text = "Xoá";
            this.Btn_Xoa.UseVisualStyleBackColor = true;
            this.Btn_Xoa.Click += new System.EventHandler(this.Btn_Xoa_Click);
            // 
            // ThemMonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 522);
            this.Controls.Add(this.Btn_Xoa);
            this.Controls.Add(this.Dgv_MonHoc);
            this.Controls.Add(this.Btn_CapNhat);
            this.Controls.Add(this.Btn_Them);
            this.Controls.Add(this.Tb_TenMonHoc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Btn_TroVe);
            this.Controls.Add(this.Btn_Luu);
            this.Controls.Add(this.Tb_MaMonHoc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ThemMonHoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm/Sửa môn học";
            this.Load += new System.EventHandler(this.ThemMonHoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_MonHoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Tb_MaMonHoc;
        private System.Windows.Forms.Button Btn_Luu;
        private System.Windows.Forms.Button Btn_TroVe;
        private System.Windows.Forms.TextBox Tb_TenMonHoc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Btn_CapNhat;
        private System.Windows.Forms.Button Btn_Them;
        private System.Windows.Forms.DataGridView Dgv_MonHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenMon;
        private System.Windows.Forms.Button Btn_Xoa;
    }
}