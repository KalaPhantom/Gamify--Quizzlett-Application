namespace Gamify__Quizzlett_Application.Forms
{
    partial class Create_Quiz
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
            panel1 = new Panel();
            groupBox1 = new GroupBox();
            property_txbx = new TextBox();
            create_btn = new MaterialSkin.Controls.MaterialButton();
            panel2 = new Panel();
            showAnswer_R_btn = new Button();
            timer_R_btn = new Button();
            showAnswer_L_btn = new Button();
            timer_L_btn = new Button();
            showAnswer_lbl = new Label();
            label9 = new Label();
            timer_lbl = new Label();
            label7 = new Label();
            mode_arrL = new Button();
            mode_arrR = new Button();
            mode_lbl = new Label();
            label4 = new Label();
            subject_txbx = new MaterialSkin.Controls.MaterialTextBox();
            label3 = new Label();
            quizName_txbx = new MaterialSkin.Controls.MaterialTextBox();
            quiz_name_lbl = new Label();
            inv_groupBox = new GroupBox();
            image_holder_pn = new Panel();
            plus_icon = new Panel();
            label2 = new Label();
            label1 = new Label();
            materialScrollBar1 = new MaterialSkin.Controls.MaterialScrollBar();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            panel2.SuspendLayout();
            inv_groupBox.SuspendLayout();
            image_holder_pn.SuspendLayout();
            SuspendLayout();
            // 
            // return_btn
            // 
            return_btn.BackgroundImage = Properties.Resources.log_in__5_;
            return_btn.BackgroundImageLayout = ImageLayout.Center;
            return_btn.FlatStyle = FlatStyle.Popup;
            return_btn.Location = new Point(12, 12);
            return_btn.Name = "return_btn";
            return_btn.Size = new Size(39, 40);
            return_btn.TabIndex = 0;
            return_btn.UseVisualStyleBackColor = true;
            return_btn.Click += return_btn_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = Color.FromArgb(120, 113, 108);
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(create_btn);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(inv_groupBox);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(345, 23);
            panel1.Name = "panel1";
            panel1.Size = new Size(927, 732);
            panel1.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(property_txbx);
            groupBox1.Location = new Point(60, 370);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(376, 246);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            // 
            // property_txbx
            // 
            property_txbx.Location = new Point(0, 11);
            property_txbx.Multiline = true;
            property_txbx.Name = "property_txbx";
            property_txbx.ReadOnly = true;
            property_txbx.Size = new Size(376, 235);
            property_txbx.TabIndex = 0;
            // 
            // create_btn
            // 
            create_btn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            create_btn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            create_btn.Depth = 0;
            create_btn.HighEmphasis = true;
            create_btn.Icon = null;
            create_btn.Location = new Point(66, 636);
            create_btn.Margin = new Padding(4, 6, 4, 6);
            create_btn.MouseState = MaterialSkin.MouseState.HOVER;
            create_btn.Name = "create_btn";
            create_btn.NoAccentTextColor = Color.Empty;
            create_btn.Size = new Size(76, 36);
            create_btn.TabIndex = 6;
            create_btn.Text = "Create";
            create_btn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            create_btn.UseAccentColor = false;
            create_btn.UseVisualStyleBackColor = true;
            create_btn.Click += create_btn_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(28, 25, 23);
            panel2.Controls.Add(showAnswer_R_btn);
            panel2.Controls.Add(timer_R_btn);
            panel2.Controls.Add(showAnswer_L_btn);
            panel2.Controls.Add(timer_L_btn);
            panel2.Controls.Add(showAnswer_lbl);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(timer_lbl);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(mode_arrL);
            panel2.Controls.Add(mode_arrR);
            panel2.Controls.Add(mode_lbl);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(subject_txbx);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(quizName_txbx);
            panel2.Controls.Add(quiz_name_lbl);
            panel2.Location = new Point(452, 86);
            panel2.Name = "panel2";
            panel2.Size = new Size(438, 575);
            panel2.TabIndex = 5;
            // 
            // showAnswer_R_btn
            // 
            showAnswer_R_btn.BackgroundImage = Properties.Resources.png_3qy3mj;
            showAnswer_R_btn.BackgroundImageLayout = ImageLayout.Center;
            showAnswer_R_btn.FlatStyle = FlatStyle.Flat;
            showAnswer_R_btn.Location = new Point(316, 457);
            showAnswer_R_btn.Name = "showAnswer_R_btn";
            showAnswer_R_btn.Size = new Size(94, 29);
            showAnswer_R_btn.TabIndex = 20;
            showAnswer_R_btn.UseVisualStyleBackColor = true;
            showAnswer_R_btn.Click += showAnswer_R_btn_Click;
            // 
            // timer_R_btn
            // 
            timer_R_btn.BackgroundImage = Properties.Resources.png_3qy3mj;
            timer_R_btn.BackgroundImageLayout = ImageLayout.Center;
            timer_R_btn.FlatStyle = FlatStyle.Flat;
            timer_R_btn.Location = new Point(316, 368);
            timer_R_btn.Name = "timer_R_btn";
            timer_R_btn.Size = new Size(94, 29);
            timer_R_btn.TabIndex = 19;
            timer_R_btn.UseVisualStyleBackColor = true;
            timer_R_btn.Click += timer_R_btn_Click;
            // 
            // showAnswer_L_btn
            // 
            showAnswer_L_btn.BackgroundImage = Properties.Resources.png_0q6s6;
            showAnswer_L_btn.BackgroundImageLayout = ImageLayout.Center;
            showAnswer_L_btn.FlatStyle = FlatStyle.Flat;
            showAnswer_L_btn.Location = new Point(18, 457);
            showAnswer_L_btn.Name = "showAnswer_L_btn";
            showAnswer_L_btn.Size = new Size(94, 29);
            showAnswer_L_btn.TabIndex = 18;
            showAnswer_L_btn.UseVisualStyleBackColor = true;
            showAnswer_L_btn.Click += showAnswer_L_btn_Click;
            // 
            // timer_L_btn
            // 
            timer_L_btn.BackgroundImage = Properties.Resources.png_0q6s6;
            timer_L_btn.BackgroundImageLayout = ImageLayout.Center;
            timer_L_btn.FlatStyle = FlatStyle.Flat;
            timer_L_btn.Location = new Point(18, 368);
            timer_L_btn.Name = "timer_L_btn";
            timer_L_btn.Size = new Size(94, 29);
            timer_L_btn.TabIndex = 17;
            timer_L_btn.UseVisualStyleBackColor = true;
            timer_L_btn.Click += timer_L_btn_Click;
            // 
            // showAnswer_lbl
            // 
            showAnswer_lbl.Font = new Font("Architects Daughter", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            showAnswer_lbl.ForeColor = SystemColors.ButtonHighlight;
            showAnswer_lbl.Location = new Point(118, 457);
            showAnswer_lbl.Name = "showAnswer_lbl";
            showAnswer_lbl.Size = new Size(192, 29);
            showAnswer_lbl.TabIndex = 16;
            showAnswer_lbl.Text = "Mode";
            showAnswer_lbl.TextAlign = ContentAlignment.TopCenter;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Architects Daughter", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = SystemColors.ButtonHighlight;
            label9.Location = new Point(18, 418);
            label9.Name = "label9";
            label9.Size = new Size(160, 29);
            label9.TabIndex = 15;
            label9.Text = "Show Answer?";
            // 
            // timer_lbl
            // 
            timer_lbl.Font = new Font("Architects Daughter", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            timer_lbl.ForeColor = SystemColors.ButtonHighlight;
            timer_lbl.Location = new Point(118, 368);
            timer_lbl.Name = "timer_lbl";
            timer_lbl.Size = new Size(192, 29);
            timer_lbl.TabIndex = 12;
            timer_lbl.Text = "Mode";
            timer_lbl.TextAlign = ContentAlignment.TopCenter;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Architects Daughter", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ButtonHighlight;
            label7.Location = new Point(18, 329);
            label7.Name = "label7";
            label7.Size = new Size(154, 29);
            label7.TabIndex = 11;
            label7.Text = "Enable Timer?";
            // 
            // mode_arrL
            // 
            mode_arrL.BackgroundImage = Properties.Resources.png_0q6s6;
            mode_arrL.BackgroundImageLayout = ImageLayout.Center;
            mode_arrL.FlatStyle = FlatStyle.Flat;
            mode_arrL.Location = new Point(18, 286);
            mode_arrL.Name = "mode_arrL";
            mode_arrL.Size = new Size(94, 29);
            mode_arrL.TabIndex = 10;
            mode_arrL.UseVisualStyleBackColor = true;
            mode_arrL.Click += mode_arrL_Click;
            // 
            // mode_arrR
            // 
            mode_arrR.BackgroundImage = Properties.Resources.png_3qy3mj;
            mode_arrR.BackgroundImageLayout = ImageLayout.Center;
            mode_arrR.FlatStyle = FlatStyle.Flat;
            mode_arrR.Location = new Point(316, 286);
            mode_arrR.Name = "mode_arrR";
            mode_arrR.Size = new Size(94, 29);
            mode_arrR.TabIndex = 9;
            mode_arrR.UseVisualStyleBackColor = true;
            mode_arrR.Click += mode_arrR_Click;
            // 
            // mode_lbl
            // 
            mode_lbl.Font = new Font("Architects Daughter", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mode_lbl.ForeColor = SystemColors.ButtonHighlight;
            mode_lbl.Location = new Point(107, 284);
            mode_lbl.Name = "mode_lbl";
            mode_lbl.Size = new Size(203, 29);
            mode_lbl.TabIndex = 8;
            mode_lbl.Text = "Mode";
            mode_lbl.TextAlign = ContentAlignment.TopCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Architects Daughter", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(18, 247);
            label4.Name = "label4";
            label4.Size = new Size(67, 29);
            label4.TabIndex = 7;
            label4.Text = "Mode";
            // 
            // subject_txbx
            // 
            subject_txbx.AnimateReadOnly = false;
            subject_txbx.BackColor = Color.FromArgb(120, 113, 108);
            subject_txbx.BorderStyle = BorderStyle.None;
            subject_txbx.Depth = 0;
            subject_txbx.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            subject_txbx.ForeColor = SystemColors.Menu;
            subject_txbx.Hint = "Enter you quiz name here";
            subject_txbx.LeadingIcon = null;
            subject_txbx.Location = new Point(18, 168);
            subject_txbx.MaxLength = 50;
            subject_txbx.MouseState = MaterialSkin.MouseState.OUT;
            subject_txbx.Multiline = false;
            subject_txbx.Name = "subject_txbx";
            subject_txbx.Size = new Size(392, 50);
            subject_txbx.TabIndex = 5;
            subject_txbx.Text = "";
            subject_txbx.TrailingIcon = null;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Architects Daughter", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(18, 136);
            label3.Name = "label3";
            label3.Size = new Size(188, 29);
            label3.TabIndex = 6;
            label3.Text = "Subject (Optional)";
            // 
            // quizName_txbx
            // 
            quizName_txbx.AnimateReadOnly = false;
            quizName_txbx.BackColor = Color.FromArgb(120, 113, 108);
            quizName_txbx.BorderStyle = BorderStyle.None;
            quizName_txbx.Depth = 0;
            quizName_txbx.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            quizName_txbx.ForeColor = SystemColors.InactiveBorder;
            quizName_txbx.Hint = "Enter you quiz name here";
            quizName_txbx.LeadingIcon = null;
            quizName_txbx.Location = new Point(18, 53);
            quizName_txbx.MaxLength = 50;
            quizName_txbx.MouseState = MaterialSkin.MouseState.OUT;
            quizName_txbx.Multiline = false;
            quizName_txbx.Name = "quizName_txbx";
            quizName_txbx.Size = new Size(392, 50);
            quizName_txbx.TabIndex = 0;
            quizName_txbx.Text = "";
            quizName_txbx.TrailingIcon = null;
            // 
            // quiz_name_lbl
            // 
            quiz_name_lbl.AutoSize = true;
            quiz_name_lbl.Font = new Font("Architects Daughter", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            quiz_name_lbl.ForeColor = SystemColors.ButtonHighlight;
            quiz_name_lbl.Location = new Point(18, 21);
            quiz_name_lbl.Name = "quiz_name_lbl";
            quiz_name_lbl.Size = new Size(118, 29);
            quiz_name_lbl.TabIndex = 4;
            quiz_name_lbl.Text = "Quiz Name";
            // 
            // inv_groupBox
            // 
            inv_groupBox.Controls.Add(image_holder_pn);
            inv_groupBox.Controls.Add(label2);
            inv_groupBox.Location = new Point(60, 86);
            inv_groupBox.Name = "inv_groupBox";
            inv_groupBox.Size = new Size(376, 278);
            inv_groupBox.TabIndex = 3;
            inv_groupBox.TabStop = false;
            inv_groupBox.MouseHover += inv_groupBox_MouseHover;
            // 
            // image_holder_pn
            // 
            image_holder_pn.AllowDrop = true;
            image_holder_pn.BackColor = Color.FromArgb(120, 113, 108);
            image_holder_pn.BackgroundImageLayout = ImageLayout.Stretch;
            image_holder_pn.Controls.Add(plus_icon);
            image_holder_pn.Location = new Point(6, 28);
            image_holder_pn.Name = "image_holder_pn";
            image_holder_pn.Size = new Size(364, 219);
            image_holder_pn.TabIndex = 6;
            image_holder_pn.DragDrop += image_holder_pn_DragDrop;
            image_holder_pn.DragEnter += image_holder_pn_DragEnter;
            // 
            // plus_icon
            // 
            plus_icon.AllowDrop = true;
            plus_icon.BackgroundImage = Properties.Resources.plus_small3;
            plus_icon.BackgroundImageLayout = ImageLayout.Center;
            plus_icon.Location = new Point(148, 76);
            plus_icon.Name = "plus_icon";
            plus_icon.Size = new Size(63, 61);
            plus_icon.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Architects Daughter", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(81, 250);
            label2.Name = "label2";
            label2.Size = new Size(221, 25);
            label2.TabIndex = 5;
            label2.Text = "Add Picture Quiz Profile";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Architects Daughter", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(28, 18);
            label1.Name = "label1";
            label1.Size = new Size(114, 38);
            label1.TabIndex = 1;
            label1.Text = "Create";
            // 
            // materialScrollBar1
            // 
            materialScrollBar1.Depth = 0;
            materialScrollBar1.Location = new Point(1971, 121);
            materialScrollBar1.MouseState = MaterialSkin.MouseState.HOVER;
            materialScrollBar1.Name = "materialScrollBar1";
            materialScrollBar1.Orientation = MaterialSkin.Controls.MaterialScrollOrientation.Vertical;
            materialScrollBar1.ScrollbarSize = 12;
            materialScrollBar1.Size = new Size(12, 732);
            materialScrollBar1.TabIndex = 3;
            materialScrollBar1.Text = "materialScrollBar1";
            // 
            // Create_Quiz
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(41, 37, 36);
            ClientSize = new Size(1564, 804);
            Controls.Add(panel1);
            Controls.Add(materialScrollBar1);
            Controls.Add(return_btn);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Create_Quiz";
            Text = "Create Quiz";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            inv_groupBox.ResumeLayout(false);
            inv_groupBox.PerformLayout();
            image_holder_pn.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button return_btn;
        private Panel panel1;
        private MaterialSkin.Controls.MaterialScrollBar materialScrollBar1;
        private Label label1;
        private MaterialSkin.Controls.MaterialTextBox quizName_txbx;
        private Label quiz_name_lbl;
        private GroupBox inv_groupBox;
        private Label label2;
        private Panel panel2;
        private MaterialSkin.Controls.MaterialButton create_btn;
        private MaterialSkin.Controls.MaterialTextBox subject_txbx;
        private Label label3;
        private Label mode_lbl;
        private Label label4;
        private Button mode_arrL;
        private Button mode_arrR;
        private GroupBox groupBox1;
        private TextBox property_txbx;
        private Label label9;
        private Label timer_lbl;
        private Label label7;
        private Button showAnswer_L_btn;
        private Button timer_L_btn;
        private Label showAnswer_lbl;
        private Button showAnswer_R_btn;
        private Button timer_R_btn;
        private Panel image_holder_pn;
        private Panel plus_icon;
    }
}