using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
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

namespace SIMSKT3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
<<<<<<< HEAD
=======

        private void Button_ClickOptionsDirector(object sender, RoutedEventArgs e)
        {
            //OptionsDirector options = new OptionsDirector();
            //options.Show();
            //this.Close();
        }

        private void Button_ClickDoctor(object sender, RoutedEventArgs e)
        {
            //Doctors doctor = new Doctors();
            //doctor.Show();
            //this.Close();
        }

        private void Button_ClickPatient(object sender, RoutedEventArgs e)
        {
            //Patient patient = new Patient();
            //patient.Show();
            //this.Close();
        }

        private void Button_ClickExit(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Button_ClickOptionsSecretary(object sender, RoutedEventArgs e)
        {
            OptionsSecretary secretary = new OptionsSecretary();
            secretary.Show();
            this.Close();
        }
>>>>>>> fd620a89ab765ad29524f4512b4a532feef65325
    }
}
