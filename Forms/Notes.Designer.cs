namespace Gamify__Quizzlett_Application.Forms
{
    partial class Notes
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
            notes_lbl = new Label();
            SuspendLayout();
            // 
            // return_btn
            // 
            return_btn.Location = new Point(12, 12);
            return_btn.Name = "return_btn";
            return_btn.Size = new Size(94, 29);
            return_btn.TabIndex = 0;
            return_btn.Text = "Return to menu ";
            return_btn.UseVisualStyleBackColor = true;
            // 
            // notes_lbl
            // 
            notes_lbl.AutoSize = true;
            notes_lbl.Location = new Point(361, 226);
            notes_lbl.Name = "notes_lbl";
            notes_lbl.Size = new Size(49, 20);
            notes_lbl.TabIndex = 1;
            notes_lbl.Text = "notes ";
            // 
            // Notes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(842, 501);
            Controls.Add(notes_lbl);
            Controls.Add(return_btn);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Notes";
            Text = "Notes";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button return_btn;
        private Label notes_lbl;
    }
}