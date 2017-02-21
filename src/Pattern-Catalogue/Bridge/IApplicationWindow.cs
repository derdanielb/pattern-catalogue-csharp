using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    abstract class IApplicationWindow
    {
        public IThemePainter theme;

        public IApplicationWindow(IThemePainter theme)
        {
            this.theme = theme;
        }
        public abstract void GetContent();
    }
}
