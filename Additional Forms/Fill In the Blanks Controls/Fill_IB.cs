using Gamify__Quizzlett_Application.Additional_Forms.Functions;
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

namespace Gamify__Quizzlett_Application.Additional_Forms.Fill_In_the_Blanks_Controls
{
    public partial class Fill_IB : UserControl
    {

        #region Local Object references
        FlowLayoutPanel card_container;
        Quiz_Data_Model quiz;
        QuestionModel_FillBlanks model;
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

        public Image? image
        {
            get { return image_panel.BackgroundImage; }
            set { image_panel.BackgroundImage = value; }
        }



        #endregion

        #region Object Internal Properties
       
        public string parsed = ""; // to prevent null values \
        char[] indvLetters;
        char[] parsedIndv;
        char[] userInputChar;
        char[] orgParsed;
        string updatedParseOnText = "";
        private int count;
        #endregion 


        public Fill_IB(FlowLayoutPanel card_container, Quiz_Data_Model quiz, QuestionModel_FillBlanks model)
        {


            InitializeComponent();
            

            // Copy all arguments in the local object references
            this.card_container = card_container;
            this.quiz = quiz;
            this.model = model;

            // pass all model data in the local properties
            this.Question = model.Question;
            this.correctAnswer = model.correct_Answer;
            this.question_count = model.question_number;

            try
            {
                this.image = Image.FromFile(model.ImagePath);

            }
            catch (Exception ex) {
                MessageBox.Show($"The image file from {model.ImagePath} has been moved to another path or deleted \n Please modify this on the menu");
                model.ImagePath = null;
            
            }
            


            // Update number display
            question_number_lbl.Text = question_count.ToString();

            parser();
            parse_lbl.Text = parsed;

            // Call the color arch
            ColorSchematics.ColorArch(highlight_1, this);



        }

        #region On text change in Answer
        private void answer_txbx_TextChanged(object sender, EventArgs e)
        {
            // Update the current answer
            user_answer = answer_txbx.Text;
            updateProperties();
            ValidateAnswer();
          
        }

        private void ValidateAnswer()
        {

            if (user_answer.ToLower() == correctAnswer.ToLower())
            {


                OnCorrect();


            }
            else
            {
                OnWrong();

            }


        }


        private void OnWrong()
        {
            message_lbl.Text = "Not Quite Right...";

        }

        private void OnCorrect()
        {
            quiz.score++;
            message_lbl.Text = $"Correct !! the answer is \"{correctAnswer}\" ";
            answer_txbx.Enabled = false;
            isAnswerCorrect = true;
            skipOrNext_btn.Text = "Next";

        }
        #endregion

        #region on Skip or next event 
        private void skipOrNext_btn_Click(object sender, EventArgs e)
        {
            // Remove and Dispose the object from the panel
            card_container.Controls.Remove(this);
            Dispose();
        }
        #endregion

        #region FB Algorithm ----------------------------------------------------------------------------------
        public void parser()
        {

            Random rnd = new Random();
            int letterCount = correctAnswer.Length;
            indvLetters = correctAnswer.ToCharArray();
            int StringNumtoShow = letterCount < 4 ? 1 : letterCount / 4;
            int[] indexToShow = new int[StringNumtoShow];

            // Assign random indexes
            for (int i = 0; i < StringNumtoShow; i++)
            {

                // Assign preliminary int
                indexToShow[i] = rnd.Next(letterCount);

                // Regen int when a current generated int exist in the collection
                //while (indexToShow.Contains(rnd.Next(letterCount))) {
                //    indexToShow[i] = rnd.Next(letterCount);
                //}

            }

            // Parse to int
            for (int i = 0; i < letterCount; i++)
            {

                bool parse = false;

                for (int b = 0; b < indexToShow.Count(); b++)
                {

                    if (i == indexToShow[b])
                    {
                        parsed += indvLetters[i];
                        parse = true;

                    }

                }

                // Create a hidden placeholder on words
                if (!parse)
                {
                    if (char.IsWhiteSpace(indvLetters[i]))
                    {
                        parsed += " ";

                    }
                    else
                    {
                        parsed += "_";
                    }

                }

                // reser the value
                parse = false;


            }

            // Parse the invidual characters
            parsedIndv = parsed.ToCharArray();
            orgParsed = indvLetters;

        }



        private void updateProperties()
        {

            answer_txbx.MaxLength = correctAnswer.Length;
            userInputChar = answer_txbx.Text.ToCharArray();
            UpdateText();

        }

        private void UpdateText()
        {
            count = answer_txbx.TextLength - 1;

            if (deleting == false)
            {
                // Parse new words
                for (int i = 0; i < userInputChar.Length; i++)
                {
                    parsedIndv[i] = userInputChar[i];

                }

                for (int i = 0; i < parsedIndv.Length; i++)
                {
                    updatedParseOnText += parsedIndv[i];

                }


                parse_lbl.Text = updatedParseOnText;
                updatedParseOnText = "";
            }



        }



        public bool deleting = false;
        //Detect back spaces
        

        

        private void answer_txbx_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                deleting = true;
                count = count == -1 ? 0 : count;

                parsedIndv[count] = parsed[count];

                for (int i = 0; i < parsedIndv.Length; i++)
                {
                    updatedParseOnText += parsedIndv[i];

                }


                parse_lbl.Text = updatedParseOnText;
                updatedParseOnText = "";

                deleting = false;
            }
        }
        #endregion
    }

}
