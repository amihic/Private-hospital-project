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
using Classes.Model;

namespace SIMSKT3
{
    public partial class MedicalRecords : Window
    {
        public MedicalRecords()
        {
            InitializeComponent();
        }

        private void Button_ClickBack(object sender, RoutedEventArgs e)
        {
            OptionsSecretary secretary = new OptionsSecretary();
            secretary.Show();
            this.Close();
        }

        private void Button_ClickAppointmentPatient(object sender, RoutedEventArgs e)
        {
            /*AppointmentPatient win = new AppointmentPatient();
            win.Show();
            this.Close();*/
        }

        private void Button_ManageAllergens(object sender, RoutedEventArgs e)
        {
            ManageAllergens manage = new ManageAllergens();
            manage.Show();
            this.Close();
        }

        private void Button_Anamnesis(object sender, RoutedEventArgs e)
        {
            //Anamnesis anamnesis = new Anamnesis();
            //anamnesis.Show();
            //this.Close();
        }

        private void Button_Prescriptions(object sender, RoutedEventArgs e)
        {

        }
<<<<<<< Updated upstream
        //private void Button_Prescriptions(object sender, RoutedEventArgs e)
        ////{
        ////    Prescription prescription = new Prescription();
        ////    prescription.Show();
        ////    this.Close();
        //}
=======
        private void Button_Prescriptions(object sender, RoutedEventArgs e)
        {
            Prescription prescription = new Prescription();
            prescription.Show();
            this.Close();
        }
>>>>>>> Stashed changes
    }
}




