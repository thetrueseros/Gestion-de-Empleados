using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_de_Empleados
{
    public class EmpleadoFactory
    {
        public void CrearEmpleado(string tipo, double salarioBase, double adicional)
        {
            Empleado empleado = null;
            switch (tipo.ToLower())
            {
                case "gerente":
                    empleado = new Gerente(salarioBase, adicional);
                    break;
                case "programador":
                    empleado = new Programador(salarioBase, adicional);
                    break;
                default:
                    throw new ArgumentException("Tipo de empleado no reconocido.");
            }
            Console.WriteLine($"Salario total del {tipo}: {empleado.CalcularSalario()}");
        }
    }
}
