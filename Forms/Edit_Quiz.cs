using Gamify__Quizzlett_Application.Additional_Forms.Functions;
using Gamify__Quizzlett_Application.User_Control.Quiz_cards;
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
    public partial class Edit_Quiz : Form
    {


        #region Properties

        public Bitmap? image
        {

            get { return (Bitmap)image_holder_pn.BackgroundImage; }
            set { image_holder_pn.BackgroundImage = (Bitmap)value; }

        }
        public string quiz_title
        { // Automaticially Sets the value on initialiazation 

            get { return quizName_txbx.Text; }
            set { quizName_txbx.Text = value; }

        }

        public string? subject
        { // Automaticially Sets the value on initialiazation 

            get { return subject_txbx.Text; }
            set { subject_txbx.Text = value; }
        }

        public bool isTimerEnabled { get; set; }

        #endregion

        #region Object reference
        Quiz_Data_Model quiz;
        Main_Menu menu;
        FlowLayoutPanel menu_panel;
        Quiz_Card_List card;
        #endregion


        public Edit_Quiz(Quiz_Data_Model quiz, Main_Menu menu, FlowLayoutPanel menu_panel, Quiz_Card_List card)
        {
            InitializeComponent();

            // pass data to the local reference from contructor's argument
            this.quiz = quiz;
            this.menu = menu;
            this.menu_panel = menu_panel;
            this.card = card;
            this.isTimerEnabled = quiz.isTimerEnabled;

            // pass references from the arguments to the local properties
            quiz_title = quiz.quiz_name;
            subject = quiz.Subject;

            try
            {
                this.image = (Bitmap)Image.FromFile(quiz.ImagePath);

            }
            catch (Exception ex)
            {
                //MessageBox.Show($"The image file from {quiz.ImagePath} has been moved to another path or deleted \n Please modify this on the menu");
                quiz.ImagePath = null;

            }

            if (image == null)
            {
                // Do nothing
                plus_icon.Visible = true;
            }
            else
            {
                plus_icon.Visible = false;
            }

            updateTimer_attributes();   // Call to serve as a label constructor

            //Call the color arch
            ColorSchematics.ColorArch(highlight1, image_holder_pn, background1);

        }


        #region On Return 
        private void return_btn_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }
        #endregion

        #region Clear Image button event 
        private void clearImg_btn_Click(object sender, EventArgs e)
        {
            image = null;
            quiz.ImagePath = null; 
            plus_icon.Visible = true;
        }
        #endregion

        #region Navigation on timer boolean Operation
        private void timer_L_btn_Click(object sender, EventArgs e)
        {
            isTimerEnabled = (isTimerEnabled == false) ? true : false;
            quiz.isTimerEnabled = isTimerEnabled;
            updateTimer_attributes();
        }

        private void timer_R_btn_Click(object sender, EventArgs e)
        {
            isTimerEnabled = (isTimerEnabled == false) ? true : false;
            quiz.isTimerEnabled = isTimerEnabled;
            updateTimer_attributes();
        }


        public void updateTimer_attributes()
        {
            if (isTimerEnabled == true)
            {
                timer_lbl.Text = "True";
            }
            else
            {
                timer_lbl.Text = "False";
            }
        }


        #endregion

        #region Drag and Drop Event
        private void image_holder_pn_DragDrop(object sender, DragEventArgs e)
        {
            // Get the file(s) from the drag event
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

            // Load the first valid image file into the PictureBox
            if (files.Length > 0 && IsImageFile(files[0]))
            {
                image_holder_pn.BackgroundImage = Image.FromFile(files[0]);
                image = (Bitmap)image_holder_pn.BackgroundImage; // pass am image
                quiz.ImagePath = files[0];
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



        #region On Proceed 
        // Local Instance
        Edit_Question editQuestion;
        private void create_btn_Click(object sender, EventArgs e)
        {

            editQuestion = new Edit_Question(this, quiz, menu_panel, menu, this.card);
            editQuestion.MdiParent = menu;
            editQuestion.FormClosed += EditQuestion_FormClosed;
            editQuestion.Dock = DockStyle.Fill;
            editQuestion.Show();


        }

        // Explicitely call the Dispose method to clean up memory
        private void EditQuestion_FormClosed(object? sender, FormClosedEventArgs e)
        {
            editQuestion.Dispose();
        }
        #endregion


        #region Modify name and subject of the parent object - Quiz
        private void quizName_txbx_TextChanged(object sender, EventArgs e)
        {
            quiz.quiz_name = quizName_txbx.Text;
        }

        private void subject_txbx_TextChanged(object sender, EventArgs e)
        {
            quiz.Subject = subject_txbx.Text;   
        }
        #endregion
    }
}
