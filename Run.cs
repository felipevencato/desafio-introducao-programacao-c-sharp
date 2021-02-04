using System;
using System.Linq;
using System.Collections.Generic;

namespace DIO
{
    class Run
    {
        static void Main(string[] args) {
            IRun [] Exe = {
                new Divisao(),
                new Distancia(),
                new Mandioca (),
            };
            if (args.Count() == 0){
                string info = "Informe o numero do Executorício\n";
                int i = 0;
                do
                    info += $"{i} {Exe[i].ToString()}\n";
                while (++i < Exe.Count());
                Console.WriteLine(info + "dotnet run [NUMERO]");
                return;
            }
            Exe.ElementAt(Int32.Parse(args[0]))
            .Run();
        }
    }
}
