// Codigo reutilizado de mi otro repositorio, https://github.com/neopkr/Super-Basic-Calculator-CSharp //

using System;

namespace API_Program
{
    class Calculadora
    {
        public void calculadora()
        {

            int seleccion;
            Console.WriteLine("                   Inicio");
            Console.WriteLine("1.- Sumar");
            Console.WriteLine("2.- Resta");
            Console.WriteLine("3.- Multiplicar");
            Console.WriteLine("4.- División");
            Console.WriteLine("5.- Cerrar");
            seleccion = Convert.ToInt32(Console.ReadLine());

            switch (seleccion)
            {
                case 1:
                    sumar();
                    break;
                case 2:
                    restar();
                    break;
                case 3:
                    multiplicar();
                    break;
                case 4:
                    dividir();
                    break;
                case 5:
                    functions obj = new functions();
                    obj.closeProgram();
                    break;
            }
        }
        public void sumar()
        {
            functions obj = new functions();
            double a, b;
            obj.clear();
            Console.Write("Digite el primer valor: ");
            a = Convert.ToDouble(Console.ReadLine());
            obj.clear();
            Console.Write("Digite el segundo valor: ");
            b = Convert.ToDouble(Console.ReadLine());
            obj.clear();
            Console.WriteLine("El resultado de {0} + {1} = {2}", a, b, (a + b));
            Console.ReadKey();
            obj.clear();
        }

        public void restar()
        {
            functions obj = new functions();
            double a, b;
            obj.clear();
            Console.Write("Digite el primer valor: ");
            a = Convert.ToDouble(Console.ReadLine());
            obj.clear();
            Console.Write("Digite el segundo valor: ");
            b = Convert.ToDouble(Console.ReadLine());
            obj.clear();
            Console.WriteLine("El resultado de {0} - {1} = {2}", a, b, (a - b));
            Console.ReadKey();
            obj.clear();
        }


        public void multiplicar()
        {
            functions obj = new functions();
            double a, b;
            obj.clear();
            Console.Write("Digite el primer valor: ");
            a = Convert.ToDouble(Console.ReadLine());
            obj.clear();
            Console.Write("Digite el segundo valor: ");
            b = Convert.ToDouble(Console.ReadLine());
            obj.clear();
            Console.WriteLine("El resultado de {0} * {1} = {2}", a, b, (a * b));
            Console.ReadKey();
            obj.clear();
        }

        public void dividir()
        {
            functions obj = new functions();
            double a, b;
            obj.clear();
            Console.Write("Digite el primer valor: ");
            a = Convert.ToDouble(Console.ReadLine());
            obj.clear();
            Console.Write("Digite el segundo valor: ");
            b = Convert.ToDouble(Console.ReadLine());
            obj.clear();
            Console.WriteLine("El resultado de {0} / {1} = {2}", a, b, (a / b));
            Console.ReadKey();
            obj.clear();
        }
    }
}
