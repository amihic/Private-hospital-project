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
    public partial class PatientAccountCRUD : Window
    {
        string prebaci;

        PatientController patientController = new PatientController();


        string b1; //novo
        string b2;
        string b3;
        string b4;



        public PatientAccountCRUD()
        {
            InitializeComponent();
        }

        public void Button_Create(object sender, RoutedEventArgs e)
        {
            Patient pat = new Patient(Convert.ToInt32(Textbox1.Text),
                                                 Textbox2.Text,
                                                 Textbox3.Text,
                                                 Textbox4.Text,
                                                 Textbox5.Text,
                                                 Textbox6.Text);
            patientController.CreatePatientAccount(pat);
            MessageBox.Show("Successfully created patient account!");
            /*StringBuilder sb = new StringBuilder();
            List<PatientAccount> patients = JsonConvert.DeserializeObject<List<PatientAccount>>(File.ReadAllText("patients.json"));
            var patient = new PatientAccount
            {
                id = Textbox1.Text,
                name = Textbox2.Text,
                surname = Textbox3.Text,
                age = Textbox4.Text,
                phoneNumber = Textbox5.Text,
                jmbg = Textbox6.Text

            };
            foreach (var pat in patients)
            {
                sb.Append(pat.id);
                sb.Append(",");
            }
            string a = sb.ToString();
            string[] splited = a.Split(',');

            if (splited.Contains(patient.id))
                MessageBox.Show("ID already exists!");
            else
            {
                patients.Add(patient);
                string json = JsonConvert.SerializeObject(patients, Formatting.Indented);
                File.WriteAllText("patients.json", json);
                MessageBox.Show("Successfully deleted all patients!");
            }*/
        }

        public void Button_ClickClear(object sender, RoutedEventArgs e)
        {
            Textbox1.Text = " ";
            Textbox2.Text = " ";
            Textbox3.Text = " ";
            Textbox4.Text = " ";
            Textbox5.Text = " ";
            Textbox6.Text = " ";

        }

        private void Button_DeleteAll(object sender, RoutedEventArgs e)
        {
            lb_patients.Items.Clear();
            patientController.deleteAll();
            MessageBox.Show("Successfully deleted all patients!");

            /*
            lb_patients.Items.Clear();
            File.WriteAllText("patients.json", String.Empty);
            MessageBox.Show("Successfully deleted all patients!");*/
        }

        private void Button_ClickBack(object sender, RoutedEventArgs e)
        {
            OptionsSecretary options = new OptionsSecretary();
            options.Show();
            this.Hide();
        }

        public void Button_ClickReadAll(object sender, RoutedEventArgs e)
        {
            lb_patients.Items.Clear();
            List<Patient> patients = JsonConvert.DeserializeObject<List<Patient>>(File.ReadAllText("patients.json"));
            foreach (var patient in patients)
            {
                lb_patients.Items.Add(patient.id + "\t" + patient.name + "\t" + patient.jmbg + "\t" + patient.surname + "\t" + "\t" + patient.age + "\t" + "\t" + "\t" + "\t" + patient.phoneNumber);
            }
        }

        private void Button_ClickRead(object sender, RoutedEventArgs e)
        {
            List<Patient> patients = JsonConvert.DeserializeObject<List<Patient>>(File.ReadAllText("patients.json"));
            foreach (var patient in patients)
            {
                if (patient.id.Equals(Textbox1.Text))
                {
                    lb_patients.Items.Clear();
                    lb_patients.Items.Add(patient.id + "\t" + patient.name + "\t" + patient.jmbg + "\t" + patient.surname + "\t" + "\t" + "\t" + patient.age + "\t" + "\t" + "\t" + "\t" + patient.phoneNumber);
                }
            }
        }
        private void Button_ClickDelete(object sender, RoutedEventArgs e)
        {
            patientController.DeletePatientAccount(Convert.ToInt32(Textbox1.Text));

            /*List<PatientAccount> patients = JsonConvert.DeserializeObject<List<PatientAccount>>(File.ReadAllText("patients.json"));
            foreach (var patient in patients.ToList())
            {
                if (patient.id.Equals(Textbox1.Text))
                {
                    patients.Remove(patient);
                }
            }
            string json = JsonConvert.SerializeObject(patients, Formatting.Indented);
            File.WriteAllText("patients.json", json);*/
        }

        private void Button_ClickUpdate(object sender, RoutedEventArgs e)
        {
            prebaci = Textbox1.Text;
            SecretaryUpdate secretary_update = new SecretaryUpdate();
            secretary_update.prebaci(prebaci.ToString());
            secretary_update.Show();
            this.Hide();


        }


        public void prebaci1(string a)
        {
            b1 = a.ToString();
            Textbox1.Text = a.ToString();




        }

        public void prebaci2(string d)
        {
            b2 = d.ToString();
            Textbox2.Text = d.ToString();
        }

        public void prebaci3(string e)
        {
            b3 = e.ToString();
            Textbox6.Text = e.ToString();
        }

        public void prebaci4(string f)
        {
            b3 = f.ToString();
            Textbox3.Text = f.ToString();
        }



    }
}

