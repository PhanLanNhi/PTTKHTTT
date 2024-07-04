namespace Form1
{
    partial class FormQLNV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormQLNV));
            this.dgv_NV = new System.Windows.Forms.DataGridView();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_updateInfoNV = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.button_back = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.date_NV = new System.Windows.Forms.DateTimePicker();
            this.cb_GioiTinh = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button_addNV = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_HoTen = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_MaNV = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.Clear_InfoNV = new System.Windows.Forms.Button();
            this.txt_numberphone = new System.Windows.Forms.TextBox();
            this.txt_address = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_NV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_NV
            // 
            this.dgv_NV.AllowUserToAddRows = false;
            this.dgv_NV.AllowUserToDeleteRows = false;
            this.dgv_NV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_NV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_NV.Location = new System.Drawing.Point(284, 277);
            this.dgv_NV.Name = "dgv_NV";
            this.dgv_NV.ReadOnly = true;
            this.dgv_NV.RowHeadersWidth = 51;
            this.dgv_NV.RowTemplate.Height = 29;
            this.dgv_NV.Size = new System.Drawing.Size(933, 377);
            this.dgv_NV.TabIndex = 0;
            this.dgv_NV.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_NV_CellContentDoubleClick);
            // 
            // button_delete
            // 
            this.button_delete.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_delete.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_delete.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_delete.Image = ((System.Drawing.Image)(resources.GetObject("button_delete.Image")));
            this.button_delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_delete.Location = new System.Drawing.Point(967, 216);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(77, 32);
            this.button_delete.TabIndex = 17;
            this.button_delete.Text = "Xóa";
            this.button_delete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_delete.UseVisualStyleBackColor = false;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // button_updateInfoNV
            // 
            this.button_updateInfoNV.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_updateInfoNV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_updateInfoNV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_updateInfoNV.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_updateInfoNV.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_updateInfoNV.Image = ((System.Drawing.Image)(resources.GetObject("button_updateInfoNV.Image")));
            this.button_updateInfoNV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_updateInfoNV.Location = new System.Drawing.Point(868, 216);
            this.button_updateInfoNV.Name = "button_updateInfoNV";
            this.button_updateInfoNV.Size = new System.Drawing.Size(82, 32);
            this.button_updateInfoNV.TabIndex = 16;
            this.button_updateInfoNV.Text = "Sửa";
            this.button_updateInfoNV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_updateInfoNV.UseVisualStyleBackColor = false;
            this.button_updateInfoNV.Click += new System.EventHandler(this.button_updateInfoNV_Click);
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.DarkGray;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(284, -1);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(933, 51);
            this.label9.TabIndex = 18;
            this.label9.Text = "QUẢN LÝ NHÂN VIÊN";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_back
            // 
            this.button_back.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_back.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_back.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_back.Image = ((System.Drawing.Image)(resources.GetObject("button_back.Image")));
            this.button_back.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_back.Location = new System.Drawing.Point(44, 601);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(104, 40);
            this.button_back.TabIndex = 19;
            this.button_back.Text = "Quay lại";
            this.button_back.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_back.UseVisualStyleBackColor = false;
            this.button_back.Click += new System.EventHandler(this.button_back_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(-2, -1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(287, 249);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 31;
            this.pictureBox2.TabStop = false;
            // 
            // date_NV
            // 
            this.date_NV.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_NV.Location = new System.Drawing.Point(1026, 79);
            this.date_NV.Name = "date_NV";
            this.date_NV.Size = new System.Drawing.Size(145, 27);
            this.date_NV.TabIndex = 58;
            // 
            // cb_GioiTinh
            // 
            this.cb_GioiTinh.FormattingEnabled = true;
            this.cb_GioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cb_GioiTinh.Location = new System.Drawing.Point(370, 154);
            this.cb_GioiTinh.Name = "cb_GioiTinh";
            this.cb_GioiTinh.Size = new System.Drawing.Size(145, 28);
            this.cb_GioiTinh.TabIndex = 55;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(918, 156);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 27);
            this.label7.TabIndex = 53;
            this.label7.Text = "Địa chỉ";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(916, 119);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 27);
            this.label8.TabIndex = 51;
            this.label8.Text = "Số điện thoại";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button_addNV
            // 
            this.button_addNV.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_addNV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_addNV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_addNV.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_addNV.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_addNV.Image = ((System.Drawing.Image)(resources.GetObject("button_addNV.Image")));
            this.button_addNV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_addNV.Location = new System.Drawing.Point(766, 216);
            this.button_addNV.Name = "button_addNV";
            this.button_addNV.Size = new System.Drawing.Size(87, 32);
            this.button_addNV.TabIndex = 17;
            this.button_addNV.Text = "Thêm";
            this.button_addNV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_addNV.UseVisualStyleBackColor = false;
            this.button_addNV.Click += new System.EventHandler(this.button_addNV_Click);
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(295, 154);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 27);
            this.label11.TabIndex = 49;
            this.label11.Text = "Giới tính";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_HoTen
            // 
            this.txt_HoTen.Location = new System.Drawing.Point(370, 119);
            this.txt_HoTen.Name = "txt_HoTen";
            this.txt_HoTen.Size = new System.Drawing.Size(224, 27);
            this.txt_HoTen.TabIndex = 42;
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(916, 83);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(80, 27);
            this.label13.TabIndex = 46;
            this.label13.Text = "Ngày sinh";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_MaNV
            // 
            this.txt_MaNV.Location = new System.Drawing.Point(370, 83);
            this.txt_MaNV.Name = "txt_MaNV";
            this.txt_MaNV.Size = new System.Drawing.Size(145, 27);
            this.txt_MaNV.TabIndex = 44;
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(295, 119);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(78, 27);
            this.label14.TabIndex = 43;
            this.label14.Text = "Họ tên";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label15.Location = new System.Drawing.Point(295, 86);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(69, 20);
            this.label15.TabIndex = 41;
            this.label15.Text = "Mã NV";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Clear_InfoNV
            // 
            this.Clear_InfoNV.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Clear_InfoNV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Clear_InfoNV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Clear_InfoNV.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Clear_InfoNV.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Clear_InfoNV.Image = ((System.Drawing.Image)(resources.GetObject("Clear_InfoNV.Image")));
            this.Clear_InfoNV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Clear_InfoNV.Location = new System.Drawing.Point(1059, 216);
            this.Clear_InfoNV.Name = "Clear_InfoNV";
            this.Clear_InfoNV.Size = new System.Drawing.Size(112, 32);
            this.Clear_InfoNV.TabIndex = 59;
            this.Clear_InfoNV.Text = "Làm mới";
            this.Clear_InfoNV.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Clear_InfoNV.UseVisualStyleBackColor = false;
            this.Clear_InfoNV.Click += new System.EventHandler(this.Clear_InfoNV_Click);
            // 
            // txt_numberphone
            // 
            this.txt_numberphone.Location = new System.Drawing.Point(1026, 119);
            this.txt_numberphone.Name = "txt_numberphone";
            this.txt_numberphone.Size = new System.Drawing.Size(145, 27);
            this.txt_numberphone.TabIndex = 60;
            // 
            // txt_address
            // 
            this.txt_address.Location = new System.Drawing.Point(1026, 156);
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(145, 27);
            this.txt_address.TabIndex = 61;
            // 
            // ListNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1212, 653);
            this.Controls.Add(this.txt_address);
            this.Controls.Add(this.txt_numberphone);
            this.Controls.Add(this.Clear_InfoNV);
            this.Controls.Add(this.date_NV);
            this.Controls.Add(this.button_addNV);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.button_updateInfoNV);
            this.Controls.Add(this.cb_GioiTinh);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button_back);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dgv_NV);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txt_HoTen);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txt_MaNV);
            this.Name = "ListNV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListNV";
            this.Load += new System.EventHandler(this.ListNV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_NV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgv_NV;
        private Button button_delete;
        private Button button_updateInfoNV;
        private Label label9;
        private Button button_back;
        private PictureBox pictureBox2;
        private DateTimePicker date_NV;
        private ComboBox cb_GioiTinh;
        private Label label7;
        private Label label8;
        private Button button_addNV;
        private Label label11;
        private TextBox txt_HoTen;
        private Label label13;
        private TextBox txt_MaNV;
        private Label label14;
        private Label label15;
        private Button Clear_InfoNV;
        private TextBox txt_numberphone;
        private TextBox txt_address;
    }
}