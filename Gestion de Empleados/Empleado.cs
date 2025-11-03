using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_de_Empleados
{
    public abstract class Empleado
    {
        public string nombre { get; set; }
        public string tipo { get; set; }
        public double SalarioBase { get; set; }
        /// <summary>
        /// Método double que calcula el salario total del empleado.
        /// </summary>
        /// <returns></returns>
        public abstract double CalcularSalario();
    }
}
