using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_de_Empleados
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTipoEmpleado.SelectedItem.ToString() == "Gerente")
            {
                label4.Text = "Bonificación:";
            }
            else
            {
                label4.Text = "Horas Extra:";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbTipoEmpleado.Items.Add("Gerente");
            cmbTipoEmpleado.Items.Add("Programador");
            cmbTipoEmpleado.SelectedIndex = 0;
        }


        private void btnAgregarEmpleado_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbTipoEmpleado.SelectedItem.ToString() == null)
                {
                    throw new ArgumentNullException("Debe seleccionar un tipo de empleado.");
                }
                if (double.Parse(txtbSalarioBase.Text) < 0)
                {
                    throw new ArgumentOutOfRangeException("El salario base no puede ser negativo.");
                }
                if (double.Parse(txtbHorasExtra.Text) < 0)
                {
                    throw new ArgumentOutOfRangeException("Las horas extra/bonificaciones no pueden ser negativas.");
                }
            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show(ex.Message, "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Empleado empleado = EmpleadoFactory.CrearEmpleado(cmbTipoEmpleado.SelectedItem.ToString(), ///tipo empleado
                txtNombreEmpleado.Text, ///nombre
                double.Parse(txtbSalarioBase.Text), ///salario base
                double.Parse(txtbHorasExtra.Text)); ///extras
        }

        private void txtbSalarioBase_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txtbSalarioBase_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbHorasExtra_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbHorasExtra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void btnMostrarEmpleados_Click(object sender, EventArgs e)
        {
            lstEmpleados.Items.Clear();
            EmpleadoRepository.instancia.MostrarEmpleadosEnListBox(lstEmpleados);
        }

    }
}

