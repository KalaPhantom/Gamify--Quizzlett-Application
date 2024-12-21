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




        #endregion

        #region Object Reference
        QuestionModel_MultipleChoice model;
        #endregion


        public Multiple_Choice(QuestionModel_MultipleChoice model)
        {
            InitializeComponent();


            // instance the object 
            this.model = model; 

            // Initialize all data here
            this.question = model.Question;
            this.correct_answer = model.correct_Answer;
            this.answer_multiple = model.choices_Collection;
            




            // Intialize Options on buttons
            Option_A_btn.Text = answer_multiple[0];
            Option_B_btn.Text = answer_multiple[1];
            Option_C_btn.Text = answer_multiple[2];
            Option_D_btn.Text = answer_multiple[3];




        }


        #region Button Click Events

        // Option A
        private void Option_A_btn_Click(object sender, EventArgs e)
        {
            // Ternary
            isAnswerCorrect = Option_A_btn.Text == correct_answer? true : false; 
            Option_A_btn.BackColor = Option_A_btn.Text == correct_answer? Color.Blue : Color.Red;
            Option_A_btn.Enabled = false;
        }

        // Option B 
        private void Option_B_btn_Click(object sender, EventArgs e)
        {
            isAnswerCorrect = Option_B_btn.Text == correct_answer ? true : false;
            Option_B_btn.BackColor = Option_B_btn.Text == correct_answer ? Color.Blue : Color.Red;
            Option_B_btn.Enabled = false;
        }

        // Option C
        private void Option_C_btn_Click(object sender, EventArgs e)
        {
            isAnswerCorrect = Option_C_btn.Text == correct_answer ? true : false;
            Option_C_btn.BackColor = Option_C_btn.Text == correct_answer ? Color.Blue : Color.Red;
            Option_C_btn.Enabled = false;
        }

        // Option D 
        private void Option_D_btn_Click(object sender, EventArgs e)
        {
            isAnswerCorrect = Option_D_btn.Text == correct_answer ? true : false;
            Option_D_btn.BackColor = Option_D_btn.Text == correct_answer ? Color.Blue : Color.Red;
            Option_D_btn.Enabled = false;
        }
        #endregion

        
    }
}
