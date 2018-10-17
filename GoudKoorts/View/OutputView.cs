using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GoudKoorts
{
    public class OutputView
    {
        public void DrawMap(Map map)
        {
            Console.Clear();
            Console.WriteLine("┌─────────────┐");
            Console.WriteLine("| Goudkoorts  |");
            Console.WriteLine("└─────────────┘");
            Console.WriteLine("───────────────────────");
            foreach (Track t in map.Row1)
            {
                Console.Write(t.Print());
            }
            Console.WriteLine();
            foreach (Track t in map.Row2)
            {
                Console.Write(t.Print());
            }
            Console.WriteLine();
            foreach (Track t in map.Row3)
            {
                Console.Write(t.Print());
            }
            Console.WriteLine();
            foreach (Track t in map.Row4)
            {
                Console.Write(t.Print());
            }
            Console.WriteLine();
            foreach (Track t in map.Row5)
            {
                Console.Write(t.Print());
            }
            Console.WriteLine("");
            Console.WriteLine("───────────────────────");
        }
    }
}