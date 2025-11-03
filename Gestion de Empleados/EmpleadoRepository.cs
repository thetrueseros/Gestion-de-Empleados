using Gestion_de_Empleados;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
public class EmpleadoRepository
{
    public static EmpleadoRepository instancia;
    private List<Empleado> empleados = new List<Empleado>();
    private readonly string rutaArchivo = "empleados.txt";

    private EmpleadoRepository()
    {
    }
    public static EmpleadoRepository Instancia
    {
        ///Crea instancia si no la hay
        get
        {
            if (instancia == null)
                instancia = new EmpleadoRepository();
            return instancia;
        }
    }
    /// <summary>
    /// Agrega empleado a la lista y guarda en archivo
    /// </summary>
    /// <param name="emp"></param>
    public void Agregar(Empleado emp)
    {
        empleados.Add(emp);
        Guardar();
    }
    /// <summary>
    /// Muestra la lista de empleados
    /// </summary>
    /// <returns></returns>
    public List<Empleado> Listar()
    {
        return empleados;
    }

    /// <summary>
    /// Guarda los empleados en txt
    /// </summary>
    private void Guardar()
    {
        using (StreamWriter sw = new StreamWriter(rutaArchivo))
        {
            foreach (var e in empleados)
                sw.WriteLine(e.ToString()); // Formato texto plano
        }
    }
    /// <summary>
    /// Carga los empleados desde txt
    /// </summary>
    public void MostrarEmpleadosEnListBox(ListBox lstEmpleados)
    {
        lstEmpleados.Items.Clear();
        if (File.Exists("empleados.txt"))
        {
            var lineas = File.ReadAllLines("empleados.txt");
            foreach (var linea in lineas)
            {
                lstEmpleados.Items.Add(linea);
            }
        }
    }

}
