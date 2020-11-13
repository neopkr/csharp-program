using System;

/*
            eleccionL = Convert.ToInt32(Console.ReadKey());
            if (eleccionL == 1)
            {
                Console.WriteLine("Usted a elegido el Item 1, desea elegir otro item? (1. Y, 2. N");
                subEleccion = Convert.ToInt32(Console.ReadLine());
                if (subEleccion == 1)
                {
                    int subOp;
                    int subOp2;
                    int subOp3;
                    int subOp4;
                    obj.clear();
                    Console.WriteLine("Que otro item desea?");
                    Console.WriteLine("1.- Item 1 - Elegido");
                    Console.WriteLine("2.- Item 2");
                    Console.WriteLine("3.- Item 3");
                    Console.WriteLine("4.- Item 4");
                    subOp = Convert.ToInt32(Console.ReadLine());
                    if (subOp == 2)
                    {
                    pay1:
                        int entrada;
                        int total = Item1 + Item2;
                        Console.WriteLine("Usted a elegido el Item 2, desea elegir otro item? (1. Y, 2. N");
                        Console.WriteLine("Total a pagar: ");
                        Console.WriteLine("Item 1 ................... " + Item1);
                        Console.WriteLine("Item 2 ................... " + Item2);
                        Console.WriteLine("Total  ................... " + total);
                        entrada = Convert.ToInt32(Console.ReadLine());
                        if (entrada == total)
                        {
                            Console.WriteLine("Ha Compleado el pago con exito");
                        }
                        else
                        {
                            Console.WriteLine("El monto ingresado no es suficiente.");
                            goto pay1;
                        }

*/
namespace API_Program
{
    class List
    {       
            int eleccionL;
            int Item1 = 1;
            int Item2 = 2;
            int Item3 = 3;
            int Item4 = 4;
        public void baseList()
        {
            functions obj = new functions();

            Console.WriteLine("Seleccione los Items que desea");
            Console.WriteLine("1.- Item 1");
            Console.WriteLine("2.- Item 2");
            Console.WriteLine("3.- Item 3");
            Console.WriteLine("4.- Item 4");
            eleccionL = Convert.ToInt32(Console.ReadLine());
            switch (eleccionL)
            {
                case 1:
                    int subOp;
                    obj.clear();
                    Console.WriteLine("Que otro item desea?");
                    Console.WriteLine("1.- Item 1 - Elegido");
                    Console.WriteLine("2.- Item 2");
                    Console.WriteLine("3.- Item 3");
                    Console.WriteLine("4.- Item 4");
                    subOp = Convert.ToInt32(Console.ReadLine());
                    if (subOp == 2) { 
                        obj.clear();
                        int entrada;
                        int total = Item1 + Item2;
                        Console.WriteLine("Usted a elegido el Item 1, Item 2");
                        Console.WriteLine("Total a pagar: ");
                        Console.WriteLine("Item 1 ................... $"+Item1);
                        Console.WriteLine("Item 2 ................... $"+ Item2);
                        Console.WriteLine("Total  ................... $"+ total);
                        Console.WriteLine("Monto a pagar: ");
                        entrada = Convert.ToInt32(Console.ReadLine());
                        obj.cambio(entrada, total);
                    }
                    else if (subOp == 3)
                    {
                        obj.clear();
                        int entrada1;
                        int total1 = Item3 + Item1;
                        Console.WriteLine("Usted a elegido el Item 1, Item 3");
                        Console.WriteLine("Total a pagar: ");
                        Console.WriteLine("Item 1 ................... $"+ Item1);
                        Console.WriteLine("Item 3 ................... $"+ Item3);
                        Console.WriteLine("Total  ................... $"+ total1);
                        Console.WriteLine("Monto a pagar: ");
                        entrada1 = Convert.ToInt32(Console.ReadLine());
                        obj.cambio(entrada1, total1);
                    }
                    else if (subOp == 4)
                    {
                        obj.clear();
                        int entrada2;
                        int total2 = Item4 + Item1;
                        Console.WriteLine("Usted a elegido el Item1, Item 4");
                        Console.WriteLine("Total a pagar: ");
                        Console.WriteLine("Item 1 ................... $"+ Item1);
                        Console.WriteLine("Item 4 ................... $"+ Item4);
                        Console.WriteLine("Total  ................... $"+ total2);
                        Console.WriteLine("Monto a pagar: ");
                        entrada2 = Convert.ToInt32(Console.ReadLine());
                        obj.cambio(entrada2, total2);
                    }

                    break;

                case 2:
                    int subtOp;
                    obj.clear();
                    Console.WriteLine("Que otro item desea?");
                    Console.WriteLine("1.- Item 1");
                    Console.WriteLine("2.- Item 2 - Elegido");
                    Console.WriteLine("3.- Item 3");
                    Console.WriteLine("4.- Item 4");
                    subtOp = Convert.ToInt32(Console.ReadLine());
                    if (subtOp == 1)
                    {
                        obj.clear();
                        int entradat;
                        int totalt = Item1 + Item2;
                        Console.WriteLine("Usted a elegido el Item 1, Item 2");
                        Console.WriteLine("Total a pagar: ");
                        Console.WriteLine("Item 1 ................... $" + Item1);
                        Console.WriteLine("Item 2 ................... $" + Item2);
                        Console.WriteLine("Total  ................... $" + totalt);
                        Console.WriteLine("Monto a pagar: ");
                        entradat = Convert.ToInt32(Console.ReadLine());
                        obj.cambio(entradat, totalt);
                    }
                    else if (subtOp == 3)
                    {
                        obj.clear();
                        int entradat1;
                        int totalt1 = Item3 + Item2;
                        Console.WriteLine("Usted a elegido el Item 2, Item 3");
                        Console.WriteLine("Total a pagar: ");
                        Console.WriteLine("Item 2 ................... $" + Item2);
                        Console.WriteLine("Item 3 ................... $" + Item3);
                        Console.WriteLine("Total  ................... $" + totalt1);
                        Console.WriteLine("Monto a pagar: ");
                        entradat1 = Convert.ToInt32(Console.ReadLine());
                        obj.cambio(entradat1, totalt1);
                    }
                    else if (subtOp == 4)
                    {
                        obj.clear();
                        int entradat2;
                        int totalt2 = Item4 + Item2;
                        Console.WriteLine("Usted a elegido el Item2, Item 4");
                        Console.WriteLine("Total a pagar: ");
                        Console.WriteLine("Item 2 ................... $" + Item2);
                        Console.WriteLine("Item 4 ................... $" + Item4);
                        Console.WriteLine("Total  ................... $" + totalt2);
                        Console.WriteLine("Monto a pagar: ");
                        entradat2 = Convert.ToInt32(Console.ReadLine());
                        obj.cambio(entradat2, totalt2);
                    }
                    break;

                case 3:
                    int subtaOp;
                    obj.clear();
                    Console.WriteLine("Que otro item desea?");
                    Console.WriteLine("1.- Item 1");
                    Console.WriteLine("2.- Item 2");
                    Console.WriteLine("3.- Item 3 - Elegido");
                    Console.WriteLine("4.- Item 4");
                    subtaOp = Convert.ToInt32(Console.ReadLine());
                    if (subtaOp == 1)
                    {
                        obj.clear();
                        int entradata;
                        int totalta = Item1 + Item3;
                        Console.WriteLine("Usted a elegido el Item 1, Item 3");
                        Console.WriteLine("Total a pagar: ");
                        Console.WriteLine("Item 1 ................... $" + Item1);
                        Console.WriteLine("Item 3 ................... $" + Item3);
                        Console.WriteLine("Total  ................... $" + totalta);
                        Console.WriteLine("Monto a pagar: ");
                        entradata = Convert.ToInt32(Console.ReadLine());
                        obj.cambio(entradata, totalta);
                    }
                    else if (subtaOp == 2)
                    {
                        obj.clear();
                        int entrada1ta;
                        int total1ta = Item3 + Item2;
                        Console.WriteLine("Usted a elegido el Item 3, Item 2");
                        Console.WriteLine("Total a pagar: ");
                        Console.WriteLine("Item 2 ................... $" + Item2);
                        Console.WriteLine("Item 3 ................... $" + Item3);
                        Console.WriteLine("Total  ................... $" + total1ta);
                        Console.WriteLine("Monto a pagar: ");
                        entrada1ta = Convert.ToInt32(Console.ReadLine());
                        obj.cambio(entrada1ta, total1ta);
                    }
                    else if (subtaOp == 4)
                    {
                        obj.clear();
                        int entrada2ta;
                        int total2ta = Item4 + Item3;
                        Console.WriteLine("Usted a elegido el Item3, Item 4");
                        Console.WriteLine("Total a pagar: ");
                        Console.WriteLine("Item 3 ................... $" + Item3);
                        Console.WriteLine("Item 4 ................... $" + Item4);
                        Console.WriteLine("Total  ................... $" + total2ta);
                        Console.WriteLine("Monto a pagar: ");
                        entrada2ta = Convert.ToInt32(Console.ReadLine());
                        obj.cambio(entrada2ta, total2ta);
                    }
                    break;

                case 4:
                    int subtateOp;
                    obj.clear();
                    Console.WriteLine("Que otro item desea?");
                    Console.WriteLine("1.- Item 1");
                    Console.WriteLine("2.- Item 2");
                    Console.WriteLine("3.- Item 3");
                    Console.WriteLine("4.- Item 4 - Elegido");
                    subtateOp = Convert.ToInt32(Console.ReadLine());
                    if (subtateOp == 1)
                    {
                        obj.clear();
                        int entradatate;
                        int totaltate = Item1 + Item4;
                        Console.WriteLine("Usted a elegido el Item 1, Item 4");
                        Console.WriteLine("Total a pagar: ");
                        Console.WriteLine("Item 1 ................... $" + Item1);
                        Console.WriteLine("Item 4 ................... $" + Item4);
                        Console.WriteLine("Total  ................... $" + totaltate);
                        Console.WriteLine("Monto a pagar: ");
                        entradatate = Convert.ToInt32(Console.ReadLine());
                        obj.cambio(entradatate, totaltate);
                    }
                    else if (subtateOp == 2) { 

                        obj.clear();
                        int entrada1tate;
                        int total1tate = Item4 + Item2;
                        Console.WriteLine("Usted a elegido el Item 3, Item 2");
                        Console.WriteLine("Total a pagar: ");
                        Console.WriteLine("Item 2 ................... $" + Item2);
                        Console.WriteLine("Item 4 ................... $" + Item4);
                        Console.WriteLine("Total  ................... $" + total1tate);
                        Console.WriteLine("Monto a pagar: ");
                        entrada1tate = Convert.ToInt32(Console.ReadLine());
                        obj.cambio(entrada1tate, total1tate);
                    }
                    else if (subtateOp == 3)
                    {
                        obj.clear();
                        int entrada2tate;
                        int total2tate = Item4 + Item3;
                        Console.WriteLine("Usted a elegido el Item3, Item 4");
                        Console.WriteLine("Total a pagar: ");
                        Console.WriteLine("Item 3 ................... $" + Item3);
                        Console.WriteLine("Item 4 ................... $" + Item4);
                        Console.WriteLine("Total  ................... $" + total2tate);
                        Console.WriteLine("Monto a pagar: ");
                        entrada2tate = Convert.ToInt32(Console.ReadLine());
                        obj.cambio(entrada2tate, total2tate);
                    }

                    break;
            }  
                      
        }
    }
}