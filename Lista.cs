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
                    payt1:
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
                        if (entradat1 == totalt1)
                        {
                            Console.WriteLine("Ha Compleado el pago con exito");
                        }
                        else
                        {
                            Console.WriteLine("El monto ingresado no es suficiente.");
                            goto payt2;
                        }
                    }
                    else if (subtOp == 4)
                    {
                    payt3:
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
                    payta1:
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
                        if (entradata == totalta)
                        {
                            Console.WriteLine("Ha Compleado el pago con exito");
                        }
                        else
                        {
                            Console.WriteLine("El monto ingresado no es suficiente.");
                            goto payta1;
                        }
                    }
                    else if (subtaOp == 2)
                    {
                    payta2:
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
                        if (entrada1ta == total1ta)
                        {
                            Console.WriteLine("Ha Compleado el pago con exito");
                        }
                        else
                        {
                            Console.WriteLine("El monto ingresado no es suficiente.");
                            goto payta2;
                        }
                    }
                    else if (subtaOp == 4)
                    {
                    payta3:
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
                        if (entrada2ta == total2ta)
                        {
                            Console.WriteLine("Ha Compleado el pago con exito");
                        }
                        else
                        {
                            Console.WriteLine("El monto ingresado no es suficiente.");
                            goto payta3;
                        }
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
                    paytate1:
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
                        if (entradatate == totaltate)
                        {
                            Console.WriteLine("Ha Compleado el pago con exito");
                        }
                        else
                        {
                            Console.WriteLine("El monto ingresado no es suficiente.");
                            goto paytate1;
                        }
                    }
                    else if (subtateOp == 2)
                    {
                    paytate2:
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
                        if (entrada1tate == total1tate)
                        {
                            Console.WriteLine("Ha Compleado el pago con exito");
                        }
                        else
                        {
                            Console.WriteLine("El monto ingresado no es suficiente.");
                            goto paytate2;
                        }
                    }
                    else if (subtateOp == 3)
                    {
                    paytate3:
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
                        if (entrada2tate == total2tate)
                        {
                            Console.WriteLine("Ha Compleado el pago con exito");
                        }
                        else
                        {
                            Console.WriteLine("El monto ingresado no es suficiente.");
                            goto paytate3;
                        }
                    }

                    break;
            }  
                      
        }
    }
}