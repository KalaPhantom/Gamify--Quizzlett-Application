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
    public partial class Multiple_choice_img : UserControl
    {

        #region Object Reference
        QuestionModel_MultipleChoice model;
        FlowLayoutPanel card_container;
        Quiz_Data_Model quiz;
        #endregion

        #region Local Properties
        public string question
        {
            get { return question_holder_txbx.Text; }
            set { question_holder_txbx.Text = value; }
        }

        public string correct_answer { get; set; }

        public string[] answer_multiple { get; set; }

        public bool isAnswerCorrect { get; set; }

        public Image image {
            get { return image_holder_pnl.BackgroundImage; }
            set { image_holder_pnl.BackgroundImage = value; }
        
        }    

        private char c_ans;
        #endregion

        public Multiple_choice_img(QuestionModel_MultipleChoice model, FlowLayoutPanel card_container, Quiz_Data_Model quiz)
        {
            InitializeComponent();


            // Pass all data from the arguments to the local object references
            this.model = model;
            this.card_container = card_container;
            this.quiz = quiz;

            // Initialize all properties from the arguments
            // Initialize all data here
            this.question = model.Question;
            this.correct_answer = model.correct_Answer;
            this.answer_multiple = model.choices_Collection;
            this.card_container = card_container;
            this.image = model.image;

            // Intialize Options on buttons
            option_A_btn.Text = answer_multiple[0];
            option_B_btn.Text = answer_multiple[1];
            option_C_btn.Text = answer_multiple[2];
            option_D_btn.Text = answer_multiple[3];
            this.card_container = card_container;


        }


        #region On Button Clicks in Choices button events
        private void option_A_btn_Click(object sender, EventArgs e)
        {
            isAnswerCorrect = option_A_btn.Text == correct_answer ? true : false;
            c_ans = 'A';
            UpdateScore();
            Updatecontrols();
        }

        private void option_B_btn_Click(object sender, EventArgs e)
        {
            isAnswerCorrect = option_B_btn.Text == correct_answer ? true : false;
            c_ans = 'B';
            UpdateScore();
            Updatecontrols();
        }

        private void option_C_btn_Click(object sender, EventArgs e)
        {
            isAnswerCorrect = option_C_btn.Text == correct_answer ? true : false;
            c_ans = 'C';
            UpdateScore();
            Updatecontrols();
        }

        private void option_D_btn_Click(object sender, EventArgs e)
        {
            isAnswerCorrect = option_D_btn.Text == correct_answer ? true : false;
            c_ans = 'D';
            UpdateScore();
            Updatecontrols();
        }


        /// <summary>
        /// This method will disable all buttons when the player chooses an answer
        /// </summary>

        private void Updatecontrols()
        {
            option_A_btn.Enabled = false;
            option_B_btn.Enabled = false;
            option_C_btn.Enabled = false;
            option_D_btn.Enabled = false;

            // Update back colors (Overwrite)
            option_A_btn.BackColor = option_A_btn.Text == correct_answer ? Color.Blue : Color.Red;
            option_B_btn.BackColor = option_B_btn.Text == correct_answer ? Color.Blue : Color.Red;
            option_C_btn.BackColor = option_C_btn.Text == correct_answer ? Color.Blue : Color.Red;
            option_D_btn.BackColor = option_D_btn.Text == correct_answer ? Color.Blue : Color.Red;

            // Override all exisitng controls
            UpdateSelected_color();

            nextOrSkip_button.Text = "Next";

        }

        /// <summary>
        /// This method below will override all existing colors in the button
        /// Orange color will indicates that the chosen answer of the player is incorrect
        /// Green color will indicates that the chosen answer by the player is correct
        /// Red buttons will represents all incorrect answers
        /// 
        ///   Note: Since the program allows the player to enter null strings in the modifiable_MC form 
        ///   - An input validator must be implemented
        /// </summary>
        private void UpdateSelected_color()
        {

            switch (c_ans)
            {
                case 'A':

                    option_A_btn.BackColor = option_A_btn.Text == correct_answer ? Color.Blue : Color.Orange;
                    break;

                case 'B':

                    option_B_btn.BackColor = option_B_btn.Text == correct_answer ? Color.Blue : Color.Orange;
                    break;

                case 'C':

                    option_C_btn.BackColor = option_C_btn.Text == correct_answer ? Color.Blue : Color.Orange;
                    break;

                case 'D':

                    option_D_btn.BackColor = option_D_btn.Text == correct_answer ? Color.Blue : Color.Orange;
                    break;

            }

        }

        // Update score 

        private void UpdateScore()
        {
            if (isAnswerCorrect == true)
            {
                quiz.score++;
            }
        }

        #endregion



        #region next or skip button event
        /// <summary>
        /// Remove and call the IDisposable Constructor to free memory when an object is no longer used
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nextOrSkip_button_Click(object sender, EventArgs e)
        {
            card_container.Controls.Remove(this);
            Dispose(); // Clean the object
        }
        #endregion
    }
}
