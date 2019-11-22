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

namespace Ventanita
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class Ventana : Window
    {

        public delegate void EventHandler(
         Empleados.Employee e
      );
        private Empleados.Employee empleado;
        private String nombre;
        private String title;
        Boolean isReelected;
       
        public Ventana(Empleados.Employee employee)
        {
            InitializeComponent();
            this.empleado = employee;
            nombre = null;
            title = null;
            isReelected = false;

        }

        public event EventHandler NewEmployee;

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            nombre = tbNombre.Text;
            title = tbTitle.Text;
            isReelected = cbReelected.IsChecked.Value;

            if (nombre != null && title != null) {

                NewEmployee(new Empleados.Employee()
                {
                    Name = nombre,
                    Title = title,
                    WasReElected = isReelected
                } );
            }
        }
        

    }
}
