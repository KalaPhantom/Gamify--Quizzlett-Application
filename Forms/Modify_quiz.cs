using Gamify__Quizzlett_Application.Additional_Forms.Identification_Controls;
using Gamify__Quizzlett_Application.Additional_Forms.Multiple_Choice_Control;
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
    public partial class Modify_Quiz_form : Form
    {

        private int q_count = 1; // question count 

        // Properties -- as nullable
        // Most of the properties is set as nullable as the may contain values of a null type
        private string? type;
        private string? quizName;
        private string? quizDescription; // unused
        private Image? image;
        private string? subject; 

        #region Class reference
        Create_Quiz base_instance; // Previous class instnace 
        Quiz_Data_Model? quiz; // base data model
        FlowLayoutPanel menu_panel;
        Main_Menu menu;
        #endregion


        public Modify_Quiz_form(Create_Quiz base_instance, Quiz_Data_Model? quiz, FlowLayoutPanel menu_panel, Main_Menu menu)
        {
            InitializeComponent();



            // copy the attributes on create
            this.base_instance = base_instance;
            this.quiz = quiz;
            this.menu_panel = menu_panel;
            this.menu = menu;

           

            // copy attributes in this instance 
            this.type = quiz?.type;
            this.quizName = quiz?.quiz_name;
            this.image = quiz?.imageProfile;
            this.subject = quiz?.Subject;


           InitializeModifiables();

            // Update on-form displays
            name_lbl_display.Text = "Quiz Name: " +  quiz?.quiz_name;


        }


        // Close the current instance of the active window
        private void return_btn_Click(object sender, EventArgs e)
        {
            this.Close();
            //quiz = null;
         
        }


        #region Add button for adding new instance of an object
        private void Add_btn_Click(object sender, EventArgs e)
        {
            
            InitializeModifiables();


        }
        #endregion

        #region Initialize

        private void InitializeModifiables() {
            // Switch case for quiz type verification
            // This will be used interchangebly for the type of quiz model to be necessarily used in various instances
            // this will be mainly used in creating another instances of an object in the flowlayout panel
            switch (type)
            {
                case "MC": // Initialize Multiple Choice
                    Modifiable_MC mod = new Modifiable_MC(q_count);
                    card_panel.Controls.Add(mod);
                    q_count++;
                    break;


                case "ID": // Initialize Identification
                    Modifiable_Identification mod_ID = new Modifiable_Identification(q_count);
                    card_panel.Controls.Add(mod_ID);
                    q_count++;
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

            // Add an interface to represent the new quiz instance
            base_instance.Close();
            this.Close();

           
        }


        /// <summary>
        /// Gather all instances of question models and parse in a link list collection
        /// </summary>
        private void save_all_question_model() {


            // TODO: Implement sorter using switch statement

            switch (type)
            {
                case "MC": // For multiple Choice
                    saveAll_MC(); 
                    break;


                case "ID": // For Identifications
                    saveAll_ID();
                    break;
                    

                case "FB":
                    break;

                default: break;
            }


           
           

            // Create an interface
            // Pass the quiz base instance
            Quiz_Card_List card = new Quiz_Card_List(quiz, menu) {

                quiz_name = quizName,
                quiz_subject = this.subject,
                quiz_type = this.type



            };

            // Add the controls
            menu_panel.Controls.Add(card);





        }
        #endregion


        #region Save Itterator instance

        private void saveAll_MC() {
            // The use of itterator to gather all instances of controls in the flow layout panel (card_panel)
            // And pass all properties of all instances in the collection of question 'objects' in the base class
            foreach (Modifiable_MC MC_Control in card_panel.Controls)
            {
                QuestionModel MC = new QuestionModel_MultipleChoice()
                {
                    Question = MC_Control.question,
                    correct_Answer = MC_Control.correct_answer,
                    question_number = MC_Control.question_number,
                    choices_Collection = MC_Control.answers,
                    image = MC_Control.image,
                    

                };

                // Add all elements 
                quiz.collection_Questions.AddLast(MC);

            }

        }



        /// <summary>
        /// Save all instance of Identification modifiables
        /// copy all instance on the back-end
        /// </summary>
        private void saveAll_ID()
        {
            foreach (Modifiable_Identification MC_Control in card_panel.Controls)
            {
               
                

                validateDataProperties(MC_Control);
                QuestionModel MC = new QuestionModel_Identification()
                {
                    Question = MC_Control.Question,
                    correct_Answer = MC_Control.correctAnswer,
                    question_number = MC_Control.question_number,
                    image = MC_Control.image,

                    // TODO: Implement Images transfer 

                };

                // Add all elements 
                quiz.collection_Questions.AddLast(MC);

            }

        }

        


        private void saveAll_FB()
        {


        }

        // For Identification
        private void validateDataProperties(Modifiable_Identification MC_Control) { 
            
            MC_Control.Question = MC_Control.Question == null? "Oppsss. Looks like the creator of the quiz forget to add a question....": MC_Control.Question;
            MC_Control.correctAnswer = MC_Control.correctAnswer == null? " ": MC_Control.correctAnswer;

        }

        #endregion

    }
}
