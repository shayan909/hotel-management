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
            this.ViewAllbtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.uC_ID_UDS1 = new HMS_FORMS.UC_ID_UDS();
            this.uC_Booking1 = new HMS_FORMS.UC_Booking();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(222, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Booking";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ViewAllbtn
            // 
            this.ViewAllbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewAllbtn.Location = new System.Drawing.Point(463, 100);
            this.ViewAllbtn.Name = "ViewAllbtn";
            this.ViewAllbtn.Size = new System.Drawing.Size(75, 35);
            this.ViewAllbtn.TabIndex = 14;
            this.ViewAllbtn.Text = "View All";
            this.ViewAllbtn.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(258, 147);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(455, 255);
            this.dataGridView1.TabIndex = 15;
            // 
            // uC_ID_UDS1
            // 
            this.uC_ID_UDS1.BackColor = System.Drawing.SystemColors.Highlight;
            this.uC_ID_UDS1.Location = new System.Drawing.Point(44, 166);
            this.uC_ID_UDS1.Name = "uC_ID_UDS1";
            this.uC_ID_UDS1.Size = new System.Drawing.Size(175, 165);
            this.uC_ID_UDS1.TabIndex = 16;
            // 
            // uC_Booking1
            // 
            this.uC_Booking1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.uC_Booking1.Location = new System.Drawing.Point(140, 108);
            this.uC_Booking1.Name = "uC_Booking1";
            this.uC_Booking1.Size = new System.Drawing.Size(234, 321);
            this.uC_Booking1.TabIndex = 17;
            // 
            // AdminBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(738, 440);
            this.Controls.Add(this.uC_Booking1);
            this.Controls.Add(this.uC_ID_UDS1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ViewAllbtn);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminBooking";
            this.Text = "Booking";
            this.Load += new System.EventHandler(this.AdminBooking_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ViewAllbtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private UC_ID_UDS uC_ID_UDS1;
        private UC_Booking uC_Booking1;
    }
}