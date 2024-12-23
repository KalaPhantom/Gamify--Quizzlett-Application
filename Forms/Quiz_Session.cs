﻿using Gamify__Quizzlett_Application.Additional_Forms;
using Gamify__Quizzlett_Application.Additional_Forms.Identification_Controls;
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
    public partial class Quiz_Session : Form
    {
        #region Object references
        Main_Menu menu;
        Quiz_Data_Model quiz;
        #endregion

        #region 
        ScoreStats scoreStats;
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

        #region Data Loader and object checker

        private void loadQuestion_data()
        {

            ObjectSerializer();
            
        }


        /// <summary>
        /// 
        /// </summary>
        private void ObjectSerializer() {

            switch (quiz.type) {

                case "MC":
                    Serialize_MC();
                    break;

                case "ID":
                    Serialize_ID();
                    break;

                case "FB":
                    break;

                default:
                    break;
            
            
            }
            
        }

        /// <summary>
        /// Serializes the Multiple Choice interfaces
        /// </summary>
        private void Serialize_MC() {
            foreach (QuestionModel_MultipleChoice model in quiz.collection_Questions)
            {
            

                // Sorter Implemented here
                // If the image is null - load the defaults
                // Otherwise, load the version of the interface where an image is supported


                if (model.image == null) {
                    // Load the default interface here
                    Multiple_Choice MC = new Multiple_Choice(model, QuizCards_flp, quiz);
                    MC.nextOrSkip_button.Click += NextOrSkip_button_Click;
                    QuizCards_flp?.Controls.Add(MC);

                }
                else {
                    Multiple_choice_img MC = new Multiple_choice_img(model, QuizCards_flp, quiz);
                    MC.nextOrSkip_button.Click += NextOrSkip_button_Click1;
                    QuizCards_flp?.Controls.Add(MC); // Must not be null

                }

            }

        }

        private void NextOrSkip_button_Click1(object? sender, EventArgs e)
        {
            CheckCount();
        }

        /// <summary>
        /// Serializes the Identification Interfaces
        /// </summary>
        private void Serialize_ID() { 
            foreach (QuestionModel_Identification model in quiz.collection_Questions)
            {
                // TODO: Implement imgae sorte
                // if image is null then load the other form

                if (model.image == null)
                {
                    Identification MC = new Identification(QuizCards_flp, quiz, model);
                    MC.skipOrNext_btn.Click += SkipOrNext_btn_Click;
                    QuizCards_flp.Controls.Add(MC);
                }
                else {
                    Identification_img MC = new Identification_img(QuizCards_flp, quiz, model);
                    MC.skipOrNext_btn.Click += SkipOrNext_btn_Click;
                    QuizCards_flp.Controls.Add(MC);
                }
                
            }
        }

        private void SkipOrNext_btn_Click(object? sender, EventArgs e)
        {
            // Call update here
            CheckCount();
        }

        /// <summary>
        /// Serialize the Fill in the blanks interface here
        /// </summary>
        private void Serialize_FB() { 
        
        
        }


        // On Multiple Choice
        private void NextOrSkip_button_Click(object? sender, EventArgs e)
        {
            // Call update here
            CheckCount();
        }


        /// <summary>
        /// CheckCount will identify if theres no remianing controls in the flow layyout panel
        /// if it does drop to zero "0" - it will destroy the current instance of this object using force Dispose method (from IDisposable)
        /// and it will load the score system
        /// 
        /// 
        /// Note: This method must be called in all forms
        /// 
        /// </summary>
        private void CheckCount()
        {
            if (QuizCards_flp.Controls.Count == 0)
            {
                // Show the score dialogue
                scoreStats = new ScoreStats(quiz, menu);
                scoreStats.FormClosed += ScoreStats_FormClosed;
                scoreStats.MdiParent = menu;
                scoreStats.Show();
                scoreStats.Dock = DockStyle.Fill;

                this.Close();
                this.Dispose();
            }
       
        }

        private void ScoreStats_FormClosed(object? sender, FormClosedEventArgs e)
        {
            //scoreStats = null;
            scoreStats.Dispose();
        }
        #endregion


        #region On Return 
        private void return_btn_Click(object sender, EventArgs e)
        {
            // TODO: Implement a closing dialogue
            Dispose();
            this.Close();
        }
        #endregion
    }
}
