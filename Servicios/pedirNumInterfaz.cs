using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicioBucle1.Servicios
{
    /// <summary>
    /// interfaz donde se encuentra el metodo de pedir un numero
    /// <author>jpr-241023</author>
    /// </summary>
    internal interface pedirNumInterfaz
    {
        /// <summary>
        /// metodo donde escane el numero que no nosotros le introduzcamos.
        /// </summary>
        /// <returns>devuelve un entero</returns>
        public int pedirNum();
    }
}
