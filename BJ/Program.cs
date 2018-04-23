using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BJ.Classes;

namespace BJ
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();

            while (true)
            {
               if(!game.StartNewGame()) // ! <-- ja funkcija atgriezis false atgrieizs sakuma un izmetis spele pabeigta
                {
                    break;
                }
            }

            Console.WriteLine("Spēle pabeigta!");
            Console.ReadLine();
        }
    }
}
