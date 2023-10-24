using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioBucle1.Servicios
{
    internal class sumaImplementacion : sumaInterfaz
    {
        public void suma(int numero1)
        {
            int i;
            int suma = 0;
            for (i = 1; i <= numero1; i++)
            {
                suma += i;
                
            }
            Console.WriteLine("La suma total es:"+suma);


        }

       
    }
}
