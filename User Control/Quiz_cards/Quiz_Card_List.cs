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
        Quiz_Session session;
        #endregion

        /// <summary>
        /// This constructor will recieve the whole instance of the quiz base instance
        /// </summary>
        public Quiz_Card_List(Quiz_Data_Model quiz, Main_Menu menu)
        {
            InitializeComponent();

            // Copy arguments in the e
            this.quiz = quiz;   
            this.menu = menu;

            CheckObject();
        }



        // TODO: Implement better controls in this point 
        private void test_lunch_btn_Click(object sender, EventArgs e)
        {
            CheckObject();
            session = new Quiz_Session(menu, quiz);
            session.MdiParent = menu;
            session.FormClosed += Session_FormClosed;
            session.Dock = DockStyle.Fill;
            session.Show();
            
            
        }

        private void Session_FormClosed(object? sender, FormClosedEventArgs e)
        {
            session = null; 
        }



        #region object Debugging methods
        private void CheckObject (){

            MessageBox.Show($"""""

                {quiz.quiz_name} \n
                {quiz.Subject}\n
                
                
                """""
                );
        
        
        
        
        }
        #endregion
    }
}
