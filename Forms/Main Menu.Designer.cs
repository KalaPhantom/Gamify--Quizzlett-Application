namespace Gamify__Quizzlett_Application.Forms
{
    partial class Menu_Panel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu_Panel));
            quiz_list_btn = new Button();
            create_quiz_btn = new Button();
            notes_btn = new Button();
            about_btn = new Button();
            stats_btn = new Button();
            button_pannel = new Panel();
            pictureBox1 = new PictureBox();
            MainMenu_flp = new FlowLayoutPanel();
            deco4 = new Panel();
            panel1 = new Panel();
            about_lbl = new Label();
            pictureBox2 = new PictureBox();
            panel2 = new Panel();
            deco3 = new Panel();
            deco2 = new Panel();
            deco1 = new Panel();
            highlight = new Panel();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            MainMenu_flp.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            highlight.SuspendLayout();
            SuspendLayout();
            // 
            // quiz_list_btn
            // 
            quiz_list_btn.FlatStyle = FlatStyle.Popup;
            quiz_list_btn.Font = new Font("Architects Daughter", 7.8F);
            quiz_list_btn.Location = new Point(27, 191);
            quiz_list_btn.Name = "quiz_list_btn";
            quiz_list_btn.Size = new Size(349, 105);
            quiz_list_btn.TabIndex = 0;
            quiz_list_btn.Text = "QUIZ LIST";
            quiz_list_btn.UseVisualStyleBackColor = true;
            quiz_list_btn.Click += quiz_list_btn_Click;
            // 
            // create_quiz_btn
            // 
            create_quiz_btn.FlatStyle = FlatStyle.Popup;
            create_quiz_btn.Font = new Font("Architects Daughter", 7.8F);
            create_quiz_btn.Location = new Point(382, 191);
            create_quiz_btn.Name = "create_quiz_btn";
            create_quiz_btn.Size = new Size(185, 105);
            create_quiz_btn.TabIndex = 1;
            create_quiz_btn.Text = "CREATE";
            create_quiz_btn.UseVisualStyleBackColor = true;
            create_quiz_btn.Click += create_quiz_btn_Click;
            // 
            // notes_btn
            // 
            notes_btn.FlatStyle = FlatStyle.Popup;
            notes_btn.Font = new Font("Architects Daughter", 7.8F);
            notes_btn.Location = new Point(27, 302);
            notes_btn.Name = "notes_btn";
            notes_btn.Size = new Size(540, 105);
            notes_btn.TabIndex = 2;
            notes_btn.Text = "NOTES";
            notes_btn.UseVisualStyleBackColor = true;
            notes_btn.Click += notes_btn_Click;
            // 
            // about_btn
            // 
            about_btn.FlatStyle = FlatStyle.Popup;
            about_btn.Font = new Font("Architects Daughter", 7.8F);
            about_btn.Location = new Point(27, 413);
            about_btn.Name = "about_btn";
            about_btn.Size = new Size(230, 105);
            about_btn.TabIndex = 3;
            about_btn.Text = "ABOUT";
            about_btn.UseVisualStyleBackColor = true;
            about_btn.Click += settings_btn_Click;
            // 
            // stats_btn
            // 
            stats_btn.FlatStyle = FlatStyle.Popup;
            stats_btn.Font = new Font("Architects Daughter", 7.8F);
            stats_btn.Location = new Point(263, 413);
            stats_btn.Name = "stats_btn";
            stats_btn.Size = new Size(304, 105);
            stats_btn.TabIndex = 4;
            stats_btn.Text = "STATS";
            stats_btn.UseVisualStyleBackColor = true;
            stats_btn.Click += stats_btn_Click;
            // 
            // button_pannel
            // 
            button_pannel.AutoSize = true;
            button_pannel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button_pannel.Location = new Point(45, 162);
            button_pannel.Name = "button_pannel";
            button_pannel.Size = new Size(0, 0);
            button_pannel.TabIndex = 5;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(25, 55);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(232, 104);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // MainMenu_flp
            // 
            MainMenu_flp.Anchor = AnchorStyles.None;
            MainMenu_flp.AutoScroll = true;
            MainMenu_flp.BackColor = Color.FromArgb(41, 37, 36);
            MainMenu_flp.Controls.Add(deco4);
            MainMenu_flp.FlowDirection = FlowDirection.TopDown;
            MainMenu_flp.Location = new Point(25, 114);
            MainMenu_flp.Name = "MainMenu_flp";
            MainMenu_flp.Size = new Size(687, 591);
            MainMenu_flp.TabIndex = 9;
            // 
            // deco4
            // 
            deco4.Anchor = AnchorStyles.None;
            deco4.Location = new Point(3, 3);
            deco4.Name = "deco4";
            deco4.Padding = new Padding(1);
            deco4.Size = new Size(681, 13);
            deco4.TabIndex = 11;
            // 
            // panel1
            // 
            panel1.Controls.Add(about_lbl);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(stats_btn);
            panel1.Controls.Add(quiz_list_btn);
            panel1.Controls.Add(notes_btn);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(create_quiz_btn);
            panel1.Controls.Add(about_btn);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(652, 717);
            panel1.TabIndex = 11;
            // 
            // about_lbl
            // 
            about_lbl.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            about_lbl.AutoSize = true;
            about_lbl.Font = new Font("Architects Daughter", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            about_lbl.ForeColor = SystemColors.ButtonHighlight;
            about_lbl.Location = new Point(186, 592);
            about_lbl.Name = "about_lbl";
            about_lbl.Size = new Size(257, 66);
            about_lbl.TabIndex = 12;
            about_lbl.Text = "CREATED BY GROUP 2\r\nA. B.  2024 VERSION 1. 02 BETA \r\nBUILD VERSION 1. 00";
            about_lbl.TextAlign = ContentAlignment.TopCenter;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImageLayout = ImageLayout.Center;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(238, 52);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(113, 107);
            pictureBox2.TabIndex = 11;
            pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(deco3);
            panel2.Controls.Add(deco2);
            panel2.Controls.Add(deco1);
            panel2.Controls.Add(highlight);
            panel2.Controls.Add(MainMenu_flp);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(652, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(744, 717);
            panel2.TabIndex = 11;
            // 
            // deco3
            // 
            deco3.Anchor = AnchorStyles.None;
            deco3.Location = new Point(25, 21);
            deco3.Name = "deco3";
            deco3.Size = new Size(304, 25);
            deco3.TabIndex = 3;
            // 
            // deco2
            // 
            deco2.Anchor = AnchorStyles.None;
            deco2.Location = new Point(283, 21);
            deco2.Name = "deco2";
            deco2.Size = new Size(250, 25);
            deco2.TabIndex = 2;
            // 
            // deco1
            // 
            deco1.Anchor = AnchorStyles.None;
            deco1.Location = new Point(459, 21);
            deco1.Name = "deco1";
            deco1.Size = new Size(253, 25);
            deco1.TabIndex = 1;
            // 
            // highlight
            // 
            highlight.Anchor = AnchorStyles.None;
            highlight.BackColor = Color.FromArgb(87, 83, 78);
            highlight.Controls.Add(label1);
            highlight.Location = new Point(25, 35);
            highlight.Name = "highlight";
            highlight.Size = new Size(687, 83);
            highlight.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Architects Daughter", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(18, 26);
            label1.Name = "label1";
            label1.Size = new Size(111, 33);
            label1.TabIndex = 0;
            label1.Text = "Quiz List";
            // 
            // Menu_Panel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.FromArgb(24, 24, 27);
            ClientSize = new Size(1396, 717);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(button_pannel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Menu_Panel";
            Text = "Main Menu";
            Load += Menu_Panel_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            MainMenu_flp.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            highlight.ResumeLayout(false);
            highlight.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button quiz_list_btn;
        private Button create_quiz_btn;
        private Button notes_btn;
        private Button about_btn;
        private Button stats_btn;
        private Panel button_pannel;
        private PictureBox pictureBox1;
        private FlowLayoutPanel MainMenu_flp;
        private Panel panel1;
        private Panel panel2;
        private Panel highlight;
        private Label label1;
        private Panel deco1;
        private Panel deco4;
        private Panel deco3;
        private Panel deco2;
        private PictureBox pictureBox2;
        private Label about_lbl;
    }
}