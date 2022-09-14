using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppSuperAutos
{
    public class Vehiculo
    {
      public string Marca;
       public string Modelo;
       public string tipo;
       public int precio;
       public string color;
       public string combustible;
        public int año;

        public void marca()
        {

            Console.Write("Marca:");

        }

        public void Tipo()
        {
            Console.Write("tipo:");

        }

        public void Precio()
        {
            Console.Write("precio:");

        }

        public void Año()
        {
            Console.Write("Año:");

        }

        public void Color()
        {
            Console.Write("Color:");

        }

        public void Combustible()
        {
            Console.Write("Combustible:");

        }

        public void modelo()
        {
            Console.Write("Modelo:");

        }

        public void puertas()
        {
            Console.Write("puertas:");

        }

        public void transmicion()
        {
           Console.Write("transmicion:");

        }

        public void Cilindros()
        {
            Console.Write("Cilindros:");

        }

        public void Acelerar()
        {


        }
        public void frenar()
        {

        }




    };

    public class Auto:Vehiculo
    {
        public int numeroPuertas;
        public string transmicion;

    

    }

    public class moto:Vehiculo
    {
     public string transmicion;
     public int cilindros;

       
    }



 

    
}
