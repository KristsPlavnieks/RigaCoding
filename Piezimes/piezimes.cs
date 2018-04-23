using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piezimes
{
    class piezimes
    {
        public void Test()
        {

            Random skaitluGenerators = new Random();

            int sk1 = skaitluGenerators.Next(1, 20);
            int sk2 = skaitluGenerators.Next(1, 20);

            Console.Write("Cik ir: " + sk1 + " reiz " + sk2 + " ?");
            int atbilde = Convert.ToInt32(Console.ReadLine());

            if(atbilde == sk1 * sk2)
            {
                Console.WriteLine("Pareizi! ");
                                
            }
            else
            {
                int atbildesIndex = skaitluGenerators.Next(1, 4);

                switch (atbildesIndex)
                {
                    case 1:
                        Console.WriteLine("Labs meiginajums!");
                        break;
                    case 2:
                        Console.WriteLine("Soreiz netrapiji!");
                        break;
                    default:
                        Console.WriteLine("Nekas, varbut veiksies citreiz!");
                        break;
                }
            }



        }
                                                                                            
        public void Uzdevums2()
        {
              Console.WriteLine("ievadi skaitli");
              int skaitlis = Convert.ToInt32(Console.ReadLine());
              for (int i = skaitlis; i < 50; i++)
              
            
              {
                if (skaitlis % 2 == 0)
                        Console.WriteLine("Number is even");
                
                else
                { 
                    Console.WriteLine("Number " + skaitlis + " is not even");
                   
                }

                break;
              }

            

            
        }               
                            
    }
}
