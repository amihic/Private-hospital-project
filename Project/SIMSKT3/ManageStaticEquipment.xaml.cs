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
    /// Interaction logic for ManageStaticEquipment.xaml
    /// </summary>
    public partial class ManageStaticEquipment : Window
    {
=======
    public partial class ManageStaticEquipment : Window
    {
        StaticEquipmentController staticController = new StaticEquipmentController();
>>>>>>> 22c5e86ff397741ea3d7633e5efd94cd720d3b2c
        public ManageStaticEquipment()
        {
            InitializeComponent();
        }

        private void Button_ClickReadAllEquipmentFrom(object sender, RoutedEventArgs e)
        {
            lb_prikazIzkoje.Items.Clear();
            List<StaticEquipment> staticEquipments = JsonConvert.DeserializeObject<List<StaticEquipment>>(File.ReadAllText("staticequipment.json"));
            foreach (var syntam in staticEquipments.ToList())
            {
                if (syntam.roomName.Equals(Textbox1.Text))
                {
                    lb_prikazIzkoje.Items.Add(syntam.id + "\t" + syntam.typeOdStaticEquipment + "\t\t" + syntam.quantity);
                }
            }
        }

        private void Button_ClickBack(object sender, RoutedEventArgs e)
        {
            OptionsDirector options = new OptionsDirector();
            options.Show();
            this.Hide();
        }

        private void Button_ClickMove(object sender, RoutedEventArgs e)
        {
<<<<<<< HEAD
            List<StaticEquipment> staticEquipments = JsonConvert.DeserializeObject<List<StaticEquipment>>(File.ReadAllText("staticequipment.json"));
            int k = 0;
            int i = 0;
            foreach (var dym in staticEquipments.ToList())
            {
                if (dym.roomName.Equals(Textbox4.Text) && dym.typeOdStaticEquipment.Equals(Textbox2.Text))
                {
                    i = i + 1;
                }
            }
            if (i > 0)
            {
                foreach (var dym in staticEquipments.ToList())
                {
                    if (dym.roomName.Equals(Textbox4.Text) && dym.typeOdStaticEquipment.Equals(Textbox2.Text))
                    {
                            k = dym.quantity + Convert.ToInt32(Textbox3.Text);
                            var dyn = new StaticEquipment()
                            {
                                roomName = Textbox4.Text,
                                id = dym.id,
                                typeOdStaticEquipment = Textbox2.Text,
                                quantity = k
                            };
                            staticEquipments.Remove(dym);
                            staticEquipments.Add(dyn);
                            string json = JsonConvert.SerializeObject(staticEquipments, Formatting.Indented);
                            File.WriteAllText("staticequipment.json", json);
                            MessageBox.Show("Entered equipment already exists in room so quantity increased instead of creating a new instance!");
                    }
                }
            }
            if (i > 0)
            {
                foreach (var dym in staticEquipments.ToList())
                {
                    if (dym.roomName.Equals(Textbox1.Text) && dym.typeOdStaticEquipment.Equals(Textbox2.Text))
                    {
                            k = dym.quantity - Convert.ToInt32(Textbox3.Text);
                            var dyn = new StaticEquipment()
                            {
                                roomName = Textbox1.Text,
                                id = dym.id,
                                typeOdStaticEquipment = Textbox2.Text,
                                quantity = k
                            };
                            staticEquipments.Remove(dym);
                            staticEquipments.Add(dyn);
                            string json = JsonConvert.SerializeObject(staticEquipments, Formatting.Indented);
                            File.WriteAllText("staticequipment.json", json);
                            //MessageBox.Show("Entered equipment already exists in room so quantity increased instead of creating a new instance!");
                    }
                }
            }
            else
            {
                var dyn1 = new StaticEquipment()
                {
                    roomName = Textbox4.Text,
                    id = Convert.ToInt32(Textbox5.Text),
                    typeOdStaticEquipment = Textbox2.Text,
                    quantity = Convert.ToInt32(Textbox3.Text)
                };
                staticEquipments.Add(dyn1);
                string json1 = JsonConvert.SerializeObject(staticEquipments, Formatting.Indented);
                File.WriteAllText("staticequipment.json", json1);
                MessageBox.Show("Successfully created static equipment in room!");
            }
            /*if (i > 0)
            {
                foreach (var dym in staticEquipments.ToList())
                {
                    if (dym.roomName.Equals(Textbox1.Text) && dym.typeOdStaticEquipment.Equals(Textbox2.Text))
                    {
                        k = dym.quantity - Convert.ToInt32(Textbox3.Text);
                        staticEquipments.Remove(dym);
                        var dyn = new StaticEquipment()
                        {
                            roomName = Textbox1.Text,
                            id = dym.id,
                            typeOdStaticEquipment = Textbox2.Text,
                            quantity = k
                        };

                        staticEquipments.Add(dyn);
                        string json = JsonConvert.SerializeObject(staticEquipments, Formatting.Indented);
                        File.WriteAllText("staticequipment.json", json);
                        //MessageBox.Show("Entered equipment already exists in room so quantity increased instead of creating a new instance!");
                    }
                }
            }*/
=======
            //bool passed = false;
            //string s1 = String.Empty;
            //string s2 = String.Empty;
            //DateTime dt;
            //try
            //{
            //    s1 = Textbox2.Text; //Whatever you are getting the time from
            //    dt = Convert.ToDateTime(s1);
            //    s1 = dt.ToString("HH:mm");
            //    passed = true;
            //    try
            //    {
            //        s2 = Textbox3.Text; //Whatever you are getting the time from
            //        dt = Convert.ToDateTime(s2);
            //        s2 = dt.ToString("HH:mm");
            //        passed = true;
            int message = staticController.TransferTo(Textbox1.Text,
                                        Textbox4.Text,
                                        Textbox2.Text,
                                        Convert.ToInt32(Textbox5.Text),
                                        Convert.ToInt32(Textbox3.Text),
                                        Convert.ToDateTime(DatePicker1.Text),
                                        Convert.ToDateTime(Textbox6.Text),
                                        Convert.ToDateTime(Textbox7.Text));
            if (message == 1)
                MessageBox.Show("Unos je neispravan. Proveriti datum ili termin koji je unet");
            else
                if (message == 2)
                MessageBox.Show("Uneta je prevelika kolicina!");
            else
                MessageBox.Show("Staticka oprema je uspesno preneta");

            //    catch (Exception ex)
            //    {
            //        MessageBox.Show("Unet pogresan format za end time!");
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Unet pogresan format za start time!");
            //}
>>>>>>> 22c5e86ff397741ea3d7633e5efd94cd720d3b2c
        }

        private void Button_ClickReadAllEquipmentTo(object sender, RoutedEventArgs e)
        {
            lb_prikazUkoju.Items.Clear();
            List<StaticEquipment> staticEquipments = JsonConvert.DeserializeObject<List<StaticEquipment>>(File.ReadAllText("staticequipment.json"));
            foreach (var syntam in staticEquipments.ToList())
            {
                if (syntam.roomName.Equals(Textbox4.Text))
                {
                    lb_prikazUkoju.Items.Add(syntam.id + "\t" + syntam.typeOdStaticEquipment + "\t\t" + syntam.quantity);
                }
            }
        }
    }
}
