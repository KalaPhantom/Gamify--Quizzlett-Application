namespace Gamify__Quizzlett_Application.User_Control.Quiz_cards
{
    partial class Quiz_Card_List
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Quiz_Card_List));
            title_lbl = new Label();
            subject_lbl = new Label();
            highlight_panel_2 = new Panel();
            Delete_btn = new Button();
            test_lunch_btn = new Button();
            modify_btn = new Button();
            highlight_panel_1 = new Panel();
            timer = new System.Windows.Forms.Timer(components);
            highlight_panel_2.SuspendLayout();
            SuspendLayout();
            // 
            // title_lbl
            // 
            title_lbl.Font = new Font("Architects Daughter", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            title_lbl.ForeColor = SystemColors.ButtonHighlight;
            title_lbl.Location = new Point(38, 14);
            title_lbl.Name = "title_lbl";
            title_lbl.Size = new Size(294, 38);
            title_lbl.TabIndex = 0;
            title_lbl.Text = "title";
            // 
            // subject_lbl
            // 
            subject_lbl.ForeColor = SystemColors.ButtonHighlight;
            subject_lbl.Location = new Point(38, 51);
            subject_lbl.Name = "subject_lbl";
            subject_lbl.Size = new Size(294, 20);
            subject_lbl.TabIndex = 1;
            subject_lbl.Text = "subject";
            // 
            // highlight_panel_2
            // 
            highlight_panel_2.BackColor = Color.FromArgb(20, 83, 45);
            highlight_panel_2.Controls.Add(Delete_btn);
            highlight_panel_2.Controls.Add(test_lunch_btn);
            highlight_panel_2.Controls.Add(modify_btn);
            highlight_panel_2.Location = new Point(358, 0);
            highlight_panel_2.Name = "highlight_panel_2";
            highlight_panel_2.Size = new Size(292, 128);
            highlight_panel_2.TabIndex = 2;
            // 
            // Delete_btn
            // 
            Delete_btn.BackgroundImage = (Image)resources.GetObject("Delete_btn.BackgroundImage");
            Delete_btn.BackgroundImageLayout = ImageLayout.Center;
            Delete_btn.FlatStyle = FlatStyle.Flat;
            Delete_btn.ForeColor = SystemColors.ButtonHighlight;
            Delete_btn.Location = new Point(100, 66);
            Delete_btn.Name = "Delete_btn";
            Delete_btn.Size = new Size(51, 43);
            Delete_btn.TabIndex = 5;
            Delete_btn.UseVisualStyleBackColor = true;
            Delete_btn.Click += Delete_btn_Click;
            // 
            // test_lunch_btn
            // 
            test_lunch_btn.BackgroundImage = (Image)resources.GetObject("test_lunch_btn.BackgroundImage");
            test_lunch_btn.BackgroundImageLayout = ImageLayout.Center;
            test_lunch_btn.FlatStyle = FlatStyle.Flat;
            test_lunch_btn.ForeColor = Color.Transparent;
            test_lunch_btn.Location = new Point(157, 14);
            test_lunch_btn.Name = "test_lunch_btn";
            test_lunch_btn.Size = new Size(124, 95);
            test_lunch_btn.TabIndex = 0;
            test_lunch_btn.UseVisualStyleBackColor = true;
            test_lunch_btn.Click += test_lunch_btn_Click;
            // 
            // modify_btn
            // 
            modify_btn.BackgroundImage = Properties.Resources.edit;
            modify_btn.BackgroundImageLayout = ImageLayout.Center;
            modify_btn.FlatStyle = FlatStyle.Flat;
            modify_btn.ForeColor = SystemColors.ButtonHighlight;
            modify_btn.Location = new Point(100, 15);
            modify_btn.Name = "modify_btn";
            modify_btn.Size = new Size(51, 43);
            modify_btn.TabIndex = 4;
            modify_btn.UseVisualStyleBackColor = true;
            modify_btn.Click += modify_btn_Click;
            // 
            // highlight_panel_1
            // 
            highlight_panel_1.BackColor = Color.FromArgb(45, 212, 191);
            highlight_panel_1.Location = new Point(3, 0);
            highlight_panel_1.Name = "highlight_panel_1";
            highlight_panel_1.Size = new Size(13, 125);
            highlight_panel_1.TabIndex = 3;
            // 
            // timer
            // 
            timer.Tick += timer_Tick;
            // 
            // Quiz_Card_List
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(41, 37, 36);
            Controls.Add(highlight_panel_1);
            Controls.Add(highlight_panel_2);
            Controls.Add(subject_lbl);
            Controls.Add(title_lbl);
            Name = "Quiz_Card_List";
            Size = new Size(650, 125);
            highlight_panel_2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label title_lbl;
        private Label subject_lbl;
        private Panel highlight_panel_2;
        private Panel highlight_panel_1;
        private Button test_lunch_btn;
        private System.Windows.Forms.Timer timer;
        private Button modify_btn;
        private Button Delete_btn;
    }
}
