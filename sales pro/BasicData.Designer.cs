namespace sales_pro
{
    partial class BasicData
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
            this.ADDpanel = new System.Windows.Forms.Panel();
            this.CatBtn = new DevComponents.DotNetBar.ButtonX();
            this.ItemBtn = new DevComponents.DotNetBar.ButtonX();
            this.AgentBtn = new DevComponents.DotNetBar.ButtonX();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesDataSet)).BeginInit();
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
            // ADDpanel
            // 
            this.ADDpanel.Location = new System.Drawing.Point(0, 3);
            this.ADDpanel.Name = "ADDpanel";
            this.ADDpanel.Size = new System.Drawing.Size(859, 597);
            this.ADDpanel.TabIndex = 0;
            // 
            // CatBtn
            // 
            this.CatBtn.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.CatBtn.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.CatBtn.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CatBtn.Location = new System.Drawing.Point(865, 85);
            this.CatBtn.Name = "CatBtn";
            this.CatBtn.Size = new System.Drawing.Size(272, 58);
            this.CatBtn.TabIndex = 1;
            this.CatBtn.Text = "اضافة قسم";
            this.CatBtn.Click += new System.EventHandler(this.CatBtn_Click);
            // 
            // ItemBtn
            // 
            this.ItemBtn.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.ItemBtn.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.ItemBtn.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemBtn.Location = new System.Drawing.Point(865, 194);
            this.ItemBtn.Name = "ItemBtn";
            this.ItemBtn.Size = new System.Drawing.Size(272, 58);
            this.ItemBtn.TabIndex = 2;
            this.ItemBtn.Text = "اضافة صنف";
            this.ItemBtn.Click += new System.EventHandler(this.ItemBtn_Click);
            // 
            // AgentBtn
            // 
            this.AgentBtn.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.AgentBtn.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.AgentBtn.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgentBtn.Location = new System.Drawing.Point(865, 306);
            this.AgentBtn.Name = "AgentBtn";
            this.AgentBtn.Size = new System.Drawing.Size(272, 58);
            this.AgentBtn.TabIndex = 3;
            this.AgentBtn.Text = "اضافة مورد";
            this.AgentBtn.Click += new System.EventHandler(this.AgentBtn_Click);
            // 
            // BasicData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.AgentBtn);
            this.Controls.Add(this.ItemBtn);
            this.Controls.Add(this.CatBtn);
            this.Controls.Add(this.ADDpanel);
            this.Name = "BasicData";
            this.Size = new System.Drawing.Size(1140, 600);
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource categoryBindingSource;
        private salesDataSet salesDataSet;
        private salesDataSetTableAdapters.CategoryTableAdapter categoryTableAdapter;
        private System.Windows.Forms.Panel ADDpanel;
        private DevComponents.DotNetBar.ButtonX CatBtn;
        private DevComponents.DotNetBar.ButtonX ItemBtn;
        private DevComponents.DotNetBar.ButtonX AgentBtn;
    }
}
