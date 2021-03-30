namespace sales_pro
{
    partial class query_stuck_bill_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(query_stuck_bill_form));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.finish_all_btn = new DevComponents.DotNetBar.ButtonX();
            this.finish_selected_btn = new DevComponents.DotNetBar.ButtonX();
            this.query_btn = new DevComponents.DotNetBar.ButtonX();
            this.q_grid = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.last_stuck_num = new System.Windows.Forms.NumericUpDown();
            this.groupPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.q_grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.last_stuck_num)).BeginInit();
            this.SuspendLayout();
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.last_stuck_num);
            this.groupPanel1.Controls.Add(this.finish_all_btn);
            this.groupPanel1.Controls.Add(this.finish_selected_btn);
            this.groupPanel1.Controls.Add(this.query_btn);
            this.groupPanel1.Controls.Add(this.q_grid);
            this.groupPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupPanel1.Location = new System.Drawing.Point(0, 0);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(517, 349);
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
            this.groupPanel1.Click += new System.EventHandler(this.groupPanel1_Click);
            // 
            // finish_all_btn
            // 
            this.finish_all_btn.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.finish_all_btn.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.finish_all_btn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finish_all_btn.Location = new System.Drawing.Point(4, 45);
            this.finish_all_btn.Name = "finish_all_btn";
            this.finish_all_btn.Size = new System.Drawing.Size(148, 34);
            this.finish_all_btn.TabIndex = 3;
            this.finish_all_btn.Text = "انهاء الكل";
            this.finish_all_btn.Click += new System.EventHandler(this.finish_all_btn_Click);
            // 
            // finish_selected_btn
            // 
            this.finish_selected_btn.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.finish_selected_btn.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.finish_selected_btn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finish_selected_btn.Location = new System.Drawing.Point(4, 5);
            this.finish_selected_btn.Name = "finish_selected_btn";
            this.finish_selected_btn.Size = new System.Drawing.Size(148, 34);
            this.finish_selected_btn.TabIndex = 2;
            this.finish_selected_btn.Text = "انهاء المحدد";
            this.finish_selected_btn.Click += new System.EventHandler(this.finish_selected_btn_Click);
            // 
            // query_btn
            // 
            this.query_btn.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.query_btn.AutoSize = true;
            this.query_btn.BackColor = System.Drawing.Color.Transparent;
            this.query_btn.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue;
            this.query_btn.Image = ((System.Drawing.Image)(resources.GetObject("query_btn.Image")));
            this.query_btn.ImageFixedSize = new System.Drawing.Size(100, 50);
            this.query_btn.Location = new System.Drawing.Point(382, 9);
            this.query_btn.Name = "query_btn";
            this.query_btn.Shape = new DevComponents.DotNetBar.EllipticalShapeDescriptor();
            this.query_btn.Size = new System.Drawing.Size(109, 70);
            this.query_btn.TabIndex = 1;
            this.query_btn.Tooltip = "استعلام عن الفواتير المعلقه";
            this.query_btn.Click += new System.EventHandler(this.query_btn_Click);
            // 
            // q_grid
            // 
            this.q_grid.AllowUserToAddRows = false;
            this.q_grid.AllowUserToDeleteRows = false;
            this.q_grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.q_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.q_grid.DefaultCellStyle = dataGridViewCellStyle1;
            this.q_grid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.q_grid.Location = new System.Drawing.Point(3, 94);
            this.q_grid.Name = "q_grid";
            this.q_grid.ReadOnly = true;
            this.q_grid.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.q_grid.Size = new System.Drawing.Size(505, 246);
            this.q_grid.TabIndex = 0;
            this.q_grid.DoubleClick += new System.EventHandler(this.q_grid_DoubleClick);
            // 
            // last_stuck_num
            // 
            this.last_stuck_num.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.last_stuck_num.Location = new System.Drawing.Point(295, 28);
            this.last_stuck_num.Name = "last_stuck_num";
            this.last_stuck_num.Size = new System.Drawing.Size(75, 35);
            this.last_stuck_num.TabIndex = 4;
            this.last_stuck_num.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.last_stuck_num.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // query_stuck_bill_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 349);
            this.Controls.Add(this.groupPanel1);
            this.Name = "query_stuck_bill_form";
            this.Text = "الاستعلام عن فاتورة معلقة";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.query_stuck_bill_form_FormClosing);
            this.Load += new System.EventHandler(this.query_stuck_bill_form_Load);
            this.groupPanel1.ResumeLayout(false);
            this.groupPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.q_grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.last_stuck_num)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.ButtonX query_btn;
        private DevComponents.DotNetBar.Controls.DataGridViewX q_grid;
        private DevComponents.DotNetBar.ButtonX finish_all_btn;
        private DevComponents.DotNetBar.ButtonX finish_selected_btn;
        private System.Windows.Forms.NumericUpDown last_stuck_num;
    }
}