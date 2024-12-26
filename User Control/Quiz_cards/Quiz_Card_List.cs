using Gamify__Quizzlett_Application.Forms;
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
using System.Timers;
using System.Threading;
using System.Diagnostics.Metrics;
using MetroFramework;
using Gamify__Quizzlett_Application.Additional_Forms.Functions;





namespace Gamify__Quizzlett_Application.User_Control.Quiz_cards
{
    public partial class Quiz_Card_List : UserControl
    {
        /// <summary>
        /// This form is only solely intended as an interface
        /// </summary>

        #region Properties
        public string quiz_name
        {
            get { return title_lbl.Text; }
            set { title_lbl.Text = value; }
        }
        public string quiz_type { get; set; }
        public string quiz_subject
        {
            get { return subject_lbl.Text; }
            set { subject_lbl.Text = value; }
        }


        #endregion


        #region Base class references
        Quiz_Data_Model quiz;
        Main_Menu menu;
        FlowLayoutPanel main_panel;

        #endregion

        /// <summary>
        /// This constructor will recieve the whole instance of the quiz base instance
        /// </summary>
        public Quiz_Card_List(Quiz_Data_Model quiz, Main_Menu menu, FlowLayoutPanel main_panel)
        {
            InitializeComponent();

            // Copy arguments in the e
            this.quiz = quiz;
            this.menu = menu;
            this.main_panel = main_panel;

            ColorSchematics.ColorArch(highlight_panel_1,highlight_panel_2, this);


        }



        // TODO: Implement better controls in this point 
        private void test_lunch_btn_Click(object sender, EventArgs e)
        {

            CountDown cd = new CountDown(menu, quiz);
                cd.MdiParent = menu;
                cd.FormClosed += Cd_FormClosed;
                cd.Dock = DockStyle.Fill;
                cd.Show();
            


        }

        private void Cd_FormClosed(object? sender, FormClosedEventArgs e)
        {
            // for future functions
        }


        private void timer_Tick(object sender, EventArgs e)
        {

        }


        #region Delete Current
        private void Delete_btn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to delete this Quiz?", "Confirm Delete", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {

                Data_Storage.quiz_list.Remove(quiz);
                main_panel.Controls.Remove(this);
                this.Dispose();
            }
            else
            {

                // Do nothing here 
                // Implement future functionalities
            }

        }
        #endregion


        #region Modify Event

        // Create a hanging instance

        Edit_Quiz _Edit_quiz;

        private void modify_btn_Click(object sender, EventArgs e)
        {
            // Update current object state
            _Edit_quiz = new Edit_Quiz(quiz, menu, main_panel, this);
            _Edit_quiz.MdiParent = menu;
            _Edit_quiz.FormClosed += _Edit_quiz_FormClosed;
            _Edit_quiz.Dock = DockStyle.Fill;
            _Edit_quiz.Show();

         

        }



        private void _Edit_quiz_FormClosed(object? sender, FormClosedEventArgs e)
        {
            _Edit_quiz?.Dispose();
        }


        #endregion
    }
}
