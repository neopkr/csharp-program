﻿using System;

namespace API_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            restart:
            int eleccion;
            functions obj = new functions();
            obj.welcomeMsg();
            obj.clear();
            Console.WriteLine("Username: " + obj.getNombre());
            Console.WriteLine("Seleccione una de estas dos opciones: ");
            Console.WriteLine("1. Calculadora");
            Console.WriteLine("2. Lista Base");
            eleccion = Convert.ToInt32(Console.ReadLine());
            switch (eleccion)
            {
                case 1:
                    Console.WriteLine("Usted a escogido la calculadora");
                    obj.clear();
                    Calculadora calc = new Calculadora();
                    retu:
                    calc.calculadora();
                    int volver;
                    Console.WriteLine("Desea hacer otra operación?");
                    Console.WriteLine("1.- Y");
                    Console.WriteLine("2.- N");
                    volver = Convert.ToInt32(Console.ReadLine());

                    switch (volver)
                    {
                        case 1:
                            functions tmobj = new functions();
                            tmobj.clear();
                            goto retu;
                            break;
                        case 2:
                            functions trobj = new functions();
                            trobj.closeProgram();
                            trobj.clear();
                            break;
                    }
                    break;
                case 2:
                    List lista = new List();
                    Console.WriteLine("Usted a escogido la lista base");
                    obj.clear();
                    lista.baseList();
                    break;
                default: Console.WriteLine("Usted no ha escogido uno de los dos puntos establecidos");
                    goto restart;
            }
        }
    }
}