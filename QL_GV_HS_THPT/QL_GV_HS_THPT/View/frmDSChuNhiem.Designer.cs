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
            this.lbDSCN = new System.Windows.Forms.Label();
            this.dgvDSCN = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NamHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSCN)).BeginInit();
            this.SuspendLayout();
            // 
            // lbDSCN
            // 
            this.lbDSCN.AutoSize = true;
            this.lbDSCN.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDSCN.Location = new System.Drawing.Point(202, 20);
            this.lbDSCN.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbDSCN.Name = "lbDSCN";
            this.lbDSCN.Size = new System.Drawing.Size(196, 22);
            this.lbDSCN.TabIndex = 0;
            this.lbDSCN.Text = "Danh Sách Chủ Nhiệm";
            // 
            // dgvDSCN
            // 
            this.dgvDSCN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSCN.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.MaGV,
            this.MaLop,
            this.NamHoc});
            this.dgvDSCN.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvDSCN.Location = new System.Drawing.Point(0, 63);
            this.dgvDSCN.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvDSCN.Name = "dgvDSCN";
            this.dgvDSCN.RowTemplate.Height = 24;
            this.dgvDSCN.Size = new System.Drawing.Size(554, 163);
            this.dgvDSCN.TabIndex = 1;
            // 
            // STT
            // 
            this.STT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            // 
            // MaGV
            // 
            this.MaGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaGV.DataPropertyName = "MaGV";
            this.MaGV.HeaderText = "Mã giáo viên";
            this.MaGV.Name = "MaGV";
            // 
            // MaLop
            // 
            this.MaLop.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaLop.DataPropertyName = "MaLop";
            this.MaLop.HeaderText = "Mã lớp";
            this.MaLop.Name = "MaLop";
            // 
            // NamHoc
            // 
            this.NamHoc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NamHoc.DataPropertyName = "NamHoc";
            this.NamHoc.HeaderText = "Năm học";
            this.NamHoc.Name = "NamHoc";
            // 
            // frmDSChuNhiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 226);
            this.Controls.Add(this.dgvDSCN);
            this.Controls.Add(this.lbDSCN);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmDSChuNhiem";
            this.Text = "Danh Sách Chủ Nhiệm";
            this.Load += new System.EventHandler(this.frmDSChuNhiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSCN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbDSCN;
        private System.Windows.Forms.DataGridView dgvDSCN;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn NamHoc;
    }
}