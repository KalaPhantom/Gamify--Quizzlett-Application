﻿namespace Gamify__Quizzlett_Application
{
    partial class Main_Menu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            SuspendLayout();
            // 
            // Main_Menu
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(24, 24, 27);
            ClientSize = new Size(1488, 832);
            IsMdiContainer = true;
            Name = "Main_Menu";
            Text = "Quizlet-Gamified - Menu";
            Load += Main_Menu_Load;
            ResumeLayout(false);
        }

        #endregion
    }
}
