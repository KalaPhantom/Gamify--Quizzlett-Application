using Gamify__Quizzlett_Application.Additional_Forms.Functions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gamify__Quizzlett_Application.Forms
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();

            // Custom Color
            ColorSchematics.ColorArch(panel1);
            ColorSchematics.ColorArch(panel2);
            ColorSchematics.ColorArch(panel3);
            ColorSchematics.ColorArch(panel4);
            ColorSchematics.ColorArch(panel5);
            ColorSchematics.ColorArch(panel6);
            ColorSchematics.ColorArch(pn1);
        }

        private void return_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           

            string url = "https://github.com/KalaPhantom/Gamify--Quizzlett-Application";
            try
            {
                Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to open the link: {ex.Message}");
            }
        }
    }
}
