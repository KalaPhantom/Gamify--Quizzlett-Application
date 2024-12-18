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
    public partial class Modify_Quiz_form : Form
    {

        // Properties -- as nullable
        private string? type;

        // class reference
        Create_Quiz base_instance;
        Quiz_Data_Model quiz;



        public Modify_Quiz_form(Create_Quiz base_instance, Quiz_Data_Model? quiz)
        {
            InitializeComponent();


            // copy the attributes on create
            this.base_instance = base_instance;
            this.quiz = quiz;
            this.type = quiz?.type;

            // Implent switch cases to identify the quiz mode from the other form
            // Create instances of the question models
            // Statement with a nullable type
            // This cases will be implemented for initialization purposes
            switch (quiz?.type) { 

                case "MC":
                    Modifiable_MC mod = new Modifiable_MC(); 
                    card_panel.Controls.Add(mod);
                    mod.Dock = DockStyle.Fill;

                    break;

                case "ID":
                    break;

                case "FB":
                    break;

                default: // if the value is null
                    
                break;
            
            }


        }


        // Close the current instance of the active window
        private void return_btn_Click(object sender, EventArgs e)
        {
            this.Close();
            quiz = null;
            // TODO: Implement additional function
        }


        #region
        private void Add_btn_Click(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
