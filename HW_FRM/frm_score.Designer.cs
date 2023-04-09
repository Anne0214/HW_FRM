namespace HW_FRM
{
    partial class frm_score
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
            this.btnSave = new System.Windows.Forms.Button();
            this.labName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtChi = new System.Windows.Forms.TextBox();
            this.labChi = new System.Windows.Forms.Label();
            this.txtMath = new System.Windows.Forms.TextBox();
            this.labMath = new System.Windows.Forms.Label();
            this.txtEng = new System.Windows.Forms.TextBox();
            this.labEng = new System.Windows.Forms.Label();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSpecial = new System.Windows.Forms.TextBox();
            this.txtDisplay = new System.Windows.Forms.TextBox();
            this.btnSpecial = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("新細明體", 16F);
            this.btnSave.Location = new System.Drawing.Point(62, 542);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(158, 52);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "儲存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // labName
            // 
            this.labName.AutoSize = true;
            this.labName.Font = new System.Drawing.Font("新細明體", 16F);
            this.labName.Location = new System.Drawing.Point(99, 130);
            this.labName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(86, 32);
            this.labName.TabIndex = 1;
            this.labName.Text = "姓名:";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("新細明體", 16F);
            this.txtName.Location = new System.Drawing.Point(230, 114);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(223, 46);
            this.txtName.TabIndex = 2;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtChi
            // 
            this.txtChi.Font = new System.Drawing.Font("新細明體", 16F);
            this.txtChi.Location = new System.Drawing.Point(230, 213);
            this.txtChi.Margin = new System.Windows.Forms.Padding(4);
            this.txtChi.Name = "txtChi";
            this.txtChi.Size = new System.Drawing.Size(223, 46);
            this.txtChi.TabIndex = 5;
            this.txtChi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labChi
            // 
            this.labChi.AutoSize = true;
            this.labChi.Font = new System.Drawing.Font("新細明體", 16F);
            this.labChi.Location = new System.Drawing.Point(99, 230);
            this.labChi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labChi.Name = "labChi";
            this.labChi.Size = new System.Drawing.Size(86, 32);
            this.labChi.TabIndex = 4;
            this.labChi.Text = "國文:";
            // 
            // txtMath
            // 
            this.txtMath.Font = new System.Drawing.Font("新細明體", 16F);
            this.txtMath.Location = new System.Drawing.Point(230, 406);
            this.txtMath.Margin = new System.Windows.Forms.Padding(4);
            this.txtMath.Name = "txtMath";
            this.txtMath.Size = new System.Drawing.Size(223, 46);
            this.txtMath.TabIndex = 9;
            this.txtMath.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labMath
            // 
            this.labMath.AutoSize = true;
            this.labMath.Font = new System.Drawing.Font("新細明體", 16F);
            this.labMath.Location = new System.Drawing.Point(99, 423);
            this.labMath.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labMath.Name = "labMath";
            this.labMath.Size = new System.Drawing.Size(86, 32);
            this.labMath.TabIndex = 8;
            this.labMath.Text = "數學:";
            // 
            // txtEng
            // 
            this.txtEng.Font = new System.Drawing.Font("新細明體", 16F);
            this.txtEng.Location = new System.Drawing.Point(230, 308);
            this.txtEng.Margin = new System.Windows.Forms.Padding(4);
            this.txtEng.Name = "txtEng";
            this.txtEng.Size = new System.Drawing.Size(223, 46);
            this.txtEng.TabIndex = 7;
            this.txtEng.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labEng
            // 
            this.labEng.AutoSize = true;
            this.labEng.Font = new System.Drawing.Font("新細明體", 16F);
            this.labEng.Location = new System.Drawing.Point(99, 324);
            this.labEng.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labEng.Name = "labEng";
            this.labEng.Size = new System.Drawing.Size(86, 32);
            this.labEng.TabIndex = 6;
            this.labEng.Text = "英文:";
            // 
            // btnDisplay
            // 
            this.btnDisplay.Font = new System.Drawing.Font("新細明體", 16F);
            this.btnDisplay.Location = new System.Drawing.Point(246, 542);
            this.btnDisplay.Margin = new System.Windows.Forms.Padding(4);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(243, 52);
            this.btnDisplay.TabIndex = 10;
            this.btnDisplay.Text = "顯示儲存內容";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSpecial);
            this.groupBox1.Controls.Add(this.txtDisplay);
            this.groupBox1.Font = new System.Drawing.Font("新細明體", 16F);
            this.groupBox1.Location = new System.Drawing.Point(532, 76);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(492, 458);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "成績";
            // 
            // txtSpecial
            // 
            this.txtSpecial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSpecial.Font = new System.Drawing.Font("新細明體", 12F);
            this.txtSpecial.Location = new System.Drawing.Point(9, 330);
            this.txtSpecial.Margin = new System.Windows.Forms.Padding(4);
            this.txtSpecial.Multiline = true;
            this.txtSpecial.Name = "txtSpecial";
            this.txtSpecial.ReadOnly = true;
            this.txtSpecial.Size = new System.Drawing.Size(472, 116);
            this.txtSpecial.TabIndex = 1;
            // 
            // txtDisplay
            // 
            this.txtDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDisplay.Font = new System.Drawing.Font("新細明體", 12F);
            this.txtDisplay.Location = new System.Drawing.Point(9, 54);
            this.txtDisplay.Margin = new System.Windows.Forms.Padding(4);
            this.txtDisplay.Multiline = true;
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.ReadOnly = true;
            this.txtDisplay.Size = new System.Drawing.Size(472, 266);
            this.txtDisplay.TabIndex = 0;
            // 
            // btnSpecial
            // 
            this.btnSpecial.Font = new System.Drawing.Font("新細明體", 16F);
            this.btnSpecial.Location = new System.Drawing.Point(698, 561);
            this.btnSpecial.Margin = new System.Windows.Forms.Padding(4);
            this.btnSpecial.Name = "btnSpecial";
            this.btnSpecial.Size = new System.Drawing.Size(327, 52);
            this.btnSpecial.TabIndex = 12;
            this.btnSpecial.Text = "最高分/最低分科目";
            this.btnSpecial.UseVisualStyleBackColor = true;
            this.btnSpecial.Click += new System.EventHandler(this.btnSpecial_Click);
            // 
            // frm_score
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 675);
            this.Controls.Add(this.btnSpecial);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.txtMath);
            this.Controls.Add(this.labMath);
            this.Controls.Add(this.txtEng);
            this.Controls.Add(this.labEng);
            this.Controls.Add(this.txtChi);
            this.Controls.Add(this.labChi);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.labName);
            this.Controls.Add(this.btnSave);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_score";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtChi;
        private System.Windows.Forms.Label labChi;
        private System.Windows.Forms.TextBox txtMath;
        private System.Windows.Forms.Label labMath;
        private System.Windows.Forms.TextBox txtEng;
        private System.Windows.Forms.Label labEng;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSpecial;
        private System.Windows.Forms.TextBox txtDisplay;
        private System.Windows.Forms.Button btnSpecial;
    }
}

