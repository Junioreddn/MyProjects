using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Eployex
{
    abstract class Empleado:Program
    {
        Menu men = new Menu();
        public string codigo;
        public string nombre = "";
        public string department;
        public string cargo;
        public int horalab;
        public int precioxhr;
        public int salario;
      

        public abstract void Ponchar();
        public abstract void Cobrar();
        public abstract void Trabajar();

    }
}
