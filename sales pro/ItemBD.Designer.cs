namespace sales_pro
{
    partial class ItemBD
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.CatIdCB = new System.Windows.Forms.ComboBox();
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.salesDataSet = new sales_pro.salesDataSet();
            this.KatPriceTB = new System.Windows.Forms.NumericUpDown();
            this.GomlaPriceTB = new System.Windows.Forms.NumericUpDown();
            this.PurchPriceTB = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.expandablePanel1 = new DevComponents.DotNetBar.ExpandablePanel();
            this.ItemIdQTB = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.ItemCB = new System.Windows.Forms.ComboBox();
            this.itemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itemsTADS = new sales_pro.ItemsTADS();
            this.label2 = new System.Windows.Forms.Label();
            this.CatCB = new System.Windows.Forms.ComboBox();
            this.categoryBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.itemDS1 = new sales_pro.ItemDS1();
            this.itemDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ItemClear = new DevComponents.DotNetBar.ButtonX();
            this.ItemUpdateBtn = new DevComponents.DotNetBar.ButtonX();
            this.ItemInsertBtn = new DevComponents.DotNetBar.ButtonX();
            this.label9 = new System.Windows.Forms.Label();
            this.ItemNoteTB = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ItemModelTB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ItemNameTB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ItemIdTB = new System.Windows.Forms.TextBox();
            this.categoryTableAdapter = new sales_pro.salesDataSetTableAdapters.CategoryTableAdapter();
            this.itemDetailsTableAdapter = new sales_pro.ItemDS1TableAdapters.ItemDetailsTableAdapter();
            this.salesDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itemsTableAdapter = new sales_pro.ItemsTADSTableAdapters.ItemsTableAdapter();
            this.label3 = new System.Windows.Forms.Label();
            this.ItemBarCodeTB = new System.Windows.Forms.TextBox();
            this.HideCHB = new System.Windows.Forms.CheckBox();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.partener_cmbx = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.add_com_btn = new DevComponents.DotNetBar.ButtonX();
            this.update_expire_date_exp = new DevComponents.DotNetBar.ExpandablePanel();
            this.exit_btn = new DevComponents.DotNetBar.ButtonX();
            this.update_btn = new DevComponents.DotNetBar.ButtonX();
            this.expire_up_date = new System.Windows.Forms.DateTimePicker();
            this.label23 = new System.Windows.Forms.Label();
            this.expire_item_grid = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.label25 = new System.Windows.Forms.Label();
            this.item_sav_date = new System.Windows.Forms.DateTimePicker();
            this.label15 = new System.Windows.Forms.Label();
            this.expire_date = new System.Windows.Forms.DateTimePicker();
            this.company_cmbx = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.sanf_store_num = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.grid_tooltip = new System.Windows.Forms.ToolTip(this.components);
            this.tableAdapterManager1 = new sales_pro.AgentDSTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KatPriceTB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GomlaPriceTB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PurchPriceTB)).BeginInit();
            this.expandablePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsTADS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemDS1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesDataSetBindingSource)).BeginInit();
            this.groupPanel1.SuspendLayout();
            this.update_expire_date_exp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.expire_item_grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sanf_store_num)).BeginInit();
            this.SuspendLayout();
            // 
            // CatIdCB
            // 
            this.CatIdCB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CatIdCB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CatIdCB.DataSource = this.categoryBindingSource;
            this.CatIdCB.DisplayMember = "CatName";
            this.CatIdCB.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CatIdCB.FormattingEnabled = true;
            this.CatIdCB.Location = new System.Drawing.Point(388, 214);
            this.CatIdCB.Name = "CatIdCB";
            this.CatIdCB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CatIdCB.Size = new System.Drawing.Size(375, 35);
            this.CatIdCB.TabIndex = 62;
            this.CatIdCB.ValueMember = "CatId";
            this.CatIdCB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CatIdCB_KeyDown);
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
            // KatPriceTB
            // 
            this.KatPriceTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.KatPriceTB.DecimalPlaces = 2;
            this.KatPriceTB.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KatPriceTB.Location = new System.Drawing.Point(57, 122);
            this.KatPriceTB.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.KatPriceTB.Name = "KatPriceTB";
            this.KatPriceTB.Size = new System.Drawing.Size(155, 35);
            this.KatPriceTB.TabIndex = 56;
            this.KatPriceTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.KatPriceTB.Visible = false;
            this.KatPriceTB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GomlaPriceTB_KeyDown);
            // 
            // GomlaPriceTB
            // 
            this.GomlaPriceTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.GomlaPriceTB.DecimalPlaces = 2;
            this.GomlaPriceTB.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GomlaPriceTB.Location = new System.Drawing.Point(57, 171);
            this.GomlaPriceTB.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.GomlaPriceTB.Name = "GomlaPriceTB";
            this.GomlaPriceTB.Size = new System.Drawing.Size(155, 35);
            this.GomlaPriceTB.TabIndex = 57;
            this.GomlaPriceTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.GomlaPriceTB.Visible = false;
            this.GomlaPriceTB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GomlaPriceTB_KeyDown);
            // 
            // PurchPriceTB
            // 
            this.PurchPriceTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.PurchPriceTB.DecimalPlaces = 2;
            this.PurchPriceTB.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PurchPriceTB.Location = new System.Drawing.Point(57, 71);
            this.PurchPriceTB.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.PurchPriceTB.Name = "PurchPriceTB";
            this.PurchPriceTB.Size = new System.Drawing.Size(155, 35);
            this.PurchPriceTB.TabIndex = 55;
            this.PurchPriceTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PurchPriceTB.Visible = false;
            this.PurchPriceTB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GomlaPriceTB_KeyDown);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label13.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(218, 125);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(102, 28);
            this.label13.TabIndex = 48;
            this.label13.Text = "سعر العميل";
            this.label13.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label12.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(218, 174);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(158, 28);
            this.label12.TabIndex = 47;
            this.label12.Text = "سعر بيع المستهلك";
            this.label12.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(218, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 28);
            this.label7.TabIndex = 46;
            this.label7.Text = "السعر التجارى";
            this.label7.Visible = false;
            // 
            // expandablePanel1
            // 
            this.expandablePanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.expandablePanel1.CollapseDirection = DevComponents.DotNetBar.eCollapseDirection.RightToLeft;
            this.expandablePanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.expandablePanel1.Controls.Add(this.ItemIdQTB);
            this.expandablePanel1.Controls.Add(this.label10);
            this.expandablePanel1.Controls.Add(this.ItemCB);
            this.expandablePanel1.Controls.Add(this.label2);
            this.expandablePanel1.Controls.Add(this.CatCB);
            this.expandablePanel1.Controls.Add(this.label1);
            this.expandablePanel1.Expanded = false;
            this.expandablePanel1.ExpandedBounds = new System.Drawing.Rectangle(12, 3, 333, 204);
            this.expandablePanel1.ExpandOnTitleClick = true;
            this.expandablePanel1.Location = new System.Drawing.Point(12, 3);
            this.expandablePanel1.Name = "expandablePanel1";
            this.expandablePanel1.Size = new System.Drawing.Size(30, 204);
            this.expandablePanel1.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.expandablePanel1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.expandablePanel1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.expandablePanel1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.expandablePanel1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.expandablePanel1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.expandablePanel1.Style.GradientAngle = 90;
            this.expandablePanel1.TabIndex = 45;
            this.expandablePanel1.TitleStyle.Alignment = System.Drawing.StringAlignment.Center;
            this.expandablePanel1.TitleStyle.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.expandablePanel1.TitleStyle.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.expandablePanel1.TitleStyle.Border = DevComponents.DotNetBar.eBorderType.RaisedInner;
            this.expandablePanel1.TitleStyle.BorderColor.Color = System.Drawing.Color.Red;
            this.expandablePanel1.TitleStyle.BorderDashStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
            this.expandablePanel1.TitleStyle.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.expandablePanel1.TitleStyle.GradientAngle = 90;
            this.expandablePanel1.TitleText = "الاستعلام عن صنف";
            // 
            // ItemIdQTB
            // 
            this.ItemIdQTB.Location = new System.Drawing.Point(8, 65);
            this.ItemIdQTB.MaxLength = 13;
            this.ItemIdQTB.Name = "ItemIdQTB";
            this.ItemIdQTB.Size = new System.Drawing.Size(244, 29);
            this.ItemIdQTB.TabIndex = 63;
            this.ItemIdQTB.TextChanged += new System.EventHandler(this.ItemIdQTB_TextChanged);
            this.ItemIdQTB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ItemIdQTB_KeyDown);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label10.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(261, 69);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 21);
            this.label10.TabIndex = 58;
            this.label10.Text = "كودالصنف";
            // 
            // ItemCB
            // 
            this.ItemCB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ItemCB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ItemCB.DataSource = this.itemsBindingSource;
            this.ItemCB.DisplayMember = "ItemName";
            this.ItemCB.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemCB.FormattingEnabled = true;
            this.ItemCB.Location = new System.Drawing.Point(8, 159);
            this.ItemCB.Name = "ItemCB";
            this.ItemCB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ItemCB.Size = new System.Drawing.Size(244, 29);
            this.ItemCB.TabIndex = 62;
            this.ItemCB.ValueMember = "ItemId";
            this.ItemCB.SelectedIndexChanged += new System.EventHandler(this.ItemCB_SelectedIndexChanged);
            // 
            // itemsBindingSource
            // 
            this.itemsBindingSource.DataMember = "Items";
            this.itemsBindingSource.DataSource = this.itemsTADS;
            // 
            // itemsTADS
            // 
            this.itemsTADS.DataSetName = "ItemsTADS";
            this.itemsTADS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(261, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 24);
            this.label2.TabIndex = 55;
            this.label2.Text = "الأصناف";
            // 
            // CatCB
            // 
            this.CatCB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CatCB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CatCB.DataSource = this.categoryBindingSource1;
            this.CatCB.DisplayMember = "CatName";
            this.CatCB.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CatCB.FormattingEnabled = true;
            this.CatCB.Location = new System.Drawing.Point(8, 108);
            this.CatCB.Name = "CatCB";
            this.CatCB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CatCB.Size = new System.Drawing.Size(244, 29);
            this.CatCB.TabIndex = 61;
            this.CatCB.ValueMember = "CatId";
            this.CatCB.SelectedIndexChanged += new System.EventHandler(this.CatCB_SelectedIndexChanged);
            this.CatCB.SelectedValueChanged += new System.EventHandler(this.CatCB_SelectedIndexChanged);
            // 
            // categoryBindingSource1
            // 
            this.categoryBindingSource1.DataMember = "Category";
            this.categoryBindingSource1.DataSource = this.salesDataSet;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(261, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 24);
            this.label1.TabIndex = 53;
            this.label1.Text = "التصنيف";
            // 
            // itemDS1
            // 
            this.itemDS1.DataSetName = "ItemDS1";
            this.itemDS1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // itemDetailsBindingSource
            // 
            this.itemDetailsBindingSource.DataMember = "ItemDetails";
            this.itemDetailsBindingSource.DataSource = this.itemDS1;
            // 
            // ItemClear
            // 
            this.ItemClear.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.ItemClear.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ItemClear.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.ItemClear.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemClear.Location = new System.Drawing.Point(243, 498);
            this.ItemClear.Name = "ItemClear";
            this.ItemClear.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(7);
            this.ItemClear.Size = new System.Drawing.Size(137, 70);
            this.ItemClear.TabIndex = 68;
            this.ItemClear.Text = "مسح";
            this.ItemClear.Tooltip = "لمسح البيانات من الشاشة";
            this.ItemClear.Click += new System.EventHandler(this.ItemClear_Click);
            // 
            // ItemUpdateBtn
            // 
            this.ItemUpdateBtn.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.ItemUpdateBtn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ItemUpdateBtn.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.ItemUpdateBtn.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemUpdateBtn.Location = new System.Drawing.Point(410, 498);
            this.ItemUpdateBtn.Name = "ItemUpdateBtn";
            this.ItemUpdateBtn.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(7);
            this.ItemUpdateBtn.Size = new System.Drawing.Size(137, 70);
            this.ItemUpdateBtn.TabIndex = 64;
            this.ItemUpdateBtn.Text = "تعديل";
            this.ItemUpdateBtn.Click += new System.EventHandler(this.ItemUpdateBtn_Click);
            // 
            // ItemInsertBtn
            // 
            this.ItemInsertBtn.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.ItemInsertBtn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ItemInsertBtn.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.ItemInsertBtn.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemInsertBtn.Location = new System.Drawing.Point(576, 497);
            this.ItemInsertBtn.Name = "ItemInsertBtn";
            this.ItemInsertBtn.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(7);
            this.ItemInsertBtn.Size = new System.Drawing.Size(137, 70);
            this.ItemInsertBtn.TabIndex = 63;
            this.ItemInsertBtn.Text = "جديد";
            this.ItemInsertBtn.Click += new System.EventHandler(this.ItemInsertBtn_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(767, 448);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 28);
            this.label9.TabIndex = 41;
            this.label9.Text = "ملاحظات";
            // 
            // ItemNoteTB
            // 
            this.ItemNoteTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ItemNoteTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ItemNoteTB.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemNoteTB.Location = new System.Drawing.Point(384, 444);
            this.ItemNoteTB.MaxLength = 90;
            this.ItemNoteTB.Multiline = true;
            this.ItemNoteTB.Name = "ItemNoteTB";
            this.ItemNoteTB.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ItemNoteTB.Size = new System.Drawing.Size(375, 37);
            this.ItemNoteTB.TabIndex = 120;
            this.ItemNoteTB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ItemNoteTB_KeyDown);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(769, 339);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(122, 28);
            this.label8.TabIndex = 39;
            this.label8.Text = "موديل الصنف";
            // 
            // ItemModelTB
            // 
            this.ItemModelTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ItemModelTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ItemModelTB.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemModelTB.Location = new System.Drawing.Point(388, 336);
            this.ItemModelTB.MaxLength = 50;
            this.ItemModelTB.Name = "ItemModelTB";
            this.ItemModelTB.Size = new System.Drawing.Size(375, 35);
            this.ItemModelTB.TabIndex = 100;
            this.ItemModelTB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ItemModelTB_KeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(769, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 28);
            this.label6.TabIndex = 37;
            this.label6.Text = "اسم الصنف";
            // 
            // ItemNameTB
            // 
            this.ItemNameTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ItemNameTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ItemNameTB.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemNameTB.Location = new System.Drawing.Point(388, 171);
            this.ItemNameTB.MaxLength = 50;
            this.ItemNameTB.Name = "ItemNameTB";
            this.ItemNameTB.Size = new System.Drawing.Size(375, 35);
            this.ItemNameTB.TabIndex = 54;
            this.ItemNameTB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ItemNameTB_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(769, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 28);
            this.label5.TabIndex = 35;
            this.label5.Text = "التصنيف";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(769, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 28);
            this.label4.TabIndex = 34;
            this.label4.Text = "كود الصنف";
            // 
            // ItemIdTB
            // 
            this.ItemIdTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ItemIdTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ItemIdTB.Enabled = false;
            this.ItemIdTB.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemIdTB.Location = new System.Drawing.Point(388, 71);
            this.ItemIdTB.Name = "ItemIdTB";
            this.ItemIdTB.Size = new System.Drawing.Size(375, 35);
            this.ItemIdTB.TabIndex = 33;
            // 
            // categoryTableAdapter
            // 
            this.categoryTableAdapter.ClearBeforeFill = true;
            // 
            // itemDetailsTableAdapter
            // 
            this.itemDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // salesDataSetBindingSource
            // 
            this.salesDataSetBindingSource.DataSource = this.salesDataSet;
            this.salesDataSetBindingSource.Position = 0;
            // 
            // itemsTableAdapter
            // 
            this.itemsTableAdapter.ClearBeforeFill = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(769, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 28);
            this.label3.TabIndex = 54;
            this.label3.Text = "الباركود";
            // 
            // ItemBarCodeTB
            // 
            this.ItemBarCodeTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ItemBarCodeTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ItemBarCodeTB.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemBarCodeTB.Location = new System.Drawing.Point(388, 122);
            this.ItemBarCodeTB.MaxLength = 13;
            this.ItemBarCodeTB.Name = "ItemBarCodeTB";
            this.ItemBarCodeTB.Size = new System.Drawing.Size(375, 35);
            this.ItemBarCodeTB.TabIndex = 121;
            this.ItemBarCodeTB.TextChanged += new System.EventHandler(this.ItemBarCodeTB_TextChanged);
            this.ItemBarCodeTB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ItemBarCodeTB_KeyDown);
            // 
            // HideCHB
            // 
            this.HideCHB.AutoSize = true;
            this.HideCHB.Location = new System.Drawing.Point(103, 33);
            this.HideCHB.Name = "HideCHB";
            this.HideCHB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.HideCHB.Size = new System.Drawing.Size(109, 25);
            this.HideCHB.TabIndex = 122;
            this.HideCHB.Text = " اسعار صنف";
            this.HideCHB.UseVisualStyleBackColor = true;
            this.HideCHB.CheckedChanged += new System.EventHandler(this.HideCHB_CheckedChanged);
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.partener_cmbx);
            this.groupPanel1.Controls.Add(this.label16);
            this.groupPanel1.Controls.Add(this.add_com_btn);
            this.groupPanel1.Controls.Add(this.update_expire_date_exp);
            this.groupPanel1.Controls.Add(this.expandablePanel1);
            this.groupPanel1.Controls.Add(this.label23);
            this.groupPanel1.Controls.Add(this.expire_item_grid);
            this.groupPanel1.Controls.Add(this.label25);
            this.groupPanel1.Controls.Add(this.item_sav_date);
            this.groupPanel1.Controls.Add(this.label15);
            this.groupPanel1.Controls.Add(this.expire_date);
            this.groupPanel1.Controls.Add(this.company_cmbx);
            this.groupPanel1.Controls.Add(this.label14);
            this.groupPanel1.Controls.Add(this.sanf_store_num);
            this.groupPanel1.Controls.Add(this.label11);
            this.groupPanel1.Controls.Add(this.HideCHB);
            this.groupPanel1.Controls.Add(this.label7);
            this.groupPanel1.Controls.Add(this.label3);
            this.groupPanel1.Controls.Add(this.ItemIdTB);
            this.groupPanel1.Controls.Add(this.ItemBarCodeTB);
            this.groupPanel1.Controls.Add(this.label4);
            this.groupPanel1.Controls.Add(this.CatIdCB);
            this.groupPanel1.Controls.Add(this.label5);
            this.groupPanel1.Controls.Add(this.KatPriceTB);
            this.groupPanel1.Controls.Add(this.ItemNameTB);
            this.groupPanel1.Controls.Add(this.GomlaPriceTB);
            this.groupPanel1.Controls.Add(this.label6);
            this.groupPanel1.Controls.Add(this.PurchPriceTB);
            this.groupPanel1.Controls.Add(this.ItemModelTB);
            this.groupPanel1.Controls.Add(this.label13);
            this.groupPanel1.Controls.Add(this.label8);
            this.groupPanel1.Controls.Add(this.label12);
            this.groupPanel1.Controls.Add(this.ItemNoteTB);
            this.groupPanel1.Controls.Add(this.label9);
            this.groupPanel1.Controls.Add(this.ItemClear);
            this.groupPanel1.Controls.Add(this.ItemInsertBtn);
            this.groupPanel1.Controls.Add(this.ItemUpdateBtn);
            this.groupPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupPanel1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupPanel1.IsShadowEnabled = true;
            this.groupPanel1.Location = new System.Drawing.Point(0, 0);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(1008, 615);
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
            this.groupPanel1.TabIndex = 63;
            this.groupPanel1.Text = "اضافة صنف";
            this.groupPanel1.Click += new System.EventHandler(this.groupPanel1_Click);
            // 
            // partener_cmbx
            // 
            this.partener_cmbx.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.partener_cmbx.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.partener_cmbx.DisplayMember = "CatId";
            this.partener_cmbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.partener_cmbx.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partener_cmbx.FormattingEnabled = true;
            this.partener_cmbx.Location = new System.Drawing.Point(388, 270);
            this.partener_cmbx.Name = "partener_cmbx";
            this.partener_cmbx.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.partener_cmbx.Size = new System.Drawing.Size(376, 35);
            this.partener_cmbx.TabIndex = 134;
            this.partener_cmbx.ValueMember = "CatId";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label16.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label16.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(770, 273);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(76, 28);
            this.label16.TabIndex = 133;
            this.label16.Text = "الشركاء";
            // 
            // add_com_btn
            // 
            this.add_com_btn.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.add_com_btn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.add_com_btn.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.add_com_btn.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_com_btn.Location = new System.Drawing.Point(300, 390);
            this.add_com_btn.Name = "add_com_btn";
            this.add_com_btn.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(10);
            this.add_com_btn.Size = new System.Drawing.Size(79, 34);
            this.add_com_btn.TabIndex = 132;
            this.add_com_btn.Text = "اضافة شركه";
            this.add_com_btn.Click += new System.EventHandler(this.add_com_btn_Click);
            // 
            // update_expire_date_exp
            // 
            this.update_expire_date_exp.CanvasColor = System.Drawing.SystemColors.Control;
            this.update_expire_date_exp.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.update_expire_date_exp.Controls.Add(this.exit_btn);
            this.update_expire_date_exp.Controls.Add(this.update_btn);
            this.update_expire_date_exp.Controls.Add(this.expire_up_date);
            this.update_expire_date_exp.Expanded = false;
            this.update_expire_date_exp.ExpandedBounds = new System.Drawing.Rectangle(57, 301, 200, 123);
            this.update_expire_date_exp.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_expire_date_exp.Location = new System.Drawing.Point(57, 275);
            this.update_expire_date_exp.Name = "update_expire_date_exp";
            this.update_expire_date_exp.Size = new System.Drawing.Size(200, 26);
            this.update_expire_date_exp.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.update_expire_date_exp.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.update_expire_date_exp.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.update_expire_date_exp.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.update_expire_date_exp.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.update_expire_date_exp.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.update_expire_date_exp.Style.GradientAngle = 90;
            this.update_expire_date_exp.TabIndex = 131;
            this.update_expire_date_exp.TitleStyle.Alignment = System.Drawing.StringAlignment.Center;
            this.update_expire_date_exp.TitleStyle.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.update_expire_date_exp.TitleStyle.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.update_expire_date_exp.TitleStyle.Border = DevComponents.DotNetBar.eBorderType.RaisedInner;
            this.update_expire_date_exp.TitleStyle.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.update_expire_date_exp.TitleStyle.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.update_expire_date_exp.TitleStyle.GradientAngle = 90;
            this.update_expire_date_exp.TitleText = "تعديل صلاحية صنف";
            this.update_expire_date_exp.Visible = false;
            // 
            // exit_btn
            // 
            this.exit_btn.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.exit_btn.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.exit_btn.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_btn.Location = new System.Drawing.Point(19, 83);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(81, 27);
            this.exit_btn.TabIndex = 3;
            this.exit_btn.Text = "خروج";
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // update_btn
            // 
            this.update_btn.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.update_btn.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.update_btn.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_btn.Location = new System.Drawing.Point(106, 83);
            this.update_btn.Name = "update_btn";
            this.update_btn.Size = new System.Drawing.Size(81, 27);
            this.update_btn.TabIndex = 2;
            this.update_btn.Text = "تعديل";
            this.update_btn.Click += new System.EventHandler(this.update_btn_Click);
            // 
            // expire_up_date
            // 
            this.expire_up_date.CalendarFont = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expire_up_date.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expire_up_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.expire_up_date.Location = new System.Drawing.Point(11, 34);
            this.expire_up_date.Name = "expire_up_date";
            this.expire_up_date.Size = new System.Drawing.Size(182, 29);
            this.expire_up_date.TabIndex = 1;
            // 
            // label23
            // 
            this.label23.BackColor = System.Drawing.Color.LightGray;
            this.label23.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label23.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label23.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.Blue;
            this.label23.Location = new System.Drawing.Point(261, 339);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(89, 24);
            this.label23.TabIndex = 130;
            this.label23.Text = "صلاحيات الصنف";
            this.grid_tooltip.SetToolTip(this.label23, "لحذف صلاحية حدد واضغط زرار حذف\r\ndelete \r\n لتعديل تاريخ صلاحية دبل كليك على التاري" +
                    "خ المراد تعديله من الجدول ");
            this.label23.Click += new System.EventHandler(this.label23_Click);
            // 
            // expire_item_grid
            // 
            this.expire_item_grid.AllowUserToAddRows = false;
            this.expire_item_grid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expire_item_grid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.expire_item_grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.expire_item_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.expire_item_grid.ColumnHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.expire_item_grid.DefaultCellStyle = dataGridViewCellStyle2;
            this.expire_item_grid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.expire_item_grid.Location = new System.Drawing.Point(57, 302);
            this.expire_item_grid.Name = "expire_item_grid";
            this.expire_item_grid.ReadOnly = true;
            this.expire_item_grid.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.expire_item_grid.Size = new System.Drawing.Size(198, 96);
            this.expire_item_grid.TabIndex = 129;
            this.grid_tooltip.SetToolTip(this.expire_item_grid, "grid_tooltip");
            this.expire_item_grid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.expire_item_grid_CellClick);
            this.expire_item_grid.DoubleClick += new System.EventHandler(this.expire_item_grid_DoubleClick);
            this.expire_item_grid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.expire_item_grid_KeyDown);
            this.expire_item_grid.MouseUp += new System.Windows.Forms.MouseEventHandler(this.expire_item_grid_MouseUp);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label25.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label25.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ForeColor = System.Drawing.Color.White;
            this.label25.Location = new System.Drawing.Point(524, 19);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(104, 21);
            this.label25.TabIndex = 128;
            this.label25.Text = "تاريخ حفظ الصنف";
            // 
            // item_sav_date
            // 
            this.item_sav_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.item_sav_date.Location = new System.Drawing.Point(384, 16);
            this.item_sav_date.Name = "item_sav_date";
            this.item_sav_date.Size = new System.Drawing.Size(134, 29);
            this.item_sav_date.TabIndex = 127;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(762, 22);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(90, 19);
            this.label15.TabIndex = 126;
            this.label15.Text = "انتهاء الصلاحية";
            // 
            // expire_date
            // 
            this.expire_date.CustomFormat = "dd-mm-yyyy";
            this.expire_date.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expire_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.expire_date.Location = new System.Drawing.Point(673, 17);
            this.expire_date.Name = "expire_date";
            this.expire_date.ShowUpDown = true;
            this.expire_date.Size = new System.Drawing.Size(86, 29);
            this.expire_date.TabIndex = 125;
            // 
            // company_cmbx
            // 
            this.company_cmbx.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.company_cmbx.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.company_cmbx.DisplayMember = "CatId";
            this.company_cmbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.company_cmbx.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.company_cmbx.FormattingEnabled = true;
            this.company_cmbx.Location = new System.Drawing.Point(388, 388);
            this.company_cmbx.Name = "company_cmbx";
            this.company_cmbx.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.company_cmbx.Size = new System.Drawing.Size(375, 35);
            this.company_cmbx.TabIndex = 124;
            this.company_cmbx.ValueMember = "CatId";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label14.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(769, 392);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(141, 28);
            this.label14.TabIndex = 123;
            this.label14.Text = "الشركة المصنعه";
            // 
            // sanf_store_num
            // 
            this.sanf_store_num.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.sanf_store_num.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sanf_store_num.Location = new System.Drawing.Point(57, 214);
            this.sanf_store_num.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.sanf_store_num.Minimum = new decimal(new int[] {
            99999,
            0,
            0,
            -2147483648});
            this.sanf_store_num.Name = "sanf_store_num";
            this.sanf_store_num.Size = new System.Drawing.Size(155, 35);
            this.sanf_store_num.TabIndex = 58;
            this.sanf_store_num.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.sanf_store_num.Visible = false;
            this.sanf_store_num.KeyDown += new System.Windows.Forms.KeyEventHandler(this.sanf_store_num_KeyDown);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label11.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(218, 217);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 28);
            this.label11.TabIndex = 63;
            this.label11.Text = "العدد";
            this.label11.Visible = false;
            // 
            // grid_tooltip
            // 
            this.grid_tooltip.AutoPopDelay = 7000;
            this.grid_tooltip.InitialDelay = 500;
            this.grid_tooltip.IsBalloon = true;
            this.grid_tooltip.ReshowDelay = 100;
            this.grid_tooltip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.grid_tooltip.ToolTipTitle = "ملحوظة:";
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.AgentTableAdapter = null;
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.Connection = null;
            this.tableAdapterManager1.UpdateOrder = sales_pro.AgentDSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // ItemBD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.groupPanel1);
            this.Name = "ItemBD";
            this.Size = new System.Drawing.Size(1008, 615);
            this.Load += new System.EventHandler(this.ItemBD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KatPriceTB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GomlaPriceTB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PurchPriceTB)).EndInit();
            this.expandablePanel1.ResumeLayout(false);
            this.expandablePanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsTADS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemDS1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesDataSetBindingSource)).EndInit();
            this.groupPanel1.ResumeLayout(false);
            this.groupPanel1.PerformLayout();
            this.update_expire_date_exp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.expire_item_grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sanf_store_num)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ComboBox CatIdCB;
        private System.Windows.Forms.NumericUpDown KatPriceTB;
        private System.Windows.Forms.NumericUpDown GomlaPriceTB;
        private System.Windows.Forms.NumericUpDown PurchPriceTB;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label7;
        private DevComponents.DotNetBar.ExpandablePanel expandablePanel1;
        private DevComponents.DotNetBar.ButtonX ItemClear;
        private DevComponents.DotNetBar.ButtonX ItemUpdateBtn;
        private DevComponents.DotNetBar.ButtonX ItemInsertBtn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox ItemNoteTB;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox ItemModelTB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ItemNameTB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ItemIdTB;
        public System.Windows.Forms.ComboBox CatCB;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox ItemCB;
        private salesDataSet1 salesDataSet1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource itemDetailsBindingSource;
        private ItemDS1 itemDS1;
        private ItemDS1TableAdapters.ItemDetailsTableAdapter itemDetailsTableAdapter;
        private System.Windows.Forms.BindingSource categoryBindingSource1;
        private System.Windows.Forms.BindingSource salesDataSetBindingSource;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ItemBarCodeTB;
        public System.Windows.Forms.BindingSource categoryBindingSource;
        public salesDataSet salesDataSet;
        public salesDataSetTableAdapters.CategoryTableAdapter categoryTableAdapter;
        public System.Windows.Forms.BindingSource itemsBindingSource;
        public ItemsTADS itemsTADS;
        public ItemsTADSTableAdapters.ItemsTableAdapter itemsTableAdapter;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox HideCHB;
        private System.Windows.Forms.TextBox ItemIdQTB;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private System.Windows.Forms.NumericUpDown sanf_store_num;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.ComboBox company_cmbx;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.DateTimePicker item_sav_date;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DateTimePicker expire_date;
        private System.Windows.Forms.Label label23;
        private DevComponents.DotNetBar.Controls.DataGridViewX expire_item_grid;
        private DevComponents.DotNetBar.ExpandablePanel update_expire_date_exp;
        private System.Windows.Forms.DateTimePicker expire_up_date;
        private DevComponents.DotNetBar.ButtonX update_btn;
        private DevComponents.DotNetBar.ButtonX exit_btn;
        private System.Windows.Forms.ToolTip grid_tooltip;
        private DevComponents.DotNetBar.ButtonX add_com_btn;
        public System.Windows.Forms.ComboBox partener_cmbx;
        private System.Windows.Forms.Label label16;
        private AgentDSTableAdapters.TableAdapterManager tableAdapterManager1;

    }
}
