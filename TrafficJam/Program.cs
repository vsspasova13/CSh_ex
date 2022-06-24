using System;
using System.Collections.Generic;

namespace TrafficJam
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); 
            Queue<string> cars = new Queue<string>();
            int totalcarspassed = 0;
            while (true)
            {
                string cmd = Console.ReadLine();
                if (cmd=="green")
                {
                    for (int i = 0; i < n; i++)
                    {
                        if (cars.Count>0)
                        {
                            var car=cars.Dequeue();
                            Console.WriteLine($"{car} passed!");
                            totalcarspassed++;
                        }
                    }

                }
                else if(cmd=="end")
                {
                    Console.WriteLine($"{totalcarspassed} cars passed the crossroad.");
                }
                else
                {
                    cars.Enqueue(cmd);
                }

            }
            
           




        }
    }
}
