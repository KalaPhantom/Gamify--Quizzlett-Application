namespace Gamify__Quizzlett_Application.Forms
{
    partial class Modify_Quiz_form
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
            Add_btn = new Button();
            Actions = new Label();
            SaveExit_btn = new Button();
            right_panel = new Panel();
            panel1 = new Panel();
            color_panel2 = new Panel();
            card_panel = new FlowLayoutPanel();
            color_panel = new Panel();
            name_lbl_display = new Label();
            toolStrip_status = new ToolStripStatusLabel();
            statusStrip1 = new StatusStrip();
            right_panel.SuspendLayout();
            panel1.SuspendLayout();
            color_panel.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // return_btn
            // 
            return_btn.BackgroundImage = Properties.Resources.log_in__5_;
            return_btn.BackgroundImageLayout = ImageLayout.Center;
            return_btn.FlatStyle = FlatStyle.Popup;
            return_btn.Location = new Point(17, 16);
            return_btn.Name = "return_btn";
            return_btn.Size = new Size(39, 40);
            return_btn.TabIndex = 1;
            return_btn.UseVisualStyleBackColor = true;
            return_btn.Click += return_btn_Click;
            // 
            // Add_btn
            // 
            Add_btn.FlatStyle = FlatStyle.Flat;
            Add_btn.Font = new Font("Architects Daughter", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Add_btn.ForeColor = SystemColors.ButtonHighlight;
            Add_btn.Location = new Point(25, 157);
            Add_btn.Name = "Add_btn";
            Add_btn.Size = new Size(157, 55);
            Add_btn.TabIndex = 3;
            Add_btn.Text = "Add";
            Add_btn.UseVisualStyleBackColor = true;
            Add_btn.Click += Add_btn_Click;
            // 
            // Actions
            // 
            Actions.AutoSize = true;
            Actions.Font = new Font("Architects Daughter", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Actions.ForeColor = Color.Transparent;
            Actions.Location = new Point(25, 117);
            Actions.Name = "Actions";
            Actions.Size = new Size(73, 25);
            Actions.TabIndex = 7;
            Actions.Text = "Actions";
            // 
            // SaveExit_btn
            // 
            SaveExit_btn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            SaveExit_btn.FlatStyle = FlatStyle.Flat;
            SaveExit_btn.Font = new Font("Architects Daughter", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SaveExit_btn.ForeColor = SystemColors.ButtonHighlight;
            SaveExit_btn.Location = new Point(25, 230);
            SaveExit_btn.Name = "SaveExit_btn";
            SaveExit_btn.Size = new Size(157, 84);
            SaveExit_btn.TabIndex = 8;
            SaveExit_btn.Text = "Save and Exit";
            SaveExit_btn.UseVisualStyleBackColor = true;
            SaveExit_btn.Click += SaveExit_btn_Click;
            // 
            // right_panel
            // 
            right_panel.BackColor = Color.FromArgb(23, 23, 23);
            right_panel.Controls.Add(return_btn);
            right_panel.Controls.Add(SaveExit_btn);
            right_panel.Controls.Add(Add_btn);
            right_panel.Controls.Add(Actions);
            right_panel.Dock = DockStyle.Left;
            right_panel.Location = new Point(0, 0);
            right_panel.Margin = new Padding(3, 4, 3, 4);
            right_panel.Name = "right_panel";
            right_panel.Size = new Size(207, 745);
            right_panel.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(12, 10, 9);
            panel1.Controls.Add(color_panel2);
            panel1.Controls.Add(card_panel);
            panel1.Controls.Add(color_panel);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1519, 771);
            panel1.TabIndex = 6;
            // 
            // color_panel2
            // 
            color_panel2.BackColor = Color.FromArgb(63, 63, 70);
            color_panel2.Dock = DockStyle.Right;
            color_panel2.Location = new Point(1493, 76);
            color_panel2.Margin = new Padding(3, 4, 3, 4);
            color_panel2.Name = "color_panel2";
            color_panel2.Size = new Size(26, 695);
            color_panel2.TabIndex = 2;
            // 
            // card_panel
            // 
            card_panel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            card_panel.AutoScroll = true;
            card_panel.Location = new Point(206, 76);
            card_panel.Margin = new Padding(3, 4, 3, 4);
            card_panel.Name = "card_panel";
            card_panel.RightToLeft = RightToLeft.No;
            card_panel.Size = new Size(1287, 665);
            card_panel.TabIndex = 0;
            // 
            // color_panel
            // 
            color_panel.AutoScroll = true;
            color_panel.BackColor = Color.FromArgb(63, 63, 70);
            color_panel.Controls.Add(name_lbl_display);
            color_panel.Dock = DockStyle.Top;
            color_panel.Location = new Point(0, 0);
            color_panel.Margin = new Padding(3, 4, 3, 4);
            color_panel.Name = "color_panel";
            color_panel.Size = new Size(1519, 76);
            color_panel.TabIndex = 1;
            // 
            // name_lbl_display
            // 
            name_lbl_display.Font = new Font("Architects Daughter", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            name_lbl_display.ForeColor = Color.Transparent;
            name_lbl_display.Location = new Point(234, 21);
            name_lbl_display.Name = "name_lbl_display";
            name_lbl_display.Size = new Size(646, 31);
            name_lbl_display.TabIndex = 0;
            name_lbl_display.Text = "Name";
            // 
            // toolStrip_status
            // 
            toolStrip_status.BackColor = Color.FromArgb(226, 232, 240);
            toolStrip_status.Name = "toolStrip_status";
            toolStrip_status.Size = new Size(281, 20);
            toolStrip_status.Text = "Hover on diffrent elements to view status";
            // 
            // statusStrip1
            // 
            statusStrip1.BackColor = Color.FromArgb(30, 41, 59);
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStrip_status });
            statusStrip1.Location = new Point(0, 745);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new Padding(1, 0, 16, 0);
            statusStrip1.Size = new Size(1519, 26);
            statusStrip1.TabIndex = 5;
            statusStrip1.Text = "statusStrip1";
            // 
            // Modify_Quiz_form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(9, 9, 11);
            ClientSize = new Size(1519, 771);
            Controls.Add(right_panel);
            Controls.Add(statusStrip1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Modify_Quiz_form";
            Text = "Modify Quiz";
            right_panel.ResumeLayout(false);
            right_panel.PerformLayout();
            panel1.ResumeLayout(false);
            color_panel.ResumeLayout(false);
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button return_btn;
        private Button Add_btn;
        private Label Actions;
        private Button SaveExit_btn;
        private Panel right_panel;
        private Panel panel1;
        private FlowLayoutPanel card_panel;
        private Panel color_panel;
        private Panel color_panel2;
        private Label name_lbl_display;
        private ToolStripStatusLabel toolStrip_status;
        private StatusStrip statusStrip1;
    }
}