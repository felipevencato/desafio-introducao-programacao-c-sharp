using System;

namespace DIO
{
    class Distancia : IRun
    {
        public void Run()
        {
            int quilometros = Int32.Parse(Console.ReadLine());
            int minutos = (int)(quilometros * 2); // Digite aqui o calculo dos minutos
            Console.WriteLine(minutos + " minutos");
        }
    }
}