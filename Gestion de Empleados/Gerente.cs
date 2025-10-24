using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_de_Empleados
{
    public class Gerente : Empleado
    {
        public double Bonificacion { get; set; }
        public Gerente(double salarioBase, double bonificacion)
        {
            SalarioBase = salarioBase;
            Bonificacion = bonificacion;
        }
        public override double CalcularSalario()
        {
            return SalarioBase + Bonificacion;
        }
    }
}
