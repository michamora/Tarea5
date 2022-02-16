using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
   
namespace Cap10.Capitulo10
{
    /// <summary>
    /// Interaction logic for Ejercicio1.xaml
    /// </summary>

    /*
        Ejercicio 2 : Crear una clase para llevar la informacion de los estudiantes de una escuela.
    */
    public partial class Ejercicio2 : Window
      {
           public Ejercicio2()
        {            
            InitializeComponent(); 
        }    
         class Estudiantes
        {
            public int codigo;
            public string nombre;
            public int edad;
            public string grado;
            
            public Estudiantes(int c, string n, int e, string g)
            {
                codigo = c;
                nombre = n;
                edad = e;
                grado = g;
                
            }
            public override String ToString()
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendFormat($"Codigo: {codigo}        Nombre del Estudiante: {nombre}        Edad: {edad}        Grado: {grado}");
                return sb.ToString();
            }
        }
        private void Datos_Click(object sender, RoutedEventArgs e)
        {
                Estudiantes estudiantes = new Estudiantes(Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox($"Codigo del estudiante: ", "Codigo", " ", 50, 0)),
                Microsoft.VisualBasic.Interaction.InputBox($"Nombre del estudiante: ", "Nombre", " ", 40, 0),
                int.Parse(Microsoft.VisualBasic.Interaction.InputBox($"Edad del estudiante: ", "Edad", " ", 40, 0)),
                Microsoft.VisualBasic.Interaction.InputBox($"Grado del estudiante: ", "Grado", " ", 40, 0));
                
                DatosEstudiantes.Items.Add(estudiantes.ToString());
        }
    }
}