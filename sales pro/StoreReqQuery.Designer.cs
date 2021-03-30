namespace sales_pro
{
    partial class StoreReqQuery
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.lastDate = new System.Windows.Forms.DateTimePicker();
            this.FirstDate = new System.Windows.Forms.DateTimePicker();
            this.stuqQueryBtn = new DevComponents.DotNetBar.ButtonX();
            this.STQuerByDateBtn = new DevComponents.DotNetBar.ButtonX();
            this.ReqGrid = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ReqGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.lastDate);
            this.groupPanel1.Controls.Add(this.FirstDate);
            this.groupPanel1.Controls.Add(this.stuqQueryBtn);
            this.groupPanel1.Controls.Add(this.STQuerByDateBtn);
            this.groupPanel1.Controls.Add(this.ReqGrid);
            this.groupPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupPanel1.Location = new System.Drawing.Point(0, 0);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(883, 546);
            // 
            // 
            // 
            this.groupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel1.Style.BackColorGradientAngle = 90;
            this.groupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderBottomWidth = 1;
            this.groupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderLeftWidth = 1;
            this.groupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderRightWidth = 1;
            this.groupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderTopWidth = 1;
            this.groupPanel1.Style.CornerDiameter = 4;
            this.groupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            this.groupPanel1.TabIndex = 0;
            // 
            // lastDate
            // 
            this.lastDate.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.lastDate.Location = new System.Drawing.Point(273, 164);
            this.lastDate.Name = "lastDate";
            this.lastDate.Size = new System.Drawing.Size(200, 36);
            this.lastDate.TabIndex = 4;
            // 
            // FirstDate
            // 
            this.FirstDate.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FirstDate.Location = new System.Drawing.Point(516, 164);
            this.FirstDate.Name = "FirstDate";
            this.FirstDate.Size = new System.Drawing.Size(200, 36);
            this.FirstDate.TabIndex = 3;
            // 
            // stuqQueryBtn
            // 
            this.stuqQueryBtn.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.stuqQueryBtn.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.stuqQueryBtn.Location = new System.Drawing.Point(722, 115);
            this.stuqQueryBtn.Name = "stuqQueryBtn";
            this.stuqQueryBtn.Size = new System.Drawing.Size(146, 34);
            this.stuqQueryBtn.TabIndex = 2;
            this.stuqQueryBtn.Text = "الاستعلام عن طلبات معلقة";
            this.stuqQueryBtn.Click += new System.EventHandler(this.stuqQueryBtn_Click);
            // 
            // STQuerByDateBtn
            // 
            this.STQuerByDateBtn.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.STQuerByDateBtn.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.STQuerByDateBtn.Location = new System.Drawing.Point(722, 166);
            this.STQuerByDateBtn.Name = "STQuerByDateBtn";
            this.STQuerByDateBtn.Size = new System.Drawing.Size(146, 34);
            this.STQuerByDateBtn.TabIndex = 1;
            this.STQuerByDateBtn.Text = "الاستعلام عن طلب خلال قترة";
            // 
            // ReqGrid
            // 
            this.ReqGrid.AllowUserToAddRows = false;
            this.ReqGrid.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.ReqGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ReqGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ReqGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column1,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ReqGrid.DefaultCellStyle = dataGridViewCellStyle1;
            this.ReqGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.ReqGrid.Location = new System.Drawing.Point(9, 216);
            this.ReqGrid.Name = "ReqGrid";
            this.ReqGrid.Size = new System.Drawing.Size(859, 315);
            this.ReqGrid.TabIndex = 0;
            this.ReqGrid.DoubleClick += new System.EventHandler(this.ReqGrid_DoubleClick);
            // 
            // Column2
            // 
            this.Column2.HeaderText = "كود طلب المخزن";
            this.Column2.Name = "Column2";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "تاريخ الطلب";
            this.Column1.Name = "Column1";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "المخزن المورد";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "المستخدم";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "ملاحظات";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "حالة الطلب";
            this.Column6.Name = "Column6";
            // 
            // StoreReqQuery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(883, 546);
            this.Controls.Add(this.groupPanel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StoreReqQuery";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "الاستعلام عن طلبات مخزن";
            this.Load += new System.EventHandler(this.StoreReqQuery_Load);
            this.groupPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ReqGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private System.Windows.Forms.DateTimePicker lastDate;
        private System.Windows.Forms.DateTimePicker FirstDate;
        private DevComponents.DotNetBar.ButtonX stuqQueryBtn;
        private DevComponents.DotNetBar.ButtonX STQuerByDateBtn;
        private DevComponents.DotNetBar.Controls.DataGridViewX ReqGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}