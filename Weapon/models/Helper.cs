using System;
using System.Collections.Generic;
using System.Text;

namespace Weapon.models
{
    public static class Helper
    {
        public static void WriteConsole(ConsoleColor color, string text)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(text);
            Console.ResetColor();
        }
    }
}
