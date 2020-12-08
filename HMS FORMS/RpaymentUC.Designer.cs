namespace HMS_FORMS
{
    partial class RpaymentUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RpaymentUC));
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Donebtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.zabHotelDataSet7 = new HMS_FORMS.zabHotelDataSet7();
            this.bookingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookingTableAdapter = new HMS_FORMS.zabHotelDataSet7TableAdapters.bookingTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zabHotelDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox2
            // 
            resources.ApplyResources(this.comboBox2, "comboBox2");
            this.comboBox2.DataSource = this.bookingBindingSource;
            this.comboBox2.DisplayMember = "BookingID";
            this.errorProvider1.SetError(this.comboBox2, resources.GetString("comboBox2.Error"));
            this.comboBox2.FormattingEnabled = true;
            this.errorProvider1.SetIconAlignment(this.comboBox2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("comboBox2.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.comboBox2, ((int)(resources.GetObject("comboBox2.IconPadding"))));
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.ValueMember = "BookingID";
            this.comboBox2.Validating += new System.ComponentModel.CancelEventHandler(this.comboBox2_Validating_1);
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.errorProvider1.SetError(this.pictureBox1, resources.GetString("pictureBox1.Error"));
            this.errorProvider1.SetIconAlignment(this.pictureBox1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("pictureBox1.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.pictureBox1, ((int)(resources.GetObject("pictureBox1.IconPadding"))));
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // richTextBox1
            // 
            resources.ApplyResources(this.richTextBox1, "richTextBox1");
            this.errorProvider1.SetError(this.richTextBox1, resources.GetString("richTextBox1.Error"));
            this.errorProvider1.SetIconAlignment(this.richTextBox1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("richTextBox1.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.richTextBox1, ((int)(resources.GetObject("richTextBox1.IconPadding"))));
            this.richTextBox1.Name = "richTextBox1";
            // 
            // comboBox1
            // 
            resources.ApplyResources(this.comboBox1, "comboBox1");
            this.errorProvider1.SetError(this.comboBox1, resources.GetString("comboBox1.Error"));
            this.comboBox1.FormattingEnabled = true;
            this.errorProvider1.SetIconAlignment(this.comboBox1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("comboBox1.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.comboBox1, ((int)(resources.GetObject("comboBox1.IconPadding"))));
            this.comboBox1.Items.AddRange(new object[] {
            resources.GetString("comboBox1.Items"),
            resources.GetString("comboBox1.Items1"),
            resources.GetString("comboBox1.Items2")});
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Validating += new System.ComponentModel.CancelEventHandler(this.comboBox1_Validating);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.errorProvider1.SetError(this.label3, resources.GetString("label3.Error"));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.errorProvider1.SetIconAlignment(this.label3, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label3.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.label3, ((int)(resources.GetObject("label3.IconPadding"))));
            this.label3.Name = "label3";
            // 
            // Donebtn
            // 
            resources.ApplyResources(this.Donebtn, "Donebtn");
            this.Donebtn.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.errorProvider1.SetError(this.Donebtn, resources.GetString("Donebtn.Error"));
            this.Donebtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.errorProvider1.SetIconAlignment(this.Donebtn, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("Donebtn.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.Donebtn, ((int)(resources.GetObject("Donebtn.IconPadding"))));
            this.Donebtn.Name = "Donebtn";
            this.Donebtn.UseVisualStyleBackColor = false;
            this.Donebtn.Click += new System.EventHandler(this.Donebtn_Click_1);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.errorProvider1.SetError(this.label2, resources.GetString("label2.Error"));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.errorProvider1.SetIconAlignment(this.label2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label2.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.label2, ((int)(resources.GetObject("label2.IconPadding"))));
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.errorProvider1.SetError(this.label1, resources.GetString("label1.Error"));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.errorProvider1.SetIconAlignment(this.label1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label1.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this.label1, ((int)(resources.GetObject("label1.IconPadding"))));
            this.label1.Name = "label1";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            resources.ApplyResources(this.errorProvider1, "errorProvider1");
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
            // RpaymentUC
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Donebtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.errorProvider1.SetError(this, resources.GetString("$this.Error"));
            this.errorProvider1.SetIconAlignment(this, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("$this.IconAlignment"))));
            this.errorProvider1.SetIconPadding(this, ((int)(resources.GetObject("$this.IconPadding"))));
            this.Name = "RpaymentUC";
            this.Load += new System.EventHandler(this.RpaymentUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zabHotelDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Donebtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.BindingSource bookingBindingSource;
        private zabHotelDataSet7 zabHotelDataSet7;
        private zabHotelDataSet7TableAdapters.bookingTableAdapter bookingTableAdapter;
    }
}
