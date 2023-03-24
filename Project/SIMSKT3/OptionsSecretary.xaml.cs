using Classes.Model;
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
using System.IO;

namespace SIMSKT3
{
    public partial class OptionsSecretary : Window
    {

        //string path = @"C:\Users\rakoc\OneDrive\Desktop\FTN NOVI SAD\SEMESTAR 6\SIMS\SIMS2kt\Patient";


        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public string Jmbg { get; set; }
        public string PhoneNumber { get; set; }

        public OptionsSecretary()
        {
            InitializeComponent();
        }

        private void Button_ClickBack(object sender, RoutedEventArgs e)
        {
            MainWindow win = new MainWindow();
            win.Show();
            this.Close();
        }

        private void Button_PatientAccountCRUD(object sender, RoutedEventArgs e)
        {
            PatientAccountCRUD patient = new PatientAccountCRUD();
            patient.Show();
            this.Hide();
        }

        private void Button_AppointmentOperationCRUD(object sender, RoutedEventArgs e)
        {
            //AppointmentPatient app = new AppointmentPatient();
            //app.Show();
            //this.Hide();
        }

        private void Button_CreateGuestAccount(object sender, RoutedEventArgs e)
        {
            GuestAccountCreate guestAccountCreate = new GuestAccountCreate();
            guestAccountCreate.Show();
            this.Hide();
        }

        private void Button_ManageAllergens(object sender, RoutedEventArgs e)
        {
            MedicalRecords records = new MedicalRecords();
            records.Show();
            this.Hide();
        }

        private void Button_ManageNews(object sender, RoutedEventArgs e)
        {
            NewsBoard news = new NewsBoard();
            news.Show();
            this.Hide();
        }

        private void Button_ManageEmergency(object sender, RoutedEventArgs e)
        {
            EmergencyAppointment emeregency = new EmergencyAppointment();
            emeregency.Show();
            this.Hide();
        }
    }
}

