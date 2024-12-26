using Org.BouncyCastle.Asn1.Mozilla;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gamify__Quizzlett_Application.Additional_Forms.Functions
{
    public class ColorSchematics
    {
        #region Color Schemes

        // Green 
        public static Color greenHighlight = Color.FromArgb(101, 163, 13);
        public static Color greenBackColor = Color.FromArgb(54, 83, 20);
        public static Color greeUhighlight = Color.FromArgb(163, 230, 53); // 400
        public static Color greenMidLight = Color.FromArgb(77, 124, 15); // 700


        // Bluey 
        public static Color blueyHighlight = Color.FromArgb(59, 130, 246); // 500
        public static Color blueyBackColor = Color.FromArgb(30, 58, 138); // 900
        public static Color blueyUhighlight = Color.FromArgb(96, 165, 250); // 400
        public static Color blueyMidLight = Color.FromArgb(29, 78, 216); // 700


        // Red Tailwind
        public static Color redHighlight = Color.FromArgb(244, 63, 94);
        public static Color redBackColor = Color.FromArgb(136, 19, 55);
        public static Color redUhighlight = Color.FromArgb(251, 113, 133); // 400
        public static Color redMidLight = Color.FromArgb(190, 18, 60); // 700

        // Yellow Tailwind
        public static Color yellowHighLight = Color.FromArgb(234, 179, 8);
        public static Color yellowBackColor = Color.FromArgb(113, 63, 18);
        public static Color yellowUhighlight = Color.FromArgb(250, 204, 21); // 400
        public static Color yellowMidLight = Color.FromArgb(161, 98, 7); // 700

        // Purple
        public static Color purpleHightLight = Color.FromArgb(168, 85, 247);
        public static Color purpleBackColor = Color.FromArgb(88, 28, 135);
        public static Color purpleUhighlight = Color.FromArgb(192, 132, 252); // 400
        public static Color purpleMidLight = Color.FromArgb(126, 34, 206); // 700

        #endregion

        #region Color Methods Costumization
        public static void ColorArch(Control highligt1, Control highlight2, Control highlight3, Control highlight4, Control back)
        {

            switch (random())
            {

                case 1: // green

                    highligt1.BackColor = greenHighlight;
                    highlight2.BackColor = greenHighlight;
                    back.BackColor = greenBackColor;

                    break;

                case 2: //Bluey

                    highligt1.BackColor = blueyHighlight;
                    highlight2.BackColor = blueyHighlight;
                    back.BackColor = blueyBackColor;
                    break;

                case 3: // red
                    highligt1.BackColor = redHighlight;
                    highlight2.BackColor = redHighlight;
                    back.BackColor = redBackColor;
                    break;

                case 4: // yelllow
                    highligt1.BackColor = yellowHighLight;
                    highlight2.BackColor = yellowHighLight;
                    back.BackColor = yellowBackColor;
                    break;

                case 5: // purple
                    highligt1.BackColor = purpleHightLight;
                    highlight2.BackColor = purpleHightLight;
                    back.BackColor = purpleBackColor;
                    break;

            }

        }
        public static void ColorArch(Control highligt1, Control highlight2, Control back) {

            switch (random()) {

                case 1: // green

                    highligt1.BackColor = greenHighlight;
                    highlight2.BackColor = greenHighlight;
                    back.BackColor = greenBackColor;

                    break;

                case 2: //Bluey

                    highligt1.BackColor = blueyHighlight;
                    highlight2.BackColor = blueyHighlight;
                    back.BackColor = blueyBackColor;
                    break;

                case 3: // red
                    highligt1.BackColor = redHighlight;
                    highlight2.BackColor = redHighlight;
                    back.BackColor = redBackColor;
                    break;

                case 4: // yelllow
                    highligt1.BackColor = yellowHighLight;
                    highlight2.BackColor = yellowHighLight;
                    back.BackColor = yellowBackColor;
                    break;

                case 5: // purple
                    highligt1.BackColor = purpleHightLight;
                    highlight2.BackColor = purpleHightLight;
                    back.BackColor = purpleBackColor;
                    break;

            }

        }

        public static void ColorArch(Control highligt1, Control back)
        {

            switch (random())
            {

                case 1: // green

                    highligt1.BackColor = greenHighlight;
                    back.BackColor = greenBackColor;

                    break;

                case 2: //Bluey

                    highligt1.BackColor = blueyHighlight;
                    back.BackColor = blueyBackColor;
                    break;

                case 3: // red
                    highligt1.BackColor = redHighlight;
                    back.BackColor = redBackColor;
                    break;

                case 4: // yelllow
                    highligt1.BackColor = yellowHighLight;
                    back.BackColor = yellowBackColor;
                    break;

                case 5: // Purple
                    highligt1.BackColor = purpleHightLight;
                    back.BackColor = purpleBackColor;
                    break;

            }

        }
        // Overload
        public static void ColorArch(Control highlight1)
        {
            switch (random())
            {

                case 1: // green

                    highlight1.BackColor = greenHighlight;


                    break;

                case 2: //Bluey

                    highlight1.BackColor = blueyHighlight;

                    break;

                case 3: // red
                    highlight1.BackColor = redHighlight;

                    break;

                case 4: // yelllow
                    highlight1.BackColor = yellowHighLight;

                    break;

                case 5: // Purple 
                    highlight1.BackColor = purpleHightLight;

                    break;


            }
        }

        public static void ColorArch_BuildUp(Control pb,Control control1, Control control2, Control control3, Control control4) {

            switch(random()){
                case 1: // green

                    pb.BackColor = greeUhighlight;
                    control1.BackColor = greeUhighlight;
                    control2.BackColor = greenHighlight;
                    control3.BackColor = greenMidLight;
                    control4.BackColor = greenBackColor;
                    //control5.BackColor = greenBackColor;


                    break;

                case 2: //Bluey

                    pb.BackColor = blueyUhighlight;
                    control1.BackColor = blueyUhighlight;
                    control2.BackColor = blueyHighlight;
                    control3.BackColor = blueyMidLight;
                    control4.BackColor = blueyBackColor;
                    //control5.BackColor = blueyBackColor;

                    break;

                case 3: // red

                    pb.BackColor = redUhighlight;
                    control1.BackColor = redUhighlight;
                    control2.BackColor = redHighlight;
                    control3.BackColor = redMidLight;
                    control4.BackColor = redBackColor;
                    //control5.BackColor = redBackColor;

                    break;

                case 4: // yelllow
                    pb.BackColor = yellowUhighlight;
                    control1.BackColor = yellowUhighlight;
                    control2.BackColor = yellowHighLight;
                    control3.BackColor = yellowMidLight;
                    control4.BackColor = yellowBackColor;
                    //control5.BackColor = yellowBackColor;

                    break;

                case 5: // purple
                    pb.BackColor = purpleUhighlight;
                    control1.BackColor = purpleUhighlight;
                    control2.BackColor = purpleHightLight;
                    control3.BackColor = purpleMidLight;
                    control4.BackColor = purpleBackColor;
                    //control5.BackColor = purpleBackColor;

                    break;

            }

            
        }

        public static void ColorAcrch_Text(Label label) {
            switch (random())
            {

                case 1: // green

                    label.ForeColor = greenHighlight;


                    break;

                case 2: //Bluey

                    label.ForeColor = blueyHighlight;

                    break;

                case 3: // red
                    label.ForeColor = redHighlight;

                    break;

                case 4: // yelllow
                    label.ForeColor = yellowHighLight;

                    break;

                case 5: // Purple 
                    label.ForeColor = purpleHightLight;

                    break;


            }



        }
    

        public static int random() { 
            
            Random random = new Random();
            return random.Next(1,5);
        
        }
        #endregion


    }
}
