namespace Gamify__Quizzlett_Application.Forms
{
    partial class Quiz_list
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
            main_card_container = new FlowLayoutPanel();
            highlight_panel = new Panel();
            label1 = new Label();
            main_card_container.SuspendLayout();
            SuspendLayout();
            // 
            // return_btn
            // 
            return_btn.BackgroundImage = Properties.Resources.log_in__5_1;
            return_btn.BackgroundImageLayout = ImageLayout.Center;
            return_btn.FlatStyle = FlatStyle.Popup;
            return_btn.Location = new Point(12, 12);
            return_btn.Name = "return_btn";
            return_btn.Size = new Size(53, 48);
            return_btn.TabIndex = 0;
            return_btn.UseVisualStyleBackColor = true;
            return_btn.Click += return_btn_Click;
            // 
            // main_card_container
            // 
            main_card_container.Anchor = AnchorStyles.None;
            main_card_container.BackColor = Color.FromArgb(41, 37, 36);
            main_card_container.Controls.Add(highlight_panel);
            main_card_container.Location = new Point(93, 96);
            main_card_container.Name = "main_card_container";
            main_card_container.Size = new Size(1378, 678);
            main_card_container.TabIndex = 1;
            // 
            // highlight_panel
            // 
            highlight_panel.Dock = DockStyle.Top;
            highlight_panel.Location = new Point(3, 3);
            highlight_panel.Name = "highlight_panel";
            highlight_panel.Size = new Size(1375, 41);
            highlight_panel.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Architects Daughter", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(93, 47);
            label1.Name = "label1";
            label1.Size = new Size(166, 49);
            label1.TabIndex = 2;
            label1.Text = "Quiz List";
            // 
            // Quiz_list
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(10, 10, 10);
            BackgroundImage = Properties.Resources.BG_131;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1564, 804);
            Controls.Add(label1);
            Controls.Add(main_card_container);
            Controls.Add(return_btn);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Quiz_list";
            Text = "Quiz_list";
            main_card_container.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button return_btn;
        private FlowLayoutPanel main_card_container;
        private Label label1;
        private Panel highlight_panel;
    }
}