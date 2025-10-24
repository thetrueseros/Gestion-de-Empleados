using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_de_Empleados
{
    public class Programador : Empleado
    {
        public double HorasExtra { get; set; }
        public Programador(double salarioBase, double horasExtra)
        {
            SalarioBase = salarioBase;
            HorasExtra = horasExtra;
        }
        public override double CalcularSalario()
        {
            return SalarioBase + (HorasExtra * 20); // Suponiendo que cada hora extra vale 20 unidades monetarias
        }
    }
}
