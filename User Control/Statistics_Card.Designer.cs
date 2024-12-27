namespace Gamify__Quizzlett_Application.User_Control
{
    partial class Statistics_Card
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
            upper_panel_1 = new Panel();
            title_lbl = new Label();
            Interpretation_lbl = new Label();
            GB1 = new GroupBox();
            GB2 = new GroupBox();
            average_time_lbl = new Label();
            GB3 = new GroupBox();
            Average_score_lbl = new Label();
            upper_panel_1.SuspendLayout();
            GB1.SuspendLayout();
            GB2.SuspendLayout();
            GB3.SuspendLayout();
            SuspendLayout();
            // 
            // upper_panel_1
            // 
            upper_panel_1.Controls.Add(title_lbl);
            upper_panel_1.Dock = DockStyle.Top;
            upper_panel_1.Location = new Point(0, 0);
            upper_panel_1.Name = "upper_panel_1";
            upper_panel_1.Size = new Size(923, 60);
            upper_panel_1.TabIndex = 0;
            // 
            // title_lbl
            // 
            title_lbl.AutoSize = true;
            title_lbl.Font = new Font("Architects Daughter", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            title_lbl.ForeColor = SystemColors.ButtonHighlight;
            title_lbl.Location = new Point(23, 18);
            title_lbl.Name = "title_lbl";
            title_lbl.Size = new Size(88, 29);
            title_lbl.TabIndex = 0;
            title_lbl.Text = "Title_lbl";
            // 
            // Interpretation_lbl
            // 
            Interpretation_lbl.Anchor = AnchorStyles.None;
            Interpretation_lbl.AutoSize = true;
            Interpretation_lbl.Font = new Font("Architects Daughter", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Interpretation_lbl.ForeColor = SystemColors.ButtonHighlight;
            Interpretation_lbl.Location = new Point(84, 58);
            Interpretation_lbl.Name = "Interpretation_lbl";
            Interpretation_lbl.Size = new Size(70, 76);
            Interpretation_lbl.TabIndex = 1;
            Interpretation_lbl.Text = "A";
            // 
            // GB1
            // 
            GB1.BackgroundImageLayout = ImageLayout.None;
            GB1.Controls.Add(Interpretation_lbl);
            GB1.Font = new Font("Architects Daughter", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            GB1.ForeColor = SystemColors.ButtonHighlight;
            GB1.Location = new Point(35, 91);
            GB1.Name = "GB1";
            GB1.Size = new Size(250, 170);
            GB1.TabIndex = 2;
            GB1.TabStop = false;
            GB1.Text = "Interpretattion";
            // 
            // GB2
            // 
            GB2.BackgroundImageLayout = ImageLayout.None;
            GB2.Controls.Add(average_time_lbl);
            GB2.Font = new Font("Architects Daughter", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            GB2.ForeColor = SystemColors.ButtonHighlight;
            GB2.Location = new Point(307, 91);
            GB2.Name = "GB2";
            GB2.Size = new Size(250, 170);
            GB2.TabIndex = 3;
            GB2.TabStop = false;
            GB2.Text = "Average Time";
            // 
            // average_time_lbl
            // 
            average_time_lbl.Anchor = AnchorStyles.None;
            average_time_lbl.Font = new Font("Architects Daughter", 19.8000011F);
            average_time_lbl.ForeColor = SystemColors.ButtonHighlight;
            average_time_lbl.Location = new Point(69, 58);
            average_time_lbl.Name = "average_time_lbl";
            average_time_lbl.Size = new Size(101, 76);
            average_time_lbl.TabIndex = 1;
            average_time_lbl.Text = "A";
            average_time_lbl.TextAlign = ContentAlignment.TopCenter;
            // 
            // GB3
            // 
            GB3.BackgroundImageLayout = ImageLayout.None;
            GB3.Controls.Add(Average_score_lbl);
            GB3.Font = new Font("Architects Daughter", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            GB3.ForeColor = SystemColors.ButtonHighlight;
            GB3.Location = new Point(587, 91);
            GB3.Name = "GB3";
            GB3.Size = new Size(250, 170);
            GB3.TabIndex = 4;
            GB3.TabStop = false;
            GB3.Text = "Average Score";
            // 
            // Average_score_lbl
            // 
            Average_score_lbl.Anchor = AnchorStyles.None;
            Average_score_lbl.Font = new Font("Architects Daughter", 19.8000011F);
            Average_score_lbl.ForeColor = SystemColors.ButtonHighlight;
            Average_score_lbl.Location = new Point(70, 58);
            Average_score_lbl.Name = "Average_score_lbl";
            Average_score_lbl.Size = new Size(101, 76);
            Average_score_lbl.TabIndex = 1;
            Average_score_lbl.Text = "A";
            Average_score_lbl.TextAlign = ContentAlignment.TopCenter;
            // 
            // Statistics_Card
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(12, 10, 9);
            Controls.Add(GB3);
            Controls.Add(GB2);
            Controls.Add(GB1);
            Controls.Add(upper_panel_1);
            Name = "Statistics_Card";
            Size = new Size(923, 300);
            upper_panel_1.ResumeLayout(false);
            upper_panel_1.PerformLayout();
            GB1.ResumeLayout(false);
            GB1.PerformLayout();
            GB2.ResumeLayout(false);
            GB3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel upper_panel_1;
        private Label title_lbl;
        private Label Interpretation_lbl;
        private GroupBox GB1;
        private GroupBox GB2;
        private Label average_time_lbl;
        private GroupBox GB3;
        private Label Average_score_lbl;
    }
}
