using System;

namespace MyApplication
{
  class Program
  {
    static void carros(string[] args)
    {
      var carros = new string[4, 2]{
      	{"toyota","azul"},
        {"honda","rojo"},
        {"nisan","verde"},
        {"jeep","amarrillo"}
        
        };
        Console.WriteLine(carros[1, 0]);
      Console.WriteLine(carros[1, 1]);
    }
  }
}