using Gamify__Quizzlett_Application.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gamify__Quizzlett_Application.Custom_Controls
{
    public partial class Floating_Navigation : UserControl
    {

        private Main_Menu mdiContainer;
        public Floating_Navigation()
        {
            InitializeComponent();
            this.mdiContainer = mdiContainer;
        }

        // Reference
      

        #region Button navigations
        private void menu_btn_Click(object sender, EventArgs e)
        {

        }

        // Object Instannce
        Create_Quiz create_quiz_form;

        private void create_btn_Click(object sender, EventArgs e)
        {
            create_quiz_form = new Create_Quiz();
            create_quiz_form.MdiParent = mdiContainer;
            create_quiz_form.Show();
            create_quiz_form.Dock = DockStyle.Fill;
        }
        #endregion
    }
}
