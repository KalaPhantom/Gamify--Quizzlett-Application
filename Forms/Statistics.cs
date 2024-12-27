using DocumentFormat.OpenXml.Packaging;
using Gamify__Quizzlett_Application.Additional_Forms.Functions;
using Gamify__Quizzlett_Application.User_Control;
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
    public partial class Statistics : Form
    {

        public int rate = 0;
        public Statistics()
        {
            InitializeComponent();
            loadCardsOnPanel();
            ColorSchematics.ColorArch(left_main_panel, panel_top, control_flp);
            ColorSchematics.ColorArch(top_panel, panel1);

            CalculateAndDisplayData();
        }

        private void return_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region Load all Stats Cards

        private void loadCardsOnPanel()
        {
            foreach (Quiz_Data_Model a in Data_Storage.quiz_list)
            {



                Statistics_Card stats_card = new Statistics_Card(a);
                control_flp.Controls.Add(stats_card);
            }

        }

        #endregion


        #region Calculate Stats
        private void CalculateAndDisplayData()
        {

            int AVG_SCORE = 0;
            int AVG_TIME = 0;

            int total_time = 0;
            int total_score = 0;

            // Get all controls in the flow layout panel
            foreach (Statistics_Card stats_cards in control_flp.Controls)
            {

                total_time += stats_cards.AverageTimeinSeconds;
                total_score += stats_cards.AverageScore;

            }

            // Arithmetic operation

            try
            {
                AVG_SCORE = (control_flp.Controls.Count / total_score) * 100;
                AVG_TIME = total_time / control_flp.Controls.Count;

            }
            catch (Exception ex) { 
            
            
            }
           

            // Update Controls
            time_avg_lbl.Text = "Average Time " + AVG_TIME;
            rate_lbl.Text = "Correct Answer Rate: " + AVG_TIME;

            rate = AVG_SCORE*100;

            InterpretDatarate();

        }

        private void InterpretDatarate() {


            if (rate >= 75)
            {
                GradeInterpritation_lbl.Text = "A";
            }

            else if (rate >= 65)
            {
                GradeInterpritation_lbl.Text = "B";
            }

            else if (rate >= 55)
            {
                GradeInterpritation_lbl.Text = "C";
            }

            else if (rate >= 45)
            {
                GradeInterpritation_lbl.Text = "D";
            }

            else
            {
                GradeInterpritation_lbl.Text = "E";
            }

        }


        #endregion



      
    }
}
