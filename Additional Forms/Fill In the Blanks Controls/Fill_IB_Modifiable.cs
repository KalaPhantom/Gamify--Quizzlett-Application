using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gamify__Quizzlett_Application.Additional_Forms.Fill_In_the_Blanks_Controls
{
    public partial class Fill_IB_Modifiable : UserControl
    {


        #region Public properties
        public string question { get; set; }
        public string correct_answer { get; set; }
        public int question_count
        {
            get { return int.Parse(count_lbl.Text); }
            set { count_lbl.Text = value.ToString(); }

        }
        public Bitmap? image { get; set; }

        #endregion





        public Fill_IB_Modifiable(int count)
        {
            InitializeComponent();

            // pass properties from arguments
            question_count = count;

        }


        #region Text Change event
        private void questionHolder_txbx_TextChanged(object sender, EventArgs e)
        {
            question = questionHolder_txbx.Text;
        }

        private void answerHolder_txbx_TextChanged(object sender, EventArgs e)
        {
            correct_answer = answerHolder_txbx.Text;
        }
        #endregion


        #region Image drag and drop event
        private void image_panel_DragDrop(object sender, DragEventArgs e)
        {
            // Get the file(s) from the drag event
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

            // Load the first valid image file into the PictureBox
            if (files.Length > 0 && IsImageFile(files[0]))
            {
                image_panel.BackgroundImage = Image.FromFile(files[0]);
                image = (Bitmap)image_panel.BackgroundImage; // pass am image
                image_panel.BackgroundImageLayout = ImageLayout.Stretch; // Change the layout

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
