namespace QL_GV_HS_THPT.View
{
    partial class frmChuNhiem
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvCN = new System.Windows.Forms.DataGridView();
            this.MaGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Malop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NamHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbGVCN = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCN)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvCN);
            this.groupBox1.Location = new System.Drawing.Point(0, 89);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(608, 173);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chủ nhiệm";
            // 
            // dgvCN
            // 
            this.dgvCN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCN.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaGV,
            this.Malop,
            this.NamHoc});
            this.dgvCN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCN.Location = new System.Drawing.Point(3, 16);
            this.dgvCN.Name = "dgvCN";
            this.dgvCN.Size = new System.Drawing.Size(602, 154);
            this.dgvCN.TabIndex = 0;
            // 
            // MaGV
            // 
            this.MaGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaGV.DataPropertyName = "MaGV";
            this.MaGV.HeaderText = "Mã GV";
            this.MaGV.Name = "MaGV";
            // 
            // Malop
            // 
            this.Malop.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Malop.DataPropertyName = "MaLop";
            this.Malop.HeaderText = "Mã Lớp";
            this.Malop.Name = "Malop";
            // 
            // NamHoc
            // 
            this.NamHoc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NamHoc.DataPropertyName = "NamHoc";
            this.NamHoc.HeaderText = "Năm Học";
            this.NamHoc.Name = "NamHoc";
            // 
            // lbGVCN
            // 
            this.lbGVCN.AutoSize = true;
            this.lbGVCN.Location = new System.Drawing.Point(256, 27);
            this.lbGVCN.Name = "lbGVCN";
            this.lbGVCN.Size = new System.Drawing.Size(108, 13);
            this.lbGVCN.TabIndex = 1;
            this.lbGVCN.Text = "Giáo Viên Chủ Nhiệm";
            // 
            // frmChuNhiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 262);
            this.Controls.Add(this.lbGVCN);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmChuNhiem";
            this.Text = "frmChuNhiem";
            this.Load += new System.EventHandler(this.frmChuNhiem_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvCN;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Malop;
        private System.Windows.Forms.DataGridViewTextBoxColumn NamHoc;
        private System.Windows.Forms.Label lbGVCN;
    }
}