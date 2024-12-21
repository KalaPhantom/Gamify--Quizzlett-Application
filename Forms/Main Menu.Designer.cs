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
            settings_btn = new Button();
            stats_btn = new Button();
            button_pannel = new Panel();
            pictureBox1 = new PictureBox();
            about_btn = new MaterialSkin.Controls.MaterialButton();
            MainMenu_flp = new FlowLayoutPanel();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // quiz_list_btn
            // 
            quiz_list_btn.FlatStyle = FlatStyle.System;
            quiz_list_btn.Font = new Font("Microsoft Sans Serif", 7.8F);
            quiz_list_btn.Location = new Point(24, 143);
            quiz_list_btn.Margin = new Padding(3, 2, 3, 2);
            quiz_list_btn.Name = "quiz_list_btn";
            quiz_list_btn.Size = new Size(305, 79);
            quiz_list_btn.TabIndex = 0;
            quiz_list_btn.Text = "QUIZ LIST";
            quiz_list_btn.UseVisualStyleBackColor = true;
            quiz_list_btn.Click += quiz_list_btn_Click;
            // 
            // create_quiz_btn
            // 
            create_quiz_btn.Font = new Font("Microsoft Sans Serif", 7.8F);
            create_quiz_btn.Location = new Point(334, 143);
            create_quiz_btn.Margin = new Padding(3, 2, 3, 2);
            create_quiz_btn.Name = "create_quiz_btn";
            create_quiz_btn.Size = new Size(162, 79);
            create_quiz_btn.TabIndex = 1;
            create_quiz_btn.Text = "CREATE";
            create_quiz_btn.UseVisualStyleBackColor = true;
            create_quiz_btn.Click += create_quiz_btn_Click;
            // 
            // notes_btn
            // 
            notes_btn.Font = new Font("Microsoft Sans Serif", 7.8F);
            notes_btn.Location = new Point(24, 226);
            notes_btn.Margin = new Padding(3, 2, 3, 2);
            notes_btn.Name = "notes_btn";
            notes_btn.Size = new Size(472, 79);
            notes_btn.TabIndex = 2;
            notes_btn.Text = "NOTES";
            notes_btn.UseVisualStyleBackColor = true;
            notes_btn.Click += notes_btn_Click;
            // 
            // settings_btn
            // 
            settings_btn.Font = new Font("Microsoft Sans Serif", 7.8F);
            settings_btn.Location = new Point(24, 310);
            settings_btn.Margin = new Padding(3, 2, 3, 2);
            settings_btn.Name = "settings_btn";
            settings_btn.Size = new Size(201, 79);
            settings_btn.TabIndex = 3;
            settings_btn.Text = "SETTINGS";
            settings_btn.UseVisualStyleBackColor = true;
            settings_btn.Click += settings_btn_Click;
            // 
            // stats_btn
            // 
            stats_btn.Font = new Font("Microsoft Sans Serif", 7.8F);
            stats_btn.Location = new Point(230, 310);
            stats_btn.Margin = new Padding(3, 2, 3, 2);
            stats_btn.Name = "stats_btn";
            stats_btn.Size = new Size(266, 79);
            stats_btn.TabIndex = 4;
            stats_btn.Text = "STATS";
            stats_btn.UseVisualStyleBackColor = true;
            stats_btn.Click += stats_btn_Click;
            // 
            // button_pannel
            // 
            button_pannel.AutoSize = true;
            button_pannel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button_pannel.Location = new Point(39, 122);
            button_pannel.Margin = new Padding(3, 2, 3, 2);
            button_pannel.Name = "button_pannel";
            button_pannel.Size = new Size(0, 0);
            button_pannel.TabIndex = 5;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(22, 34);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(232, 104);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // about_btn
            // 
            about_btn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            about_btn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            about_btn.Depth = 0;
            about_btn.HighEmphasis = true;
            about_btn.Icon = null;
            about_btn.Location = new Point(230, 488);
            about_btn.Margin = new Padding(4, 4, 4, 4);
            about_btn.MouseState = MaterialSkin.MouseState.HOVER;
            about_btn.Name = "about_btn";
            about_btn.NoAccentTextColor = Color.Empty;
            about_btn.Size = new Size(69, 36);
            about_btn.TabIndex = 10;
            about_btn.Text = "About";
            about_btn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            about_btn.UseAccentColor = false;
            about_btn.UseVisualStyleBackColor = false;
            // 
            // MainMenu_flp
            // 
            MainMenu_flp.BackColor = Color.FromArgb(41, 37, 36);
            MainMenu_flp.Dock = DockStyle.Right;
            MainMenu_flp.FlowDirection = FlowDirection.TopDown;
            MainMenu_flp.Location = new Point(570, 0);
            MainMenu_flp.Margin = new Padding(3, 2, 3, 2);
            MainMenu_flp.Name = "MainMenu_flp";
            MainMenu_flp.Size = new Size(652, 538);
            MainMenu_flp.TabIndex = 9;
            // 
            // panel1
            // 
            panel1.Controls.Add(stats_btn);
            panel1.Controls.Add(about_btn);
            panel1.Controls.Add(quiz_list_btn);
            panel1.Controls.Add(notes_btn);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(create_quiz_btn);
            panel1.Controls.Add(settings_btn);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(570, 538);
            panel1.TabIndex = 11;
            // 
            // Menu_Panel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.FromArgb(24, 24, 27);
            ClientSize = new Size(1222, 538);
            Controls.Add(panel1);
            Controls.Add(MainMenu_flp);
            Controls.Add(button_pannel);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Menu_Panel";
            Text = "Main Menu";
            Load += Menu_Panel_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button quiz_list_btn;
        private Button create_quiz_btn;
        private Button notes_btn;
        private Button settings_btn;
        private Button stats_btn;
        private Panel button_pannel;
        private PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialButton about_btn;
        private FlowLayoutPanel MainMenu_flp;
        private Panel panel1;
    }
}