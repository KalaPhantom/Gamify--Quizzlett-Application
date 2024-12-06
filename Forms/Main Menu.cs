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
