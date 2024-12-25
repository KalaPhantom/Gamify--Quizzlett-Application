using Quizlett_Prototype.Additional_Forms.Functions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gamify__Quizzlett_Application.Additional_Forms
{
    public partial class Multiple_Choice : UserControl
    {


        #region Object Properties

        public string question
        {
            get { return Question_txbx.Text; }
            set { Question_txbx.Text = value; }
        }

        public string correct_answer { get; set; }

        public string[] answer_multiple { get; set; }

        public bool isAnswerCorrect { get; set; }

        private char c_ans;


        #endregion

        #region Object Reference

        QuestionModel_MultipleChoice model;
        FlowLayoutPanel card_container;
        Quiz_Data_Model quiz; 
        #endregion


        public Multiple_Choice(QuestionModel_MultipleChoice model, FlowLayoutPanel card_container, Quiz_Data_Model quiz)
        {
            InitializeComponent();


            // instance the object 
            this.model = model;
            this.quiz = quiz;

            // Initialize all data here
            this.question = model.Question;
            this.correct_answer = model.correct_Answer;
            this.answer_multiple = model.choices_Collection;
            this.card_container = card_container;   

            // Intialize Options on buttons
            Option_A_btn.Text = answer_multiple[0];
            Option_B_btn.Text = answer_multiple[1];
            Option_C_btn.Text = answer_multiple[2];
            Option_D_btn.Text = answer_multiple[3];
            this.card_container = card_container;   
        }


        #region Button Click Events

        /// <summary>
        /// These button click events below uses a ternary operators (shorthand -if-else statements)
        /// to assign values such as booleans and back colors of the button controls
        /// </summary>


        // Option A
        private void Option_A_btn_Click(object sender, EventArgs e)
        {

            isAnswerCorrect = Option_A_btn.Text == correct_answer ? true : false;
            c_ans = 'A';
            UpdateScore();
            Updatecontrols();
        }

        // Option B 
        private void Option_B_btn_Click(object sender, EventArgs e)
        {
            isAnswerCorrect = Option_B_btn.Text == correct_answer ? true : false;
            c_ans = 'B';
            UpdateScore();
            Updatecontrols();
        }

        // Option C
        private void Option_C_btn_Click(object sender, EventArgs e)
        {
            isAnswerCorrect = Option_C_btn.Text == correct_answer ? true : false;
            c_ans = 'C';
            UpdateScore();
            Updatecontrols();
        }

        // Option D 
        private void Option_D_btn_Click(object sender, EventArgs e)
        {
            isAnswerCorrect = Option_D_btn.Text == correct_answer ? true : false;
            c_ans = 'D';
            UpdateScore();
            Updatecontrols();
        }


        /// <summary>
        /// This method will disable all buttons when the player chooses an answer
        /// </summary>

        private void Updatecontrols() { 
            Option_A_btn.Enabled = false;
            Option_B_btn.Enabled = false;
            Option_C_btn.Enabled = false;
            Option_D_btn.Enabled = false;

            // Update back colors (Overwrite)
            Option_A_btn.BackColor = Option_A_btn.Text == correct_answer ? Color.Blue : Color.Red;
            Option_B_btn.BackColor = Option_B_btn.Text == correct_answer ? Color.Blue : Color.Red;
            Option_C_btn.BackColor = Option_C_btn.Text == correct_answer ? Color.Blue : Color.Red;
            Option_D_btn.BackColor = Option_D_btn.Text == correct_answer ? Color.Blue : Color.Red;

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
        private void UpdateSelected_color() {

            switch (c_ans) {
                case 'A':
                    
                    Option_A_btn.BackColor = Option_A_btn.Text == correct_answer ? Color.Blue : Color.Orange;
                    break;

                case 'B':
                   
                    Option_B_btn.BackColor = Option_B_btn.Text == correct_answer ? Color.Blue : Color.Orange;
                    break;

                case 'C':
                   
                    Option_C_btn.BackColor = Option_C_btn.Text == correct_answer ? Color.Blue : Color.Orange;
                    break;

                case 'D':
                    
                    Option_D_btn.BackColor = Option_D_btn.Text == correct_answer ? Color.Blue : Color.Orange;
                    break;

            }

        }

        // Update score 

        private void UpdateScore() {
            if (isAnswerCorrect == true) {
                quiz.score++;
            }
        }




        #endregion


        #region Next or skip button Event
        private void nextOrSkip_button_Click(object sender, EventArgs e)
        {

            card_container.Controls.Remove(this);
            Dispose();
        }

        #endregion
    }
}
