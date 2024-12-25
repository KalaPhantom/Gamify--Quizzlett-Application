using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using FluentTransitions;
using FluentTransitions.Methods;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Quizlett_Prototype.Additional_Forms.Functions;

namespace Gamify__Quizzlett_Application.Forms
{
    public partial class CountDown : Form
    {

        private int currentTime
        {
            get { return int.Parse(label2.Text); }
            set { label2.Text = value.ToString(); }
        }

        Quiz_Session session;
        Main_Menu menu;
        Quiz_Data_Model quiz;

        private int timeLimit = 3;

        public CountDown(Main_Menu menu, Quiz_Data_Model model)
        {
            InitializeComponent();
            currentTime = timeLimit;
            this.menu  = menu;  
            this.quiz = model; 

            InitializeTime();
            timer.Start();
        }

        private void InitializeTime()
        {
            timer.Interval = 1000; /// 1000ms or 1 sec
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            
            timeLimit--;
            currentTime = timeLimit;

           

            if (timeLimit == 0)
            {

                // Load the Quiz session form once the ready timer ended
                session = new Quiz_Session(menu, quiz);
                session.MdiParent = menu;
                session.FormClosed += Session_FormClosed;
                session.Dock = DockStyle.Fill;
                session.Show();
                timer.Stop();           
                this.Close();
                this.Dispose();

            }

        }

        private void Session_FormClosed(object? sender, FormClosedEventArgs e)
        {
            session = null;
        }

        private void CountDown_Load(object sender, EventArgs e)
        {

        }
    }
}
