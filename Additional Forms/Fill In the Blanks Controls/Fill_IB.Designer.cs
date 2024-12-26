namespace Gamify__Quizzlett_Application.Additional_Forms.Fill_In_the_Blanks_Controls
{
    partial class Fill_IB
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
            image_panel = new Panel();
            question_txbx = new TextBox();
            parse_lbl = new Label();
            answer_txbx = new TextBox();
            skipOrNext_btn = new Button();
            question_number_lbl = new Label();
            question_dsp_lbl = new Label();
            message_lbl = new Label();
            highlight_1 = new Panel();
            SuspendLayout();
            // 
            // image_panel
            // 
            image_panel.AllowDrop = true;
            image_panel.BackgroundImageLayout = ImageLayout.Stretch;
            image_panel.Location = new Point(89, 96);
            image_panel.Name = "image_panel";
            image_panel.Size = new Size(316, 277);
            image_panel.TabIndex = 0;
            // 
            // question_txbx
            // 
            question_txbx.Location = new Point(411, 96);
            question_txbx.Multiline = true;
            question_txbx.Name = "question_txbx";
            question_txbx.ReadOnly = true;
            question_txbx.ScrollBars = ScrollBars.Vertical;
            question_txbx.Size = new Size(695, 277);
            question_txbx.TabIndex = 1;
            // 
            // parse_lbl
            // 
            parse_lbl.Font = new Font("Architects Daughter", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            parse_lbl.ForeColor = SystemColors.ButtonHighlight;
            parse_lbl.Location = new Point(89, 411);
            parse_lbl.Name = "parse_lbl";
            parse_lbl.Size = new Size(1017, 25);
            parse_lbl.TabIndex = 2;
            parse_lbl.Text = "__ __ __ S __ __ __ R";
            parse_lbl.TextAlign = ContentAlignment.TopCenter;
            // 
            // answer_txbx
            // 
            answer_txbx.Font = new Font("Architects Daughter", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            answer_txbx.Location = new Point(89, 462);
            answer_txbx.Name = "answer_txbx";
            answer_txbx.PlaceholderText = "Type Your Answer Here";
            answer_txbx.Size = new Size(1017, 35);
            answer_txbx.TabIndex = 3;
            answer_txbx.TextAlign = HorizontalAlignment.Center;
            answer_txbx.TextChanged += answer_txbx_TextChanged;
            answer_txbx.KeyDown += answer_txbx_KeyDown;
            // 
            // skipOrNext_btn
            // 
            skipOrNext_btn.FlatStyle = FlatStyle.Flat;
            skipOrNext_btn.Font = new Font("Architects Daughter", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            skipOrNext_btn.ForeColor = SystemColors.ButtonHighlight;
            skipOrNext_btn.Location = new Point(1012, 597);
            skipOrNext_btn.Name = "skipOrNext_btn";
            skipOrNext_btn.Size = new Size(94, 29);
            skipOrNext_btn.TabIndex = 8;
            skipOrNext_btn.Text = "Skip";
            skipOrNext_btn.UseVisualStyleBackColor = true;
            skipOrNext_btn.Click += skipOrNext_btn_Click;
            // 
            // question_number_lbl
            // 
            question_number_lbl.AutoSize = true;
            question_number_lbl.Font = new Font("Architects Daughter", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            question_number_lbl.ForeColor = SystemColors.ButtonHighlight;
            question_number_lbl.Location = new Point(186, 45);
            question_number_lbl.Name = "question_number_lbl";
            question_number_lbl.Size = new Size(15, 28);
            question_number_lbl.TabIndex = 10;
            question_number_lbl.Text = "1";
            // 
            // question_dsp_lbl
            // 
            question_dsp_lbl.AutoSize = true;
            question_dsp_lbl.Font = new Font("Architects Daughter", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            question_dsp_lbl.ForeColor = SystemColors.ButtonHighlight;
            question_dsp_lbl.Location = new Point(89, 45);
            question_dsp_lbl.Name = "question_dsp_lbl";
            question_dsp_lbl.Size = new Size(91, 28);
            question_dsp_lbl.TabIndex = 9;
            question_dsp_lbl.Text = "Question";
            // 
            // message_lbl
            // 
            message_lbl.Font = new Font("Architects Daughter", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            message_lbl.ForeColor = SystemColors.ButtonHighlight;
            message_lbl.Location = new Point(252, 519);
            message_lbl.Name = "message_lbl";
            message_lbl.Size = new Size(676, 25);
            message_lbl.TabIndex = 11;
            message_lbl.Text = "Type your answer carefully!!";
            message_lbl.TextAlign = ContentAlignment.TopCenter;
            // 
            // highlight_1
            // 
            highlight_1.Dock = DockStyle.Top;
            highlight_1.Location = new Point(0, 0);
            highlight_1.Name = "highlight_1";
            highlight_1.Size = new Size(1205, 19);
            highlight_1.TabIndex = 12;
            // 
            // Fill_IB
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(26, 46, 5);
            Controls.Add(highlight_1);
            Controls.Add(message_lbl);
            Controls.Add(question_number_lbl);
            Controls.Add(question_dsp_lbl);
            Controls.Add(skipOrNext_btn);
            Controls.Add(answer_txbx);
            Controls.Add(parse_lbl);
            Controls.Add(question_txbx);
            Controls.Add(image_panel);
            Name = "Fill_IB";
            Size = new Size(1205, 663);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel image_panel;
        private TextBox question_txbx;
        private Label parse_lbl;
        private TextBox answer_txbx;
        public Button skipOrNext_btn;
        private Label question_number_lbl;
        private Label question_dsp_lbl;
        private Label message_lbl;
        private Panel highlight_1;
    }
}
