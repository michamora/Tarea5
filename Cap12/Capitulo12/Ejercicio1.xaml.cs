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
        Ejercicio 1 : Usar la depuracion paso a paso para observar
        como cambia el valor de la variable en el programa del factorial
    */
    public partial class Ejercicio1 : Window
      {
           public Ejercicio1()
        {            
            InitializeComponent(); 
        }    
        private void VerificarButton_Click(object sender, RoutedEventArgs e)
        {
            int factorial = 1;
            int numero = int.Parse(Numero.Text);
            for (int i = numero; i >= 1; i--)
            {
                factorial *= i;
            }
            MessageBox.Show($"El factorial de {numero} es {factorial}");
        }
        
    }
}