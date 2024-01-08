using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutlookMiner
{
    /// <summary>
    /// This Class has taken heavy inspiration from the source RJ Code Advance, and is used to select colors for the window forms. 
    /// Source: https://www.youtube.com/watch?v=BtOEztT1Qzk&list=PLwG-AtjFaHdNb42cPK-Wb0dp3pAsCzALB&index=2 Video: Modern Flat UI, Random MultiColor, Highlight button-Active Form, WinForm, C#, V-0.1
    /// </summary>
    public static class ThemeColor
    {
        public static Color PrimaryColor { get; set; }
        public static Color SecondaryColor { get; set; }
        public static List<string> ColorList = new List<string>() { "#3F51B5",
                                                                    "#009688",
                                                                    "#FF5722",
                                                                    "#607D8B",
                                                                    "#5978BB",
                                                                    "#018790",
                                                                    "#EA4833",
                                                                    "#EF937E",
                                                                    "#F37521",
                                                                    "#126881",
                                                                    "#364D5B", 
                                                                    "#0094BC",
                                                                    "#43B76E",
                                                                    "#7BCFE9",
                                                                    "#B71C46"};
        public static Color ChangeColorBrightness(Color color, double correctionFactor)
        {
            double red = color.R;
            double green = color.G;
            double blue = color.B;
            //If correction factor is less than 0, darken color.
            if (correctionFactor < 0)
            {
                correctionFactor = 1 + correctionFactor;
                red *= correctionFactor;
                green *= correctionFactor;
                blue *= correctionFactor;
            }
            //If correction factor is greater than zero, lighten color.
            else
            {
                red = (255 - red) * correctionFactor + red;
                green = (255 - green) * correctionFactor + green;
                blue = (255 - blue) * correctionFactor + blue;
            }
            return Color.FromArgb(color.A, (byte)red, (byte)green, (byte)blue);
        }
    }
}
