using System;
using System.Collections.Generic;
using System.Text;

namespace API_Program
{
    class Config
    {
        public void configConsole()
        {
            ConfigH configH = new ConfigH();
            configH.configTitleConsole();
            configH.configHeaderConsole();
            configH.configBackgroundColor();
        }
    }
}
