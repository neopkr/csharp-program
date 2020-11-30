using System;

// Aún falta por añadir el case 2

namespace API_Program
{
    class Conversion
    {
        public void conversion()
        {
            functions obj = new functions();
            int election;
            Console.WriteLine("1. Millas a Km");
            Console.WriteLine("2. Km a Millas");
            election = Convert.ToInt32(Console.ReadLine());
            switch (election)
            {
                case 1:
                    obj.clear();
                    int mi;
                    Console.WriteLine("Millas: ");
                    mi = Convert.ToInt32(Console.ReadLine());
                    double co = mi / 0.62;
                    double km;
                    km = co;
                    Console.WriteLine("La conversion se ha realizado con exito (Millas a KM");
                    Console.WriteLine("Conversion a Km: ");
                    Console.WriteLine(km);
                    break;
            }
        }
    }
}
