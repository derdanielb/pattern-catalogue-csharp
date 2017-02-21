using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    class LightTheme : IThemePainter
    {
        public void GetContent()
        {
            Console.WriteLine("LightTheme.GetContent");
        }

        public void PaintContentInThemeColors()
        {
            Console.WriteLine("LightTheme.PaintContentInThemeColors");
        }
    }
}
