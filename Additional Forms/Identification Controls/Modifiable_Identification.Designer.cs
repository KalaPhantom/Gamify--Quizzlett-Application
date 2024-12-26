﻿namespace Gamify__Quizzlett_Application.Additional_Forms.Identification_Controls
{
    partial class Modifiable_Identification
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
            questionHolder_txbx = new TextBox();
            answerHolder_txbx = new TextBox();
            label1 = new Label();
            label2 = new Label();
            groupBox1 = new GroupBox();
            image_panel = new Panel();
            image_lbl = new Label();
            count_lbl = new Label();
            delete_card_btn = new Button();
            highlight_1 = new Panel();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // questionHolder_txbx
            // 
            questionHolder_txbx.Font = new Font("Architects Daughter", 9F);
            questionHolder_txbx.Location = new Point(514, 107);
            questionHolder_txbx.Margin = new Padding(3, 4, 3, 4);
            questionHolder_txbx.Multiline = true;
            questionHolder_txbx.Name = "questionHolder_txbx";
            questionHolder_txbx.PlaceholderText = "Enter your question here....";
            questionHolder_txbx.Size = new Size(562, 393);
            questionHolder_txbx.TabIndex = 0;
            questionHolder_txbx.TextChanged += questionHolder_txbx_TextChanged;
            // 
            // answerHolder_txbx
            // 
            answerHolder_txbx.Font = new Font("Architects Daughter", 9F);
            answerHolder_txbx.Location = new Point(146, 551);
            answerHolder_txbx.Margin = new Padding(3, 4, 3, 4);
            answerHolder_txbx.Name = "answerHolder_txbx";
            answerHolder_txbx.PlaceholderText = "Enter the correct answer here";
            answerHolder_txbx.Size = new Size(930, 31);
            answerHolder_txbx.TabIndex = 1;
            answerHolder_txbx.TextChanged += answerHolder_txbx_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Architects Daughter", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(146, 69);
            label1.Name = "label1";
            label1.Size = new Size(101, 29);
            label1.TabIndex = 2;
            label1.Text = "Question:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Architects Daughter", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(146, 518);
            label2.Name = "label2";
            label2.Size = new Size(87, 29);
            label2.TabIndex = 3;
            label2.Text = "Answer";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(image_panel);
            groupBox1.Location = new Point(146, 93);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(362, 407);
            groupBox1.TabIndex = 18;
            groupBox1.TabStop = false;
            // 
            // image_panel
            // 
            image_panel.AllowDrop = true;
            image_panel.BackgroundImage = Properties.Resources.Side_Border___18_pp1;
            image_panel.Location = new Point(15, 22);
            image_panel.Name = "image_panel";
            image_panel.Size = new Size(334, 371);
            image_panel.TabIndex = 0;
            image_panel.DragDrop += image_panel_DragDrop;
            image_panel.DragEnter += image_panel_DragEnter;
            // 
            // image_lbl
            // 
            image_lbl.AutoSize = true;
            image_lbl.Font = new Font("Architects Daughter", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            image_lbl.ForeColor = SystemColors.ButtonHighlight;
            image_lbl.Location = new Point(214, 489);
            image_lbl.Name = "image_lbl";
            image_lbl.Size = new Size(237, 25);
            image_lbl.TabIndex = 13;
            image_lbl.Text = "Drag and drop Image here";
            // 
            // count_lbl
            // 
            count_lbl.AutoSize = true;
            count_lbl.Font = new Font("Architects Daughter", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            count_lbl.ForeColor = SystemColors.ButtonFace;
            count_lbl.Location = new Point(249, 71);
            count_lbl.Name = "count_lbl";
            count_lbl.Size = new Size(16, 29);
            count_lbl.TabIndex = 20;
            count_lbl.Text = "1";
            // 
            // delete_card_btn
            // 
            delete_card_btn.BackgroundImage = Properties.Resources.delete__1_;
            delete_card_btn.BackgroundImageLayout = ImageLayout.Center;
            delete_card_btn.FlatStyle = FlatStyle.Flat;
            delete_card_btn.ForeColor = SystemColors.ButtonHighlight;
            delete_card_btn.Location = new Point(982, 63);
            delete_card_btn.Name = "delete_card_btn";
            delete_card_btn.Size = new Size(94, 40);
            delete_card_btn.TabIndex = 23;
            delete_card_btn.UseVisualStyleBackColor = true;
            delete_card_btn.Click += delete_card_btn_Click;
            // 
            // highlight_1
            // 
            highlight_1.Dock = DockStyle.Top;
            highlight_1.Location = new Point(0, 0);
            highlight_1.Name = "highlight_1";
            highlight_1.Size = new Size(1205, 19);
            highlight_1.TabIndex = 24;
            // 
            // Modifiable_Identification
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(69, 10, 10);
            Controls.Add(highlight_1);
            Controls.Add(delete_card_btn);
            Controls.Add(image_lbl);
            Controls.Add(count_lbl);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(answerHolder_txbx);
            Controls.Add(questionHolder_txbx);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Modifiable_Identification";
            Size = new Size(1205, 663);
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox questionHolder_txbx;
        private TextBox answerHolder_txbx;
        private Label label1;
        private Label label2;
        private GroupBox groupBox1;
        private Label image_lbl;
        private Label count_lbl;
        private Panel image_panel;
        private Button delete_card_btn;
        private Panel highlight_1;
    }
}
