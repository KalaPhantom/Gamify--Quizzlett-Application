﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FluentTransitions;
using MaterialSkin.Animations;
using System.Runtime.CompilerServices;
using System.Reflection.Emit;
using FluentTransitions.Methods;

namespace Gamify__Quizzlett_Application.Forms
{
    public partial class Menu_Panel : Form
    {

        // Form object instance in button events
        Create_Quiz create_Quiz;
        Quiz_list Quiz_list;
        Statistics statistics;
        Settings settings;
        Notes notes;






        // Reference Object
        Main_Menu mdiContainer;

        public Menu_Panel(Main_Menu mdiContainer)
        {
            InitializeComponent();
            this.mdiContainer = mdiContainer;


            // Take the original positions for animations
            int ql_1 = quiz_list_btn.Left;
            int ql_2 = create_quiz_btn.Top;
            int ql_3 = notes_btn.Left;
            int ql_4 = settings_btn.Top;
            int ql_5 = stats_btn.Left;

            // Reset Random
            quiz_list_btn.Left = 200;
            create_quiz_btn.Top = 200;
            notes_btn.Left = -200;
            settings_btn.Top = 200;
            stats_btn.Left = 300;
            




            Transition
                .With(quiz_list_btn, nameof(Left), ql_1 )
                .With(create_quiz_btn, nameof(Top), ql_2)
                .With(notes_btn, nameof(Left), ql_3)
                .With(settings_btn, nameof(Top), ql_4)
                .With(stats_btn, nameof(Left), ql_5)
                .EaseInEaseOut(TimeSpan.FromSeconds(1));

           











        }


        #region Button Events

        // Quiz list button event
        private void quiz_list_btn_Click(object sender, EventArgs e)
        {

            Quiz_list = new Quiz_list();
            Quiz_list.MdiParent = mdiContainer;
            Quiz_list.FormClosed += Quiz_list_FormClosed;
            Quiz_list.Show();
            Quiz_list.Dock = DockStyle.Fill;
        }

        private void Quiz_list_FormClosed(object? sender, FormClosedEventArgs e)
        {
            Quiz_list = null;
            
           
        }

        // Create quiz button
        private void create_quiz_btn_Click(object sender, EventArgs e)
        {
            create_Quiz = new Create_Quiz();
            create_Quiz.MdiParent = mdiContainer;
            create_Quiz.FormClosed += Create_Quiz_FormClosed;
            create_Quiz.Show();
            create_Quiz.Dock = DockStyle.Fill;
        }

        private void Create_Quiz_FormClosed(object? sender, FormClosedEventArgs e)
        {
            // nullify the form to save more MB space
            create_Quiz = null;
        }

        // Notes button
        private void notes_btn_Click(object sender, EventArgs e)
        {
            notes = new Notes();
            notes.MdiParent = mdiContainer;
            notes.FormClosed += Notes_FormClosed;
            notes.Show();
            notes.Dock = DockStyle.Fill;
        }

        private void Notes_FormClosed(object? sender, FormClosedEventArgs e)
        {
            // Nullify form
            notes = null;
        }

        // Notes button event
        private void settings_btn_Click(object sender, EventArgs e)
        {
            settings = new Settings();
            settings.MdiParent = mdiContainer;
            settings.FormClosed += Settings_FormClosed;
            settings.Show();
            settings.Dock = DockStyle.Fill;
        }

        private void Settings_FormClosed(object? sender, FormClosedEventArgs e)
        {
            settings = null;
        }

        // Notes button
        private void stats_btn_Click(object sender, EventArgs e)
        {
            statistics = new Statistics();
            statistics.MdiParent = mdiContainer;
            statistics.FormClosed += Statistics_FormClosed;
            statistics.Show();
            statistics.Dock = DockStyle.Fill;
        }

        private void Statistics_FormClosed(object? sender, FormClosedEventArgs e)
        {
            statistics = null;
        }

        #endregion

        private void Menu_Panel_Load(object sender, EventArgs e)
        {

        }

    
    }
}
