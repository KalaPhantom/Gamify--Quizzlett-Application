using Gamify__Quizzlett_Application.Additional_Forms;
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
    public partial class Quiz_Session : Form
    {
        #region Object references
        Main_Menu menu;
        Quiz_Data_Model quiz;
        #endregion

        public Quiz_Session(Main_Menu menu, Quiz_Data_Model quiz)
        {
            InitializeComponent();
            this.menu = menu;
            this.quiz = quiz;

            loadQuestion_data();
        }


       


        #region Mouse Hover event on the side panel for controls

        /// <summary>
        ///  The code blocks under the hover event will show a hidden control in the active form
        /// </summary>

        private void Hover_control_panel_MouseEnter(object sender, EventArgs e)
        {

        }



        #endregion

        #region Data Loader

        private void loadQuestion_data() {
            foreach (QuestionModel_MultipleChoice model in quiz.collection_Questions) {


                //Call interface
                Multiple_Choice MC = new Multiple_Choice(model);
             



                QuizCards_flp?.Controls.Add(MC);
            }
        }
        #endregion
    }
}
