using Gamify__Quizzlett_Application.Forms;
using WinFormAnimation_NET5;

namespace Gamify__Quizzlett_Application
{
    public partial class Main_Menu : Form
    {

        #region Form Objects
        // Initialize form Objects to load default
        Menu_Panel menu;
        Create_Quiz create_Quiz;
        Quiz_list Quiz_list;
        Statistics statistics;
        Settings settings;
        #endregion


        public Main_Menu()
        {
            InitializeComponent();

            // Initialize the main menu panel in the MDI container
            menu = new Menu_Panel();
            menu.MdiParent = this;
            menu.Show();
            menu.Dock = DockStyle.Fill;

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
       
        // Main menu load function
        private void Main_Menu_Load(object sender, EventArgs e)
        {

        }
    }
}
