using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            HelpWindow[] windows =
            {
                new HelpWindow(new DarkTheme()),
                new HelpWindow(new LightTheme())
            };
            foreach (HelpWindow win in windows)
            {
                win.GetContent();
            }
            Console.ReadLine();
        }
    }
}
