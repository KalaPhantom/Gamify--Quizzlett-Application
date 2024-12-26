using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FluentTransitions;
using Gamify__Quizzlett_Application.User_Control.Quiz_cards;
using iText.Commons.Utils;
using Quizlett_Prototype.Additional_Forms.Functions;

namespace Gamify__Quizzlett_Application.Forms
{
    public partial class Quiz_list : Form
    {

       #region 
       
       
       Main_Menu menu;
       #endregion


        public Quiz_list(Main_Menu menu)
        {
            InitializeComponent();

            // Pass references to the local object instance
            this.menu = menu;

            int org = this.Top;
            this.Top = -2000;

            Transition
                .With(this, nameof(Left), org)
                .EaseInEaseOut(TimeSpan.FromSeconds(1));

            LoadCardsfromJson();
        }

        #region Return
        private void return_btn_Click(object sender, EventArgs e)
        {
            // TODO: Implement a destructor
            this.Close();
        }
        #endregion

        #region Load Data fromo Json
        private void LoadCardsfromJson()
        {


            if (Data_Storage.quiz_list != null)
            {

                foreach (Quiz_Data_Model model in Data_Storage.quiz_list)
                {


                    Quiz_main_card m_card = new Quiz_main_card(model, main_card_container, menu);
                    main_card_container.Controls.Add(m_card);

                    // Create an interface
                    // Pass the quiz base instance
                    //Quiz_Card_List card = new Quiz_Card_List(model, mdiContainer, MainMenu_flp)
                    //{
                    //    quiz_name = model.quiz_name,
                    //    quiz_subject = model.Subject,
                    //    quiz_type = model.type,

                    //};

                    //// Add the controls
                    //MainMenu_flp.Controls.Add(card);
                }

            }

        }
        #endregion

    }
}
