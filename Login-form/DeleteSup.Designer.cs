namespace Login_form
{
    partial class DeleteSup
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.savebtn = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.suppliersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inventory_ManagementDataSet12 = new Login_form.Inventory_ManagementDataSet12();
            this.panel14 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.suppliersTableAdapter = new Login_form.Inventory_ManagementDataSet12TableAdapters.SuppliersTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.suppliersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventory_ManagementDataSet12)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.savebtn);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.panel14);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(426, 114);
            this.panel1.TabIndex = 0;
            // 
            // savebtn
            // 
            this.savebtn.BackColor = System.Drawing.Color.DarkBlue;
            this.savebtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.savebtn.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savebtn.ForeColor = System.Drawing.SystemColors.Info;
            this.savebtn.Location = new System.Drawing.Point(37, 58);
            this.savebtn.Name = "savebtn";
            this.savebtn.Size = new System.Drawing.Size(356, 35);
            this.savebtn.TabIndex = 116;
            this.savebtn.Text = "Delete";
            this.savebtn.UseVisualStyleBackColor = false;
            this.savebtn.Click += new System.EventHandler(this.savebtn_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.suppliersBindingSource;
            this.comboBox1.DisplayMember = "id_supplier";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(152, 20);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(259, 21);
            this.comboBox1.TabIndex = 115;
            this.comboBox1.ValueMember = "id_supplier";
            // 
            // suppliersBindingSource
            // 
            this.suppliersBindingSource.DataMember = "Suppliers";
            this.suppliersBindingSource.DataSource = this.inventory_ManagementDataSet12;
            // 
            // inventory_ManagementDataSet12
            // 
            this.inventory_ManagementDataSet12.DataSetName = "Inventory_ManagementDataSet12";
            this.inventory_ManagementDataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel14.Location = new System.Drawing.Point(152, 42);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(259, 1);
            this.panel14.TabIndex = 114;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label8.Location = new System.Drawing.Point(15, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 23);
            this.label8.TabIndex = 113;
            this.label8.Text = "Id Supplier :";
            // 
            // suppliersTableAdapter
            // 
            this.suppliersTableAdapter.ClearBeforeFill = true;
            // 
            // DeleteSup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(426, 114);
            this.Controls.Add(this.panel1);
            this.Name = "DeleteSup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DeleteSup";
            this.Load += new System.EventHandler(this.DeleteSup_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.suppliersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventory_ManagementDataSet12)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Label label8;
        private Inventory_ManagementDataSet12 inventory_ManagementDataSet12;
        private System.Windows.Forms.BindingSource suppliersBindingSource;
        private Inventory_ManagementDataSet12TableAdapters.SuppliersTableAdapter suppliersTableAdapter;
        private System.Windows.Forms.Button savebtn;
    }
}