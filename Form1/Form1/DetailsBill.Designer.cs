namespace Form1
{
    partial class DetailsBill
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DetailsBill));
            this.lb_time = new System.Windows.Forms.Label();
            this.lb_nameCus = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_numBill = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dgv_billDetails = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_billDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_time
            // 
            this.lb_time.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lb_time.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_time.Location = new System.Drawing.Point(447, 191);
            this.lb_time.Name = "lb_time";
            this.lb_time.Size = new System.Drawing.Size(172, 28);
            this.lb_time.TabIndex = 38;
            this.lb_time.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_nameCus
            // 
            this.lb_nameCus.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lb_nameCus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_nameCus.Location = new System.Drawing.Point(149, 191);
            this.lb_nameCus.Name = "lb_nameCus";
            this.lb_nameCus.Size = new System.Drawing.Size(166, 28);
            this.lb_nameCus.TabIndex = 37;
            this.lb_nameCus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-6, -4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(149, 115);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(447, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 25);
            this.label5.TabIndex = 35;
            this.label5.Text = "Thời gian";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(41, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 25);
            this.label2.TabIndex = 34;
            this.label2.Text = "Khách hàng";
            // 
            // lb_numBill
            // 
            this.lb_numBill.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lb_numBill.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_numBill.Location = new System.Drawing.Point(149, 142);
            this.lb_numBill.Name = "lb_numBill";
            this.lb_numBill.Size = new System.Drawing.Size(166, 28);
            this.lb_numBill.TabIndex = 33;
            this.lb_numBill.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(41, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 28);
            this.label4.TabIndex = 32;
            this.label4.Text = "Hóa đơn số:";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Font = new System.Drawing.Font("Delicious", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(227, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 52);
            this.label1.TabIndex = 31;
            this.label1.Text = "The Pizza Company";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(506, 637);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 25);
            this.label8.TabIndex = 42;
            this.label8.Text = "Đã thanh toán";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgv_billDetails
            // 
            this.dgv_billDetails.AllowUserToAddRows = false;
            this.dgv_billDetails.AllowUserToDeleteRows = false;
            this.dgv_billDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_billDetails.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgv_billDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_billDetails.Location = new System.Drawing.Point(41, 244);
            this.dgv_billDetails.Name = "dgv_billDetails";
            this.dgv_billDetails.ReadOnly = true;
            this.dgv_billDetails.RowHeadersWidth = 51;
            this.dgv_billDetails.RowTemplate.Height = 29;
            this.dgv_billDetails.Size = new System.Drawing.Size(578, 366);
            this.dgv_billDetails.TabIndex = 44;
            // 
            // DetailsBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(682, 685);
            this.Controls.Add(this.dgv_billDetails);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lb_time);
            this.Controls.Add(this.lb_nameCus);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lb_numBill);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "DetailsBill";
            this.Text = "DetailsBill";
            this.Load += new System.EventHandler(this.DetailsBill_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_billDetails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Label lb_time;
        private Label lb_nameCus;
        private PictureBox pictureBox1;
        private Label label5;
        private Label label2;
        private Label lb_numBill;
        private Label label4;
        private Label label1;
        private Label label8;
        private DataGridView dgv_billDetails;
    }
}