namespace HW_FRM
{
    partial class frm_StudentGrade
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
            this.listAll = new System.Windows.Forms.ListView();
            this.colName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colChi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colEng = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colMath = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colAvg = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colMin = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colMas = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listSummary = new System.Windows.Forms.ListView();
            this.labName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtChi = new System.Windows.Forms.TextBox();
            this.labChi = new System.Windows.Forms.Label();
            this.txtMath = new System.Windows.Forms.TextBox();
            this.labMath = new System.Windows.Forms.Label();
            this.txtEng = new System.Windows.Forms.TextBox();
            this.labEng = new System.Windows.Forms.Label();
            this.btnRandom = new System.Windows.Forms.Button();
            this.btnSummary = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnRadeom20 = new System.Windows.Forms.Button();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listAll
            // 
            this.listAll.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colName,
            this.colChi,
            this.colEng,
            this.colMath,
            this.colSum,
            this.colAvg,
            this.colMin,
            this.colMas});
            this.listAll.HideSelection = false;
            this.listAll.Location = new System.Drawing.Point(189, 12);
            this.listAll.Margin = new System.Windows.Forms.Padding(2);
            this.listAll.Name = "listAll";
            this.listAll.ShowItemToolTips = true;
            this.listAll.Size = new System.Drawing.Size(720, 251);
            this.listAll.TabIndex = 0;
            this.listAll.UseCompatibleStateImageBehavior = false;
            this.listAll.View = System.Windows.Forms.View.Details;
            // 
            // colName
            // 
            this.colName.Text = "姓名";
            this.colName.Width = 100;
            // 
            // colChi
            // 
            this.colChi.Text = "國文";
            this.colChi.Width = 80;
            // 
            // colEng
            // 
            this.colEng.Text = "英文";
            this.colEng.Width = 80;
            // 
            // colMath
            // 
            this.colMath.Text = "數學";
            this.colMath.Width = 80;
            // 
            // colSum
            // 
            this.colSum.Text = "總分";
            this.colSum.Width = 80;
            // 
            // colAvg
            // 
            this.colAvg.Text = "平均";
            this.colAvg.Width = 80;
            // 
            // colMin
            // 
            this.colMin.Text = "最低";
            this.colMin.Width = 100;
            // 
            // colMas
            // 
            this.colMas.Text = "最高";
            this.colMas.Width = 100;
            // 
            // listSummary
            // 
            this.listSummary.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listSummary.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.listSummary.HideSelection = false;
            this.listSummary.Location = new System.Drawing.Point(189, 266);
            this.listSummary.Margin = new System.Windows.Forms.Padding(2);
            this.listSummary.Name = "listSummary";
            this.listSummary.Size = new System.Drawing.Size(720, 89);
            this.listSummary.TabIndex = 1;
            this.listSummary.UseCompatibleStateImageBehavior = false;
            this.listSummary.View = System.Windows.Forms.View.Details;
            // 
            // labName
            // 
            this.labName.AutoSize = true;
            this.labName.Font = new System.Drawing.Font("新細明體", 12F);
            this.labName.Location = new System.Drawing.Point(26, 20);
            this.labName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(43, 16);
            this.labName.TabIndex = 2;
            this.labName.Text = "姓名:";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("新細明體", 12F);
            this.txtName.Location = new System.Drawing.Point(73, 12);
            this.txtName.Margin = new System.Windows.Forms.Padding(2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(108, 27);
            this.txtName.TabIndex = 3;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("新細明體", 12F);
            this.btnAdd.Location = new System.Drawing.Point(41, 181);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(131, 29);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "加入學生資料";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtChi
            // 
            this.txtChi.Font = new System.Drawing.Font("新細明體", 12F);
            this.txtChi.Location = new System.Drawing.Point(73, 55);
            this.txtChi.Margin = new System.Windows.Forms.Padding(2);
            this.txtChi.Name = "txtChi";
            this.txtChi.Size = new System.Drawing.Size(108, 27);
            this.txtChi.TabIndex = 6;
            // 
            // labChi
            // 
            this.labChi.AutoSize = true;
            this.labChi.Font = new System.Drawing.Font("新細明體", 12F);
            this.labChi.Location = new System.Drawing.Point(26, 63);
            this.labChi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labChi.Name = "labChi";
            this.labChi.Size = new System.Drawing.Size(43, 16);
            this.labChi.TabIndex = 5;
            this.labChi.Text = "國文:";
            // 
            // txtMath
            // 
            this.txtMath.Font = new System.Drawing.Font("新細明體", 12F);
            this.txtMath.Location = new System.Drawing.Point(73, 144);
            this.txtMath.Margin = new System.Windows.Forms.Padding(2);
            this.txtMath.Name = "txtMath";
            this.txtMath.Size = new System.Drawing.Size(108, 27);
            this.txtMath.TabIndex = 10;
            // 
            // labMath
            // 
            this.labMath.AutoSize = true;
            this.labMath.Font = new System.Drawing.Font("新細明體", 12F);
            this.labMath.Location = new System.Drawing.Point(26, 152);
            this.labMath.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labMath.Name = "labMath";
            this.labMath.Size = new System.Drawing.Size(43, 16);
            this.labMath.TabIndex = 9;
            this.labMath.Text = "數學:";
            // 
            // txtEng
            // 
            this.txtEng.Font = new System.Drawing.Font("新細明體", 12F);
            this.txtEng.Location = new System.Drawing.Point(73, 101);
            this.txtEng.Margin = new System.Windows.Forms.Padding(2);
            this.txtEng.Name = "txtEng";
            this.txtEng.Size = new System.Drawing.Size(108, 27);
            this.txtEng.TabIndex = 8;
            // 
            // labEng
            // 
            this.labEng.AutoSize = true;
            this.labEng.Font = new System.Drawing.Font("新細明體", 12F);
            this.labEng.Location = new System.Drawing.Point(26, 109);
            this.labEng.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labEng.Name = "labEng";
            this.labEng.Size = new System.Drawing.Size(43, 16);
            this.labEng.TabIndex = 7;
            this.labEng.Text = "英文:";
            // 
            // btnRandom
            // 
            this.btnRandom.Font = new System.Drawing.Font("新細明體", 12F);
            this.btnRandom.Location = new System.Drawing.Point(41, 213);
            this.btnRandom.Margin = new System.Windows.Forms.Padding(2);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(131, 29);
            this.btnRandom.TabIndex = 11;
            this.btnRandom.Text = "隨機儲存資料";
            this.btnRandom.UseVisualStyleBackColor = true;
            this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click);
            // 
            // btnSummary
            // 
            this.btnSummary.Enabled = false;
            this.btnSummary.Font = new System.Drawing.Font("新細明體", 12F);
            this.btnSummary.Location = new System.Drawing.Point(41, 248);
            this.btnSummary.Margin = new System.Windows.Forms.Padding(2);
            this.btnSummary.Name = "btnSummary";
            this.btnSummary.Size = new System.Drawing.Size(131, 29);
            this.btnSummary.TabIndex = 12;
            this.btnSummary.Text = "各科統計";
            this.btnSummary.UseVisualStyleBackColor = true;
            this.btnSummary.Click += new System.EventHandler(this.btnSummary_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("新細明體", 12F);
            this.btnReset.Location = new System.Drawing.Point(41, 292);
            this.btnReset.Margin = new System.Windows.Forms.Padding(2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(131, 29);
            this.btnReset.TabIndex = 13;
            this.btnReset.Text = "重設所有資料";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnRadeom20
            // 
            this.btnRadeom20.Font = new System.Drawing.Font("新細明體", 12F);
            this.btnRadeom20.Location = new System.Drawing.Point(41, 325);
            this.btnRadeom20.Margin = new System.Windows.Forms.Padding(2);
            this.btnRadeom20.Name = "btnRadeom20";
            this.btnRadeom20.Size = new System.Drawing.Size(131, 29);
            this.btnRadeom20.TabIndex = 14;
            this.btnRadeom20.Text = "隨機加入20筆";
            this.btnRadeom20.UseVisualStyleBackColor = true;
            this.btnRadeom20.Click += new System.EventHandler(this.btnRadeom20_Click);
            // 
            // frm_StudentGrade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 373);
            this.Controls.Add(this.btnRadeom20);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSummary);
            this.Controls.Add(this.btnRandom);
            this.Controls.Add(this.txtMath);
            this.Controls.Add(this.labMath);
            this.Controls.Add(this.txtEng);
            this.Controls.Add(this.labEng);
            this.Controls.Add(this.txtChi);
            this.Controls.Add(this.labChi);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.labName);
            this.Controls.Add(this.listSummary);
            this.Controls.Add(this.listAll);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frm_StudentGrade";
            this.Text = "frm_StudentGrade";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        

    private System.Windows.Forms.ListView listAll;
        private System.Windows.Forms.ColumnHeader colName;
        private System.Windows.Forms.ColumnHeader colChi;
        private System.Windows.Forms.ColumnHeader colEng;
        private System.Windows.Forms.ColumnHeader colMath;
        private System.Windows.Forms.ListView listSummary;
        private System.Windows.Forms.ColumnHeader colSum;
        private System.Windows.Forms.ColumnHeader colAvg;
        private System.Windows.Forms.ColumnHeader colMin;
        private System.Windows.Forms.ColumnHeader colMas;
        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtChi;
        private System.Windows.Forms.Label labChi;
        private System.Windows.Forms.TextBox txtMath;
        private System.Windows.Forms.Label labMath;
        private System.Windows.Forms.TextBox txtEng;
        private System.Windows.Forms.Label labEng;
        private System.Windows.Forms.Button btnRandom;
        private System.Windows.Forms.Button btnSummary;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnRadeom20;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
    
}