using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FluentTransitions;

namespace Gamify__Quizzlett_Application.Forms
{
    public partial class Quiz_list : Form
    {
        public Quiz_list()
        {
            InitializeComponent();


            int org = this.Top;

            this.Top = -2000;

            Transition
                .With(this, nameof(Left), org)
                .EaseInEaseOut(TimeSpan.FromSeconds(1));



            
        }
        
        private void return_btn_Click(object sender, EventArgs e)
        {
            // TODO: Implement a destructor
            this.Close();
        }
    }
}
