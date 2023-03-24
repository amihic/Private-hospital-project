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


namespace SIMSKT3
{
    /// <summary>
    /// Interaction logic for Doctor.xaml
    /// </summary>
    public partial class Doctor : Window
    {
        public Doctor()
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
            Appointment win = new Appointment();
            win.Show();
            this.Close();
        }


        private void Button_MedRec(object sender, RoutedEventArgs e)
        {
            MedicalRecords mr = new MedicalRecords();
            mr.Show();
            this.Close();
        }
    }
}
