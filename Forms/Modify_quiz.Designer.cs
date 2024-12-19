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
            statusStrip1 = new StatusStrip();
            toolStrip_status = new ToolStripStatusLabel();
            Actions = new Label();
            SaveExit_btn = new Button();
            right_panel = new Panel();
            groupBox1 = new GroupBox();
            panel1 = new Panel();
            color_panel2 = new Panel();
            card_panel = new FlowLayoutPanel();
            color_panel = new Panel();
            name_lbl_display = new Label();
            statusStrip1.SuspendLayout();
            right_panel.SuspendLayout();
            panel1.SuspendLayout();
            color_panel.SuspendLayout();
            SuspendLayout();
            // 
            // return_btn
            // 
            return_btn.BackgroundImage = Properties.Resources.log_in__5_;
            return_btn.BackgroundImageLayout = ImageLayout.Center;
            return_btn.FlatStyle = FlatStyle.Popup;
            return_btn.Location = new Point(15, 12);
            return_btn.Margin = new Padding(3, 2, 3, 2);
            return_btn.Name = "return_btn";
            return_btn.Size = new Size(34, 30);
            return_btn.TabIndex = 1;
            return_btn.UseVisualStyleBackColor = true;
            return_btn.Click += return_btn_Click;
            // 
            // Add_btn
            // 
            Add_btn.FlatStyle = FlatStyle.Flat;
            Add_btn.Font = new Font("Architects Daughter", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Add_btn.ForeColor = SystemColors.ButtonHighlight;
            Add_btn.Location = new Point(22, 118);
            Add_btn.Margin = new Padding(3, 2, 3, 2);
            Add_btn.Name = "Add_btn";
            Add_btn.Size = new Size(137, 41);
            Add_btn.TabIndex = 3;
            Add_btn.Text = "Add";
            Add_btn.UseVisualStyleBackColor = true;
            Add_btn.Click += Add_btn_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.BackColor = Color.FromArgb(30, 41, 59);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStrip_status });
            statusStrip1.Location = new Point(0, 556);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1329, 22);
            statusStrip1.TabIndex = 5;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStrip_status
            // 
            toolStrip_status.BackColor = Color.FromArgb(226, 232, 240);
            toolStrip_status.Name = "toolStrip_status";
            toolStrip_status.Size = new Size(224, 17);
            toolStrip_status.Text = "Hover on diffrent elements to view status";
            // 
            // Actions
            // 
            Actions.AutoSize = true;
            Actions.Font = new Font("Architects Daughter", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Actions.ForeColor = Color.Transparent;
            Actions.Location = new Point(22, 88);
            Actions.Name = "Actions";
            Actions.Size = new Size(58, 20);
            Actions.TabIndex = 7;
            Actions.Text = "Actions";
            // 
            // SaveExit_btn
            // 
            SaveExit_btn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            SaveExit_btn.FlatStyle = FlatStyle.Flat;
            SaveExit_btn.Font = new Font("Architects Daughter", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SaveExit_btn.ForeColor = SystemColors.ButtonHighlight;
            SaveExit_btn.Location = new Point(22, 411);
            SaveExit_btn.Margin = new Padding(3, 2, 3, 2);
            SaveExit_btn.Name = "SaveExit_btn";
            SaveExit_btn.Size = new Size(137, 63);
            SaveExit_btn.TabIndex = 8;
            SaveExit_btn.Text = "Save and Exit";
            SaveExit_btn.UseVisualStyleBackColor = true;
            SaveExit_btn.Click += SaveExit_btn_Click;
            // 
            // right_panel
            // 
            right_panel.BackColor = Color.FromArgb(23, 23, 23);
            right_panel.Controls.Add(groupBox1);
            right_panel.Controls.Add(return_btn);
            right_panel.Controls.Add(SaveExit_btn);
            right_panel.Controls.Add(Add_btn);
            right_panel.Controls.Add(Actions);
            right_panel.Dock = DockStyle.Left;
            right_panel.Location = new Point(0, 0);
            right_panel.Name = "right_panel";
            right_panel.Size = new Size(181, 556);
            right_panel.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(22, 156);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(137, 250);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(12, 10, 9);
            panel1.Controls.Add(color_panel2);
            panel1.Controls.Add(card_panel);
            panel1.Controls.Add(color_panel);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1329, 578);
            panel1.TabIndex = 6;
            // 
            // color_panel2
            // 
            color_panel2.BackColor = Color.FromArgb(63, 63, 70);
            color_panel2.Dock = DockStyle.Right;
            color_panel2.Location = new Point(1306, 57);
            color_panel2.Name = "color_panel2";
            color_panel2.Size = new Size(23, 521);
            color_panel2.TabIndex = 2;
            // 
            // card_panel
            // 
            card_panel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            card_panel.AutoScroll = true;
            card_panel.Location = new Point(180, 57);
            card_panel.Name = "card_panel";
            card_panel.RightToLeft = RightToLeft.No;
            card_panel.Size = new Size(1126, 499);
            card_panel.TabIndex = 0;
            // 
            // color_panel
            // 
            color_panel.AutoScroll = true;
            color_panel.BackColor = Color.FromArgb(63, 63, 70);
            color_panel.Controls.Add(name_lbl_display);
            color_panel.Dock = DockStyle.Top;
            color_panel.Location = new Point(0, 0);
            color_panel.Name = "color_panel";
            color_panel.Size = new Size(1329, 57);
            color_panel.TabIndex = 1;
            // 
            // name_lbl_display
            // 
            name_lbl_display.Font = new Font("Architects Daughter", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            name_lbl_display.ForeColor = Color.Transparent;
            name_lbl_display.Location = new Point(205, 16);
            name_lbl_display.Name = "name_lbl_display";
            name_lbl_display.Size = new Size(565, 23);
            name_lbl_display.TabIndex = 0;
            name_lbl_display.Text = "Name";
            // 
            // Modify_Quiz_form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(9, 9, 11);
            ClientSize = new Size(1329, 578);
            Controls.Add(right_panel);
            Controls.Add(statusStrip1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Modify_Quiz_form";
            Text = "Modify Quiz";
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            right_panel.ResumeLayout(false);
            right_panel.PerformLayout();
            panel1.ResumeLayout(false);
            color_panel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button return_btn;
        private Button Add_btn;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStrip_status;
        private Label Actions;
        private Button SaveExit_btn;
        private Panel right_panel;
        private Panel panel1;
        private FlowLayoutPanel card_panel;
        private Panel color_panel;
        private Panel color_panel2;
        private Label name_lbl_display;
        private GroupBox groupBox1;
    }
}