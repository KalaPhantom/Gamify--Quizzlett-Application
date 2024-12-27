namespace Gamify__Quizzlett_Application.Forms
{
    partial class ScoreStats
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
            upper_panel = new Panel();
            return_btn = new Button();
            left_margin_panel = new Panel();
            lef_margin_panel = new Panel();
            lower_margin_panel = new Panel();
            Center_panel = new Panel();
            internal_panel_lDock = new Panel();
            ratio_lbl = new Label();
            lbl1 = new Label();
            upper_panel.SuspendLayout();
            Center_panel.SuspendLayout();
            internal_panel_lDock.SuspendLayout();
            SuspendLayout();
            // 
            // upper_panel
            // 
            upper_panel.Controls.Add(return_btn);
            upper_panel.Dock = DockStyle.Top;
            upper_panel.Location = new Point(0, 0);
            upper_panel.Name = "upper_panel";
            upper_panel.Size = new Size(1519, 49);
            upper_panel.TabIndex = 0;
            // 
            // return_btn
            // 
            return_btn.BackgroundImage = Properties.Resources.log_in__5_;
            return_btn.BackgroundImageLayout = ImageLayout.Center;
            return_btn.FlatStyle = FlatStyle.Popup;
            return_btn.Location = new Point(12, 6);
            return_btn.Name = "return_btn";
            return_btn.Size = new Size(39, 40);
            return_btn.TabIndex = 1;
            return_btn.UseVisualStyleBackColor = true;
            return_btn.Click += return_btn_Click;
            // 
            // left_margin_panel
            // 
            left_margin_panel.Dock = DockStyle.Left;
            left_margin_panel.Location = new Point(0, 49);
            left_margin_panel.Name = "left_margin_panel";
            left_margin_panel.Size = new Size(64, 722);
            left_margin_panel.TabIndex = 1;
            // 
            // lef_margin_panel
            // 
            lef_margin_panel.Dock = DockStyle.Right;
            lef_margin_panel.Location = new Point(1458, 49);
            lef_margin_panel.Name = "lef_margin_panel";
            lef_margin_panel.Size = new Size(61, 722);
            lef_margin_panel.TabIndex = 2;
            // 
            // lower_margin_panel
            // 
            lower_margin_panel.Dock = DockStyle.Bottom;
            lower_margin_panel.Location = new Point(64, 714);
            lower_margin_panel.Name = "lower_margin_panel";
            lower_margin_panel.Size = new Size(1394, 57);
            lower_margin_panel.TabIndex = 3;
            // 
            // Center_panel
            // 
            Center_panel.Controls.Add(internal_panel_lDock);
            Center_panel.Dock = DockStyle.Fill;
            Center_panel.Location = new Point(64, 49);
            Center_panel.Name = "Center_panel";
            Center_panel.Size = new Size(1394, 665);
            Center_panel.TabIndex = 4;
            // 
            // internal_panel_lDock
            // 
            internal_panel_lDock.Controls.Add(ratio_lbl);
            internal_panel_lDock.Controls.Add(lbl1);
            internal_panel_lDock.Dock = DockStyle.Fill;
            internal_panel_lDock.Location = new Point(0, 0);
            internal_panel_lDock.Name = "internal_panel_lDock";
            internal_panel_lDock.Size = new Size(1394, 665);
            internal_panel_lDock.TabIndex = 0;
            // 
            // ratio_lbl
            // 
            ratio_lbl.Anchor = AnchorStyles.None;
            ratio_lbl.AutoSize = true;
            ratio_lbl.BackColor = Color.Transparent;
            ratio_lbl.Font = new Font("Architects Daughter", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ratio_lbl.ForeColor = Color.Transparent;
            ratio_lbl.Location = new Point(667, 287);
            ratio_lbl.Name = "ratio_lbl";
            ratio_lbl.Size = new Size(63, 65);
            ratio_lbl.TabIndex = 1;
            ratio_lbl.Text = "1/1";
            // 
            // lbl1
            // 
            lbl1.Anchor = AnchorStyles.None;
            lbl1.AutoSize = true;
            lbl1.Font = new Font("Architects Daughter", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl1.ForeColor = SystemColors.ButtonHighlight;
            lbl1.Location = new Point(660, 227);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(70, 28);
            lbl1.TabIndex = 0;
            lbl1.Text = "Score";
            // 
            // ScoreStats
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(2, 6, 23);
            ClientSize = new Size(1519, 771);
            Controls.Add(Center_panel);
            Controls.Add(lower_margin_panel);
            Controls.Add(lef_margin_panel);
            Controls.Add(left_margin_panel);
            Controls.Add(upper_panel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ScoreStats";
            Text = "ScoreStatd";
            upper_panel.ResumeLayout(false);
            Center_panel.ResumeLayout(false);
            internal_panel_lDock.ResumeLayout(false);
            internal_panel_lDock.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel upper_panel;
        private Panel left_margin_panel;
        private Panel lef_margin_panel;
        private Panel lower_margin_panel;
        private Panel Center_panel;
        private Panel internal_panel_lDock;
        private Label ratio_lbl;
        private Label lbl1;
        private Button return_btn;
    }
}