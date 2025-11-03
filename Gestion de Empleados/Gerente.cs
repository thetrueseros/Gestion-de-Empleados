using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            if (SalarioBase > 5000000)
            {
                MessageBox.Show("El salario base excede el límite para pago de bonificación, " +
                    "por lo que su salario final será solo su salario base.", "Aviso", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return SalarioBase;
            }
            return SalarioBase + Bonificacion;
        }
    }
}
