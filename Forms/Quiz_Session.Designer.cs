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
            Center_panel = new Panel();
            return_btn = new Button();
            Timer_Progress = new MaterialSkin.Controls.MaterialProgressBar();
            QuizCards_flp = new FlowLayoutPanel();
            Center_panel.SuspendLayout();
            SuspendLayout();
            // 
            // Center_panel
            // 
            Center_panel.Controls.Add(return_btn);
            Center_panel.Controls.Add(Timer_Progress);
            Center_panel.Controls.Add(QuizCards_flp);
            Center_panel.Dock = DockStyle.Fill;
            Center_panel.Location = new Point(0, 0);
            Center_panel.Name = "Center_panel";
            Center_panel.Size = new Size(1501, 724);
            Center_panel.TabIndex = 4;
            // 
            // return_btn
            // 
            return_btn.BackgroundImage = Properties.Resources.log_in__5_;
            return_btn.BackgroundImageLayout = ImageLayout.Center;
            return_btn.FlatStyle = FlatStyle.Popup;
            return_btn.Location = new Point(42, 18);
            return_btn.Name = "return_btn";
            return_btn.Size = new Size(39, 40);
            return_btn.TabIndex = 6;
            return_btn.UseVisualStyleBackColor = true;
            // 
            // Timer_Progress
            // 
            Timer_Progress.Depth = 0;
            Timer_Progress.Location = new Point(342, 32);
            Timer_Progress.MouseState = MaterialSkin.MouseState.HOVER;
            Timer_Progress.Name = "Timer_Progress";
            Timer_Progress.Size = new Size(898, 5);
            Timer_Progress.TabIndex = 5;
            Timer_Progress.Value = 100;
            // 
            // QuizCards_flp
            // 
            QuizCards_flp.Location = new Point(177, 43);
            QuizCards_flp.Name = "QuizCards_flp";
            QuizCards_flp.Size = new Size(1205, 663);
            QuizCards_flp.TabIndex = 4;
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
            ResumeLayout(false);
        }

        #endregion
        private Panel Center_panel;
        private Button return_btn;
        private MaterialSkin.Controls.MaterialProgressBar Timer_Progress;
        private FlowLayoutPanel QuizCards_flp;
    }
}