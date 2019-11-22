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
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace Empleados
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private Ventanita.Ventana ventana;
        public MainWindow()
        {
            InitializeComponent();
            dataGrid.ItemsSource = Employee.GetEmployees();
       
            
        }

       

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Employee employe = new Employee();
            ventana = new Ventanita.Ventana(employe);
            ventana.NewEmployee += (o) =>
            {
                Employee.GetEmployees().Add(o);
            };
            ventana.Show();
            
        }


    }
}
