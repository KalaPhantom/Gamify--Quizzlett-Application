namespace Gamify__Quizzlett_Application.Forms
{
    partial class Statistics
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
            top_panel = new Panel();
            panel1 = new Panel();
            label1 = new Label();
            main_frame = new Panel();
            control_flp = new FlowLayoutPanel();
            left_main_panel = new Panel();
            rate_lbl = new Label();
            time_avg_lbl = new Label();
            Grade = new Label();
            GradeInterpritation_lbl = new Label();
            panel_top = new Panel();
            top_panel.SuspendLayout();
            panel1.SuspendLayout();
            main_frame.SuspendLayout();
            left_main_panel.SuspendLayout();
            SuspendLayout();
            // 
            // return_btn
            // 
            return_btn.BackgroundImage = Properties.Resources.log_in__5_2;
            return_btn.BackgroundImageLayout = ImageLayout.Center;
            return_btn.FlatStyle = FlatStyle.Popup;
            return_btn.Location = new Point(12, 3);
            return_btn.Name = "return_btn";
            return_btn.Size = new Size(48, 45);
            return_btn.TabIndex = 0;
            return_btn.UseVisualStyleBackColor = true;
            return_btn.Click += return_btn_Click;
            // 
            // top_panel
            // 
            top_panel.Controls.Add(panel1);
            top_panel.Controls.Add(label1);
            top_panel.Dock = DockStyle.Top;
            top_panel.Location = new Point(0, 0);
            top_panel.Name = "top_panel";
            top_panel.Size = new Size(1564, 58);
            top_panel.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Controls.Add(return_btn);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(106, 58);
            panel1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Architects Daughter", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(112, 15);
            label1.Name = "label1";
            label1.Size = new Size(104, 29);
            label1.TabIndex = 1;
            label1.Text = "Statistics";
            // 
            // main_frame
            // 
            main_frame.Anchor = AnchorStyles.None;
            main_frame.Controls.Add(control_flp);
            main_frame.Controls.Add(left_main_panel);
            main_frame.Location = new Point(120, 122);
            main_frame.Name = "main_frame";
            main_frame.Size = new Size(1331, 635);
            main_frame.TabIndex = 2;
            // 
            // control_flp
            // 
            control_flp.AutoScroll = true;
            control_flp.Dock = DockStyle.Fill;
            control_flp.FlowDirection = FlowDirection.TopDown;
            control_flp.Location = new Point(350, 0);
            control_flp.Name = "control_flp";
            control_flp.Size = new Size(981, 635);
            control_flp.TabIndex = 1;
            control_flp.WrapContents = false;
            // 
            // left_main_panel
            // 
            left_main_panel.Controls.Add(rate_lbl);
            left_main_panel.Controls.Add(time_avg_lbl);
            left_main_panel.Controls.Add(Grade);
            left_main_panel.Controls.Add(GradeInterpritation_lbl);
            left_main_panel.Dock = DockStyle.Left;
            left_main_panel.Location = new Point(0, 0);
            left_main_panel.Name = "left_main_panel";
            left_main_panel.Size = new Size(350, 635);
            left_main_panel.TabIndex = 0;
            // 
            // rate_lbl
            // 
            rate_lbl.AutoSize = true;
            rate_lbl.FlatStyle = FlatStyle.System;
            rate_lbl.Font = new Font("Architects Daughter", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rate_lbl.ForeColor = SystemColors.ButtonHighlight;
            rate_lbl.Location = new Point(27, 342);
            rate_lbl.Name = "rate_lbl";
            rate_lbl.Size = new Size(211, 25);
            rate_lbl.TabIndex = 3;
            rate_lbl.Text = "Correct Answer Rate: ";
            // 
            // time_avg_lbl
            // 
            time_avg_lbl.AutoSize = true;
            time_avg_lbl.FlatStyle = FlatStyle.System;
            time_avg_lbl.Font = new Font("Architects Daughter", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            time_avg_lbl.ForeColor = SystemColors.ButtonHighlight;
            time_avg_lbl.Location = new Point(27, 307);
            time_avg_lbl.Name = "time_avg_lbl";
            time_avg_lbl.Size = new Size(133, 25);
            time_avg_lbl.TabIndex = 2;
            time_avg_lbl.Text = "Average Time:";
            // 
            // Grade
            // 
            Grade.AutoSize = true;
            Grade.Font = new Font("Architects Daughter", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Grade.ForeColor = SystemColors.ButtonHighlight;
            Grade.Location = new Point(27, 36);
            Grade.Name = "Grade";
            Grade.Size = new Size(71, 28);
            Grade.TabIndex = 1;
            Grade.Text = "Grade";
            // 
            // GradeInterpritation_lbl
            // 
            GradeInterpritation_lbl.Anchor = AnchorStyles.None;
            GradeInterpritation_lbl.Font = new Font("Architects Daughter", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            GradeInterpritation_lbl.ForeColor = SystemColors.Control;
            GradeInterpritation_lbl.Location = new Point(135, 110);
            GradeInterpritation_lbl.Name = "GradeInterpritation_lbl";
            GradeInterpritation_lbl.Size = new Size(62, 79);
            GradeInterpritation_lbl.TabIndex = 0;
            GradeInterpritation_lbl.Text = "A";
            // 
            // panel_top
            // 
            panel_top.Anchor = AnchorStyles.None;
            panel_top.Location = new Point(120, 92);
            panel_top.Name = "panel_top";
            panel_top.Size = new Size(1328, 31);
            panel_top.TabIndex = 3;
            // 
            // Statistics
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(10, 10, 10);
            ClientSize = new Size(1564, 804);
            Controls.Add(panel_top);
            Controls.Add(main_frame);
            Controls.Add(top_panel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Statistics";
            Text = "Statistics";
            top_panel.ResumeLayout(false);
            top_panel.PerformLayout();
            panel1.ResumeLayout(false);
            main_frame.ResumeLayout(false);
            left_main_panel.ResumeLayout(false);
            left_main_panel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button return_btn;
        private Panel top_panel;
        private Label label1;
        private Panel panel1;
        private Panel main_frame;
        private FlowLayoutPanel control_flp;
        private Panel left_main_panel;
        private Label GradeInterpritation_lbl;
        private Label rate_lbl;
        private Label time_avg_lbl;
        private Label Grade;
        private Panel panel_top;
    }
}