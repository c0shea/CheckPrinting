namespace CheckPrinting
{
    partial class Main
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPay = new System.Windows.Forms.TabPage();
            this.tabEndorse = new System.Windows.Forms.TabPage();
            this.lblDate = new System.Windows.Forms.Label();
            this.txtPayToTheOrderOf = new System.Windows.Forms.TextBox();
            this.lblPayToTheOrderOf = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.txtMemo = new System.Windows.Forms.TextBox();
            this.lblMemo = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtLogicalName = new System.Windows.Forms.TextBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnEndorse = new System.Windows.Forms.Button();
            this.txtEndorsement = new System.Windows.Forms.TextBox();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.tabControl1.SuspendLayout();
            this.tabPay.SuspendLayout();
            this.tabEndorse.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPay);
            this.tabControl1.Controls.Add(this.tabEndorse);
            this.tabControl1.Location = new System.Drawing.Point(16, 57);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(428, 248);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPay
            // 
            this.tabPay.Controls.Add(this.datePicker);
            this.tabPay.Controls.Add(this.btnPrint);
            this.tabPay.Controls.Add(this.txtMemo);
            this.tabPay.Controls.Add(this.lblMemo);
            this.tabPay.Controls.Add(this.txtAmount);
            this.tabPay.Controls.Add(this.lblAmount);
            this.tabPay.Controls.Add(this.txtPayToTheOrderOf);
            this.tabPay.Controls.Add(this.lblPayToTheOrderOf);
            this.tabPay.Controls.Add(this.lblDate);
            this.tabPay.Location = new System.Drawing.Point(4, 29);
            this.tabPay.Name = "tabPay";
            this.tabPay.Padding = new System.Windows.Forms.Padding(3);
            this.tabPay.Size = new System.Drawing.Size(420, 215);
            this.tabPay.TabIndex = 0;
            this.tabPay.Text = "Pay";
            this.tabPay.UseVisualStyleBackColor = true;
            // 
            // tabEndorse
            // 
            this.tabEndorse.Controls.Add(this.txtEndorsement);
            this.tabEndorse.Controls.Add(this.btnEndorse);
            this.tabEndorse.Location = new System.Drawing.Point(4, 29);
            this.tabEndorse.Name = "tabEndorse";
            this.tabEndorse.Padding = new System.Windows.Forms.Padding(3);
            this.tabEndorse.Size = new System.Drawing.Size(420, 215);
            this.tabEndorse.TabIndex = 1;
            this.tabEndorse.Text = "Endorse";
            this.tabEndorse.UseVisualStyleBackColor = true;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(6, 11);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(44, 20);
            this.lblDate.TabIndex = 0;
            this.lblDate.Text = "Date:";
            // 
            // txtPayToTheOrderOf
            // 
            this.txtPayToTheOrderOf.Location = new System.Drawing.Point(105, 56);
            this.txtPayToTheOrderOf.MaxLength = 120;
            this.txtPayToTheOrderOf.Name = "txtPayToTheOrderOf";
            this.txtPayToTheOrderOf.Size = new System.Drawing.Size(302, 27);
            this.txtPayToTheOrderOf.TabIndex = 3;
            // 
            // lblPayToTheOrderOf
            // 
            this.lblPayToTheOrderOf.AutoSize = true;
            this.lblPayToTheOrderOf.Location = new System.Drawing.Point(6, 45);
            this.lblPayToTheOrderOf.Name = "lblPayToTheOrderOf";
            this.lblPayToTheOrderOf.Size = new System.Drawing.Size(91, 40);
            this.lblPayToTheOrderOf.TabIndex = 2;
            this.lblPayToTheOrderOf.Text = "Pay to\r\nthe order of:";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(105, 92);
            this.txtAmount.MaxLength = 14;
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(132, 27);
            this.txtAmount.TabIndex = 5;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(6, 95);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(65, 20);
            this.lblAmount.TabIndex = 4;
            this.lblAmount.Text = "Amount:";
            // 
            // txtMemo
            // 
            this.txtMemo.Location = new System.Drawing.Point(105, 125);
            this.txtMemo.MaxLength = 100;
            this.txtMemo.Name = "txtMemo";
            this.txtMemo.Size = new System.Drawing.Size(302, 27);
            this.txtMemo.TabIndex = 7;
            // 
            // lblMemo
            // 
            this.lblMemo.AutoSize = true;
            this.lblMemo.Location = new System.Drawing.Point(6, 128);
            this.lblMemo.Name = "lblMemo";
            this.lblMemo.Size = new System.Drawing.Size(55, 20);
            this.lblMemo.TabIndex = 6;
            this.lblMemo.Text = "Memo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Logical Name:";
            // 
            // txtLogicalName
            // 
            this.txtLogicalName.Location = new System.Drawing.Point(135, 12);
            this.txtLogicalName.MaxLength = 1000;
            this.txtLogicalName.Name = "txtLogicalName";
            this.txtLogicalName.Size = new System.Drawing.Size(292, 27);
            this.txtLogicalName.TabIndex = 2;
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.SteelBlue;
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Location = new System.Drawing.Point(143, 167);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(134, 36);
            this.btnPrint.TabIndex = 8;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = false;
            // 
            // btnEndorse
            // 
            this.btnEndorse.BackColor = System.Drawing.Color.SteelBlue;
            this.btnEndorse.FlatAppearance.BorderSize = 0;
            this.btnEndorse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEndorse.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEndorse.ForeColor = System.Drawing.Color.White;
            this.btnEndorse.Location = new System.Drawing.Point(142, 161);
            this.btnEndorse.Name = "btnEndorse";
            this.btnEndorse.Size = new System.Drawing.Size(134, 36);
            this.btnEndorse.TabIndex = 9;
            this.btnEndorse.Text = "Endorse";
            this.btnEndorse.UseVisualStyleBackColor = false;
            // 
            // txtEndorsement
            // 
            this.txtEndorsement.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEndorsement.Location = new System.Drawing.Point(58, 31);
            this.txtEndorsement.Multiline = true;
            this.txtEndorsement.Name = "txtEndorsement";
            this.txtEndorsement.Size = new System.Drawing.Size(316, 66);
            this.txtEndorsement.TabIndex = 10;
            // 
            // datePicker
            // 
            this.datePicker.CustomFormat = "MM/dd/yyyy";
            this.datePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datePicker.Location = new System.Drawing.Point(105, 6);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(132, 27);
            this.datePicker.TabIndex = 9;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(457, 321);
            this.Controls.Add(this.txtLogicalName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Main";
            this.Text = "Check Printing";
            this.Load += new System.EventHandler(this.Main_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPay.ResumeLayout(false);
            this.tabPay.PerformLayout();
            this.tabEndorse.ResumeLayout(false);
            this.tabEndorse.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPay;
        private System.Windows.Forms.TabPage tabEndorse;
        private System.Windows.Forms.TextBox txtMemo;
        private System.Windows.Forms.Label lblMemo;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.TextBox txtPayToTheOrderOf;
        private System.Windows.Forms.Label lblPayToTheOrderOf;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtLogicalName;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnEndorse;
        private System.Windows.Forms.TextBox txtEndorsement;
        private System.Windows.Forms.DateTimePicker datePicker;
    }
}

