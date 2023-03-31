namespace frm_score
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
            this.btnSave.Location = new System.Drawing.Point(41, 361);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(105, 35);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "儲存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // labName
            // 
            this.labName.AutoSize = true;
            this.labName.Font = new System.Drawing.Font("新細明體", 16F);
            this.labName.Location = new System.Drawing.Point(66, 87);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(60, 22);
            this.labName.TabIndex = 1;
            this.labName.Text = "姓名:";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("新細明體", 16F);
            this.txtName.Location = new System.Drawing.Point(153, 76);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(150, 33);
            this.txtName.TabIndex = 2;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtChi
            // 
            this.txtChi.Font = new System.Drawing.Font("新細明體", 16F);
            this.txtChi.Location = new System.Drawing.Point(153, 142);
            this.txtChi.Name = "txtChi";
            this.txtChi.Size = new System.Drawing.Size(150, 33);
            this.txtChi.TabIndex = 5;
            this.txtChi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labChi
            // 
            this.labChi.AutoSize = true;
            this.labChi.Font = new System.Drawing.Font("新細明體", 16F);
            this.labChi.Location = new System.Drawing.Point(66, 153);
            this.labChi.Name = "labChi";
            this.labChi.Size = new System.Drawing.Size(60, 22);
            this.labChi.TabIndex = 4;
            this.labChi.Text = "國文:";
            // 
            // txtMath
            // 
            this.txtMath.Font = new System.Drawing.Font("新細明體", 16F);
            this.txtMath.Location = new System.Drawing.Point(153, 271);
            this.txtMath.Name = "txtMath";
            this.txtMath.Size = new System.Drawing.Size(150, 33);
            this.txtMath.TabIndex = 9;
            this.txtMath.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labMath
            // 
            this.labMath.AutoSize = true;
            this.labMath.Font = new System.Drawing.Font("新細明體", 16F);
            this.labMath.Location = new System.Drawing.Point(66, 282);
            this.labMath.Name = "labMath";
            this.labMath.Size = new System.Drawing.Size(60, 22);
            this.labMath.TabIndex = 8;
            this.labMath.Text = "數學:";
            // 
            // txtEng
            // 
            this.txtEng.Font = new System.Drawing.Font("新細明體", 16F);
            this.txtEng.Location = new System.Drawing.Point(153, 205);
            this.txtEng.Name = "txtEng";
            this.txtEng.Size = new System.Drawing.Size(150, 33);
            this.txtEng.TabIndex = 7;
            this.txtEng.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labEng
            // 
            this.labEng.AutoSize = true;
            this.labEng.Font = new System.Drawing.Font("新細明體", 16F);
            this.labEng.Location = new System.Drawing.Point(66, 216);
            this.labEng.Name = "labEng";
            this.labEng.Size = new System.Drawing.Size(60, 22);
            this.labEng.TabIndex = 6;
            this.labEng.Text = "英文:";
            // 
            // btnDisplay
            // 
            this.btnDisplay.Font = new System.Drawing.Font("新細明體", 16F);
            this.btnDisplay.Location = new System.Drawing.Point(164, 361);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(162, 35);
            this.btnDisplay.TabIndex = 10;
            this.btnDisplay.Text = "顯示儲存內容";
            this.btnDisplay.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSpecial);
            this.groupBox1.Controls.Add(this.txtDisplay);
            this.groupBox1.Font = new System.Drawing.Font("新細明體", 16F);
            this.groupBox1.Location = new System.Drawing.Point(355, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(328, 305);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "成績";
            // 
            // txtSpecial
            // 
            this.txtSpecial.Font = new System.Drawing.Font("新細明體", 12F);
            this.txtSpecial.Location = new System.Drawing.Point(6, 220);
            this.txtSpecial.Multiline = true;
            this.txtSpecial.Name = "txtSpecial";
            this.txtSpecial.Size = new System.Drawing.Size(316, 79);
            this.txtSpecial.TabIndex = 1;
            // 
            // txtDisplay
            // 
            this.txtDisplay.Font = new System.Drawing.Font("新細明體", 12F);
            this.txtDisplay.Location = new System.Drawing.Point(6, 36);
            this.txtDisplay.Multiline = true;
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.Size = new System.Drawing.Size(316, 179);
            this.txtDisplay.TabIndex = 0;
            // 
            // btnSpecial
            // 
            this.btnSpecial.Font = new System.Drawing.Font("新細明體", 16F);
            this.btnSpecial.Location = new System.Drawing.Point(465, 374);
            this.btnSpecial.Name = "btnSpecial";
            this.btnSpecial.Size = new System.Drawing.Size(218, 35);
            this.btnSpecial.TabIndex = 12;
            this.btnSpecial.Text = "最高分/最低分科目";
            this.btnSpecial.UseVisualStyleBackColor = true;
            // 
            // frm_score
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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

