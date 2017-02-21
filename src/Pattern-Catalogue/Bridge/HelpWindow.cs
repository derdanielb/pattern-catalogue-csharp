using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    class HelpWindow : IApplicationWindow
    {
        public HelpWindow(IThemePainter theme) : base(theme)
        {
        }

        public override void GetContent()
        {
            theme.GetContent();
            theme.PaintContentInThemeColors();
        }
    }
}
