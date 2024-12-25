using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gamify__Quizzlett_Application.Additional_Forms.Multiple_Choice_Control
{
    public partial class Modifiable_MC : UserControl
    {

        #region Properties
        public string question { get; set; }
        public string? correct_answer { get; set; }
        public int question_number { get; set; }

        public string[]? answers = new string[4]; // answer container

        public Bitmap image { get; set; }


        #endregion
        public Modifiable_MC(int count)
        {

            InitializeComponent();
            question_number = count;
            count_lbl.Text = count.ToString();
            update_correct_Selection();
        }


        #region Correct answer navigation 

        /// <summary>
        /// Code blocks under this region is meant serve as a navigation control back-ends
        /// </summary>
        /// 

        private int selected = 1;

        private void leftSelector_btn_Click(object sender, EventArgs e)
        {
            selected = selected == 1 ? 4 : selected - 1; // Ternary

            update_correct_Selection();

        }

        private void rightSelector_btn_Click(object sender, EventArgs e)
        {
            selected = selected == 4 ? 1 : selected + 1; // Ternary
            update_correct_Selection();
        }

        /// <summary>
        /// Updates all parameters after button navigation events
        /// </summary>
        private void update_correct_Selection()
        {
            switch (selected)
            {
                case 1:
                    correct_answer = answers?[0];
                    Selected.Text = "Option A";
                    break;
                case 2:
                    correct_answer = answers?[1];
                    Selected.Text = "Option B";
                    break;
                case 3:
                    correct_answer = answers?[2];
                    Selected.Text = "Option C";
                    break;
                case 4:
                    correct_answer = answers?[3];
                    Selected.Text = "Option D";
                    break;

                default:
                    correct_answer = answers?[1];
                    Selected.Text = "Option A";
                    break;

            }
        }
        #endregion


        #region Text Change events
        private void Opt_A_txbx_TextChanged(object sender, EventArgs e)
        {
            answers[0] = Opt_A_txbx.Text;
            update_correct_Selection();
        }

        private void Opt_B_txbx_TextChanged(object sender, EventArgs e)
        {
            answers[1] = Opt_B_txbx.Text;
            update_correct_Selection();
        }

        private void Opt_C_txbx_TextChanged(object sender, EventArgs e)
        {
            answers[2] = Opt_C_txbx.Text;
            update_correct_Selection();
        }

        private void Opt_D_txbx_TextChanged(object sender, EventArgs e)
        {
            answers[3] = Opt_D_txbx.Text;
            update_correct_Selection();
        }

        // Questions
        private void Question_holder_txbx_TextChanged(object sender, EventArgs e)
        {
            question = Question_holder_txbx.Text;
        }
        #endregion


        #region Image drag and drop event
        private void panel_image_pn_DragDrop(object sender, DragEventArgs e)
        {
            // Get the file(s) from the drag event
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

            // Load the first valid image file into the PictureBox
            if (files.Length > 0 && IsImageFile(files[0]))
            {
                panel_image_pn.BackgroundImage = Image.FromFile(files[0]);
                image = (Bitmap)panel_image_pn.BackgroundImage; // pass am image
                panel_image_pn.BackgroundImageLayout = ImageLayout.Stretch;
            }
}

        private void panel_image_pn_DragEnter(object sender, DragEventArgs e)
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
