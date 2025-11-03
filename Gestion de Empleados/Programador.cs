using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_de_Empleados
{
    public class Programador : Empleado
    {
        public double HorasExtra { get; set; }
        public Programador(double salarioBase, string tipo, double horasExtra)
        {
            SalarioBase = salarioBase;
            this.tipo = tipo;
            HorasExtra = horasExtra;
        }
        public override double CalcularSalario()
        {
            if (SalarioBase > 2500000)
            {
                MessageBox.Show("El salario base excede el límite para pago de horas extra.");
                return SalarioBase; // No se pagan horas extra si el salario base es mayor a 2,500,000
            }
            else
            {
                return SalarioBase + (HorasExtra * 20); // Suponiendo que cada hora extra vale 20 unidades monetarias
            }
                
        }
    }
}
