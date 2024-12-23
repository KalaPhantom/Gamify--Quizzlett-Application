namespace Gamify__Quizzlett_Application.Additional_Forms
{
    partial class Multiple_Choice
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
            Option_C_btn = new Button();
            Option_D_btn = new Button();
            Option_B_btn = new Button();
            Option_A_btn = new Button();
            Question_txbx = new TextBox();
            nextOrSkip_button = new Button();
            SuspendLayout();
            // 
            // Option_C_btn
            // 
            Option_C_btn.FlatStyle = FlatStyle.Flat;
            Option_C_btn.Font = new Font("Architects Daughter", 10.8F);
            Option_C_btn.ForeColor = SystemColors.ButtonFace;
            Option_C_btn.Location = new Point(85, 486);
            Option_C_btn.Name = "Option_C_btn";
            Option_C_btn.Size = new Size(504, 61);
            Option_C_btn.TabIndex = 0;
            Option_C_btn.Text = "Option C";
            Option_C_btn.UseVisualStyleBackColor = true;
            Option_C_btn.Click += Option_C_btn_Click;
            // 
            // Option_D_btn
            // 
            Option_D_btn.FlatStyle = FlatStyle.Flat;
            Option_D_btn.Font = new Font("Architects Daughter", 10.8F);
            Option_D_btn.ForeColor = SystemColors.ButtonFace;
            Option_D_btn.Location = new Point(595, 486);
            Option_D_btn.Name = "Option_D_btn";
            Option_D_btn.Size = new Size(496, 61);
            Option_D_btn.TabIndex = 1;
            Option_D_btn.Text = "Option D";
            Option_D_btn.UseVisualStyleBackColor = true;
            Option_D_btn.Click += Option_D_btn_Click;
            // 
            // Option_B_btn
            // 
            Option_B_btn.FlatStyle = FlatStyle.Flat;
            Option_B_btn.Font = new Font("Architects Daughter", 10.8F);
            Option_B_btn.ForeColor = SystemColors.ButtonFace;
            Option_B_btn.Location = new Point(595, 418);
            Option_B_btn.Name = "Option_B_btn";
            Option_B_btn.Size = new Size(496, 61);
            Option_B_btn.TabIndex = 2;
            Option_B_btn.Text = "Option B";
            Option_B_btn.UseVisualStyleBackColor = true;
            Option_B_btn.Click += Option_B_btn_Click;
            // 
            // Option_A_btn
            // 
            Option_A_btn.FlatStyle = FlatStyle.Flat;
            Option_A_btn.Font = new Font("Architects Daughter", 10.8F);
            Option_A_btn.ForeColor = SystemColors.ButtonFace;
            Option_A_btn.Location = new Point(85, 418);
            Option_A_btn.Name = "Option_A_btn";
            Option_A_btn.Size = new Size(504, 61);
            Option_A_btn.TabIndex = 3;
            Option_A_btn.Text = "Option A";
            Option_A_btn.UseVisualStyleBackColor = true;
            Option_A_btn.Click += Option_A_btn_Click;
            // 
            // Question_txbx
            // 
            Question_txbx.Font = new Font("Architects Daughter", 10.8F);
            Question_txbx.Location = new Point(77, 63);
            Question_txbx.Multiline = true;
            Question_txbx.Name = "Question_txbx";
            Question_txbx.Size = new Size(1026, 349);
            Question_txbx.TabIndex = 4;
            Question_txbx.TextAlign = HorizontalAlignment.Center;
            // 
            // nextOrSkip_button
            // 
            nextOrSkip_button.Font = new Font("Architects Daughter", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nextOrSkip_button.Location = new Point(542, 584);
            nextOrSkip_button.Name = "nextOrSkip_button";
            nextOrSkip_button.Size = new Size(121, 40);
            nextOrSkip_button.TabIndex = 5;
            nextOrSkip_button.Text = "Next";
            nextOrSkip_button.UseVisualStyleBackColor = true;
            nextOrSkip_button.Click += nextOrSkip_button_Click;
            // 
            // Multiple_Choice
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(4, 47, 46);
            Controls.Add(nextOrSkip_button);
            Controls.Add(Question_txbx);
            Controls.Add(Option_A_btn);
            Controls.Add(Option_B_btn);
            Controls.Add(Option_D_btn);
            Controls.Add(Option_C_btn);
            Name = "Multiple_Choice";
            Size = new Size(1205, 663);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Option_C_btn;
        private Button Option_D_btn;
        private Button Option_B_btn;
        private Button Option_A_btn;
        private TextBox Question_txbx;
        public Button nextOrSkip_button;
    }
}
