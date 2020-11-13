using System;
namespace API_Program
{
    public class functions 
    {
        public string nombre;
        public functions()
        {

        }   
        public void clear()
        {
            Console.Clear();
        }

        public void pause()
        {
            Console.ReadLine();
        }
        public void setNombre(string nombre)
        {
            this.nombre = nombre;
        }
        public String getNombre()
        {
            return nombre;
        }

        public void welcomeMsg()
        {
            functions obj = new functions();
            Console.WriteLine("Bienvenido a este programa!, por favor digite su nombre a continuacion: ");
            obj.setNombre(Console.ReadLine());
            Console.WriteLine("Username: " + obj.getNombre());
            obj.pause();
        }
        public void closeProgram()
        {
            Console.WriteLine("Hasta Luego!");
            Console.ReadKey();
            Environment.Exit(0);
        }

        public void cambio(int e, int t)
        {
            functions obj = new functions();
            if (e >= t)
            {
                int cambio = e - t;
                Console.WriteLine("Ha Compleado el pago con exito, Devolucion: $" + cambio); ;
                obj.pause();
            }
            else
            {
                Console.WriteLine("El monto ingresado no es suficiente.");
                obj.pause();
            }
        }
    }
}
