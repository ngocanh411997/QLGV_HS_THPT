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
            this.txtMaGV = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.dgvDSChuNhiem = new System.Windows.Forms.DataGridView();
            this.TenGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NamHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSChuNhiem)).BeginInit();
            this.SuspendLayout();
            // 
            // lbDSCN
            // 
            this.lbDSCN.AutoSize = true;
            this.lbDSCN.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDSCN.Location = new System.Drawing.Point(116, 20);
            this.lbDSCN.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbDSCN.Name = "lbDSCN";
            this.lbDSCN.Size = new System.Drawing.Size(193, 22);
            this.lbDSCN.TabIndex = 0;
            this.lbDSCN.Text = "Thông Tin Chủ Nhiệm";
            // 
            // txtMaGV
            // 
            this.txtMaGV.Location = new System.Drawing.Point(120, 244);
            this.txtMaGV.Name = "txtMaGV";
            this.txtMaGV.Size = new System.Drawing.Size(100, 20);
            this.txtMaGV.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 247);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mã Giáo Viên";
            // 
            // btnThoat
            // 
            this.btnThoat.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnThoat.Location = new System.Drawing.Point(317, 215);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(69, 49);
            this.btnThoat.TabIndex = 8;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // dgvDSChuNhiem
            // 
            this.dgvDSChuNhiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSChuNhiem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenGV,
            this.TenLop,
            this.NamHoc});
            this.dgvDSChuNhiem.Location = new System.Drawing.Point(36, 56);
            this.dgvDSChuNhiem.Name = "dgvDSChuNhiem";
            this.dgvDSChuNhiem.Size = new System.Drawing.Size(350, 124);
            this.dgvDSChuNhiem.TabIndex = 9;
            // 
            // TenGV
            // 
            this.TenGV.DataPropertyName = "TenGV";
            this.TenGV.HeaderText = "Giáo Viên";
            this.TenGV.Name = "TenGV";
            // 
            // TenLop
            // 
            this.TenLop.DataPropertyName = "TenLop";
            this.TenLop.HeaderText = "Lớp";
            this.TenLop.Name = "TenLop";
            // 
            // NamHoc
            // 
            this.NamHoc.DataPropertyName = "NamHoc";
            this.NamHoc.HeaderText = "Năm Học";
            this.NamHoc.Name = "NamHoc";
            // 
            // frmDSChuNhiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(421, 301);
            this.Controls.Add(this.dgvDSChuNhiem);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMaGV);
            this.Controls.Add(this.lbDSCN);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmDSChuNhiem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh Sách Chủ Nhiệm";
            this.Load += new System.EventHandler(this.frmDSChuNhiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSChuNhiem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbDSCN;
        private System.Windows.Forms.TextBox txtMaGV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.DataGridView dgvDSChuNhiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn NamHoc;
    }
}