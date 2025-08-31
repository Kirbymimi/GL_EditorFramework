using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotlight.GUI
{
    public class ColorKit
    {
        public static ColorKit Kit = new ColorKit();
        public Color BackColor1;
        public Color BackColor2;
        public Color ForeColor1;
        public Color AliceBlueColor;

        public SolidBrush BackBrush1;
        public SolidBrush BackBrush2;
        public SolidBrush ForeBrush1;
        public SolidBrush AliceBlueBrush;

        public ColorKit()
        {
            SetLight();
        }
        public void SetDark()
        {
            BackColor1 = Color.FromArgb(50, 50, 50);
            ForeColor1 = Color.White;
            BackColor2 = Color.FromArgb(30, 30, 30);
            AliceBlueColor = Color.FromArgb(120, 120, 120);
            updateBrushes();
        }
        public void SetLight()
        {
            BackColor1 = Color.FromArgb(240, 240, 240);
            BackColor2 = Color.FromArgb(255, 255, 255);
            ForeColor1 = Color.Black;
            AliceBlueColor = Color.AliceBlue;
            updateBrushes();
        }
        private void updateBrushes()
        {
            BackBrush1 = new SolidBrush(BackColor1);
            BackBrush2 = new SolidBrush(BackColor2);
            ForeBrush1 = new SolidBrush(ForeColor1);
            AliceBlueBrush = new SolidBrush(AliceBlueColor);
        }
    }
}
