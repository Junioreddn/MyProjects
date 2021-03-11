using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Eployex
{
    class TiempoComplt : Empleado
    {
        private static string typePay;


        public static new string TypePay
        {
            get
            {
                return typePay;
            }
            set
            {
                if (value == "")
                {

                    Console.WriteLine("Como no selecciono ninguna opcion Valida y por pertenecer a la empresa, se le pagara por Cuenta Bancaria");
                    typePay = "  Cuenta Bancaria.";
                    Thread.Sleep(2000);
                }
                else if (value == "1")
                {

                    typePay = " cheque.";
                }
                else if (value == "2")
                {

                    typePay = " Cuenta Bancaria.";
                }
                else
                {
                    Console.WriteLine("Como no selecciono ninguna opcion Valida y por pertenecer a la empresa, se le pagara por Cuenta Bancaria");
                    typePay = "  Cuenta Bancaria.";
                    Thread.Sleep(2000);

                }
            }
        }

        public void id()
        {
            Console.WriteLine("Empleado Numero " + Menu.num + " de " + Menu.cant);
            Console.WriteLine();
            Console.WriteLine("Cual es el nombre del empleado?");
            nombre = Console.ReadLine();
            Console.WriteLine("Cual es su codigo?");
            codigo = Console.ReadLine();
            while (codigo == "" || codigo == " " || codigo == "  " || codigo == "   " || codigo == "    " || codigo == "     ")
            {
                Console.WriteLine("ALMENOS EL CODIGO ES REQUERIDO!!");
                Thread.Sleep(2000);
                Console.Clear();
                titulo();
                Console.WriteLine("Empleado Numero " + Menu.num + " de " + Menu.cant);
                Console.WriteLine();
                Console.WriteLine("Cual es el nombre del empleado?");
                Console.WriteLine(nombre);
                Console.WriteLine("Cual es su codigo?");
                codigo = Console.ReadLine();
            }
            Console.WriteLine("En que departamento labora?");
            department = Console.ReadLine();
            Console.WriteLine("Cual es su cargo?");
            cargo = Console.ReadLine();

            do
            {
                try
                {
                    precioxhr = 0;
                    Console.WriteLine("Cuantas horas a laborado?");
                    horalab = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("precio por hora?");
                    precioxhr = Convert.ToInt32(Console.ReadLine());
                    if (horalab < 0)
                    {
                        Console.WriteLine("Eso no es posible");

                    }
                }
                catch (SystemException)
                {

                    Console.WriteLine();
                    Console.WriteLine("Eso no es Correcto, intente de nuevo!!");
                    Thread.Sleep(1000);
                    Console.Clear();
                    titulo();
                    Console.WriteLine("Empleado Numero " + Menu.num + " de " + Menu.cant);
                    Console.WriteLine();
                    Console.WriteLine("Cual es el nombre del empleado?");
                    Console.WriteLine(nombre);
                    Console.WriteLine("Cual es su codigo?");
                    Console.WriteLine(codigo);
                    Console.WriteLine("En que departamento labora?");
                    Console.WriteLine(department);
                    Console.WriteLine("Cual es su cargo?");
                    Console.WriteLine(cargo);
                }
            } while (precioxhr < 1);



        }




        public override void Ponchar()
        {

            Console.WriteLine($"                                          /---Datos del empleado {nombre.ToUpper()}---/");

            Console.WriteLine();
            var fecha = DateTime.Now;
            Console.Write("Nombre: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(nombre);
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Codigo: " + codigo);
            Console.ResetColor();
            Console.WriteLine(fecha);
            Console.WriteLine("Departamento laboral actual: " + department);
            Console.WriteLine("Cargo : " + cargo);

        }
        public override void Trabajar()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("-EMPLEADO DE TIEMPO COMPLETO-");
            Console.ResetColor();
            Console.WriteLine("Trabajando!!..   ");
        }
        public override void Cobrar()
        {
            // ConsoleColor[] colors = (ConsoleColor[])ConsoleColor.GetValues(typeof(ConsoleColor));
            // Save the current background and foreground colors.




            salario = horalab * precioxhr;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("-EMPLEADO DE TIEMPO COMPLETO-");
            Console.ResetColor();
            Console.Write("su salario calculado es de ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write($"RD$" + salario);
            Console.ResetColor();
            Console.Write(" pesos");
            Console.WriteLine();
            Console.WriteLine("Cobrara por " + TypePay);
        }

        
        

    }
}
