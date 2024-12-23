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
        public Image? image { get; set; } // Can be null

        #endregion


        public Modifiable_Identification(int count)
        {
            InitializeComponent();

            // pass the reference 
            question_number = count;


        }


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
            // Get the file(s) from the drag event
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

            // Load the first valid image file into the PictureBox
            if (files.Length > 0 && IsImageFile(files[0]))
            {
                image_panel.BackgroundImage = Image.FromFile(files[0]);
                image = image_panel.BackgroundImage; // pass am image

            }
        }

        private void image_panel_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

                // Validate if the file is an image
                if (files.Length > 0 && IsImageFile(files[0]))
                {
                    e.Effect = DragDropEffects.Copy; // Allow drop
                }
                else
                {
                    e.Effect = DragDropEffects.None; // Deny drop
                }
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
    }
}
