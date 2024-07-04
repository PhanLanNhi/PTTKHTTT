namespace Form1
{
    partial class App
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(App));
            this.button_LichLam = new System.Windows.Forms.Button();
            this.button_NhanVien = new System.Windows.Forms.Button();
            this.button_HoaDon = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button_MonAn = new System.Windows.Forms.Button();
            this.button_DoanhThu = new System.Windows.Forms.Button();
            this.bt_kho = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_LichLam
            // 
            this.button_LichLam.BackColor = System.Drawing.Color.SeaGreen;
            this.button_LichLam.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_LichLam.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_LichLam.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_LichLam.Location = new System.Drawing.Point(217, 62);
            this.button_LichLam.Name = "button_LichLam";
            this.button_LichLam.Size = new System.Drawing.Size(130, 40);
            this.button_LichLam.TabIndex = 0;
            this.button_LichLam.Text = "Lịch làm";
            this.button_LichLam.UseVisualStyleBackColor = false;
            this.button_LichLam.Click += new System.EventHandler(this.button_LichLam_Click);
            // 
            // button_NhanVien
            // 
            this.button_NhanVien.BackColor = System.Drawing.Color.SeaGreen;
            this.button_NhanVien.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_NhanVien.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_NhanVien.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_NhanVien.Location = new System.Drawing.Point(30, 62);
            this.button_NhanVien.Name = "button_NhanVien";
            this.button_NhanVien.Size = new System.Drawing.Size(130, 40);
            this.button_NhanVien.TabIndex = 1;
            this.button_NhanVien.Text = "Nhân viên";
            this.button_NhanVien.UseVisualStyleBackColor = false;
            this.button_NhanVien.Click += new System.EventHandler(this.button_NhanVien_Click);
            // 
            // button_HoaDon
            // 
            this.button_HoaDon.BackColor = System.Drawing.Color.SeaGreen;
            this.button_HoaDon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_HoaDon.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_HoaDon.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_HoaDon.Location = new System.Drawing.Point(217, 159);
            this.button_HoaDon.Name = "button_HoaDon";
            this.button_HoaDon.Size = new System.Drawing.Size(130, 40);
            this.button_HoaDon.TabIndex = 3;
            this.button_HoaDon.Text = "Bán hàng";
            this.button_HoaDon.UseVisualStyleBackColor = false;
            this.button_HoaDon.Click += new System.EventHandler(this.button_HoaDon_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(-1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(381, 104);
            this.label1.TabIndex = 4;
            this.label1.Text = "CHỌN CHỨC NĂNG";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_MonAn
            // 
            this.button_MonAn.BackColor = System.Drawing.Color.SeaGreen;
            this.button_MonAn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_MonAn.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_MonAn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_MonAn.Location = new System.Drawing.Point(30, 159);
            this.button_MonAn.Name = "button_MonAn";
            this.button_MonAn.Size = new System.Drawing.Size(130, 40);
            this.button_MonAn.TabIndex = 5;
            this.button_MonAn.Text = "Món ăn";
            this.button_MonAn.UseVisualStyleBackColor = false;
            this.button_MonAn.Click += new System.EventHandler(this.button_MonAn_Click);
            // 
            // button_DoanhThu
            // 
            this.button_DoanhThu.BackColor = System.Drawing.Color.SeaGreen;
            this.button_DoanhThu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_DoanhThu.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_DoanhThu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_DoanhThu.Location = new System.Drawing.Point(30, 252);
            this.button_DoanhThu.Name = "button_DoanhThu";
            this.button_DoanhThu.Size = new System.Drawing.Size(130, 40);
            this.button_DoanhThu.TabIndex = 6;
            this.button_DoanhThu.Text = "Hóa đơn";
            this.button_DoanhThu.UseVisualStyleBackColor = false;
            this.button_DoanhThu.Click += new System.EventHandler(this.button_DoanhThu_Click);
            // 
            // bt_kho
            // 
            this.bt_kho.BackColor = System.Drawing.Color.SeaGreen;
            this.bt_kho.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_kho.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt_kho.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bt_kho.Location = new System.Drawing.Point(217, 252);
            this.bt_kho.Name = "bt_kho";
            this.bt_kho.Size = new System.Drawing.Size(130, 40);
            this.bt_kho.TabIndex = 7;
            this.bt_kho.Text = "Kho";
            this.bt_kho.UseVisualStyleBackColor = false;
            this.bt_kho.Click += new System.EventHandler(this.bt_kho_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.button_LichLam);
            this.panel1.Controls.Add(this.bt_kho);
            this.panel1.Controls.Add(this.button_NhanVien);
            this.panel1.Controls.Add(this.button_DoanhThu);
            this.panel1.Controls.Add(this.button_HoaDon);
            this.panel1.Controls.Add(this.button_MonAn);
            this.panel1.Location = new System.Drawing.Point(-1, 99);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(381, 528);
            this.panel1.TabIndex = 8;
            // 
            // App
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1092, 619);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "App";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "App";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Button button_LichLam;
        private Button button_NhanVien;
        private Button button_HoaDon;
        private Label label1;
        private Button button_MonAn;
        private Button button_DoanhThu;
        private Button bt_kho;
        private Panel panel1;
    }
}