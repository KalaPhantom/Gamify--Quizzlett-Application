using Microsoft.VisualBasic;
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


namespace Gamify__Quizzlett_Application.Forms
{
    public partial class Create_Quiz : Form
    {

        // Object instance from the main menu
        Main_Menu menu;
        FlowLayoutPanel menu_panel;

        // New instance of the linked object
        Modify_Quiz_form modify_form;

        public string quizMode { get; set; }
        public bool isTimerenabled { get; set; }
        public bool showAnswer { get; set; }
        public Image? image { get; set; }



        public Create_Quiz(Main_Menu menu, FlowLayoutPanel menu_panel)
        {

            InitializeComponent();
            mode_indexUpdate();

            // set the allow drop property of a panel



            // Pass an object reference on the local properties
            this.menu = menu;
            this.menu_panel = menu_panel;

            // Set constructors in the local properties
            // TODO NOTE: Fix this code below as it may cause some logical errors later on the project
            isTimerenabled = false;
            timer_lbl.Text = "false";
            showAnswer = false;
            showAnswer_lbl.Text = "false";


        }

        #region Return
        private void return_btn_Click(object sender, EventArgs e)
        {
            // TODOD: Implement a destructor to add optimization
            this.Close();
        }
        #endregion


        #region Hover events in the properties
        // Hover event for property info display
        private void inv_groupBox_MouseHover(object sender, EventArgs e)
        {
            property_txbx.Text = "Drag and Drop image here or select an image file";
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            property_txbx.Text = "Drag and Drop image here or select an image file";
        }
        #endregion


        #region Mode Navigation Pane
        /// <summary>
        /// this section acts as a navigation pane that updates idndexes
        /// and interprets indexes to desired action 
        /// 
        /// for current instance:
        /// 
        /// 1 = multiple choice (default)
        /// 2 = identification
        /// 3 = fill in the blanks
        /// 
        /// </summary>

        // Counter for index representation
        public int ModeCount = 1;

        private void mode_arrL_Click(object sender, EventArgs e)
        {

            ModeCount = (ModeCount == 1) ? 3 : ModeCount - 1;
            mode_indexUpdate();

        }

        private void mode_arrR_Click(object sender, EventArgs e)
        {

            ModeCount = ModeCount == 3 ? 1 : ModeCount + 1;
            mode_indexUpdate();

        }

        public void mode_indexUpdate()
        {
            switch (ModeCount)
            {
                case 1:
                    quizMode = "MC"; // Multiple Choice (Mode)
                    mode_lbl.Text = "Multiple Choice";

                    break;
                case 2:
                    quizMode = "ID"; // Identification (Mode);
                    mode_lbl.Text = "Identification";
                    break;
                case 3:
                    quizMode = "FB"; // Fill in the blanks (Mode);
                    mode_lbl.Text = "Fill in the Blanks";


                    break;
                default:
                    throw new Exception();


            }

        }
        #endregion


        #region timer switch on navigation

        /// <summary>
        /// all code blocks under this region serves as a swithcer betwwen time modes
        /// A quiz pannel could be timed 
        /// 
        /// parameters;
        /// 
        /// 1 = true
        /// 2 = false
        /// </summary>
        /// 



        private void timer_L_btn_Click(object sender, EventArgs e)
        {
            isTimerenabled = (isTimerenabled == false) ? true : false;

            updateTimer_attributes();
        }

        private void timer_R_btn_Click(object sender, EventArgs e)
        {
            isTimerenabled = (isTimerenabled == false) ? true : false;

            updateTimer_attributes();
        }

        public void updateTimer_attributes()
        {
            if (isTimerenabled == true)
            {
                timer_lbl.Text = "True";
            }
            else
            {
                timer_lbl.Text = "False";
            }
        }



        #endregion

        #region Show Answer navigation on modes

        /// <summary>
        /// The purpose of all code blocks under this region is to navigate through all boolean modees
        /// </summary>

        private void showAnswer_R_btn_Click(object sender, EventArgs e)
        {
            showAnswer = showAnswer == true ? false : true;
            updateShowAnswer_attributes();
        }

        private void showAnswer_L_btn_Click(object sender, EventArgs e)
        {
            showAnswer = showAnswer == true ? false : true;
            updateShowAnswer_attributes();
        }

        public void updateShowAnswer_attributes()
        {
            if (showAnswer == true)
            {
                showAnswer_lbl.Text = "True";
            }
            else
            {
                showAnswer_lbl.Text = "False";
            }
        }


        #endregion


        #region create event
        public void create_btn_Click(object sender, EventArgs e)
        {

            validate_data();
            initializeObject();


        }

        private void Modify_form_FormClosed(object? sender, FormClosedEventArgs e)
        {
            // destroy the instance of the object
            modify_form = null;
        }


        /// <summary>
        /// validate_data()
        /// 
        /// validates if the all the strings came from texboxes are empty
        /// assigns new values
        /// </summary>
        private void validate_data()
        {



            if (string.IsNullOrEmpty(quizName_txbx.Text))
            {
                quizName_txbx.Text = "Untitled Quiz";
            }

            if (string.IsNullOrEmpty(subject_txbx.Text))
            {
                subject_txbx.Text = "Not set";
            }

        }

        // initialize objects base on the mode assignments
        private void initializeObject()
        {

            // Create instance of the quiz object 
            Quiz_Data_Model? quiz = new Quiz_Data_Model()
            {
                quiz_name = this.quizName_txbx.Text,
                Subject = this.subject_txbx.Text,
                type = this.quizMode,
                imageProfile = this.image

            };

            // Create instance of the new form "Modify form"
            // Pass the existing instance of the MDI parent form 
            modify_form = new Modify_Quiz_form(this, quiz, menu_panel, menu);
            modify_form.MdiParent = this.MdiParent;
            modify_form.FormClosed += Modify_form_FormClosed;
            modify_form.Show();
            modify_form.Dock = DockStyle.Fill;


        }

        #endregion

        #region image drag and drop event
        private void image_holder_pn_DragDrop(object sender, DragEventArgs e)
        {
            // Get the file(s) from the drag event
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

            // Load the first valid image file into the PictureBox
            if (files.Length > 0 && IsImageFile(files[0]))
            {
                image_holder_pn.BackgroundImage = Image.FromFile(files[0]);
                image = panel1.BackgroundImage; // pass am image
                plus_icon.Visible = false;


            }
        }
        

        private void image_holder_pn_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

                // Validate if the file is an image
                if (files.Length > 0 && IsImageFile(files[0]))
                {
                    e.Effect = DragDropEffects.Copy; // Allow drop
                    plus_icon.Visible = false;
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


        /// <summary>
        /// Check the image format
        /// </summary>
      
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
