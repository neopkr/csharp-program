using System;
using System.Collections.Generic;
using System.Text;

namespace API_Program
{
    class ConfigH
    {
        public string title = "API-PROGRAM";
        private void configTestHeaderConsole()
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
            width = 140;
            height = 35;
            Console.SetWindowSize(width, height);
            Console.WriteLine(m2, Console.WindowWidth, Console.WindowHeight);
            Console.WriteLine(m4);
            Console.ReadKey(true);
            //
            // restore to original size
            //
            Console.SetWindowSize(origWidth, origHeight);
            Console.WriteLine(m1, Console.WindowWidth, Console.WindowHeight);
        }
        public void configHeaderConsole()
        {
            int origWidth, WIDTHMIN_, WIDTHMAX_;
            int origHeight, HEIGHTMIN_, HEIGHTMAX_;
            int YNE;
            int ELECTION_;

            string origSize = "La anchura y altura original es {0}, {1}.";
            string ifChange = "Desea cambiarlo? (Presione 1 para 1/4) (Presione 2 para dejarlo original) (Presione 3 para aumentar)";
            string changeSize = "La nueva anchura y alto es {0}, {1}";
            string nonConform = "Desea cambiarlo?";
            string keyContinue = "Press any key to continue...";
            string dontChange = "La anchura y alto no ha sido cambiada.";

            // load current window size
            return1:
            origWidth = Console.WindowWidth;
            origHeight = Console.WindowHeight;
            Console.WriteLine(origSize, origWidth, origHeight);
            Console.WriteLine(ifChange);
            ELECTION_ = Convert.ToInt32(Console.ReadLine());

            switch (ELECTION_)
            {
                case 1:
                    WIDTHMIN_ = origWidth / 2;
                    HEIGHTMIN_ = origHeight / 2;
                    Console.SetWindowSize(WIDTHMIN_, HEIGHTMIN_);
                    Console.WriteLine(changeSize, Console.WindowWidth, Console.WindowHeight);
                    Console.WriteLine(nonConform);
                    YNE = Convert.ToInt32(Console.ReadLine());
                    if (YNE == 1)
                    {
                        goto return1;
                    }
                    else if (YNE == 2)
                    {
                        Console.WriteLine(keyContinue);
                        Console.ReadKey(true);
                    }
                    break;
                case 2:
                    Console.SetWindowSize(origWidth, origHeight);
                    Console.WriteLine(dontChange, Console.WindowWidth, Console.WindowHeight);
                    Console.WriteLine(keyContinue);
                    Console.ReadKey(true);
                    break;
                case 3:
                    WIDTHMAX_ = 140;
                    HEIGHTMAX_ = 35;
                    Console.SetWindowSize(WIDTHMAX_, HEIGHTMAX_);
                    Console.WriteLine(changeSize, Console.WindowWidth, Console.WindowHeight);
                    Console.WriteLine(nonConform);
                    YNE = Convert.ToInt32(Console.ReadLine());
                    if (YNE == 1)
                    {
                        goto return1;
                    }
                    else if (YNE == 2)
                    {
                        Console.WriteLine(keyContinue);
                        Console.ReadKey(true);
                    }
                    break;
            }
        }
        public void configBackgroundColor()
        {
            // Get an array with the values of ConsoleColor enumeration members.
            ConsoleColor[] colors = (ConsoleColor[])ConsoleColor.GetValues(typeof(ConsoleColor));
            // Save the current background and foreground colors.
            ConsoleColor currentBackground = Console.BackgroundColor;
            ConsoleColor currentForeground = Console.ForegroundColor;

            // Display all foreground colors except the one that matches the background.
            Console.WriteLine("All the foreground colors except {0}, the background color:",
                              currentBackground);
            foreach (var color in colors)
            {
                if (color == currentBackground) continue;

                Console.ForegroundColor = color;
                Console.WriteLine("   The foreground color is {0}.", color);
            }
            Console.WriteLine();
            // Restore the foreground color.
            Console.ForegroundColor = currentForeground;

            // Display each background color except the one that matches the current foreground color.
            Console.WriteLine("All the background colors except {0}, the foreground color:",
                              currentForeground);
            foreach (var color in colors)
            {
                if (color == currentForeground) continue;

                Console.BackgroundColor = color;
                Console.WriteLine("   The background color is {0}.", color);
            }

            // Restore the original console colors.
            Console.ResetColor();
            Console.WriteLine("\nOriginal colors restored...");
        }

        public void configTitleConsole()
        {
            // if u wanna change during the program press this numbers in the menu = 32;
            Console.Title = title;
        }
        public void configTitleChangeConsole()
        {
            int ELYN;
            string y1 = "El titulo ha sido cambiado, ahora es: ";
            Console.WriteLine("El titulo currente en la consola es " + title);
            Console.WriteLine("Presiona 1 si lo quieres cambiar, presiona 2 si lo deseas dejar tal como esta.");
            ELYN = Convert.ToInt32(Console.ReadLine());
            switch (ELYN)
            {
                case 1:
                    Console.WriteLine("Escribe el nuevo titulo: ");
                    title = Convert.ToString(Console.ReadLine());
                    Console.Title = title;
                    Console.WriteLine(y1, Console.Title);
                    break;
                case 2:
                    Console.Clear();
                    break;
            }
        }
        public void configCursorVisible()
        {
            int NY;
            Console.WriteLine("Desea ver el Cursor: ");
            NY = Convert.ToInt32(Console.ReadLine());
            if (NY == 1)
            {
                Console.CursorVisible = true;
            }
            else if (NY == 2)
            {
                Console.CursorVisible = false;
            }

        }
    }
    //The example displays output like the following:
    //    All the foreground colors except DarkCyan, the background color:
    //       The foreground color is Black.
    //       The foreground color is DarkBlue.
    //       The foreground color is DarkGreen.
    //       The foreground color is DarkRed.
    //       The foreground color is DarkMagenta.
    //       The foreground color is DarkYellow.
    //       The foreground color is Gray.
    //       The foreground color is DarkGray.
    //       The foreground color is Blue.
    //       The foreground color is Green.
    //       The foreground color is Cyan.
    //       The foreground color is Red.
    //       The foreground color is Magenta.
    //       The foreground color is Yellow.
    //       The foreground color is White.
    //
    //    All the background colors except White, the foreground color:
    //       The background color is Black.
    //       The background color is DarkBlue.
    //       The background color is DarkGreen.
    //       The background color is DarkCyan.
    //       The background color is DarkRed.
    //       The background color is DarkMagenta.
    //       The background color is DarkYellow.
    //       The background color is Gray.
    //       The background color is DarkGray.
    //       The background color is Blue.
    //       The background color is Green.
    //       The background color is Cyan.
    //       The background color is Red.
    //       The background color is Magenta.
    //       The background color is Yellow.
    //
    //    Original colors restored...

    // no se como funciona esto aun, pero más tarde estará listo jaja
}
    

