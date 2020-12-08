namespace HMS_FORMS
{
    partial class RServicesUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.servicesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.OKbtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.zabHotelDataSet7 = new HMS_FORMS.zabHotelDataSet7();
            this.bookingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookingTableAdapter = new HMS_FORMS.zabHotelDataSet7TableAdapters.bookingTableAdapter();
            this.zabHotelDataSet1 = new HMS_FORMS.zabHotelDataSet1();
            this.servicesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.servicesTableAdapter = new HMS_FORMS.zabHotelDataSet1TableAdapters.servicesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.servicesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zabHotelDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zabHotelDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicesBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.servicesBindingSource1;
            this.comboBox1.DisplayMember = "name";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(596, 219);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 82;
            this.comboBox1.ValueMember = "name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(485, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 16);
            this.label3.TabIndex = 81;
            this.label3.Text = "Service";
            // 
            // OKbtn
            // 
            this.OKbtn.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.OKbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OKbtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.OKbtn.Location = new System.Drawing.Point(615, 284);
            this.OKbtn.Name = "OKbtn";
            this.OKbtn.Size = new System.Drawing.Size(90, 28);
            this.OKbtn.TabIndex = 80;
            this.OKbtn.Text = "OK";
            this.OKbtn.UseVisualStyleBackColor = false;
            this.OKbtn.Click += new System.EventHandler(this.OKbtn_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(485, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 16);
            this.label2.TabIndex = 79;
            this.label2.Text = "Booking ID";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(537, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 46);
            this.label1.TabIndex = 78;
            this.label1.Text = "Services";
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.bookingBindingSource;
            this.comboBox2.DisplayMember = "BookingID";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(596, 130);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 83;
            this.comboBox2.ValueMember = "BookingID";
            // 
            // zabHotelDataSet7
            // 
            this.zabHotelDataSet7.DataSetName = "zabHotelDataSet7";
            this.zabHotelDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bookingBindingSource
            // 
            this.bookingBindingSource.DataMember = "booking";
            this.bookingBindingSource.DataSource = this.zabHotelDataSet7;
            // 
            // bookingTableAdapter
            // 
            this.bookingTableAdapter.ClearBeforeFill = true;
            // 
            // zabHotelDataSet1
            // 
            this.zabHotelDataSet1.DataSetName = "zabHotelDataSet1";
            this.zabHotelDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // servicesBindingSource1
            // 
            this.servicesBindingSource1.DataMember = "services";
            this.servicesBindingSource1.DataSource = this.zabHotelDataSet1;
            // 
            // servicesTableAdapter
            // 
            this.servicesTableAdapter.ClearBeforeFill = true;
            // 
            // RServicesUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.OKbtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox2);
            this.Name = "RServicesUC";
            this.Size = new System.Drawing.Size(1271, 568);
            this.Load += new System.EventHandler(this.RServicesUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.servicesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zabHotelDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zabHotelDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicesBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource servicesBindingSource;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button OKbtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.BindingSource servicesBindingSource1;
        private zabHotelDataSet1 zabHotelDataSet1;
        private System.Windows.Forms.BindingSource bookingBindingSource;
        private zabHotelDataSet7 zabHotelDataSet7;
        private zabHotelDataSet7TableAdapters.bookingTableAdapter bookingTableAdapter;
        private zabHotelDataSet1TableAdapters.servicesTableAdapter servicesTableAdapter;
    }
}
