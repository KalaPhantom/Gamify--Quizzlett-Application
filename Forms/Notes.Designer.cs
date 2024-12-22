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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Notes));
            return_btn = new Button();
            panel4textEditor = new Panel();
            btnRedo = new Button();
            btnUndo = new Button();
            btnNumberingList = new Button();
            btnParagraphAlignment = new Button();
            btnClearTextFormat = new Button();
            btnBulletList = new Button();
            label2 = new Label();
            btnTextBackColor = new Button();
            btnTextColor = new Button();
            label1 = new Label();
            rtbTexEditor = new RichTextBox();
            textboxtitle = new TextBox();
            btnBold = new Button();
            comboBoxFont = new ComboBox();
            comboBoxFontSize = new ComboBox();
            btnItalic = new Button();
            btnUnderline = new Button();
            panel1 = new Panel();
            btnExport = new Button();
            btnImport = new Button();
            btnDelete = new Button();
            btnSave = new Button();
            btnNewNote = new Button();
            label3 = new Label();
            btnLoad = new Button();
            dgvpreviousNotes = new DataGridView();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            panel4textEditor.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvpreviousNotes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // return_btn
            // 
            return_btn.Location = new Point(34, 564);
            return_btn.Margin = new Padding(3, 2, 3, 2);
            return_btn.Name = "return_btn";
            return_btn.Size = new Size(82, 22);
            return_btn.TabIndex = 0;
            return_btn.Text = "Return to menu ";
            return_btn.UseVisualStyleBackColor = true;
            return_btn.Click += return_btn_Click;
            // 
            // panel4textEditor
            // 
            panel4textEditor.BackColor = Color.FromArgb(19, 19, 19);
            panel4textEditor.Controls.Add(btnRedo);
            panel4textEditor.Controls.Add(btnUndo);
            panel4textEditor.Controls.Add(btnNumberingList);
            panel4textEditor.Controls.Add(btnParagraphAlignment);
            panel4textEditor.Controls.Add(btnClearTextFormat);
            panel4textEditor.Controls.Add(btnBulletList);
            panel4textEditor.Controls.Add(label2);
            panel4textEditor.Controls.Add(btnTextBackColor);
            panel4textEditor.Controls.Add(btnTextColor);
            panel4textEditor.Controls.Add(label1);
            panel4textEditor.Controls.Add(rtbTexEditor);
            panel4textEditor.Controls.Add(textboxtitle);
            panel4textEditor.Controls.Add(btnBold);
            panel4textEditor.Controls.Add(comboBoxFont);
            panel4textEditor.Controls.Add(comboBoxFontSize);
            panel4textEditor.Controls.Add(btnItalic);
            panel4textEditor.Controls.Add(btnUnderline);
            panel4textEditor.Location = new Point(376, 3);
            panel4textEditor.Name = "panel4textEditor";
            panel4textEditor.Size = new Size(796, 605);
            panel4textEditor.TabIndex = 1;
            // 
            // btnRedo
            // 
            btnRedo.BackColor = Color.Silver;
            btnRedo.FlatAppearance.BorderSize = 0;
            btnRedo.FlatStyle = FlatStyle.Flat;
            btnRedo.Image = (Image)resources.GetObject("btnRedo.Image");
            btnRedo.Location = new Point(760, 58);
            btnRedo.Name = "btnRedo";
            btnRedo.Size = new Size(29, 30);
            btnRedo.TabIndex = 40;
            btnRedo.UseVisualStyleBackColor = false;
            btnRedo.Click += btnRedo_Click;
            btnRedo.MouseHover += btnRedo_MouseHover;
            // 
            // btnUndo
            // 
            btnUndo.BackColor = Color.Silver;
            btnUndo.FlatAppearance.BorderSize = 0;
            btnUndo.FlatStyle = FlatStyle.Flat;
            btnUndo.Image = (Image)resources.GetObject("btnUndo.Image");
            btnUndo.Location = new Point(723, 58);
            btnUndo.Name = "btnUndo";
            btnUndo.Size = new Size(29, 30);
            btnUndo.TabIndex = 39;
            btnUndo.UseVisualStyleBackColor = false;
            btnUndo.Click += btnUndo_Click;
            btnUndo.MouseHover += btnUndo_MouseHover;
            // 
            // btnNumberingList
            // 
            btnNumberingList.BackColor = Color.Silver;
            btnNumberingList.FlatAppearance.BorderSize = 0;
            btnNumberingList.FlatStyle = FlatStyle.Flat;
            btnNumberingList.Image = (Image)resources.GetObject("btnNumberingList.Image");
            btnNumberingList.Location = new Point(690, 564);
            btnNumberingList.Name = "btnNumberingList";
            btnNumberingList.Size = new Size(29, 30);
            btnNumberingList.TabIndex = 38;
            btnNumberingList.UseVisualStyleBackColor = false;
            btnNumberingList.Click += btnNumberingList_Click;
            btnNumberingList.MouseHover += btnNumberingList_MouseHover;
            // 
            // btnParagraphAlignment
            // 
            btnParagraphAlignment.BackColor = Color.Silver;
            btnParagraphAlignment.FlatAppearance.BorderSize = 0;
            btnParagraphAlignment.FlatStyle = FlatStyle.Flat;
            btnParagraphAlignment.Image = (Image)resources.GetObject("btnParagraphAlignment.Image");
            btnParagraphAlignment.Location = new Point(133, 566);
            btnParagraphAlignment.Name = "btnParagraphAlignment";
            btnParagraphAlignment.Size = new Size(29, 30);
            btnParagraphAlignment.TabIndex = 37;
            btnParagraphAlignment.UseVisualStyleBackColor = false;
            btnParagraphAlignment.Click += btnParagraphAlignment_Click;
            btnParagraphAlignment.MouseHover += btnParagraphAlignment_MouseHover;
            // 
            // btnClearTextFormat
            // 
            btnClearTextFormat.BackColor = Color.Silver;
            btnClearTextFormat.FlatAppearance.BorderSize = 0;
            btnClearTextFormat.FlatStyle = FlatStyle.Flat;
            btnClearTextFormat.Image = (Image)resources.GetObject("btnClearTextFormat.Image");
            btnClearTextFormat.Location = new Point(760, 564);
            btnClearTextFormat.Name = "btnClearTextFormat";
            btnClearTextFormat.Size = new Size(29, 30);
            btnClearTextFormat.TabIndex = 35;
            btnClearTextFormat.UseVisualStyleBackColor = false;
            btnClearTextFormat.Click += btnClearTextFormat_Click;
            btnClearTextFormat.MouseHover += btnClearTextFormat_MouseHover;
            // 
            // btnBulletList
            // 
            btnBulletList.BackColor = Color.Silver;
            btnBulletList.FlatAppearance.BorderSize = 0;
            btnBulletList.FlatStyle = FlatStyle.Flat;
            btnBulletList.Image = (Image)resources.GetObject("btnBulletList.Image");
            btnBulletList.Location = new Point(725, 564);
            btnBulletList.Name = "btnBulletList";
            btnBulletList.Size = new Size(29, 30);
            btnBulletList.TabIndex = 33;
            btnBulletList.UseVisualStyleBackColor = false;
            btnBulletList.Click += btnBulletList_Click;
            btnBulletList.MouseHover += btnBulletList_MouseHover;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(17, 72);
            label2.Name = "label2";
            label2.Size = new Size(48, 19);
            label2.TabIndex = 3;
            label2.Text = "Notes";
            // 
            // btnTextBackColor
            // 
            btnTextBackColor.BackColor = Color.Silver;
            btnTextBackColor.FlatAppearance.BorderSize = 0;
            btnTextBackColor.FlatStyle = FlatStyle.Flat;
            btnTextBackColor.Image = (Image)resources.GetObject("btnTextBackColor.Image");
            btnTextBackColor.Location = new Point(209, 566);
            btnTextBackColor.Name = "btnTextBackColor";
            btnTextBackColor.Size = new Size(29, 30);
            btnTextBackColor.TabIndex = 31;
            btnTextBackColor.UseVisualStyleBackColor = false;
            btnTextBackColor.Click += btnTextBackColor_Click;
            btnTextBackColor.MouseHover += btnTextBackColor_MouseHover;
            // 
            // btnTextColor
            // 
            btnTextColor.BackColor = Color.Silver;
            btnTextColor.FlatAppearance.BorderSize = 0;
            btnTextColor.FlatStyle = FlatStyle.Flat;
            btnTextColor.Image = (Image)resources.GetObject("btnTextColor.Image");
            btnTextColor.Location = new Point(171, 566);
            btnTextColor.Name = "btnTextColor";
            btnTextColor.Size = new Size(29, 30);
            btnTextColor.TabIndex = 29;
            btnTextColor.UseVisualStyleBackColor = false;
            btnTextColor.Click += btnTextColor_Click;
            btnTextColor.MouseHover += btnTextColor_MouseHover;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(18, 11);
            label1.Name = "label1";
            label1.Size = new Size(38, 19);
            label1.TabIndex = 2;
            label1.Text = "Title";
            // 
            // rtbTexEditor
            // 
            rtbTexEditor.BackColor = Color.DimGray;
            rtbTexEditor.BorderStyle = BorderStyle.None;
            rtbTexEditor.ForeColor = Color.White;
            rtbTexEditor.Location = new Point(18, 94);
            rtbTexEditor.Name = "rtbTexEditor";
            rtbTexEditor.Size = new Size(771, 455);
            rtbTexEditor.TabIndex = 1;
            rtbTexEditor.Text = "";
            rtbTexEditor.TextChanged += rtbTexEditor_TextChanged;
            // 
            // textboxtitle
            // 
            textboxtitle.BackColor = Color.FromArgb(64, 64, 64);
            textboxtitle.BorderStyle = BorderStyle.None;
            textboxtitle.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            textboxtitle.ForeColor = Color.White;
            textboxtitle.Location = new Point(17, 33);
            textboxtitle.Name = "textboxtitle";
            textboxtitle.Size = new Size(772, 19);
            textboxtitle.TabIndex = 0;
            // 
            // btnBold
            // 
            btnBold.BackColor = Color.Silver;
            btnBold.FlatAppearance.BorderSize = 0;
            btnBold.FlatStyle = FlatStyle.Flat;
            btnBold.ForeColor = Color.White;
            btnBold.Image = (Image)resources.GetObject("btnBold.Image");
            btnBold.Location = new Point(20, 566);
            btnBold.Name = "btnBold";
            btnBold.Size = new Size(28, 30);
            btnBold.TabIndex = 22;
            btnBold.UseVisualStyleBackColor = false;
            btnBold.Click += btnBold_Click;
            btnBold.MouseHover += btnBold_MouseHover;
            // 
            // comboBoxFont
            // 
            comboBoxFont.BackColor = Color.Silver;
            comboBoxFont.FlatStyle = FlatStyle.Flat;
            comboBoxFont.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxFont.FormattingEnabled = true;
            comboBoxFont.Location = new Point(248, 566);
            comboBoxFont.Name = "comboBoxFont";
            comboBoxFont.Size = new Size(257, 27);
            comboBoxFont.TabIndex = 25;
            comboBoxFont.SelectedIndexChanged += comboBoxFont_SelectedIndexChanged;
            // 
            // comboBoxFontSize
            // 
            comboBoxFontSize.BackColor = Color.Silver;
            comboBoxFontSize.FlatStyle = FlatStyle.Flat;
            comboBoxFontSize.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxFontSize.FormattingEnabled = true;
            comboBoxFontSize.Location = new Point(511, 566);
            comboBoxFontSize.Name = "comboBoxFontSize";
            comboBoxFontSize.Size = new Size(172, 27);
            comboBoxFontSize.TabIndex = 28;
            comboBoxFontSize.SelectedIndexChanged += comboBoxFontSize_SelectedIndexChanged;
            // 
            // btnItalic
            // 
            btnItalic.BackColor = Color.Silver;
            btnItalic.FlatAppearance.BorderSize = 0;
            btnItalic.FlatStyle = FlatStyle.Flat;
            btnItalic.Image = (Image)resources.GetObject("btnItalic.Image");
            btnItalic.Location = new Point(57, 566);
            btnItalic.Name = "btnItalic";
            btnItalic.Size = new Size(29, 30);
            btnItalic.TabIndex = 23;
            btnItalic.UseVisualStyleBackColor = false;
            btnItalic.Click += btnItalic_Click;
            btnItalic.MouseHover += btnItalic_MouseHover;
            // 
            // btnUnderline
            // 
            btnUnderline.BackColor = Color.Silver;
            btnUnderline.FlatAppearance.BorderSize = 0;
            btnUnderline.FlatStyle = FlatStyle.Flat;
            btnUnderline.Image = (Image)resources.GetObject("btnUnderline.Image");
            btnUnderline.Location = new Point(95, 566);
            btnUnderline.Name = "btnUnderline";
            btnUnderline.Size = new Size(29, 30);
            btnUnderline.TabIndex = 24;
            btnUnderline.UseVisualStyleBackColor = false;
            btnUnderline.Click += btnUnderline_Click;
            btnUnderline.MouseHover += btnUnderline_MouseHover;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnExport);
            panel1.Controls.Add(btnImport);
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(btnSave);
            panel1.Controls.Add(btnNewNote);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(btnLoad);
            panel1.Controls.Add(dgvpreviousNotes);
            panel1.Location = new Point(148, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(222, 605);
            panel1.TabIndex = 2;
            // 
            // btnExport
            // 
            btnExport.BackColor = SystemColors.ButtonShadow;
            btnExport.FlatStyle = FlatStyle.Flat;
            btnExport.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnExport.ForeColor = SystemColors.ActiveCaptionText;
            btnExport.Location = new Point(7, 566);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(210, 30);
            btnExport.TabIndex = 9;
            btnExport.Text = "Export";
            btnExport.UseVisualStyleBackColor = false;
            btnExport.Click += btnExport_Click;
            // 
            // btnImport
            // 
            btnImport.BackColor = SystemColors.ButtonShadow;
            btnImport.FlatStyle = FlatStyle.Flat;
            btnImport.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnImport.ForeColor = SystemColors.ActiveCaptionText;
            btnImport.Location = new Point(7, 530);
            btnImport.Name = "btnImport";
            btnImport.Size = new Size(211, 30);
            btnImport.TabIndex = 8;
            btnImport.Text = "Import";
            btnImport.UseVisualStyleBackColor = false;
            btnImport.Click += btnImport_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Silver;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnDelete.ForeColor = SystemColors.ActiveCaptionText;
            btnDelete.Location = new Point(114, 494);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(103, 30);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Silver;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnSave.ForeColor = SystemColors.ActiveCaptionText;
            btnSave.Location = new Point(7, 494);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(102, 30);
            btnSave.TabIndex = 6;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnNewNote
            // 
            btnNewNote.BackColor = Color.Silver;
            btnNewNote.FlatStyle = FlatStyle.Flat;
            btnNewNote.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnNewNote.ForeColor = SystemColors.ActiveCaptionText;
            btnNewNote.Location = new Point(115, 458);
            btnNewNote.Name = "btnNewNote";
            btnNewNote.Size = new Size(103, 30);
            btnNewNote.TabIndex = 5;
            btnNewNote.Text = "New Note";
            btnNewNote.UseVisualStyleBackColor = false;
            btnNewNote.Click += btnNewNote_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(3, 9);
            label3.Name = "label3";
            label3.Size = new Size(73, 19);
            label3.TabIndex = 4;
            label3.Text = "My Notes";
            // 
            // btnLoad
            // 
            btnLoad.BackColor = Color.Silver;
            btnLoad.FlatStyle = FlatStyle.Flat;
            btnLoad.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnLoad.ForeColor = SystemColors.ActiveCaptionText;
            btnLoad.Location = new Point(7, 458);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(102, 30);
            btnLoad.TabIndex = 4;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = false;
            btnLoad.Click += btnLoad_Click;
            // 
            // dgvpreviousNotes
            // 
            dgvpreviousNotes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvpreviousNotes.BackgroundColor = Color.FromArgb(24, 24, 24);
            dgvpreviousNotes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvpreviousNotes.Location = new Point(3, 33);
            dgvpreviousNotes.Name = "dgvpreviousNotes";
            dgvpreviousNotes.Size = new Size(216, 419);
            dgvpreviousNotes.TabIndex = 0;
            dgvpreviousNotes.CellClick += dgvpreviousNotes_CellClick;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(13, 11);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(127, 67);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.InactiveCaptionText;
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(return_btn);
            panel2.Location = new Point(-1, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(146, 605);
            panel2.TabIndex = 41;
            // 
            // Notes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(24, 24, 27);
            ClientSize = new Size(1175, 611);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panel4textEditor);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Notes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Note Taking";
            Load += Notes_Load;
            panel4textEditor.ResumeLayout(false);
            panel4textEditor.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvpreviousNotes).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button return_btn;
        private Panel panel4textEditor;
        private RichTextBox rtbTexEditor;
        private TextBox textboxtitle;
        private Panel panel1;
        private DataGridView dgvpreviousNotes;
        private Label label1;
        private Label label2;
        private Button button3;
        private Button button2;
        private Button btnLoad;
        private Label label3;
        private Button btnExport;
        private Button btnImport;
        private Button btnDelete;
        private Button btnSave;
        private Button btnNewNote;
        private Button btnClearTextFormat;
        private Button btnBulletList;
        private Button btnBold;
        private ComboBox comboBoxFont;
        private Button btnTextBackColor;
        private Button btnTextColor;
        private ComboBox comboBoxFontSize;
        private Button btnItalic;
        private Button btnUnderline;
        private Button btnNumberingList;
        private Button btnParagraphAlignment;
        private Button btnRedo;
        private Button btnUndo;
        private PictureBox pictureBox1;
        private Panel panel2;
    }
}