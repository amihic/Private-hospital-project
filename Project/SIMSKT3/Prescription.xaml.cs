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

namespace SIMSKT3
{
    /// <summary>
    /// Interaction logic for Prescription.xaml
    /// </summary>
    public partial class Prescription : Window
    {
        public Prescription()
        {
            InitializeComponent();
        }

        private void Button_Click_Clear(object sender, RoutedEventArgs e)
        {
            Textbox1.Text = " ";
            Textbox2.Text = " ";
            Textbox3.Text = " ";
            Textbox4.Text = " ";
        }

        private void Button_AddPrescription(object sender, RoutedEventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            List<Classes.Model.Prescription> prescriptions = JsonConvert.DeserializeObject<List<Classes.Model.Prescription>>(File.ReadAllText("prescriptions.json"));

            var pres = new Classes.Model.Prescription
            {
                id = Textbox1.Text,
                pati = cb_patients.Text,
                medicine = Textbox2.Text,
                quantity = Textbox3.Text,
                usage = Textbox4.Text
            };

            foreach (var pr in prescriptions)
            {
                sb.Append(pr.id);
                sb.Append(",");
            }
            string a = sb.ToString();
            string[] splited = a.Split(',');
            List<string> splited1 = new List<string>(splited);

            if (splited1.Contains(pres.id.ToString()))
                MessageBox.Show("ID already exists!");
            else

            {
                prescriptions.Add(pres);
                string json = JsonConvert.SerializeObject(prescriptions, Formatting.Indented);
                File.WriteAllText("prescriptions.json", json);
                MessageBox.Show("Prescriptions is successfully added!");
            }
        }

        private void cb_patients_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            List<Classes.Model.PatientAccount> patients = JsonConvert.DeserializeObject<List<Classes.Model.PatientAccount>>(File.ReadAllText("patients.json"));
            foreach (var pat in patients.ToList())
            {
                cb_patients.Items.Add(pat.name + " " + pat.surname + " " + pat.jmbg);

            }
        }

        private void read_AllPrescriptions(object sender, RoutedEventArgs e)
        {
            try
            {
                lv_prescriptions.Items.Clear();
                List<Classes.Model.Prescription> prescriptions = JsonConvert.DeserializeObject<List<Classes.Model.Prescription>>(File.ReadAllText("prescriptions.json"));
                foreach (var pres in prescriptions)
                {
                    lv_prescriptions.Items.Add(pres.id + "\t" + pres.pati + "\t" + pres.medicine + "\t" + pres.quantity + "\t" + pres.usage);
                }
            }
            catch (Exception E)
            {
                MessageBox.Show("There isn't any prescription");
            }
        }

        private void Button_ReadPrescription(object sender, RoutedEventArgs e)
        {
            List<Classes.Model.Prescription> prescriptions = JsonConvert.DeserializeObject<List<Classes.Model.Prescription>>(File.ReadAllText("prescriptions.json"));
            foreach (var pres in prescriptions)
            {
                if (pres.id.Equals(Textbox1.Text))
                {
                    lv_prescriptions.Items.Clear();
                    lv_prescriptions.Items.Add(pres.id + "\t" + pres.pati + "\t" + pres.medicine + "\t" + pres.quantity + "\t" + pres.usage);
                }
            }
        }

        private void Button_BackToDr(object sender, RoutedEventArgs e)
        {
            Doctor dr = new Doctor();
            dr.Show();
            this.Close();
        }
        private void lv_prescriptions_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
