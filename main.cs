using System;
using System.Linq;
using System.Collections.Generic;

namespace korep2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var lista = new List<int>(); var r = new Random(); for (var i = 0; i < 10; i++) lista.Add(r.Next(0, 10)); foreach (var num in lista) Console.WriteLine(num); var l = (from num in lista where num == 1 select num).Any(); if (l) Console.WriteLine("van benne"); else Console.WriteLine("nincs benne");


        }
    }
}
