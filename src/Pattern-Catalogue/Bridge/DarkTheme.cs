using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    class DarkTheme : IThemePainter
    {
        public void GetContent()
        {
            Console.WriteLine("DarkTheme.GetContent");
        }

        public void PaintContentInThemeColors()
        {
            Console.WriteLine("DarkTheme.PaintContentInThemeColors");
        }
    }
}
