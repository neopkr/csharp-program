using System;

namespace API_Program
{
    class List
    {
        public void baseList()
        {
            functions obj = new functions();
            int subEleccion;
            int eleccion;
            int Item1 = 1;
            int Item2 = 2;
            int Item3 = 3;
            int Item4 = 4;
            Console.WriteLine("Seleccione los Items que desea");
            Console.WriteLine("1.- Item 1");
            Console.WriteLine("2.- Item 2");
            Console.WriteLine("3.- Item 3");
            Console.WriteLine("4.- Item 4");
            eleccion = Convert.ToInt32(Console.ReadKey());

            switch (eleccion)
            {
                case 1:
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
                            Console.WriteLine("Total  ................... ") + total;
                            if (entrada == total)
                            {
                                Console.WriteLine("Ha Compleado el pago con exito");
                            } else
                            {
                                Console.WriteLine("El monto ingresado no es suficiente.");
                                goto pay1;
                            }
                        } else if (subOp == 3)
                        {
                        pay2:
                            int entrada1;
                            int total1 = Item3 + Item1;
                            Console.WriteLine("Usted a elegido el Item 3, desea elegir otro item? (1. Y, 2. N");
                            Console.WriteLine("Total a pagar: ");
                            Console.WriteLine("Item 1 ................... " + Item1);
                            Console.WriteLine("Item 3 ................... " + Item3);
                            Console.WriteLine("Total  ................... ") + total1;
                            if (entrada1 == total1)
                            {
                                Console.WriteLine("Ha Compleado el pago con exito");
                            }
                            else
                            {
                                Console.WriteLine("El monto ingresado no es suficiente.");
                                goto pay2;
                            } else if (subOp == 4)
                            {
                            pay3:
                                int entrada2;
                                int total2 = Item4 + Item1;
                                Console.WriteLine("Usted a elegido el Item 4, desea elegir otro item? (1. Y, 2. N");
                                Console.WriteLine("Total a pagar: ");
                                Console.WriteLine("Item 1 ................... " + Item1);
                                Console.WriteLine("Item 4 ................... " + Item4);
                                Console.WriteLine("Total  ................... ") + total2;
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
                            else if (subEleccion == 2)
                            {
                                int subtOp;
                                int subtOp2;
                                int subtOp3;
                                int subtOp4;
                                obj.clear();
                                Console.WriteLine("Que otro item desea?");
                                Console.WriteLine("1.- Item 1");
                                Console.WriteLine("2.- Item 2 - Elegido");
                                Console.WriteLine("3.- Item 3");
                                Console.WriteLine("4.- Item 4");
                                subtOp = Convert.ToInt32(Console.ReadLine());
                                if (subtOp == 1)
                                {
                                payt1:
                                    int entradat;
                                    int totalt = Item1 + Item2;
                                    Console.WriteLine("Usted a elegido el Item 2, desea elegir otro item? (1. Y, 2. N");
                                    Console.WriteLine("Total a pagar: ");
                                    Console.WriteLine("Item 1 ................... " + Item1);
                                    Console.WriteLine("Item 2 ................... " + Item2);
                                    Console.WriteLine("Total  ................... ") + totalt;
                                    if (entradat == totalt)
                                    {
                                        Console.WriteLine("Ha Compleado el pago con exito");
                                    }
                                    else
                                    {
                                        Console.WriteLine("El monto ingresado no es suficiente.");
                                        goto payt1;
                                    }
                                }
                                else if (subtOp == 3)
                                {
                                payt2:
                                    int entradat1;
                                    int totalt1 = Item3 + Item2;
                                    Console.WriteLine("Usted a elegido el Item 3, desea elegir otro item? (1. Y, 2. N");
                                    Console.WriteLine("Total a pagar: ");
                                    Console.WriteLine("Item 2 ................... " + Item2);
                                    Console.WriteLine("Item 3 ................... " + Item3);
                                    Console.WriteLine("Total  ................... ") + totalt1;
                                    if (entradat1 == totalt1)
                                    {
                                        Console.WriteLine("Ha Compleado el pago con exito");
                                    }
                                    else
                                    {
                                        Console.WriteLine("El monto ingresado no es suficiente.");
                                        goto payt2;
                                    } else if (subtOp == 4)
                                    {
                                    payt3:
                                        int entradat2;
                                        int totalt2 = Item4 + Item2;
                                        Console.WriteLine("Usted a elegido el Item 4, desea elegir otro item? (1. Y, 2. N");
                                        Console.WriteLine("Total a pagar: ");
                                        Console.WriteLine("Item 2 ................... " + Item2);
                                        Console.WriteLine("Item 4 ................... " + Item4);
                                        Console.WriteLine("Total  ................... ") + totalt2;
                                        if (entradat2 == totalt2)
                                        {
                                            Console.WriteLine("Ha Compleado el pago con exito");
                                        }
                                        else
                                        {
                                            Console.WriteLine("El monto ingresado no es suficiente.");
                                            goto payt3;
                                        }
                                    }
                                }
                            else if (subEleccion == 3)
                            {

                            }
                            else if (subEleccion == 4)
                            {

                            } 
                    break;
            }
        }
    }
}