namespace QL_GV_HS_THPT.View
{
    partial class frmDSChuNhiem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDSChuNhiem));
            this.lbDSCN = new System.Windows.Forms.Label();
            this.grbThaoTac = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.n = new System.Windows.Forms.Label();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.txtNamHoc = new System.Windows.Forms.TextBox();
            this.cbMaLop = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDatChuNhiem = new System.Windows.Forms.Button();
            this.dgvCN = new System.Windows.Forms.DataGridView();
            this.txtMaGV = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grbThaoTac.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCN)).BeginInit();
            this.SuspendLayout();
            // 
            // lbDSCN
            // 
            this.lbDSCN.AutoSize = true;
            this.lbDSCN.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDSCN.Location = new System.Drawing.Point(275, 24);
            this.lbDSCN.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbDSCN.Name = "lbDSCN";
            this.lbDSCN.Size = new System.Drawing.Size(193, 22);
            this.lbDSCN.TabIndex = 0;
            this.lbDSCN.Text = "Thông Tin Chủ Nhiệm";
            // 
            // grbThaoTac
            // 
            this.grbThaoTac.Controls.Add(this.label8);
            this.grbThaoTac.Controls.Add(this.n);
            this.grbThaoTac.Controls.Add(this.btnXacNhan);
            this.grbThaoTac.Controls.Add(this.txtNamHoc);
            this.grbThaoTac.Controls.Add(this.cbMaLop);
            this.grbThaoTac.Location = new System.Drawing.Point(470, 19);
            this.grbThaoTac.Name = "grbThaoTac";
            this.grbThaoTac.Size = new System.Drawing.Size(214, 143);
            this.grbThaoTac.TabIndex = 36;
            this.grbThaoTac.TabStop = false;
            this.grbThaoTac.Text = "Chọn Chủ Nhiệm";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 72);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 35;
            this.label8.Text = "Năm Học";
            // 
            // n
            // 
            this.n.AutoSize = true;
            this.n.Location = new System.Drawing.Point(6, 30);
            this.n.Name = "n";
            this.n.Size = new System.Drawing.Size(25, 13);
            this.n.TabIndex = 34;
            this.n.Text = "Lớp";
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.Location = new System.Drawing.Point(78, 102);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(121, 23);
            this.btnXacNhan.TabIndex = 2;
            this.btnXacNhan.Text = "Xác Nhận";
            this.btnXacNhan.UseVisualStyleBackColor = true;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // txtNamHoc
            // 
            this.txtNamHoc.Location = new System.Drawing.Point(78, 65);
            this.txtNamHoc.Name = "txtNamHoc";
            this.txtNamHoc.Size = new System.Drawing.Size(121, 20);
            this.txtNamHoc.TabIndex = 1;
            // 
            // cbMaLop
            // 
            this.cbMaLop.FormattingEnabled = true;
            this.cbMaLop.Location = new System.Drawing.Point(78, 22);
            this.cbMaLop.Name = "cbMaLop";
            this.cbMaLop.Size = new System.Drawing.Size(121, 21);
            this.cbMaLop.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDatChuNhiem);
            this.groupBox2.Controls.Add(this.dgvCN);
            this.groupBox2.Controls.Add(this.grbThaoTac);
            this.groupBox2.Location = new System.Drawing.Point(24, 68);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(712, 208);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông Tin Giáo Viên Chủ Nhiệm";
            // 
            // btnDatChuNhiem
            // 
            this.btnDatChuNhiem.Location = new System.Drawing.Point(104, 168);
            this.btnDatChuNhiem.Name = "btnDatChuNhiem";
            this.btnDatChuNhiem.Size = new System.Drawing.Size(180, 23);
            this.btnDatChuNhiem.TabIndex = 38;
            this.btnDatChuNhiem.Text = "Đặt làm Chủ Nhiệm";
            this.btnDatChuNhiem.UseVisualStyleBackColor = true;
            this.btnDatChuNhiem.Click += new System.EventHandler(this.btnDatChuNhiem_Click_1);
            // 
            // dgvCN
            // 
            this.dgvCN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCN.Location = new System.Drawing.Point(15, 31);
            this.dgvCN.Name = "dgvCN";
            this.dgvCN.Size = new System.Drawing.Size(429, 131);
            this.dgvCN.TabIndex = 37;
            // 
            // txtMaGV
            // 
            this.txtMaGV.Location = new System.Drawing.Point(101, 29);
            this.txtMaGV.Name = "txtMaGV";
            this.txtMaGV.Size = new System.Drawing.Size(96, 20);
            this.txtMaGV.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 40;
            this.label1.Text = "Mã GV";
            // 
            // frmDSChuNhiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(760, 293);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMaGV);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lbDSCN);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmDSChuNhiem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin chủ nhiệm";
            this.Load += new System.EventHandler(this.frmDSChuNhiem_Load);
            this.grbThaoTac.ResumeLayout(false);
            this.grbThaoTac.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbDSCN;
        private System.Windows.Forms.GroupBox grbThaoTac;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label n;
        private System.Windows.Forms.Button btnXacNhan;
        private System.Windows.Forms.TextBox txtNamHoc;
        private System.Windows.Forms.ComboBox cbMaLop;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvCN;
        private System.Windows.Forms.TextBox txtMaGV;
        private System.Windows.Forms.Button btnDatChuNhiem;
        private System.Windows.Forms.Label label1;
    }
}