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

    public partial class SecretaryUpdate : Window
    {
        string b;
        PatientController patientController = new PatientController();

        public SecretaryUpdate()
        {
            InitializeComponent();
        }

        private void Button_ClickClear(object sender, RoutedEventArgs e)
        {
            Textbox11.Text = " ";
            Textbox22.Text = " ";
            Textbox66.Text = " ";
            Textbox33.Text = " ";
            Textbox44.Text = " ";
            Textbox55.Text = " ";

        }

        private void Button_ClickBack(object sender, RoutedEventArgs e)
        {
            PatientAccountCRUD patient = new PatientAccountCRUD();
            patient.Show();
            this.Hide();
        }

        private void Button_ClickUpdate(object sender, RoutedEventArgs e)
        {
            Patient patt = new Patient(Convert.ToInt32(Textbox11.Text),
                                                        Textbox22.Text,
                                                        Textbox66.Text,
                                                        Textbox33.Text,
                                                        Textbox44.Text,
                                                        Textbox55.Text


                );
            patientController.UpdatePatientAccount(patt);
            MessageBox.Show("Patient account is updated so you can go back!");
            /*List<PatientAccount> patients = JsonConvert.DeserializeObject<List<PatientAccount>>(File.ReadAllText("patients.json"));
            foreach (var patient in patients)
            {
                if (patient.id.Equals(Textbox11.Text))
                {
                    patient.id = Convert.ToInt32(Textbox11.Text);
                    patient.name = Textbox22.Text;
                    patient.jmbg = Textbox66.Text;
                    patient.surname = Textbox33.Text;
                    patient.age = Textbox44.Text;
                    patient.phoneNumber = Textbox55.Text;

                }
            }
            string json = JsonConvert.SerializeObject(patients, Formatting.Indented);
            File.WriteAllText("patients.json", json);
            MessageBox.Show("Patient account is updated so you can go back!");*/
        }
        public void prebaci(string a)
        {
            b = a.ToString();
            Textbox11.Text = a.ToString();
        }


    }
}

