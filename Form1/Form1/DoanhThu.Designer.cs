namespace Form1
{
    partial class DoanhThu
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
            this.label1 = new System.Windows.Forms.Label();
            this.datePickStart = new System.Windows.Forms.DateTimePicker();
            this.datePickEnd = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(32, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thời Gian";
            // 
            // datePickStart
            // 
            this.datePickStart.CustomFormat = "";
            this.datePickStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datePickStart.Location = new System.Drawing.Point(156, 14);
            this.datePickStart.Name = "datePickStart";
            this.datePickStart.Size = new System.Drawing.Size(221, 27);
            this.datePickStart.TabIndex = 1;
            // 
            // datePickEnd
            // 
            this.datePickEnd.CustomFormat = "";
            this.datePickEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datePickEnd.Location = new System.Drawing.Point(423, 14);
            this.datePickEnd.Name = "datePickEnd";
            this.datePickEnd.Size = new System.Drawing.Size(221, 27);
            this.datePickEnd.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(854, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 29);
            this.button1.TabIndex = 3;
            this.button1.Text = "Ngày hôm nay";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1025, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(131, 29);
            this.button2.TabIndex = 4;
            this.button2.Text = "7 ngày gần nhất";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1183, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(142, 29);
            this.button3.TabIndex = 5;
            this.button3.Text = "30 ngày gần nhất";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(702, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(94, 29);
            this.button4.TabIndex = 6;
            this.button4.Text = "Tùy chọn";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // DoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1414, 727);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.datePickEnd);
            this.Controls.Add(this.datePickStart);
            this.Controls.Add(this.label1);
            this.Name = "DoanhThu";
            this.Text = "DoanhThu";
            this.ResumeLayout(false);

        }

        #endregion

        private Label label1;
        private DateTimePicker datePickStart;
        private DateTimePicker datePickEnd;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}