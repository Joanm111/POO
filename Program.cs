using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppSuperAutos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s1 = null;
            
            do
            {
                Console.WriteLine("\n\nbienvenido, que tipo de vehiculo busca \n" +
                    "\n1.- Autos" +
                    "\n2.- Motos" +
                    "\n3.- filtrar por marca" +
                    "\n4.- Salir\n");
                s1 = Console.ReadLine();

                switch (s1)
                {
                    case "1":
                        Console.Clear();
                        
                        Auto carro = new Auto();
                        Console.Write("\n******** Nissan Rogue S 2016 **********\n\n");
                        carro.marca();
                        Console.Write(carro.Marca = "Nisaan\n");
                        carro.modelo();
                        Console.Write(carro.Modelo = "Rogue S 2016 \n");
                        carro.Tipo();
                        Console.Write(carro.tipo = "Auto\n");
                        carro.Año();
                        Console.Write(carro.año = 2016);
                        Console.Write("\n");
                        carro.Color();
                        Console.Write(carro.color = "negro\n");
                        carro.Combustible();
                        Console.Write(carro.combustible = "gasolina\n");
                        carro.transmicion();
                        Console.Write(carro.transmicion = "automatica\n");
                        carro.puertas();
                        Console.Write(carro.numeroPuertas = 4);
                        Console.Write("\n");
                        carro.Precio();
                        Console.Write(carro.precio = 18000);
                        Console.Write("\n");

                        Auto carro1 = new Auto();
                        Console.Write("\n******** Mercedes-Benz Clase GLA 250 4 Matic 2015 **********\n\n");
                        carro.marca();
                        Console.Write(carro.Marca = "Mercedes-Benz\n");
                        carro.modelo();
                        Console.Write(carro.Modelo = "GLA 250 4 Matic \n");
                        carro.Tipo();
                        Console.Write(carro.tipo = "Auto\n");
                        carro.Año();
                        Console.Write(carro.año = 2015);
                        Console.Write("\n");
                        carro.Color();
                        Console.Write(carro.color = "gris plata\n");
                        carro.Combustible();
                        Console.Write(carro.combustible = "gasolina\n");
                        carro.transmicion();
                        Console.Write(carro.transmicion = "automatica\n");
                        carro.puertas();
                        Console.Write(carro.numeroPuertas = 4);
                        Console.Write("\n");
                        carro.Precio();
                        Console.Write(carro.precio = 28000);
                        Console.Write("\n");

                        Auto carro2 = new Auto();
                        Console.Write("\n******** Chevrolet Tahoe LTZ 2016 **********\n\n");
                        carro.marca();
                        Console.Write(carro.Marca = "Chevrolet\n");
                        carro.modelo();
                        Console.Write(carro.Modelo = "Tahoe LTZ \n");
                        carro.Tipo();
                        Console.Write(carro.tipo = "Auto\n");
                        carro.Año();
                        Console.Write(carro.año = 2016);
                        Console.Write("\n");
                        carro.Color();
                        Console.Write(carro.color = "negro\n");
                        carro.Combustible();
                        Console.Write(carro.combustible = "gasolina\n");
                        carro.transmicion();
                        Console.Write(carro.transmicion = "automatica\n");
                        carro.puertas();
                        Console.Write(carro.numeroPuertas = 4);
                        Console.Write("\n");
                        carro.Precio();
                        Console.Write(carro.precio = 46000);
                        Console.Write("\n");

                        Auto carro3 = new Auto();
                        Console.Write("\n******** Lexus RX 350 F Sport 2017 **********\n\n");
                        carro.marca();
                        Console.Write(carro.Marca = "Lexus\n");
                        carro.modelo();
                        Console.Write(carro.Modelo = "RX 350 F Sport \n");
                        carro.Tipo();
                        Console.Write(carro.tipo = "Auto\n");
                        carro.Año();
                        Console.Write(carro.año = 2017);
                        Console.Write("\n");
                        carro.Color();
                        Console.Write(carro.color = "negro\n");
                        carro.Combustible();
                        Console.Write(carro.combustible = "gasolina\n");
                        carro.transmicion();
                        Console.Write(carro.transmicion = "automatica\n");
                        carro.puertas();
                        Console.Write(carro.numeroPuertas = 4);
                        Console.Write("\n");
                        carro.Precio();
                        Console.Write(carro.precio = 53000);
                        Console.Write("\n");

                        Auto carro4 = new Auto();
                        Console.Write("\n******** Toyota 4 Runner Limited 2014 **********\n\n");
                        carro.marca();
                        Console.Write(carro.Marca = "Toyota\n");
                        carro.modelo();
                        Console.Write(carro.Modelo = "4 Runner Limited \n");
                        carro.Tipo();
                        Console.Write(carro.tipo = "Auto\n");
                        carro.Año();
                        Console.Write(carro.año = 2014);
                        Console.Write("\n");
                        carro.Color();
                        Console.Write(carro.color = "blanco perla\n");
                        carro.Combustible();
                        Console.Write(carro.combustible = "gasolina\n");
                        carro.transmicion();
                        Console.Write(carro.transmicion = "automatica\n");
                        carro.puertas();
                        Console.Write(carro.numeroPuertas = 4);
                        Console.Write("\n");
                        carro.Precio();
                        Console.Write(carro.precio = 35000);
                        Console.Write("\n");

                        Auto carro5 = new Auto();
                        Console.Write("\n******** Toyota Hilux Rocco 2022 **********\n\n");
                        carro.marca();
                        Console.Write(carro.Marca = "Toyota\n");
                        carro.modelo();
                        Console.Write(carro.Modelo = "Hilux Rocco\n");
                        carro.Tipo();
                        Console.Write(carro.tipo = "Auto\n");
                        carro.Año();
                        Console.Write(carro.año = 2022);
                        Console.Write("\n");
                        carro.Color();
                        Console.Write(carro.color = "negro\n");
                        carro.Combustible();
                        Console.Write(carro.combustible = "gasolina\n");
                        carro.transmicion();
                        Console.Write(carro.transmicion = "automatica\n");
                        carro.puertas();
                        Console.Write(carro.numeroPuertas = 4);
                        Console.Write("\n");
                        carro.Precio();
                        Console.Write(carro.precio = 72000);
                        Console.Write("\n");

                        Auto carro6 = new Auto();
                        Console.Write("\n******** Mercedes-Benz Clase C 300 AMG 2018 **********\n\n");
                        carro.marca();
                        Console.Write(carro.Marca = "Mercedez-Benz\n");
                        carro.modelo();
                        Console.Write(carro.Modelo = "C 300 AMG \n");
                        carro.Tipo();
                        Console.Write(carro.tipo = "Auto\n");
                        carro.Año();
                        Console.Write(carro.año = 2018);
                        Console.Write("\n");
                        carro.Color();
                        Console.Write(carro.color = "negro\n");
                        carro.Combustible();
                        Console.Write(carro.combustible = "gasolina\n");
                        carro.transmicion();
                        Console.Write(carro.transmicion = "automatica\n");
                        carro.puertas();
                        Console.Write(carro.numeroPuertas = 4);
                        Console.Write("\n");
                        carro.Precio();
                        Console.Write(carro.precio = 38000);
                        Console.Write("\n");

                        Auto carro7 = new Auto();
                        Console.Write("\n******** Honda CR-V EX 2017 **********\n\n");
                        carro.marca();
                        Console.Write(carro.Marca = "Honda\n");
                        carro.modelo();
                        Console.Write(carro.Modelo = "CR-V EX \n");
                        carro.Tipo();
                        Console.Write(carro.tipo = "Auto\n");
                        carro.Año();
                        Console.Write(carro.año = 2017);
                        Console.Write("\n");
                        carro.Color();
                        Console.Write(carro.color = "naranja\n");
                        carro.Combustible();
                        Console.Write(carro.combustible = "gasolina\n");
                        carro.transmicion();
                        Console.Write(carro.transmicion = "automatica\n");
                        carro.puertas();
                        Console.Write(carro.numeroPuertas = 4);
                        Console.Write("\n");
                        carro.Precio();
                        Console.Write(carro.precio = 29000);
                        Console.Write("\n");

                        Auto carro8 = new Auto();
                        Console.Write("\n******** Mercedes-Benz Clase GLE 53 4matic Coupe AMG Plus 2021**********\n\n");
                        carro.marca();
                        Console.Write(carro.Marca = "Mercedes-Benz\n");
                        carro.modelo();
                        Console.Write(carro.Modelo = "GLE 53 \n");
                        carro.Tipo();
                        Console.Write(carro.tipo = "Auto\n");
                        carro.Año();
                        Console.Write(carro.año = 2021);
                        Console.Write("\n");
                        carro.Color();
                        Console.Write(carro.color = "blanco perla\n");
                        carro.Combustible();
                        Console.Write(carro.combustible = "gasolina\n");
                        carro.transmicion();
                        Console.Write(carro.transmicion = "automatica\n");
                        carro.puertas();
                        Console.Write(carro.numeroPuertas = 4);
                        Console.Write("\n");
                        carro.Precio();
                        Console.Write(carro.precio = 158000);
                        Console.Write("\n");

                        Auto carro9 = new Auto();
                        Console.Write("\n******** Honda Accord Touring 2016 **********\n\n");
                        carro.marca();
                        Console.Write(carro.Marca = "Honda\n");
                        carro.modelo();
                        Console.Write(carro.Modelo = "Accord Touring \n");
                        carro.Tipo();
                        Console.Write(carro.tipo = "Auto\n");
                        carro.Año();
                        Console.Write(carro.año = 2016);
                        Console.Write("\n");
                        carro.Color();
                        Console.Write(carro.color = "negro\n");
                        carro.Combustible();
                        Console.Write(carro.combustible = "gasolina\n");
                        carro.transmicion();
                        Console.Write(carro.transmicion = "automatica\n");
                        carro.puertas();
                        Console.Write(carro.numeroPuertas = 4);
                        Console.Write("\n");
                        carro.Precio();
                        Console.Write(carro.precio = 22000);
                        Console.Write("\n");
                        break;

                    case "2":
                        Console.Clear();
                        moto motor = new moto();
                        Console.Write("\n******** Honda Navi 2022 **********\n\n");
                        motor.marca();
                        Console.Write(motor.Marca = "Honda\n");
                        motor.modelo();
                        Console.Write(motor.Modelo = "Navi \n");
                        motor.Tipo();
                        Console.Write(motor.tipo = "Moto\n");
                        motor.Año();
                        Console.Write(motor.año = 2022);
                        Console.Write("\n");
                        motor.Color();
                        Console.Write(motor.color = "rojo\n");
                        motor.Combustible();
                        Console.Write(motor.combustible = "gasolina\n");
                        motor.transmicion();
                        Console.Write(motor.transmicion = "automatica\n");
                        motor.Cilindros();
                        Console.Write(motor.cilindros = 1);
                        Console.Write("\n");
                        motor.Precio();
                        Console.Write(motor.precio = 2000);
                        Console.Write("\n");

                        moto motor1 = new moto();
                        Console.Write("\n******** Honda XR 650 L 2019 **********\n\n");
                        motor.marca();
                        Console.Write(motor.Marca = "Honda\n");
                        motor.modelo();
                        Console.Write(motor.Modelo = "XR 650 L\n");
                        motor.Tipo();
                        Console.Write(motor.tipo = "Moto\n");
                        motor.Año();
                        Console.Write(motor.año = 2019);
                        Console.Write("\n");
                        motor.Color();
                        Console.Write(motor.color = "rojo\n");
                        motor.Combustible();
                        Console.Write(motor.combustible = "gasolina\n");
                        motor.transmicion();
                        Console.Write(motor.transmicion = "automatica\n");
                        motor.Cilindros();
                        Console.Write(motor.cilindros = 1);
                        Console.Write("\n");
                        motor.Precio();
                        Console.Write(motor.precio = 13000);
                        Console.Write("\n");


                        moto motor2 = new moto();
                        Console.Write("\n******** Honda Repsol 2009 **********\n\n");
                        motor.marca();
                        Console.Write(motor.Marca = "Honda\n");
                        motor.modelo();
                        Console.Write(motor.Modelo = "Repsol\n");
                        motor.Tipo();
                        Console.Write(motor.tipo = "Moto\n");
                        motor.Año();
                        Console.Write(motor.año = 2009);
                        Console.Write("\n");
                        motor.Color();
                        Console.Write(motor.color = "azul\n");
                        motor.Combustible();
                        Console.Write(motor.combustible = "gasolina\n");
                        motor.transmicion();
                        Console.Write(motor.transmicion = "automatica\n");
                        motor.Cilindros();
                        Console.Write(motor.cilindros = 2);
                        Console.Write("\n");
                        motor.Precio();
                        Console.Write(motor.precio = 12000);
                        Console.Write("\n");


                        moto motor3 = new moto();
                        Console.Write("\n******** YAMAHA YZF-R1 2021 **********\n\n");
                        motor.marca();
                        Console.Write(motor.Marca = "Yamaha\n");
                        motor.modelo();
                        Console.Write(motor.Modelo = "YZF-R1\n");
                        motor.Tipo();
                        Console.Write(motor.tipo = "Moto\n");
                        motor.Año();
                        Console.Write(motor.año = 2021);
                        Console.Write("\n");
                        motor.Color();
                        Console.Write(motor.color = "azul\n");
                        motor.Combustible();
                        Console.Write(motor.combustible = "gasolina\n");
                        motor.transmicion();
                        Console.Write(motor.transmicion = "automatica\n");
                        motor.Cilindros();
                        Console.Write(motor.cilindros = 1);
                        Console.Write("\n");
                        motor.Precio();
                        Console.Write(motor.precio = 11000);
                        Console.Write("\n");

                        moto motor4 = new moto();
                        Console.Write("\n******** YAMAHA YFZ 450 R Special Edition 2021 **********\n\n");
                        motor.marca();
                        Console.Write(motor.Marca = "Yamaha\n");
                        motor.modelo();
                        Console.Write(motor.Modelo = "YFZ 450 R\n");
                        motor.Tipo();
                        Console.Write(motor.tipo = "Moto\n");
                        motor.Año();
                        Console.Write(motor.año = 2021);
                        Console.Write("\n");
                        motor.Color();
                        Console.Write(motor.color = "azul\n");
                        motor.Combustible();
                        Console.Write(motor.combustible = "gasolina\n");
                        motor.transmicion();
                        Console.Write(motor.transmicion = "automatica\n");
                        motor.Cilindros();
                        Console.Write(motor.cilindros = 2);
                        Console.Write("\n");
                        motor.Precio();
                        Console.Write(motor.precio = 15000);
                        Console.Write("\n");



                        break;

                    case "3":
                        Console.Clear();
                        Console.WriteLine("Escriba la marca que desea buscar\n");
                        string buscar = Console.ReadLine();
                        if (buscar == "Nissan" | buscar == "nissan")
                        {
                            Auto Nissan = new Auto();
                            Console.Write("\n******** Nissan Rogue S 2016 **********\n\n");
                            Nissan.marca();
                            Console.Write(Nissan.Marca = "Nisaan\n");
                            Nissan.modelo();
                            Console.Write(Nissan.Modelo = "Rogue S 2016 \n");
                            Nissan.Tipo();
                            Console.Write(Nissan.tipo = "Auto\n");
                            Nissan.Año();
                            Console.Write(Nissan.año = 2016);
                            Console.Write("\n");
                            Nissan.Color();
                            Console.Write(Nissan.color = "negro\n");
                            Nissan.Combustible();
                            Console.Write(Nissan.combustible = "gasolina\n");
                            Nissan.transmicion();
                            Console.Write(Nissan.transmicion = "automatica\n");
                            Nissan.puertas();
                            Console.Write(Nissan.numeroPuertas = 4);
                            Console.Write("\n");
                            Nissan.Precio();
                            Console.Write(Nissan.precio = 18000);
                            Console.Write("\n");

                        }


                        else if (buscar == "Mercedes" | buscar == "mercedes")

                        {
                            Auto Mercedes = new Auto();
                            Console.Write("\n******** Mercedes-Benz Clase GLA 250 4 Matic 2015 **********\n\n");
                            Mercedes.marca();
                            Console.Write(Mercedes.Marca = "Mercedes-Benz\n");
                            Mercedes.modelo();
                            Console.Write(Mercedes.Modelo = "GLA 250 4 Matic \n");
                            Mercedes.Tipo();
                            Console.Write(Mercedes.tipo = "Auto\n");
                            Mercedes.Año();
                            Console.Write(Mercedes.año = 2015);
                            Console.Write("\n");
                            Mercedes.Color();
                            Console.Write(Mercedes.color = "gris plata\n");
                            Mercedes.Combustible();
                            Console.Write(Mercedes.combustible = "gasolina\n");
                            Mercedes.transmicion();
                            Console.Write(Mercedes.transmicion = "automatica\n");
                            Mercedes.puertas();
                            Console.Write(Mercedes.numeroPuertas = 4);
                            Console.Write("\n");
                            Mercedes.Precio();
                            Console.Write(Mercedes.precio = 28000);
                            Console.Write("\n");

                            Auto Mercedes1 = new Auto();
                            Console.Write("\n******** Mercedes-Benz Clase C 300 AMG 2018 **********\n\n");
                            Mercedes.marca();
                            Console.Write(Mercedes.Marca = "Mercedez-Benz\n");
                            Mercedes.modelo();
                            Console.Write(Mercedes.Modelo = "C 300 AMG \n");
                            Mercedes.Tipo();
                            Console.Write(Mercedes.tipo = "Auto\n");
                            Mercedes.Año();
                            Console.Write(Mercedes.año = 2018);
                            Console.Write("\n");
                            Mercedes.Color();
                            Console.Write(Mercedes.color = "negro\n");
                            Mercedes.Combustible();
                            Console.Write(Mercedes.combustible = "gasolina\n");
                            Mercedes.transmicion();
                            Console.Write(Mercedes.transmicion = "automatica\n");
                            Mercedes.puertas();
                            Console.Write(Mercedes.numeroPuertas = 4);
                            Console.Write("\n");
                            Mercedes.Precio();
                            Console.Write(Mercedes.precio = 38000);
                            Console.Write("\n");

                            Auto Mercedes2 = new Auto();
                            Console.Write("\n******** Mercedes-Benz Clase GLE 53 4matic Coupe AMG Plus 2021**********\n\n");
                            Mercedes.marca();
                            Console.Write(Mercedes.Marca = "Mercedes-Benz\n");
                            Mercedes.modelo();
                            Console.Write(Mercedes.Modelo = "GLE 53 \n");
                            Mercedes.Tipo();
                            Console.Write(Mercedes.tipo = "Auto\n");
                            Mercedes.Año();
                            Console.Write(Mercedes.año = 2021);
                            Console.Write("\n");
                            Mercedes.Color();
                            Console.Write(Mercedes.color = "blanco perla\n");
                            Mercedes.Combustible();
                            Console.Write(Mercedes.combustible = "gasolina\n");
                            Mercedes.transmicion();
                            Console.Write(Mercedes.transmicion = "automatica\n");
                            Mercedes.puertas();
                            Console.Write(Mercedes.numeroPuertas = 4);
                            Console.Write("\n");
                            Mercedes.Precio();
                            Console.Write(Mercedes.precio = 158000);
                            Console.Write("\n");

                        }
                        else if (buscar == "chevrolet" | buscar == " Chevrolet")
                        {
                            Auto Chevrolet = new Auto();
                            Console.Write("\n******** Chevrolet Tahoe LTZ 2016 **********\n\n");
                            Chevrolet.marca();
                            Console.Write(Chevrolet.Marca = "Chevrolet\n");
                            Chevrolet.modelo();
                            Console.Write(Chevrolet.Modelo = "Tahoe LTZ \n");
                            Chevrolet.Tipo();
                            Console.Write(Chevrolet.tipo = "Auto\n");
                            Chevrolet.Año();
                            Console.Write(Chevrolet.año = 2016);
                            Console.Write("\n");
                            Chevrolet.Color();
                            Console.Write(Chevrolet.color = "negro\n");
                            Chevrolet.Combustible();
                            Console.Write(Chevrolet.combustible = "gasolina\n");
                            Chevrolet.transmicion();
                            Console.Write(Chevrolet.transmicion = "automatica\n");
                            Chevrolet.puertas();
                            Console.Write(Chevrolet.numeroPuertas = 4);
                            Console.Write("\n");
                            Chevrolet.Precio();
                            Console.Write(Chevrolet.precio = 46000);
                            Console.Write("\n");


                        }
                        else if (buscar == "Lexus" | buscar == "lexus")
                        {
                            Auto Lexus = new Auto();
                            Console.Write("\n******** Lexus RX 350 F Sport 2017 **********\n\n");
                            Lexus.marca();
                            Console.Write(Lexus.Marca = "Lexus\n");
                            Lexus.modelo();
                            Console.Write(Lexus.Modelo = "RX 350 F Sport \n");
                            Lexus.Tipo();
                            Console.Write(Lexus.tipo = "Auto\n");
                            Lexus.Año();
                            Console.Write(Lexus.año = 2017);
                            Console.Write("\n");
                            Lexus.Color();
                            Console.Write(Lexus.color = "negro\n");
                            Lexus.Combustible();
                            Console.Write(Lexus.combustible = "gasolina\n");
                            Lexus.transmicion();
                            Console.Write(Lexus.transmicion = "automatica\n");
                            Lexus.puertas();
                            Console.Write(Lexus.numeroPuertas = 4);
                            Console.Write("\n");
                            Lexus.Precio();
                            Console.Write(Lexus.precio = 53000);
                            Console.Write("\n");
                        }
                        else if (buscar  == "Toyota" | buscar == "toyota")
                        {
                            Auto Toyota = new Auto();
                            Console.Write("\n******** Toyota 4 Runner Limited 2014 **********\n\n");
                            Toyota.marca();
                            Console.Write(Toyota.Marca = "Toyota\n");
                            Toyota.modelo();
                            Console.Write(Toyota.Modelo = "4 Runner Limited \n");
                            Toyota.Tipo();
                            Console.Write(Toyota.tipo = "Auto\n");
                            Toyota.Año();
                            Console.Write(Toyota.año = 2014);
                            Console.Write("\n");
                            Toyota.Color();
                            Console.Write(Toyota.color = "blanco perla\n");
                            Toyota.Combustible();
                            Console.Write(Toyota.combustible = "gasolina\n");
                            Toyota.transmicion();
                            Console.Write(Toyota.transmicion = "automatica\n");
                            Toyota.puertas();
                            Console.Write(Toyota.numeroPuertas = 4);
                            Console.Write("\n");
                            Toyota.Precio();
                            Console.Write(Toyota.precio = 35000);
                            Console.Write("\n");

                            Auto Toyota1 = new Auto();
                            Console.Write("\n******** Toyota Hilux Rocco 2022 **********\n\n");
                            Toyota.marca();
                            Console.Write(Toyota.Marca = "Toyota\n");
                            Toyota.modelo();
                            Console.Write(Toyota.Modelo = "Hilux Rocco\n");
                            Toyota.Tipo();
                            Console.Write(Toyota.tipo = "Auto\n");
                            Toyota.Año();
                            Console.Write(Toyota.año = 2022);
                            Console.Write("\n");
                            Toyota.Color();
                            Console.Write(Toyota.color = "negro\n");
                            Toyota.Combustible();
                            Console.Write(Toyota.combustible = "gasolina\n");
                            Toyota.transmicion();
                            Console.Write(Toyota.transmicion = "automatica\n");
                            Toyota.puertas();
                            Console.Write(Toyota.numeroPuertas = 4);
                            Console.Write("\n");
                            Toyota.Precio();
                            Console.Write(Toyota.precio = 72000);
                            Console.Write("\n");

                        }
                        else if (buscar == "Honda" | buscar == "honda")
                        {
                            Auto Honda = new Auto();
                            Console.Write("\n******** Honda Accord Touring 2016 **********\n\n");
                            Honda.marca();
                            Console.Write(Honda.Marca = "Honda\n");
                            Honda.modelo();
                            Console.Write(Honda.Modelo = "Accord Touring \n");
                            Honda.Tipo();
                            Console.Write(Honda.tipo = "Auto\n");
                            Honda.Año();
                            Console.Write(Honda.año = 2016);
                            Console.Write("\n");
                            Honda.Color();
                            Console.Write(Honda.color = "negro\n");
                            Honda.Combustible();
                            Console.Write(Honda.combustible = "gasolina\n");
                            Honda.transmicion();
                            Console.Write(Honda.transmicion = "automatica\n");
                            Honda.puertas();
                            Console.Write(Honda.numeroPuertas = 4);
                            Console.Write("\n");
                            Honda.Precio();
                            Console.Write(Honda.precio = 22000);
                            Console.Write("\n");


                            Auto Honda1 = new Auto();
                            Console.Write("\n******** Honda CR-V EX 2017 **********\n\n");
                            Honda.marca();
                            Console.Write(Honda.Marca = "Honda\n");
                            Honda.modelo();
                            Console.Write(Honda.Modelo = "CR-V EX \n");
                            Honda.Tipo();
                            Console.Write(Honda.tipo = "Auto\n");
                            Honda.Año();
                            Console.Write(Honda.año = 2017);
                            Console.Write("\n");
                            Honda.Color();
                            Console.Write(Honda.color = "naranja\n");
                            Honda.Combustible();
                            Console.Write(Honda.combustible = "gasolina\n");
                            Honda.transmicion();
                            Console.Write(Honda.transmicion = "automatica\n");
                            Honda.puertas();
                            Console.Write(Honda.numeroPuertas = 4);
                            Console.Write("\n");
                            Honda.Precio();
                            Console.Write(Honda.precio = 29000);
                            Console.Write("\n");

                            moto motoR = new moto();
                            Console.Write("\n******** Honda Navi 2022 **********\n\n");
                            motoR.marca();
                            Console.Write(motoR.Marca = "Honda\n");
                            motoR.modelo();
                            Console.Write(motoR.Modelo = "Navi \n");
                            motoR.Tipo();
                            Console.Write(motoR.tipo = "Moto\n");
                            motoR.Año();
                            Console.Write(motoR.año = 2022);
                            Console.Write("\n");
                            motoR.Color();
                            Console.Write(motoR.color = "rojo\n");
                            motoR.Combustible();
                            Console.Write(motoR.combustible = "gasolina\n");
                            motoR.transmicion();
                            Console.Write(motoR.transmicion = "automatica\n");
                            motoR.Cilindros();
                            Console.Write(motoR.cilindros = 1);
                            Console.Write("\n");
                            motoR.Precio();
                            Console.Write(motoR.precio = 2000);
                            Console.Write("\n");

                            moto motoR1 = new moto();
                            Console.Write("\n******** Honda XR 650 L 2019 **********\n\n");
                            motoR.marca();
                            Console.Write(motoR.Marca = "Honda\n");
                            motoR.modelo();
                            Console.Write(motoR.Modelo = "XR 650 L\n");
                            motoR.Tipo();
                            Console.Write(motoR.tipo = "Moto\n");
                            motoR.Año();
                            Console.Write(motoR.año = 2019);
                            Console.Write("\n");
                            motoR.Color();
                            Console.Write(motoR.color = "rojo\n");
                            motoR.Combustible();
                            Console.Write(motoR.combustible = "gasolina\n");
                            motoR.transmicion();
                            Console.Write(motoR.transmicion = "automatica\n");
                            motoR.Cilindros();
                            Console.Write(motoR.cilindros = 1);
                            Console.Write("\n");
                            motoR.Precio();
                            Console.Write(motoR.precio = 13000);
                            Console.Write("\n");


                            moto motoR2 = new moto();
                            Console.Write("\n******** Honda Repsol 2009 **********\n\n");
                            motoR.marca();
                            Console.Write(motoR.Marca = "Honda\n");
                            motoR.modelo();
                            Console.Write(motoR.Modelo = "Repsol\n");
                            motoR.Tipo();
                            Console.Write(motoR.tipo = "Moto\n");
                            motoR.Año();
                            Console.Write(motoR.año = 2009);
                            Console.Write("\n");
                            motoR.Color();
                            Console.Write(motoR.color = "azul\n");
                            motoR.Combustible();
                            Console.Write(motoR.combustible = "gasolina\n");
                            motoR.transmicion();
                            Console.Write(motoR.transmicion = "automatica\n");
                            motoR.Cilindros();
                            Console.Write(motoR.cilindros = 2);
                            Console.Write("\n");
                            motoR.Precio();
                            Console.Write(motoR.precio = 12000);
                            Console.Write("\n");

                        }
                        else if (buscar == "yamaha" | buscar == "Yamaha")
                        {

                            moto yamaha = new moto();
                            Console.Write("\n******** YAMAHA YZF-R1 2021 **********\n\n");
                            yamaha.marca();
                            Console.Write(yamaha.Marca = "Yamaha\n");
                            yamaha.modelo();
                            Console.Write(yamaha.Modelo = "YZF-R1\n");
                            yamaha.Tipo();
                            Console.Write(yamaha.tipo = "Moto\n");
                            yamaha.Año();
                            Console.Write(yamaha.año = 2021);
                            Console.Write("\n");
                            yamaha.Color();
                            Console.Write(yamaha.color = "azul\n");
                            yamaha.Combustible();
                            Console.Write(yamaha.combustible = "gasolina\n");
                            yamaha.transmicion();
                            Console.Write(yamaha.transmicion = "automatica\n");
                            yamaha.Cilindros();
                            Console.Write(yamaha.cilindros = 1);
                            Console.Write("\n");
                            yamaha.Precio();
                            Console.Write(yamaha.precio = 11000);
                            Console.Write("\n");

                            moto yamaha2 = new moto();
                            Console.Write("\n******** YAMAHA YFZ 450 R Special Edition 2021 **********\n\n");
                            yamaha.marca();
                            Console.Write(yamaha.Marca = "Yamaha\n");
                            yamaha.modelo();
                            Console.Write(yamaha.Modelo = "YFZ 450 R\n");
                            yamaha.Tipo();
                            Console.Write(yamaha.tipo = "Moto\n");
                            yamaha.Año();
                            Console.Write(yamaha.año = 2021);
                            Console.Write("\n");
                            yamaha.Color();
                            Console.Write(yamaha.color = "azul\n");
                            yamaha.Combustible();
                            Console.Write(yamaha.combustible = "gasolina\n");
                            yamaha.transmicion();
                            Console.Write(yamaha.transmicion = "automatica\n");
                            yamaha.Cilindros();
                            Console.Write(yamaha.cilindros = 2);
                            Console.Write("\n");
                            yamaha.Precio();
                            Console.Write(yamaha.precio = 15000);
                            Console.Write("\n");
                        }
                        else
                        {
                         Console.Write("no tenemos vehiculos de esta marca \n");
                        }

                        break;

                    case "4":
                        Console.WriteLine("\n vuelva pronto");
                        break;

                    default:
                        Console.WriteLine("selecione una opcion");
                        break;
                        



                }   
            } while (s1 != "4");

           

        }

    }
}
