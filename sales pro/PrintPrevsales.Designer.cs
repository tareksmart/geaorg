namespace sales_pro
{
    partial class PrintPrevsales
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
            this.agentTableAdapter = new sales_pro.AgentDSTableAdapters.AgentTableAdapter();
            this.BillIdTB = new System.Windows.Forms.TextBox();
            this.QueryBTN = new System.Windows.Forms.Button();
            this.BillNoTB = new System.Windows.Forms.NumericUpDown();
            this.BillCounterRB = new System.Windows.Forms.RadioButton();
            this.ToDateTB = new System.Windows.Forms.DateTimePicker();
            this.FinalBillRB = new System.Windows.Forms.RadioButton();
            this.DateRB = new System.Windows.Forms.RadioButton();
            this.agentDS = new sales_pro.AgentDS();
            this.label13 = new System.Windows.Forms.Label();
            this.SalesBillCRD1 = new sales_pro.SalesBillCRD();
            this.AgentQCB = new System.Windows.Forms.ComboBox();
            this.agentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.OperType = new System.Windows.Forms.ComboBox();
            this.FromDateTB = new System.Windows.Forms.DateTimePicker();
            this.SalesCRV = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.fat_id_rdbtn = new System.Windows.Forms.CheckBox();
            this.AgentCHB = new System.Windows.Forms.CheckBox();
            this.groupPanel2 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BillNoTB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agentDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agentBindingSource)).BeginInit();
            this.groupPanel1.SuspendLayout();
            this.groupPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // agentTableAdapter
            // 
            this.agentTableAdapter.ClearBeforeFill = true;
            // 
            // BillIdTB
            // 
            this.BillIdTB.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BillIdTB.Location = new System.Drawing.Point(91, 9);
            this.BillIdTB.Name = "BillIdTB";
            this.BillIdTB.Size = new System.Drawing.Size(186, 29);
            this.BillIdTB.TabIndex = 60;
            this.BillIdTB.TextChanged += new System.EventHandler(this.BillIdTB_TextChanged);
            // 
            // QueryBTN
            // 
            this.QueryBTN.BackColor = System.Drawing.Color.LightSteelBlue;
            this.QueryBTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.QueryBTN.Location = new System.Drawing.Point(9, 49);
            this.QueryBTN.Name = "QueryBTN";
            this.QueryBTN.Size = new System.Drawing.Size(145, 41);
            this.QueryBTN.TabIndex = 59;
            this.QueryBTN.Text = "عرض";
            this.QueryBTN.UseVisualStyleBackColor = false;
            this.QueryBTN.Click += new System.EventHandler(this.QueryBTN_Click);
            // 
            // BillNoTB
            // 
            this.BillNoTB.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BillNoTB.Location = new System.Drawing.Point(827, 36);
            this.BillNoTB.Name = "BillNoTB";
            this.BillNoTB.Size = new System.Drawing.Size(149, 29);
            this.BillNoTB.TabIndex = 49;
            this.BillNoTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BillCounterRB
            // 
            this.BillCounterRB.AutoSize = true;
            this.BillCounterRB.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BillCounterRB.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BillCounterRB.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BillCounterRB.Location = new System.Drawing.Point(990, 36);
            this.BillCounterRB.Name = "BillCounterRB";
            this.BillCounterRB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BillCounterRB.Size = new System.Drawing.Size(123, 27);
            this.BillCounterRB.TabIndex = 57;
            this.BillCounterRB.Text = "آخرعدد فواتير";
            this.BillCounterRB.UseVisualStyleBackColor = true;
            // 
            // ToDateTB
            // 
            this.ToDateTB.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToDateTB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ToDateTB.Location = new System.Drawing.Point(632, 0);
            this.ToDateTB.Name = "ToDateTB";
            this.ToDateTB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ToDateTB.Size = new System.Drawing.Size(147, 29);
            this.ToDateTB.TabIndex = 56;
            // 
            // FinalBillRB
            // 
            this.FinalBillRB.AutoSize = true;
            this.FinalBillRB.Checked = true;
            this.FinalBillRB.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.FinalBillRB.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FinalBillRB.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FinalBillRB.Location = new System.Drawing.Point(1017, 72);
            this.FinalBillRB.Name = "FinalBillRB";
            this.FinalBillRB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.FinalBillRB.Size = new System.Drawing.Size(96, 27);
            this.FinalBillRB.TabIndex = 55;
            this.FinalBillRB.TabStop = true;
            this.FinalBillRB.Text = "آخرفاتورة";
            this.FinalBillRB.UseVisualStyleBackColor = true;
            // 
            // DateRB
            // 
            this.DateRB.AutoSize = true;
            this.DateRB.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.DateRB.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateRB.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.DateRB.Location = new System.Drawing.Point(971, 1);
            this.DateRB.Name = "DateRB";
            this.DateRB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DateRB.Size = new System.Drawing.Size(142, 27);
            this.DateRB.TabIndex = 54;
            this.DateRB.Text = "تاريخ الفاتورة من";
            this.DateRB.UseVisualStyleBackColor = true;
            // 
            // agentDS
            // 
            this.agentDS.DataSetName = "AgentDS";
            this.agentDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label13.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(986, 14);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(81, 24);
            this.label13.TabIndex = 52;
            this.label13.Text = "نوع العملية";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AgentQCB
            // 
            this.AgentQCB.DataSource = this.agentBindingSource;
            this.AgentQCB.DisplayMember = "AgentName";
            this.AgentQCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AgentQCB.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgentQCB.FormattingEnabled = true;
            this.AgentQCB.Location = new System.Drawing.Point(442, 9);
            this.AgentQCB.Name = "AgentQCB";
            this.AgentQCB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.AgentQCB.Size = new System.Drawing.Size(281, 30);
            this.AgentQCB.TabIndex = 53;
            this.AgentQCB.ValueMember = "AgentId";
            // 
            // agentBindingSource
            // 
            this.agentBindingSource.DataMember = "Agent";
            this.agentBindingSource.DataSource = this.agentDS;
            // 
            // OperType
            // 
            this.OperType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.OperType.Enabled = false;
            this.OperType.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OperType.FormattingEnabled = true;
            this.OperType.Items.AddRange(new object[] {
            "فاتورة بيع",
            "فاتورة مرتجعه"});
            this.OperType.Location = new System.Drawing.Point(841, 11);
            this.OperType.Name = "OperType";
            this.OperType.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.OperType.Size = new System.Drawing.Size(135, 30);
            this.OperType.TabIndex = 51;
            // 
            // FromDateTB
            // 
            this.FromDateTB.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FromDateTB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FromDateTB.Location = new System.Drawing.Point(827, 0);
            this.FromDateTB.Name = "FromDateTB";
            this.FromDateTB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.FromDateTB.Size = new System.Drawing.Size(147, 29);
            this.FromDateTB.TabIndex = 50;
            // 
            // SalesCRV
            // 
            this.SalesCRV.ActiveViewIndex = -1;
            this.SalesCRV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.SalesCRV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SalesCRV.Cursor = System.Windows.Forms.Cursors.Default;
            this.SalesCRV.Location = new System.Drawing.Point(0, 286);
            this.SalesCRV.Name = "SalesCRV";
            this.SalesCRV.ReuseParameterValuesOnRefresh = true;
            this.SalesCRV.Size = new System.Drawing.Size(1152, 396);
            this.SalesCRV.TabIndex = 48;
            this.SalesCRV.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // groupPanel1
            // 
            this.groupPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.fat_id_rdbtn);
            this.groupPanel1.Controls.Add(this.AgentCHB);
            this.groupPanel1.Controls.Add(this.BillIdTB);
            this.groupPanel1.Controls.Add(this.AgentQCB);
            this.groupPanel1.Controls.Add(this.OperType);
            this.groupPanel1.Controls.Add(this.label13);
            this.groupPanel1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupPanel1.Location = new System.Drawing.Point(12, 6);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(1132, 90);
            // 
            // 
            // 
            this.groupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
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
            this.groupPanel1.TabIndex = 63;
            this.groupPanel1.Text = "بيانات اساسية";
            // 
            // fat_id_rdbtn
            // 
            this.fat_id_rdbtn.AutoSize = true;
            this.fat_id_rdbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.fat_id_rdbtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.fat_id_rdbtn.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fat_id_rdbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.fat_id_rdbtn.Location = new System.Drawing.Point(278, 10);
            this.fat_id_rdbtn.Name = "fat_id_rdbtn";
            this.fat_id_rdbtn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.fat_id_rdbtn.Size = new System.Drawing.Size(108, 27);
            this.fat_id_rdbtn.TabIndex = 61;
            this.fat_id_rdbtn.Text = "رقم الفاتورة";
            this.fat_id_rdbtn.UseVisualStyleBackColor = false;
            // 
            // AgentCHB
            // 
            this.AgentCHB.AutoSize = true;
            this.AgentCHB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.AgentCHB.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.AgentCHB.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgentCHB.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AgentCHB.Location = new System.Drawing.Point(745, 11);
            this.AgentCHB.Name = "AgentCHB";
            this.AgentCHB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.AgentCHB.Size = new System.Drawing.Size(72, 27);
            this.AgentCHB.TabIndex = 54;
            this.AgentCHB.Text = "العميل";
            this.AgentCHB.UseVisualStyleBackColor = false;
            // 
            // groupPanel2
            // 
            this.groupPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupPanel2.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel2.Controls.Add(this.button1);
            this.groupPanel2.Controls.Add(this.label1);
            this.groupPanel2.Controls.Add(this.ToDateTB);
            this.groupPanel2.Controls.Add(this.FromDateTB);
            this.groupPanel2.Controls.Add(this.QueryBTN);
            this.groupPanel2.Controls.Add(this.DateRB);
            this.groupPanel2.Controls.Add(this.FinalBillRB);
            this.groupPanel2.Controls.Add(this.BillCounterRB);
            this.groupPanel2.Controls.Add(this.BillNoTB);
            this.groupPanel2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupPanel2.Location = new System.Drawing.Point(12, 97);
            this.groupPanel2.Name = "groupPanel2";
            this.groupPanel2.Size = new System.Drawing.Size(1134, 181);
            // 
            // 
            // 
            this.groupPanel2.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel2.Style.BackColorGradientAngle = 90;
            this.groupPanel2.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel2.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderBottomWidth = 1;
            this.groupPanel2.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel2.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderLeftWidth = 1;
            this.groupPanel2.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderRightWidth = 1;
            this.groupPanel2.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderTopWidth = 1;
            this.groupPanel2.Style.CornerDiameter = 4;
            this.groupPanel2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel2.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel2.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel2.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            this.groupPanel2.TabIndex = 64;
            this.groupPanel2.Text = "فلترة";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(9, 100);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 41);
            this.button1.TabIndex = 64;
            this.button1.Text = "خروج";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(785, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 24);
            this.label1.TabIndex = 63;
            this.label1.Text = "الى";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PrintPrevsales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1152, 682);
            this.Controls.Add(this.groupPanel2);
            this.Controls.Add(this.groupPanel1);
            this.Controls.Add(this.SalesCRV);
            this.Name = "PrintPrevsales";
            this.Text = "طباعة فواتير سابقه";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.PrintPrevsales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BillNoTB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agentDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agentBindingSource)).EndInit();
            this.groupPanel1.ResumeLayout(false);
            this.groupPanel1.PerformLayout();
            this.groupPanel2.ResumeLayout(false);
            this.groupPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private AgentDSTableAdapters.AgentTableAdapter agentTableAdapter;
        private System.Windows.Forms.TextBox BillIdTB;
        private System.Windows.Forms.Button QueryBTN;
        private System.Windows.Forms.NumericUpDown BillNoTB;
        private System.Windows.Forms.RadioButton BillCounterRB;
        private System.Windows.Forms.DateTimePicker ToDateTB;
        private System.Windows.Forms.RadioButton FinalBillRB;
        private System.Windows.Forms.RadioButton DateRB;
        private AgentDS agentDS;
        private System.Windows.Forms.Label label13;
        private SalesBillCRD SalesBillCRD1;
        private System.Windows.Forms.ComboBox AgentQCB;
        private System.Windows.Forms.BindingSource agentBindingSource;
        private System.Windows.Forms.ComboBox OperType;
        private System.Windows.Forms.DateTimePicker FromDateTB;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer SalesCRV;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel2;
        private System.Windows.Forms.CheckBox AgentCHB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox fat_id_rdbtn;
    }
}