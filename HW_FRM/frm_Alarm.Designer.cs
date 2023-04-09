namespace HW_FRM
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
            this.components = new System.ComponentModel.Container();
            this.labNow = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.switchBox = new System.Windows.Forms.CheckBox();
            this.txtAlarm = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labNow
            // 
            this.labNow.AutoSize = true;
            this.labNow.Font = new System.Drawing.Font("新細明體", 16F);
            this.labNow.Location = new System.Drawing.Point(56, 56);
            this.labNow.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labNow.Name = "labNow";
            this.labNow.Size = new System.Drawing.Size(86, 32);
            this.labNow.TabIndex = 0;
            this.labNow.Text = "label1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.switchBox);
            this.groupBox1.Controls.Add(this.txtAlarm);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("新細明體", 12F);
            this.groupBox1.Location = new System.Drawing.Point(60, 153);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(402, 210);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "選個鬧鐘時間";
            // 
            // switchBox
            // 
            this.switchBox.AutoSize = true;
            this.switchBox.Location = new System.Drawing.Point(201, 146);
            this.switchBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.switchBox.Name = "switchBox";
            this.switchBox.Size = new System.Drawing.Size(156, 28);
            this.switchBox.TabIndex = 2;
            this.switchBox.Text = "鬧鐘開啟中";
            this.switchBox.UseVisualStyleBackColor = true;
            this.switchBox.CheckedChanged += new System.EventHandler(this.switchBox_CheckedChanged);
            // 
            // txtAlarm
            // 
            this.txtAlarm.Location = new System.Drawing.Point(146, 64);
            this.txtAlarm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAlarm.Name = "txtAlarm";
            this.txtAlarm.Size = new System.Drawing.Size(199, 36);
            this.txtAlarm.TabIndex = 1;
            this.txtAlarm.Text = "時:分:秒";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 69);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "響鈴時間";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frm_Alarm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 436);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labNow);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frm_Alarm";
            this.Text = "frm_Alarm";
            this.Load += new System.EventHandler(this.frm_Alarm_Load);
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
        private System.Windows.Forms.Timer timer1;
    }
}