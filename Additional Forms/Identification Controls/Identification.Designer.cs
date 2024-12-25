namespace Gamify__Quizzlett_Application.Additional_Forms.Identification_Controls
{
    partial class Identification
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
            question_txbx = new TextBox();
            answer_txbx = new TextBox();
            question_dsp_lbl = new Label();
            question_number_lbl = new Label();
            label1 = new Label();
            hidden_ans_lbl = new Label();
            hidden_msg_lbl = new Label();
            skipOrNext_btn = new Button();
            submit_btn = new Button();
            SuspendLayout();
            // 
            // question_txbx
            // 
            question_txbx.Font = new Font("Architects Daughter", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            question_txbx.Location = new Point(100, 74);
            question_txbx.Multiline = true;
            question_txbx.Name = "question_txbx";
            question_txbx.ReadOnly = true;
            question_txbx.ScrollBars = ScrollBars.Vertical;
            question_txbx.Size = new Size(992, 223);
            question_txbx.TabIndex = 0;
            question_txbx.TextAlign = HorizontalAlignment.Center;
            // 
            // answer_txbx
            // 
            answer_txbx.Font = new Font("Architects Daughter", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            answer_txbx.Location = new Point(100, 360);
            answer_txbx.Name = "answer_txbx";
            answer_txbx.PlaceholderText = "Type your answer here......";
            answer_txbx.Size = new Size(997, 31);
            answer_txbx.TabIndex = 1;
            answer_txbx.TextChanged += answer_txbx_TextChanged;
            // 
            // question_dsp_lbl
            // 
            question_dsp_lbl.AutoSize = true;
            question_dsp_lbl.Font = new Font("Architects Daughter", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            question_dsp_lbl.ForeColor = SystemColors.ButtonHighlight;
            question_dsp_lbl.Location = new Point(100, 43);
            question_dsp_lbl.Name = "question_dsp_lbl";
            question_dsp_lbl.Size = new Size(91, 28);
            question_dsp_lbl.TabIndex = 2;
            question_dsp_lbl.Text = "Question";
            // 
            // question_number_lbl
            // 
            question_number_lbl.AutoSize = true;
            question_number_lbl.Font = new Font("Architects Daughter", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            question_number_lbl.ForeColor = SystemColors.ButtonHighlight;
            question_number_lbl.Location = new Point(197, 43);
            question_number_lbl.Name = "question_number_lbl";
            question_number_lbl.Size = new Size(15, 28);
            question_number_lbl.TabIndex = 3;
            question_number_lbl.Text = "1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Architects Daughter", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(100, 329);
            label1.Name = "label1";
            label1.Size = new Size(135, 28);
            label1.TabIndex = 4;
            label1.Text = "Your Answer";
            // 
            // hidden_ans_lbl
            // 
            hidden_ans_lbl.Font = new Font("Architects Daughter", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            hidden_ans_lbl.ForeColor = SystemColors.ButtonHighlight;
            hidden_ans_lbl.Location = new Point(180, 488);
            hidden_ans_lbl.Name = "hidden_ans_lbl";
            hidden_ans_lbl.Size = new Size(825, 25);
            hidden_ans_lbl.TabIndex = 5;
            hidden_ans_lbl.Text = "Hidden Answer";
            hidden_ans_lbl.TextAlign = ContentAlignment.MiddleCenter;
            hidden_ans_lbl.Visible = false;
            // 
            // hidden_msg_lbl
            // 
            hidden_msg_lbl.Font = new Font("Architects Daughter", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            hidden_msg_lbl.ForeColor = SystemColors.ButtonFace;
            hidden_msg_lbl.Location = new Point(167, 463);
            hidden_msg_lbl.Name = "hidden_msg_lbl";
            hidden_msg_lbl.Size = new Size(825, 25);
            hidden_msg_lbl.TabIndex = 6;
            hidden_msg_lbl.Text = "Type your answer correctly !!";
            hidden_msg_lbl.TextAlign = ContentAlignment.TopCenter;
            // 
            // skipOrNext_btn
            // 
            skipOrNext_btn.FlatStyle = FlatStyle.Flat;
            skipOrNext_btn.Font = new Font("Architects Daughter", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            skipOrNext_btn.ForeColor = SystemColors.ButtonHighlight;
            skipOrNext_btn.Location = new Point(1003, 594);
            skipOrNext_btn.Name = "skipOrNext_btn";
            skipOrNext_btn.Size = new Size(94, 29);
            skipOrNext_btn.TabIndex = 7;
            skipOrNext_btn.Text = "Skip";
            skipOrNext_btn.UseVisualStyleBackColor = true;
            skipOrNext_btn.Click += skipOrNext_btn_Click;
            // 
            // submit_btn
            // 
            submit_btn.FlatStyle = FlatStyle.Flat;
            submit_btn.Font = new Font("Architects Daughter", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            submit_btn.ForeColor = SystemColors.ButtonHighlight;
            submit_btn.Location = new Point(547, 413);
            submit_btn.Name = "submit_btn";
            submit_btn.Size = new Size(94, 29);
            submit_btn.TabIndex = 8;
            submit_btn.Text = "Submit";
            submit_btn.UseVisualStyleBackColor = true;
            submit_btn.Click += submit_btn_Click;
            // 
            // Identification
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(4, 47, 46);
            Controls.Add(submit_btn);
            Controls.Add(skipOrNext_btn);
            Controls.Add(hidden_msg_lbl);
            Controls.Add(hidden_ans_lbl);
            Controls.Add(label1);
            Controls.Add(question_number_lbl);
            Controls.Add(question_dsp_lbl);
            Controls.Add(answer_txbx);
            Controls.Add(question_txbx);
            Name = "Identification";
            Size = new Size(1205, 663);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox answer_txbx;
        private Label label1;
        private Label hidden_ans_lbl;
        private Label hidden_msg_lbl;
        private Button submit_btn;
        public Button skipOrNext_btn;
        public TextBox question_txbx;
        public Label question_dsp_lbl;
        public Label question_number_lbl;
    }
}
