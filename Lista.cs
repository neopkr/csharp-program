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
                    if (subOp == 2)
                    {
                    pay1:
                        int entrada;
                        int total = Item1 + Item2;
                        Console.WriteLine("Usted a elegido el Item 2, desea elegir otro item? (1. Y, 2. N)");
                        Console.WriteLine("Total a pagar: ");
                        Console.WriteLine("Item 1 ................... $"+Item1);
                        Console.WriteLine("Item 2 ................... $"+ Item2);
                        Console.WriteLine("Total  ................... $"+ total);
                        Console.WriteLine("Monto a pagar: ");
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
                    }
                    else if (subOp == 3)
                    {
                    pay2:
                        int entrada1;
                        int total1 = Item3 + Item1;
                        Console.WriteLine("Usted a elegido el Item 3, desea elegir otro item? (1. Y, 2. N)");
                        Console.WriteLine("Total a pagar: ");
                        Console.WriteLine("Item 1 ................... $"+ Item1);
                        Console.WriteLine("Item 3 ................... $"+ Item3);
                        Console.WriteLine("Total  ................... $"+ total1);
                        entrada1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Monto a pagar: ");
                        if (entrada1 == total1)
                        {
                            Console.WriteLine("Ha Compleado el pago con exito");
                        }
                        else
                        {
                            Console.WriteLine("El monto ingresado no es suficiente.");
                            goto pay2;
                        }
                    }
                    else if (subOp == 4)
                    {
                    pay3:
                        int entrada2;
                        int total2 = Item4 + Item1;
                        Console.WriteLine("Usted a elegido el Item 4, desea elegir otro item? (1. Y, 2. N)");
                        Console.WriteLine("Total a pagar: ");
                        Console.WriteLine("Item 1 ................... $"+ Item1);
                        Console.WriteLine("Item 4 ................... $"+ Item4);
                        Console.WriteLine("Total  ................... $"+ total2);
                        entrada2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Monto a pagar: ");
                        if (entrada2 == total2)
                        {
                            Console.WriteLine("Ha Compleado el pago con exito");
                        }
                        else
                        {
                            Console.WriteLine("El monto ingresado no es suficiente.");
                            goto pay3;
                        }
                    }

                    break;

                case 2:

                    break;
                    

            }  
                      
        }
    }
}