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
            label1 = new Label();
            panel1 = new Panel();
            main_frame = new Panel();
            top_panel.SuspendLayout();
            panel1.SuspendLayout();
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
            // panel1
            // 
            panel1.Controls.Add(return_btn);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(106, 58);
            panel1.TabIndex = 2;
            // 
            // main_frame
            // 
            main_frame.Anchor = AnchorStyles.None;
            main_frame.Location = new Point(141, 122);
            main_frame.Name = "main_frame";
            main_frame.Size = new Size(1273, 635);
            main_frame.TabIndex = 2;
            // 
            // Statistics
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(10, 10, 10);
            ClientSize = new Size(1564, 804);
            Controls.Add(main_frame);
            Controls.Add(top_panel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Statistics";
            Text = "Statistics";
            top_panel.ResumeLayout(false);
            top_panel.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button return_btn;
        private Panel top_panel;
        private Label label1;
        private Panel panel1;
        private Panel main_frame;
    }
}