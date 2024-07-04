namespace Form1
{
    partial class FormBill
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBill));
            this.listview_Bill = new System.Windows.Forms.ListView();
            this.product = new System.Windows.Forms.ColumnHeader();
            this.SoLuongProduct = new System.Windows.Forms.ColumnHeader();
            this.price = new System.Windows.Forms.ColumnHeader();
            this.totalPrice = new System.Windows.Forms.ColumnHeader();
            this.label1 = new System.Windows.Forms.Label();
            this.label_numberBill = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label_discount = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label_payment = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label_note = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label_nameCustomer = new System.Windows.Forms.Label();
            this.label_timeBill = new System.Windows.Forms.Label();
            this.bt_PrintBill = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // listview_Bill
            // 
            this.listview_Bill.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.product,
            this.SoLuongProduct,
            this.price,
            this.totalPrice});
            this.listview_Bill.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.listview_Bill.GridLines = true;
            this.listview_Bill.Location = new System.Drawing.Point(55, 231);
            this.listview_Bill.Name = "listview_Bill";
            this.listview_Bill.Size = new System.Drawing.Size(573, 343);
            this.listview_Bill.TabIndex = 10;
            this.listview_Bill.UseCompatibleStateImageBehavior = false;
            this.listview_Bill.View = System.Windows.Forms.View.Details;
            // 
            // product
            // 
            this.product.Text = "Sản phẩm";
            this.product.Width = 185;
            // 
            // SoLuongProduct
            // 
            this.SoLuongProduct.Text = "Số lượng";
            this.SoLuongProduct.Width = 100;
            // 
            // price
            // 
            this.price.Text = "Giá";
            this.price.Width = 120;
            // 
            // totalPrice
            // 
            this.totalPrice.Text = "Tổng tiền";
            this.totalPrice.Width = 160;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(211, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 52);
            this.label1.TabIndex = 12;
            this.label1.Text = "The Pizza Company";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_numberBill
            // 
            this.label_numberBill.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label_numberBill.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_numberBill.Location = new System.Drawing.Point(158, 131);
            this.label_numberBill.Name = "label_numberBill";
            this.label_numberBill.Size = new System.Drawing.Size(166, 28);
            this.label_numberBill.TabIndex = 16;
            this.label_numberBill.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(50, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 25);
            this.label2.TabIndex = 17;
            this.label2.Text = "Khách hàng";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(456, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 25);
            this.label5.TabIndex = 18;
            this.label5.Text = "Thời gian";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(50, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 28);
            this.label4.TabIndex = 15;
            this.label4.Text = "Hóa đơn số:";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(414, 590);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 28);
            this.label6.TabIndex = 19;
            this.label6.Text = "Giảm giá: \r\n";
            // 
            // label_discount
            // 
            this.label_discount.BackColor = System.Drawing.Color.Gainsboro;
            this.label_discount.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_discount.Location = new System.Drawing.Point(504, 586);
            this.label_discount.Name = "label_discount";
            this.label_discount.Size = new System.Drawing.Size(124, 28);
            this.label_discount.TabIndex = 20;
            this.label_discount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(414, 629);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 25);
            this.label8.TabIndex = 21;
            this.label8.Text = "Thanh toán:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_payment
            // 
            this.label_payment.BackColor = System.Drawing.Color.Gainsboro;
            this.label_payment.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_payment.Location = new System.Drawing.Point(504, 626);
            this.label_payment.Name = "label_payment";
            this.label_payment.Size = new System.Drawing.Size(124, 28);
            this.label_payment.TabIndex = 22;
            this.label_payment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(50, 590);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 25);
            this.label11.TabIndex = 24;
            this.label11.Text = "Ghi chú";
            // 
            // label_note
            // 
            this.label_note.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label_note.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label_note.Location = new System.Drawing.Point(50, 615);
            this.label_note.Name = "label_note";
            this.label_note.Size = new System.Drawing.Size(230, 89);
            this.label_note.TabIndex = 25;
            this.label_note.Text = "Giảm giá cực hot!!!\r\n200.000 vnđ trở lên giảm 5%\r\n500.000 vnđ trở lên giảm 7%\r\n1." +
    "000.000 vnđ trở lên giảm 10%\r\n";
            this.label_note.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(149, 115);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // label_nameCustomer
            // 
            this.label_nameCustomer.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label_nameCustomer.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_nameCustomer.Location = new System.Drawing.Point(158, 180);
            this.label_nameCustomer.Name = "label_nameCustomer";
            this.label_nameCustomer.Size = new System.Drawing.Size(166, 28);
            this.label_nameCustomer.TabIndex = 29;
            this.label_nameCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_timeBill
            // 
            this.label_timeBill.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label_timeBill.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_timeBill.Location = new System.Drawing.Point(456, 180);
            this.label_timeBill.Name = "label_timeBill";
            this.label_timeBill.Size = new System.Drawing.Size(172, 28);
            this.label_timeBill.TabIndex = 30;
            this.label_timeBill.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_timeBill.Click += new System.EventHandler(this.label_timeBill_Click);
            // 
            // bt_PrintBill
            // 
            this.bt_PrintBill.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt_PrintBill.Image = ((System.Drawing.Image)(resources.GetObject("bt_PrintBill.Image")));
            this.bt_PrintBill.Location = new System.Drawing.Point(504, 674);
            this.bt_PrintBill.Name = "bt_PrintBill";
            this.bt_PrintBill.Size = new System.Drawing.Size(124, 38);
            this.bt_PrintBill.TabIndex = 31;
            this.bt_PrintBill.Text = "Lưu";
            this.bt_PrintBill.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_PrintBill.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bt_PrintBill.UseVisualStyleBackColor = true;
            this.bt_PrintBill.Click += new System.EventHandler(this.bt_PrintBill_Click);
            // 
            // FormBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(682, 753);
            this.Controls.Add(this.bt_PrintBill);
            this.Controls.Add(this.label_timeBill);
            this.Controls.Add(this.label_nameCustomer);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label_note);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label_payment);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label_discount);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_numberBill);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listview_Bill);
            this.Name = "FormBill";
            this.Text = "FormBill";
            this.Load += new System.EventHandler(this.FormBill_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ListView listview_Bill;
        private ColumnHeader product;
        private ColumnHeader SoLuongProduct;
        private ColumnHeader price;
        private ColumnHeader totalPrice;
        private Label label1;
        private Label label_numberBill;
        private Label label2;
        private Label label5;
        private Label label4;
        private Label label6;
        private Label label_discount;
        private Label label8;
        private Label label_payment;
        private Label label11;
        private Label label_note;
        private PictureBox pictureBox1;
        private Label label_nameCustomer;
        private Label label_timeBill;
        private Button bt_PrintBill;
    }
}