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
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Classes.Model;
using Classes.Service;
using Classes.Repository;
using Classes.Controller;
using System.IO;

namespace SIMSKT3
{
    public partial class EmergencyAppointment : Window
    {
        string prebaci;
        string prebacaj1;


        EmergencyController emergencyController = new EmergencyController();
        PatientController patientController = new PatientController();

        //private int i=1;

        public EmergencyAppointment()
        {
            InitializeComponent();
        }

        private void Button_ClickBack(object sender, RoutedEventArgs e)
        {
            OptionsSecretary options = new OptionsSecretary();
            options.Show();
            this.Hide();
        }

        public void Button_Choose(object sender, RoutedEventArgs e)
        {
            List<Patient> patients = JsonConvert.DeserializeObject<List<Patient>>(File.ReadAllText("patients.json"));


            int i = 0;
            foreach (var patient in patients)
            {

                if (patient.jmbg.Equals(Textbox6.Text))
                {

                    i = i + 1;
                }
            }

            if (i > 0)
            {
                MessageBox.Show("Patient is chosen!");
                prebaci = Textbox6.Text;
                ChooseDoctor choose_doctor = new ChooseDoctor();
                choose_doctor.prebaci(prebaci.ToString());
                choose_doctor.Show();
                this.Hide();
            }
            else
            {


                MessageBox.Show("Patient does not exist! Create guest account!");
                prebacaj1 = Textbox6.Text;
                GuestAccountCreate guest = new GuestAccountCreate();
                guest.prebacaj(prebacaj1.ToString());
                guest.Show();
                this.Hide();

            }

        }






        private void Button_CreateEmergency(object sender, RoutedEventArgs e)
        {

        }

        private void Button_ClickReadPatient(object sender, RoutedEventArgs e)
        {
            Patient patients = patientController.ReadPatientAccount(Convert.ToInt32(Textbox7.Text));
            lb_emergency.Items.Clear();
            lb_emergency.Items.Add(patients.id + "\t" + patients.name + "\t" + patients.jmbg + "\t" + patients.surname + "\t" + "\t" + patients.age + "\t" + "\t" + "\t" + "\t" + patients.phoneNumber);

            //List<PatientAccount> patients = JsonConvert.DeserializeObject<List<PatientAccount>>(File.ReadAllText("patients.json"));
            //foreach (var patient in patients)
            //{
            //    if (patient.jmbg.Equals(Textbox6.Text))
            //    {
            //        lb_emergency.Items.Clear();
            //        lb_emergency.Items.Add(patient.id + "\t" + patient.name + "\t" + patient.jmbg + "\t" + patient.surname + "\t" + "\t" + "\t" + patient.age + "\t" + "\t" + "\t" + "\t" + patient.phoneNumber);
            //    }
            //}
        }

        private void Button_ClickReadAllPatients(object sender, RoutedEventArgs e)
        {
            lb_emergency.Items.Clear();
            List<Patient> patients = patientController.GetAllPatientAccounts();
            foreach (var patient in patients)
            {
                lb_emergency.Items.Add(patient.id + "\t" + patient.name + "\t" + patient.jmbg + "\t" + patient.surname + "\t" + "\t" + patient.age + "\t" + "\t" + "\t" + "\t" + patient.phoneNumber);

                //lb_emergency.Items.Clear();
                //List<PatientAccount> patients = JsonConvert.DeserializeObject<List<PatientAccount>>(File.ReadAllText("patients.json"));
                //foreach (var patient in patients)
                //{
                //    lb_emergency.Items.Add(patient.id + "\t" + patient.name + "\t" + patient.jmbg + "\t" + patient.surname + "\t" + "\t" + patient.age + "\t" + "\t" + "\t" + "\t" + patient.phoneNumber);
                //}
            }
        }

        private void Button_ClickDeleteEmergency(object sender, RoutedEventArgs e)
        {
            emergencyController.delete(Convert.ToInt32(Textbox7.Text));

        }

        private void Button_ClickBackEmergency(object sender, RoutedEventArgs e)
        {
            OptionsSecretary options = new OptionsSecretary();
            options.Show();
            this.Hide();
        }

        private void Button_ClickClearEmergency(object sender, RoutedEventArgs e)
        {
            Textbox6.Text = " ";
            Textbox7.Text = " ";

        }
    }
}
