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

    public partial class DynamicEquipmentCRUD : Window
    {
        string prebaci;
<<<<<<< HEAD
=======
        WarehouseController warehouseController = new WarehouseController();
>>>>>>> 22c5e86ff397741ea3d7633e5efd94cd720d3b2c
        public DynamicEquipmentCRUD()
        {
            InitializeComponent();
        }

        private void Button_Create(object sender, RoutedEventArgs e)
        {
<<<<<<< HEAD
            List<DynamicEquipment> dynamicEquipments = JsonConvert.DeserializeObject<List<DynamicEquipment>>(File.ReadAllText("warehouse.json"));
            int k = 0;
            int i = 0;
                foreach (var dym in dynamicEquipments.ToList())
                {
                    if (dym.typeOfDynamicEquipment.Equals(Textbox2.Text))
                    {
                        i=i+1;
                        //k = dym.quantity + Convert.ToInt32(Textbox3.Text);
                        //dynamicEquipments.Remove(dym);
                        //var dyn = new DynamicEquipment()
                        //{
                        //    id = dym.id,
                        //    typeOfDynamicEquipment = Textbox2.Text,
                        //    quantity = Convert.ToInt32(k)
                        // };
                        //dynamicEquipments.Add(dyn);
                        //string json = JsonConvert.SerializeObject(dynamicEquipments, Formatting.Indented);
                        //File.WriteAllText("warehouse.json", json);
                        //MessageBox.Show("Successfully created dynamic equipment in warehouse!");
                    }
                }
                if (i > 0)
                {
                    foreach (var dym in dynamicEquipments.ToList())
                    {
                        if (dym.typeOfDynamicEquipment.Equals(Textbox2.Text))
                        {
                            k = dym.quantity + Convert.ToInt32(Textbox3.Text);
                            dynamicEquipments.Remove(dym);
                            var dyn = new DynamicEquipment()
                            {
                                id = dym.id,
                                typeOfDynamicEquipment = Textbox2.Text,
                                quantity = Convert.ToInt32(k)
                            };
                            dynamicEquipments.Add(dyn);
                            string json = JsonConvert.SerializeObject(dynamicEquipments, Formatting.Indented);
                            File.WriteAllText("warehouse.json", json);
                            MessageBox.Show("Entered equipment already exists in warehouse so quantity increased instead of creating a new instance!");
                            
                        }
                    }
                }
                else
                {
                    var dyn1 = new DynamicEquipment()
                    {
                        id = Convert.ToInt32(Textbox1.Text),
                        typeOfDynamicEquipment = Textbox2.Text,
                        quantity = Convert.ToInt32(Textbox3.Text)
                    };
                    dynamicEquipments.Add(dyn1);
                    string json1 = JsonConvert.SerializeObject(dynamicEquipments, Formatting.Indented);
                    File.WriteAllText("warehouse.json", json1);
                    MessageBox.Show("Successfully created dynamic equipment in warehouse!");
                }
                
            //string a = sb.ToString();
            //string[] splited = a.Split(',');


            //if (splited.Contains(room.id))
            //    MessageBox.Show("ID already exists!");
            //else
            //{
            //}
=======
            DynamicEquipment dym = new DynamicEquipment(Convert.ToInt32(Textbox1.Text),
                                                        Textbox2.Text,
                                                        Convert.ToInt32(Textbox3.Text));
            warehouseController.Create(dym);
            MessageBox.Show("Successfully created dynamic equipment!");
>>>>>>> 22c5e86ff397741ea3d7633e5efd94cd720d3b2c
        }

        private void Button_ClickClear(object sender, RoutedEventArgs e)
        {
            Textbox1.Text = " ";
            Textbox2.Text = " ";
            Textbox3.Text = " ";
        }

        private void Button_DeleteAll(object sender, RoutedEventArgs e)
        {
            lb_dynamicEquip.Items.Clear();
<<<<<<< HEAD
            List<DynamicEquipment> warehouse = JsonConvert.DeserializeObject<List<DynamicEquipment>>(File.ReadAllText("warehouse.json"));
            foreach (var war in warehouse.ToList())
            {
                warehouse.Remove(war);
            }
            string json = JsonConvert.SerializeObject(warehouse, Formatting.Indented);
            File.WriteAllText("warehouse.json", json);
            MessageBox.Show("All dynamic equipment is deleted");
=======
            warehouseController.DeleteAll();
            MessageBox.Show("All rooms are deleted");
>>>>>>> 22c5e86ff397741ea3d7633e5efd94cd720d3b2c
        }

        private void Button_ClickBack(object sender, RoutedEventArgs e)
        {
            OptionsDirector options = new OptionsDirector();
            options.Show();
            this.Hide();
        }

        public void Button_ClickReadAll(object sender, RoutedEventArgs e)
        {
            lb_dynamicEquip.Items.Clear();
            List<DynamicEquipment> dynamicEquipments = JsonConvert.DeserializeObject<List<DynamicEquipment>>(File.ReadAllText("warehouse.json"));
            foreach (var dynam in dynamicEquipments.ToList())
            {
                lb_dynamicEquip.Items.Add(dynam.id + "\t" + dynam.typeOfDynamicEquipment + "\t\t" + dynam.quantity);
            }
        }

        private void Button_ClickRead(object sender, RoutedEventArgs e)
        {
            lb_dynamicEquip.Items.Clear();
            List<DynamicEquipment> dynamicEquipments = JsonConvert.DeserializeObject<List<DynamicEquipment>>(File.ReadAllText("warehouse.json"));
            foreach (var dynam in dynamicEquipments.ToList())
            {
                if (dynam.id == Convert.ToInt32(Textbox1.Text))
                {
                    lb_dynamicEquip.Items.Add(dynam.id + "\t" + dynam.typeOfDynamicEquipment + "\t\t" + dynam.quantity);
                }
            }
        }
        private void Button_ClickDelete(object sender, RoutedEventArgs e)
        {
<<<<<<< HEAD
            List<DynamicEquipment> dynamicEquipments = JsonConvert.DeserializeObject<List<DynamicEquipment>>(File.ReadAllText("warehouse.json"));
            foreach (var dynam in dynamicEquipments.ToList())
            {
                if (dynam.id == Convert.ToInt32(Textbox1.Text))
                {
                    dynamicEquipments.Remove(dynam);
                }
            }
            string json = JsonConvert.SerializeObject(dynamicEquipments, Formatting.Indented);
            File.WriteAllText("warehouse.json", json);
=======
            warehouseController.Delete(Convert.ToInt32(Textbox1.Text));
>>>>>>> 22c5e86ff397741ea3d7633e5efd94cd720d3b2c
            MessageBox.Show("Dynamic equipment is deleted. Read all equipment again");
        }

        private void Button_ClickUpdate(object sender, RoutedEventArgs e)
        {
            prebaci = Textbox1.Text;
            WarehouseUpdate warehouse = new WarehouseUpdate();
            warehouse.prebaci(prebaci.ToString());
            warehouse.Show();
            this.Hide();
        }

        private void Button_ClickExtract(object sender, RoutedEventArgs e)
        {
            prebaci = Textbox2.Text;
            Extract extract = new Extract();
            extract.prebaci(prebaci.ToString());
            extract.Show();
            this.Hide();
        }

        private void Button_ClickReadExtractions(object sender, RoutedEventArgs e)
        {
            lb_extractions.Items.Clear();
            foreach (string line in File.ReadAllLines("extractions.txt"))
            {
                lb_extractions.Items.Add(line);
            }
        }
    }
<<<<<<< HEAD
}
=======
}
>>>>>>> 22c5e86ff397741ea3d7633e5efd94cd720d3b2c
