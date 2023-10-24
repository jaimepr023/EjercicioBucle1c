using ejercicioBucle1.Servicios;

namespace ejercicioBucle1
{
    /// <summary>
    /// clase principal de nuestro programa
    /// <author>jpr-241023</author>
    /// </summary>
    class program
    {
        /// <summary>
        /// nuestro metodo principal del programa 
        /// <author>jpr-241023</author>
        /// </summary>
        /// <param name="args"></param>
        public static void Main(String[] args)
        {
            pedirNumInterfaz pn = new pedirNumImplementacion();
            sumaInterfaz sn = new sumaImplementacion();
           int n1=pn.pedirNum();
            sn.suma(n1);
        }
    }
}   