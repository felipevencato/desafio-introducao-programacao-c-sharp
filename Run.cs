using System;
using System.Linq;
using System.Collections.Generic;

namespace DIO
{
    class Run
    {
        static void Main(string[] args)
        {
            var Exe = new List<IRun>{
                new Divisao(),
                new Distancia(),
                new Mandioca ()
            };
            if (args.Count() == 0)
            {
                int i = 0;
                Console.WriteLine(
                    "Informe o numero do Executorício\n"
                    + string.Join("\n", Exe.Select(x => $"{i++} {x}"))
                    + "\ndotnet run [NUMERO]"
                );
                return;
            }
            Exe.ElementAt(Int32.Parse(args[0]))
            .Run();
        }
    }
}
