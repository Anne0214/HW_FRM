namespace frm_hw2
{
    partial class frm_Alarm
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
            this.labNow = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAlarm = new System.Windows.Forms.TextBox();
            this.switchBox = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labNow
            // 
            this.labNow.AutoSize = true;
            this.labNow.Font = new System.Drawing.Font("新細明體", 12F);
            this.labNow.Location = new System.Drawing.Point(37, 37);
            this.labNow.Name = "labNow";
            this.labNow.Size = new System.Drawing.Size(45, 16);
            this.labNow.TabIndex = 0;
            this.labNow.Text = "label1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.switchBox);
            this.groupBox1.Controls.Add(this.txtAlarm);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("新細明體", 12F);
            this.groupBox1.Location = new System.Drawing.Point(40, 102);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(268, 140);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "選個鬧鐘時間";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "響鈴時間";
            // 
            // txtAlarm
            // 
            this.txtAlarm.Location = new System.Drawing.Point(97, 43);
            this.txtAlarm.Name = "txtAlarm";
            this.txtAlarm.Size = new System.Drawing.Size(100, 27);
            this.txtAlarm.TabIndex = 1;
            // 
            // switchBox
            // 
            this.switchBox.AutoSize = true;
            this.switchBox.Location = new System.Drawing.Point(134, 97);
            this.switchBox.Name = "switchBox";
            this.switchBox.Size = new System.Drawing.Size(106, 20);
            this.switchBox.TabIndex = 2;
            this.switchBox.Text = "鬧鐘開啟中";
            this.switchBox.UseVisualStyleBackColor = true;
            // 
            // frm_Alarm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 291);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labNow);
            this.Name = "frm_Alarm";
            this.Text = "frm_Alarm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labNow;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox switchBox;
        private System.Windows.Forms.TextBox txtAlarm;
        private System.Windows.Forms.Label label2;
    }
}