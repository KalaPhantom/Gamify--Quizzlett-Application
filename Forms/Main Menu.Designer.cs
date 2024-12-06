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
            materialCard1 = new MaterialSkin.Controls.MaterialCard();
            button_pannel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // quiz_list_btn
            // 
            quiz_list_btn.Location = new Point(14, 3);
            quiz_list_btn.Name = "quiz_list_btn";
            quiz_list_btn.Size = new Size(349, 105);
            quiz_list_btn.TabIndex = 0;
            quiz_list_btn.Text = "QUIZ LIST";
            quiz_list_btn.UseVisualStyleBackColor = true;
            quiz_list_btn.Click += quiz_list_btn_Click;
            // 
            // create_quiz_btn
            // 
            create_quiz_btn.Location = new Point(369, 3);
            create_quiz_btn.Name = "create_quiz_btn";
            create_quiz_btn.Size = new Size(185, 105);
            create_quiz_btn.TabIndex = 1;
            create_quiz_btn.Text = "CREATE";
            create_quiz_btn.UseVisualStyleBackColor = true;
            create_quiz_btn.Click += create_quiz_btn_Click;
            // 
            // notes_btn
            // 
            notes_btn.Location = new Point(14, 114);
            notes_btn.Name = "notes_btn";
            notes_btn.Size = new Size(540, 105);
            notes_btn.TabIndex = 2;
            notes_btn.Text = "NOTES";
            notes_btn.UseVisualStyleBackColor = true;
            notes_btn.Click += notes_btn_Click;
            // 
            // settings_btn
            // 
            settings_btn.Location = new Point(14, 225);
            settings_btn.Name = "settings_btn";
            settings_btn.Size = new Size(230, 105);
            settings_btn.TabIndex = 3;
            settings_btn.Text = "SETTINGS";
            settings_btn.UseVisualStyleBackColor = true;
            settings_btn.Click += settings_btn_Click;
            // 
            // stats_btn
            // 
            stats_btn.Location = new Point(250, 225);
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
            button_pannel.Controls.Add(stats_btn);
            button_pannel.Controls.Add(quiz_list_btn);
            button_pannel.Controls.Add(create_quiz_btn);
            button_pannel.Controls.Add(settings_btn);
            button_pannel.Controls.Add(notes_btn);
            button_pannel.Location = new Point(45, 162);
            button_pannel.Name = "button_pannel";
            button_pannel.Size = new Size(557, 333);
            button_pannel.TabIndex = 5;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(45, 24);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(232, 104);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // materialCard1
            // 
            materialCard1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            materialCard1.AutoSize = true;
            materialCard1.BackColor = Color.FromArgb(255, 255, 255);
            materialCard1.Depth = 0;
            materialCard1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard1.Location = new Point(644, 24);
            materialCard1.Margin = new Padding(14);
            materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard1.Name = "materialCard1";
            materialCard1.Padding = new Padding(14);
            materialCard1.Size = new Size(715, 621);
            materialCard1.TabIndex = 7;
            // 
            // Menu_Panel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.FromArgb(24, 24, 27);
            ClientSize = new Size(1396, 717);
            Controls.Add(materialCard1);
            Controls.Add(pictureBox1);
            Controls.Add(button_pannel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Menu_Panel";
            Text = "Main Menu";
            Load += Menu_Panel_Load;
            button_pannel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private MaterialSkin.Controls.MaterialCard materialCard1;
    }
}