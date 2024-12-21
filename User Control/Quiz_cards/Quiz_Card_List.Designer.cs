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
            test_lunch_btn = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // title_lbl
            // 
            title_lbl.AutoSize = true;
            title_lbl.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            title_lbl.ForeColor = SystemColors.ButtonHighlight;
            title_lbl.Location = new Point(50, 23);
            title_lbl.Name = "title_lbl";
            title_lbl.Size = new Size(53, 27);
            title_lbl.TabIndex = 0;
            title_lbl.Text = "title";
            // 
            // subject_lbl
            // 
            subject_lbl.AutoSize = true;
            subject_lbl.ForeColor = SystemColors.ButtonHighlight;
            subject_lbl.Location = new Point(48, 62);
            subject_lbl.Name = "subject_lbl";
            subject_lbl.Size = new Size(56, 20);
            subject_lbl.TabIndex = 1;
            subject_lbl.Text = "subject";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(20, 83, 45);
            panel1.Controls.Add(test_lunch_btn);
            panel1.Location = new Point(384, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(266, 128);
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
            // test_lunch_btn
            // 
            test_lunch_btn.Location = new Point(87, 58);
            test_lunch_btn.Name = "test_lunch_btn";
            test_lunch_btn.Size = new Size(94, 29);
            test_lunch_btn.TabIndex = 0;
            test_lunch_btn.Text = "test Button";
            test_lunch_btn.UseVisualStyleBackColor = true;
            test_lunch_btn.Click += test_lunch_btn_Click;
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
            Size = new Size(650, 125);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label title_lbl;
        private Label subject_lbl;
        private Panel panel1;
        private Panel status_color_pnl;
        private Button test_lunch_btn;
    }
}
