﻿using System.Windows.Forms;
using System;

namespace HW_FRM
{
    partial class frm_XOGame
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnEsc = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(323, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "X O Game";
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("新細明體", 16F);
            this.btnReset.Location = new System.Drawing.Point(226, 504);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(130, 51);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "Reset(R)";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnEsc
            // 
            this.btnEsc.Font = new System.Drawing.Font("新細明體", 16F);
            this.btnEsc.Location = new System.Drawing.Point(415, 504);
            this.btnEsc.Name = "btnEsc";
            this.btnEsc.Size = new System.Drawing.Size(153, 51);
            this.btnEsc.TabIndex = 2;
            this.btnEsc.Text = "Exit(Esc)";
            this.btnEsc.UseVisualStyleBackColor = true;
            this.btnEsc.Click += new System.EventHandler(this.btnEsc_Click);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.SystemColors.Info;
            this.btn1.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Bold);
            this.btn1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.btn1.Location = new System.Drawing.Point(3, 3);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(110, 120);
            this.btn1.TabIndex = 3;
            this.btn1.UseVisualStyleBackColor = false;
     ;
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.SystemColors.Info;
            this.btn2.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Bold);
            this.btn2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.btn2.Location = new System.Drawing.Point(119, 3);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(110, 120);
            this.btn2.TabIndex = 5;
            this.btn2.UseVisualStyleBackColor = false;
  
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.SystemColors.Info;
            this.btn3.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Bold);
            this.btn3.ForeColor = System.Drawing.SystemColors.GrayText;
            this.btn3.Location = new System.Drawing.Point(235, 3);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(110, 120);
            this.btn3.TabIndex = 6;
            this.btn3.UseVisualStyleBackColor = false;
    
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.SystemColors.Info;
            this.btn6.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Bold);
            this.btn6.ForeColor = System.Drawing.SystemColors.GrayText;
            this.btn6.Location = new System.Drawing.Point(235, 129);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(110, 120);
            this.btn6.TabIndex = 9;
            this.btn6.UseVisualStyleBackColor = false;
     
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.SystemColors.Info;
            this.btn5.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Bold);
            this.btn5.ForeColor = System.Drawing.SystemColors.GrayText;
            this.btn5.Location = new System.Drawing.Point(119, 129);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(110, 120);
            this.btn5.TabIndex = 8;
            this.btn5.UseVisualStyleBackColor = false;
       
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.SystemColors.Info;
            this.btn4.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Bold);
            this.btn4.ForeColor = System.Drawing.SystemColors.GrayText;
            this.btn4.Location = new System.Drawing.Point(3, 129);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(110, 120);
            this.btn4.TabIndex = 7;
            this.btn4.UseVisualStyleBackColor = false;
          
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.SystemColors.Info;
            this.btn9.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Bold);
            this.btn9.ForeColor = System.Drawing.SystemColors.GrayText;
            this.btn9.Location = new System.Drawing.Point(235, 255);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(110, 120);
            this.btn9.TabIndex = 12;
            this.btn9.UseVisualStyleBackColor = false;
           
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.SystemColors.Info;
            this.btn8.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Bold);
            this.btn8.ForeColor = System.Drawing.SystemColors.GrayText;
            this.btn8.Location = new System.Drawing.Point(119, 255);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(110, 120);
            this.btn8.TabIndex = 11;
            this.btn8.UseVisualStyleBackColor = false;
         
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.SystemColors.Info;
            this.btn7.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Bold);
            this.btn7.ForeColor = System.Drawing.SystemColors.GrayText;
            this.btn7.Location = new System.Drawing.Point(3, 255);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(110, 120);
            this.btn7.TabIndex = 10;
            this.btn7.UseVisualStyleBackColor = false;
            
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btn1);
            this.flowLayoutPanel1.Controls.Add(this.btn2);
            this.flowLayoutPanel1.Controls.Add(this.btn3);
            this.flowLayoutPanel1.Controls.Add(this.btn4);
            this.flowLayoutPanel1.Controls.Add(this.btn5);
            this.flowLayoutPanel1.Controls.Add(this.btn6);
            this.flowLayoutPanel1.Controls.Add(this.btn7);
            this.flowLayoutPanel1.Controls.Add(this.btn8);
            this.flowLayoutPanel1.Controls.Add(this.btn9);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(226, 92);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(355, 383);
            this.flowLayoutPanel1.TabIndex = 13;
            foreach(System.Windows.Forms.Button b in this.flowLayoutPanel1.Controls)
            {
                b.Click += new EventHandler(btn_Click);
            }
            // 
            // frm_XOGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 596);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.btnEsc);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.label1);
            this.Name = "frm_XOGame";
            this.Text = "frm_XOGame";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnEsc;
        private System.Windows.Forms.Button btn1;

        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}