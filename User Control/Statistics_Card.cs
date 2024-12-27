using Gamify__Quizzlett_Application.Additional_Forms.Functions;
using iText.StyledXmlParser.Node;
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

namespace Gamify__Quizzlett_Application.User_Control
{
    public partial class Statistics_Card : UserControl
    {


        #region
        public string title {

            get { return title_lbl.Text; }
            set { title_lbl.Text = value; }

        }

        public int AverageTimeinSeconds
        {

            get { return int.Parse(average_time_lbl.Text); }
            set { average_time_lbl.Text = value.ToString(); }
        }

        public int AverageScore {

            get { return int.Parse(Average_score_lbl.Text); }
            set { Average_score_lbl.Text = value.ToString(); }
        }

        


        #endregion

        #region Local Object references

        Quiz_Data_Model quiz; 

        #endregion

        public Statistics_Card(Quiz_Data_Model quiz)
        {
            InitializeComponent();

            // Pass data references
            this.quiz = quiz;

            // Update elements
            InitializeSecondaryComponent(); 

        }


        #region Initialize Secondary Component
        private void InitializeSecondaryComponent() {
            this.title = quiz.quiz_name;
            InterpretScore();

            AverageTimeinSeconds = ComputeAverage_Time();
            AverageScore = Average_Total_Score();

            ColorSchematics.ColorArch(upper_panel_1,this);

            Average_score_lbl.Text = AverageScore.ToString();

            // Remove trailing data from the hashset


            // Trim collections
            quiz.Scores_collection = StatisticModel.TrimExcessData(quiz.Scores_collection);
            StatisticModel.TrimExcessData(quiz.Time_collection);
        
        }
        #endregion

       


        #region Math Average Methods
        private int ComputeAverage_Time() {

            int totalScore = 0;

            List<int> tempList = new List<int>();

            // not recomended
            while (quiz.Time_collection.Count > 0) {

                tempList.Add(quiz.Time_collection.Dequeue());
            }

            // Add all and average
            foreach (int a in tempList) { 
                totalScore += a;
            }

            try
            {
                totalScore = totalScore/tempList.Count;
            }
            catch (Exception ex) { 
            
            }

            return totalScore;
        
        }

        private int Average_Total_Score() {
            double totalScore = 0;
            double AVG = 0;

            List<int> collection1 = new List<int>(quiz.Scores_collection);

            for (int i = 0; i < collection1.Count; i++) {
                totalScore +=collection1[i];
            }

            try
            {
                AVG = totalScore / collection1.Count ;
                totalScore = AVG/ quiz.collection_Questions.Count ;
               

            }
            catch (Exception ex)
            {
                // Do nthing
            }

            double result = totalScore * 100;
            return (int) result;
       
        }


        private void InterpretScore() {



            if (Average_Total_Score() >= 75)
            {
                Interpretation_lbl.Text = "A";
            }

            else if (Average_Total_Score() >= 65)
            {
                Interpretation_lbl.Text = "B";
            }

            else if (Average_Total_Score() >= 55)
            {
                Interpretation_lbl.Text = "C";
            }

            else if (Average_Total_Score() >= 45)
            {
                Interpretation_lbl.Text = "D";
            }

            else
            {
                Interpretation_lbl.Text = "E";
            }

        }
        #endregion
    }
}
