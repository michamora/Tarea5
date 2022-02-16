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
        Ejercicio 3 : Crear una clase para poligonos con sobrecarga del constructor.
    */
    public partial class Ejercicio3 : Window
      {
           public Ejercicio3()
        {            
            InitializeComponent(); 
        }    
         class Poligono
        {
            public int cantidad;
            public int medidas;
            public int angulos;
            public Poligono(int c, int m, int a)
            {
                cantidad = c;
                medidas = m;
                angulos = a;
            }
            public override String ToString()
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendFormat($"Cantidad de lados: {cantidad}        Medidas de lados: {medidas}         Angulos: {angulos}");
                return sb.ToString();
            }
        }
        private void Datos_Click(object sender, RoutedEventArgs e)
        {
                Poligono poligono = new Poligono(Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox($"Cantidad de lados: ", "Lados", " ", 50, 0)),
                Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox($"Medidas de lados: ", "Medidas", " ", 50, 0)),
                Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox($"Angulos: ", "Angulo", " ", 50, 0)));
                
                Poligonos.Items.Add(poligono.ToString());
        }
    }
}