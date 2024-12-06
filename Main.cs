using Gamify__Quizzlett_Application.Forms;
using WinFormAnimation_NET5;
using MaterialSkin;
using MaterialSkin.Controls;

namespace Gamify__Quizzlett_Application
{
    public partial class Main_Menu : MaterialForm
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
            menu = new Menu_Panel(this);
            menu.MdiParent = this;
            menu.Show();
            menu.Dock = DockStyle.Fill;

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Grey50, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.BLACK);

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
