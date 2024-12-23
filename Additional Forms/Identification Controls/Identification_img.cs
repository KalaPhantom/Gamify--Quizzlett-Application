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
    public partial class Identification_img : UserControl
    {

        #region Object references
        /// <summary>
        ///  @Object References
        ///  
        /// 'card_container' is being use to control the pressence of this control in a particular flowl layout panel
        /// 'quiz' is being used in this instance to update the scores in the base class (Quiz data model)
        /// 'model' is being used as sender arguments - to load every instance of the Question Model in the existing container
        /// </summary>
        /// 
        FlowLayoutPanel card_container;
        Quiz_Data_Model quiz;
        QuestionModel_Identification model;
        #endregion

        #region Local properties
        public string Question
        {
            get { return question_txbx.Text; }
            set { question_txbx.Text = value; }
        }
        public string correctAnswer { get; set; }
        public string user_answer { get; set; }
        public int question_count { get; set; }
        public bool isAnswerCorrect { get; set; }

        public Image? image {
            get { return image_panel.BackgroundImage; }
            set { image_panel.BackgroundImage = value; }
        }

        #endregion

        public Identification_img(FlowLayoutPanel card_container, Quiz_Data_Model quiz, QuestionModel_Identification model)
        {
            InitializeComponent();

            // Copy all attributes to the local object references
            this.card_container = card_container;
            this.quiz = quiz;
            this.model = model;

            // pass all model data in the local properties
            this.Question = model.Question;
            this.correctAnswer = model.correct_Answer;
            this.question_count = model.question_number;
            this.image = model.image;


            // Update number display
            question_number_lbl.Text = question_count.ToString();
        }

        private void skipOrNext_btn_Click(object sender, EventArgs e)
        {
            // Remove and Dispose the object from the panel
            card_container.Controls.Remove(this);
            Dispose();
        }

        private void answer_txbx_TextChanged(object sender, EventArgs e)
        {
            this.user_answer = answer_txbx.Text;
        }

        private void submit_btn_Click(object sender, EventArgs e)
        {
            // try-catch statement to negate an unnecessary argument when the user enters a null value
            try
            {

                if ((user_answer = user_answer == null ? "" : user_answer.ToLower()) == (correctAnswer = correctAnswer == null ? "" : correctAnswer.ToLower()))
                {
                    isAnswerCorrect = true;
                }
                else
                {
                    isAnswerCorrect = false;
                }

            }
            catch (NullReferenceException a)
            {

                // Do nothing
            }

            ValidateAnswer(); 
        }


        private void ValidateAnswer()
        {

            if (isAnswerCorrect == true)
            {
                quiz.score++;
                onCorrect();

            }
            else
            {
                onWrong();

            }

            // Change the button text of the "skip button"
            skipOrNext_btn.Text = "Next";

        }

        // Update Control Properties when the answer is wrong
        private void onWrong()
        {

            // Change the message
            hidden_msg_lbl.Text = "Oopss.... You got that wrong";
            hidden_ans_lbl.Visible = true;
            hidden_ans_lbl.Text = correctAnswer + " is the correct answer...";

            // Change the back color of the answer textbox color
            answer_txbx.BackColor = Color.Red;

            // Update control accessibility to the user 
            answer_txbx.Enabled = false;
            submit_btn.Enabled = false;
            submit_btn.Visible = false;

        }

        // Update Control Properties when the answer is correct
        private void onCorrect()
        {

            // Change the message....
            hidden_msg_lbl.Text = "Correct";

            // Change the back color of the answer textbox
            answer_txbx.BackColor = Color.Green;

            // Update control accessibility to the user 
            answer_txbx.Enabled = false;
            submit_btn.Enabled = false;
            submit_btn.Visible = false;

        }
    }
}
