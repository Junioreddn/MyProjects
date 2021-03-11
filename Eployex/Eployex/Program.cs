using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Tracing;
using System.Threading;

namespace Eployex
{
    class Program
    {
        //Metodos 
    
        public static void TypePay()
        {
            Console.WriteLine("--Seleccione su forma de cobro digitando uno de los numeros acontinuacion--");
            Console.WriteLine("1- cobro por Cheque ");
            Console.WriteLine("2- cobro por Cuenta Bancaria ");
            Console.WriteLine();
            Console.WriteLine("Si no selecciona una opcion valida se le asignara un medio de pago segun el tipo de empleado que sea.");
            if (Menu.desEm == 1)
            {
                TiempoComplt.TypePay = Console.ReadLine();
            }
            else if (Menu.desEm == 2)
            {
                MedioTiempo.TypePay = Console.ReadLine();
            }
           
            Console.WriteLine();
        }
        public static void titulo()
        {
            Console.WriteLine("*--------------------------------------------------------------------------------------------------------*");
            Console.WriteLine("              Consulta y registro de operaciones de gestion de empleados en la organizacion.     ");
            Console.WriteLine("*--------------------------------------------------------------------------------------------------------*");
            Console.WriteLine();
        }
       
        static void Main(string[] args)
        {

            //Instancio mis objetos tipo empleado
          
            titulo();
            Menu.Menus();
            Console.Clear();
            titulo();
            Console.WriteLine("---------------😉👌¡¡GRACIAS POR SU ATENCION!!😆👍-----------------");
     
        }
    }
}   




