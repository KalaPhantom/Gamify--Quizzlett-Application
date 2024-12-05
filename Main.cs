using Gamify__Quizzlett_Application.Forms;

namespace Gamify__Quizzlett_Application
{
    public partial class Main_Menu : Form
    {

        #region Form Objects
        // Initialize form Objects to load default

        #endregion
        Menu_Panel menu;
        public Main_Menu()
        {
            InitializeComponent();

            // Initialize the main meun
            menu = new Menu_Panel();
            menu.MdiParent = this;
            menu.Show();
            menu.Dock = DockStyle.Fill;

        }
    }
}
