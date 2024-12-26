using DocumentFormat.OpenXml.Drawing.Charts;
using Gamify__Quizzlett_Application.Additional_Forms.Fill_In_the_Blanks_Controls;
using Gamify__Quizzlett_Application.Additional_Forms.Functions;
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
    public partial class Edit_Question : Form
    {

        #region Object References
        Quiz_Data_Model quiz;
        Edit_Quiz base_instance;
        FlowLayoutPanel menu_panel;
        Main_Menu menu;
        Quiz_Card_List card;

        #endregion

        public Edit_Question(Edit_Quiz base_instance, Quiz_Data_Model? quiz, FlowLayoutPanel menu_panel, Main_Menu menu, Quiz_Card_List card)
        {
            InitializeComponent();

            // Pass all reference from the argument to the local instanced objects
            this.base_instance = base_instance;
            this.quiz = quiz;
            this.menu_panel = menu_panel;
            this.menu = menu;
            this.card = card;

            // Call the deserializer
            DesrializeQuestion();
            this.card = card;

            // Call color Arch
            ColorSchematics.ColorArch(top_panel);
        }


        #region Add button event
        private void Add_btn_Click(object sender, EventArgs e)
        {
            InitializeModifiables();
        }

        private void InitializeModifiables()
        {
            // Switch case for quiz type verification
            // This will be used interchangebly for the type of quiz model to be necessarily used in various instances
            // this will be mainly used in creating another instances of an object in the flowlayout panel
            switch (quiz.type)
            {
                case "MC": // Initialize Multiple Choice
                    Modifiable_MC mod = new Modifiable_MC(temp_count);
                    card_panel.Controls.Add(mod);
                    temp_count++;
                    break;


                case "ID": // Initialize Identification
                    Modifiable_Identification mod_ID = new Modifiable_Identification(temp_count);
                    card_panel.Controls.Add(mod_ID);
                    temp_count++;
                    break;

                case "FB":
                    Fill_IB_Modifiable mod_IB = new Fill_IB_Modifiable(temp_count);
                    card_panel.Controls.Add(mod_IB);
                    temp_count++;
                    break;

                default: break;
            }


        }

        #endregion

        #region Question Deserializer
        /// <summary>
        /// Method to Load all existing collections of Question Model Objects stored to its parent object
        /// </summary>
        private void DesrializeQuestion()
        {

            // Switch statement for Quiz type Identification

            switch (quiz.type)
            {

                case "MC":
                    DeserializeMC();
                    break;

                case "ID":
                    DeserializeID();
                    break;

                case "FB":
                    DeserializeFB();
                    break;

            }

        }

        private int temp_count = 1;

        private void DeserializeMC()
        {

            // Foreach loop to itterate through a linked list collections
            foreach (QuestionModel_MultipleChoice MC in quiz.collection_Questions)
            {


                // Initiate the interface and pass the Multiple Choice Data
                Modifiable_MC mod_MC = new Modifiable_MC(temp_count, MC)
                {
                    question = MC.Question,
                    correct_answer = MC.correct_Answer,
                    question_number = MC.question_number,
                    answers = MC.choices_Collection,
                    //image = MC.image
                    image_path = MC.ImagePath,

                };

                // Add the control
                card_panel.Controls.Add(mod_MC);
                temp_count++;

            }

        }

        private void DeserializeID()
        {
            // Foreach loop to itterate through a linked list collections
            foreach (QuestionModel_Identification ID in quiz.collection_Questions)
            {


                // Initiate the interface and pass the Multiple Choice Data
                Modifiable_Identification mod_MC = new Modifiable_Identification(temp_count, ID)
                {
                    Question = ID.Question,
                    correctAnswer = ID.correct_Answer,
                    question_number = ID.question_number,
                    image_path = ID.ImagePath,

                };

                // Add the control
                card_panel.Controls.Add(mod_MC);
                temp_count++;

            }


        }

        private void DeserializeFB()
        {

            foreach (QuestionModel_FillBlanks FB in quiz.collection_Questions)
            {

                // Initiate the interface and pass the Multiple Choice Data
                Fill_IB_Modifiable mod_MC = new Fill_IB_Modifiable(temp_count, FB)
                {
                    question = FB.Question,
                    correct_answer = FB.correct_Answer,
                    question_count = FB.question_number,
                    image_path = FB.ImagePath,

                };

                // Add the control
                card_panel.Controls.Add(mod_MC);
                temp_count++;
            }
        }


        #endregion


        #region On Closing
        private void return_btn_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }
        #endregion

       

        #region On Save and Exit event 
        /// <summary>
        /// Use the templa quiz data model for storing temporary quiz model
        /// </summary>
       
        private void SaveExit_btn_Click(object sender, EventArgs e)
        {
            // pass for saving instance 
         
            quiz.collection_Questions.Clear(); // Clear old collection for modification

            // Identify the quiz type for Interface gathering 
            switch (quiz.type)
            {

                case "MC":
                    saveAll_MC();
                    break;

                case "ID":
                    saveAll_ID();
                    break;

                case "FB":
                    saveAll_FB();
                    break;

            }

           

            // remove the recent instance of the card interface
            menu_panel.Controls.Remove(this.card);

            // create new quiz card and assign the values
            Quiz_Card_List card = new Quiz_Card_List(quiz, menu, menu_panel)
            {
                quiz_name = quiz.quiz_name,
                quiz_subject = quiz.Subject,
                quiz_type = quiz.type

            };

            menu_panel.Controls.Add(card);  

            this.Close();
            base_instance.Close();
            this.Dispose();
            base_instance.Dispose();
        }



        #endregion

        #region Save Itterator instance

        private void saveAll_MC()
        {
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
                    //image = (Bitmap)MC_Control.image,
                    ImagePath = MC_Control.image_path


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
                    //image = (Bitmap)MC_Control.image,
                    ImagePath = MC_Control.image_path

                    // TODO: Implement Images transfer 

                };

                // Add all elements 
                quiz.collection_Questions.AddLast(MC);

            }

        }



        /// <summary>
        /// Save all instance of the Fill in the blanks modifiables
        /// </summary>
        private void saveAll_FB()
        {
            foreach (Fill_IB_Modifiable MC_Control in card_panel.Controls)
            {



                validateDataProperties(MC_Control);
                QuestionModel MC = new QuestionModel_FillBlanks()
                {
                    Question = MC_Control.question,
                    correct_Answer = MC_Control.correct_answer,
                    question_number = MC_Control.question_count,
                    //image = MC_Control.image,
                    ImagePath = MC_Control.image_path

                    // TODO: Implement Images transfer 

                };

                // Add all elements 
                quiz.collection_Questions.AddLast(MC);

            }

        }

        // For Identification
        private void validateDataProperties(Modifiable_Identification MC_Control)
        {

            MC_Control.Question = MC_Control.Question == null ? "Oppsss. Looks like the creator of the quiz forget to add a question...." : MC_Control.Question;
            MC_Control.correctAnswer = MC_Control.correctAnswer == null ? " " : MC_Control.correctAnswer;

        }

        // For Fill in the Blanks
        private void validateDataProperties(Fill_IB_Modifiable MC_Control)
        {

            MC_Control.question = MC_Control.question == null ? "Oppsss. Looks like the creator of the quiz forget to add a question...." : MC_Control.question;
            MC_Control.correct_answer = MC_Control.correct_answer == null ? " " : MC_Control.correct_answer;

        }
        #endregion
    }
}
