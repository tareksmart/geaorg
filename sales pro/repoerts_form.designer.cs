namespace sales_pro
{
    partial class repoerts_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(repoerts_form));
            this.rep_crst = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // rep_crst
            // 
            this.rep_crst.ActiveViewIndex = -1;
            this.rep_crst.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rep_crst.Cursor = System.Windows.Forms.Cursors.Default;
            this.rep_crst.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rep_crst.Location = new System.Drawing.Point(0, 0);
            this.rep_crst.Name = "rep_crst";
            this.rep_crst.ReuseParameterValuesOnRefresh = true;
            this.rep_crst.ShowGroupTreeButton = false;
            this.rep_crst.Size = new System.Drawing.Size(658, 383);
            this.rep_crst.TabIndex = 0;
            this.rep_crst.Load += new System.EventHandler(this.rep_crst_Load);
            this.rep_crst.Click += new System.EventHandler(this.rep_crst_Click);
            // 
            // repoerts_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 383);
            this.Controls.Add(this.rep_crst);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "repoerts_form";
            this.Text = "Repoerts";
            this.Load += new System.EventHandler(this.repoerts_form_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public CrystalDecisions.Windows.Forms.CrystalReportViewer rep_crst;
    }
}