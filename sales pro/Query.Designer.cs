namespace sales_pro
{
    partial class Query
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.SearchTB = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.dataGridViewX1 = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.AllCHB = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.ItemsCHB = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.BillCHB = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.SalesCHB = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.dataGridViewX2 = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.dataGridViewX3 = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.dataGridViewX4 = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.AgentCHB = new DevComponents.DotNetBar.Controls.CheckBoxX();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX4)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchTB
            // 
            // 
            // 
            // 
            this.SearchTB.Border.Class = "TextBoxBorder";
            this.SearchTB.Location = new System.Drawing.Point(374, 130);
            this.SearchTB.Name = "SearchTB";
            this.SearchTB.Size = new System.Drawing.Size(260, 20);
            this.SearchTB.TabIndex = 0;
            this.SearchTB.TextChanged += new System.EventHandler(this.SearchTB_TextChanged);
            // 
            // labelX1
            // 
            this.labelX1.Location = new System.Drawing.Point(685, 130);
            this.labelX1.Name = "labelX1";
            this.labelX1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX1.SingleLineColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelX1.Size = new System.Drawing.Size(75, 23);
            this.labelX1.TabIndex = 1;
            this.labelX1.Text = "إستعلام";
            // 
            // dataGridViewX1
            // 
            this.dataGridViewX1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewX1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewX1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dataGridViewX1.Location = new System.Drawing.Point(24, 260);
            this.dataGridViewX1.Name = "dataGridViewX1";
            this.dataGridViewX1.Size = new System.Drawing.Size(296, 184);
            this.dataGridViewX1.TabIndex = 2;
            // 
            // AllCHB
            // 
            this.AllCHB.Location = new System.Drawing.Point(579, 184);
            this.AllCHB.Name = "AllCHB";
            this.AllCHB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.AllCHB.Size = new System.Drawing.Size(75, 23);
            this.AllCHB.TabIndex = 3;
            this.AllCHB.Text = "الكل";
            this.AllCHB.CheckedChanged += new System.EventHandler(this.AllCHB_CheckedChanged);
            // 
            // ItemsCHB
            // 
            this.ItemsCHB.Location = new System.Drawing.Point(498, 184);
            this.ItemsCHB.Name = "ItemsCHB";
            this.ItemsCHB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ItemsCHB.Size = new System.Drawing.Size(75, 23);
            this.ItemsCHB.TabIndex = 4;
            this.ItemsCHB.Text = "الأصناف";
            this.ItemsCHB.CheckedChanged += new System.EventHandler(this.ItemsCHB_CheckedChanged);
            // 
            // BillCHB
            // 
            this.BillCHB.Location = new System.Drawing.Point(417, 184);
            this.BillCHB.Name = "BillCHB";
            this.BillCHB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BillCHB.Size = new System.Drawing.Size(75, 23);
            this.BillCHB.TabIndex = 5;
            this.BillCHB.Text = "الفواتير";
            this.BillCHB.CheckedChanged += new System.EventHandler(this.BillCHB_CheckedChanged);
            // 
            // SalesCHB
            // 
            this.SalesCHB.Location = new System.Drawing.Point(336, 184);
            this.SalesCHB.Name = "SalesCHB";
            this.SalesCHB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.SalesCHB.Size = new System.Drawing.Size(75, 23);
            this.SalesCHB.TabIndex = 6;
            this.SalesCHB.Text = "المبيعات";
            this.SalesCHB.CheckedChanged += new System.EventHandler(this.SalesCHB_CheckedChanged);
            // 
            // dataGridViewX2
            // 
            this.dataGridViewX2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewX2.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewX2.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dataGridViewX2.Location = new System.Drawing.Point(326, 260);
            this.dataGridViewX2.Name = "dataGridViewX2";
            this.dataGridViewX2.Size = new System.Drawing.Size(282, 184);
            this.dataGridViewX2.TabIndex = 7;
            // 
            // dataGridViewX3
            // 
            this.dataGridViewX3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewX3.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewX3.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dataGridViewX3.Location = new System.Drawing.Point(614, 260);
            this.dataGridViewX3.Name = "dataGridViewX3";
            this.dataGridViewX3.Size = new System.Drawing.Size(277, 184);
            this.dataGridViewX3.TabIndex = 8;
            // 
            // labelX2
            // 
            this.labelX2.Location = new System.Drawing.Point(676, 184);
            this.labelX2.Name = "labelX2";
            this.labelX2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX2.SingleLineColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelX2.Size = new System.Drawing.Size(75, 23);
            this.labelX2.TabIndex = 9;
            this.labelX2.Text = "البحث عن";
            // 
            // dataGridViewX4
            // 
            this.dataGridViewX4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewX4.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewX4.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dataGridViewX4.Location = new System.Drawing.Point(897, 260);
            this.dataGridViewX4.Name = "dataGridViewX4";
            this.dataGridViewX4.Size = new System.Drawing.Size(277, 184);
            this.dataGridViewX4.TabIndex = 10;
            // 
            // AgentCHB
            // 
            this.AgentCHB.Location = new System.Drawing.Point(245, 184);
            this.AgentCHB.Name = "AgentCHB";
            this.AgentCHB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.AgentCHB.Size = new System.Drawing.Size(98, 23);
            this.AgentCHB.TabIndex = 11;
            this.AgentCHB.Text = "عميل او مورد";
            this.AgentCHB.CheckedChanged += new System.EventHandler(this.AgentCHB_CheckedChanged);
            // 
            // Query
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.Controls.Add(this.AgentCHB);
            this.Controls.Add(this.dataGridViewX4);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.dataGridViewX3);
            this.Controls.Add(this.dataGridViewX2);
            this.Controls.Add(this.SalesCHB);
            this.Controls.Add(this.BillCHB);
            this.Controls.Add(this.ItemsCHB);
            this.Controls.Add(this.AllCHB);
            this.Controls.Add(this.dataGridViewX1);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.SearchTB);
            this.Name = "Query";
            this.Size = new System.Drawing.Size(1192, 626);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.TextBoxX SearchTB;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.DataGridViewX dataGridViewX1;
        private DevComponents.DotNetBar.Controls.CheckBoxX AllCHB;
        private DevComponents.DotNetBar.Controls.CheckBoxX ItemsCHB;
        private DevComponents.DotNetBar.Controls.CheckBoxX BillCHB;
        private DevComponents.DotNetBar.Controls.CheckBoxX SalesCHB;
        private DevComponents.DotNetBar.Controls.DataGridViewX dataGridViewX2;
        private DevComponents.DotNetBar.Controls.DataGridViewX dataGridViewX3;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.DataGridViewX dataGridViewX4;
        private DevComponents.DotNetBar.Controls.CheckBoxX AgentCHB;
    }
}
