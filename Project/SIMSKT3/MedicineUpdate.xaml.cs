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


    public partial class MedicineUpdate : Window
    {
        string b;
        MedicineController medicineController = new MedicineController();
        public MedicineUpdate()
        {
            InitializeComponent();
        }

        private void Button_ClickUpdate(object sender, RoutedEventArgs e)
        {
            Classes.Model.Medicine medic = new Classes.Model.Medicine(Convert.ToInt32(Textbox11.Text),
                                                                                    Textbox22.Text,
                                                                                    Textbox33.Text,
                                                                                    Textbox44.Text,
                                                                                    Textbox55.Text,
                                                                                    Textbox66.Text);
            medicineController.UpdateMedicine(medic);
            MessageBox.Show("You need to wait for validation!");
        }

        private void Button_ClickClear(object sender, RoutedEventArgs e)
        {
            Textbox22.Text = " ";
            Textbox44.Text = " ";
            Textbox55.Text = " ";
            Textbox66.Text = " ";
        }

        private void Button_ClickBack(object sender, RoutedEventArgs e)
        {
            Medicine medicine = new Medicine();
            medicine.Show();
            this.Hide();
        }
        public void prebaci(string a, string b)
        {
            //b = a.ToString();
            Textbox11.Text = a.ToString();
            Textbox33.Text = b.ToString();
        }
    }
}
