namespace Login_form
{
    partial class UpdateCus
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
            this.panelUpCus = new System.Windows.Forms.Panel();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inventory_ManagementDataSet = new Login_form.Inventory_ManagementDataSet();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ExtbrnSup = new System.Windows.Forms.Button();
            this.savebtnSup = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textUsername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.customersTableAdapter = new Login_form.Inventory_ManagementDataSetTableAdapters.CustomersTableAdapter();
            this.panelUpCus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventory_ManagementDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // panelUpCus
            // 
            this.panelUpCus.BackColor = System.Drawing.Color.White;
            this.panelUpCus.Controls.Add(this.comboBox3);
            this.panelUpCus.Controls.Add(this.panel1);
            this.panelUpCus.Controls.Add(this.label4);
            this.panelUpCus.Controls.Add(this.panel5);
            this.panelUpCus.Controls.Add(this.panel4);
            this.panelUpCus.Controls.Add(this.panel2);
            this.panelUpCus.Controls.Add(this.panel3);
            this.panelUpCus.Controls.Add(this.ExtbrnSup);
            this.panelUpCus.Controls.Add(this.savebtnSup);
            this.panelUpCus.Controls.Add(this.label3);
            this.panelUpCus.Controls.Add(this.label2);
            this.panelUpCus.Controls.Add(this.textBox1);
            this.panelUpCus.Controls.Add(this.textBox4);
            this.panelUpCus.Controls.Add(this.textBox2);
            this.panelUpCus.Controls.Add(this.textUsername);
            this.panelUpCus.Controls.Add(this.label1);
            this.panelUpCus.Controls.Add(this.label5);
            this.panelUpCus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelUpCus.Location = new System.Drawing.Point(0, 0);
            this.panelUpCus.Name = "panelUpCus";
            this.panelUpCus.Size = new System.Drawing.Size(536, 392);
            this.panelUpCus.TabIndex = 1;
            this.panelUpCus.Paint += new System.Windows.Forms.PaintEventHandler(this.panelUpCus_Paint);
            // 
            // comboBox3
            // 
            this.comboBox3.DataSource = this.customersBindingSource;
            this.comboBox3.DisplayMember = "id_cust";
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(252, 20);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(259, 21);
            this.comboBox3.TabIndex = 93;
            this.comboBox3.ValueMember = "id_cust";
            // 
            // customersBindingSource
            // 
            this.customersBindingSource.DataMember = "Customers";
            this.customersBindingSource.DataSource = this.inventory_ManagementDataSet;
            // 
            // inventory_ManagementDataSet
            // 
            this.inventory_ManagementDataSet.DataSetName = "Inventory_ManagementDataSet";
            this.inventory_ManagementDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Location = new System.Drawing.Point(252, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(255, 1);
            this.panel1.TabIndex = 92;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label4.Location = new System.Drawing.Point(12, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 23);
            this.label4.TabIndex = 91;
            this.label4.Text = "Customer Id :";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel5.Location = new System.Drawing.Point(252, 274);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(259, 1);
            this.panel5.TabIndex = 89;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel4.Location = new System.Drawing.Point(252, 211);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(259, 1);
            this.panel4.TabIndex = 88;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel2.Location = new System.Drawing.Point(252, 149);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(255, 1);
            this.panel2.TabIndex = 87;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel3.Location = new System.Drawing.Point(252, 94);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(255, 1);
            this.panel3.TabIndex = 86;
            // 
            // ExtbrnSup
            // 
            this.ExtbrnSup.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ExtbrnSup.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ExtbrnSup.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExtbrnSup.ForeColor = System.Drawing.SystemColors.Info;
            this.ExtbrnSup.Location = new System.Drawing.Point(183, 340);
            this.ExtbrnSup.Name = "ExtbrnSup";
            this.ExtbrnSup.Size = new System.Drawing.Size(163, 33);
            this.ExtbrnSup.TabIndex = 85;
            this.ExtbrnSup.Text = "Exit";
            this.ExtbrnSup.UseVisualStyleBackColor = false;
            this.ExtbrnSup.Click += new System.EventHandler(this.ExtbrnSup_Click);
            // 
            // savebtnSup
            // 
            this.savebtnSup.BackColor = System.Drawing.Color.DarkBlue;
            this.savebtnSup.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.savebtnSup.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savebtnSup.ForeColor = System.Drawing.SystemColors.Info;
            this.savebtnSup.Location = new System.Drawing.Point(39, 295);
            this.savebtnSup.Name = "savebtnSup";
            this.savebtnSup.Size = new System.Drawing.Size(436, 39);
            this.savebtnSup.TabIndex = 84;
            this.savebtnSup.Text = "Save";
            this.savebtnSup.UseVisualStyleBackColor = false;
            this.savebtnSup.Click += new System.EventHandler(this.savebtnSup_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label3.Location = new System.Drawing.Point(12, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(198, 23);
            this.label3.TabIndex = 78;
            this.label3.Text = "Customer Last Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label2.Location = new System.Drawing.Point(12, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 23);
            this.label2.TabIndex = 75;
            this.label2.Text = "Customer Name :";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(252, 188);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(259, 24);
            this.textBox1.TabIndex = 77;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.White;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(252, 248);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(259, 24);
            this.textBox4.TabIndex = 81;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.White;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(252, 126);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(259, 24);
            this.textBox2.TabIndex = 79;
            // 
            // textUsername
            // 
            this.textUsername.BackColor = System.Drawing.Color.White;
            this.textUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textUsername.Location = new System.Drawing.Point(252, 71);
            this.textUsername.Multiline = true;
            this.textUsername.Name = "textUsername";
            this.textUsername.Size = new System.Drawing.Size(259, 24);
            this.textUsername.TabIndex = 74;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Location = new System.Drawing.Point(12, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 23);
            this.label1.TabIndex = 76;
            this.label1.Text = "Customer Address:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label5.Location = new System.Drawing.Point(4, 252);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(242, 23);
            this.label5.TabIndex = 80;
            this.label5.Text = "Customer Phone Number:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // customersTableAdapter
            // 
            this.customersTableAdapter.ClearBeforeFill = true;
            // 
            // UpdateCus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 392);
            this.Controls.Add(this.panelUpCus);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "UpdateCus";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdateCus";
            this.Load += new System.EventHandler(this.UpdateCus_Load);
            this.panelUpCus.ResumeLayout(false);
            this.panelUpCus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventory_ManagementDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelUpCus;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button ExtbrnSup;
        private System.Windows.Forms.Button savebtnSup;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textUsername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox3;
        private Inventory_ManagementDataSet inventory_ManagementDataSet;
        private System.Windows.Forms.BindingSource customersBindingSource;
        private Inventory_ManagementDataSetTableAdapters.CustomersTableAdapter customersTableAdapter;
    }
}