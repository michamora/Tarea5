using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;

namespace Cap12.Capitulo12
{
    /// <summary>
    /// Interaction logic for Ejercicio1.xaml
    /// </summary>
   
    /*
        Ejercicio 2 : Utilizar el metodo WriteLine() de la clase Debug
        para que las funciones nos indiquen cuando entramos y salimos de ellas.
    */
    public partial class Ejercicio2 : Window
      {
           public Ejercicio2()
        {            
            InitializeComponent(); 
        }    
       
        private void VerificarButton_Click(object sender, RoutedEventArgs e)
        {
            int factorial = 1;
            int numero = int.Parse(Numero.Text);
            for (int i = numero; i >= 1; i--)
            {
                Console.WriteLine("Entro");
                factorial *= i;
                Console.WriteLine("Salio, y Factorial es en la entrada" + i + factorial);
            }
            MessageBox.Show($"El factorial de {numero} es {factorial}");
        }
    }
}