using System;

namespace API_Program
{
    class Randomizer
    {
        public void randomi()
        {
            //// crear un objeto, utiliza un reloh del sistema para crear una semilla
            ////Obtiene un numero natural (incluye 0) aleatorio entre 0 y int.MaxValue
            //int numAleNatMin_ = rnd.Next();
            //Console.WriteLine("Número sin cotas: {0}", numAleNatMin_);
            //obj.pause();
            //obj.clear();
            ////obtiene en este caso un numero natural que incluira el 0
            ////es aleatorio entre 0 y 5
            //int numAleNatMax_ = rnd.Next(5);
            //Console.WriteLine("Número entre 0 y 5: {0}", numAleNatMax_);
            //obj.pause();
            //obj.clear();
            ////aqui creare un ejemplo con numeros naturales cual incluye 0 de 4 a 10
            //int numAletNatCort_ = rnd.Next(4, 10);
            //Console.WriteLine("Numero entre 4 y 10: {0}", numAletNatCort_);
            //obj.pause();
            //obj.clear();
            functions obj = new functions();
            Random rnd = new Random();
            int n1, n2;
            Console.WriteLine("Digite el primer número: ");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite el segundo número: ");
            n2 = Convert.ToInt32(Console.ReadLine());

            int numAletMin_ = n1;
            int numAletMax_ = n2;

            int PROCESSALTMIN_ = rnd.Next(numAletMin_, numAletMax_);

            Console.WriteLine("El número entre {0} y {1} es: {2}", n1, n2, PROCESSALTMIN_);
            obj.pause();
        }
    }
}