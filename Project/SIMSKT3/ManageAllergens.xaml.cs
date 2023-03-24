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
    public partial class ManageAllergens : Window
    {
        string prebacI;



        //string b6; //novo
        ManageAllergensController allergenController = new ManageAllergensController();

        public ManageAllergens()
        {
            InitializeComponent();
        }

        public void Button_CreateAllergens(object sender, RoutedEventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            List<Allergen> allergens = JsonConvert.DeserializeObject<List<Allergen>>(File.ReadAllText("allergens.json"));
            var allergen = new Allergen
            {
                id = Convert.ToInt32(Textbox9.Text),
                allergenName = Textbox10.Text,
                diagnosisDate = Textbox16.Text
            };
            ////foreach (var aller in allergens)
            //{
            //  //  sb.Append(aller.id);
            //   // sb.Append(",");
            ////}
            //string a = sb.ToString();
            //string[] splited = a.Split(',');

            ////if (splited.Contains(allergen.id))
            // //   MessageBox.Show("ID already exists!");
            ////else
            ////{
            allergens.Add(allergen);
            string json = JsonConvert.SerializeObject(allergens, Formatting.Indented);
            File.WriteAllText("allergens.json", json);
            MessageBox.Show("Successfully created allergen!");
            //}
        }

        public void Button_ClickClearAllergens(object sender, RoutedEventArgs e)
        {
            Textbox9.Text = " ";
            Textbox10.Text = " ";
            Textbox16.Text = " ";


        }

        private void Button_DeleteAllAllergens(object sender, RoutedEventArgs e)
        {
            lb_allergens.Items.Clear();
            File.WriteAllText("allergens.json", String.Empty);
            MessageBox.Show("Successfully deleted all allergens!");
        }

        private void Button_ClickBack(object sender, RoutedEventArgs e)
        {
            MedicalRecords record = new MedicalRecords();
            record.Show();
            this.Hide();
        }

        public void Button_ClickReadAllAllergens(object sender, RoutedEventArgs e)
        {
            lb_allergens.Items.Clear();
            List<Allergen> allergens = JsonConvert.DeserializeObject<List<Allergen>>(File.ReadAllText("allergens.json"));
            foreach (var allergen in allergens)
            {
                lb_allergens.Items.Add(allergen.id + "\t" + allergen.allergenName + "\t" + "\t" + "\t" + allergen.diagnosisDate);
            }
        }

        private void Button_ClickReadAllergen(object sender, RoutedEventArgs e)
        {
            List<Allergen> allergens = JsonConvert.DeserializeObject<List<Allergen>>(File.ReadAllText("allergens.json"));
            foreach (var allergen in allergens)
            {
                if (allergen.id == Convert.ToInt32(Textbox9.Text))
                {
                    lb_allergens.Items.Clear();
                    lb_allergens.Items.Add(allergen.id + "\t" + allergen.allergenName + "\t" + "\t" + "\t" + allergen.diagnosisDate);
                }
            }
        }
        private void Button_ClickDeleteAllergen(object sender, RoutedEventArgs e)
        {
            allergenController.Delete(Convert.ToInt32(Textbox9.Text), Textbox10.Text);
            MessageBox.Show("Allergen is deleted. Read all allergens again");
            /*List<Allergen> allergens = JsonConvert.DeserializeObject<List<Allergen>>(File.ReadAllText("allergens.json"));
            foreach (var allergen in allergens.ToList())
            {
                if (allergen.id.Equals(Textbox9.Text))
                {
                    allergens.Remove(allergen);
                }
            }
            string json = JsonConvert.SerializeObject(allergens, Formatting.Indented);
            File.WriteAllText("allergens.json", json);*/
        }

        private void Button_ClickUpdateAllergen(object sender, RoutedEventArgs e)
        {
            prebacI = Textbox9.Text;
            SecretaryUpdateAllergen secretary_update_allergen = new SecretaryUpdateAllergen();
            secretary_update_allergen.PREBACI(prebacI.ToString());
            secretary_update_allergen.Show();
            this.Hide();


        }


        // public void PREBACI(string a)
        //{
        //   b6 = a.ToString();
        //  Textbox9.Text = a.ToString();
        // }

        private void lv_allergens_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        /*
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
        }*/



    }
}

