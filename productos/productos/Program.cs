using System;

namespace productos
{
    class Promedio
    {
        public static void Main(string[] args)
        {
            string nombre;

            Console.Write("Bienvenido ");

            Console.WriteLine("Por favor ingresa 3 productos");

            Console.Write("Ingresa el precio del primer producto: ");
            string dato = Console.ReadLine();
            int n1 = int.Parse(dato);

            Console.Write("Ingresa el precio del primer producto: ");
            dato = Console.ReadLine();
            int n2 = int.Parse(dato);

            Console.Write("Ingresa el precio del primer producto: ");
            dato = Console.ReadLine();
            int n3 = int.Parse(dato);

            int suma = n1 + n2 + n3;

            if (suma > 100)
            {
                double v = suma * 0.15;
                Console.WriteLine("Su descuento es: " +  v);
            }
            

            Console.WriteLine("El total de su compra es: {0}", suma);
            

            Console.Read();
        }
    }
}
