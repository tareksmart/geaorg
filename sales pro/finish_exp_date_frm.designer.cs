namespace sales_pro
{
    partial class finish_exp_date_frm
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
            this.finish_ex_item_id_bx = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.finish_ex_item_name_bx = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cancel_btn = new DevComponents.DotNetBar.ButtonX();
            this.finish_btn = new DevComponents.DotNetBar.ButtonX();
            this.label4 = new System.Windows.Forms.Label();
            this.op_code_bx = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.finish_expire_date_bx = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // finish_ex_item_id_bx
            // 
            // 
            // 
            // 
            this.finish_ex_item_id_bx.Border.Class = "TextBoxBorder";
            this.finish_ex_item_id_bx.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finish_ex_item_id_bx.Location = new System.Drawing.Point(459, 28);
            this.finish_ex_item_id_bx.Name = "finish_ex_item_id_bx";
            this.finish_ex_item_id_bx.Size = new System.Drawing.Size(113, 26);
            this.finish_ex_item_id_bx.TabIndex = 0;
            this.finish_ex_item_id_bx.TextChanged += new System.EventHandler(this.finish_ex_item_id_bx_TextChanged);
            // 
            // finish_ex_item_name_bx
            // 
            // 
            // 
            // 
            this.finish_ex_item_name_bx.Border.Class = "TextBoxBorder";
            this.finish_ex_item_name_bx.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finish_ex_item_name_bx.Location = new System.Drawing.Point(194, 28);
            this.finish_ex_item_name_bx.Name = "finish_ex_item_name_bx";
            this.finish_ex_item_name_bx.Size = new System.Drawing.Size(192, 26);
            this.finish_ex_item_name_bx.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightGray;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(576, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightGray;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(390, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "اسم الدواء";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LightGray;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(110, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "تاريخ الانتهاء";
            // 
            // cancel_btn
            // 
            this.cancel_btn.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.cancel_btn.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb;
            this.cancel_btn.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel_btn.Location = new System.Drawing.Point(298, 76);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(99, 46);
            this.cancel_btn.TabIndex = 9;
            this.cancel_btn.Text = "الغاء";
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // finish_btn
            // 
            this.finish_btn.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.finish_btn.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb;
            this.finish_btn.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finish_btn.Location = new System.Drawing.Point(410, 76);
            this.finish_btn.Name = "finish_btn";
            this.finish_btn.Size = new System.Drawing.Size(99, 46);
            this.finish_btn.TabIndex = 8;
            this.finish_btn.Text = "انهاء";
            this.finish_btn.Click += new System.EventHandler(this.finish_btn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.LightGray;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(724, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 21);
            this.label4.TabIndex = 11;
            this.label4.Text = "كودالعملية";
            // 
            // op_code_bx
            // 
            // 
            // 
            // 
            this.op_code_bx.Border.Class = "TextBoxBorder";
            this.op_code_bx.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.op_code_bx.Location = new System.Drawing.Point(607, 28);
            this.op_code_bx.Name = "op_code_bx";
            this.op_code_bx.Size = new System.Drawing.Size(113, 26);
            this.op_code_bx.TabIndex = 10;
            // 
            // finish_expire_date_bx
            // 
            this.finish_expire_date_bx.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finish_expire_date_bx.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.finish_expire_date_bx.Location = new System.Drawing.Point(4, 28);
            this.finish_expire_date_bx.Name = "finish_expire_date_bx";
            this.finish_expire_date_bx.Size = new System.Drawing.Size(107, 26);
            this.finish_expire_date_bx.TabIndex = 12;
            // 
            // finish_exp_date_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 128);
            this.Controls.Add(this.finish_expire_date_bx);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.op_code_bx);
            this.Controls.Add(this.cancel_btn);
            this.Controls.Add(this.finish_btn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.finish_ex_item_name_bx);
            this.Controls.Add(this.finish_ex_item_id_bx);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "finish_exp_date_frm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "انهاء تحذير صلاحية صنف";
            this.Load += new System.EventHandler(this.finish_exp_date_frm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal DevComponents.DotNetBar.Controls.TextBoxX finish_ex_item_id_bx;
        internal DevComponents.DotNetBar.Controls.TextBoxX finish_ex_item_name_bx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private DevComponents.DotNetBar.ButtonX cancel_btn;
        private DevComponents.DotNetBar.ButtonX finish_btn;
        private System.Windows.Forms.Label label4;
        internal DevComponents.DotNetBar.Controls.TextBoxX op_code_bx;
        internal System.Windows.Forms.DateTimePicker finish_expire_date_bx;
    }
}