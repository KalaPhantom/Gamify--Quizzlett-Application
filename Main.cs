using Gamify__Quizzlett_Application.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using Quizlett_Prototype.Additional_Forms.Functions;
using MetroFramework;
using MetroFramework.Forms;


namespace Gamify__Quizzlett_Application
{
    public partial class Main_Menu : MetroForm
    {

        #region Form Objects
        // Initialize form Objects to load default
        Menu_Panel menu;
        Create_Quiz create_Quiz;
        Quiz_list Quiz_list;
        Statistics statistics;
        About settings;
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
            //materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Green50, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.BLACK);
            //Font a = new Font("Architecs Daughter", 14, FontStyle.Bold);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        // Main menu load function
        private void Main_Menu_Load(object sender, EventArgs e)
        {
           
        }

        #region On Main Application Closing 
        private void Main_Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            JsonMethods.Serialize();
        }
        #endregion
    }
}
