using Gamify__Quizzlett_Application.Additional_Forms.Functions;
using Gamify__Quizzlett_Application.Forms;
using Quizlett_Prototype.Additional_Forms.Functions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gamify__Quizzlett_Application.User_Control.Quiz_cards
{


    public partial class Quiz_main_card : UserControl
    {

        #region Properties
        public string name
        {
            get { return name_lbl.Text; }
            set { name_lbl.Text = value; }

        }

        public string? subject
        {
            get { return subject_lbl.Text; }
            set { subject_lbl.Text = value; }

        }

        public string? type_display
        {

            get { return type_lbl.Text; }
            set { type_lbl.Text = value; }
        }

        public string? type { get; set; }

        public Bitmap? image_profile
        {
            get { return (Bitmap)image_panel.BackgroundImage; }
            set { image_panel.BackgroundImage = value; }
        }

        public string timer_enabled
        {

            get { return istimer_lbl.Text; }
            set { istimer_lbl.Text = (string)value; }
        }

        public string last_score {

            get { return last_score_lbl.Text; }
            set { last_score_lbl.Text = (string)value; }
        }
        #endregion

        #region Object Reference
        Quiz_Data_Model quiz;
        FlowLayoutPanel card_container;
        Main_Menu menu; 
        #endregion

        public Quiz_main_card(Quiz_Data_Model quiz, FlowLayoutPanel card_container, Main_Menu menu)
        {
            InitializeComponent();

            // Pass data from the arguments to the local object reference
            this.quiz = quiz;
            this.card_container = card_container;
            this.menu = menu;

            // Assign values from the objects in the arguments to the local properties
            name = quiz.quiz_name;
            subject = quiz.Subject;
            type_display = quiz.type == "MC" ? "Multiple Choice" : quiz.type == "ID" ? "Identification" : quiz.type == "FB" ? "Fill in the blanks" : "Not Set";
            this.type = quiz.type;
          

            try
            {
                this.image_profile = (Bitmap)Image.FromFile(quiz.ImagePath);
                image_panel.BackgroundImageLayout = ImageLayout.Stretch;

            }
            catch (Exception ex)
            {
                // Do nothing 
            }
            
            this.timer_enabled = "Timer: " + quiz.isTimerEnabled;
            this.last_score_lbl.Text = $"Recent Score: " + quiz.score;
            this.last_score = "Last Score: " + quiz.recentScore.ToString();

            // Call ColorArch
            ColorSchematics.ColorArch_BuildUp(image_panel, this, panel2, panel3, play_btn);

        }



        #region On Play Quiz
        // Create the instance of the countdown
        CountDown cd;
        private void play_btn_Click(object sender, EventArgs e)
        {
            CountDown cd = new CountDown(menu, quiz);
            cd.MdiParent = menu;
            cd.FormClosed += Cd_FormClosed;
            cd.Dock = DockStyle.Fill;
            cd.Show();
        }

        private void Cd_FormClosed(object? sender, FormClosedEventArgs e)
        {
            cd.FormClosed -= Cd_FormClosed; // Unsubscribe the event for efficient resources
            cd.Dispose();
        }
        #endregion
    }
}
