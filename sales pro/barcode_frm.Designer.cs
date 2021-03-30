namespace sales_pro
{
    partial class barcode_frm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(barcode_frm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label6 = new System.Windows.Forms.Label();
            this.bar_sanf_cod_bx = new System.Windows.Forms.TextBox();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.bar_tasn_name_cmbx = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.label15 = new System.Windows.Forms.Label();
            this.bar_sanf_name_cmbx = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.bar_code_bx = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupPanel2 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.groupPanel3 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.a4_splited_rdbtn = new System.Windows.Forms.RadioButton();
            this.a4_compl_rdbnt = new System.Windows.Forms.RadioButton();
            this.copy_n_bx = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.bar_pic_num_bx = new System.Windows.Forms.NumericUpDown();
            this.exit_btn = new DevComponents.DotNetBar.ButtonX();
            this.bar_prnt_btn = new DevComponents.DotNetBar.ButtonX();
            this.show_bef_prnt_btn = new DevComponents.DotNetBar.ButtonX();
            this.bar_save_btn = new DevComponents.DotNetBar.ButtonX();
            this.label3 = new System.Windows.Forms.Label();
            this.bar_type_cmbx = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.comboItem1 = new DevComponents.Editors.ComboItem();
            this.comboItem2 = new DevComponents.Editors.ComboItem();
            this.bar_grid = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.groupPanel1.SuspendLayout();
            this.groupPanel2.SuspendLayout();
            this.groupPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bar_pic_num_bx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bar_grid)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(930, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 21);
            this.label6.TabIndex = 21;
            this.label6.Text = "كود الصنف";
            // 
            // bar_sanf_cod_bx
            // 
            this.bar_sanf_cod_bx.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bar_sanf_cod_bx.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.bar_sanf_cod_bx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bar_sanf_cod_bx.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bar_sanf_cod_bx.Location = new System.Drawing.Point(801, 16);
            this.bar_sanf_cod_bx.MaxLength = 13;
            this.bar_sanf_cod_bx.Name = "bar_sanf_cod_bx";
            this.bar_sanf_cod_bx.Size = new System.Drawing.Size(122, 26);
            this.bar_sanf_cod_bx.TabIndex = 20;
            this.bar_sanf_cod_bx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.bar_sanf_cod_bx.TextChanged += new System.EventHandler(this.bar_sanf_cod_bx_TextChanged);
            this.bar_sanf_cod_bx.KeyDown += new System.Windows.Forms.KeyEventHandler(this.bar_sanf_cod_bx_KeyDown);
            // 
            // groupPanel1
            // 
            this.groupPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.label5);
            this.groupPanel1.Controls.Add(this.bar_tasn_name_cmbx);
            this.groupPanel1.Controls.Add(this.label15);
            this.groupPanel1.Controls.Add(this.bar_sanf_name_cmbx);
            this.groupPanel1.Controls.Add(this.bar_code_bx);
            this.groupPanel1.Controls.Add(this.label2);
            this.groupPanel1.Controls.Add(this.bar_sanf_cod_bx);
            this.groupPanel1.Controls.Add(this.label6);
            this.groupPanel1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupPanel1.Location = new System.Drawing.Point(3, 3);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(1031, 79);
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
            this.groupPanel1.TabIndex = 22;
            this.groupPanel1.Text = "الاستعلام عن صنف";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(473, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 21);
            this.label5.TabIndex = 48;
            this.label5.Text = "تصنيف";
            // 
            // bar_tasn_name_cmbx
            // 
            this.bar_tasn_name_cmbx.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bar_tasn_name_cmbx.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.bar_tasn_name_cmbx.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.bar_tasn_name_cmbx.DisplayMember = "Text";
            this.bar_tasn_name_cmbx.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.bar_tasn_name_cmbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bar_tasn_name_cmbx.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bar_tasn_name_cmbx.FormattingEnabled = true;
            this.bar_tasn_name_cmbx.ItemHeight = 20;
            this.bar_tasn_name_cmbx.Location = new System.Drawing.Point(302, 16);
            this.bar_tasn_name_cmbx.Name = "bar_tasn_name_cmbx";
            this.bar_tasn_name_cmbx.Size = new System.Drawing.Size(164, 26);
            this.bar_tasn_name_cmbx.TabIndex = 47;
            this.bar_tasn_name_cmbx.SelectedIndexChanged += new System.EventHandler(this.bar_tasn_name_cmbx_SelectedIndexChanged);
            this.bar_tasn_name_cmbx.DropDownClosed += new System.EventHandler(this.bar_tasn_name_cmbx_DropDownClosed);
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label15.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(224, 19);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(71, 21);
            this.label15.TabIndex = 46;
            this.label15.Text = "اسم الصنف";
            // 
            // bar_sanf_name_cmbx
            // 
            this.bar_sanf_name_cmbx.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bar_sanf_name_cmbx.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.bar_sanf_name_cmbx.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.bar_sanf_name_cmbx.DisplayMember = "Text";
            this.bar_sanf_name_cmbx.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.bar_sanf_name_cmbx.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bar_sanf_name_cmbx.FormattingEnabled = true;
            this.bar_sanf_name_cmbx.ItemHeight = 20;
            this.bar_sanf_name_cmbx.Location = new System.Drawing.Point(3, 16);
            this.bar_sanf_name_cmbx.Name = "bar_sanf_name_cmbx";
            this.bar_sanf_name_cmbx.Size = new System.Drawing.Size(214, 26);
            this.bar_sanf_name_cmbx.TabIndex = 45;
            this.bar_sanf_name_cmbx.SelectedIndexChanged += new System.EventHandler(this.bar_sanf_name_cmbx_SelectedIndexChanged);
            this.bar_sanf_name_cmbx.DropDownClosed += new System.EventHandler(this.bar_sanf_name_cmbx_DropDownClosed);
            // 
            // bar_code_bx
            // 
            this.bar_code_bx.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bar_code_bx.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.bar_code_bx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bar_code_bx.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bar_code_bx.Location = new System.Drawing.Point(531, 17);
            this.bar_code_bx.Name = "bar_code_bx";
            this.bar_code_bx.ReadOnly = true;
            this.bar_code_bx.Size = new System.Drawing.Size(173, 26);
            this.bar_code_bx.TabIndex = 22;
            this.bar_code_bx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.bar_code_bx.TextChanged += new System.EventHandler(this.bar_code_bx_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(711, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 21);
            this.label2.TabIndex = 23;
            this.label2.Text = "باركود الصنف";
            // 
            // groupPanel2
            // 
            this.groupPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupPanel2.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel2.Controls.Add(this.groupPanel3);
            this.groupPanel2.Controls.Add(this.bar_pic_num_bx);
            this.groupPanel2.Controls.Add(this.exit_btn);
            this.groupPanel2.Controls.Add(this.bar_prnt_btn);
            this.groupPanel2.Controls.Add(this.show_bef_prnt_btn);
            this.groupPanel2.Controls.Add(this.bar_save_btn);
            this.groupPanel2.Controls.Add(this.label3);
            this.groupPanel2.Controls.Add(this.bar_type_cmbx);
            this.groupPanel2.Controls.Add(this.bar_grid);
            this.groupPanel2.Controls.Add(this.label1);
            this.groupPanel2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupPanel2.Location = new System.Drawing.Point(1, 86);
            this.groupPanel2.Name = "groupPanel2";
            this.groupPanel2.Size = new System.Drawing.Size(1036, 494);
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
            this.groupPanel2.TabIndex = 23;
            this.groupPanel2.Text = "طباعة الباركود";
            // 
            // groupPanel3
            // 
            this.groupPanel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupPanel3.BackColor = System.Drawing.Color.Transparent;
            this.groupPanel3.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel3.Controls.Add(this.a4_splited_rdbtn);
            this.groupPanel3.Controls.Add(this.a4_compl_rdbnt);
            this.groupPanel3.Controls.Add(this.copy_n_bx);
            this.groupPanel3.Controls.Add(this.label4);
            this.groupPanel3.Location = new System.Drawing.Point(485, 334);
            this.groupPanel3.Name = "groupPanel3";
            this.groupPanel3.Size = new System.Drawing.Size(276, 127);
            // 
            // 
            // 
            this.groupPanel3.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel3.Style.BackColorGradientAngle = 90;
            this.groupPanel3.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel3.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel3.Style.BorderBottomWidth = 1;
            this.groupPanel3.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel3.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel3.Style.BorderLeftWidth = 1;
            this.groupPanel3.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel3.Style.BorderRightWidth = 1;
            this.groupPanel3.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel3.Style.BorderTopWidth = 1;
            this.groupPanel3.Style.CornerDiameter = 4;
            this.groupPanel3.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel3.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel3.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel3.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            this.groupPanel3.TabIndex = 68;
            this.groupPanel3.Text = "مقاس";
            // 
            // a4_splited_rdbtn
            // 
            this.a4_splited_rdbtn.AutoSize = true;
            this.a4_splited_rdbtn.BackColor = System.Drawing.Color.Transparent;
            this.a4_splited_rdbtn.Checked = true;
            this.a4_splited_rdbtn.Location = new System.Drawing.Point(75, 3);
            this.a4_splited_rdbtn.Name = "a4_splited_rdbtn";
            this.a4_splited_rdbtn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.a4_splited_rdbtn.Size = new System.Drawing.Size(78, 23);
            this.a4_splited_rdbtn.TabIndex = 1;
            this.a4_splited_rdbtn.TabStop = true;
            this.a4_splited_rdbtn.Text = "A4 مقسم";
            this.a4_splited_rdbtn.UseVisualStyleBackColor = false;
            // 
            // a4_compl_rdbnt
            // 
            this.a4_compl_rdbnt.AutoSize = true;
            this.a4_compl_rdbnt.BackColor = System.Drawing.Color.Transparent;
            this.a4_compl_rdbnt.Location = new System.Drawing.Point(175, 3);
            this.a4_compl_rdbnt.Name = "a4_compl_rdbnt";
            this.a4_compl_rdbnt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.a4_compl_rdbnt.Size = new System.Drawing.Size(83, 23);
            this.a4_compl_rdbnt.TabIndex = 0;
            this.a4_compl_rdbnt.Text = "A4 صحيح";
            this.a4_compl_rdbnt.UseVisualStyleBackColor = false;
            // 
            // copy_n_bx
            // 
            this.copy_n_bx.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.copy_n_bx.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.copy_n_bx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.copy_n_bx.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copy_n_bx.Location = new System.Drawing.Point(13, 47);
            this.copy_n_bx.Name = "copy_n_bx";
            this.copy_n_bx.Size = new System.Drawing.Size(155, 35);
            this.copy_n_bx.TabIndex = 65;
            this.copy_n_bx.Text = "1";
            this.copy_n_bx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.copy_n_bx.TextChanged += new System.EventHandler(this.copy_n_bx_TextChanged);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(174, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 28);
            this.label4.TabIndex = 66;
            this.label4.Text = "عدد النسخ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bar_pic_num_bx
            // 
            this.bar_pic_num_bx.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bar_pic_num_bx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.bar_pic_num_bx.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bar_pic_num_bx.Location = new System.Drawing.Point(263, 16);
            this.bar_pic_num_bx.Maximum = new decimal(new int[] {
            144,
            0,
            0,
            0});
            this.bar_pic_num_bx.Name = "bar_pic_num_bx";
            this.bar_pic_num_bx.Size = new System.Drawing.Size(151, 32);
            this.bar_pic_num_bx.TabIndex = 67;
            this.bar_pic_num_bx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.bar_pic_num_bx.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.bar_pic_num_bx.KeyDown += new System.Windows.Forms.KeyEventHandler(this.bar_pic_num_bx_KeyDown);
            // 
            // exit_btn
            // 
            this.exit_btn.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.exit_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.exit_btn.BackColor = System.Drawing.Color.Transparent;
            this.exit_btn.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.exit_btn.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_btn.Image = ((System.Drawing.Image)(resources.GetObject("exit_btn.Image")));
            this.exit_btn.ImageFixedSize = new System.Drawing.Size(50, 50);
            this.exit_btn.Location = new System.Drawing.Point(3, 415);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(2);
            this.exit_btn.Size = new System.Drawing.Size(48, 50);
            this.exit_btn.TabIndex = 64;
            this.exit_btn.Tooltip = "خروج";
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // bar_prnt_btn
            // 
            this.bar_prnt_btn.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.bar_prnt_btn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bar_prnt_btn.BackColor = System.Drawing.Color.LightBlue;
            this.bar_prnt_btn.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.bar_prnt_btn.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bar_prnt_btn.Location = new System.Drawing.Point(324, 409);
            this.bar_prnt_btn.Name = "bar_prnt_btn";
            this.bar_prnt_btn.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(4);
            this.bar_prnt_btn.Size = new System.Drawing.Size(144, 51);
            this.bar_prnt_btn.TabIndex = 52;
            this.bar_prnt_btn.Text = "طباعه";
            this.bar_prnt_btn.Click += new System.EventHandler(this.bar_prnt_btn_Click);
            // 
            // show_bef_prnt_btn
            // 
            this.show_bef_prnt_btn.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.show_bef_prnt_btn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.show_bef_prnt_btn.BackColor = System.Drawing.Color.LightBlue;
            this.show_bef_prnt_btn.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.show_bef_prnt_btn.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.show_bef_prnt_btn.Location = new System.Drawing.Point(324, 344);
            this.show_bef_prnt_btn.Name = "show_bef_prnt_btn";
            this.show_bef_prnt_btn.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(4);
            this.show_bef_prnt_btn.Size = new System.Drawing.Size(144, 51);
            this.show_bef_prnt_btn.TabIndex = 51;
            this.show_bef_prnt_btn.Text = "معاينة قبل الطباعه";
            this.show_bef_prnt_btn.Click += new System.EventHandler(this.show_bef_prnt_btn_Click);
            // 
            // bar_save_btn
            // 
            this.bar_save_btn.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.bar_save_btn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bar_save_btn.BackColor = System.Drawing.Color.LightBlue;
            this.bar_save_btn.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.bar_save_btn.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bar_save_btn.Location = new System.Drawing.Point(455, 66);
            this.bar_save_btn.Name = "bar_save_btn";
            this.bar_save_btn.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(4);
            this.bar_save_btn.Size = new System.Drawing.Size(144, 56);
            this.bar_save_btn.TabIndex = 50;
            this.bar_save_btn.Text = "حفظ";
            this.bar_save_btn.Click += new System.EventHandler(this.bar_save_btn_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(779, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 26);
            this.label3.TabIndex = 49;
            this.label3.Text = "المطلوب طباعته";
            // 
            // bar_type_cmbx
            // 
            this.bar_type_cmbx.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bar_type_cmbx.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.bar_type_cmbx.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.bar_type_cmbx.DisplayMember = "Text";
            this.bar_type_cmbx.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.bar_type_cmbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bar_type_cmbx.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bar_type_cmbx.FormattingEnabled = true;
            this.bar_type_cmbx.ItemHeight = 26;
            this.bar_type_cmbx.Items.AddRange(new object[] {
            this.comboItem1,
            this.comboItem2});
            this.bar_type_cmbx.Location = new System.Drawing.Point(552, 16);
            this.bar_type_cmbx.Name = "bar_type_cmbx";
            this.bar_type_cmbx.Size = new System.Drawing.Size(223, 32);
            this.bar_type_cmbx.TabIndex = 48;
            this.bar_type_cmbx.SelectedIndexChanged += new System.EventHandler(this.bar_type_cmbx_SelectedIndexChanged);
            // 
            // comboItem1
            // 
            this.comboItem1.Text = "الصنف";
            // 
            // comboItem2
            // 
            this.comboItem2.Text = "التصنيف";
            // 
            // bar_grid
            // 
            this.bar_grid.AllowUserToAddRows = false;
            this.bar_grid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.bar_grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.bar_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bar_grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.bar_grid.DefaultCellStyle = dataGridViewCellStyle1;
            this.bar_grid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.bar_grid.Location = new System.Drawing.Point(3, 133);
            this.bar_grid.Name = "bar_grid";
            this.bar_grid.ReadOnly = true;
            this.bar_grid.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.bar_grid.Size = new System.Drawing.Size(1023, 192);
            this.bar_grid.TabIndex = 22;
            this.bar_grid.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.bar_grid_RowsRemoved);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "كود الصنف";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "اسم الصنف";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "عدد الصور";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(420, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 26);
            this.label1.TabIndex = 21;
            this.label1.Text = "عدد الصور";
            // 
            // barcode_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1039, 582);
            this.Controls.Add(this.groupPanel2);
            this.Controls.Add(this.groupPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "barcode_frm";
            this.Text = "طباعة باركود";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.barcode_frm_Load);
            this.groupPanel1.ResumeLayout(false);
            this.groupPanel1.PerformLayout();
            this.groupPanel2.ResumeLayout(false);
            this.groupPanel2.PerformLayout();
            this.groupPanel3.ResumeLayout(false);
            this.groupPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bar_pic_num_bx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bar_grid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox bar_sanf_cod_bx;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private System.Windows.Forms.TextBox bar_code_bx;
        private System.Windows.Forms.Label label2;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel2;
        private DevComponents.DotNetBar.Controls.DataGridViewX bar_grid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private DevComponents.DotNetBar.Controls.ComboBoxEx bar_tasn_name_cmbx;
        private System.Windows.Forms.Label label15;
        private DevComponents.DotNetBar.Controls.ComboBoxEx bar_sanf_name_cmbx;
        private System.Windows.Forms.Label label3;
        private DevComponents.DotNetBar.Controls.ComboBoxEx bar_type_cmbx;
        private DevComponents.Editors.ComboItem comboItem1;
        private DevComponents.DotNetBar.ButtonX bar_save_btn;
        private DevComponents.DotNetBar.ButtonX bar_prnt_btn;
        private DevComponents.DotNetBar.ButtonX show_bef_prnt_btn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private DevComponents.DotNetBar.ButtonX exit_btn;
        private System.Windows.Forms.TextBox copy_n_bx;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown bar_pic_num_bx;
        private DevComponents.Editors.ComboItem comboItem2;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel3;
        private System.Windows.Forms.RadioButton a4_splited_rdbtn;
        private System.Windows.Forms.RadioButton a4_compl_rdbnt;
    }
}