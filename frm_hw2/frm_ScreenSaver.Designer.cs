namespace frm_hw2
{
    partial class frm_ScreenSaver
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
            this.ball = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
            this.SuspendLayout();
            // 
            // ball
            // 
            this.ball.Image = global::frm_hw2.Properties.Resources.ball;
            this.ball.Location = new System.Drawing.Point(50, 115);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(200, 200);
            this.ball.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ball.TabIndex = 0;
            this.ball.TabStop = false;
            // 
            // frm_ScreenSaver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 656);
            this.Controls.Add(this.ball);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_ScreenSaver";
            this.Text = "frm_ScreenSaver";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Click += new System.EventHandler(this.frm_ScreenSaver_Click);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frm_ScreenSaver_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.ball)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ball;
    }
}