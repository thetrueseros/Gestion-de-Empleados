using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_de_Empleados
{
    public class EmpleadoFactory
    {
        public void CrearEmpleado(string tipo, string nombre, double salarioBase, double extra)
        {
            Empleado empleado = null;
            switch (tipo.ToLower())
            {
                case "Gerente":
                    empleado = new Gerente(salarioBase, extra);
                    break;
                case "Programador":
                    empleado = new Programador(salarioBase, extra);
                    break;
                default:
                    throw new ArgumentException("Tipo de empleado no reconocido.");
            }
        }
    }
}
