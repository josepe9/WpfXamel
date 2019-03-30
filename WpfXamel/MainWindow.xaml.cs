using System.Windows;
using WpfXamel.Vistas;

namespace WpfXamel
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
               
        private void Ventana1(object sender, RoutedEventArgs e)
        {
            Window1 ven1 = new Window1();
            ven1.Show();
        }

        private void Ventana2(object sender, RoutedEventArgs e)
        {
            Window2 ven2 = new Window2();
            ven2.Show();
        }
    }
}
