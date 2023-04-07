namespace frm_hw2
{
    partial class frm_Guess
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
            this.labInstruction = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnAnswer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labInstruction
            // 
            this.labInstruction.AutoSize = true;
            this.labInstruction.Font = new System.Drawing.Font("新細明體", 12F);
            this.labInstruction.Location = new System.Drawing.Point(34, 42);
            this.labInstruction.Name = "labInstruction";
            this.labInstruction.Size = new System.Drawing.Size(87, 16);
            this.labInstruction.TabIndex = 0;
            this.labInstruction.Text = "來猜數字ㄅ";
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("新細明體", 12F);
            this.btnStart.Location = new System.Drawing.Point(36, 90);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(102, 39);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "接受挑戰";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnAnswer
            // 
            this.btnAnswer.Font = new System.Drawing.Font("新細明體", 12F);
            this.btnAnswer.Location = new System.Drawing.Point(181, 90);
            this.btnAnswer.Name = "btnAnswer";
            this.btnAnswer.Size = new System.Drawing.Size(113, 39);
            this.btnAnswer.TabIndex = 2;
            this.btnAnswer.Text = "我菜，看答案";
            this.btnAnswer.UseVisualStyleBackColor = true;
            this.btnAnswer.Click += new System.EventHandler(this.btnAnswer_Click);
            // 
            // frm_Guess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 141);
            this.Controls.Add(this.btnAnswer);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.labInstruction);
            this.Name = "frm_Guess";
            this.Text = "frm_Guess";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label labInstruction;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnAnswer;
    }
}