namespace Gamify__Quizzlett_Application.Additional_Forms.Identification_Controls
{
    partial class Identification_img
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
            submit_btn = new Button();
            skipOrNext_btn = new Button();
            hidden_msg_lbl = new Label();
            hidden_ans_lbl = new Label();
            answer_txbx = new TextBox();
            question_txbx = new TextBox();
            question_number_lbl = new Label();
            question_dsp_lbl = new Label();
            image_panel = new Panel();
            SuspendLayout();
            // 
            // submit_btn
            // 
            submit_btn.FlatStyle = FlatStyle.Flat;
            submit_btn.Font = new Font("Architects Daughter", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            submit_btn.ForeColor = SystemColors.ButtonHighlight;
            submit_btn.Location = new Point(551, 414);
            submit_btn.Name = "submit_btn";
            submit_btn.Size = new Size(94, 29);
            submit_btn.TabIndex = 14;
            submit_btn.Text = "Submit";
            submit_btn.UseVisualStyleBackColor = true;
            submit_btn.Click += submit_btn_Click;
            // 
            // skipOrNext_btn
            // 
            skipOrNext_btn.FlatStyle = FlatStyle.Flat;
            skipOrNext_btn.Font = new Font("Architects Daughter", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            skipOrNext_btn.ForeColor = SystemColors.ButtonHighlight;
            skipOrNext_btn.Location = new Point(1007, 577);
            skipOrNext_btn.Name = "skipOrNext_btn";
            skipOrNext_btn.Size = new Size(94, 29);
            skipOrNext_btn.TabIndex = 13;
            skipOrNext_btn.Text = "Skip";
            skipOrNext_btn.UseVisualStyleBackColor = true;
            skipOrNext_btn.Click += skipOrNext_btn_Click;
            // 
            // hidden_msg_lbl
            // 
            hidden_msg_lbl.Font = new Font("Architects Daughter", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            hidden_msg_lbl.ForeColor = SystemColors.ButtonFace;
            hidden_msg_lbl.Location = new Point(171, 464);
            hidden_msg_lbl.Name = "hidden_msg_lbl";
            hidden_msg_lbl.Size = new Size(825, 25);
            hidden_msg_lbl.TabIndex = 12;
            hidden_msg_lbl.Text = "Type your answer correctly !!";
            hidden_msg_lbl.TextAlign = ContentAlignment.TopCenter;
            // 
            // hidden_ans_lbl
            // 
            hidden_ans_lbl.Font = new Font("Architects Daughter", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            hidden_ans_lbl.ForeColor = SystemColors.ButtonHighlight;
            hidden_ans_lbl.Location = new Point(184, 489);
            hidden_ans_lbl.Name = "hidden_ans_lbl";
            hidden_ans_lbl.Size = new Size(825, 25);
            hidden_ans_lbl.TabIndex = 11;
            hidden_ans_lbl.Text = "Hidden Answer";
            hidden_ans_lbl.TextAlign = ContentAlignment.MiddleCenter;
            hidden_ans_lbl.Visible = false;
            // 
            // answer_txbx
            // 
            answer_txbx.Font = new Font("Architects Daughter", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            answer_txbx.Location = new Point(104, 361);
            answer_txbx.Name = "answer_txbx";
            answer_txbx.PlaceholderText = "Type your answer here......";
            answer_txbx.Size = new Size(997, 31);
            answer_txbx.TabIndex = 10;
            answer_txbx.TextChanged += answer_txbx_TextChanged;
            // 
            // question_txbx
            // 
            question_txbx.Font = new Font("Architects Daughter", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            question_txbx.Location = new Point(514, 75);
            question_txbx.Multiline = true;
            question_txbx.Name = "question_txbx";
            question_txbx.ReadOnly = true;
            question_txbx.ScrollBars = ScrollBars.Vertical;
            question_txbx.Size = new Size(582, 280);
            question_txbx.TabIndex = 9;
            question_txbx.TextAlign = HorizontalAlignment.Center;
            // 
            // question_number_lbl
            // 
            question_number_lbl.AutoSize = true;
            question_number_lbl.Font = new Font("Architects Daughter", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            question_number_lbl.ForeColor = SystemColors.ButtonHighlight;
            question_number_lbl.Location = new Point(201, 26);
            question_number_lbl.Name = "question_number_lbl";
            question_number_lbl.Size = new Size(15, 28);
            question_number_lbl.TabIndex = 16;
            question_number_lbl.Text = "1";
            // 
            // question_dsp_lbl
            // 
            question_dsp_lbl.AutoSize = true;
            question_dsp_lbl.Font = new Font("Architects Daughter", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            question_dsp_lbl.ForeColor = SystemColors.ButtonHighlight;
            question_dsp_lbl.Location = new Point(104, 26);
            question_dsp_lbl.Name = "question_dsp_lbl";
            question_dsp_lbl.Size = new Size(91, 28);
            question_dsp_lbl.TabIndex = 15;
            question_dsp_lbl.Text = "Question";
            // 
            // image_panel
            // 
            image_panel.AllowDrop = true;
            image_panel.Location = new Point(102, 75);
            image_panel.Name = "image_panel";
            image_panel.Size = new Size(406, 280);
            image_panel.TabIndex = 17;
            // 
            // Identification_img
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 16, 101);
            Controls.Add(image_panel);
            Controls.Add(question_number_lbl);
            Controls.Add(question_dsp_lbl);
            Controls.Add(submit_btn);
            Controls.Add(skipOrNext_btn);
            Controls.Add(hidden_msg_lbl);
            Controls.Add(hidden_ans_lbl);
            Controls.Add(answer_txbx);
            Controls.Add(question_txbx);
            Name = "Identification_img";
            Size = new Size(1205, 663);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button submit_btn;
        public Button skipOrNext_btn;
        private Label hidden_msg_lbl;
        private Label hidden_ans_lbl;
        private TextBox answer_txbx;
        private TextBox question_txbx;
        private Label question_number_lbl;
        private Label question_dsp_lbl;
        private Panel image_panel;
    }
}
