namespace Form1
{
    partial class FormQLMonAn
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormQLMonAn));
            this.txt_maMon = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_tenMon = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_donGia = new System.Windows.Forms.TextBox();
            this.button_back = new System.Windows.Forms.Button();
            this.button_OK = new System.Windows.Forms.Button();
            this.button_Update = new System.Windows.Forms.Button();
            this.button_Xoa = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_thoiGian = new System.Windows.Forms.TextBox();
            this.label_date = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dgvFood = new System.Windows.Forms.DataGridView();
            this.MaMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThoiGian = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_reset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFood)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_maMon
            // 
            this.txt_maMon.Location = new System.Drawing.Point(405, 39);
            this.txt_maMon.Name = "txt_maMon";
            this.txt_maMon.Size = new System.Drawing.Size(224, 27);
            this.txt_maMon.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(321, 84);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 27);
            this.label10.TabIndex = 22;
            this.label10.Text = "Tên món";
            // 
            // txt_tenMon
            // 
            this.txt_tenMon.Location = new System.Drawing.Point(405, 81);
            this.txt_tenMon.Name = "txt_tenMon";
            this.txt_tenMon.Size = new System.Drawing.Size(224, 27);
            this.txt_tenMon.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(321, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "Mã món";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(321, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 27);
            this.label2.TabIndex = 25;
            this.label2.Text = "Đơn giá";
            // 
            // txt_donGia
            // 
            this.txt_donGia.Location = new System.Drawing.Point(405, 123);
            this.txt_donGia.Name = "txt_donGia";
            this.txt_donGia.Size = new System.Drawing.Size(224, 27);
            this.txt_donGia.TabIndex = 24;
            // 
            // button_back
            // 
            this.button_back.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_back.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_back.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_back.Image = ((System.Drawing.Image)(resources.GetObject("button_back.Image")));
            this.button_back.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_back.Location = new System.Drawing.Point(64, 619);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(105, 40);
            this.button_back.TabIndex = 27;
            this.button_back.Text = "Quay lại";
            this.button_back.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_back.UseVisualStyleBackColor = false;
            this.button_back.Click += new System.EventHandler(this.button_back_Click);
            // 
            // button_OK
            // 
            this.button_OK.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_OK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_OK.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_OK.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_OK.Image = ((System.Drawing.Image)(resources.GetObject("button_OK.Image")));
            this.button_OK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_OK.Location = new System.Drawing.Point(840, 147);
            this.button_OK.Name = "button_OK";
            this.button_OK.Size = new System.Drawing.Size(90, 37);
            this.button_OK.TabIndex = 28;
            this.button_OK.Text = "Thêm";
            this.button_OK.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_OK.UseVisualStyleBackColor = false;
            this.button_OK.Click += new System.EventHandler(this.button_OK_Click);
            // 
            // button_Update
            // 
            this.button_Update.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Update.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_Update.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_Update.Image = ((System.Drawing.Image)(resources.GetObject("button_Update.Image")));
            this.button_Update.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Update.Location = new System.Drawing.Point(959, 147);
            this.button_Update.Name = "button_Update";
            this.button_Update.Size = new System.Drawing.Size(71, 36);
            this.button_Update.TabIndex = 28;
            this.button_Update.Text = "Sửa";
            this.button_Update.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_Update.UseVisualStyleBackColor = false;
            this.button_Update.Click += new System.EventHandler(this.button_Update_Click);
            // 
            // button_Xoa
            // 
            this.button_Xoa.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_Xoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Xoa.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_Xoa.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_Xoa.Image = ((System.Drawing.Image)(resources.GetObject("button_Xoa.Image")));
            this.button_Xoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Xoa.Location = new System.Drawing.Point(1055, 148);
            this.button_Xoa.Name = "button_Xoa";
            this.button_Xoa.Size = new System.Drawing.Size(70, 36);
            this.button_Xoa.TabIndex = 28;
            this.button_Xoa.Text = "Xóa";
            this.button_Xoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_Xoa.UseVisualStyleBackColor = false;
            this.button_Xoa.Click += new System.EventHandler(this.button_Xoa_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(251, 226);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // txt_thoiGian
            // 
            this.txt_thoiGian.Location = new System.Drawing.Point(862, 43);
            this.txt_thoiGian.Name = "txt_thoiGian";
            this.txt_thoiGian.Size = new System.Drawing.Size(206, 27);
            this.txt_thoiGian.TabIndex = 38;
            // 
            // label_date
            // 
            this.label_date.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_date.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label_date.Location = new System.Drawing.Point(775, 50);
            this.label_date.Name = "label_date";
            this.label_date.Size = new System.Drawing.Size(76, 20);
            this.label_date.TabIndex = 37;
            this.label_date.Text = "Thời gian";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // dgvFood
            // 
            this.dgvFood.AllowUserToAddRows = false;
            this.dgvFood.AllowUserToDeleteRows = false;
            this.dgvFood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFood.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaMon,
            this.TenMon,
            this.DonGia,
            this.ThoiGian});
            this.dgvFood.Location = new System.Drawing.Point(321, 242);
            this.dgvFood.Name = "dgvFood";
            this.dgvFood.RowHeadersWidth = 51;
            this.dgvFood.RowTemplate.Height = 29;
            this.dgvFood.Size = new System.Drawing.Size(833, 437);
            this.dgvFood.TabIndex = 41;
            this.dgvFood.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFood_CellContentClick);
            // 
            // MaMon
            // 
            this.MaMon.DataPropertyName = "MaMon";
            this.MaMon.HeaderText = "Mã món";
            this.MaMon.MinimumWidth = 6;
            this.MaMon.Name = "MaMon";
            this.MaMon.Width = 130;
            // 
            // TenMon
            // 
            this.TenMon.DataPropertyName = "TenMon";
            this.TenMon.HeaderText = "Tên món";
            this.TenMon.MinimumWidth = 6;
            this.TenMon.Name = "TenMon";
            this.TenMon.Width = 250;
            // 
            // DonGia
            // 
            this.DonGia.DataPropertyName = "DonGia";
            this.DonGia.HeaderText = "Đơn giá";
            this.DonGia.MinimumWidth = 6;
            this.DonGia.Name = "DonGia";
            this.DonGia.Width = 160;
            // 
            // ThoiGian
            // 
            this.ThoiGian.DataPropertyName = "ThoiGian";
            this.ThoiGian.HeaderText = "Thời gian cập nhật";
            this.ThoiGian.MinimumWidth = 6;
            this.ThoiGian.Name = "ThoiGian";
            this.ThoiGian.Width = 200;
            // 
            // button_reset
            // 
            this.button_reset.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_reset.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_reset.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_reset.Image = ((System.Drawing.Image)(resources.GetObject("button_reset.Image")));
            this.button_reset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_reset.Location = new System.Drawing.Point(1021, 197);
            this.button_reset.Name = "button_reset";
            this.button_reset.Size = new System.Drawing.Size(104, 29);
            this.button_reset.TabIndex = 42;
            this.button_reset.Text = "Làm mới";
            this.button_reset.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_reset.UseVisualStyleBackColor = false;
            this.button_reset.Click += new System.EventHandler(this.button_reset_Click);
            // 
            // FormAddMonAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 683);
            this.Controls.Add(this.button_reset);
            this.Controls.Add(this.dgvFood);
            this.Controls.Add(this.txt_thoiGian);
            this.Controls.Add(this.label_date);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button_Xoa);
            this.Controls.Add(this.button_Update);
            this.Controls.Add(this.button_OK);
            this.Controls.Add(this.button_back);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_donGia);
            this.Controls.Add(this.txt_maMon);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txt_tenMon);
            this.Controls.Add(this.label1);
            this.Name = "FormAddMonAn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAddMonAn";
            this.Load += new System.EventHandler(this.FormAddMonAn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFood)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox txt_maMon;
        private Label label10;
        private TextBox txt_tenMon;
        private Label label1;
        private Label label2;
        private TextBox txt_donGia;
        private Button button_back;
        private Button button_OK;
        private Button button_Update;
        private Button button_Xoa;
        private PictureBox pictureBox1;
        private TextBox txt_thoiGian;
        private Label label_date;
        private System.Windows.Forms.Timer timer1;
        private DataGridView dgvFood;
        private Button button_reset;
        private DataGridViewTextBoxColumn MaMon;
        private DataGridViewTextBoxColumn TenMon;
        private DataGridViewTextBoxColumn DonGia;
        private DataGridViewTextBoxColumn ThoiGian;
    }
}