namespace Gamify__Quizzlett_Application.User_Control.Quiz_cards
{
    partial class Quiz_main_card
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
            image_panel = new Panel();
            panel2 = new Panel();
            last_score_lbl = new Label();
            type_lbl = new Label();
            istimer_lbl = new Label();
            subject_lbl = new Label();
            name_lbl = new Label();
            panel3 = new Panel();
            play_btn = new Button();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // image_panel
            // 
            image_panel.BackgroundImage = Properties.Resources.Side_Border___18_pp2;
            image_panel.Location = new Point(17, 11);
            image_panel.Name = "image_panel";
            image_panel.Size = new Size(304, 272);
            image_panel.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(last_score_lbl);
            panel2.Controls.Add(type_lbl);
            panel2.Controls.Add(istimer_lbl);
            panel2.Controls.Add(subject_lbl);
            panel2.Controls.Add(name_lbl);
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(380, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(998, 300);
            panel2.TabIndex = 1;
            // 
            // last_score_lbl
            // 
            last_score_lbl.AutoSize = true;
            last_score_lbl.Font = new Font("Architects Daughter", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            last_score_lbl.ForeColor = SystemColors.ButtonHighlight;
            last_score_lbl.Location = new Point(20, 195);
            last_score_lbl.Name = "last_score_lbl";
            last_score_lbl.Size = new Size(115, 28);
            last_score_lbl.TabIndex = 5;
            last_score_lbl.Text = "last_score";
            // 
            // type_lbl
            // 
            type_lbl.AutoSize = true;
            type_lbl.Font = new Font("Architects Daughter", 10.8F);
            type_lbl.ForeColor = SystemColors.ButtonHighlight;
            type_lbl.Location = new Point(20, 258);
            type_lbl.Name = "type_lbl";
            type_lbl.Size = new Size(99, 29);
            type_lbl.TabIndex = 4;
            type_lbl.Text = "name_lbl";
            // 
            // istimer_lbl
            // 
            istimer_lbl.AutoSize = true;
            istimer_lbl.Font = new Font("Architects Daughter", 10.8F);
            istimer_lbl.ForeColor = SystemColors.ButtonHighlight;
            istimer_lbl.Location = new Point(20, 223);
            istimer_lbl.Name = "istimer_lbl";
            istimer_lbl.Size = new Size(113, 29);
            istimer_lbl.TabIndex = 3;
            istimer_lbl.Text = "istimer_lbl";
            // 
            // subject_lbl
            // 
            subject_lbl.AutoSize = true;
            subject_lbl.Font = new Font("Architects Daughter", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            subject_lbl.ForeColor = SystemColors.ButtonHighlight;
            subject_lbl.Location = new Point(20, 86);
            subject_lbl.Name = "subject_lbl";
            subject_lbl.Size = new Size(113, 28);
            subject_lbl.TabIndex = 2;
            subject_lbl.Text = "subject_lbl";
            // 
            // name_lbl
            // 
            name_lbl.Font = new Font("Architects Daughter", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            name_lbl.ForeColor = SystemColors.ButtonHighlight;
            name_lbl.Location = new Point(13, 21);
            name_lbl.Name = "name_lbl";
            name_lbl.Size = new Size(482, 65);
            name_lbl.TabIndex = 1;
            name_lbl.Text = "name_lbl";
            // 
            // panel3
            // 
            panel3.Controls.Add(play_btn);
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(518, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(480, 300);
            panel3.TabIndex = 0;
            // 
            // play_btn
            // 
            play_btn.FlatStyle = FlatStyle.Popup;
            play_btn.ForeColor = SystemColors.ButtonHighlight;
            play_btn.Image = Properties.Resources.png_avyho;
            play_btn.Location = new Point(54, 31);
            play_btn.Name = "play_btn";
            play_btn.Size = new Size(395, 239);
            play_btn.TabIndex = 0;
            play_btn.UseVisualStyleBackColor = true;
            play_btn.Click += play_btn_Click;
            // 
            // Quiz_main_card
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(28, 25, 23);
            Controls.Add(panel2);
            Controls.Add(image_panel);
            Name = "Quiz_main_card";
            Size = new Size(1378, 300);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel image_panel;
        private Panel panel2;
        private Label type_lbl;
        private Label istimer_lbl;
        private Label subject_lbl;
        private Label name_lbl;
        private Panel panel3;
        private Button play_btn;
        private Label last_score_lbl;
    }
}
