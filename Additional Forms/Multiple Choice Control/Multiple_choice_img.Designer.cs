namespace Gamify__Quizzlett_Application.Additional_Forms.Multiple_Choice_Control
{
    partial class Multiple_choice_img
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
            question_holder_txbx = new TextBox();
            option_A_btn = new Button();
            option_B_btn = new Button();
            option_D_btn = new Button();
            option_C_btn = new Button();
            image_holder_pnl = new Panel();
            nextOrSkip_button = new Button();
            highlight_1 = new Panel();
            SuspendLayout();
            // 
            // question_holder_txbx
            // 
            question_holder_txbx.Font = new Font("Architects Daughter", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            question_holder_txbx.Location = new Point(538, 40);
            question_holder_txbx.Multiline = true;
            question_holder_txbx.Name = "question_holder_txbx";
            question_holder_txbx.ReadOnly = true;
            question_holder_txbx.ScrollBars = ScrollBars.Vertical;
            question_holder_txbx.Size = new Size(577, 392);
            question_holder_txbx.TabIndex = 9;
            // 
            // option_A_btn
            // 
            option_A_btn.FlatStyle = FlatStyle.Flat;
            option_A_btn.Font = new Font("Architects Daughter", 10.2F);
            option_A_btn.ForeColor = SystemColors.ButtonHighlight;
            option_A_btn.Location = new Point(89, 447);
            option_A_btn.Name = "option_A_btn";
            option_A_btn.Size = new Size(504, 61);
            option_A_btn.TabIndex = 8;
            option_A_btn.Text = "Option A";
            option_A_btn.UseVisualStyleBackColor = true;
            option_A_btn.Click += option_A_btn_Click;
            // 
            // option_B_btn
            // 
            option_B_btn.FlatStyle = FlatStyle.Flat;
            option_B_btn.Font = new Font("Architects Daughter", 10.2F);
            option_B_btn.ForeColor = SystemColors.ButtonHighlight;
            option_B_btn.Location = new Point(619, 447);
            option_B_btn.Name = "option_B_btn";
            option_B_btn.Size = new Size(496, 61);
            option_B_btn.TabIndex = 7;
            option_B_btn.Text = "Option B";
            option_B_btn.UseVisualStyleBackColor = true;
            option_B_btn.Click += option_B_btn_Click;
            // 
            // option_D_btn
            // 
            option_D_btn.FlatStyle = FlatStyle.Flat;
            option_D_btn.Font = new Font("Architects Daughter", 10.2F);
            option_D_btn.ForeColor = SystemColors.ButtonHighlight;
            option_D_btn.Location = new Point(619, 515);
            option_D_btn.Name = "option_D_btn";
            option_D_btn.Size = new Size(496, 61);
            option_D_btn.TabIndex = 6;
            option_D_btn.Text = "Option D";
            option_D_btn.UseVisualStyleBackColor = true;
            option_D_btn.Click += option_D_btn_Click;
            // 
            // option_C_btn
            // 
            option_C_btn.FlatStyle = FlatStyle.Flat;
            option_C_btn.Font = new Font("Architects Daughter", 10.2F);
            option_C_btn.ForeColor = SystemColors.ButtonHighlight;
            option_C_btn.Location = new Point(89, 515);
            option_C_btn.Name = "option_C_btn";
            option_C_btn.Size = new Size(504, 61);
            option_C_btn.TabIndex = 5;
            option_C_btn.Text = "Option C";
            option_C_btn.UseVisualStyleBackColor = true;
            option_C_btn.Click += option_C_btn_Click;
            // 
            // image_holder_pnl
            // 
            image_holder_pnl.BackgroundImageLayout = ImageLayout.Stretch;
            image_holder_pnl.Location = new Point(89, 40);
            image_holder_pnl.Name = "image_holder_pnl";
            image_holder_pnl.Size = new Size(443, 392);
            image_holder_pnl.TabIndex = 10;
            // 
            // nextOrSkip_button
            // 
            nextOrSkip_button.FlatStyle = FlatStyle.Flat;
            nextOrSkip_button.Font = new Font("Architects Daughter", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nextOrSkip_button.ForeColor = SystemColors.ButtonHighlight;
            nextOrSkip_button.Location = new Point(549, 603);
            nextOrSkip_button.Name = "nextOrSkip_button";
            nextOrSkip_button.Size = new Size(121, 40);
            nextOrSkip_button.TabIndex = 11;
            nextOrSkip_button.Text = "Next";
            nextOrSkip_button.UseVisualStyleBackColor = true;
            nextOrSkip_button.Click += nextOrSkip_button_Click;
            // 
            // highlight_1
            // 
            highlight_1.Dock = DockStyle.Top;
            highlight_1.Location = new Point(0, 0);
            highlight_1.Name = "highlight_1";
            highlight_1.Size = new Size(1205, 16);
            highlight_1.TabIndex = 12;
            // 
            // Multiple_choice_img
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(113, 63, 18);
            Controls.Add(highlight_1);
            Controls.Add(nextOrSkip_button);
            Controls.Add(image_holder_pnl);
            Controls.Add(question_holder_txbx);
            Controls.Add(option_A_btn);
            Controls.Add(option_B_btn);
            Controls.Add(option_D_btn);
            Controls.Add(option_C_btn);
            Name = "Multiple_choice_img";
            Size = new Size(1205, 663);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox question_holder_txbx;
        private Button option_A_btn;
        private Button option_B_btn;
        private Button option_D_btn;
        private Button option_C_btn;
        private Panel image_holder_pnl;
        public Button nextOrSkip_button;
        private Panel highlight_1;
    }
}
