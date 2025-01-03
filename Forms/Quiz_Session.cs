﻿using FluentTransitions.Methods;
using FluentTransitions;
using Gamify__Quizzlett_Application.Additional_Forms;
using Gamify__Quizzlett_Application.Additional_Forms.Fill_In_the_Blanks_Controls;
using Gamify__Quizzlett_Application.Additional_Forms.Identification_Controls;
using Gamify__Quizzlett_Application.Additional_Forms.Multiple_Choice_Control;
using Org.BouncyCastle.Asn1.Cmp;
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
using Gamify__Quizzlett_Application.Additional_Forms.Functions;

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

        #region timer Property
        public int currentTime = 0;
        public int previousScore;
        #endregion

        public Quiz_Session(Main_Menu menu, Quiz_Data_Model quiz)
        {
            InitializeComponent();

            // Pass reference
            this.menu = menu;
            this.quiz = quiz;

            // Pass ref previous score
            previousScore = (int)quiz.score;

            loadQuestion_data(); // Load all instance of the question 
            InitializeTimer(); // Load the timer 
        }


        #region Mouse Hover event on the side panel for controls

        /// <summary>
        ///  The code blocks under the hover event will show a hidden control in the active form
        /// </summary>





        #endregion

        #region Data Loader and object checker

        private void loadQuestion_data()
        {

            ObjectSerializer();

        }


        /// <summary>
        /// 
        /// </summary>
        private void ObjectSerializer()
        {

            switch (quiz.type)
            {

                case "MC":
                    Serialize_MC();
                    break;

                case "ID":
                    Serialize_ID();
                    break;

                case "FB":
                    Serialize_FB();
                    break;

                default:
                    break;


            }

        }

        /// <summary>
        /// Serializes the Multiple Choice interfaces
        /// </summary>
        private void Serialize_MC()
        {
            foreach (QuestionModel_MultipleChoice model in quiz.collection_Questions)
            {

                // Sorter Implemented here
                // If the image is null - load the defaults
                // Otherwise, load the version of the interface where an image is supported


                if (model.ImagePath == null)
                {
                    // Load the default interface here
                    Multiple_Choice MC = new Multiple_Choice(model, QuizCards_flp, quiz);
                    MC.nextOrSkip_button.Click += NextOrSkip_button_Click;
                    QuizCards_flp?.Controls.Add(MC);

                }
                else
                {
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

        private void NextOrSkip_button_Click(object? sender, EventArgs e)
        {
            CheckCount();
        }



        /// <summary>
        /// Serializes the Identification Interfaces
        /// </summary>
        private void Serialize_ID()
        {




            foreach (QuestionModel_Identification model in quiz.collection_Questions)
            {
                // TODO: Implement image sort
                // if image is null then load the other form

                if (model.ImagePath == null)
                {
                    Identification MC = new Identification(QuizCards_flp, quiz, model);
                    MC.skipOrNext_btn.Click += SkipOrNext_btn_Click;
                    QuizCards_flp.Controls.Add(MC);
                }
                else
                {
                    Identification_img MC = new Identification_img(QuizCards_flp, quiz, model);
                    MC.skipOrNext_btn.Click += SkipOrNext_btn_Click1;
                    QuizCards_flp.Controls.Add(MC);
                }
            }
        }

        private void SkipOrNext_btn_Click1(object? sender, EventArgs e)
        {
            CheckCount();
        }

        private void SkipOrNext_btn_Click(object? sender, EventArgs e)
        {
            CheckCount();
        }


        /// <summary>
        /// Serialize the Fill in the blanks interface here
        /// </summary>
        private void Serialize_FB()
        {

            // Serialize all fill in the blanks data here
            foreach (QuestionModel_FillBlanks model in quiz.collection_Questions)
            {
                if (model.ImagePath == null)
                {
                    Fill_IB_Standard MC = new Fill_IB_Standard(QuizCards_flp, quiz, model);
                    MC.skipOrNext_btn.Click += SkipOrNext_btn_Click2;
                    QuizCards_flp.Controls.Add(MC);
                }
                else
                {
                    Fill_IB MC = new Fill_IB(QuizCards_flp, quiz, model);
                    MC.skipOrNext_btn.Click += SkipOrNext_btn_Click3; ;
                    QuizCards_flp.Controls.Add(MC);
                }

            }
        }

        private void SkipOrNext_btn_Click3(object? sender, EventArgs e)
        {
            CheckCount();
        }

        private void SkipOrNext_btn_Click2(object? sender, EventArgs e)
        {
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


                // Stop the timer from executing

                if (quiz.isTimerEnabled != false) {
                    quiz_timer.Stop();
                }
               
                // Pass additional data here 
                try // Catch a null exception 
                {
                   
                    if (quiz.score != previousScore && quiz.Scores_collection.Count != 0) {
                        RemoveTrailing();
                    }

                    //MessageBox.Show(quiz.Scores_collection.Count.ToString());
                    quiz.Scores_collection.Add((int)quiz.score);
                    quiz.Time_collection.Enqueue(this.currentTime, this.currentTime);

                   


                }
                catch (Exception ex)
                {

                    // Do nothing when a null reference exception in thrown =
                }

                // Show the score dialogue
                scoreStats = new ScoreStats(quiz, menu);
                scoreStats.FormClosed += ScoreStats_FormClosed;
                scoreStats.MdiParent = menu;
                scoreStats.Show();
                scoreStats.Dock = DockStyle.Fill;


                Close();
                Dispose();

            }

        }

        #region remove trailing from the hashset
        private void RemoveTrailing()
        {

            List<int> a = new List<int>(quiz.Scores_collection);
            a.RemoveAt(0);

            HashSet<int> b = new HashSet<int>(a);

            quiz.Scores_collection = b;


        }
        #endregion

        private void ScoreStats_FormClosed(object? sender, FormClosedEventArgs e)
        {
            scoreStats.Dispose();
            Dispose();
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

        #region Timer Methods



        private void InitializeTimer()
        {
            if (quiz.isTimerEnabled != false)
            {
                quiz_timer.Interval = 1000;// 1000 ms or 1 second interval
                quiz_timer.Start();
            }
           

        }


        private void quiz_timer_Tick(object sender, EventArgs e)
        {
            currentTime++;
            timer_lbl.Text = currentTime.ToString();
            ColorSchematics.ColorAcrch_Text(timer_lbl);
        }

        #endregion


    }
}
