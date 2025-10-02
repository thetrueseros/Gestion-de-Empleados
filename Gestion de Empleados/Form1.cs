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

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbTipoEmpleado.Items.Add("Gerente");
            cmbTipoEmpleado.Items.Add("Programador");
            cmbTipoEmpleado.SelectedIndex = 0;
        }


        private void btnCargarEmpleado_Click(object sender, EventArgs e)
        {
            string nombre = txtNombreEmpleado.Text;
            double salario = double.Parse(txtbSalarioBase.Text);
            double extras = double.Parse(txtbHorasExtra.Text);
            string tipoEmpleado = cmbTipoEmpleado.SelectedItem.ToString();
        }
    }
}
