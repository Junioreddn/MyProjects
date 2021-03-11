using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Mail;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Xml;

namespace Eployex
{
    class Menu : Program
    {
        public static int des = 5;
        public static int desEm = 5;
        public static int cant;
        public static List<Empleado> Lista = new List<Empleado>();
        public static List<TiempoComplt> ListaCompl = new List<TiempoComplt>();
        public static List<MedioTiempo> ListaSemi = new List<MedioTiempo>();
        public static List<Temporero> ListaTemp = new List<Temporero>();
        static string name;
        static string code;
        public static int num;
     

        public static void Menus()
        {

              int cont = 1;
            //Menu de opciones

            do
            {

                try
                {
                    do
                    {
                        Console.WriteLine();
                        Console.WriteLine("                                               *--Menu--*");
                        Console.WriteLine();
                        Console.WriteLine("Seleccione uno de los numeros de la lista de opciones");
                        Console.WriteLine();
                        Console.WriteLine("Que desea hacer? ");
                        Console.WriteLine("1. Crear empleados");
                        Console.WriteLine("2. Borrar empleados");
                        Console.WriteLine("3. Mostrar lista de empleados");
                        Console.WriteLine();
                        Console.WriteLine("0. Seleccione 0 para salir");
                          des = int.Parse(Console.ReadLine());
                        if (des != 1 && des != 2 && des != 3 && des != 0)
                        {
                            Console.WriteLine();
                            Console.WriteLine("Selecciono un numero invalido intentelo denuevo");
                            Thread.Sleep(2000);
                            Console.Clear();
                            titulo();
                            
                        }
                    } while (des != 1 && des != 2 && des != 3 && des != 0);
                    if (des == 1)
                    {
                        do
                        {
                            Console.Clear();
                            titulo();
                            Console.WriteLine("Cuantos clientes desea crear?");
                            cant = int.Parse(Console.ReadLine());
                            if(cant < 1) 
                            {
                                Console.WriteLine($"No se puede crear {cant} cantidad de empleados!!");
                                Thread.Sleep(1000);
                            }
                        } while (cant < 1);
                        Console.Clear();
                        titulo();
                        for (int i = 1; i <= cant; i++)
                        {
                            

                                
                           num = i;

                            do
                            {


                                do
                                {
                                    //desEm = 5;
                                    if (desEm != 0)
                                    {
                                        try
                                        {
                                            Console.WriteLine("Empleado Numero " + i + " de " + cant);
                                            Console.WriteLine();
                                            Console.WriteLine("                                               *--Menu--*");
                                            Console.WriteLine();
                                            Console.WriteLine("Seleccione uno de los numeros de la lista de opciones");
                                            Console.WriteLine();
                                            Console.WriteLine("Que tipo de empleado desea crear? ");
                                            Console.WriteLine("1. Empleado de Tiempo Completo");
                                            Console.WriteLine("2. Empleado de Medio Tiempo");
                                            Console.WriteLine("3. Empleado de Temporero");
                                            Console.WriteLine();
                                            Console.WriteLine("0. Seleccione 0 para salir");

                                            desEm = int.Parse(Console.ReadLine());
                                            if (desEm != 1 && desEm != 2 && desEm != 3 && desEm != 0)
                                            {
                                                Console.WriteLine();
                                                Console.WriteLine("Selecciono un numero invalido intentelo denuevo");
                                                Thread.Sleep(2000);
                                                Console.Clear();
                                                titulo();
                                            }
                                          
                                        }
                                        catch
                                        {
                                            Console.WriteLine();
                                            Console.WriteLine("Error... Eso es invalido intentelo denuevo");
                                            desEm = 5;
                                            Thread.Sleep(2000);
                                            Console.Clear();
                                            titulo();
                                        }


                                    }
                                  
                                } while (desEm != 1 && desEm != 2 && desEm != 3 && desEm != 0);

                                if (desEm != 3 && desEm != 0)
                                {
                                    TypePay();
                                }


                                //la aplicacion solicitando los datos del empleado
                                if (desEm != 0)
                                {
                                    Console.Clear();
                                    titulo();



                                 



                                    if (desEm == 1 )
                                    {
                                        TiempoComplt emplComp = new TiempoComplt();
                                        emplComp.id();
                                        Lista.Add(emplComp);
                                        ListaCompl.Add(emplComp);
                                        name = emplComp.nombre;
                                        code = emplComp.codigo;
                                    }
                                    else if (desEm == 2)
                                    {
                                        MedioTiempo emplMed = new MedioTiempo();
                                        emplMed.id();
                                        Lista.Add(emplMed);
                                        ListaSemi.Add(emplMed);
                                        name = emplMed.nombre;
                                        code = emplMed.codigo;
                                    }
                                    else if (desEm == 3)
                                    {
                                        Temporero tempor = new Temporero();
                                        tempor.id();
                                        Lista.Add(tempor);
                                        ListaTemp.Add(tempor);
                                        name = tempor.nombre;
                                        code = tempor.codigo;
                                    }

                                }
                                Console.Clear();
                                titulo();
                                Console.WriteLine();

                                        
                            } while (desEm != 1 && desEm != 2 && desEm != 3 && desEm !=0 );
                            if (desEm == 0)
                            {
                                i = cant;
                            }

                        }

                        
                    }else if (des == 2)
                    {
                        //TiempoComplt emplCom = new TiempoComplt();
                       
                        Console.Clear();
                        titulo();
                       
                        string pic = "";
                        do
                        {
                            
                            string d = Lista.Count(x => x.nombre == name).ToString();
                            string c = Lista.Count(x => x.codigo == code).ToString();
                            Temporero tempor = new Temporero();
                            MedioTiempo emplMed = new MedioTiempo();
                            TiempoComplt tiempoCom = new TiempoComplt();
                            Console.Clear();
                            titulo();
                           // Console.WriteLine(d);
                            if (Lista.Capacity == 0 || Lista.Capacity == 4 && d == "0" && c == "0" )
                            {
                                Console.WriteLine();
                                Console.WriteLine("                   /-------NO EXISTEN EMPLEADOS EN ESTA LISTA, NADA QUE ELIMINAR------/");
                                Console.WriteLine();
                                Console.WriteLine();
                                Console.WriteLine();
                                Console.WriteLine("Presione cualquier tecla para salir. . .");
                                Console.ReadKey();
                                pic = "0";
                            }
                            else
                            {
                                Console.WriteLine("                                            --EMPLEADOS LISTADOS--");

                                foreach (Empleado completo in Lista)
                                {



                                    Console.WriteLine();
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.WriteLine("Nombre: " + completo.nombre);
                                    Console.ForegroundColor = ConsoleColor.Blue;
                                    Console.WriteLine("Codigo: " + completo.codigo);
                                    Console.ResetColor();
                                    Console.WriteLine("--------------------------------");


                                }

                                Console.WriteLine();
                                Console.WriteLine("                                              *--Opciones--*");
                                Console.WriteLine();
                                Console.WriteLine("Desea eliminar por Nombre o por Codigo?");
                                Console.WriteLine("1. NOMBRE");
                                Console.WriteLine("2. CODIGO");
                                Console.WriteLine("3. ELIMINAR TODO EMPLEADO EN LA LISTA");
                                Console.WriteLine();
                                Console.WriteLine("0. Salir al menu");
                                pic = Console.ReadLine();
                                if (pic == "1")
                                {
                                    Console.WriteLine("Press ENTER Si Desea Regresar. . .");
                                    Console.WriteLine();
                                    Console.WriteLine("NOMBRE del Empleado que desea eliminar?");
                                    name = Console.ReadLine();
                                    d = Lista.Count(x => x.nombre == name).ToString();




                                    if (d == "1")
                                    {

                                        Lista.RemoveAll(x => x.nombre == name);
                                        Console.WriteLine($"Empleado con el Nombre {name.ToUpper()} Eliminado Satisfactoriamente!!");
                                        Thread.Sleep(2000);
                                        Console.Clear();
                                        titulo();
                                    }
                                    else if (name == "" && d == "0")
                                    {

                                        Console.Clear();
                                        titulo();

                                    }
                                    else
                                    {
                                        Console.WriteLine($"NO SE ENCONTRARON RESULTADOS EN LA BUSQUEDA DEL NOMBRE {name} ");
                                        Thread.Sleep(1500);
                                        Console.Clear();
                                        titulo();

                                    }


                                }
                                else if (pic == "2")
                                {
                                    Console.WriteLine("Press ENTER para Regresar. . .");
                                    Console.WriteLine();
                                    Console.WriteLine("CODIGO del Empleado que desea eliminar?");
                                    name = Console.ReadLine();
                                    d = Lista.Count(x => x.codigo == name).ToString();
                                    if (d == "1")
                                    {
                                        Lista.RemoveAll(x => x.codigo == name);
                                        Console.WriteLine($"Empleado con el codigo {name.ToUpper()} Eliminado Satisfactoriamente!!");
                                        Thread.Sleep(2000);
                                        Console.Clear();
                                        titulo();
                                    }
                                    else if (name == "" && d == "0")
                                    {

                                        Console.Clear();
                                        titulo();

                                    }
                                    else
                                    {
                                        Console.WriteLine($"NO SE ENCONTRARON RESULTADOS EN LA BUSQUEDA DEL CODIGO {name} ");
                                        Thread.Sleep(1500);
                                        Console.Clear();
                                        titulo();

                                    }
                                }
                                else if (pic == "3")
                                {
                                    string rev = "";
                                    Console.Clear();
                                    titulo();
                                    Console.WriteLine("                   /-------NO EXISTEN EMPLEADOS EN ESTA LISTA, NADA QUE ELIMINAR------/");
                                    Console.WriteLine();
                                    Console.WriteLine();
                                    Console.WriteLine("                                              *--Opciones--*");
                                    Console.WriteLine();
                                    Console.WriteLine("Desea eliminar por Nombre o por Codigo?");
                                    Console.WriteLine("1. NOMBRE");
                                    Console.WriteLine("2. CODIGO");
                                    Console.WriteLine("3. ELIMINAR TODO EMPLEADO EN LA LISTA");
                                    Console.WriteLine();
                                    Console.WriteLine("0. Salir al menu");
                                    Console.WriteLine(pic);
                                    Console.WriteLine($"Lista Eliminada Satisfactoriamente!!");
                                    Thread.Sleep(2000);
                                    Console.WriteLine("Press 1 para revertir los cambios. . .");
                                    Console.WriteLine("Press enter para salir");

                                    rev = Console.ReadLine();

                                    if (rev == "1")
                                    {
                                        Console.WriteLine("Cambios Revertidos!!");
                                        Thread.Sleep(1000);


                                    }
                                    else
                                    {
                                        Lista.Clear();
                                        titulo();
                                        pic = "0";
                                    }
                                    Console.Clear();
                                    titulo();
                                }
                                else if (pic == "0")
                                {
                                    Console.WriteLine();
                                    Console.WriteLine("Saliendo. . . ");
                                    Thread.Sleep(400);
                                }
                                else
                                {
                                    Console.WriteLine("Opcion no Valida!!");
                                    Thread.Sleep(1000);
                                    Console.Clear();
                                    titulo();
                                }


                            }

                            

                        } while (pic != "0");


                    }
                    else if (des == 3)
                    {
                        Temporero tempor = new Temporero();
                        MedioTiempo emplMed = new MedioTiempo();
                        TiempoComplt tiempoCom = new TiempoComplt();
                        Console.Clear();
                        titulo();
                        int pic = 5;
                        string d = Lista.Count(x => x.nombre == name).ToString();
                        string c = Lista.Count(x => x.codigo == code).ToString();
                 
                        Console.WriteLine();

                        if (Lista.Capacity == 0 || Lista.Capacity == 4 && d == "0" && c == "0")
                        {
                            Console.WriteLine("                              /-------NO EXISTEN EMPLEADOS EN ESTA LISTA------/");
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine("Presione cualquier tecla para salir. . .");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        else
                        {
                            do
                            {
                                try
                                {
                               

                                    Console.WriteLine("                                            --LISTAS CLASIFICADAS--");
                                    Console.WriteLine();
                                    Console.WriteLine("                                                *--Opciones--*");
                                    Console.WriteLine();
                                    Console.WriteLine("Seleccione que lista desea ver");
                                    Console.WriteLine();
                                    Console.WriteLine("1. LISTA GENERAL");
                                    Console.WriteLine("2. LISTA EMPLEADO TIEMPO COMPLETO");
                                    Console.WriteLine("3. LISTA EMPLEADO MEDIO TIEMPO");
                                    Console.WriteLine("4. LISTA EMPLEADO TEMPORERO");
                                    Console.WriteLine();
                                    Console.WriteLine("0. Salir al menu");
                                    pic = int.Parse(Console.ReadLine());
                                    
                                    switch (pic)
                                    {
                                        case 1:
                                            if (Lista.Capacity == 0 || Lista.Capacity == 4 && d == "0" && c == "0")
                                            {
                                                Console.Clear();
                                                titulo();

                                                Console.WriteLine("                              /-------NO EXISTEN EMPLEADOS EN ESTA LISTA------/");
                                                Console.WriteLine();
                                                Console.WriteLine();
                                                Console.WriteLine();
                                                Console.WriteLine("Presione cualquier tecla para salir. . .");
                                                Console.ReadKey();
                                                Console.Clear();
                                                pic = 5;
                                                titulo();
                                            }
                                            else
                                            {
                                                Console.Clear();
                                                titulo();


                                                Console.WriteLine();

                                                Console.WriteLine("                                               --EMPLEADOS LISTADOS--");
                                                cont = 1;
                                                foreach (Empleado completo in Lista)
                                                {

                                                    Console.WriteLine("EMPLEADO NUMERO " + cont);
                                                    Console.WriteLine();
                                                    completo.Ponchar();
                                                    Console.WriteLine("------------------------------------------------------");
                                                    Console.WriteLine();
                                                    completo.Trabajar();
                                                    Console.WriteLine("------------------------------------------------------");
                                                    Console.WriteLine();
                                                    completo.Cobrar();
                                                    Console.WriteLine("------------------------------------------------------");
                                                    Console.WriteLine();
                                                    cont++;

                                                }
                                                Console.WriteLine();
                                                Console.WriteLine("Presione cualquier tecla para salir. . .");
                                                Console.ReadKey();
                                                Console.Clear();
                                                pic = 5;
                                                titulo();
                                            }


                                            break;

                                        case 2:
                                            if (ListaCompl.Capacity == 0 || ListaCompl.Capacity == 4 && d == "0" && c == "0")
                                            {
                                                Console.Clear();
                                                titulo();


                                                Console.WriteLine("                              /-------NO EXISTEN EMPLEADOS EN ESTA LISTA------/");
                                                Console.WriteLine();
                                                Console.WriteLine();
                                                Console.WriteLine();
                                                Console.WriteLine("Presione cualquier tecla para salir. . .");
                                                Console.ReadKey();
                                                Console.Clear();
                                                pic = 5;
                                                titulo();
                                            }
                                            else
                                            {
                                                Console.Clear();
                                                titulo();


                                                Console.WriteLine();
                                                cont = 1;
                                                Console.WriteLine("                                         --EMPLEADOS DE TIEMPO COMPLETO--");

                                                foreach (Empleado completo in ListaCompl)
                                                {

                                                    Console.WriteLine("EMPLEADO NUMERO " + cont);
                                                    Console.WriteLine();
                                                    completo.Ponchar();
                                                    Console.WriteLine("------------------------------------------------------");
                                                    Console.WriteLine();
                                                    completo.Trabajar();
                                                    Console.WriteLine("------------------------------------------------------");
                                                    Console.WriteLine();
                                                    completo.Cobrar();
                                                    Console.WriteLine("------------------------------------------------------");
                                                    Console.WriteLine();
                                                    cont++;

                                                }
                                                Console.WriteLine();
                                                Console.WriteLine("Presione cualquier tecla para salir. . .");
                                                Console.ReadKey();
                                                Console.Clear();
                                                pic = 5;
                                                titulo();

                                            }

                                            break;
                                        case 3:
                                            if (ListaSemi.Capacity == 0 || ListaSemi.Capacity == 4 && d == "0" && c == "0")
                                            {
                                                Console.Clear();
                                                titulo();


                                                Console.WriteLine("                              /-------NO EXISTEN EMPLEADOS EN ESTA LISTA------/");
                                                Console.WriteLine();
                                                Console.WriteLine();
                                                Console.WriteLine();
                                                Console.WriteLine("Presione cualquier tecla para salir. . .");
                                                Console.ReadKey();
                                                Console.Clear();
                                                titulo();
                                                pic = 5;
                                            }
                                            else
                                            {
                                                Console.Clear();
                                                titulo();


                                                Console.WriteLine();
                                                cont = 1;
                                                Console.WriteLine("                                         --EMPLEADOS DE MEDIO TIEMPO --");

                                                foreach (Empleado completo in ListaSemi)
                                                {

                                                    Console.WriteLine("EMPLEADO NUMERO " + cont);
                                                    Console.WriteLine();
                                                    completo.Ponchar();
                                                    Console.WriteLine("------------------------------------------------------");
                                                    Console.WriteLine();
                                                    completo.Trabajar();
                                                    Console.WriteLine("------------------------------------------------------");
                                                    Console.WriteLine();
                                                    completo.Cobrar();
                                                    Console.WriteLine("------------------------------------------------------");
                                                    Console.WriteLine();
                                                    cont++;

                                                }
                                                Console.WriteLine();
                                                Console.WriteLine("Presione cualquier tecla para salir. . .");
                                                Console.ReadKey();
                                                Console.Clear();
                                                titulo();
                                                pic = 5;

                                            }
                                            break;
                                        case 4:
                                            if (ListaTemp.Capacity == 0 || ListaTemp.Capacity == 4 && d == "0" && c == "0")
                                            {
                                                Console.Clear();
                                                titulo();


                                                Console.WriteLine("                              /-------NO EXISTEN EMPLEADOS EN ESTA LISTA------/");
                                                Console.WriteLine();
                                                Console.WriteLine();
                                                Console.WriteLine();
                                                Console.WriteLine("Presione cualquier tecla para salir. . .");
                                                Console.ReadKey();
                                                Console.Clear();
                                                pic = 5;
                                                titulo();
                                            }
                                            else
                                            {
                                                Console.Clear();
                                                titulo();


                                                Console.WriteLine();
                                                cont = 1;
                                                Console.WriteLine("                                          --EMPLEADOS TEMPOREROS--");

                                                foreach (Empleado completo in ListaTemp)
                                                {

                                                    Console.WriteLine("EMPLEADO NUMERO " + cont);
                                                    Console.WriteLine();
                                                    completo.Ponchar();
                                                    Console.WriteLine("------------------------------------------------------");
                                                    Console.WriteLine();
                                                    completo.Trabajar();
                                                    Console.WriteLine("------------------------------------------------------");
                                                    Console.WriteLine();
                                                    completo.Cobrar();
                                                    Console.WriteLine("------------------------------------------------------");
                                                    Console.WriteLine();
                                                    cont++;

                                                }
                                                Console.WriteLine();
                                                Console.WriteLine("Presione cualquier tecla para salir. . .");
                                                Console.ReadKey();
                                                Console.Clear();
                                                pic = 5;
                                                titulo();

                                            }
                                            break;
                                        case 0:
                                            Console.Clear();
                                            titulo();

                                            break;
                                        default:
                                            Console.WriteLine();
                                            Console.WriteLine("OPCION NO VALIDA!!");
                                            Thread.Sleep(1000);
                                            Console.Clear();
                                            titulo();
                                            break;

                                    }
                                }
                                catch (Exception)
                                {
                                    Console.WriteLine();
                                    Console.WriteLine("ERROR... ESO NO ES VALIDO!!");
                                    Thread.Sleep(1000);
                                    Console.Clear();
                                    titulo();
                                    pic = 5;

                                }
                            } while (pic != 0 && pic != 1 && pic != 2 && pic != 3 && pic != 4);
                           

                        }
                        

                    }
                    else if (des == 0)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Saliendo. . . ");
                        Thread.Sleep(1000);
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine();
                    Console.WriteLine("Error... Eso es invalido intentelo denuevo");
       
                    des = 5;
                
                    Thread.Sleep(1000);
                    Console.Clear();
                    titulo();
                }
                Console.Clear();
                titulo();
                   

            } while (des != 0 );
           
        }
    }
}
