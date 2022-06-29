
namespace MixApp.form
{
    partial class DeThi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeThi));
            this.Btn_TimDe = new System.Windows.Forms.Button();
            this.Btn_Thoat = new System.Windows.Forms.Button();
            this.Btn_LamMoi = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Cbb_KyThi = new System.Windows.Forms.ComboBox();
            this.Cbb_MonThi = new System.Windows.Forms.ComboBox();
            this.Dgv_DeThi = new System.Windows.Forms.DataGridView();
            this.Btn_ThemKyThi = new System.Windows.Forms.Button();
            this.Btn_ThemMon = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_DeThi)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_TimDe
            // 
            this.Btn_TimDe.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Btn_TimDe.Location = new System.Drawing.Point(685, 55);
            this.Btn_TimDe.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_TimDe.Name = "Btn_TimDe";
            this.Btn_TimDe.Size = new System.Drawing.Size(97, 32);
            this.Btn_TimDe.TabIndex = 7;
            this.Btn_TimDe.Text = "Tìm đề";
            this.Btn_TimDe.UseVisualStyleBackColor = true;
            this.Btn_TimDe.Click += new System.EventHandler(this.Btn_TimDe_Click);
            // 
            // Btn_Thoat
            // 
            this.Btn_Thoat.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Btn_Thoat.Location = new System.Drawing.Point(707, 599);
            this.Btn_Thoat.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Thoat.Name = "Btn_Thoat";
            this.Btn_Thoat.Size = new System.Drawing.Size(97, 32);
            this.Btn_Thoat.TabIndex = 6;
            this.Btn_Thoat.Text = "Thoát";
            this.Btn_Thoat.UseVisualStyleBackColor = true;
            this.Btn_Thoat.Click += new System.EventHandler(this.Btn_Thoat_Click);
            // 
            // Btn_LamMoi
            // 
            this.Btn_LamMoi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Btn_LamMoi.Location = new System.Drawing.Point(685, 109);
            this.Btn_LamMoi.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_LamMoi.Name = "Btn_LamMoi";
            this.Btn_LamMoi.Size = new System.Drawing.Size(97, 32);
            this.Btn_LamMoi.TabIndex = 3;
            this.Btn_LamMoi.Text = "Làm mới";
            this.Btn_LamMoi.UseVisualStyleBackColor = true;
            this.Btn_LamMoi.Click += new System.EventHandler(this.Btn_LamMoi_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(13, 9);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 21);
            this.label7.TabIndex = 35;
            this.label7.Text = "Đề thi";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(33, 39);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 21);
            this.label8.TabIndex = 36;
            this.label8.Text = "Chọn kỳ thi";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(450, 39);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(114, 21);
            this.label9.TabIndex = 37;
            this.label9.Text = "Chọn môn thi";
            // 
            // Cbb_KyThi
            // 
            this.Cbb_KyThi.FormattingEnabled = true;
            this.Cbb_KyThi.Location = new System.Drawing.Point(33, 63);
            this.Cbb_KyThi.Name = "Cbb_KyThi";
            this.Cbb_KyThi.Size = new System.Drawing.Size(377, 23);
            this.Cbb_KyThi.TabIndex = 38;
            // 
            // Cbb_MonThi
            // 
            this.Cbb_MonThi.FormattingEnabled = true;
            this.Cbb_MonThi.Location = new System.Drawing.Point(450, 63);
            this.Cbb_MonThi.Name = "Cbb_MonThi";
            this.Cbb_MonThi.Size = new System.Drawing.Size(185, 23);
            this.Cbb_MonThi.TabIndex = 39;
            // 
            // Dgv_DeThi
            // 
            this.Dgv_DeThi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_DeThi.Location = new System.Drawing.Point(33, 148);
            this.Dgv_DeThi.Name = "Dgv_DeThi";
            this.Dgv_DeThi.ReadOnly = true;
            this.Dgv_DeThi.RowTemplate.Height = 25;
            this.Dgv_DeThi.Size = new System.Drawing.Size(771, 375);
            this.Dgv_DeThi.TabIndex = 40;
            this.Dgv_DeThi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_DeThi_CellContentClick);
            this.Dgv_DeThi.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_DeThi_CellDoubleClick);
            // 
            // Btn_ThemKyThi
            // 
            this.Btn_ThemKyThi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Btn_ThemKyThi.Location = new System.Drawing.Point(313, 93);
            this.Btn_ThemKyThi.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_ThemKyThi.Name = "Btn_ThemKyThi";
            this.Btn_ThemKyThi.Size = new System.Drawing.Size(97, 32);
            this.Btn_ThemKyThi.TabIndex = 41;
            this.Btn_ThemKyThi.Text = "Thêm/Sửa";
            this.Btn_ThemKyThi.UseVisualStyleBackColor = true;
            this.Btn_ThemKyThi.Click += new System.EventHandler(this.Btn_ThemKyThi_Click);
            // 
            // Btn_ThemMon
            // 
            this.Btn_ThemMon.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Btn_ThemMon.Location = new System.Drawing.Point(538, 93);
            this.Btn_ThemMon.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_ThemMon.Name = "Btn_ThemMon";
            this.Btn_ThemMon.Size = new System.Drawing.Size(97, 32);
            this.Btn_ThemMon.TabIndex = 42;
            this.Btn_ThemMon.Text = "Thêm/Sửa";
            this.Btn_ThemMon.UseVisualStyleBackColor = true;
            this.Btn_ThemMon.Click += new System.EventHandler(this.Btn_ThemMon_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(707, 549);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 32);
            this.button1.TabIndex = 44;
            this.button1.Text = "Tạo đề";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DeThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 644);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Btn_ThemMon);
            this.Controls.Add(this.Btn_ThemKyThi);
            this.Controls.Add(this.Dgv_DeThi);
            this.Controls.Add(this.Cbb_MonThi);
            this.Controls.Add(this.Cbb_KyThi);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Btn_TimDe);
            this.Controls.Add(this.Btn_Thoat);
            this.Controls.Add(this.Btn_LamMoi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DeThi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đề thi";
            this.Load += new System.EventHandler(this.DeThi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_DeThi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Btn_TimDe;
        private System.Windows.Forms.Button Btn_Thoat;
        private System.Windows.Forms.Button Btn_LamMoi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox Cbb_KyThi;
        private System.Windows.Forms.ComboBox Cbb_MonThi;
        private System.Windows.Forms.DataGridView Dgv_DeThi;
        private System.Windows.Forms.Button Btn_ThemKyThi;
        private System.Windows.Forms.Button Btn_ThemMon;
        private System.Windows.Forms.Button button1;
    }
}