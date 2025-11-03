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
        public double horasExtra { get; set; }
        public Programador(string nombre, double salarioBase, string tipo, double horasExtra)
        {
            this.nombre = nombre;
            this.salarioBase = salarioBase;
            this.tipo = tipo;
            this.horasExtra = horasExtra;
        }
        public override double CalcularSalario()
        {
            if (salarioBase > 2500000)
            {
                MessageBox.Show("El salario base excede el límite para pago de horas extra.");
                return salarioBase; // No se pagan horas extra si el salario base es mayor a 2,500,000
            }
            else
            {
                return salarioBase + (horasExtra * 20); // Suponiendo que cada hora extra vale 20 unidades monetarias
            }
                
        }
    }
}
