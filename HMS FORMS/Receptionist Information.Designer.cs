namespace HMS_FORMS
{
    partial class Receptionist_Information
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Receptionist_Information));
            this.label1 = new System.Windows.Forms.Label();
            this.Viewrbtn = new System.Windows.Forms.RadioButton();
            this.Okbtn = new System.Windows.Forms.Button();
            this.Searchrbtn = new System.Windows.Forms.RadioButton();
            this.Deleterbtn = new System.Windows.Forms.RadioButton();
            this.Updaterbtn = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Insertrbtn = new System.Windows.Forms.RadioButton();
            this.userControl11 = new HMS_FORMS.UserControl1();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(299, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(565, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Receptionist Information";
            // 
            // Viewrbtn
            // 
            this.Viewrbtn.AutoSize = true;
            this.Viewrbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Viewrbtn.Location = new System.Drawing.Point(88, 278);
            this.Viewrbtn.Name = "Viewrbtn";
            this.Viewrbtn.Size = new System.Drawing.Size(59, 20);
            this.Viewrbtn.TabIndex = 6;
            this.Viewrbtn.TabStop = true;
            this.Viewrbtn.Text = "View";
            this.Viewrbtn.UseVisualStyleBackColor = true;
            // 
            // Okbtn
            // 
            this.Okbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Okbtn.Location = new System.Drawing.Point(90, 336);
            this.Okbtn.Name = "Okbtn";
            this.Okbtn.Size = new System.Drawing.Size(75, 35);
            this.Okbtn.TabIndex = 7;
            this.Okbtn.Text = "OK";
            this.Okbtn.UseVisualStyleBackColor = true;
            this.Okbtn.Click += new System.EventHandler(this.Okbtn_Click);
            // 
            // Searchrbtn
            // 
            this.Searchrbtn.AutoSize = true;
            this.Searchrbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Searchrbtn.Location = new System.Drawing.Point(88, 255);
            this.Searchrbtn.Name = "Searchrbtn";
            this.Searchrbtn.Size = new System.Drawing.Size(75, 20);
            this.Searchrbtn.TabIndex = 5;
            this.Searchrbtn.TabStop = true;
            this.Searchrbtn.Text = "Search";
            this.Searchrbtn.UseVisualStyleBackColor = true;
            // 
            // Deleterbtn
            // 
            this.Deleterbtn.AutoSize = true;
            this.Deleterbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deleterbtn.Location = new System.Drawing.Point(88, 232);
            this.Deleterbtn.Name = "Deleterbtn";
            this.Deleterbtn.Size = new System.Drawing.Size(72, 20);
            this.Deleterbtn.TabIndex = 4;
            this.Deleterbtn.TabStop = true;
            this.Deleterbtn.Text = "Delete";
            this.Deleterbtn.UseVisualStyleBackColor = true;
            // 
            // Updaterbtn
            // 
            this.Updaterbtn.AutoSize = true;
            this.Updaterbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Updaterbtn.Location = new System.Drawing.Point(88, 209);
            this.Updaterbtn.Name = "Updaterbtn";
            this.Updaterbtn.Size = new System.Drawing.Size(77, 20);
            this.Updaterbtn.TabIndex = 3;
            this.Updaterbtn.TabStop = true;
            this.Updaterbtn.Text = "Update";
            this.Updaterbtn.UseVisualStyleBackColor = true;
            this.Updaterbtn.CheckedChanged += new System.EventHandler(this.Updaterbtn_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox5);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(248, 185);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(302, 186);
            this.groupBox1.TabIndex = 86;
            this.groupBox1.TabStop = false;
            this.groupBox1.Visible = false;
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(149, 124);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(141, 22);
            this.textBox5.TabIndex = 4;
            this.textBox5.Validating += new System.ComponentModel.CancelEventHandler(this.textBox5_Validating);
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(148, 91);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(141, 22);
            this.textBox4.TabIndex = 3;
            this.textBox4.Validating += new System.ComponentModel.CancelEventHandler(this.textBox4_Validating);
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(148, 56);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(141, 22);
            this.textBox3.TabIndex = 2;
            this.textBox3.Validating += new System.ComponentModel.CancelEventHandler(this.textBox3_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(23, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 16);
            this.label5.TabIndex = 57;
            this.label5.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 16);
            this.label4.TabIndex = 59;
            this.label4.Text = "Email";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(148, 20);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(141, 22);
            this.textBox2.TabIndex = 1;
            this.textBox2.Text = "admin";
            this.textBox2.Validating += new System.ComponentModel.CancelEventHandler(this.textBox2_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 16);
            this.label3.TabIndex = 57;
            this.label3.Text = "Last Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 16);
            this.label2.TabIndex = 55;
            this.label2.Text = "First Name";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(592, 133);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(467, 283);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.Visible = false;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Insertrbtn
            // 
            this.Insertrbtn.AutoSize = true;
            this.Insertrbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Insertrbtn.Location = new System.Drawing.Point(88, 187);
            this.Insertrbtn.Name = "Insertrbtn";
            this.Insertrbtn.Size = new System.Drawing.Size(64, 20);
            this.Insertrbtn.TabIndex = 2;
            this.Insertrbtn.TabStop = true;
            this.Insertrbtn.Text = "Insert";
            this.Insertrbtn.UseVisualStyleBackColor = true;
            this.Insertrbtn.CheckedChanged += new System.EventHandler(this.Insertrbtn_CheckedChanged);
            // 
            // userControl11
            // 
            this.userControl11.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.userControl11.ForeColor = System.Drawing.Color.LightBlue;
            this.userControl11.id = "";
            this.userControl11.Location = new System.Drawing.Point(31, 92);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(249, 51);
            this.userControl11.TabIndex = 1;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Receptionist_Information
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(1129, 512);
            this.Controls.Add(this.userControl11);
            this.Controls.Add(this.Insertrbtn);
            this.Controls.Add(this.Viewrbtn);
            this.Controls.Add(this.Okbtn);
            this.Controls.Add(this.Searchrbtn);
            this.Controls.Add(this.Deleterbtn);
            this.Controls.Add(this.Updaterbtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Receptionist_Information";
            this.Text = "Receptionist_Information";
            this.Load += new System.EventHandler(this.Receptionist_Information_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
    
        private System.Windows.Forms.RadioButton Viewrbtn;
        private System.Windows.Forms.Button Okbtn;
        private System.Windows.Forms.RadioButton Searchrbtn;
        private System.Windows.Forms.RadioButton Deleterbtn;
        private System.Windows.Forms.RadioButton Updaterbtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RadioButton Insertrbtn;
        private System.Windows.Forms.Label label5;
        private UserControl1 userControl11;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}