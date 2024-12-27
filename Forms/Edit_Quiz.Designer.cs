namespace Gamify__Quizzlett_Application.Forms
{
    partial class Edit_Quiz
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
            background1 = new Panel();
            clearImg_btn = new Button();
            groupBox1 = new GroupBox();
            property_txbx = new TextBox();
            create_btn = new MaterialSkin.Controls.MaterialButton();
            highlight1 = new Panel();
            timer_R_btn = new Button();
            timer_L_btn = new Button();
            timer_lbl = new Label();
            label7 = new Label();
            subject_txbx = new MaterialSkin.Controls.MaterialTextBox();
            label3 = new Label();
            quizName_txbx = new MaterialSkin.Controls.MaterialTextBox();
            quiz_name_lbl = new Label();
            inv_groupBox = new GroupBox();
            image_holder_pn = new Panel();
            plus_icon = new Panel();
            label2 = new Label();
            label1 = new Label();
            return_btn = new Button();
            background1.SuspendLayout();
            groupBox1.SuspendLayout();
            highlight1.SuspendLayout();
            inv_groupBox.SuspendLayout();
            image_holder_pn.SuspendLayout();
            SuspendLayout();
            // 
            // background1
            // 
            background1.Anchor = AnchorStyles.None;
            background1.BackColor = Color.FromArgb(28, 25, 23);
            background1.Controls.Add(clearImg_btn);
            background1.Controls.Add(groupBox1);
            background1.Controls.Add(create_btn);
            background1.Controls.Add(highlight1);
            background1.Controls.Add(inv_groupBox);
            background1.Controls.Add(label1);
            background1.Location = new Point(290, 12);
            background1.Name = "background1";
            background1.Size = new Size(927, 700);
            background1.TabIndex = 2;
            // 
            // clearImg_btn
            // 
            clearImg_btn.FlatStyle = FlatStyle.Flat;
            clearImg_btn.Font = new Font("Architects Daughter", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            clearImg_btn.ForeColor = SystemColors.Control;
            clearImg_btn.Location = new Point(60, 364);
            clearImg_btn.Name = "clearImg_btn";
            clearImg_btn.Size = new Size(376, 84);
            clearImg_btn.TabIndex = 7;
            clearImg_btn.Text = "Clear Image";
            clearImg_btn.UseVisualStyleBackColor = true;
            clearImg_btn.Click += clearImg_btn_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(property_txbx);
            groupBox1.Location = new Point(60, 454);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(376, 162);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            // 
            // property_txbx
            // 
            property_txbx.Location = new Point(0, 0);
            property_txbx.Multiline = true;
            property_txbx.Name = "property_txbx";
            property_txbx.ReadOnly = true;
            property_txbx.Size = new Size(376, 177);
            property_txbx.TabIndex = 0;
            // 
            // create_btn
            // 
            create_btn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            create_btn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            create_btn.Depth = 0;
            create_btn.HighEmphasis = true;
            create_btn.Icon = null;
            create_btn.Location = new Point(439, 644);
            create_btn.Margin = new Padding(4, 6, 4, 6);
            create_btn.MouseState = MaterialSkin.MouseState.HOVER;
            create_btn.Name = "create_btn";
            create_btn.NoAccentTextColor = Color.Empty;
            create_btn.Size = new Size(86, 36);
            create_btn.TabIndex = 6;
            create_btn.Text = "Proceed";
            create_btn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            create_btn.UseAccentColor = false;
            create_btn.UseVisualStyleBackColor = true;
            create_btn.Click += create_btn_Click;
            // 
            // highlight1
            // 
            highlight1.BackColor = Color.FromArgb(41, 37, 36);
            highlight1.Controls.Add(timer_R_btn);
            highlight1.Controls.Add(timer_L_btn);
            highlight1.Controls.Add(timer_lbl);
            highlight1.Controls.Add(label7);
            highlight1.Controls.Add(subject_txbx);
            highlight1.Controls.Add(label3);
            highlight1.Controls.Add(quizName_txbx);
            highlight1.Controls.Add(quiz_name_lbl);
            highlight1.Location = new Point(452, 86);
            highlight1.Name = "highlight1";
            highlight1.Size = new Size(438, 530);
            highlight1.TabIndex = 5;
            // 
            // timer_R_btn
            // 
            timer_R_btn.BackgroundImage = Properties.Resources.png_3qy3mj;
            timer_R_btn.BackgroundImageLayout = ImageLayout.Center;
            timer_R_btn.FlatStyle = FlatStyle.Flat;
            timer_R_btn.Location = new Point(316, 281);
            timer_R_btn.Name = "timer_R_btn";
            timer_R_btn.Size = new Size(94, 29);
            timer_R_btn.TabIndex = 19;
            timer_R_btn.UseVisualStyleBackColor = true;
            timer_R_btn.Click += timer_R_btn_Click;
            // 
            // timer_L_btn
            // 
            timer_L_btn.BackgroundImage = Properties.Resources.png_0q6s6;
            timer_L_btn.BackgroundImageLayout = ImageLayout.Center;
            timer_L_btn.FlatStyle = FlatStyle.Flat;
            timer_L_btn.Location = new Point(18, 281);
            timer_L_btn.Name = "timer_L_btn";
            timer_L_btn.Size = new Size(94, 29);
            timer_L_btn.TabIndex = 17;
            timer_L_btn.UseVisualStyleBackColor = true;
            timer_L_btn.Click += timer_L_btn_Click;
            // 
            // timer_lbl
            // 
            timer_lbl.Font = new Font("Architects Daughter", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            timer_lbl.ForeColor = SystemColors.ButtonHighlight;
            timer_lbl.Location = new Point(118, 281);
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
            label7.Location = new Point(18, 242);
            label7.Name = "label7";
            label7.Size = new Size(154, 29);
            label7.TabIndex = 11;
            label7.Text = "Enable Timer?";
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
            subject_txbx.TextChanged += subject_txbx_TextChanged;
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
            quizName_txbx.TextChanged += quizName_txbx_TextChanged;
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
            inv_groupBox.Location = new Point(60, 79);
            inv_groupBox.Name = "inv_groupBox";
            inv_groupBox.Size = new Size(376, 278);
            inv_groupBox.TabIndex = 3;
            inv_groupBox.TabStop = false;
            // 
            // image_holder_pn
            // 
            image_holder_pn.AllowDrop = true;
            image_holder_pn.BackColor = Color.FromArgb(28, 25, 23);
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
            label2.Location = new Point(61, 247);
            label2.Name = "label2";
            label2.Size = new Size(266, 25);
            label2.TabIndex = 5;
            label2.Text = "Drag and Drop an Image here";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Architects Daughter", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(28, 18);
            label1.Name = "label1";
            label1.Size = new Size(139, 38);
            label1.TabIndex = 1;
            label1.Text = "Edit Quiz";
            // 
            // return_btn
            // 
            return_btn.BackgroundImage = Properties.Resources.log_in__5_;
            return_btn.BackgroundImageLayout = ImageLayout.Center;
            return_btn.FlatStyle = FlatStyle.Popup;
            return_btn.Location = new Point(12, 12);
            return_btn.Name = "return_btn";
            return_btn.Size = new Size(39, 40);
            return_btn.TabIndex = 3;
            return_btn.UseVisualStyleBackColor = true;
            return_btn.Click += return_btn_Click;
            // 
            // Edit_Quiz
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(12, 10, 9);
            BackgroundImage = Properties.Resources.BG_12;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1501, 724);
            Controls.Add(return_btn);
            Controls.Add(background1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Edit_Quiz";
            Text = "Edit_Quiz";
            background1.ResumeLayout(false);
            background1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            highlight1.ResumeLayout(false);
            highlight1.PerformLayout();
            inv_groupBox.ResumeLayout(false);
            inv_groupBox.PerformLayout();
            image_holder_pn.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel background1;
        private GroupBox groupBox1;
        private TextBox property_txbx;
        private MaterialSkin.Controls.MaterialButton create_btn;
        private Panel highlight1;
        private Button timer_R_btn;
        private Button timer_L_btn;
        private Label timer_lbl;
        private Label label7;
        private MaterialSkin.Controls.MaterialTextBox subject_txbx;
        private Label label3;
        private MaterialSkin.Controls.MaterialTextBox quizName_txbx;
        private Label quiz_name_lbl;
        private GroupBox inv_groupBox;
        private Panel image_holder_pn;
        private Panel plus_icon;
        private Label label2;
        private Label label1;
        private Button return_btn;
        private Button clearImg_btn;
    }
}