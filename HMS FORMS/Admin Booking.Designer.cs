namespace HMS_FORMS
{
    partial class AdminBooking
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminBooking));
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Updaterbtn = new System.Windows.Forms.RadioButton();
            this.Searchrbtn = new System.Windows.Forms.RadioButton();
            this.Okbtn = new System.Windows.Forms.Button();
            this.Viewrbtn = new System.Windows.Forms.RadioButton();
            this.userControl11 = new HMS_FORMS.UserControl1();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker4 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(331, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Booking";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(467, 145);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(553, 294);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.Visible = false;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePicker4);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.dateTimePicker2);
            this.groupBox1.Controls.Add(this.dateTimePicker3);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(154, 145);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(307, 294);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Visible = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(23, 220);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 16);
            this.label8.TabIndex = 64;
            this.label8.Text = "Check out Time";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(23, 172);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 16);
            this.label9.TabIndex = 61;
            this.label9.Text = "Check out Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(23, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 16);
            this.label5.TabIndex = 57;
            this.label5.Text = "Check in Time";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(24, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 16);
            this.label4.TabIndex = 59;
            this.label4.Text = "Check in Date";
            // 
            // Updaterbtn
            // 
            this.Updaterbtn.AutoSize = true;
            this.Updaterbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Updaterbtn.ForeColor = System.Drawing.Color.Black;
            this.Updaterbtn.Location = new System.Drawing.Point(35, 236);
            this.Updaterbtn.Name = "Updaterbtn";
            this.Updaterbtn.Size = new System.Drawing.Size(77, 20);
            this.Updaterbtn.TabIndex = 70;
            this.Updaterbtn.TabStop = true;
            this.Updaterbtn.Text = "Update";
            this.Updaterbtn.UseVisualStyleBackColor = true;
            this.Updaterbtn.CheckedChanged += new System.EventHandler(this.Updaterbtn_CheckedChanged);
            // 
            // Searchrbtn
            // 
            this.Searchrbtn.AutoSize = true;
            this.Searchrbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Searchrbtn.ForeColor = System.Drawing.Color.Black;
            this.Searchrbtn.Location = new System.Drawing.Point(35, 191);
            this.Searchrbtn.Name = "Searchrbtn";
            this.Searchrbtn.Size = new System.Drawing.Size(75, 20);
            this.Searchrbtn.TabIndex = 72;
            this.Searchrbtn.TabStop = true;
            this.Searchrbtn.Text = "Search";
            this.Searchrbtn.UseVisualStyleBackColor = true;
            this.Searchrbtn.CheckedChanged += new System.EventHandler(this.Searchrbtn_CheckedChanged);
            // 
            // Okbtn
            // 
            this.Okbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Okbtn.ForeColor = System.Drawing.Color.Black;
            this.Okbtn.Location = new System.Drawing.Point(35, 289);
            this.Okbtn.Name = "Okbtn";
            this.Okbtn.Size = new System.Drawing.Size(75, 35);
            this.Okbtn.TabIndex = 73;
            this.Okbtn.Text = "OK";
            this.Okbtn.UseVisualStyleBackColor = true;
            this.Okbtn.Click += new System.EventHandler(this.Okbtn_Click);
            // 
            // Viewrbtn
            // 
            this.Viewrbtn.AutoSize = true;
            this.Viewrbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Viewrbtn.ForeColor = System.Drawing.Color.Black;
            this.Viewrbtn.Location = new System.Drawing.Point(35, 148);
            this.Viewrbtn.Name = "Viewrbtn";
            this.Viewrbtn.Size = new System.Drawing.Size(59, 20);
            this.Viewrbtn.TabIndex = 74;
            this.Viewrbtn.TabStop = true;
            this.Viewrbtn.Text = "View";
            this.Viewrbtn.UseVisualStyleBackColor = true;
            this.Viewrbtn.CheckedChanged += new System.EventHandler(this.Viewrbtn_CheckedChanged);
            // 
            // userControl11
            // 
            this.userControl11.BackColor = System.Drawing.Color.LightGray;
            this.userControl11.ForeColor = System.Drawing.Color.LightBlue;
            this.userControl11.id = "";
            this.userControl11.Location = new System.Drawing.Point(154, 95);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(307, 44);
            this.userControl11.TabIndex = 75;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(150, 40);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(127, 20);
            this.dateTimePicker1.TabIndex = 76;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker2.Location = new System.Drawing.Point(150, 88);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.ShowUpDown = true;
            this.dateTimePicker2.Size = new System.Drawing.Size(127, 20);
            this.dateTimePicker2.TabIndex = 77;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Location = new System.Drawing.Point(142, 172);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(135, 20);
            this.dateTimePicker3.TabIndex = 78;
            // 
            // dateTimePicker4
            // 
            this.dateTimePicker4.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker4.Location = new System.Drawing.Point(142, 220);
            this.dateTimePicker4.Name = "dateTimePicker4";
            this.dateTimePicker4.ShowUpDown = true;
            this.dateTimePicker4.Size = new System.Drawing.Size(135, 20);
            this.dateTimePicker4.TabIndex = 79;
            // 
            // AdminBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(1022, 543);
            this.Controls.Add(this.userControl11);
            this.Controls.Add(this.Viewrbtn);
            this.Controls.Add(this.Okbtn);
            this.Controls.Add(this.Searchrbtn);
            this.Controls.Add(this.Updaterbtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminBooking";
            this.Opacity = 0.75D;
            this.Text = "Booking";
            this.Load += new System.EventHandler(this.AdminBooking_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton Updaterbtn;
        private System.Windows.Forms.RadioButton Searchrbtn;
        private System.Windows.Forms.Button Okbtn;
        private System.Windows.Forms.RadioButton Viewrbtn;
        private UserControl1 userControl11;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.DateTimePicker dateTimePicker4;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
    }
}