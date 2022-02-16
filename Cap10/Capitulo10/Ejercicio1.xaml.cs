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
        Ejercicio 1 : Crear el diseño de una clase para llevar el inventario de una tienda.
    */
    public partial class Ejercicio1 : Window
      {
           public Ejercicio1()
        {            
            InitializeComponent(); 
        }    
         class Inventario
        {
            public int codigo;
            public string producto;
            public string descripcion;
            public int existencia;

            public Inventario(int c, string p, string d, int e)
            {
                codigo = c;
                producto = p;
                descripcion = d;
                existencia = e;
            }

            public override String ToString()
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendFormat($"Codigo: {codigo}       Nombre del Producto: {producto}       Descripcion: {descripcion}       Existencia: {existencia}");
                return sb.ToString();
            }
        }
        private void Datos_Click(object sender, RoutedEventArgs e)
        {
               Inventario inventario = new Inventario(Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox($"Codigo del producto: ", "Codigo del Producto", " ", 50, 0)),
               Microsoft.VisualBasic.Interaction.InputBox($"Nombre del producto: ", "Nombre del Producto", " ", 50, 0),
               Microsoft.VisualBasic.Interaction.InputBox($"Descripcion del producto: ", "Descripcion del Producto", " ", 50, 0),
               Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox($"Existencia del producto: ", "Existencia del Producto", " ", 50, 0)));

               DatosInventario.Items.Add(inventario.ToString());
        }
    }
}