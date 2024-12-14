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
    public partial class Create_Quiz : Form
    {
        public Create_Quiz()
        {
            InitializeComponent();
          
        }

        private void return_btn_Click(object sender, EventArgs e)
        {
            // TODOD: Implement a destructor to add optimization
            this.Close();
        }
    }
}
