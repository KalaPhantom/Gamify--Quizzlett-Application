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
    public partial class ScoreStats : Form
    {


        #region
        public Quiz_Data_Model quiz;
        public Main_Menu menu;
        #endregion

        public ScoreStats(Quiz_Data_Model quiz, Main_Menu menu)
        {
            InitializeComponent();

            // Update
            this.quiz = quiz;
            this.menu = menu;

            UpdateStatusControl();


        }

        #region
        /// <summary>
        /// UpdateStatusConstrol() 
        /// 
        ///  info:
        ///  This method will perform status updates on this control
        /// 1: Update the score
        /// 2: Show the score system
        /// </summary>
        private void UpdateStatusControl()
        {

            ratio_lbl.Text = quiz.score + " /" + quiz.collection_Questions.Count.ToString();
            quiz.recentScore = quiz.score;
            quiz.score = 0;
        }
        #endregion




        // return button event
        private void return_btn_Click(object sender, EventArgs e)
        {
            // reset the score count
           
            

            this.Close();
            Dispose();  
        }
    }
}
