namespace Gamify__Quizzlett_Application.Forms
{
    partial class Edit_Question
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
            left_panel = new Panel();
            return_btn = new Button();
            SaveExit_btn = new Button();
            Add_btn = new Button();
            Actions = new Label();
            right_panel = new Panel();
            top_panel = new Panel();
            name_lbl_display = new Label();
            card_panel = new FlowLayoutPanel();
            bottom_pnl = new Panel();
            left_panel.SuspendLayout();
            top_panel.SuspendLayout();
            SuspendLayout();
            // 
            // left_panel
            // 
            left_panel.BackColor = Color.FromArgb(23, 23, 23);
            left_panel.Controls.Add(return_btn);
            left_panel.Controls.Add(SaveExit_btn);
            left_panel.Controls.Add(Add_btn);
            left_panel.Controls.Add(Actions);
            left_panel.Dock = DockStyle.Left;
            left_panel.Location = new Point(0, 0);
            left_panel.Name = "left_panel";
            left_panel.Size = new Size(234, 724);
            left_panel.TabIndex = 0;
            // 
            // return_btn
            // 
            return_btn.BackgroundImage = Properties.Resources.log_in__5_;
            return_btn.BackgroundImageLayout = ImageLayout.Center;
            return_btn.FlatStyle = FlatStyle.Popup;
            return_btn.Location = new Point(12, 21);
            return_btn.Name = "return_btn";
            return_btn.Size = new Size(39, 40);
            return_btn.TabIndex = 9;
            return_btn.UseVisualStyleBackColor = true;
            return_btn.Click += return_btn_Click;
            // 
            // SaveExit_btn
            // 
            SaveExit_btn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            SaveExit_btn.FlatStyle = FlatStyle.Flat;
            SaveExit_btn.Font = new Font("Architects Daughter", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SaveExit_btn.ForeColor = SystemColors.ButtonHighlight;
            SaveExit_btn.Location = new Point(36, 235);
            SaveExit_btn.Name = "SaveExit_btn";
            SaveExit_btn.Size = new Size(157, 84);
            SaveExit_btn.TabIndex = 12;
            SaveExit_btn.Text = "Save and Exit";
            SaveExit_btn.UseVisualStyleBackColor = true;
            SaveExit_btn.Click += SaveExit_btn_Click;
            // 
            // Add_btn
            // 
            Add_btn.FlatStyle = FlatStyle.Flat;
            Add_btn.Font = new Font("Architects Daughter", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Add_btn.ForeColor = SystemColors.ButtonHighlight;
            Add_btn.Location = new Point(36, 162);
            Add_btn.Name = "Add_btn";
            Add_btn.Size = new Size(157, 55);
            Add_btn.TabIndex = 10;
            Add_btn.Text = "Add";
            Add_btn.UseVisualStyleBackColor = true;
            Add_btn.Click += Add_btn_Click;
            // 
            // Actions
            // 
            Actions.AutoSize = true;
            Actions.Font = new Font("Architects Daughter", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Actions.ForeColor = Color.Transparent;
            Actions.Location = new Point(20, 122);
            Actions.Name = "Actions";
            Actions.Size = new Size(73, 25);
            Actions.TabIndex = 11;
            Actions.Text = "Actions";
            // 
            // right_panel
            // 
            right_panel.BackColor = Color.FromArgb(23, 23, 23);
            right_panel.Dock = DockStyle.Right;
            right_panel.Location = new Point(1475, 74);
            right_panel.Margin = new Padding(3, 4, 3, 4);
            right_panel.Name = "right_panel";
            right_panel.Size = new Size(26, 650);
            right_panel.TabIndex = 4;
            // 
            // top_panel
            // 
            top_panel.AutoScroll = true;
            top_panel.BackColor = Color.FromArgb(23, 23, 23);
            top_panel.Controls.Add(name_lbl_display);
            top_panel.Dock = DockStyle.Top;
            top_panel.Location = new Point(234, 0);
            top_panel.Margin = new Padding(3, 4, 3, 4);
            top_panel.Name = "top_panel";
            top_panel.Size = new Size(1267, 74);
            top_panel.TabIndex = 3;
            // 
            // name_lbl_display
            // 
            name_lbl_display.Font = new Font("Architects Daughter", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            name_lbl_display.ForeColor = Color.Transparent;
            name_lbl_display.Location = new Point(25, 21);
            name_lbl_display.Name = "name_lbl_display";
            name_lbl_display.Size = new Size(646, 31);
            name_lbl_display.TabIndex = 0;
            name_lbl_display.Text = "Name";
            // 
            // card_panel
            // 
            card_panel.AutoScroll = true;
            card_panel.Dock = DockStyle.Fill;
            card_panel.Location = new Point(234, 74);
            card_panel.Margin = new Padding(3, 4, 3, 4);
            card_panel.Name = "card_panel";
            card_panel.RightToLeft = RightToLeft.No;
            card_panel.Size = new Size(1241, 631);
            card_panel.TabIndex = 5;
            // 
            // bottom_pnl
            // 
            bottom_pnl.BackColor = Color.FromArgb(23, 23, 23);
            bottom_pnl.Dock = DockStyle.Bottom;
            bottom_pnl.Location = new Point(234, 705);
            bottom_pnl.Name = "bottom_pnl";
            bottom_pnl.Size = new Size(1241, 19);
            bottom_pnl.TabIndex = 5;
            // 
            // Edit_Question
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(9, 9, 11);
            ClientSize = new Size(1501, 724);
            Controls.Add(card_panel);
            Controls.Add(bottom_pnl);
            Controls.Add(right_panel);
            Controls.Add(top_panel);
            Controls.Add(left_panel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Edit_Question";
            Text = "Edit_Question";
            left_panel.ResumeLayout(false);
            left_panel.PerformLayout();
            top_panel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel left_panel;
        private Panel right_panel;
        private Panel top_panel;
        private Label name_lbl_display;
        private FlowLayoutPanel card_panel;
        private Panel bottom_pnl;
        private Button return_btn;
        private Button SaveExit_btn;
        private Button Add_btn;
        private Label Actions;
    }
}