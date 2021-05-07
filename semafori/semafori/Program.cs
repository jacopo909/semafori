using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace semafori
{
    class Program
    {
        static int n;
        static int incrementa;
        static int decrementa;
        static void Main(string[] args)
        {
            
            while (true)
            {
                
                Thread t1 = new Thread(() => {
                    incrementa = 1000000000;
                    n += incrementa;
                });
                while (t1.IsAlive) ;
                Thread t2 = new Thread(() => {
                    decrementa = 1000000000;
                    n += decrementa;
                });
                while (t2.IsAlive) ;
                Console.WriteLine($"il numero n vale: {n}");
            }
            
        }
    }
}
