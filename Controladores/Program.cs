using ejercicioBucle1.Servicios;

namespace ejercicioBucle1
{
    class program
    {
        public static void Main(String[] args)
        {
            pedirNumInterfaz pn = new pedirNumImplementacion();
            sumaInterfaz sn = new sumaImplementacion();
           int n1=pn.pedirNum();
            sn.suma(n1);
        }
    }
}   