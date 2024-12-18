namespace Gamify__Quizzlett_Application.Additional_Forms.Multiple_Choice_Control
{
    partial class Modifiable_MC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Modifiable_MC));
            Opt_A_txbx = new TextBox();
            main_pb = new PictureBox();
            Question_holder_txbx = new TextBox();
            Opt_C_txbx = new TextBox();
            Opt_B_txbx = new TextBox();
            Opt_D_txbx = new TextBox();
            Modify_lbl = new Label();
            browsw_file = new FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)main_pb).BeginInit();
            SuspendLayout();
            // 
            // Opt_A_txbx
            // 
            Opt_A_txbx.BorderStyle = BorderStyle.None;
            Opt_A_txbx.Font = new Font("Architects Daughter", 9F);
            Opt_A_txbx.Location = new Point(103, 462);
            Opt_A_txbx.Multiline = true;
            Opt_A_txbx.Name = "Opt_A_txbx";
            Opt_A_txbx.PlaceholderText = "Option A";
            Opt_A_txbx.Size = new Size(492, 65);
            Opt_A_txbx.TabIndex = 0;
            // 
            // main_pb
            // 
            main_pb.BackgroundImage = (Image)resources.GetObject("main_pb.BackgroundImage");
            main_pb.BackgroundImageLayout = ImageLayout.Center;
            main_pb.Location = new Point(103, 69);
            main_pb.Name = "main_pb";
            main_pb.Size = new Size(363, 373);
            main_pb.TabIndex = 12;
            main_pb.TabStop = false;
            // 
            // Question_holder_txbx
            // 
            Question_holder_txbx.Font = new Font("Architects Daughter", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Question_holder_txbx.Location = new Point(472, 69);
            Question_holder_txbx.Multiline = true;
            Question_holder_txbx.Name = "Question_holder_txbx";
            Question_holder_txbx.PlaceholderText = "Enter your question here";
            Question_holder_txbx.Size = new Size(641, 373);
            Question_holder_txbx.TabIndex = 11;
            // 
            // Opt_C_txbx
            // 
            Opt_C_txbx.Font = new Font("Architects Daughter", 9F);
            Opt_C_txbx.Location = new Point(103, 542);
            Opt_C_txbx.Multiline = true;
            Opt_C_txbx.Name = "Opt_C_txbx";
            Opt_C_txbx.PlaceholderText = "Option C";
            Opt_C_txbx.Size = new Size(492, 65);
            Opt_C_txbx.TabIndex = 13;
            // 
            // Opt_B_txbx
            // 
            Opt_B_txbx.Font = new Font("Architects Daughter", 9F);
            Opt_B_txbx.Location = new Point(601, 462);
            Opt_B_txbx.Multiline = true;
            Opt_B_txbx.Name = "Opt_B_txbx";
            Opt_B_txbx.PlaceholderText = "Option B";
            Opt_B_txbx.Size = new Size(512, 65);
            Opt_B_txbx.TabIndex = 14;
            // 
            // Opt_D_txbx
            // 
            Opt_D_txbx.Font = new Font("Architects Daughter", 9F);
            Opt_D_txbx.Location = new Point(601, 542);
            Opt_D_txbx.Multiline = true;
            Opt_D_txbx.Name = "Opt_D_txbx";
            Opt_D_txbx.PlaceholderText = "Option D";
            Opt_D_txbx.Size = new Size(512, 65);
            Opt_D_txbx.TabIndex = 15;
            // 
            // Modify_lbl
            // 
            Modify_lbl.AutoSize = true;
            Modify_lbl.Font = new Font("Architects Daughter", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Modify_lbl.ForeColor = SystemColors.Control;
            Modify_lbl.Location = new Point(14, 11);
            Modify_lbl.Name = "Modify_lbl";
            Modify_lbl.Size = new Size(177, 29);
            Modify_lbl.TabIndex = 16;
            Modify_lbl.Text = "Modify Question";
            // 
            // Modifiable_MC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(49, 46, 129);
            Controls.Add(Modify_lbl);
            Controls.Add(Opt_D_txbx);
            Controls.Add(Opt_B_txbx);
            Controls.Add(Opt_C_txbx);
            Controls.Add(main_pb);
            Controls.Add(Question_holder_txbx);
            Controls.Add(Opt_A_txbx);
            Name = "Modifiable_MC";
            Size = new Size(1205, 663);
            ((System.ComponentModel.ISupportInitialize)main_pb).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Opt_A_txbx;
        private PictureBox main_pb;
        private TextBox Question_holder_txbx;
        private TextBox Opt_C_txbx;
        private TextBox Opt_B_txbx;
        private TextBox Opt_D_txbx;
        private Label Modify_lbl;
        private FolderBrowserDialog browsw_file;
    }
}
