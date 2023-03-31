
namespace frm_loan
{
    partial class loan_report
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
            this._btnEmail = new System.Windows.Forms.Button();
            this._labLoan = new System.Windows.Forms.Label();
            this._txtLoan = new System.Windows.Forms.TextBox();
            this._labTerm = new System.Windows.Forms.Label();
            this._txtTerm = new System.Windows.Forms.TextBox();
            this._labRate = new System.Windows.Forms.Label();
            this._txtRate = new System.Windows.Forms.TextBox();
            this._labPMT = new System.Windows.Forms.Label();
            this._txtPMT = new System.Windows.Forms.TextBox();
            this._labTotal = new System.Windows.Forms.Label();
            this._txtTotal = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // _btnEmail
            // 
            this._btnEmail.Font = new System.Drawing.Font("新細明體", 16F);
            this._btnEmail.Location = new System.Drawing.Point(534, 350);
            this._btnEmail.Name = "_btnEmail";
            this._btnEmail.Size = new System.Drawing.Size(104, 35);
            this._btnEmail.TabIndex = 0;
            this._btnEmail.Text = "Email";
            this._btnEmail.UseVisualStyleBackColor = true;
            // 
            // _labLoan
            // 
            this._labLoan.AutoSize = true;
            this._labLoan.Font = new System.Drawing.Font("新細明體", 16F);
            this._labLoan.Location = new System.Drawing.Point(106, 74);
            this._labLoan.Name = "_labLoan";
            this._labLoan.Size = new System.Drawing.Size(98, 22);
            this._labLoan.TabIndex = 1;
            this._labLoan.Text = "貸款金額";
            // 
            // _txtLoan
            // 
            this._txtLoan.Location = new System.Drawing.Point(231, 74);
            this._txtLoan.Name = "_txtLoan";
            this._txtLoan.Size = new System.Drawing.Size(100, 22);
            this._txtLoan.TabIndex = 2;
            // 
            // _labTerm
            // 
            this._labTerm.AutoSize = true;
            this._labTerm.Font = new System.Drawing.Font("新細明體", 16F);
            this._labTerm.Location = new System.Drawing.Point(106, 125);
            this._labTerm.Name = "_labTerm";
            this._labTerm.Size = new System.Drawing.Size(90, 22);
            this._labTerm.TabIndex = 3;
            this._labTerm.Text = "期限(年)";
            // 
            // _txtTerm
            // 
            this._txtTerm.Location = new System.Drawing.Point(231, 125);
            this._txtTerm.Name = "_txtTerm";
            this._txtTerm.Size = new System.Drawing.Size(100, 22);
            this._txtTerm.TabIndex = 4;
            // 
            // _labRate
            // 
            this._labRate.AutoSize = true;
            this._labRate.Font = new System.Drawing.Font("新細明體", 16F);
            this._labRate.Location = new System.Drawing.Point(106, 173);
            this._labRate.Name = "_labRate";
            this._labRate.Size = new System.Drawing.Size(85, 22);
            this._labRate.TabIndex = 5;
            this._labRate.Text = "利率(%)";
            // 
            // _txtRate
            // 
            this._txtRate.Location = new System.Drawing.Point(231, 173);
            this._txtRate.Name = "_txtRate";
            this._txtRate.Size = new System.Drawing.Size(100, 22);
            this._txtRate.TabIndex = 6;
            // 
            // _labPMT
            // 
            this._labPMT.AutoSize = true;
            this._labPMT.Font = new System.Drawing.Font("新細明體", 16F);
            this._labPMT.Location = new System.Drawing.Point(106, 230);
            this._labPMT.Name = "_labPMT";
            this._labPMT.Size = new System.Drawing.Size(76, 22);
            this._labPMT.TabIndex = 7;
            this._labPMT.Text = "月付款";
            // 
            // _txtPMT
            // 
            this._txtPMT.Location = new System.Drawing.Point(231, 234);
            this._txtPMT.Name = "_txtPMT";
            this._txtPMT.Size = new System.Drawing.Size(100, 22);
            this._txtPMT.TabIndex = 8;
            // 
            // _labTotal
            // 
            this._labTotal.AutoSize = true;
            this._labTotal.Font = new System.Drawing.Font("新細明體", 16F);
            this._labTotal.Location = new System.Drawing.Point(106, 295);
            this._labTotal.Name = "_labTotal";
            this._labTotal.Size = new System.Drawing.Size(76, 22);
            this._labTotal.TabIndex = 9;
            this._labTotal.Text = "總付款";
            // 
            // _txtTotal
            // 
            this._txtTotal.Location = new System.Drawing.Point(231, 299);
            this._txtTotal.Name = "_txtTotal";
            this._txtTotal.Size = new System.Drawing.Size(100, 22);
            this._txtTotal.TabIndex = 10;
            // 
            // loan_report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this._txtTotal);
            this.Controls.Add(this._labTotal);
            this.Controls.Add(this._txtPMT);
            this.Controls.Add(this._labPMT);
            this.Controls.Add(this._txtRate);
            this.Controls.Add(this._labRate);
            this.Controls.Add(this._txtTerm);
            this.Controls.Add(this._labTerm);
            this.Controls.Add(this._txtLoan);
            this.Controls.Add(this._labLoan);
            this.Controls.Add(this._btnEmail);
            this.Name = "loan_report";
            this.Text = "結果報告";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _btnEmail;
        private System.Windows.Forms.Label _labLoan;
        public System.Windows.Forms.TextBox _txtLoan;
        private System.Windows.Forms.Label _labTerm;
        public System.Windows.Forms.TextBox _txtTerm;
        private System.Windows.Forms.Label _labRate;
        public System.Windows.Forms.TextBox _txtRate;
        private System.Windows.Forms.Label _labPMT;
        public System.Windows.Forms.TextBox _txtPMT;
        private System.Windows.Forms.Label _labTotal;
        public System.Windows.Forms.TextBox _txtTotal;
    }
}