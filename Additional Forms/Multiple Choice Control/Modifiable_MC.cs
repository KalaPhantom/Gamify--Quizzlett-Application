using DocumentFormat.OpenXml.Packaging;
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

namespace Gamify__Quizzlett_Application.Additional_Forms.Multiple_Choice_Control
{
    public partial class Modifiable_MC : UserControl
    {

        #region Properties
        public string question { get; set; }
        public string? correct_answer { get; set; }
        public int question_number { get; set; }

        public string[]? answers = new string[4]; // answer container
      


        public Bitmap image {

            get { return (Bitmap)panel_image_pn.BackgroundImage; }
            set { panel_image_pn.BackgroundImage = (Bitmap)value; }
        
        }
        public string  image_path {get; set;}


        #endregion


        public Modifiable_MC(int count)
        {
            // Intialize basic componanents and starting attributes
            InitializeComponent();
            question_number = count;
            count_lbl.Text = count.ToString();
            update_correct_Selection();

            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();

            // Call the color Arch for custom modification
            ColorSchematics.ColorArch(highlight_1,this);

        }


        QuestionModel_MultipleChoice MC; 
        public Modifiable_MC(int count, QuestionModel_MultipleChoice MC)
        {

            InitializeComponent();
            question_number = count;
            count_lbl.Text = count.ToString();
            update_correct_Selection();

            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();

            // Pass the local reference 
            this.MC = MC;

            InitializeComponent_Secondary(); 

        }

        #region
        private void InitializeComponent_Secondary() {

            // Load Instances from the local instances
            Opt_A_txbx.Text = MC.choices_Collection[0];
            Opt_B_txbx.Text = MC.choices_Collection[1];
            Opt_C_txbx.Text = MC.choices_Collection[2];
            Opt_D_txbx.Text = MC.choices_Collection[3];


            try {
                // Load image from files and cast it onto bitmap
                image = (Bitmap)Image.FromFile(MC.ImagePath);
                panel_image_pn.BackgroundImageLayout = ImageLayout.Stretch;

            }
            catch(Exception ex) { 
            
                // Do nothing 
            }
           

            Question_holder_txbx.Text = MC.Question;
            update_correct_Selection();

        }
        #endregion


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
            if (e.Data.GetData(DataFormats.FileDrop) is string[] files && files.Length > 0)
            {
                string filePath = files[0];
                try
                {
                    panel_image_pn.BackgroundImage = Image.FromFile(files[0]);
                    //image = (Bitmap)panel_image_pn.BackgroundImage; // pass am image
                    panel_image_pn.BackgroundImageLayout = ImageLayout.Stretch;
                    image_path = filePath;

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading image: {ex.Message} -- Invalid File format", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }




          
        }

        private void panel_image_pn_DragEnter(object sender, DragEventArgs e)
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
        #endregion

        private void delete_card_btn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
