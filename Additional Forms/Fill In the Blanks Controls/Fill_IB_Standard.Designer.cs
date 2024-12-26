namespace Gamify__Quizzlett_Application.Additional_Forms.Fill_In_the_Blanks_Controls
{
    partial class Fill_IB_Standard
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
            message_lbl = new Label();
            question_number_lbl = new Label();
            question_dsp_lbl = new Label();
            skipOrNext_btn = new Button();
            answer_txbx = new TextBox();
            parse_lbl = new Label();
            question_txbx = new TextBox();
            highlight_1 = new Panel();
            SuspendLayout();
            // 
            // message_lbl
            // 
            message_lbl.Font = new Font("Architects Daughter", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            message_lbl.ForeColor = SystemColors.ButtonHighlight;
            message_lbl.Location = new Point(257, 515);
            message_lbl.Name = "message_lbl";
            message_lbl.Size = new Size(676, 25);
            message_lbl.TabIndex = 18;
            message_lbl.Text = "Type your answer carefully!!";
            message_lbl.TextAlign = ContentAlignment.TopCenter;
            // 
            // question_number_lbl
            // 
            question_number_lbl.AutoSize = true;
            question_number_lbl.Font = new Font("Architects Daughter", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            question_number_lbl.ForeColor = SystemColors.ButtonHighlight;
            question_number_lbl.Location = new Point(191, 41);
            question_number_lbl.Name = "question_number_lbl";
            question_number_lbl.Size = new Size(15, 28);
            question_number_lbl.TabIndex = 17;
            question_number_lbl.Text = "1";
            // 
            // question_dsp_lbl
            // 
            question_dsp_lbl.AutoSize = true;
            question_dsp_lbl.Font = new Font("Architects Daughter", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            question_dsp_lbl.ForeColor = SystemColors.ButtonHighlight;
            question_dsp_lbl.Location = new Point(94, 41);
            question_dsp_lbl.Name = "question_dsp_lbl";
            question_dsp_lbl.Size = new Size(91, 28);
            question_dsp_lbl.TabIndex = 16;
            question_dsp_lbl.Text = "Question";
            // 
            // skipOrNext_btn
            // 
            skipOrNext_btn.FlatStyle = FlatStyle.Flat;
            skipOrNext_btn.Font = new Font("Architects Daughter", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            skipOrNext_btn.ForeColor = SystemColors.ButtonHighlight;
            skipOrNext_btn.Location = new Point(1017, 593);
            skipOrNext_btn.Name = "skipOrNext_btn";
            skipOrNext_btn.Size = new Size(94, 29);
            skipOrNext_btn.TabIndex = 15;
            skipOrNext_btn.Text = "Skip";
            skipOrNext_btn.UseVisualStyleBackColor = true;
            skipOrNext_btn.Click += skipOrNext_btn_Click;
            // 
            // answer_txbx
            // 
            answer_txbx.Font = new Font("Architects Daughter", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            answer_txbx.Location = new Point(94, 458);
            answer_txbx.Name = "answer_txbx";
            answer_txbx.PlaceholderText = "Type Your Answer Here";
            answer_txbx.Size = new Size(1017, 35);
            answer_txbx.TabIndex = 14;
            answer_txbx.TextAlign = HorizontalAlignment.Center;
            answer_txbx.TextChanged += answer_txbx_TextChanged;
            answer_txbx.KeyDown += answer_txbx_KeyDown_1;
            // 
            // parse_lbl
            // 
            parse_lbl.Font = new Font("Architects Daughter", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            parse_lbl.ForeColor = SystemColors.ButtonHighlight;
            parse_lbl.Location = new Point(94, 407);
            parse_lbl.Name = "parse_lbl";
            parse_lbl.Size = new Size(1017, 25);
            parse_lbl.TabIndex = 13;
            parse_lbl.Text = "__ __ __ S __ __ __ R";
            parse_lbl.TextAlign = ContentAlignment.TopCenter;
            // 
            // question_txbx
            // 
            question_txbx.Location = new Point(94, 92);
            question_txbx.Multiline = true;
            question_txbx.Name = "question_txbx";
            question_txbx.ReadOnly = true;
            question_txbx.ScrollBars = ScrollBars.Vertical;
            question_txbx.Size = new Size(1017, 277);
            question_txbx.TabIndex = 12;
            // 
            // highlight_1
            // 
            highlight_1.Dock = DockStyle.Top;
            highlight_1.Location = new Point(0, 0);
            highlight_1.Name = "highlight_1";
            highlight_1.Size = new Size(1205, 16);
            highlight_1.TabIndex = 19;
            // 
            // Fill_IB_Standard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 16, 101);
            Controls.Add(highlight_1);
            Controls.Add(message_lbl);
            Controls.Add(question_number_lbl);
            Controls.Add(question_dsp_lbl);
            Controls.Add(skipOrNext_btn);
            Controls.Add(answer_txbx);
            Controls.Add(parse_lbl);
            Controls.Add(question_txbx);
            Name = "Fill_IB_Standard";
            Size = new Size(1205, 663);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label message_lbl;
        private Label question_number_lbl;
        private Label question_dsp_lbl;
        public Button skipOrNext_btn;
        private TextBox answer_txbx;
        private Label parse_lbl;
        private TextBox question_txbx;
        private Panel highlight_1;
    }
}
