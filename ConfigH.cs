using System;
using System.Collections.Generic;
using System.Text;

namespace API_Program
{
    class ConfigH
    {
        public void configHeaderConsole()
        {
            int origWidth, width;
            int origHeight, height;
            string m1 = "La anchura de la ventana es {0} y el alto es {1}.";
            string m2 = "La nueva anchura de la ventana es {0}, y el alto es {1}";
            string m4 = " Press Any Key To Continue...";
            //
            // Current size windows dimensions
            //
            origWidth = Console.WindowWidth;
            origHeight = Console.WindowHeight;
            Console.WriteLine(m1, Console.WindowWidth, Console.WindowHeight);
            Console.WriteLine(m4);
            Console.ReadKey(true);
            //
            // cut the windows in 1/4
            //
            width = origWidth / 2;
            height = origHeight / 2;
            Console.SetWindowSize(width, height);
            Console.WriteLine(m1, Console.WindowWidth, Console.WindowHeight);
            Console.WriteLine(m4);
            Console.ReadKey(true);
            //
            // restore to original size
            //
            Console.SetWindowSize(origWidth, origHeight);
            Console.WriteLine(m1, Console.WindowWidth, Console.WindowHeight);
        }
    }
}
