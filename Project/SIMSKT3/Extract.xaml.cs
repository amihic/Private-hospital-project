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
<<<<<<< HEAD
    /// <summary>
    /// Interaction logic for Extract.xaml
    /// </summary>
    public partial class Extract : Window
    {
        string b;
=======

    public partial class Extract : Window
    {
        string b;
        WarehouseController warehouseController = new WarehouseController();
>>>>>>> 22c5e86ff397741ea3d7633e5efd94cd720d3b2c
        public Extract()
        {
            InitializeComponent();
        }
        private void Button_ClickClear(object sender, RoutedEventArgs e)
        {
            Textbox11.Text = " ";
            Textbox22.Text = " ";
        }

        private void Button_ClickBack(object sender, RoutedEventArgs e)
        {
            DynamicEquipmentCRUD room = new DynamicEquipmentCRUD();
            room.Show();
            this.Hide();
        }

        private void Button_ClickExtract(object sender, RoutedEventArgs e)
        {
<<<<<<< HEAD
            int k = 0;
            List<DynamicEquipment> dynamics = JsonConvert.DeserializeObject<List<DynamicEquipment>>(File.ReadAllText("warehouse.json"));
            foreach (var dyn in dynamics)
            {
                if (dyn.typeOfDynamicEquipment.Equals(Textbox11.Text))
                {
                    k = dyn.quantity - Convert.ToInt32(Textbox22.Text);
                    dyn.quantity = k;
                }
            }
            string json = JsonConvert.SerializeObject(dynamics, Formatting.Indented);
            File.WriteAllText("warehouse.json", json);
            MessageBox.Show("Dynamic equipment is extracted so you can go back!");

            string lines = "Extracted dynamic equipment:" + Textbox11.Text + "\t" + " quantity:" + Textbox22.Text + "\n";
            File.AppendAllText("extractions.txt", lines);
=======
            DynamicEquipment extract = new DynamicEquipment(Convert.ToInt32(Textbox22.Text),
                                                            Textbox11.Text,
                                                            Convert.ToInt32(Textbox22.Text));

            warehouseController.Extract(extract);
            MessageBox.Show("Equipment is extracted so you can go back!");
>>>>>>> 22c5e86ff397741ea3d7633e5efd94cd720d3b2c
        }
        public void prebaci(string a)
        {
            //b = a.ToString();
            Textbox11.Text = a.ToString();
        }
    }
<<<<<<< HEAD
}
=======
}
>>>>>>> 22c5e86ff397741ea3d7633e5efd94cd720d3b2c
