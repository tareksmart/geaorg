namespace sales_pro
{
    partial class expir_query_frm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(expir_query_frm));
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.company_nam_cmbx = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.day_num = new System.Windows.Forms.NumericUpDown();
            this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.finish_expire_all_item_btn = new DevComponents.DotNetBar.ButtonX();
            this.finish_expire_selected_item_btn = new DevComponents.DotNetBar.ButtonX();
            this.remain_kem_bx = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.expir_items_query_btn = new DevComponents.DotNetBar.ButtonX();
            this.item_expire_finish_btn = new DevComponents.DotNetBar.ButtonX();
            this.item_query_btn = new DevComponents.DotNetBar.ButtonX();
            this.label15 = new System.Windows.Forms.Label();
            this.k_it_id_bx = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.sels_q_grid = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.k_sanf_q_code_bx = new System.Windows.Forms.TextBox();
            this.k_sanf_nam_cmbx = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.k_tasn_nam_cmbx = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.label18 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.day_num)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sels_q_grid)).BeginInit();
            this.SuspendLayout();
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.VS2005;
            this.groupPanel1.Controls.Add(this.company_nam_cmbx);
            this.groupPanel1.Controls.Add(this.label4);
            this.groupPanel1.Controls.Add(this.label3);
            this.groupPanel1.Controls.Add(this.day_num);
            this.groupPanel1.Controls.Add(this.buttonX1);
            this.groupPanel1.Controls.Add(this.label2);
            this.groupPanel1.Controls.Add(this.label1);
            this.groupPanel1.Controls.Add(this.finish_expire_all_item_btn);
            this.groupPanel1.Controls.Add(this.finish_expire_selected_item_btn);
            this.groupPanel1.Controls.Add(this.remain_kem_bx);
            this.groupPanel1.Controls.Add(this.expir_items_query_btn);
            this.groupPanel1.Controls.Add(this.item_expire_finish_btn);
            this.groupPanel1.Controls.Add(this.item_query_btn);
            this.groupPanel1.Controls.Add(this.label15);
            this.groupPanel1.Controls.Add(this.k_it_id_bx);
            this.groupPanel1.Controls.Add(this.sels_q_grid);
            this.groupPanel1.Controls.Add(this.k_sanf_q_code_bx);
            this.groupPanel1.Controls.Add(this.k_sanf_nam_cmbx);
            this.groupPanel1.Controls.Add(this.k_tasn_nam_cmbx);
            this.groupPanel1.Controls.Add(this.label18);
            this.groupPanel1.Controls.Add(this.label5);
            this.groupPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupPanel1.Location = new System.Drawing.Point(0, 0);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(990, 593);
            // 
            // 
            // 
            this.groupPanel1.Style.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarCaptionBackground;
            this.groupPanel1.Style.BackColorGradientAngle = 90;
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
            // company_nam_cmbx
            // 
            this.company_nam_cmbx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.company_nam_cmbx.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.company_nam_cmbx.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.company_nam_cmbx.DisplayMember = "Text";
            this.company_nam_cmbx.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.company_nam_cmbx.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.company_nam_cmbx.FormattingEnabled = true;
            this.company_nam_cmbx.ItemHeight = 23;
            this.company_nam_cmbx.Location = new System.Drawing.Point(266, 104);
            this.company_nam_cmbx.Name = "company_nam_cmbx";
            this.company_nam_cmbx.Size = new System.Drawing.Size(151, 29);
            this.company_nam_cmbx.TabIndex = 124;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.BackColor = System.Drawing.Color.LightGray;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(420, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 21);
            this.label4.TabIndex = 123;
            this.label4.Text = "لشركة";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.BackColor = System.Drawing.Color.LightGray;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(475, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 24);
            this.label3.TabIndex = 122;
            this.label3.Text = "يوم";
            // 
            // day_num
            // 
            this.day_num.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.day_num.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.day_num.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.day_num.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.day_num.Location = new System.Drawing.Point(509, 102);
            this.day_num.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.day_num.Name = "day_num";
            this.day_num.Size = new System.Drawing.Size(120, 29);
            this.day_num.TabIndex = 121;
            this.day_num.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonX1
            // 
            this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonX1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonX1.Location = new System.Drawing.Point(642, 101);
            this.buttonX1.Name = "buttonX1";
            this.buttonX1.Size = new System.Drawing.Size(306, 38);
            this.buttonX1.TabIndex = 120;
            this.buttonX1.Text = "اصناف متبقى على صلاحيتها اقل من او يساوى";
            this.buttonX1.Click += new System.EventHandler(this.buttonX1_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.BackColor = System.Drawing.Color.LightGray;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(127, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 24);
            this.label2.TabIndex = 119;
            this.label2.Text = "المتبقى";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.LightGray;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(694, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 21);
            this.label1.TabIndex = 118;
            this.label1.Text = "ID";
            // 
            // finish_expire_all_item_btn
            // 
            this.finish_expire_all_item_btn.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.finish_expire_all_item_btn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finish_expire_all_item_btn.Location = new System.Drawing.Point(28, 193);
            this.finish_expire_all_item_btn.Name = "finish_expire_all_item_btn";
            this.finish_expire_all_item_btn.Size = new System.Drawing.Size(219, 39);
            this.finish_expire_all_item_btn.TabIndex = 117;
            this.finish_expire_all_item_btn.Text = "انهاء صلاحيات كل الاصناف فى الجدول";
            this.finish_expire_all_item_btn.Click += new System.EventHandler(this.finish_expire_all_item_btn_Click);
            // 
            // finish_expire_selected_item_btn
            // 
            this.finish_expire_selected_item_btn.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.finish_expire_selected_item_btn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finish_expire_selected_item_btn.Location = new System.Drawing.Point(259, 193);
            this.finish_expire_selected_item_btn.Name = "finish_expire_selected_item_btn";
            this.finish_expire_selected_item_btn.Size = new System.Drawing.Size(216, 39);
            this.finish_expire_selected_item_btn.TabIndex = 116;
            this.finish_expire_selected_item_btn.Text = "انهاء صلاحيات الاصناف المحدده فقط";
            this.finish_expire_selected_item_btn.Click += new System.EventHandler(this.finish_expire_selected_item_btn_Click);
            // 
            // remain_kem_bx
            // 
            this.remain_kem_bx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.remain_kem_bx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            // 
            // 
            // 
            this.remain_kem_bx.Border.Class = "TextBoxBorder";
            this.remain_kem_bx.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remain_kem_bx.Location = new System.Drawing.Point(28, 23);
            this.remain_kem_bx.Name = "remain_kem_bx";
            this.remain_kem_bx.ReadOnly = true;
            this.remain_kem_bx.Size = new System.Drawing.Size(94, 25);
            this.remain_kem_bx.TabIndex = 114;
            this.remain_kem_bx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // expir_items_query_btn
            // 
            this.expir_items_query_btn.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.expir_items_query_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.expir_items_query_btn.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expir_items_query_btn.Location = new System.Drawing.Point(642, 147);
            this.expir_items_query_btn.Name = "expir_items_query_btn";
            this.expir_items_query_btn.Size = new System.Drawing.Size(306, 38);
            this.expir_items_query_btn.TabIndex = 108;
            this.expir_items_query_btn.Text = "اصناف متبقى على صلاحيتها اقل من 3اشهر";
            this.expir_items_query_btn.Click += new System.EventHandler(this.expir_items_query_btn_Click);
            // 
            // item_expire_finish_btn
            // 
            this.item_expire_finish_btn.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.item_expire_finish_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.item_expire_finish_btn.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.item_expire_finish_btn.Location = new System.Drawing.Point(642, 194);
            this.item_expire_finish_btn.Name = "item_expire_finish_btn";
            this.item_expire_finish_btn.Size = new System.Drawing.Size(306, 38);
            this.item_expire_finish_btn.TabIndex = 113;
            this.item_expire_finish_btn.Text = "اصناف صلاحيتها انتهت";
            this.item_expire_finish_btn.Click += new System.EventHandler(this.item_expire_finish_btn_Click);
            // 
            // item_query_btn
            // 
            this.item_query_btn.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.item_query_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.item_query_btn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.item_query_btn.Location = new System.Drawing.Point(875, 17);
            this.item_query_btn.Name = "item_query_btn";
            this.item_query_btn.Size = new System.Drawing.Size(100, 38);
            this.item_query_btn.TabIndex = 107;
            this.item_query_btn.Text = "صلاحية الصنف";
            this.item_query_btn.Click += new System.EventHandler(this.item_query_btn_Click);
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.BackColor = System.Drawing.Color.LightGray;
            this.label15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label15.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Blue;
            this.label15.Location = new System.Drawing.Point(380, 23);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(40, 24);
            this.label15.TabIndex = 93;
            this.label15.Text = "الصنف";
            // 
            // k_it_id_bx
            // 
            this.k_it_id_bx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.k_it_id_bx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            // 
            // 
            // 
            this.k_it_id_bx.Border.Class = "TextBoxBorder";
            this.k_it_id_bx.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.k_it_id_bx.Location = new System.Drawing.Point(601, 23);
            this.k_it_id_bx.Name = "k_it_id_bx";
            this.k_it_id_bx.ReadOnly = true;
            this.k_it_id_bx.Size = new System.Drawing.Size(88, 25);
            this.k_it_id_bx.TabIndex = 110;
            this.k_it_id_bx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.k_it_id_bx.TextChanged += new System.EventHandler(this.k_it_id_bx_TextChanged);
            // 
            // sels_q_grid
            // 
            this.sels_q_grid.AllowUserToAddRows = false;
            this.sels_q_grid.AllowUserToDeleteRows = false;
            this.sels_q_grid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.sels_q_grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.sels_q_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.sels_q_grid.DefaultCellStyle = dataGridViewCellStyle1;
            this.sels_q_grid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.sels_q_grid.Location = new System.Drawing.Point(2, 244);
            this.sels_q_grid.Name = "sels_q_grid";
            this.sels_q_grid.ReadOnly = true;
            this.sels_q_grid.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.sels_q_grid.Size = new System.Drawing.Size(979, 343);
            this.sels_q_grid.TabIndex = 109;
            this.sels_q_grid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.sels_q_grid_CellContentClick);
            this.sels_q_grid.DoubleClick += new System.EventHandler(this.sels_q_grid_DoubleClick);
            this.sels_q_grid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.sels_q_grid_KeyDown);
            // 
            // k_sanf_q_code_bx
            // 
            this.k_sanf_q_code_bx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.k_sanf_q_code_bx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.k_sanf_q_code_bx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.k_sanf_q_code_bx.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.k_sanf_q_code_bx.ForeColor = System.Drawing.SystemColors.MenuText;
            this.k_sanf_q_code_bx.Location = new System.Drawing.Point(720, 22);
            this.k_sanf_q_code_bx.MaxLength = 13;
            this.k_sanf_q_code_bx.Name = "k_sanf_q_code_bx";
            this.k_sanf_q_code_bx.Size = new System.Drawing.Size(88, 26);
            this.k_sanf_q_code_bx.TabIndex = 102;
            this.k_sanf_q_code_bx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.k_sanf_q_code_bx.TextChanged += new System.EventHandler(this.k_sanf_q_code_bx_TextChanged);
            this.k_sanf_q_code_bx.KeyDown += new System.Windows.Forms.KeyEventHandler(this.k_sanf_q_code_bx_KeyDown);
            // 
            // k_sanf_nam_cmbx
            // 
            this.k_sanf_nam_cmbx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.k_sanf_nam_cmbx.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.k_sanf_nam_cmbx.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.k_sanf_nam_cmbx.DisplayMember = "Text";
            this.k_sanf_nam_cmbx.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.k_sanf_nam_cmbx.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.k_sanf_nam_cmbx.FormattingEnabled = true;
            this.k_sanf_nam_cmbx.ItemHeight = 19;
            this.k_sanf_nam_cmbx.Location = new System.Drawing.Point(176, 23);
            this.k_sanf_nam_cmbx.Name = "k_sanf_nam_cmbx";
            this.k_sanf_nam_cmbx.Size = new System.Drawing.Size(204, 25);
            this.k_sanf_nam_cmbx.TabIndex = 105;
            this.k_sanf_nam_cmbx.SelectedIndexChanged += new System.EventHandler(this.k_sanf_nam_cmbx_SelectedIndexChanged);
            this.k_sanf_nam_cmbx.DropDownClosed += new System.EventHandler(this.k_sanf_nam_cmbx_DropDownClosed);
            this.k_sanf_nam_cmbx.KeyDown += new System.Windows.Forms.KeyEventHandler(this.k_sanf_nam_cmbx_KeyDown);
            // 
            // k_tasn_nam_cmbx
            // 
            this.k_tasn_nam_cmbx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.k_tasn_nam_cmbx.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.k_tasn_nam_cmbx.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.k_tasn_nam_cmbx.DisplayMember = "Text";
            this.k_tasn_nam_cmbx.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.k_tasn_nam_cmbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.k_tasn_nam_cmbx.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.k_tasn_nam_cmbx.FormattingEnabled = true;
            this.k_tasn_nam_cmbx.ItemHeight = 19;
            this.k_tasn_nam_cmbx.Location = new System.Drawing.Point(422, 23);
            this.k_tasn_nam_cmbx.Name = "k_tasn_nam_cmbx";
            this.k_tasn_nam_cmbx.Size = new System.Drawing.Size(123, 25);
            this.k_tasn_nam_cmbx.TabIndex = 104;
            this.k_tasn_nam_cmbx.SelectedIndexChanged += new System.EventHandler(this.k_tasn_nam_cmbx_SelectedIndexChanged);
            this.k_tasn_nam_cmbx.DropDownClosed += new System.EventHandler(this.k_tasn_nam_cmbx_DropDownClosed);
            this.k_tasn_nam_cmbx.KeyDown += new System.Windows.Forms.KeyEventHandler(this.k_tasn_nam_cmbx_KeyDown);
            // 
            // label18
            // 
            this.label18.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label18.BackColor = System.Drawing.Color.LightGray;
            this.label18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label18.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label18.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.Blue;
            this.label18.Location = new System.Drawing.Point(813, 23);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(60, 24);
            this.label18.TabIndex = 106;
            this.label18.Text = "ادخال الكود";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.BackColor = System.Drawing.Color.LightGray;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(550, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 21);
            this.label5.TabIndex = 103;
            this.label5.Text = "التصنيف";
            // 
            // expir_query_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 593);
            this.Controls.Add(this.groupPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "expir_query_frm";
            this.Text = " الاستعلام عن صلاحيات الادوية";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.expir_query_frm_Load);
            this.groupPanel1.ResumeLayout(false);
            this.groupPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.day_num)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sels_q_grid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.Controls.TextBoxX k_it_id_bx;
        private DevComponents.DotNetBar.Controls.DataGridViewX sels_q_grid;
        private DevComponents.DotNetBar.ButtonX expir_items_query_btn;
        private DevComponents.DotNetBar.ButtonX item_query_btn;
        private System.Windows.Forms.TextBox k_sanf_q_code_bx;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label5;
        private DevComponents.DotNetBar.Controls.ComboBoxEx k_tasn_nam_cmbx;
        private DevComponents.DotNetBar.Controls.ComboBoxEx k_sanf_nam_cmbx;
        private System.Windows.Forms.Label label15;
        private DevComponents.DotNetBar.ButtonX item_expire_finish_btn;
        private DevComponents.DotNetBar.Controls.TextBoxX remain_kem_bx;
        private DevComponents.DotNetBar.ButtonX finish_expire_all_item_btn;
        private DevComponents.DotNetBar.ButtonX finish_expire_selected_item_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevComponents.DotNetBar.Controls.ComboBoxEx company_nam_cmbx;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown day_num;
        private DevComponents.DotNetBar.ButtonX buttonX1;
    }
}