using Gamify__Quizzlett_Application.Additional_Forms.Functions;
using Org.BouncyCastle.Asn1.Mozilla;
using Quizlett_Prototype.Additional_Forms.Functions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gamify__Quizzlett_Application.Additional_Forms.Identification_Controls
{
    public partial class Modifiable_Identification : UserControl
    {

        #region Object Properties

        public string correctAnswer { get; set; }
        public string Question { get; set; }

        public int question_number
        {
            get { return int.Parse(count_lbl.Text); }
            set { count_lbl.Text = value.ToString(); }
        }
        public Bitmap? image // Can be null
        {
            get { return (Bitmap)image_panel.BackgroundImage; }
            set { image_panel.BackgroundImage = (Bitmap)value; }
        
        } 
        public string image_path { get; set; }
        #endregion


        public Modifiable_Identification(int count)
        {
            InitializeComponent();

            // pass the reference 
            question_number = count;

            // Color Arch Call
            ColorSchematics.ColorArch(highlight_1, this);
        }

        QuestionModel_Identification ID;
        public Modifiable_Identification(int count, QuestionModel_Identification ID)
        {

            InitializeComponent();
            question_number = count;
            count_lbl.Text = count.ToString();


            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();

            // Pass the local reference 
            this.ID = ID;

            InitializeComponent_Secondary();

            // Color Arch Call
            ColorSchematics.ColorArch(highlight_1, this);

        }

        #region
        private void InitializeComponent_Secondary()
        {

            // Load Instances from the local instances
            // Load image from files and cast it onto bitmap
            
            // try catch to negate a null exception when a Question model does not contain any image
            try
            {

                image = (Bitmap)Image.FromFile(ID.ImagePath);
                image_panel.BackgroundImageLayout = ImageLayout.Stretch;
            }
            catch (Exception ex) { 
            
                // Do nothing
            }
            

            questionHolder_txbx.Text = ID.Question;
            answerHolder_txbx.Text = ID.correct_Answer;

        }

        #endregion

        #region On user input
        /// <summary>
        ///  Updates the object properties
        ///     : Correct answer and Question
        ///     
        ///  Note:
        ///      : The correct answer is parsed in to Lower Cases
        /// </summary>

        private void questionHolder_txbx_TextChanged(object sender, EventArgs e)
        {
            Question = questionHolder_txbx.Text;
        }

        private void answerHolder_txbx_TextChanged(object sender, EventArgs e)
        {
            // Avoid having string mismatch by comparing both strings (correct answer and the user answer) into both lower cases
            correctAnswer = answerHolder_txbx.Text.ToLower();
        }

        #endregion

        #region Drag and DropEvents 
        private void image_panel_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetData(DataFormats.FileDrop) is string[] files && files.Length > 0) 
            {
                string filePath = files[0];
                try
                {
                    image_panel.BackgroundImage = Image.FromFile(files[0]);
                    //image = (Bitmap)image_panel.BackgroundImage; // pass am image
                    image_panel.BackgroundImageLayout = ImageLayout.Stretch;
                    image_path = filePath;

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading image: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


        }

        private void image_panel_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private bool IsImageFile(string filePath)
        {
            try
            {
                using (Image img = Image.FromFile(filePath))
                {
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }




        #endregion


        #region Delete Button event
        private void delete_card_btn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        #endregion
    }
}
