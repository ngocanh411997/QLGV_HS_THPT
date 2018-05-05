namespace QL_GV_HS_THPT.View
{
    partial class frmXemDiem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmXemDiem));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvXemDiem = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaHS = new System.Windows.Forms.TextBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.TenHS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiemMieng = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Diem15ph = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Diem1Tiet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiemHocKy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrungBinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvXemDiem)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvXemDiem);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(755, 237);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Điểm học sinh";
            // 
            // dgvXemDiem
            // 
            this.dgvXemDiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvXemDiem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenHS,
            this.TenLop,
            this.TenMon,
            this.DiemMieng,
            this.Diem15ph,
            this.Diem1Tiet,
            this.DiemHocKy,
            this.TrungBinh});
            this.dgvXemDiem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvXemDiem.Location = new System.Drawing.Point(3, 18);
            this.dgvXemDiem.Name = "dgvXemDiem";
            this.dgvXemDiem.Size = new System.Drawing.Size(749, 216);
            this.dgvXemDiem.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 314);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã Học Sinh";
            // 
            // txtMaHS
            // 
            this.txtMaHS.Location = new System.Drawing.Point(148, 311);
            this.txtMaHS.Name = "txtMaHS";
            this.txtMaHS.Size = new System.Drawing.Size(159, 24);
            this.txtMaHS.TabIndex = 2;
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnThoat.Location = new System.Drawing.Point(694, 281);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(70, 75);
            this.btnThoat.TabIndex = 7;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // TenHS
            // 
            this.TenHS.DataPropertyName = "TenHS";
            this.TenHS.HeaderText = "Tên HS";
            this.TenHS.Name = "TenHS";
            // 
            // TenLop
            // 
            this.TenLop.DataPropertyName = "TenLop";
            this.TenLop.HeaderText = "Tên lớp";
            this.TenLop.Name = "TenLop";
            // 
            // TenMon
            // 
            this.TenMon.DataPropertyName = "TenMon";
            this.TenMon.HeaderText = "Môn học";
            this.TenMon.Name = "TenMon";
            // 
            // DiemMieng
            // 
            this.DiemMieng.DataPropertyName = "DiemMieng";
            this.DiemMieng.HeaderText = "Điểm miệng";
            this.DiemMieng.Name = "DiemMieng";
            // 
            // Diem15ph
            // 
            this.Diem15ph.DataPropertyName = "Diem15ph";
            this.Diem15ph.HeaderText = "Điểm 15ph";
            this.Diem15ph.Name = "Diem15ph";
            // 
            // Diem1Tiet
            // 
            this.Diem1Tiet.DataPropertyName = "Diem1Tiet";
            this.Diem1Tiet.HeaderText = "Điểm 1 tiết";
            this.Diem1Tiet.Name = "Diem1Tiet";
            // 
            // DiemHocKy
            // 
            this.DiemHocKy.DataPropertyName = "DiemHocKy";
            this.DiemHocKy.HeaderText = "Điểm học kỳ";
            this.DiemHocKy.Name = "DiemHocKy";
            // 
            // TrungBinh
            // 
            this.TrungBinh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TrungBinh.DataPropertyName = "TrungBinh";
            dataGridViewCellStyle1.Format = "0.00";
            this.TrungBinh.DefaultCellStyle = dataGridViewCellStyle1;
            this.TrungBinh.HeaderText = "TB";
            this.TrungBinh.Name = "TrungBinh";
            // 
            // frmXemDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(779, 396);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.txtMaHS);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmXemDiem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmXemDiem";
            this.Load += new System.EventHandler(this.frmXemDiem_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvXemDiem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvXemDiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaHS;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenHS;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiemMieng;
        private System.Windows.Forms.DataGridViewTextBoxColumn Diem15ph;
        private System.Windows.Forms.DataGridViewTextBoxColumn Diem1Tiet;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiemHocKy;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrungBinh;
    }
}