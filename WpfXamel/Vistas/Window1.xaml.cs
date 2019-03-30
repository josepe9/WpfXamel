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

namespace WpfXamel.Vistas
{
    /// <summary>
    /// Lógica de interacción para Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void Calcular(object sender, RoutedEventArgs e)
        {
            int n1 = Convert.ToInt32(Numero1.Text);
            int n2 = Convert.ToInt32(Numero2.Text);
            int res = n1 + n2;
            MessageBox.Show("El resultado es: " + res);
        }
    }
}
