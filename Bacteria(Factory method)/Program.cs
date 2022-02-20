using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bacteria_Factory_method_
{
    class Program
    {


        static public void Main(String[] args)
        {

            Console.OutputEncoding = Encoding.UTF8;
            Random random = new Random();
            Bacteria bacteria_ = new Bacteria(0,0,false,0);
            int id = 1, dead_bacteria = 0, number_bacteria = 1, live_bacteria = 1;
            Factory factory=new Factory();
            List<Bacteria> bacterias = new List<Bacteria>();
            bacterias.Add(bacteria_);
            bool cont = true;

            while (cont==true)
            {

                foreach (Bacteria bacteria in bacterias.ToArray())
                {
                    int random_num = 0;
                    random_num = random.Next(1, 100);
                    

                    if(random_num<70)
                    {
                        bacterias.Add(factory.Reproduction(bacteria, id + 1));
                        number_bacteria++;
                        live_bacteria++;
                    }
                    else if(random_num>=70)
                    {
                        factory.Death(bacteria);
                        bacterias.Remove(bacteria);
                        dead_bacteria++;
                        live_bacteria--;
                    }

                }

                if(Console.ReadKey().Key==ConsoleKey.Enter)
                {
                    Console.WriteLine("==========================================================");
                    Console.WriteLine("Кількість бактерій: "+number_bacteria);
                    Console.WriteLine("Живі бактерії:      "+live_bacteria);
                    Console.WriteLine("Мертві бактерії:    "+dead_bacteria);
                    cont = true;
                }
                else if(Console.ReadKey().Key == ConsoleKey.Backspace)
                {
                    Console.WriteLine("==========================================================");
                    Console.WriteLine("Кількість бактерій: " + number_bacteria);
                    Console.WriteLine("Живі бактерії:      " + live_bacteria);
                    Console.WriteLine("Мертві бактерії:    " + dead_bacteria);
                    cont = false;
                }
            }








            Console.ReadLine();
        }


    }
}

