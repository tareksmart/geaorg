namespace sales_pro
{
    partial class CategoryBD
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
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.salesDataSet = new sales_pro.salesDataSet();
            this.categoryTableAdapter = new sales_pro.salesDataSetTableAdapters.CategoryTableAdapter();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.tasn_quer_exp = new DevComponents.DotNetBar.ExpandablePanel();
            this.CategoryCB = new System.Windows.Forms.ComboBox();
            this.CatIdTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.InsertBtn = new DevComponents.DotNetBar.ButtonX();
            this.label3 = new System.Windows.Forms.Label();
            this.UpdateBtn = new DevComponents.DotNetBar.ButtonX();
            this.ClearBtn = new DevComponents.DotNetBar.ButtonX();
            this.CatNotesTB = new System.Windows.Forms.TextBox();
            this.CatNameTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesDataSet)).BeginInit();
            this.groupPanel1.SuspendLayout();
            this.tasn_quer_exp.SuspendLayout();
            this.SuspendLayout();
            // 
            // categoryBindingSource
            // 
            this.categoryBindingSource.DataMember = "Category";
            this.categoryBindingSource.DataSource = this.salesDataSet;
            // 
            // salesDataSet
            // 
            this.salesDataSet.DataSetName = "salesDataSet";
            this.salesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // categoryTableAdapter
            // 
            this.categoryTableAdapter.ClearBeforeFill = true;
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.tasn_quer_exp);
            this.groupPanel1.Controls.Add(this.CatIdTB);
            this.groupPanel1.Controls.Add(this.label2);
            this.groupPanel1.Controls.Add(this.InsertBtn);
            this.groupPanel1.Controls.Add(this.label3);
            this.groupPanel1.Controls.Add(this.UpdateBtn);
            this.groupPanel1.Controls.Add(this.ClearBtn);
            this.groupPanel1.Controls.Add(this.CatNotesTB);
            this.groupPanel1.Controls.Add(this.CatNameTB);
            this.groupPanel1.Controls.Add(this.label1);
            this.groupPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupPanel1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupPanel1.IsShadowEnabled = true;
            this.groupPanel1.Location = new System.Drawing.Point(0, 0);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(928, 557);
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
            this.groupPanel1.TabIndex = 20;
            this.groupPanel1.Text = "اضافة تصنيف";
            this.groupPanel1.Click += new System.EventHandler(this.groupPanel1_Click);
            // 
            // tasn_quer_exp
            // 
            this.tasn_quer_exp.CanvasColor = System.Drawing.SystemColors.Control;
            this.tasn_quer_exp.CollapseDirection = DevComponents.DotNetBar.eCollapseDirection.RightToLeft;
            this.tasn_quer_exp.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.tasn_quer_exp.Controls.Add(this.CategoryCB);
            this.tasn_quer_exp.Expanded = false;
            this.tasn_quer_exp.ExpandedBounds = new System.Drawing.Rectangle(3, 16, 371, 164);
            this.tasn_quer_exp.ExpandOnTitleClick = true;
            this.tasn_quer_exp.Location = new System.Drawing.Point(3, 16);
            this.tasn_quer_exp.Name = "tasn_quer_exp";
            this.tasn_quer_exp.Size = new System.Drawing.Size(30, 164);
            this.tasn_quer_exp.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.tasn_quer_exp.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.tasn_quer_exp.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.tasn_quer_exp.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.tasn_quer_exp.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.tasn_quer_exp.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.tasn_quer_exp.Style.GradientAngle = 90;
            this.tasn_quer_exp.TabIndex = 17;
            this.tasn_quer_exp.TitleStyle.Alignment = System.Drawing.StringAlignment.Center;
            this.tasn_quer_exp.TitleStyle.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.tasn_quer_exp.TitleStyle.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.tasn_quer_exp.TitleStyle.Border = DevComponents.DotNetBar.eBorderType.RaisedInner;
            this.tasn_quer_exp.TitleStyle.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.tasn_quer_exp.TitleStyle.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.tasn_quer_exp.TitleStyle.GradientAngle = 90;
            this.tasn_quer_exp.TitleText = "الاستعلام عن تصنيف";
            // 
            // CategoryCB
            // 
            this.CategoryCB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CategoryCB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CategoryCB.DataSource = this.categoryBindingSource;
            this.CategoryCB.DisplayMember = "CatName";
            this.CategoryCB.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoryCB.FormattingEnabled = true;
            this.CategoryCB.Location = new System.Drawing.Point(38, 74);
            this.CategoryCB.Name = "CategoryCB";
            this.CategoryCB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CategoryCB.Size = new System.Drawing.Size(284, 29);
            this.CategoryCB.TabIndex = 15;
            this.CategoryCB.ValueMember = "CatId";
            this.CategoryCB.SelectedIndexChanged += new System.EventHandler(this.CategoryCBSelectedIndexChanged);
            // 
            // CatIdTB
            // 
            this.CatIdTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.CatIdTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CatIdTB.Enabled = false;
            this.CatIdTB.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CatIdTB.Location = new System.Drawing.Point(236, 123);
            this.CatIdTB.Name = "CatIdTB";
            this.CatIdTB.ReadOnly = true;
            this.CatIdTB.Size = new System.Drawing.Size(457, 29);
            this.CatIdTB.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(713, 254);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 28);
            this.label2.TabIndex = 16;
            this.label2.Text = "ملاحظات";
            // 
            // InsertBtn
            // 
            this.InsertBtn.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.InsertBtn.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.InsertBtn.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InsertBtn.Location = new System.Drawing.Point(569, 344);
            this.InsertBtn.Name = "InsertBtn";
            this.InsertBtn.Size = new System.Drawing.Size(124, 63);
            this.InsertBtn.TabIndex = 12;
            this.InsertBtn.Text = "جديد";
            this.InsertBtn.Click += new System.EventHandler(this.InsertBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(713, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 28);
            this.label3.TabIndex = 19;
            this.label3.Text = "كود التصنيف";
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.UpdateBtn.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.UpdateBtn.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateBtn.Location = new System.Drawing.Point(402, 344);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(124, 63);
            this.UpdateBtn.TabIndex = 13;
            this.UpdateBtn.Text = "تعديل";
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // ClearBtn
            // 
            this.ClearBtn.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.ClearBtn.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.ClearBtn.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearBtn.Location = new System.Drawing.Point(236, 344);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(124, 63);
            this.ClearBtn.TabIndex = 14;
            this.ClearBtn.Text = "مسح";
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // CatNotesTB
            // 
            this.CatNotesTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.CatNotesTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CatNotesTB.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CatNotesTB.Location = new System.Drawing.Point(236, 244);
            this.CatNotesTB.MaxLength = 100;
            this.CatNotesTB.Multiline = true;
            this.CatNotesTB.Name = "CatNotesTB";
            this.CatNotesTB.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.CatNotesTB.Size = new System.Drawing.Size(457, 44);
            this.CatNotesTB.TabIndex = 11;
            this.CatNotesTB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CatNotesTB_KeyDown);
            // 
            // CatNameTB
            // 
            this.CatNameTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.CatNameTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CatNameTB.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CatNameTB.Location = new System.Drawing.Point(236, 180);
            this.CatNameTB.MaxLength = 50;
            this.CatNameTB.Name = "CatNameTB";
            this.CatNameTB.Size = new System.Drawing.Size(457, 35);
            this.CatNameTB.TabIndex = 10;
            this.CatNameTB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CatNameTB_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(713, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 28);
            this.label1.TabIndex = 15;
            this.label1.Text = "التصنيف";
            // 
            // CategoryBD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.groupPanel1);
            this.Name = "CategoryBD";
            this.Size = new System.Drawing.Size(928, 557);
            this.Load += new System.EventHandler(this.CategoryBD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesDataSet)).EndInit();
            this.groupPanel1.ResumeLayout(false);
            this.groupPanel1.PerformLayout();
            this.tasn_quer_exp.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.BindingSource categoryBindingSource;
        public salesDataSet salesDataSet;
        public salesDataSetTableAdapters.CategoryTableAdapter categoryTableAdapter;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private System.Windows.Forms.TextBox CatIdTB;
        private DevComponents.DotNetBar.ExpandablePanel tasn_quer_exp;
        public System.Windows.Forms.ComboBox CategoryCB;
        private System.Windows.Forms.Label label2;
        private DevComponents.DotNetBar.ButtonX InsertBtn;
        private System.Windows.Forms.Label label3;
        private DevComponents.DotNetBar.ButtonX UpdateBtn;
        private DevComponents.DotNetBar.ButtonX ClearBtn;
        private System.Windows.Forms.TextBox CatNotesTB;
        private System.Windows.Forms.TextBox CatNameTB;
        private System.Windows.Forms.Label label1;
    }
}
