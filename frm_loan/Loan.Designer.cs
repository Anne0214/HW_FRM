namespace frm_loan
{
    partial class Loan
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnPMT = new System.Windows.Forms.Button();
            this.btnTotal = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.labLoan = new System.Windows.Forms.Label();
            this.labTerm = new System.Windows.Forms.Label();
            this.labRate = new System.Windows.Forms.Label();
            this.labDownPayment = new System.Windows.Forms.Label();
            this.txtLoan = new System.Windows.Forms.TextBox();
            this.txtTerm = new System.Windows.Forms.TextBox();
            this.txtRate = new System.Windows.Forms.TextBox();
            this.txtDownPayment = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnPMT
            // 
            this.btnPMT.Font = new System.Drawing.Font("新細明體", 16F);
            this.btnPMT.Location = new System.Drawing.Point(162, 328);
            this.btnPMT.Name = "btnPMT";
            this.btnPMT.Size = new System.Drawing.Size(119, 36);
            this.btnPMT.TabIndex = 0;
            this.btnPMT.Text = "PMT(月付)";
            this.btnPMT.UseVisualStyleBackColor = true;
            this.btnPMT.Click += new System.EventHandler(this.btnPMT_Click);
            // 
            // btnTotal
            // 
            this.btnTotal.Font = new System.Drawing.Font("新細明體", 16F);
            this.btnTotal.Location = new System.Drawing.Point(303, 328);
            this.btnTotal.Name = "btnTotal";
            this.btnTotal.Size = new System.Drawing.Size(102, 36);
            this.btnTotal.TabIndex = 1;
            this.btnTotal.Text = "總付款";
            this.btnTotal.UseVisualStyleBackColor = true;
            this.btnTotal.Click += new System.EventHandler(this.btnTotal_Click);
            // 
            // btnReport
            // 
            this.btnReport.Font = new System.Drawing.Font("新細明體", 16F);
            this.btnReport.Location = new System.Drawing.Point(527, 328);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(107, 36);
            this.btnReport.TabIndex = 2;
            this.btnReport.Text = "Report";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // labLoan
            // 
            this.labLoan.AutoSize = true;
            this.labLoan.Font = new System.Drawing.Font("新細明體", 16F);
            this.labLoan.Location = new System.Drawing.Point(119, 43);
            this.labLoan.Name = "labLoan";
            this.labLoan.Size = new System.Drawing.Size(98, 22);
            this.labLoan.TabIndex = 3;
            this.labLoan.Text = "貸款金額";
            // 
            // labTerm
            // 
            this.labTerm.AutoSize = true;
            this.labTerm.Font = new System.Drawing.Font("新細明體", 16F);
            this.labTerm.Location = new System.Drawing.Point(119, 104);
            this.labTerm.Name = "labTerm";
            this.labTerm.Size = new System.Drawing.Size(90, 22);
            this.labTerm.TabIndex = 4;
            this.labTerm.Text = "期限(年)";
            // 
            // labRate
            // 
            this.labRate.AutoSize = true;
            this.labRate.Font = new System.Drawing.Font("新細明體", 16F);
            this.labRate.Location = new System.Drawing.Point(119, 161);
            this.labRate.Name = "labRate";
            this.labRate.Size = new System.Drawing.Size(85, 22);
            this.labRate.TabIndex = 5;
            this.labRate.Text = "利率(%)";
            // 
            // labDownPayment
            // 
            this.labDownPayment.AutoSize = true;
            this.labDownPayment.Font = new System.Drawing.Font("新細明體", 16F);
            this.labDownPayment.Location = new System.Drawing.Point(119, 223);
            this.labDownPayment.Name = "labDownPayment";
            this.labDownPayment.Size = new System.Drawing.Size(76, 22);
            this.labDownPayment.TabIndex = 6;
            this.labDownPayment.Text = "頭期款";
            // 
            // txtLoan
            // 
            this.txtLoan.Location = new System.Drawing.Point(218, 40);
            this.txtLoan.Name = "txtLoan";
            this.txtLoan.Size = new System.Drawing.Size(100, 22);
            this.txtLoan.TabIndex = 8;
            // 
            // txtTerm
            // 
            this.txtTerm.Location = new System.Drawing.Point(215, 104);
            this.txtTerm.Name = "txtTerm";
            this.txtTerm.Size = new System.Drawing.Size(100, 22);
            this.txtTerm.TabIndex = 9;
            // 
            // txtRate
            // 
            this.txtRate.Location = new System.Drawing.Point(218, 161);
            this.txtRate.Name = "txtRate";
            this.txtRate.Size = new System.Drawing.Size(100, 22);
            this.txtRate.TabIndex = 10;
            // 
            // txtDownPayment
            // 
            this.txtDownPayment.Location = new System.Drawing.Point(218, 223);
            this.txtDownPayment.Name = "txtDownPayment";
            this.txtDownPayment.Size = new System.Drawing.Size(100, 22);
            this.txtDownPayment.TabIndex = 11;
            // 
            // Loan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtDownPayment);
            this.Controls.Add(this.txtRate);
            this.Controls.Add(this.txtTerm);
            this.Controls.Add(this.txtLoan);
            this.Controls.Add(this.labDownPayment);
            this.Controls.Add(this.labRate);
            this.Controls.Add(this.labTerm);
            this.Controls.Add(this.labLoan);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.btnTotal);
            this.Controls.Add(this.btnPMT);
            this.Name = "Loan";
            this.Text = "貸款金額試算";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPMT;
        private System.Windows.Forms.Button btnTotal;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Label labLoan;
        private System.Windows.Forms.Label labTerm;
        private System.Windows.Forms.Label labRate;
        private System.Windows.Forms.Label labDownPayment;
        private System.Windows.Forms.TextBox txtLoan;
        private System.Windows.Forms.TextBox txtTerm;
        private System.Windows.Forms.TextBox txtRate;
        private System.Windows.Forms.TextBox txtDownPayment;
    }
}

