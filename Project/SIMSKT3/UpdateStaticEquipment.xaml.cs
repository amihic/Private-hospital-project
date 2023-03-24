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
    /// <summary>
    /// Interaction logic for UpdateStaticEquipment.xaml
    /// </summary>
    public partial class UpdateStaticEquipment : Window
    {
        string b;
        StaticEquipmentController staticController = new StaticEquipmentController();
        public UpdateStaticEquipment()
        {
            InitializeComponent();
        }
        private void Button_ClickClear(object sender, RoutedEventArgs e)
        {
            Textbox11.Text = " ";
            Textbox22.Text = " ";
            Textbox33.Text = " ";
            Textbox44.Text = " ";
        }

        private void Button_ClickBack(object sender, RoutedEventArgs e)
        {
<<<<<<< HEAD
            StaticEquipmentCRUD staticequip= new StaticEquipmentCRUD();
=======
            StaticEquipmentCRUD staticequip = new StaticEquipmentCRUD();
>>>>>>> 22c5e86ff397741ea3d7633e5efd94cd720d3b2c
            staticequip.Show();
            this.Hide();
        }

        private void Button_ClickUpdate(object sender, RoutedEventArgs e)
        {
<<<<<<< HEAD
            List<StaticEquipment> equipments = JsonConvert.DeserializeObject<List<StaticEquipment>>(File.ReadAllText("staticequipment.json"));
            foreach (var equip in equipments)
            {
                if (equip.id== Convert.ToInt32(Textbox22.Text))
                {
                    //equip.id = Convert.ToInt32(Textbox22.Text);
                    equip.typeOdStaticEquipment = Textbox33.Text;
                    equip.quantity = Convert.ToInt32(Textbox44.Text);
                }
            }
            string json = JsonConvert.SerializeObject(equipments, Formatting.Indented);
            File.WriteAllText("staticequipment.json", json);
            MessageBox.Show("Static equipment is updated so you can go back!");
=======
            StaticEquipment stat = new StaticEquipment(Textbox11.Text,
                                                       Convert.ToInt32(Textbox22.Text),
                                                       Textbox33.Text,
                                                       Convert.ToInt32(Textbox44.Text));
            staticController.Update(stat);
            MessageBox.Show("Equipment is updated so you can go back!");
            //List<StaticEquipment> equipments = JsonConvert.DeserializeObject<List<StaticEquipment>>(File.ReadAllText("staticequipment.json"));
            //foreach (var equip in equipments)
            //{
            //    if (equip.id == Convert.ToInt32(Textbox22.Text) && equip.roomName == Textbox11.Text)
            //    {
            //        //equip.id = Convert.ToInt32(Textbox22.Text);
            //        equip.typeOdStaticEquipment = Textbox33.Text;
            //        equip.quantity = Convert.ToInt32(Textbox44.Text);
            //    }
            //}
            //string json = JsonConvert.SerializeObject(equipments, Formatting.Indented);
            //File.WriteAllText("staticequipment.json", json);
            //MessageBox.Show("Static equipment is updated so you can go back!");
>>>>>>> 22c5e86ff397741ea3d7633e5efd94cd720d3b2c
        }
        public void prebaci(string a, string b)
        {
            //b = a.ToString();
            Textbox11.Text = a.ToString();
            Textbox22.Text = b.ToString();
        }
    }
}
