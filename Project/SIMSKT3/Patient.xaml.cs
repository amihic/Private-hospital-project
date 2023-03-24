using System;
using System.Collections.Generic;
using System.IO;
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
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Classes.Model;

namespace SIMSKT3
{
    /// <summary>
    /// Interaction logic for Patient.xaml
    /// </summary>
    public partial class Patient : Window
    {
        public Patient()
        {
            InitializeComponent();
        }

        private void Button_ClickBack(object sender, RoutedEventArgs e)
        {
            MainWindow win = new MainWindow();
            win.Show();
            this.Close();
        }
        private void Button_ClickAppointment(object sender, RoutedEventArgs e)
        {
            AppointmentPatient win = new AppointmentPatient();
            win.Show();
            this.Close();
        }

        private void Button_ClickNotification(object sender, RoutedEventArgs e)
        {
            Notifications win = new Notifications();
            win.Show();
            this.Close();
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
