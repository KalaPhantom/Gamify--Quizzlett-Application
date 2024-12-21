using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using Wp = DocumentFormat.OpenXml.Wordprocessing;
using iText.Kernel.Pdf;

namespace Gamify__Quizzlett_Application.Forms
{
    public partial class Notes : Form
    {
        DataTable notes = new DataTable();
        bool editing = false;

        private ColorDialog colorDialog;

        ToolTip toolTip = new ToolTip();

        private Stack<string> undoStack = new Stack<string>();
        private Stack<string> redoStack = new Stack<string>();

        public Notes()
        {
            InitializeComponent();
            colorDialog = new ColorDialog();
        }

        private void return_btn_Click(object sender, EventArgs e)
        {
            // TODO: Implement A destructor
            this.Close();
        }

        private void Notes_Load(object sender, EventArgs e)
        {
            dgvpreviousNotes.DefaultCellStyle.ForeColor = Color.Black;
            dgvpreviousNotes.DefaultCellStyle.SelectionBackColor = Color.DimGray;

            notes.Columns.Add("Titles");
            notes.Columns.Add("Note");

            dgvpreviousNotes.DataSource = notes;

            // Load the fonts into the combobox when the form loads
            // Get all the Font Family names from Graphics associated to richTextBox
            // Then load the font name to the combobox
            Graphics gr = rtbTexEditor.CreateGraphics();
            foreach (System.Drawing.FontFamily F_family in System.Drawing.FontFamily.GetFamilies(gr))
            {
                comboBoxFont.Items.Add(F_family.Name);
            }

            // Load font sizes
            for (int fsize = 7; fsize < 73; fsize++)
            {
                comboBoxFontSize.Items.Add(fsize);
            }

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (dgvpreviousNotes.CurrentCell != null)
            {
                textboxtitle.Text = notes.Rows[dgvpreviousNotes.CurrentCell.RowIndex].ItemArray[0].ToString();
                rtbTexEditor.Rtf = notes.Rows[dgvpreviousNotes.CurrentCell.RowIndex].ItemArray[1].ToString();
                editing = true;
            }
        }

        private void btnNewNote_Click(object sender, EventArgs e)
        {
            textboxtitle.Text = "";
            rtbTexEditor.Text = "";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (editing && dgvpreviousNotes.CurrentCell != null)
            {
                // Update existing note
                notes.Rows[dgvpreviousNotes.CurrentCell.RowIndex]["Title"] = textboxtitle.Text;
                notes.Rows[dgvpreviousNotes.CurrentCell.RowIndex]["Note"] = rtbTexEditor.Rtf;
            }
            else
            {
                // Add new note
                notes.Rows.Add(textboxtitle.Text, rtbTexEditor.Rtf);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                notes.Rows[dgvpreviousNotes.CurrentCell.RowIndex].Delete();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Not a valid note");
            };

        }

        private void dgvpreviousNotes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvpreviousNotes.CurrentCell != null)
            {
                textboxtitle.Text = notes.Rows[dgvpreviousNotes.CurrentCell.RowIndex].ItemArray[0].ToString();
                rtbTexEditor.Rtf = notes.Rows[dgvpreviousNotes.CurrentCell.RowIndex].ItemArray[1].ToString();
                editing = true;
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Text files (*.txt)|*.txt|Rich Text Format (*.rtf)|*.rtf|Word Document (*.docx)|*.docx|PDF file (*.pdf)|*.pdf",
                FilterIndex = 1,
                Multiselect = false
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filename = openFileDialog.FileName;
                string extension = Path.GetExtension(filename).ToLower();

                try
                {
                    switch (extension)
                    {
                        case ".txt":
                            rtbTexEditor.Text = File.ReadAllText(filename);
                            break;

                        case ".rtf":
                            rtbTexEditor.LoadFile(filename, RichTextBoxStreamType.RichText);
                            break;

                        case ".docx":
                            rtbTexEditor.Text = LoadDocxContent(filename);
                            break;

                        case ".pdf":
                            rtbTexEditor.Text = LoadPdfContent(filename);
                            break;

                        default:
                            MessageBox.Show("Unsupported file type.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error reading file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private string LoadDocxContent(string filepath)
        {
            using (WordprocessingDocument wordDoc = WordprocessingDocument.Open(filepath, false))
            {
                var body = wordDoc.MainDocumentPart.Document.Body;
                return body.InnerText;
            }
        }

        private string LoadPdfContent(string filepath)
        {
            StringBuilder text = new StringBuilder();

            using (PdfReader pdfReader = new PdfReader(filepath))
            {
                PdfDocument pdf = new PdfDocument(pdfReader);

                for (int i = 1; i <= pdf.GetNumberOfPages(); i++)
                {
                    var page = pdf.GetPage(i);
                    var content = iText.Kernel.Pdf.Canvas.Parser.PdfTextExtractor.GetTextFromPage(page);
                    text.Append(content);
                }
            }

            return text.ToString();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Word Document (*.docx)|*.docx|PDF file (*.pdf)|*.pdf|Rich Text Format (*.rtf)|*.rtf|Text file (*.txt)|*.txt";
            saveFileDialog1.FilterIndex = 4;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filename = saveFileDialog1.FileName;
                string extension = Path.GetExtension(filename).ToLower();
                string rtfContent = rtbTexEditor.Rtf;

                switch (extension)
                {
                    case ".rtf":
                        rtbTexEditor.SaveFile(filename, RichTextBoxStreamType.RichText);
                        break;
                    case ".pdf":
                        SaveAsPdf(filename, rtfContent);
                        break;
                    case ".docx":
                        SaveAsDocx(filename, rtfContent);
                        break;
                    case ".txt":
                        File.WriteAllText(filename, rtbTexEditor.Text);
                        break;
                    default:
                        MessageBox.Show("Unsupported file type.");
                        break;
                }

                rtbTexEditor.Clear();
                rtbTexEditor.Clear();
                editing = false;
            }
        }

        private void SaveAsPdf(string filename, string rtfContent)
        {
            // Save as plain text, no styles
            using (FileStream writer = new FileStream(filename, FileMode.Create))
            {
                var pdfWriter = new PdfWriter(writer);
                var pdf = new PdfDocument(pdfWriter);
                var document = new iText.Layout.Document(pdf);

                // Convert RTF content to HTML
                string htmlContent = ConvertRtfToHtml(rtfContent);

                // Add HTML content to PDF
                document.Add(new iText.Layout.Element.Paragraph(htmlContent));

                document.Close();
            }
        }

        private void SaveAsDocx(string filename, string rtfContent)
        {
            // Save as plain text, no formatting
            string plainText = ConvertRtfToPlainText(rtfContent);

            using (var doc = WordprocessingDocument.Create(filename, WordprocessingDocumentType.Document))
            {
                var mainPart = doc.AddMainDocumentPart();
                mainPart.Document = new Wp.Document();
                var body = new Wp.Body();

                // Add plain text content to DOCX body
                var paragraph = new Wp.Paragraph(new Wp.Run(new Wp.Text(plainText)));
                body.Append(paragraph);
                mainPart.Document.Append(body);
                mainPart.Document.Save();
            }
        }

        private string ConvertRtfToPlainText(string rtfContent)
        {
            using (var rtb = new System.Windows.Forms.RichTextBox())
            {
                rtb.Rtf = rtfContent;
                return rtb.Text;
            }
        }

        private string ConvertRtfToHtml(string rtfContent)
        {
            using (var rtb = new System.Windows.Forms.RichTextBox())
            {
                rtb.Rtf = rtfContent;
                return rtb.Text;
            }
        }

        private void ToggleButtonColor(Button button, bool isActive)
        {
            if (isActive)
            {
                button.BackColor = Color.DarkGray;
            }
            else
            {
                button.BackColor = Color.Silver;
            }
        }

        //prevent triggering TextChanged during undo/redo
        private bool isProgrammaticChange = false;

        private void rtbTexEditor_TextChanged(object sender, EventArgs e)
        {
            if (isProgrammaticChange)
                return; // Skip if the change is programmatic

            // Push the current state to the undo stack
            undoStack.Push(rtbTexEditor.Rtf);

            // Clear the redo stack 
            redoStack.Clear();
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            if (undoStack.Count > 1) // Ensure there's at least one state to undo
            {
                // Temporarily disable TextChanged event
                isProgrammaticChange = true;

                // Push the current state to the redo stack
                redoStack.Push(undoStack.Pop());

                // Apply the previous state from the undo stack
                rtbTexEditor.Rtf = undoStack.Peek();

                // Re-enable TextChanged event
                isProgrammaticChange = false;
            }
            else
            {
                MessageBox.Show("Nothing to undo: Please add text in the editor box.", "Undo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnRedo_Click(object sender, EventArgs e)
        {
            if (redoStack.Count > 0)
            {
                // Temporarily disable TextChanged event
                isProgrammaticChange = true;

                // Push the current state to the undo stack
                undoStack.Push(redoStack.Pop());

                // Apply the last state from the redo stack
                rtbTexEditor.Rtf = undoStack.Peek();

                // Re-enable TextChanged event
                isProgrammaticChange = false;
            }
            else
            {
                MessageBox.Show("Nothing to redo: You've reached the latest state.", "Redo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnBold_Click(object sender, EventArgs e)
        {
            if (rtbTexEditor.SelectionFont != null)
            {
                System.Drawing.Font currentFont = rtbTexEditor.SelectionFont;
                FontStyle newStyle = currentFont.Style ^ FontStyle.Bold;
                System.Drawing.Font newFont = new System.Drawing.Font(currentFont, newStyle);
                rtbTexEditor.SelectionFont = newFont;
                ToggleButtonColor((Button)sender, newFont.Bold);
            }
        }

        private void btnItalic_Click(object sender, EventArgs e)
        {
            if (rtbTexEditor.SelectionFont != null)
            {
                System.Drawing.Font currentFont = rtbTexEditor.SelectionFont;
                FontStyle newStyle = currentFont.Style ^ FontStyle.Italic;
                System.Drawing.Font newFont = new System.Drawing.Font(currentFont, newStyle);
                rtbTexEditor.SelectionFont = newFont;
                ToggleButtonColor((Button)sender, newFont.Italic);
            }
        }

        private void btnUnderline_Click(object sender, EventArgs e)
        {
            if (rtbTexEditor.SelectionFont != null)
            {
                System.Drawing.Font currentFont = rtbTexEditor.SelectionFont;
                FontStyle newStyle = currentFont.Style ^ FontStyle.Underline;
                System.Drawing.Font newFont = new System.Drawing.Font(currentFont, newStyle);
                rtbTexEditor.SelectionFont = newFont;
                ToggleButtonColor((Button)sender, newFont.Underline);
            }
        }

        private enum AlignmentState
        {
            Left,
            Center,
            Right,
        }

        // Track the current alignment state
        private AlignmentState currentAlignment = AlignmentState.Left;

        private void btnParagraphAlignment_Click(object sender, EventArgs e)
        {
            // Cycle through the alignment states when the button is being clicked repeatedly
            switch (currentAlignment)
            {
                case AlignmentState.Left:
                    rtbTexEditor.SelectionAlignment = HorizontalAlignment.Left;
                    currentAlignment = AlignmentState.Center;
                    break;

                case AlignmentState.Center:
                    rtbTexEditor.SelectionAlignment = HorizontalAlignment.Center;
                    currentAlignment = AlignmentState.Right;
                    break;

                case AlignmentState.Right:
                    rtbTexEditor.SelectionAlignment = HorizontalAlignment.Right;
                    currentAlignment = AlignmentState.Left;
                    break;
            }
        }

        private void btnTextColor_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                rtbTexEditor.SelectionColor = colorDialog.Color;
            }
        }
        private void btnTextBackColor_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                rtbTexEditor.SelectionBackColor = colorDialog.Color;
            }
        }

        private void comboBoxFont_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetNewFont();
        }

        private void comboBoxFontSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetNewFont();
        }

        private void SetNewFont()
        {
            // Declarations that will feed Font 
            System.Drawing.Font old_font = null;
            System.Drawing.Font new_font;
            String Fname;
            float Fsize = 8;
            FontStyle style = 0;
            byte charset = 0;

            // Grab required information from UI
            Fname = comboBoxFont.Text;
            if (string.IsNullOrEmpty(comboBoxFontSize.Text))
            {
                Fsize = 8;
            }
            else
            {
                Fsize = float.Parse(comboBoxFontSize.Text);
                old_font = rtbTexEditor.SelectionFont;
            }

            // If no font/selection text then default 
            if (old_font == null)
            {
                style = FontStyle.Regular;
            }
            else
            {
                style = old_font.Style;
                charset = old_font.GdiCharSet;
            }

            // Construct the font
            new_font = new System.Drawing.Font(Fname, Fsize, style, GraphicsUnit.Point, charset);
            rtbTexEditor.SelectionFont = new_font;
        }


        private void btnNumberingList_Click(object sender, EventArgs e)
        {
            // Get the selected text or the current paragraph
            int selectionStart = rtbTexEditor.SelectionStart;
            int selectionLength = rtbTexEditor.SelectionLength;

            // Select the entire paragraph or selection
            rtbTexEditor.Select(selectionStart, selectionLength);
            string selectedText = rtbTexEditor.SelectedText;

            if (string.IsNullOrWhiteSpace(selectedText))
            {
                MessageBox.Show("Please select text to apply numbering.", "Numbering List", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Split the selected text into lines
            string[] lines = selectedText.Split(new[] { '\n' }, StringSplitOptions.None);

            // Apply numbering to each line
            StringBuilder numberedText = new StringBuilder();
            for (int i = 0; i < lines.Length; i++)
            {
                if (!string.IsNullOrWhiteSpace(lines[i]))
                {
                    numberedText.AppendLine($"{i + 1}. {lines[i].Trim()}");
                }
                else
                {
                    numberedText.AppendLine();
                }
            }

            // Replace the selected text with the numbered text
            rtbTexEditor.SelectedText = numberedText.ToString();

            // Restore the selection
            rtbTexEditor.Select(selectionStart, numberedText.Length);
            rtbTexEditor.SelectionIndent = 20;
            rtbTexEditor.Focus();
        }

        private void btnBulletList_Click(object sender, EventArgs e)
        {
            rtbTexEditor.SelectionBullet = true;
            rtbTexEditor.SelectionIndent = 20;
        }

        private void btnClearTextFormat_Click(object sender, EventArgs e)
        {
            // Save the current selection
            int start = rtbTexEditor.SelectionStart;
            int length = rtbTexEditor.SelectionLength;

            // Select the entire text if nothing is selected
            if (length == 0)
            {
                rtbTexEditor.SelectAll();
            }

            // Remove formatting from the selected text
            rtbTexEditor.SelectionFont = new Font(rtbTexEditor.Font, FontStyle.Regular);
            rtbTexEditor.SelectionColor = rtbTexEditor.ForeColor;
            rtbTexEditor.SelectionBackColor = rtbTexEditor.BackColor;
            rtbTexEditor.SelectionBullet = false;
            rtbTexEditor.SelectionIndent = 0;

            // Clear the selection and reset the cursor position
            rtbTexEditor.SelectionLength = 0;
            rtbTexEditor.SelectionStart = start;

            // Clear formatting toggles for buttons (if applicable)
            ToggleButtonColor(btnBold, false);
            ToggleButtonColor(btnItalic, false);
            ToggleButtonColor(btnUnderline, false);
        }

        private void btnBold_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(btnBold, "Bold");
        }

        private void btnItalic_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(btnItalic, "Italic");
        }

        private void btnUnderline_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(btnUnderline, "Underline");
        }

        private void btnParagraphAlignment_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(btnParagraphAlignment, "Paragraph Alignment");

        }

        private void btnTextColor_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(btnTextColor, "Text Color");
        }

        private void btnTextBackColor_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(btnTextBackColor, "Text Highlight");
        }

        private void btnNumberingList_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(btnNumberingList, "Number List");
        }

        private void btnBulletList_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(btnBulletList, "Bullet List");
        }

        private void btnClearTextFormat_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(btnClearTextFormat, "Clear Format");
        }

        private void btnUndo_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(btnUndo, "Undo");
        }

        private void btnRedo_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(btnRedo, "Redo");
        }
    }
}
