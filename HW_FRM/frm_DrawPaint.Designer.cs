namespace HW_FRM
{
    partial class frm_DrawPaint
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
            this.btnColor = new System.Windows.Forms.Button();
            this.brushBar = new System.Windows.Forms.TrackBar();
            this.brushSize = new System.Windows.Forms.Label();
            this.colorBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.brushBar)).BeginInit();
            this.SuspendLayout();
            // 
            // btnColor
            // 
            this.btnColor.Location = new System.Drawing.Point(713, 25);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(75, 23);
            this.btnColor.TabIndex = 0;
            this.btnColor.Text = "顏色";
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // brushBar
            // 
            this.brushBar.Location = new System.Drawing.Point(730, 134);
            this.brushBar.Maximum = 100;
            this.brushBar.Minimum = 1;
            this.brushBar.Name = "brushBar";
            this.brushBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.brushBar.Size = new System.Drawing.Size(45, 196);
            this.brushBar.TabIndex = 1;
            this.brushBar.Value = 1;
            this.brushBar.Scroll += new System.EventHandler(this.brushBar_Scroll);
            // 
            // brushSize
            // 
            this.brushSize.AutoSize = true;
            this.brushSize.Location = new System.Drawing.Point(728, 333);
            this.brushSize.Name = "brushSize";
            this.brushSize.Size = new System.Drawing.Size(11, 12);
            this.brushSize.TabIndex = 3;
            this.brushSize.Text = "1";
            // 
            // colorBox
            // 
            this.colorBox.BackColor = System.Drawing.Color.Black;
            this.colorBox.Enabled = false;
            this.colorBox.Location = new System.Drawing.Point(713, 55);
            this.colorBox.Multiline = true;
            this.colorBox.Name = "colorBox";
            this.colorBox.Size = new System.Drawing.Size(75, 38);
            this.colorBox.TabIndex = 4;
            // 
            // frm_DrawPaint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.colorBox);
            this.Controls.Add(this.brushSize);
            this.Controls.Add(this.brushBar);
            this.Controls.Add(this.btnColor);
            this.Name = "frm_DrawPaint";
            this.Text = "frm_DrawPaint";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frm_DrawPaint_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frm_DrawPaint_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frm_DrawPaint_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.brushBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.TrackBar brushBar;
        private System.Windows.Forms.Label brushSize;
        private System.Windows.Forms.TextBox colorBox;
    }
}