namespace sales_pro
{
    partial class Discount_agent
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
            this.confirm_btn = new DevComponents.DotNetBar.ButtonX();
            this.label18 = new System.Windows.Forms.Label();
            this.mony_ref_ag_bx = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // confirm_btn
            // 
            this.confirm_btn.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.confirm_btn.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.confirm_btn.Location = new System.Drawing.Point(75, 64);
            this.confirm_btn.Name = "confirm_btn";
            this.confirm_btn.Size = new System.Drawing.Size(108, 30);
            this.confirm_btn.TabIndex = 24;
            this.confirm_btn.Text = "تاكيد";
            this.confirm_btn.Click += new System.EventHandler(this.confirm_btn_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label18.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label18.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(202, 24);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(42, 21);
            this.label18.TabIndex = 23;
            this.label18.Text = "المبلغ";
            // 
            // mony_ref_ag_bx
            // 
            this.mony_ref_ag_bx.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.mony_ref_ag_bx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mony_ref_ag_bx.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mony_ref_ag_bx.Location = new System.Drawing.Point(40, 20);
            this.mony_ref_ag_bx.Name = "mony_ref_ag_bx";
            this.mony_ref_ag_bx.Size = new System.Drawing.Size(158, 29);
            this.mony_ref_ag_bx.TabIndex = 22;
            this.mony_ref_ag_bx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mony_ref_ag_bx.TextChanged += new System.EventHandler(this.mony_ref_ag_bx_TextChanged);
            // 
            // Discount_agent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 107);
            this.Controls.Add(this.confirm_btn);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.mony_ref_ag_bx);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Discount_agent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Discount_agent";
            this.Load += new System.EventHandler(this.Discount_agent_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX confirm_btn;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox mony_ref_ag_bx;
    }
}