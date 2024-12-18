namespace Gamify__Quizzlett_Application.Additional_Forms.Identification_Controls
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
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // questionHolder_txbx
            // 
            questionHolder_txbx.Font = new Font("Architects Daughter", 9F);
            questionHolder_txbx.Location = new Point(170, 88);
            questionHolder_txbx.Multiline = true;
            questionHolder_txbx.Name = "questionHolder_txbx";
            questionHolder_txbx.PlaceholderText = "Enter your question here....";
            questionHolder_txbx.Size = new Size(700, 193);
            questionHolder_txbx.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Architects Daughter", 9F);
            textBox1.Location = new Point(173, 346);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Enter the correct answer here";
            textBox1.Size = new Size(697, 27);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Architects Daughter", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(173, 60);
            label1.Name = "label1";
            label1.Size = new Size(82, 25);
            label1.TabIndex = 2;
            label1.Text = "Question";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Architects Daughter", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(173, 318);
            label2.Name = "label2";
            label2.Size = new Size(74, 25);
            label2.TabIndex = 3;
            label2.Text = "Answer";
            // 
            // Modifiable_Identification
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(69, 10, 10);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(questionHolder_txbx);
            Name = "Modifiable_Identification";
            Size = new Size(1054, 497);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox questionHolder_txbx;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
    }
}
