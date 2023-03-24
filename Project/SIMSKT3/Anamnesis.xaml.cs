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
    /// Interaction logic for Anamnesis.xaml
    /// </summary>
    public partial class Anamnesis : Window
    {
        public Anamnesis()
        {
            InitializeComponent();
        }

        private void Button_BackToDr(object sender, RoutedEventArgs e)
        {
            Doctor dr = new Doctor();
            dr.Show();
            this.Close();
        }


        public void read_AllAnamnesis(object sender, RoutedEventArgs e)
        {
            try
            {
                lv_anamnesis.Items.Clear();
                List<Classes.Model.Anamnesis> anamnesis = JsonConvert.DeserializeObject<List<Classes.Model.Anamnesis>>(File.ReadAllText("anamnesis.json"));
                foreach (var anam in anamnesis)
                {
                    lv_anamnesis.Items.Add(anam.id + "\t" + anam.pati + "\t" + anam.name + "\t" + anam.description);
                }
            }
            catch (Exception E)
            {
                MessageBox.Show("There isn't any appointment");
            }
        }






        private void Button_CreateAnamnesis(object sender, RoutedEventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            List<Classes.Model.Anamnesis> anamnesis = JsonConvert.DeserializeObject<List<Classes.Model.Anamnesis>>(File.ReadAllText("anamnesis.json"));

            var anam = new Classes.Model.Anamnesis
            {
                id = Textbox1.Text,
                pati = cb_patients.Text,
                name = Textbox2.Text,
                description = Textbox3.Text
            };

            foreach (var an in anamnesis)
            {
                sb.Append(an.id);
                sb.Append(",");
            }
            string a = sb.ToString();
            string[] splited = a.Split(',');
            List<string> splited1 = new List<string>(splited);

            if (splited1.Contains(anam.id.ToString()))
                MessageBox.Show("ID already exists!");
            else

            {
                anamnesis.Add(anam);
                string json = JsonConvert.SerializeObject(anamnesis, Formatting.Indented);
                File.WriteAllText("anamnesis.json", json);
                MessageBox.Show("Anamnesis is successfully created!");
            }


        }





        private void Button_UpdateAnamnesis(object sender, RoutedEventArgs e)
        {
            List<Classes.Model.Anamnesis> anamnesis = JsonConvert.DeserializeObject<List<Classes.Model.Anamnesis>>(File.ReadAllText("anamnesis.json"));
<<<<<<< HEAD

            foreach (var anam in anamnesis)
            {
                if (anam.id.Equals(Textbox1.Text))
                {
                    anam.name = Textbox2.Text;
                    anam.description = Textbox3.Text;
                
                    MessageBox.Show("Anamnesis is successfully updated");
                }
            }
            string json = JsonConvert.SerializeObject(anamnesis, Formatting.Indented);
            File.WriteAllText("anamnesis.json", json);
        }


=======

            foreach (var anam in anamnesis)
            {
                if (anam.id.Equals(Textbox1.Text))
                {
                    anam.name = Textbox2.Text;
                    anam.description = Textbox3.Text;

                    MessageBox.Show("Anamnesis is successfully updated");
                }
            }
            string json = JsonConvert.SerializeObject(anamnesis, Formatting.Indented);
            File.WriteAllText("anamnesis.json", json);
        }


>>>>>>> 83499ee84be005688bb7f3e09a0e6c98d5c5d410
        private void Button_ReadAnamnesis(object sender, RoutedEventArgs e)
        {
            List<Classes.Model.Anamnesis> anamnesis = JsonConvert.DeserializeObject<List<Classes.Model.Anamnesis>>(File.ReadAllText("anamnesis.json"));
            foreach (var anam in anamnesis)
            {
                if (anam.id.Equals(Textbox1.Text))
                {
                    lv_anamnesis.Items.Clear();
                    lv_anamnesis.Items.Add(anam.id + "\t" + anam.pati + "\t" + anam.name + "\t" + anam.description);
                }
            }
        }



        private void Button_Click_Clear(object sender, RoutedEventArgs e)
        {
            Textbox1.Text = " ";
            Textbox2.Text = " ";
            Textbox3.Text = " ";
        }

        private void cb_patients_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            List<Classes.Model.PatientAccount> patients = JsonConvert.DeserializeObject<List<Classes.Model.PatientAccount>>(File.ReadAllText("patients.json"));
            foreach (var pat in patients.ToList())
            {
                cb_patients.Items.Add(pat.name + " " + pat.surname + " " + pat.jmbg);

            }
        }

        private void lv_anamnesis_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

<<<<<<< Updated upstream
<<<<<<< HEAD
       
=======

>>>>>>> 83499ee84be005688bb7f3e09a0e6c98d5c5d410
=======
 
>>>>>>> Stashed changes
    }
}
