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
            materialTextBox21 = new MaterialSkin.Controls.MaterialTextBox2();
            materialScrollBar1 = new MaterialSkin.Controls.MaterialScrollBar();
            materialScrollBar2 = new MaterialSkin.Controls.MaterialScrollBar();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // return_btn
            // 
            return_btn.BackgroundImage = Properties.Resources.log_in__5_;
            return_btn.BackgroundImageLayout = ImageLayout.Center;
            return_btn.FlatStyle = FlatStyle.Flat;
            return_btn.Location = new Point(12, 12);
            return_btn.Name = "return_btn";
            return_btn.Size = new Size(39, 40);
            return_btn.TabIndex = 0;
            return_btn.UseVisualStyleBackColor = true;
            return_btn.Click += return_btn_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(120, 113, 108);
            panel1.Controls.Add(materialTextBox21);
            panel1.Location = new Point(296, 40);
            panel1.Name = "panel1";
            panel1.Size = new Size(791, 732);
            panel1.TabIndex = 1;
            // 
            // materialTextBox21
            // 
            materialTextBox21.AnimateReadOnly = false;
            materialTextBox21.BackgroundImageLayout = ImageLayout.None;
            materialTextBox21.CharacterCasing = CharacterCasing.Normal;
            materialTextBox21.Depth = 0;
            materialTextBox21.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialTextBox21.HideSelection = true;
            materialTextBox21.LeadingIcon = null;
            materialTextBox21.Location = new Point(399, 43);
            materialTextBox21.MaxLength = 32767;
            materialTextBox21.MouseState = MaterialSkin.MouseState.OUT;
            materialTextBox21.Name = "materialTextBox21";
            materialTextBox21.PasswordChar = '\0';
            materialTextBox21.PrefixSuffixText = null;
            materialTextBox21.ReadOnly = false;
            materialTextBox21.RightToLeft = RightToLeft.No;
            materialTextBox21.SelectedText = "";
            materialTextBox21.SelectionLength = 0;
            materialTextBox21.SelectionStart = 0;
            materialTextBox21.ShortcutsEnabled = true;
            materialTextBox21.Size = new Size(360, 48);
            materialTextBox21.TabIndex = 5;
            materialTextBox21.TabStop = false;
            materialTextBox21.Text = "materialTextBox21";
            materialTextBox21.TextAlign = HorizontalAlignment.Left;
            materialTextBox21.TrailingIcon = null;
            materialTextBox21.UseSystemPasswordChar = false;
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
            // materialScrollBar2
            // 
            materialScrollBar2.Depth = 0;
            materialScrollBar2.Location = new Point(1103, 40);
            materialScrollBar2.MouseState = MaterialSkin.MouseState.HOVER;
            materialScrollBar2.Name = "materialScrollBar2";
            materialScrollBar2.Orientation = MaterialSkin.Controls.MaterialScrollOrientation.Vertical;
            materialScrollBar2.ScrollbarSize = 12;
            materialScrollBar2.Size = new Size(12, 732);
            materialScrollBar2.TabIndex = 4;
            materialScrollBar2.Text = "materialScrollBar2";
            // 
            // Create_Quiz
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(41, 37, 36);
            ClientSize = new Size(1519, 771);
            Controls.Add(materialScrollBar2);
            Controls.Add(panel1);
            Controls.Add(materialScrollBar1);
            Controls.Add(return_btn);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Create_Quiz";
            Text = "Create Quiz";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button return_btn;
        private Panel panel1;
        private MaterialSkin.Controls.MaterialScrollBar materialScrollBar1;
        private MaterialSkin.Controls.MaterialScrollBar materialScrollBar2;
        private MaterialSkin.Controls.MaterialTextBox2 materialTextBox21;
    }
}