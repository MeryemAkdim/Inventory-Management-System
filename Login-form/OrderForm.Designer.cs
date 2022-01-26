namespace Login_form
{
    partial class OrderForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Order_panel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            this.dataGridViewOrd = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.UpdatbtnOrder = new System.Windows.Forms.Button();
            this.DeletebtnOrder = new System.Windows.Forms.Button();
            this.addbtnOrder = new System.Windows.Forms.Button();
            this.iconPictureBox3 = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBox4 = new FontAwesome.Sharp.IconPictureBox();
            this.Order_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // Order_panel
            // 
            this.Order_panel.BackColor = System.Drawing.Color.White;
            this.Order_panel.Controls.Add(this.iconPictureBox4);
            this.Order_panel.Controls.Add(this.iconPictureBox3);
            this.Order_panel.Controls.Add(this.label1);
            this.Order_panel.Controls.Add(this.iconPictureBox2);
            this.Order_panel.Controls.Add(this.dataGridViewOrd);
            this.Order_panel.Controls.Add(this.panel4);
            this.Order_panel.Controls.Add(this.textBox3);
            this.Order_panel.Controls.Add(this.iconPictureBox1);
            this.Order_panel.Controls.Add(this.UpdatbtnOrder);
            this.Order_panel.Controls.Add(this.DeletebtnOrder);
            this.Order_panel.Controls.Add(this.addbtnOrder);
            this.Order_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Order_panel.Location = new System.Drawing.Point(0, 0);
            this.Order_panel.Name = "Order_panel";
            this.Order_panel.Size = new System.Drawing.Size(847, 519);
            this.Order_panel.TabIndex = 0;
            this.Order_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.Order_panel_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 18);
            this.label1.TabIndex = 98;
            this.label1.Text = "Search Order :";
            // 
            // iconPictureBox2
            // 
            this.iconPictureBox2.BackColor = System.Drawing.Color.MidnightBlue;
            this.iconPictureBox2.ForeColor = System.Drawing.Color.Coral;
            this.iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.iconPictureBox2.IconColor = System.Drawing.Color.Coral;
            this.iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox2.Location = new System.Drawing.Point(92, 428);
            this.iconPictureBox2.Name = "iconPictureBox2";
            this.iconPictureBox2.Size = new System.Drawing.Size(32, 32);
            this.iconPictureBox2.TabIndex = 97;
            this.iconPictureBox2.TabStop = false;
            // 
            // dataGridViewOrd
            // 
            this.dataGridViewOrd.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewOrd.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewOrd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewOrd.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewOrd.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(87)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewOrd.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewOrd.ColumnHeadersHeight = 40;
            this.dataGridViewOrd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewOrd.EnableHeadersVisualStyles = false;
            this.dataGridViewOrd.GridColor = System.Drawing.Color.RoyalBlue;
            this.dataGridViewOrd.Location = new System.Drawing.Point(3, 89);
            this.dataGridViewOrd.Name = "dataGridViewOrd";
            this.dataGridViewOrd.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewOrd.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewOrd.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewOrd.Size = new System.Drawing.Size(843, 248);
            this.dataGridViewOrd.TabIndex = 96;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel4.Location = new System.Drawing.Point(23, 52);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(751, 1);
            this.panel4.TabIndex = 91;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.White;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(23, 29);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(751, 24);
            this.textBox3.TabIndex = 90;
            this.textBox3.Tag = "";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.White;
            this.iconPictureBox1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.iconPictureBox1.IconColor = System.Drawing.Color.MidnightBlue;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.Location = new System.Drawing.Point(802, 21);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(32, 32);
            this.iconPictureBox1.TabIndex = 36;
            this.iconPictureBox1.TabStop = false;
            // 
            // UpdatbtnOrder
            // 
            this.UpdatbtnOrder.BackColor = System.Drawing.Color.MidnightBlue;
            this.UpdatbtnOrder.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdatbtnOrder.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.UpdatbtnOrder.Location = new System.Drawing.Point(338, 416);
            this.UpdatbtnOrder.Name = "UpdatbtnOrder";
            this.UpdatbtnOrder.Size = new System.Drawing.Size(150, 53);
            this.UpdatbtnOrder.TabIndex = 34;
            this.UpdatbtnOrder.Text = "Update";
            this.UpdatbtnOrder.UseVisualStyleBackColor = false;
            this.UpdatbtnOrder.Click += new System.EventHandler(this.UpdatbtnOrder_Click);
            // 
            // DeletebtnOrder
            // 
            this.DeletebtnOrder.BackColor = System.Drawing.Color.MidnightBlue;
            this.DeletebtnOrder.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeletebtnOrder.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.DeletebtnOrder.Location = new System.Drawing.Point(622, 416);
            this.DeletebtnOrder.Name = "DeletebtnOrder";
            this.DeletebtnOrder.Size = new System.Drawing.Size(143, 53);
            this.DeletebtnOrder.TabIndex = 33;
            this.DeletebtnOrder.Text = "Delete";
            this.DeletebtnOrder.UseVisualStyleBackColor = false;
            this.DeletebtnOrder.Click += new System.EventHandler(this.DeletebtnOrder_Click);
            // 
            // addbtnOrder
            // 
            this.addbtnOrder.BackColor = System.Drawing.Color.MidnightBlue;
            this.addbtnOrder.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addbtnOrder.ForeColor = System.Drawing.Color.White;
            this.addbtnOrder.Location = new System.Drawing.Point(79, 416);
            this.addbtnOrder.Name = "addbtnOrder";
            this.addbtnOrder.Size = new System.Drawing.Size(143, 53);
            this.addbtnOrder.TabIndex = 31;
            this.addbtnOrder.Text = "Add";
            this.addbtnOrder.UseVisualStyleBackColor = false;
            this.addbtnOrder.Click += new System.EventHandler(this.addbtnOrder_Click);
            // 
            // iconPictureBox3
            // 
            this.iconPictureBox3.BackColor = System.Drawing.Color.MidnightBlue;
            this.iconPictureBox3.ForeColor = System.Drawing.Color.Coral;
            this.iconPictureBox3.IconChar = FontAwesome.Sharp.IconChar.PenAlt;
            this.iconPictureBox3.IconColor = System.Drawing.Color.Coral;
            this.iconPictureBox3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox3.Location = new System.Drawing.Point(349, 428);
            this.iconPictureBox3.Name = "iconPictureBox3";
            this.iconPictureBox3.Size = new System.Drawing.Size(36, 32);
            this.iconPictureBox3.TabIndex = 99;
            this.iconPictureBox3.TabStop = false;
            // 
            // iconPictureBox4
            // 
            this.iconPictureBox4.BackColor = System.Drawing.Color.MidnightBlue;
            this.iconPictureBox4.ForeColor = System.Drawing.Color.Coral;
            this.iconPictureBox4.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.iconPictureBox4.IconColor = System.Drawing.Color.Coral;
            this.iconPictureBox4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox4.Location = new System.Drawing.Point(634, 428);
            this.iconPictureBox4.Name = "iconPictureBox4";
            this.iconPictureBox4.Size = new System.Drawing.Size(32, 32);
            this.iconPictureBox4.TabIndex = 100;
            this.iconPictureBox4.TabStop = false;
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 519);
            this.Controls.Add(this.Order_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OrderForm";
            this.Text = "OrderForm";
            this.Load += new System.EventHandler(this.OrderForm_Load);
            this.Order_panel.ResumeLayout(false);
            this.Order_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel Order_panel;
        private System.Windows.Forms.DataGridView dataGridViewOrd;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox textBox3;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Button UpdatbtnOrder;
        private System.Windows.Forms.Button DeletebtnOrder;
        private System.Windows.Forms.Button addbtnOrder;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox4;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox3;
    }
}