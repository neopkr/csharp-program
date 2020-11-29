using System;
using System.Collections.Generic;
using System.Text;

namespace API_Program
{
    class Randomizer
    {
        public void randomi()
        {
            functions obj = new functions();
            // crear un objeto, utiliza un reloh del sistema para crear una semilla
            Random rnd = new Random();
            //Obtiene un numero natural (incluye 0) aleatorio entre 0 y int.MaxValue
            int numAleNatMin_ = rnd.Next();
            Console.WriteLine("Número sin cotas: {0}", numAleNatMin_);
            obj.pause();
            obj.clear();
            //obtiene en este caso un numero natural que incluira el 0
            //es aleatorio entre 0 y 5
            int numAleNatMax_ = rnd.Next(5);
            Console.WriteLine("Número entre 0 y 5: {0}", numAleNatMax_);
            obj.pause();
            obj.clear();
            //aqui creare un ejemplo con numeros naturales cual incluye 0 de 4 a 10
            int numAletNatCort_ = rnd.Next(4, 10);
            Console.WriteLine("Numero entre 4 y 10: {0}", numAletNatCort_);
            obj.pause();
            obj.clear();
        }
    }
}