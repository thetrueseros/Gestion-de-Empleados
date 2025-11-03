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
        public double bonificacion { get; set; }
        public Gerente(string nombre, double salarioBase,string tipo, double bonificacion)
        {
            this.nombre = nombre;
            this.salarioBase = salarioBase;
            this.tipo = tipo;
            this.bonificacion = bonificacion;
        }
        public override double CalcularSalario()
        {
            if (salarioBase > 5000000)
            {
                MessageBox.Show("El salario base excede el límite para pago de bonificación, " +
                    "por lo que su salario final será solo su salario base.", "Aviso", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return salarioBase;
            }
            return salarioBase + bonificacion;
        }
    }
}
