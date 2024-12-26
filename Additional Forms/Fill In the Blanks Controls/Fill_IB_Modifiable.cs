using Gamify__Quizzlett_Application.Additional_Forms.Functions;
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
        public string image_path { get; set; }

        #endregion


        public Fill_IB_Modifiable(int count)
        {
            InitializeComponent();

            // pass properties from arguments
            question_count = count;
            ColorSchematics.ColorArch(highlight_1, this);

        }

        QuestionModel_FillBlanks FB;
        public Fill_IB_Modifiable(int count, QuestionModel_FillBlanks FB)
        {

            InitializeComponent();
            question_count = count;
            count_lbl.Text = count.ToString();
     

            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();

            // Pass the local reference 
            this.FB = FB;

            InitializeComponent_Secondary();

            // Call the color arch
            ColorSchematics.ColorArch(highlight_1, this);

        }

        #region
        private void InitializeComponent_Secondary()
        {

            // Load Instances from the local instances
            // Load image from files and cast it onto bitmap

            try
            {

                image = (Bitmap)Image.FromFile(FB.ImagePath);
                image_panel.BackgroundImageLayout = ImageLayout.Stretch;
            }
            catch (Exception ex) { 
               
                // Do nothing
            
            }
          

            questionHolder_txbx.Text = FB.Question;
            answerHolder_txbx.Text = FB.correct_Answer;
          

        }
        #endregion

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
            if (e.Data.GetData(DataFormats.FileDrop) is string[] files && files.Length > 0)
            {
                string filePath = files[0];
                try
                {
                    image_panel.BackgroundImage = Image.FromFile(files[0]);
                    //image = (Bitmap)image_panel.BackgroundImage; // pass am image
                    image_panel.BackgroundImageLayout = ImageLayout.Stretch; // Change the layout
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


        #region delete Button event
        private void delete_card_btn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        #endregion
    }
}
