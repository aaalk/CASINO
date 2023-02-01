using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Casinoo
{
    class Standart
    {

        public static void Print(string s, int x, int y, ConsoleColor fg = ConsoleColor.Red)
        {
            Console.ForegroundColor = fg;
            Console.SetCursorPosition(x, y);
            Console.Write(s);
        }

        public static void HLine(string sym, int x, int y, int len)
        {
            for (int i = 0; i < len; i++)
            {
                Print(sym, x + i, y);
            }
        }

        public static void VLine(string sym, int x, int y, int len)
        {
            for (int i = 0; i < len; i++)
            {
                Print(sym, x, y + i);
            }
        }

        public static void Rectange(int x, int y, int w, int h)    //xy -- координаты левого верхнего угла
        {
            Print("╔", x, y); //201
            HLine("═", x + 1, y, w - 2); //205
            Print("╗", x + w - 1, y);   //187
            VLine("║", x, y + 1, h - 2); //186
            VLine("║", x + w - 1, y + 1, h - 2);
            Print("╚ ", x, y + h - 1); //200
            HLine("═", x + 1, y + h - 1, w - 2); //205
            Print("╝", x + w - 1, y + h - 1); //188
        }

    }
    internal class UserIntface
    {
        public static int n1, n2, n3;

        public static void Screen()
        {
            Standart.Rectange(5, 5, 12, 6);
            Standart.Rectange(20, 5, 12, 6);
            Standart.Rectange(35, 5, 12, 6);
            Standart.Rectange(3, 4, 46, 8);

        }

        public static void Game()
         {   
            string[] sym_list = { "!", "%", "@", "?", "*", "|", "~" }; 

            var rand = new Random();
            n1 = rand.Next(sym_list.Length);
            n2 = rand.Next(sym_list.Length);
            n3 = rand.Next(sym_list.Length);
            Standart.Print(sym_list[n1], 10, 8, ConsoleColor.DarkBlue);
            Thread.Sleep(1000); // милисекунды
            Standart.Print(sym_list[n2], 25, 8, ConsoleColor.DarkBlue);
            Thread.Sleep(2000);
            Standart.Print(sym_list[n3], 40, 8, ConsoleColor.DarkBlue);

        }
    }
}
