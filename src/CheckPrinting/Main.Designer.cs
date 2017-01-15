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
            this.components = new System.ComponentModel.Container();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPayee = new System.Windows.Forms.TabPage();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.btnPrint = new System.Windows.Forms.Button();
            this.txtMemo = new System.Windows.Forms.TextBox();
            this.lblMemo = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.txtPayToTheOrderOf = new System.Windows.Forms.TextBox();
            this.lblPayToTheOrderOf = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.tabEndorse = new System.Windows.Forms.TabPage();
            this.txtEndorsement = new System.Windows.Forms.TextBox();
            this.btnEndorse = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtLogicalName = new System.Windows.Forms.TextBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblStatus = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.tabPayee.SuspendLayout();
            this.tabEndorse.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tabPayee);
            this.tabControl.Controls.Add(this.tabEndorse);
            this.tabControl.Location = new System.Drawing.Point(16, 57);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(428, 248);
            this.tabControl.TabIndex = 0;
            // 
            // tabPayee
            // 
            this.tabPayee.Controls.Add(this.datePicker);
            this.tabPayee.Controls.Add(this.btnPrint);
            this.tabPayee.Controls.Add(this.txtMemo);
            this.tabPayee.Controls.Add(this.lblMemo);
            this.tabPayee.Controls.Add(this.txtAmount);
            this.tabPayee.Controls.Add(this.lblAmount);
            this.tabPayee.Controls.Add(this.txtPayToTheOrderOf);
            this.tabPayee.Controls.Add(this.lblPayToTheOrderOf);
            this.tabPayee.Controls.Add(this.lblDate);
            this.tabPayee.Location = new System.Drawing.Point(4, 29);
            this.tabPayee.Name = "tabPayee";
            this.tabPayee.Padding = new System.Windows.Forms.Padding(3);
            this.tabPayee.Size = new System.Drawing.Size(420, 215);
            this.tabPayee.TabIndex = 0;
            this.tabPayee.Text = "Payee";
            this.tabPayee.UseVisualStyleBackColor = true;
            // 
            // datePicker
            // 
            this.datePicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.datePicker.CustomFormat = "MM/dd/yyyy";
            this.datePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datePicker.Location = new System.Drawing.Point(105, 6);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(132, 27);
            this.datePicker.TabIndex = 0;
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.BackColor = System.Drawing.Color.SteelBlue;
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Location = new System.Drawing.Point(143, 167);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(134, 36);
            this.btnPrint.TabIndex = 4;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // txtMemo
            // 
            this.txtMemo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMemo.Location = new System.Drawing.Point(105, 125);
            this.txtMemo.MaxLength = 24;
            this.txtMemo.Name = "txtMemo";
            this.txtMemo.Size = new System.Drawing.Size(292, 27);
            this.txtMemo.TabIndex = 3;
            // 
            // lblMemo
            // 
            this.lblMemo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMemo.AutoSize = true;
            this.lblMemo.Location = new System.Drawing.Point(6, 128);
            this.lblMemo.Name = "lblMemo";
            this.lblMemo.Size = new System.Drawing.Size(55, 20);
            this.lblMemo.TabIndex = 6;
            this.lblMemo.Text = "Memo:";
            // 
            // txtAmount
            // 
            this.txtAmount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAmount.Location = new System.Drawing.Point(105, 92);
            this.txtAmount.MaxLength = 10;
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(132, 27);
            this.txtAmount.TabIndex = 2;
            this.txtAmount.TextChanged += new System.EventHandler(this.txtAmount_TextChanged);
            // 
            // lblAmount
            // 
            this.lblAmount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(6, 95);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(65, 20);
            this.lblAmount.TabIndex = 4;
            this.lblAmount.Text = "Amount:";
            // 
            // txtPayToTheOrderOf
            // 
            this.txtPayToTheOrderOf.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPayToTheOrderOf.Location = new System.Drawing.Point(105, 56);
            this.txtPayToTheOrderOf.MaxLength = 40;
            this.txtPayToTheOrderOf.Name = "txtPayToTheOrderOf";
            this.txtPayToTheOrderOf.Size = new System.Drawing.Size(292, 27);
            this.txtPayToTheOrderOf.TabIndex = 1;
            // 
            // lblPayToTheOrderOf
            // 
            this.lblPayToTheOrderOf.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPayToTheOrderOf.AutoSize = true;
            this.lblPayToTheOrderOf.Location = new System.Drawing.Point(6, 45);
            this.lblPayToTheOrderOf.Name = "lblPayToTheOrderOf";
            this.lblPayToTheOrderOf.Size = new System.Drawing.Size(91, 40);
            this.lblPayToTheOrderOf.TabIndex = 2;
            this.lblPayToTheOrderOf.Text = "Pay to\r\nthe order of:";
            // 
            // lblDate
            // 
            this.lblDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(6, 11);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(44, 20);
            this.lblDate.TabIndex = 0;
            this.lblDate.Text = "Date:";
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
            // txtEndorsement
            // 
            this.txtEndorsement.AcceptsReturn = true;
            this.txtEndorsement.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEndorsement.Location = new System.Drawing.Point(81, 11);
            this.txtEndorsement.Multiline = true;
            this.txtEndorsement.Name = "txtEndorsement";
            this.txtEndorsement.Size = new System.Drawing.Size(258, 128);
            this.txtEndorsement.TabIndex = 10;
            this.txtEndorsement.Text = "FOR DEPOSIT ONLY\r\n";
            // 
            // btnEndorse
            // 
            this.btnEndorse.BackColor = System.Drawing.Color.SteelBlue;
            this.btnEndorse.FlatAppearance.BorderSize = 0;
            this.btnEndorse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEndorse.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEndorse.ForeColor = System.Drawing.Color.White;
            this.btnEndorse.Location = new System.Drawing.Point(143, 161);
            this.btnEndorse.Name = "btnEndorse";
            this.btnEndorse.Size = new System.Drawing.Size(134, 36);
            this.btnEndorse.TabIndex = 9;
            this.btnEndorse.Text = "Endorse";
            this.btnEndorse.UseVisualStyleBackColor = false;
            this.btnEndorse.Click += new System.EventHandler(this.btnEndorse_Click);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Logical Name:";
            // 
            // txtLogicalName
            // 
            this.txtLogicalName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLogicalName.Location = new System.Drawing.Point(135, 12);
            this.txtLogicalName.MaxLength = 1000;
            this.txtLogicalName.Name = "txtLogicalName";
            this.txtLogicalName.Size = new System.Drawing.Size(292, 27);
            this.txtLogicalName.TabIndex = 0;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // lblStatus
            // 
            this.lblStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStatus.BackColor = System.Drawing.Color.AliceBlue;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(-3, 312);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Padding = new System.Windows.Forms.Padding(5);
            this.lblStatus.Size = new System.Drawing.Size(461, 65);
            this.lblStatus.TabIndex = 3;
            this.lblStatus.Text = "Ready.";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(457, 377);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.txtLogicalName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tabControl);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Main";
            this.Text = "Check Printing";
            this.Load += new System.EventHandler(this.Main_Load);
            this.tabControl.ResumeLayout(false);
            this.tabPayee.ResumeLayout(false);
            this.tabPayee.PerformLayout();
            this.tabEndorse.ResumeLayout(false);
            this.tabEndorse.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPayee;
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
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Label lblStatus;
    }
}

