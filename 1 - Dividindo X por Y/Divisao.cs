using System;
using System.Linq;

namespace DIO
{
    public class Divisao : IRun
    {
        private void OP1()
        {
            int limit = Int32.Parse(Console.ReadLine());
            for (int i = 0; i < limit; i++)
            {
                string[] line = Console.ReadLine().Split(" ");
                double X = double.Parse(line[0]);
                double Y = double.Parse(line[1]);

                if (Y == 0)
                {
                    Console.WriteLine("divisao impossivel");
                }
                else
                {
                    double divisao = (double)X / Y;

                    if (divisao < 0 && divisao > -0.5)
                    {
                        Console.WriteLine("-0.0");
                    }
                    else
                    {
                        Console.WriteLine(Math.Round(divisao, 1).ToString("N1"));
                    }
                }
            }
        }
        private void OP2()
        {
            int limit = Int32.Parse(Console.ReadLine());
            while (limit-- > 0)
            {
                var Args = Console.ReadLine()
                    .Split(" ")
                    .Select(x => double.Parse(x))
                    .ToArray();

                if (Args[1] == 0)
                {
                    Console.WriteLine("divisao impossivel");
                    continue;
                }

                double Divisao = Args[0] / Args[1];

                if (Divisao < 0 && Divisao > -0.5)
                {
                    Console.WriteLine("-0.0");
                    continue;
                }
                Console.WriteLine(Math.Round(Divisao, 1).ToString("N1"));
            }

        }
        public void Run()
        {
            OP2();
        }
    }
}