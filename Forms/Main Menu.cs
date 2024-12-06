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

        public Menu_Panel()
        {
            InitializeComponent();
        }


        #region Button Events

        // Quiz list button event
        private void quiz_list_btn_Click(object sender, EventArgs e)
        {

        }

        // Form closing event
        // This event will be triggered if the obeject is terminated or closed


        // Create quiz button
        private void create_quiz_btn_Click(object sender, EventArgs e)
        {

        }

        // Notes button
        private void notes_btn_Click(object sender, EventArgs e)
        {

        }

        // Notes button event
        private void settings_btn_Click(object sender, EventArgs e)
        {

        }

        // Notes button
        private void stats_btn_Click(object sender, EventArgs e)
        {

        }

        #endregion

        private void Menu_Panel_Load(object sender, EventArgs e)
        {

        }
    }
}
