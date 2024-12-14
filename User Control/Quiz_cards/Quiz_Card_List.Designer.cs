namespace Gamify__Quizzlett_Application.User_Control.Quiz_cards
{
    partial class Quiz_Card_List
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            title_lbl = new Label();
            subject_lbl = new Label();
            panel1 = new Panel();
            status_color_pnl = new Panel();
            SuspendLayout();
            // 
            // title_lbl
            // 
            title_lbl.AutoSize = true;
            title_lbl.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            title_lbl.ForeColor = SystemColors.ButtonHighlight;
            title_lbl.Location = new Point(67, 23);
            title_lbl.Name = "title_lbl";
            title_lbl.Size = new Size(53, 27);
            title_lbl.TabIndex = 0;
            title_lbl.Text = "title";
            // 
            // subject_lbl
            // 
            subject_lbl.AutoSize = true;
            subject_lbl.ForeColor = SystemColors.ButtonHighlight;
            subject_lbl.Location = new Point(67, 62);
            subject_lbl.Name = "subject_lbl";
            subject_lbl.Size = new Size(56, 20);
            subject_lbl.TabIndex = 1;
            subject_lbl.Text = "subject";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(20, 83, 45);
            panel1.Location = new Point(243, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(217, 125);
            panel1.TabIndex = 2;
            // 
            // status_color_pnl
            // 
            status_color_pnl.BackColor = Color.FromArgb(45, 212, 191);
            status_color_pnl.Location = new Point(3, 0);
            status_color_pnl.Name = "status_color_pnl";
            status_color_pnl.Size = new Size(13, 125);
            status_color_pnl.TabIndex = 3;
            // 
            // Quiz_Card_List
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(41, 37, 36);
            Controls.Add(status_color_pnl);
            Controls.Add(panel1);
            Controls.Add(subject_lbl);
            Controls.Add(title_lbl);
            Name = "Quiz_Card_List";
            Size = new Size(490, 125);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label title_lbl;
        private Label subject_lbl;
        private Panel panel1;
        private Panel status_color_pnl;
    }
}
