﻿namespace Gamify__Quizzlett_Application.Forms
{
    partial class Create_Quiz
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
            return_btn = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // return_btn
            // 
            return_btn.Location = new Point(12, 12);
            return_btn.Name = "return_btn";
            return_btn.Size = new Size(94, 29);
            return_btn.TabIndex = 0;
            return_btn.Text = "Return";
            return_btn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(395, 195);
            label1.Name = "label1";
            label1.Size = new Size(86, 20);
            label1.TabIndex = 1;
            label1.Text = "Create Quiz";
            // 
            // Create_Quiz
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(883, 450);
            Controls.Add(label1);
            Controls.Add(return_btn);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Create_Quiz";
            Text = "Create Quiz";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button return_btn;
        private Label label1;
    }
}