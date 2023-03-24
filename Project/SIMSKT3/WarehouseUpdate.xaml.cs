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
    /// Interaction logic for WarehouseUpdate.xaml
    /// </summary>
    public partial class WarehouseUpdate : Window
    {
        string b;
=======

    public partial class WarehouseUpdate : Window
    {
        string b;
        WarehouseController warehouseController = new WarehouseController();
>>>>>>> 22c5e86ff397741ea3d7633e5efd94cd720d3b2c
        public WarehouseUpdate()
        {
            InitializeComponent();
        }
        private void Button_ClickClear(object sender, RoutedEventArgs e)
        {
            Textbox11.Text = " ";
            Textbox22.Text = " ";
            Textbox44.Text = " ";
        }

        private void Button_ClickBack(object sender, RoutedEventArgs e)
        {
            DynamicEquipmentCRUD room = new DynamicEquipmentCRUD();
            room.Show();
            this.Hide();
        }

        private void Button_ClickUpdate(object sender, RoutedEventArgs e)
        {
<<<<<<< HEAD
            List<DynamicEquipment> equipments = JsonConvert.DeserializeObject<List<DynamicEquipment>>(File.ReadAllText("warehouse.json"));
            foreach (var equip in equipments)
            {
                if (equip.id == Convert.ToInt32(Textbox11.Text))
                {
                    equip.typeOfDynamicEquipment = Textbox22.Text;
                    equip.quantity = Convert.ToInt32(Textbox44.Text);
                }
            }
            string json = JsonConvert.SerializeObject(equipments, Formatting.Indented);
            File.WriteAllText("warehouse.json", json);
            MessageBox.Show("Warehouse is updated so you can go back!");
=======
            DynamicEquipment dym = new DynamicEquipment(Convert.ToInt32(Textbox11.Text),
                                                        Textbox22.Text,
                                                        Convert.ToInt32(Textbox44.Text));
            warehouseController.Update(dym);
            MessageBox.Show("Equipment is updated so you can go back!");
>>>>>>> 22c5e86ff397741ea3d7633e5efd94cd720d3b2c
        }
        public void prebaci(string a)
        {
            //b = a.ToString();
            Textbox11.Text = a.ToString();
        }
    }
}
