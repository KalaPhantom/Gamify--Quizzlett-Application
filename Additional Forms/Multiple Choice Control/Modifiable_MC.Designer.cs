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
            groupBox1 = new GroupBox();
            image_lbl = new Label();
            count_lbl = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            Selected = new Label();
            rightSelector_btn = new Button();
            leftSelector_btn = new Button();
            ((System.ComponentModel.ISupportInitialize)main_pb).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // Opt_A_txbx
            // 
            Opt_A_txbx.BorderStyle = BorderStyle.None;
            Opt_A_txbx.Font = new Font("Architects Daughter", 9F);
            Opt_A_txbx.Location = new Point(90, 346);
            Opt_A_txbx.Margin = new Padding(3, 2, 3, 2);
            Opt_A_txbx.Multiline = true;
            Opt_A_txbx.Name = "Opt_A_txbx";
            Opt_A_txbx.PlaceholderText = "Option A";
            Opt_A_txbx.Size = new Size(430, 49);
            Opt_A_txbx.TabIndex = 0;
            Opt_A_txbx.TextChanged += Opt_A_txbx_TextChanged;
            // 
            // main_pb
            // 
            main_pb.BackgroundImage = (Image)resources.GetObject("main_pb.BackgroundImage");
            main_pb.BackgroundImageLayout = ImageLayout.Center;
            main_pb.Location = new Point(6, 21);
            main_pb.Margin = new Padding(3, 2, 3, 2);
            main_pb.Name = "main_pb";
            main_pb.Size = new Size(305, 276);
            main_pb.TabIndex = 12;
            main_pb.TabStop = false;
            main_pb.DragDrop += main_pb_DragDrop;
            // 
            // Question_holder_txbx
            // 
            Question_holder_txbx.Font = new Font("Architects Daughter", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Question_holder_txbx.Location = new Point(413, 46);
            Question_holder_txbx.Margin = new Padding(3, 2, 3, 2);
            Question_holder_txbx.Multiline = true;
            Question_holder_txbx.Name = "Question_holder_txbx";
            Question_holder_txbx.PlaceholderText = "Enter your question here";
            Question_holder_txbx.Size = new Size(561, 172);
            Question_holder_txbx.TabIndex = 11;
            Question_holder_txbx.TextChanged += Question_holder_txbx_TextChanged;
            // 
            // Opt_C_txbx
            // 
            Opt_C_txbx.Font = new Font("Architects Daughter", 9F);
            Opt_C_txbx.Location = new Point(90, 406);
            Opt_C_txbx.Margin = new Padding(3, 2, 3, 2);
            Opt_C_txbx.Multiline = true;
            Opt_C_txbx.Name = "Opt_C_txbx";
            Opt_C_txbx.PlaceholderText = "Option C";
            Opt_C_txbx.Size = new Size(431, 50);
            Opt_C_txbx.TabIndex = 13;
            Opt_C_txbx.TextChanged += Opt_C_txbx_TextChanged;
            // 
            // Opt_B_txbx
            // 
            Opt_B_txbx.Font = new Font("Architects Daughter", 9F);
            Opt_B_txbx.Location = new Point(526, 346);
            Opt_B_txbx.Margin = new Padding(3, 2, 3, 2);
            Opt_B_txbx.Multiline = true;
            Opt_B_txbx.Name = "Opt_B_txbx";
            Opt_B_txbx.PlaceholderText = "Option B";
            Opt_B_txbx.Size = new Size(448, 50);
            Opt_B_txbx.TabIndex = 14;
            Opt_B_txbx.TextChanged += Opt_B_txbx_TextChanged;
            // 
            // Opt_D_txbx
            // 
            Opt_D_txbx.Font = new Font("Architects Daughter", 9F);
            Opt_D_txbx.Location = new Point(526, 406);
            Opt_D_txbx.Margin = new Padding(3, 2, 3, 2);
            Opt_D_txbx.Multiline = true;
            Opt_D_txbx.Name = "Opt_D_txbx";
            Opt_D_txbx.PlaceholderText = "Option D";
            Opt_D_txbx.Size = new Size(448, 50);
            Opt_D_txbx.TabIndex = 15;
            Opt_D_txbx.TextChanged += Opt_D_txbx_TextChanged;
            // 
            // Modify_lbl
            // 
            Modify_lbl.AutoSize = true;
            Modify_lbl.Font = new Font("Architects Daughter", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Modify_lbl.ForeColor = SystemColors.Control;
            Modify_lbl.Location = new Point(12, 8);
            Modify_lbl.Name = "Modify_lbl";
            Modify_lbl.Size = new Size(189, 25);
            Modify_lbl.TabIndex = 16;
            Modify_lbl.Text = "Modify Question No: ";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(image_lbl);
            groupBox1.Controls.Add(main_pb);
            groupBox1.Location = new Point(90, 36);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(317, 305);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            // 
            // image_lbl
            // 
            image_lbl.AutoSize = true;
            image_lbl.Font = new Font("Architects Daughter", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            image_lbl.ForeColor = SystemColors.ButtonHighlight;
            image_lbl.Location = new Point(105, 187);
            image_lbl.Name = "image_lbl";
            image_lbl.Size = new Size(113, 20);
            image_lbl.TabIndex = 13;
            image_lbl.Text = "add image here";
            // 
            // count_lbl
            // 
            count_lbl.AutoSize = true;
            count_lbl.Font = new Font("Architects Daughter", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            count_lbl.ForeColor = SystemColors.ButtonHighlight;
            count_lbl.Location = new Point(207, 8);
            count_lbl.Name = "count_lbl";
            count_lbl.Size = new Size(14, 25);
            count_lbl.TabIndex = 18;
            count_lbl.Text = "1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Architects Daughter", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(6, 19);
            label1.Name = "label1";
            label1.Size = new Size(135, 20);
            label1.TabIndex = 20;
            label1.Text = "Correct Answer";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(Selected);
            groupBox2.Controls.Add(rightSelector_btn);
            groupBox2.Controls.Add(leftSelector_btn);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(413, 223);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(561, 110);
            groupBox2.TabIndex = 21;
            groupBox2.TabStop = false;
            // 
            // Selected
            // 
            Selected.AutoSize = true;
            Selected.Font = new Font("Architects Daughter", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Selected.ForeColor = SystemColors.ButtonHighlight;
            Selected.Location = new Point(248, 55);
            Selected.Name = "Selected";
            Selected.Size = new Size(47, 23);
            Selected.TabIndex = 23;
            Selected.Text = "None";
            // 
            // rightSelector_btn
            // 
            rightSelector_btn.BackgroundImage = Properties.Resources.png_3qy3mj1;
            rightSelector_btn.BackgroundImageLayout = ImageLayout.Center;
            rightSelector_btn.FlatStyle = FlatStyle.Flat;
            rightSelector_btn.ForeColor = SystemColors.ButtonHighlight;
            rightSelector_btn.Location = new Point(390, 55);
            rightSelector_btn.Name = "rightSelector_btn";
            rightSelector_btn.Size = new Size(75, 23);
            rightSelector_btn.TabIndex = 22;
            rightSelector_btn.UseVisualStyleBackColor = true;
            rightSelector_btn.Click += rightSelector_btn_Click;
            // 
            // leftSelector_btn
            // 
            leftSelector_btn.BackgroundImage = Properties.Resources.png_0q6s61;
            leftSelector_btn.BackgroundImageLayout = ImageLayout.Center;
            leftSelector_btn.FlatStyle = FlatStyle.Flat;
            leftSelector_btn.ForeColor = SystemColors.ButtonFace;
            leftSelector_btn.Location = new Point(109, 55);
            leftSelector_btn.Name = "leftSelector_btn";
            leftSelector_btn.Size = new Size(75, 23);
            leftSelector_btn.TabIndex = 21;
            leftSelector_btn.UseVisualStyleBackColor = true;
            leftSelector_btn.Click += leftSelector_btn_Click;
            // 
            // Modifiable_MC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(49, 46, 129);
            Controls.Add(groupBox2);
            Controls.Add(count_lbl);
            Controls.Add(groupBox1);
            Controls.Add(Modify_lbl);
            Controls.Add(Opt_D_txbx);
            Controls.Add(Opt_B_txbx);
            Controls.Add(Opt_C_txbx);
            Controls.Add(Question_holder_txbx);
            Controls.Add(Opt_A_txbx);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Modifiable_MC";
            Size = new Size(1054, 497);
            ((System.ComponentModel.ISupportInitialize)main_pb).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
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
        private GroupBox groupBox1;
        private Label count_lbl;
        private Label label1;
        private GroupBox groupBox2;
        private Label Selected;
        private Button rightSelector_btn;
        private Button leftSelector_btn;
        private Label image_lbl;
    }
}
