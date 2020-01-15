using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            // The client code.
            Conexion s1 = Conexion.GetConexion();
            Conexion s2 = Conexion.GetConexion();

            if (s1 == s2)
            {
                Console.WriteLine("Singleton works, both variables contain the same instance.");
            }
            else
            {
                Console.WriteLine("Singleton failed, variables contain different instances.");
            }

            Console.ReadLine();
        }
    }
}
