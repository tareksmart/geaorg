namespace sales_pro
{
    partial class AgentBD
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
            this.AgentEXPanel = new DevComponents.DotNetBar.ExpandablePanel();
            this.label1 = new System.Windows.Forms.Label();
            this.AgentCB = new System.Windows.Forms.ComboBox();
            this.agentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.agentDS = new sales_pro.AgentDS();
            this.label19 = new System.Windows.Forms.Label();
            this.AgentNotesTB = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.AgentAddrTB = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.AgentTeleNoTB = new System.Windows.Forms.TextBox();
            this.AgentClearBtn = new DevComponents.DotNetBar.ButtonX();
            this.AgentUpdateBtn = new DevComponents.DotNetBar.ButtonX();
            this.AgentInsertBtn = new DevComponents.DotNetBar.ButtonX();
            this.AgentNameLabel = new System.Windows.Forms.Label();
            this.AgentNameTB = new System.Windows.Forms.TextBox();
            this.AgColabel = new System.Windows.Forms.Label();
            this.AgentIdTB = new System.Windows.Forms.TextBox();
            this.agentTableAdapter = new sales_pro.AgentDSTableAdapters.AgentTableAdapter();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.AgentEXPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.agentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agentDS)).BeginInit();
            this.groupPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AgentEXPanel
            // 
            this.AgentEXPanel.CanvasColor = System.Drawing.SystemColors.Control;
            this.AgentEXPanel.CollapseDirection = DevComponents.DotNetBar.eCollapseDirection.RightToLeft;
            this.AgentEXPanel.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.AgentEXPanel.Controls.Add(this.label1);
            this.AgentEXPanel.Controls.Add(this.AgentCB);
            this.AgentEXPanel.Expanded = false;
            this.AgentEXPanel.ExpandedBounds = new System.Drawing.Rectangle(3, 3, 371, 164);
            this.AgentEXPanel.ExpandOnTitleClick = true;
            this.AgentEXPanel.Location = new System.Drawing.Point(3, 3);
            this.AgentEXPanel.Name = "AgentEXPanel";
            this.AgentEXPanel.Size = new System.Drawing.Size(30, 164);
            this.AgentEXPanel.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.AgentEXPanel.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.AgentEXPanel.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.AgentEXPanel.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.AgentEXPanel.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.AgentEXPanel.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.AgentEXPanel.Style.GradientAngle = 90;
            this.AgentEXPanel.TabIndex = 44;
            this.AgentEXPanel.TitleStyle.Alignment = System.Drawing.StringAlignment.Center;
            this.AgentEXPanel.TitleStyle.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.AgentEXPanel.TitleStyle.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.AgentEXPanel.TitleStyle.Border = DevComponents.DotNetBar.eBorderType.RaisedInner;
            this.AgentEXPanel.TitleStyle.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.AgentEXPanel.TitleStyle.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.AgentEXPanel.TitleStyle.GradientAngle = 90;
            this.AgentEXPanel.TitleText = "الاستعلام عن عميل";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(273, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 24);
            this.label1.TabIndex = 40;
            this.label1.Text = "اسم العميل";
            // 
            // AgentCB
            // 
            this.AgentCB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.AgentCB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.AgentCB.DataSource = this.agentBindingSource;
            this.AgentCB.DisplayMember = "AgentName";
            this.AgentCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AgentCB.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgentCB.FormattingEnabled = true;
            this.AgentCB.Location = new System.Drawing.Point(4, 65);
            this.AgentCB.Name = "AgentCB";
            this.AgentCB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.AgentCB.Size = new System.Drawing.Size(262, 29);
            this.AgentCB.TabIndex = 39;
            this.AgentCB.ValueMember = "AgentId";
            this.AgentCB.SelectedValueChanged += new System.EventHandler(this.AgentCB_SelectedIndexChanged);
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
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label19.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label19.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.White;
            this.label19.Location = new System.Drawing.Point(728, 370);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(85, 28);
            this.label19.TabIndex = 43;
            this.label19.Text = "ملاحظات";
            // 
            // AgentNotesTB
            // 
            this.AgentNotesTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.AgentNotesTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AgentNotesTB.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgentNotesTB.Location = new System.Drawing.Point(139, 365);
            this.AgentNotesTB.MaxLength = 50;
            this.AgentNotesTB.Multiline = true;
            this.AgentNotesTB.Name = "AgentNotesTB";
            this.AgentNotesTB.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.AgentNotesTB.Size = new System.Drawing.Size(577, 55);
            this.AgentNotesTB.TabIndex = 36;
            this.AgentNotesTB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AgentNotesTB_KeyDown);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label18.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label18.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(728, 312);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(70, 28);
            this.label18.TabIndex = 41;
            this.label18.Text = "العنوان";
            // 
            // AgentAddrTB
            // 
            this.AgentAddrTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.AgentAddrTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AgentAddrTB.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgentAddrTB.Location = new System.Drawing.Point(139, 308);
            this.AgentAddrTB.MaxLength = 50;
            this.AgentAddrTB.Name = "AgentAddrTB";
            this.AgentAddrTB.Size = new System.Drawing.Size(577, 35);
            this.AgentAddrTB.TabIndex = 35;
            this.AgentAddrTB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AgentAddrTB_KeyDown);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label17.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label17.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(728, 250);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(66, 28);
            this.label17.TabIndex = 39;
            this.label17.Text = "تليفون";
            // 
            // AgentTeleNoTB
            // 
            this.AgentTeleNoTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.AgentTeleNoTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AgentTeleNoTB.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgentTeleNoTB.Location = new System.Drawing.Point(139, 241);
            this.AgentTeleNoTB.MaxLength = 13;
            this.AgentTeleNoTB.Name = "AgentTeleNoTB";
            this.AgentTeleNoTB.Size = new System.Drawing.Size(577, 35);
            this.AgentTeleNoTB.TabIndex = 34;
            this.AgentTeleNoTB.TextChanged += new System.EventHandler(this.AgentTeleNoTB_TextChanged);
            this.AgentTeleNoTB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AgentTeleNoTB_KeyDown);
            // 
            // AgentClearBtn
            // 
            this.AgentClearBtn.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.AgentClearBtn.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.AgentClearBtn.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgentClearBtn.Location = new System.Drawing.Point(206, 462);
            this.AgentClearBtn.Name = "AgentClearBtn";
            this.AgentClearBtn.Size = new System.Drawing.Size(130, 64);
            this.AgentClearBtn.TabIndex = 38;
            this.AgentClearBtn.Text = "مسح";
            this.AgentClearBtn.Click += new System.EventHandler(this.AgentClearBtn_Click);
            // 
            // AgentUpdateBtn
            // 
            this.AgentUpdateBtn.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.AgentUpdateBtn.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.AgentUpdateBtn.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgentUpdateBtn.Location = new System.Drawing.Point(372, 462);
            this.AgentUpdateBtn.Name = "AgentUpdateBtn";
            this.AgentUpdateBtn.Size = new System.Drawing.Size(130, 64);
            this.AgentUpdateBtn.TabIndex = 37;
            this.AgentUpdateBtn.Text = "تعديل";
            this.AgentUpdateBtn.Click += new System.EventHandler(this.AgentUpdateBtn_Click);
            // 
            // AgentInsertBtn
            // 
            this.AgentInsertBtn.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.AgentInsertBtn.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.AgentInsertBtn.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgentInsertBtn.Location = new System.Drawing.Point(539, 462);
            this.AgentInsertBtn.Name = "AgentInsertBtn";
            this.AgentInsertBtn.Size = new System.Drawing.Size(130, 64);
            this.AgentInsertBtn.TabIndex = 36;
            this.AgentInsertBtn.Text = "جديد";
            this.AgentInsertBtn.Click += new System.EventHandler(this.AgentInsertBtn_Click);
            // 
            // AgentNameLabel
            // 
            this.AgentNameLabel.AutoSize = true;
            this.AgentNameLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.AgentNameLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AgentNameLabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.AgentNameLabel.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgentNameLabel.ForeColor = System.Drawing.Color.White;
            this.AgentNameLabel.Location = new System.Drawing.Point(728, 178);
            this.AgentNameLabel.Name = "AgentNameLabel";
            this.AgentNameLabel.Size = new System.Drawing.Size(97, 28);
            this.AgentNameLabel.TabIndex = 34;
            this.AgentNameLabel.Text = "اسم العميل";
            // 
            // AgentNameTB
            // 
            this.AgentNameTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.AgentNameTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AgentNameTB.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgentNameTB.Location = new System.Drawing.Point(139, 174);
            this.AgentNameTB.MaxLength = 50;
            this.AgentNameTB.Name = "AgentNameTB";
            this.AgentNameTB.Size = new System.Drawing.Size(577, 35);
            this.AgentNameTB.TabIndex = 33;
            this.AgentNameTB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AgentNameTB_KeyDown);
            // 
            // AgColabel
            // 
            this.AgColabel.AutoSize = true;
            this.AgColabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.AgColabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AgColabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.AgColabel.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgColabel.ForeColor = System.Drawing.Color.White;
            this.AgColabel.Location = new System.Drawing.Point(728, 118);
            this.AgColabel.Name = "AgColabel";
            this.AgColabel.Size = new System.Drawing.Size(90, 28);
            this.AgColabel.TabIndex = 32;
            this.AgColabel.Text = "كودالعميل";
            // 
            // AgentIdTB
            // 
            this.AgentIdTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.AgentIdTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AgentIdTB.Enabled = false;
            this.AgentIdTB.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgentIdTB.Location = new System.Drawing.Point(139, 114);
            this.AgentIdTB.Name = "AgentIdTB";
            this.AgentIdTB.Size = new System.Drawing.Size(577, 35);
            this.AgentIdTB.TabIndex = 31;
            // 
            // agentTableAdapter
            // 
            this.agentTableAdapter.ClearBeforeFill = true;
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.AgentEXPanel);
            this.groupPanel1.Controls.Add(this.AgentIdTB);
            this.groupPanel1.Controls.Add(this.AgColabel);
            this.groupPanel1.Controls.Add(this.label19);
            this.groupPanel1.Controls.Add(this.AgentNameTB);
            this.groupPanel1.Controls.Add(this.AgentNotesTB);
            this.groupPanel1.Controls.Add(this.AgentNameLabel);
            this.groupPanel1.Controls.Add(this.label18);
            this.groupPanel1.Controls.Add(this.AgentInsertBtn);
            this.groupPanel1.Controls.Add(this.AgentAddrTB);
            this.groupPanel1.Controls.Add(this.AgentUpdateBtn);
            this.groupPanel1.Controls.Add(this.label17);
            this.groupPanel1.Controls.Add(this.AgentClearBtn);
            this.groupPanel1.Controls.Add(this.AgentTeleNoTB);
            this.groupPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupPanel1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupPanel1.IsShadowEnabled = true;
            this.groupPanel1.Location = new System.Drawing.Point(0, 0);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(970, 571);
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
            this.groupPanel1.TabIndex = 45;
            this.groupPanel1.Click += new System.EventHandler(this.groupPanel1_Click);
            // 
            // AgentBD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.groupPanel1);
            this.Name = "AgentBD";
            this.Size = new System.Drawing.Size(970, 571);
            this.Load += new System.EventHandler(this.AgentBD_Load);
            this.AgentEXPanel.ResumeLayout(false);
            this.AgentEXPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.agentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agentDS)).EndInit();
            this.groupPanel1.ResumeLayout(false);
            this.groupPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ExpandablePanel AgentEXPanel;
        public System.Windows.Forms.ComboBox AgentCB;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox AgentNotesTB;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox AgentAddrTB;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox AgentTeleNoTB;
        private DevComponents.DotNetBar.ButtonX AgentClearBtn;
        private DevComponents.DotNetBar.ButtonX AgentUpdateBtn;
        private DevComponents.DotNetBar.ButtonX AgentInsertBtn;
        private System.Windows.Forms.Label AgentNameLabel;
        private System.Windows.Forms.TextBox AgentNameTB;
        private System.Windows.Forms.Label AgColabel;
        private System.Windows.Forms.TextBox AgentIdTB;
        private System.Windows.Forms.BindingSource agentBindingSource;
        private AgentDS agentDS;
        private AgentDSTableAdapters.AgentTableAdapter agentTableAdapter;
        private System.Windows.Forms.Label label1;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
    }
}
