namespace Gamify__Quizzlett_Application.Forms
{
    partial class Modify_Quiz_form
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
            return_btn.TabIndex = 1;
            return_btn.UseVisualStyleBackColor = true;
            return_btn.Click += return_btn_Click;
            // 
            // Modify_Quiz_form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(3, 7, 18);
            ClientSize = new Size(1519, 771);
            Controls.Add(return_btn);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Modify_Quiz_form";
            Text = "Modify Quiz";
            ResumeLayout(false);
        }

        #endregion

        private Button return_btn;
    }
}