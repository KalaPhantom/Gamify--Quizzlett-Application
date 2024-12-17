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
    public partial class Modify_Quiz_form : Form
    {
        // class reference
        Create_Quiz base_instance;
        Quiz_Data_Model quiz;



        public  Modify_Quiz_form(Create_Quiz base_instance, Quiz_Data_Model? quiz)
        {
            InitializeComponent();

            
            // copy the attributes on create
            this.base_instance = base_instance;
            this.quiz = quiz;
           
        }


        // Close the current instance of the active window
        private void return_btn_Click(object sender, EventArgs e)
        {
            this.Close();
            quiz = null;
            // TODO: Implement additional function
        }
    }
}
