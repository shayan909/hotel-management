namespace HMS_FORMS
{
    partial class AdminRooms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminRooms));
            this.label2 = new System.Windows.Forms.Label();
            this.UC_Customer_Record_Updatebtn = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.roomtypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zabHotelDataSet8 = new HMS_FORMS.zabHotelDataSet8();
            this.room_typeTableAdapter = new HMS_FORMS.zabHotelDataSet8TableAdapters.room_typeTableAdapter();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomtypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zabHotelDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(67, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Room Type ID";
            // 
            // UC_Customer_Record_Updatebtn
            // 
            this.UC_Customer_Record_Updatebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UC_Customer_Record_Updatebtn.Location = new System.Drawing.Point(194, 274);
            this.UC_Customer_Record_Updatebtn.Name = "UC_Customer_Record_Updatebtn";
            this.UC_Customer_Record_Updatebtn.Size = new System.Drawing.Size(75, 23);
            this.UC_Customer_Record_Updatebtn.TabIndex = 3;
            this.UC_Customer_Record_Updatebtn.Text = "Update";
            this.UC_Customer_Record_Updatebtn.UseVisualStyleBackColor = true;
            this.UC_Customer_Record_Updatebtn.Click += new System.EventHandler(this.UC_Customer_Record_Updatebtn_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(182, 211);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(121, 20);
            this.textBox2.TabIndex = 2;
            this.textBox2.Validating += new System.ComponentModel.CancelEventHandler(this.textBox2_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(116, 215);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 48;
            this.label1.Text = "Amount";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(358, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 39);
            this.label3.TabIndex = 50;
            this.label3.Text = "Rooms";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(376, 118);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(442, 246);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.roomtypeBindingSource;
            this.comboBox1.DisplayMember = "roomtypeID";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(182, 130);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.ValueMember = "roomtypeID";
            this.comboBox1.Validating += new System.ComponentModel.CancelEventHandler(this.comboBox1_Validating);
            // 
            // roomtypeBindingSource
            // 
            this.roomtypeBindingSource.DataMember = "room_type";
            this.roomtypeBindingSource.DataSource = this.zabHotelDataSet8;
            // 
            // zabHotelDataSet8
            // 
            this.zabHotelDataSet8.DataSetName = "zabHotelDataSet8";
            this.zabHotelDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // room_typeTableAdapter
            // 
            this.room_typeTableAdapter.ClearBeforeFill = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // AdminRooms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(830, 424);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UC_Customer_Record_Updatebtn);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminRooms";
            this.Text = "Rooms";
            this.Load += new System.EventHandler(this.AdminRooms_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomtypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zabHotelDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button UC_Customer_Record_Updatebtn;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox1;
        private zabHotelDataSet8 zabHotelDataSet8;
        private System.Windows.Forms.BindingSource roomtypeBindingSource;
        private zabHotelDataSet8TableAdapters.room_typeTableAdapter room_typeTableAdapter;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}