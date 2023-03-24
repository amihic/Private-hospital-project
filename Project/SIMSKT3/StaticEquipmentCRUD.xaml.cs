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
    public partial class StaticEquipmentCRUD : Window
    {
        string prebaci1;
        string prebaci2;
<<<<<<< HEAD
=======
        StaticEquipmentController staticController = new StaticEquipmentController();
>>>>>>> 22c5e86ff397741ea3d7633e5efd94cd720d3b2c
        public StaticEquipmentCRUD()
        {
            InitializeComponent();
        }

        public void Button_Create(object sender, RoutedEventArgs e)
        {
<<<<<<< HEAD
            List<StaticEquipment> staticEquipments = JsonConvert.DeserializeObject<List<StaticEquipment>>(File.ReadAllText("staticequipment.json"));
            int k = 0;
            int i = 0;
            foreach (var dym in staticEquipments.ToList())
            {
<<<<<<< Updated upstream
                if (dym.roomName.Equals(Textbox4.Text) && dym.typeOdStaticEquipment.Equals(Textbox2.Text))
                {
                    i = i + 1;
                }
=======
                id = Textbox1.Text,
                typeOdStaticEquipment = Textbox2.Text,
                quantity = Textbox3.Text
        };
            /*foreach (var rum in rooms)
            {
                sb.Append(rum.id);
                sb.Append(",");
>>>>>>> Stashed changes
            }
            if (i > 0)
            {
                foreach (var dym in staticEquipments.ToList())
                {
                    if (dym.roomName.Equals(Textbox4.Text) && dym.typeOdStaticEquipment.Equals(Textbox2.Text))
                    {
                        k = dym.quantity + Convert.ToInt32(Textbox3.Text);
                        staticEquipments.Remove(dym);
                        var dyn = new StaticEquipment()
                        {
                            roomName = Textbox4.Text,
                            id = dym.id,
                            typeOdStaticEquipment = Textbox2.Text,
                            quantity = Convert.ToInt32(k)
                        };
                        staticEquipments.Add(dyn);
                        string json = JsonConvert.SerializeObject(staticEquipments, Formatting.Indented);
                        File.WriteAllText("staticequipment.json", json);
                        MessageBox.Show("Entered equipment already exists in room so quantity increased instead of creating a new instance!");

                    }
                }
            }
            else
            {
                var dyn1 = new StaticEquipment()
                {
                    roomName = Textbox4.Text,
                    id = Convert.ToInt32(Textbox1.Text),
                    typeOdStaticEquipment = Textbox2.Text,
                    quantity = Convert.ToInt32(Textbox3.Text)
                };
                staticEquipments.Add(dyn1);
                string json1 = JsonConvert.SerializeObject(staticEquipments, Formatting.Indented);
                File.WriteAllText("staticequipment.json", json1);
                MessageBox.Show("Successfully created static equipment in room!");
            }
=======
            StaticEquipment stat = new StaticEquipment(Textbox4.Text,
                                                      Convert.ToInt32(Textbox1.Text),
                                                      Textbox2.Text,
                                                      Convert.ToInt32(Textbox3.Text));
            staticController.Create(stat);
            MessageBox.Show("Successfully created static equipment!");
>>>>>>> 22c5e86ff397741ea3d7633e5efd94cd720d3b2c
        }

        public void Button_ClickClear(object sender, RoutedEventArgs e)
        {
            Textbox1.Text = " ";
            Textbox2.Text = " ";
            Textbox3.Text = " ";
            Textbox4.Text = " ";
        }

        private void Button_DeleteAll(object sender, RoutedEventArgs e)
        {
            lb_rooms.Items.Clear();
<<<<<<< HEAD
            List<StaticEquipment> staticequipments = JsonConvert.DeserializeObject<List<StaticEquipment>>(File.ReadAllText("staticequipment.json"));
            foreach (var stat in staticequipments.ToList())
            {
                staticequipments.Remove(stat);
            }
            string json = JsonConvert.SerializeObject(staticequipments, Formatting.Indented);
            File.WriteAllText("staticequipment.json", json);
            MessageBox.Show("All equipmnet is deleted");
=======
            staticController.DeleteAll();
            MessageBox.Show("All static equipment is deleted");
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

            lb_rooms.Items.Clear();
            List<StaticEquipment> statics = JsonConvert.DeserializeObject<List<StaticEquipment>>(File.ReadAllText("staticequipment.json"));
            foreach (var stat in statics)
            {
                lb_rooms.Items.Add(stat.roomName + "\t\t" + stat.id + "\t" + stat.typeOdStaticEquipment + "\t\t" + stat.quantity);
            }
        }

        private void Button_ClickRead(object sender, RoutedEventArgs e)
        {
            lb_rooms.Items.Clear();
            List<StaticEquipment> staticequipments = JsonConvert.DeserializeObject<List<StaticEquipment>>(File.ReadAllText("staticequipment.json"));
            foreach (var stat in staticequipments.ToList())
            {
<<<<<<< HEAD
                if(stat.roomName.Equals(Textbox4.Text)/* && stat.typeOdStaticEquipment.Equals(Textbox2.Text*/)
                {
                      lb_rooms.Items.Add(stat.roomName + "\t\t" + stat.id + "\t" + stat.typeOdStaticEquipment + "\t\t" + stat.quantity);
=======
                if (stat.roomName.Equals(Textbox4.Text)/* && stat.typeOdStaticEquipment.Equals(Textbox2.Text*/)
                {
                    lb_rooms.Items.Add(stat.roomName + "\t\t" + stat.id + "\t" + stat.typeOdStaticEquipment + "\t\t" + stat.quantity);
>>>>>>> 22c5e86ff397741ea3d7633e5efd94cd720d3b2c
                }
            }
        }
        private void Button_ClickDelete(object sender, RoutedEventArgs e)
        {
<<<<<<< HEAD
            List<StaticEquipment> staticequipments = JsonConvert.DeserializeObject<List<StaticEquipment>>(File.ReadAllText("staticequipment.json"));
            foreach (var stat in staticequipments.ToList())
            {
                if (stat.roomName.Equals(Textbox4.Text) && stat.typeOdStaticEquipment.Equals(Textbox2.Text))
                {
                    staticequipments.Remove(stat);
                }
            }
            string json = JsonConvert.SerializeObject(staticequipments, Formatting.Indented);
            File.WriteAllText("staticequipment.json", json);
=======
            staticController.Delete(Textbox4.Text, Convert.ToInt32(Textbox1.Text));
>>>>>>> 22c5e86ff397741ea3d7633e5efd94cd720d3b2c
            MessageBox.Show("Static equipment is deleted. Read all equipment again");
        }

        private void Button_ClickUpdate(object sender, RoutedEventArgs e)
        {
            prebaci1 = Textbox4.Text;
            prebaci2 = Textbox1.Text;
            UpdateStaticEquipment static_update = new UpdateStaticEquipment();
            static_update.prebaci(prebaci1.ToString(), prebaci2.ToString());
            static_update.Show();
            this.Hide();
        }
    }
}
