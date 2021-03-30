namespace sales_pro
{
    partial class PrintSalesPriv
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
            this.SalesBillCRD1 = new sales_pro.SalesBillCRD();
            this.ItemRB = new System.Windows.Forms.RadioButton();
            this.ToDateTB = new System.Windows.Forms.DateTimePicker();
            this.CatRB = new System.Windows.Forms.RadioButton();
            this.AgentQCB = new System.Windows.Forms.ComboBox();
            this.agentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.agentDS = new sales_pro.AgentDS();
            this.FromDateTB = new System.Windows.Forms.DateTimePicker();
            this.QueryBTN = new System.Windows.Forms.Button();
            this.agentTableAdapter = new sales_pro.AgentDSTableAdapters.AgentTableAdapter();
            this.ItemIdTB = new System.Windows.Forms.TextBox();
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.salesDataSet = new sales_pro.salesDataSet();
            this.categoryTableAdapter = new sales_pro.salesDataSetTableAdapters.CategoryTableAdapter();
            this.itemsTADS = new sales_pro.ItemsTADS();
            this.itemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itemsTableAdapter = new sales_pro.ItemsTADSTableAdapters.ItemsTableAdapter();
            this.CategoryCB = new System.Windows.Forms.ComboBox();
            this.ItemCB = new System.Windows.Forms.ComboBox();
            this.AllRB = new System.Windows.Forms.RadioButton();
            this.label13 = new System.Windows.Forms.Label();
            this.OperTypeCB = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AgentCHB = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.sel_sanf_nam_by_tasn_bx = new System.Windows.Forms.ComboBox();
            this.sel_rp_cod_rdbtn = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.agentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agentDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsTADS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ItemRB
            // 
            this.ItemRB.AutoSize = true;
            this.ItemRB.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ItemRB.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemRB.Location = new System.Drawing.Point(515, 55);
            this.ItemRB.Name = "ItemRB";
            this.ItemRB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ItemRB.Size = new System.Drawing.Size(115, 27);
            this.ItemRB.TabIndex = 43;
            this.ItemRB.Text = "حسب الصنف";
            this.ItemRB.UseVisualStyleBackColor = true;
            this.ItemRB.CheckedChanged += new System.EventHandler(this.ItemRB_CheckedChanged);
            // 
            // ToDateTB
            // 
            this.ToDateTB.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToDateTB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ToDateTB.Location = new System.Drawing.Point(125, 70);
            this.ToDateTB.Name = "ToDateTB";
            this.ToDateTB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ToDateTB.Size = new System.Drawing.Size(195, 29);
            this.ToDateTB.TabIndex = 42;
            this.ToDateTB.ValueChanged += new System.EventHandler(this.ToDateTB_ValueChanged);
            // 
            // CatRB
            // 
            this.CatRB.AutoSize = true;
            this.CatRB.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.CatRB.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CatRB.Location = new System.Drawing.Point(505, 90);
            this.CatRB.Name = "CatRB";
            this.CatRB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CatRB.Size = new System.Drawing.Size(125, 27);
            this.CatRB.TabIndex = 41;
            this.CatRB.Text = "حسب التصنيف";
            this.CatRB.UseVisualStyleBackColor = true;
            this.CatRB.CheckedChanged += new System.EventHandler(this.CatRB_CheckedChanged);
            // 
            // AgentQCB
            // 
            this.AgentQCB.DataSource = this.agentBindingSource;
            this.AgentQCB.DisplayMember = "AgentName";
            this.AgentQCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AgentQCB.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgentQCB.FormattingEnabled = true;
            this.AgentQCB.Location = new System.Drawing.Point(125, 25);
            this.AgentQCB.Name = "AgentQCB";
            this.AgentQCB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.AgentQCB.Size = new System.Drawing.Size(195, 30);
            this.AgentQCB.TabIndex = 39;
            this.AgentQCB.ValueMember = "AgentId";
            this.AgentQCB.SelectedIndexChanged += new System.EventHandler(this.AgentQCB_SelectedIndexChanged);
            // 
            // agentBindingSource
            // 
            this.agentBindingSource.DataMember = "Agent";
            this.agentBindingSource.DataSource = this.agentDS;
            // 
            // agentDS
            // 
            this.agentDS.DataSetName = "AgentDS";
            this.agentDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FromDateTB
            // 
            this.FromDateTB.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FromDateTB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FromDateTB.Location = new System.Drawing.Point(395, 70);
            this.FromDateTB.Name = "FromDateTB";
            this.FromDateTB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.FromDateTB.Size = new System.Drawing.Size(147, 29);
            this.FromDateTB.TabIndex = 36;
            this.FromDateTB.ValueChanged += new System.EventHandler(this.FromDateTB_ValueChanged);
            // 
            // QueryBTN
            // 
            this.QueryBTN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.QueryBTN.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.QueryBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.QueryBTN.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QueryBTN.ForeColor = System.Drawing.Color.Blue;
            this.QueryBTN.Location = new System.Drawing.Point(728, 12);
            this.QueryBTN.Name = "QueryBTN";
            this.QueryBTN.Size = new System.Drawing.Size(275, 31);
            this.QueryBTN.TabIndex = 45;
            this.QueryBTN.Text = "تقرير عن المبيعات خلال فترة على حسب";
            this.QueryBTN.UseVisualStyleBackColor = false;
            this.QueryBTN.Click += new System.EventHandler(this.QueryBTN_Click);
            // 
            // agentTableAdapter
            // 
            this.agentTableAdapter.ClearBeforeFill = true;
            // 
            // ItemIdTB
            // 
            this.ItemIdTB.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemIdTB.Location = new System.Drawing.Point(287, 19);
            this.ItemIdTB.Name = "ItemIdTB";
            this.ItemIdTB.Size = new System.Drawing.Size(200, 29);
            this.ItemIdTB.TabIndex = 46;
            this.ItemIdTB.TextChanged += new System.EventHandler(this.ItemIdTB_TextChanged);
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
            // itemsTADS
            // 
            this.itemsTADS.DataSetName = "ItemsTADS";
            this.itemsTADS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // itemsBindingSource
            // 
            this.itemsBindingSource.DataMember = "Items";
            this.itemsBindingSource.DataSource = this.itemsTADS;
            // 
            // itemsTableAdapter
            // 
            this.itemsTableAdapter.ClearBeforeFill = true;
            // 
            // CategoryCB
            // 
            this.CategoryCB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CategoryCB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CategoryCB.DataSource = this.categoryBindingSource;
            this.CategoryCB.DisplayMember = "CatName";
            this.CategoryCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CategoryCB.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CategoryCB.FormattingEnabled = true;
            this.CategoryCB.Location = new System.Drawing.Point(287, 90);
            this.CategoryCB.Name = "CategoryCB";
            this.CategoryCB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CategoryCB.Size = new System.Drawing.Size(200, 30);
            this.CategoryCB.TabIndex = 51;
            this.CategoryCB.ValueMember = "CatId";
            this.CategoryCB.SelectedIndexChanged += new System.EventHandler(this.CategoryCB_SelectedIndexChanged);
            // 
            // ItemCB
            // 
            this.ItemCB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ItemCB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ItemCB.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.categoryBindingSource, "CatId", true));
            this.ItemCB.DisplayMember = "ItemId";
            this.ItemCB.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemCB.FormattingEnabled = true;
            this.ItemCB.Location = new System.Drawing.Point(6, 52);
            this.ItemCB.Name = "ItemCB";
            this.ItemCB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ItemCB.Size = new System.Drawing.Size(200, 30);
            this.ItemCB.TabIndex = 52;
            this.ItemCB.ValueMember = "ItemId";
            this.ItemCB.SelectedIndexChanged += new System.EventHandler(this.ItemCB_SelectedIndexChanged);
            // 
            // AllRB
            // 
            this.AllRB.AutoSize = true;
            this.AllRB.Checked = true;
            this.AllRB.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.AllRB.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllRB.Location = new System.Drawing.Point(572, 125);
            this.AllRB.Name = "AllRB";
            this.AllRB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.AllRB.Size = new System.Drawing.Size(58, 27);
            this.AllRB.TabIndex = 53;
            this.AllRB.TabStop = true;
            this.AllRB.Text = "الكل";
            this.AllRB.UseVisualStyleBackColor = true;
            this.AllRB.CheckedChanged += new System.EventHandler(this.AllRB_CheckedChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label13.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(548, 30);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(81, 24);
            this.label13.TabIndex = 55;
            this.label13.Text = "نوع العملية";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // OperTypeCB
            // 
            this.OperTypeCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.OperTypeCB.Enabled = false;
            this.OperTypeCB.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OperTypeCB.FormattingEnabled = true;
            this.OperTypeCB.Items.AddRange(new object[] {
            "عمليات بيع",
            "عمليات ارتجاع"});
            this.OperTypeCB.Location = new System.Drawing.Point(395, 27);
            this.OperTypeCB.Name = "OperTypeCB";
            this.OperTypeCB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.OperTypeCB.Size = new System.Drawing.Size(147, 30);
            this.OperTypeCB.TabIndex = 54;
            this.OperTypeCB.SelectedIndexChanged += new System.EventHandler(this.OperTypeCB_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.AgentCHB);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.FromDateTB);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.AgentQCB);
            this.groupBox1.Controls.Add(this.OperTypeCB);
            this.groupBox1.Controls.Add(this.ToDateTB);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(722, 129);
            this.groupBox1.TabIndex = 56;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "بيانات اساسية";
            // 
            // AgentCHB
            // 
            this.AgentCHB.AutoSize = true;
            this.AgentCHB.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgentCHB.Location = new System.Drawing.Point(324, 29);
            this.AgentCHB.Name = "AgentCHB";
            this.AgentCHB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.AgentCHB.Size = new System.Drawing.Size(66, 26);
            this.AgentCHB.TabIndex = 58;
            this.AgentCHB.Text = "العميل";
            this.AgentCHB.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(358, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 24);
            this.label3.TabIndex = 57;
            this.label3.Text = "الى";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(559, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 24);
            this.label2.TabIndex = 56;
            this.label2.Text = "الفترة من";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.sel_sanf_nam_by_tasn_bx);
            this.groupBox2.Controls.Add(this.sel_rp_cod_rdbtn);
            this.groupBox2.Controls.Add(this.ItemCB);
            this.groupBox2.Controls.Add(this.CatRB);
            this.groupBox2.Controls.Add(this.AllRB);
            this.groupBox2.Controls.Add(this.ItemRB);
            this.groupBox2.Controls.Add(this.ItemIdTB);
            this.groupBox2.Controls.Add(this.CategoryCB);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(0, 131);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(722, 162);
            this.groupBox2.TabIndex = 57;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "فلترة";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(222, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 24);
            this.label4.TabIndex = 61;
            this.label4.Text = "الصنف";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(454, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 24);
            this.label1.TabIndex = 60;
            this.label1.Text = "تصنيف";
            // 
            // sel_sanf_nam_by_tasn_bx
            // 
            this.sel_sanf_nam_by_tasn_bx.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.sel_sanf_nam_by_tasn_bx.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.sel_sanf_nam_by_tasn_bx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sel_sanf_nam_by_tasn_bx.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sel_sanf_nam_by_tasn_bx.FormattingEnabled = true;
            this.sel_sanf_nam_by_tasn_bx.Location = new System.Drawing.Point(287, 51);
            this.sel_sanf_nam_by_tasn_bx.Name = "sel_sanf_nam_by_tasn_bx";
            this.sel_sanf_nam_by_tasn_bx.Size = new System.Drawing.Size(161, 30);
            this.sel_sanf_nam_by_tasn_bx.TabIndex = 59;
            this.sel_sanf_nam_by_tasn_bx.SelectedIndexChanged += new System.EventHandler(this.sel_sanf_nam_by_tasn_bx_SelectedIndexChanged);
            // 
            // sel_rp_cod_rdbtn
            // 
            this.sel_rp_cod_rdbtn.AutoSize = true;
            this.sel_rp_cod_rdbtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.sel_rp_cod_rdbtn.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sel_rp_cod_rdbtn.Location = new System.Drawing.Point(526, 20);
            this.sel_rp_cod_rdbtn.Name = "sel_rp_cod_rdbtn";
            this.sel_rp_cod_rdbtn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.sel_rp_cod_rdbtn.Size = new System.Drawing.Size(104, 27);
            this.sel_rp_cod_rdbtn.TabIndex = 54;
            this.sel_rp_cod_rdbtn.Text = "كود الصنف";
            this.sel_rp_cod_rdbtn.UseVisualStyleBackColor = true;
            // 
            // PrintSalesPriv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.QueryBTN);
            this.Name = "PrintSalesPriv";
            this.Size = new System.Drawing.Size(1011, 313);
            this.Load += new System.EventHandler(this.PrintSalesPriv_Load);
            ((System.ComponentModel.ISupportInitialize)(this.agentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agentDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsTADS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton ItemRB;
        private System.Windows.Forms.DateTimePicker ToDateTB;
        private System.Windows.Forms.RadioButton CatRB;
        private System.Windows.Forms.ComboBox AgentQCB;
        private System.Windows.Forms.DateTimePicker FromDateTB;
        private SalesBillCRD SalesBillCRD1;
        private System.Windows.Forms.Button QueryBTN;
        private System.Windows.Forms.BindingSource agentBindingSource;
        private AgentDS agentDS;
        private AgentDSTableAdapters.AgentTableAdapter agentTableAdapter;
        private System.Windows.Forms.TextBox ItemIdTB;
        public System.Windows.Forms.BindingSource categoryBindingSource;
        public salesDataSet salesDataSet;
        public salesDataSetTableAdapters.CategoryTableAdapter categoryTableAdapter;
        public ItemsTADS itemsTADS;
        public System.Windows.Forms.BindingSource itemsBindingSource;
        public ItemsTADSTableAdapters.ItemsTableAdapter itemsTableAdapter;
        private System.Windows.Forms.ComboBox CategoryCB;
        private System.Windows.Forms.ComboBox ItemCB;
        private System.Windows.Forms.RadioButton AllRB;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox OperTypeCB;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox AgentCHB;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton sel_rp_cod_rdbtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox sel_sanf_nam_by_tasn_bx;
    }
}
