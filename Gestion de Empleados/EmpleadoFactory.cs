using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_de_Empleados
{
    public class EmpleadoFactory
    {
        public static Empleado CrearEmpleado(string tipo, string nombre, double salarioBase, double extra)
        {
            try
            {
                switch (tipo)
                {
                    case "Gerente":
                        return new Gerente(salarioBase, extra);
                    case "Programador":
                        return new Programador(salarioBase, extra);
                    default:
                        throw new ArgumentException("Tipo de empleado no reconocido.");
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show("Error al crear el empleado: " + ex.Message, "¡Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
    }
}