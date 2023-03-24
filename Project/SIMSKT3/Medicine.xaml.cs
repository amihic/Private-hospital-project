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
using Classes.Service;
using Classes.Repository;
using Classes.Controller;
using System.IO;

namespace SIMSKT3
{
    public partial class Medicine : Window
    {
        MedicineController medicineController = new MedicineController();
        string prebaci;
        public Medicine()
        {
            InitializeComponent();
        }

        private void Button_Create(object sender, RoutedEventArgs e)
        {

            Classes.Model.Medicine medicine = new Classes.Model.Medicine(Convert.ToInt32(Textbox1.Text),
                                                                                        Textbox2.Text,
                                                                                        Textbox3.Text,
                                                                                        Textbox4.Text,
                                                                                        Textbox5.Text,
                                                                                        Textbox6.Text);
            medicineController.CreateMedicine(medicine);
            MessageBox.Show("You need to wait for validation!");
        }

        private void Button_ClickRead(object sender, RoutedEventArgs e)
        {
            lb_medicine.Items.Clear();
            lb_ingredients.Items.Clear();
            lb_alternatives.Items.Clear();
            List<Classes.Model.Medicine> medicines = JsonConvert.DeserializeObject<List<Classes.Model.Medicine>>(File.ReadAllText("medicine.json"));
            foreach (var medic in medicines)
            {
                if (medic.id == Convert.ToInt32(Textbox1.Text) && medic.status.Equals("VALIDATED"))
                {
                    lb_medicine.Items.Add(medic.id + "\t" + medic.name + "\t" + medic.status + "\t" + medic.description);
                    string[] ingred = medic.ingredients.Split(',');
                    foreach (var ing in ingred)
                        lb_ingredients.Items.Add(ing + "\n");
                    string[] alter = medic.alternatives.Split(',');
                    foreach (var alt in alter)
                        lb_alternatives.Items.Add(alt + "\n");
                }
            }
        }

        private void Button_ClickReadAll(object sender, RoutedEventArgs e)
        {
            lb_medicine.Items.Clear();
            lb_ingredients.Items.Clear();
            lb_alternatives.Items.Clear();
            List<Classes.Model.Medicine> medicines = JsonConvert.DeserializeObject<List<Classes.Model.Medicine>>(File.ReadAllText("medicine.json"));
            foreach (var medic in medicines)
            {
                if (medic.status.Equals("VALIDATED"))
                    lb_medicine.Items.Add(medic.id + "\t" + medic.name + "\t" + medic.status + "\t" + medic.description);
            }
        }

        private void Button_ClickUpdate(object sender, RoutedEventArgs e)
        {
            string prebaci1 = Textbox1.Text;
            string prebaci2 = Textbox3.Text;
            MedicineUpdate medicine_update = new MedicineUpdate();
            medicine_update.prebaci(prebaci1.ToString(), prebaci2.ToString());
            medicine_update.Show();
            this.Hide();
        }

        private void Button_ClickDelete(object sender, RoutedEventArgs e)
        {
            medicineController.DeleteMedicine(Convert.ToInt32(Textbox1.Text));
            MessageBox.Show("Medicine is deleted!");
        }


        private void Button_ClickBack(object sender, RoutedEventArgs e)
        {
            OptionsDirector options = new OptionsDirector();
            options.Show();
            this.Hide();
        }

        private void Button_ClickClear(object sender, RoutedEventArgs e)
        {
            Textbox1.Text = " ";
            Textbox2.Text = " ";
            Textbox4.Text = " ";
            Textbox5.Text = " ";
            Textbox6.Text = " ";
        }
    }
}
