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

    public partial class SecretaryUpdateAllergen : Window
    {
        string b;

        ManageAllergensController allergenController = new ManageAllergensController();

        public SecretaryUpdateAllergen()
        {
            InitializeComponent();
        }

        private void Button_ClickClear(object sender, RoutedEventArgs e)
        {
            Textbox100.Text = " ";
            Textbox200.Text = " ";
            Textbox300.Text = " ";

        }

        private void Button_ClickBack(object sender, RoutedEventArgs e)
        {
            ManageAllergens allergens = new ManageAllergens();
            allergens.Show();
            this.Hide();
        }

        private void Button_ClickUpdate(object sender, RoutedEventArgs e)
        {
            Allergen all = new Allergen(Convert.ToInt32(Textbox100.Text),
                                                       Textbox200.Text,
                                                       Textbox300.Text
                                                       );
            allergenController.Update(all);
            MessageBox.Show("Allergen is updated so you can go back!");
            /*List<Allergen> allergens = JsonConvert.DeserializeObject<List<Allergen>>(File.ReadAllText("allergens.json"));
            foreach (var allergen in allergens)
            {
                if (allergen.id==Convert.ToInt32(Textbox100.Text))
                {
                    allergen.id = Convert.ToInt32(Textbox100.Text);
                    allergen.name = Textbox200.Text;
                    allergen.diagnosisDate = Textbox300.Text;


                }
            }
            string json = JsonConvert.SerializeObject(allergens, Formatting.Indented);
            File.WriteAllText("allergens.json", json);
            MessageBox.Show("Allergen is updated so you can go back!");*/
        }


        public void PREBACI(string a)
        {
            //b = a.ToString();
            Textbox100.Text = a.ToString();
        }



    }
}
