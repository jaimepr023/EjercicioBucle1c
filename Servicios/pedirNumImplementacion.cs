using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioBucle1.Servicios
{
    internal class pedirNumImplementacion : pedirNumInterfaz
    {
        public int pedirNum()
        {
            Console.WriteLine("Dame un numero por favor:");
            int n1 = Int32.Parse(Console.ReadLine());   
            return n1; 
        }
    }
}
