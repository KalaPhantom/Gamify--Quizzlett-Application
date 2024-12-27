namespace Gamify__Quizzlett_Application.Forms
{
    partial class Quiz_Session
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
            components = new System.ComponentModel.Container();
            Center_panel = new Panel();
            timer_lbl = new Label();
            label1 = new Label();
            return_btn = new Button();
            Timer_Progress = new MaterialSkin.Controls.MaterialProgressBar();
            QuizCards_flp = new FlowLayoutPanel();
            quiz_timer = new System.Windows.Forms.Timer(components);
            Center_panel.SuspendLayout();
            SuspendLayout();
            // 
            // Center_panel
            // 
            Center_panel.BackgroundImage = Properties.Resources.BG_13;
            Center_panel.BackgroundImageLayout = ImageLayout.Stretch;
            Center_panel.Controls.Add(timer_lbl);
            Center_panel.Controls.Add(label1);
            Center_panel.Controls.Add(return_btn);
            Center_panel.Controls.Add(Timer_Progress);
            Center_panel.Controls.Add(QuizCards_flp);
            Center_panel.Dock = DockStyle.Fill;
            Center_panel.Location = new Point(0, 0);
            Center_panel.Name = "Center_panel";
            Center_panel.Size = new Size(1501, 724);
            Center_panel.TabIndex = 4;
            // 
            // timer_lbl
            // 
            timer_lbl.Anchor = AnchorStyles.None;
            timer_lbl.Font = new Font("Architects Daughter", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            timer_lbl.ForeColor = SystemColors.ButtonHighlight;
            timer_lbl.Location = new Point(35, 344);
            timer_lbl.Name = "timer_lbl";
            timer_lbl.Size = new Size(98, 28);
            timer_lbl.TabIndex = 8;
            timer_lbl.Text = "Disabled";
            timer_lbl.TextAlign = ContentAlignment.TopCenter;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Architects Daughter", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(43, 316);
            label1.Name = "label1";
            label1.Size = new Size(85, 28);
            label1.TabIndex = 7;
            label1.Text = "Ellapsed";
            // 
            // return_btn
            // 
            return_btn.BackgroundImage = Properties.Resources.log_in__5_;
            return_btn.BackgroundImageLayout = ImageLayout.Center;
            return_btn.FlatStyle = FlatStyle.Popup;
            return_btn.Location = new Point(12, 12);
            return_btn.Name = "return_btn";
            return_btn.Size = new Size(39, 40);
            return_btn.TabIndex = 6;
            return_btn.UseVisualStyleBackColor = true;
            return_btn.Click += return_btn_Click;
            // 
            // Timer_Progress
            // 
            Timer_Progress.Anchor = AnchorStyles.None;
            Timer_Progress.Depth = 0;
            Timer_Progress.Location = new Point(162, 27);
            Timer_Progress.MouseState = MaterialSkin.MouseState.HOVER;
            Timer_Progress.Name = "Timer_Progress";
            Timer_Progress.Size = new Size(1205, 5);
            Timer_Progress.TabIndex = 5;
            Timer_Progress.Value = 100;
            // 
            // QuizCards_flp
            // 
            QuizCards_flp.Anchor = AnchorStyles.None;
            QuizCards_flp.Location = new Point(162, 43);
            QuizCards_flp.Name = "QuizCards_flp";
            QuizCards_flp.Size = new Size(1205, 663);
            QuizCards_flp.TabIndex = 4;
            // 
            // quiz_timer
            // 
            quiz_timer.Tick += quiz_timer_Tick;
            // 
            // Quiz_Session
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(12, 10, 9);
            ClientSize = new Size(1501, 724);
            Controls.Add(Center_panel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Quiz_Session";
            Text = "Quiz_Session";
            Center_panel.ResumeLayout(false);
            Center_panel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel Center_panel;
        private Button return_btn;
        private MaterialSkin.Controls.MaterialProgressBar Timer_Progress;
        private FlowLayoutPanel QuizCards_flp;
        private System.Windows.Forms.Timer quiz_timer;
        private Label label1;
        private Label timer_lbl;
    }
}