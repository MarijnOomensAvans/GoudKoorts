using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GoudKoorts
{
    public class InputView
    {
        public void PrintControls()
        {
            Console.WriteLine("Press 1-5 to switch to switch switches (direction left-right, first from the left is 1 etc.)");
        }

        public int GetSwitchNumber()
        {                           
            bool pressed = false;
            int result = 0;
            while (!pressed)
            {
                ConsoleKey input = Console.ReadKey(false).Key;
 
                switch (input)
                {
                    case ConsoleKey.S:
                        result = -1;
                        pressed = true;
                        break;
                    case ConsoleKey.D1:
                        result = 1;
                        pressed = true;
                        break;
                    case ConsoleKey.D2:
                        result = 2;
                        pressed = true;
                        break;
                    case ConsoleKey.D3:
                        result = 3;
                        pressed = true;
                        break;
                    case ConsoleKey.D4:
                        result = 4;
                        pressed = true;
                        break;
                    case ConsoleKey.D5:
                        result = 4;
                        pressed = true;
                        break;
                    default:
                        Console.WriteLine("");
                        Console.WriteLine("Press 1-5 to switch to switch switches (direction left-right, first from the left is 1 etc.)");
                        break;
                }
            }
            return result;
        }
    }
}