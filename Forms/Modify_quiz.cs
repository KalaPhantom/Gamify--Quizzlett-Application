using Gamify__Quizzlett_Application.Additional_Forms.Multiple_Choice_Control;
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
    public partial class Modify_Quiz_form : Form
    {

        private int q_count = 1; // question count 

        // Properties -- as nullable
        // Most of the properties is set as nullable as the may contain values of a null type
        private string? type;
        private string? quizName;
        private string? quizDescription; // unused
        private Image? image;

        #region Class reference
        Create_Quiz base_instance; // Previous class instnace 
        Quiz_Data_Model quiz; // base data model
        #endregion


        public Modify_Quiz_form(Create_Quiz base_instance, Quiz_Data_Model? quiz)
        {
            InitializeComponent();



            // copy the attributes on create
            this.base_instance = base_instance;
            this.quiz = quiz;

            // copy attributes in this instance 
            this.type = quiz?.type;
            this.quizName = quiz?.quiz_name;
            this.image = quiz?.imageProfile;


            // Switch case for initializing the modifiable interfaces
            switch (quiz?.type)
            {

                case "MC":

                    // Create the instance of the interface
                    Modifiable_MC mod = new Modifiable_MC(q_count);
                    card_panel.Controls.Add(mod);
                    q_count++;
                    
                    break;

                case "ID":
                    break;

                case "FB":
                    break;

                default: // if the value is null

                    break;

            }

            // Update on-form displays
            name_lbl_display.Text = "Quiz Name: " +  quiz.quiz_name;


        }


        // Close the current instance of the active window
        private void return_btn_Click(object sender, EventArgs e)
        {
            this.Close();
            quiz = null;
         
        }


        #region Add button for adding new instance of an object
        private void Add_btn_Click(object sender, EventArgs e)
        {
            // Switch case for quiz type verification
            // This will be used interchangebly for the type of quiz model to be necessarily used in various instances
            // this will be mainly used in creating another instances of an object in the flowlayout panel
            switch (type)
            {
                case "MC":
                    Modifiable_MC mod = new Modifiable_MC(q_count);
                    card_panel.Controls.Add(mod);
                    q_count++;
                    
                    break;

                case "ID":
                    break;

                case "FB":
                    break;

                default: break;
            }


        }
        #endregion

        #region save and exit event
        private void SaveExit_btn_Click(object sender, EventArgs e)
        {
            // close the active form 
            save_all_question_model();
            this.Close();

           
        }

        private void save_all_question_model() {

           

            foreach (Modifiable_MC MC_Control in card_panel.Controls) {
                QuestionModel_MultipleChoice MC = new QuestionModel_MultipleChoice()
                {
                    Question = MC_Control.question,
                    correct_Answer = MC_Control.correct_answer,
                    question_number = MC_Control.question_number,
                    choices_Collection = MC_Control.answers

                };

                quiz.collection_Questions.AddLast(MC);

            }
        
        
        }


        #endregion
    }
}
