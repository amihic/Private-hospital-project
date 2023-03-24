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

    public partial class SearchEquipment : Window
    {
        public SearchEquipment()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            OptionsDirector options = new OptionsDirector();
            options.Show();
            this.Hide();
        }

        private void Button_ClickSearchEquipment(object sender, RoutedEventArgs e)
        {
            List<DynamicEquipment> dynamics = JsonConvert.DeserializeObject<List<DynamicEquipment>>(File.ReadAllText("warehouse.json"));
            List<StaticEquipment> statics = JsonConvert.DeserializeObject<List<StaticEquipment>>(File.ReadAllText("staticequipment.json"));
            lb_searchResults.Items.Clear();
            if (ComboBox1.Text.Equals("EQUIPMENT TYPE"))
            {
                if (String.IsNullOrEmpty(Textbox2.Text))
                {
                    MessageBox.Show("Morate uneti tip opreme!");
                }
                else
                {
                    if (String.IsNullOrEmpty(ComboBox2.Text))
                    {
                        if (Textbox2.Text.ToLower().Equals("DINAMICKA".ToLower()))
                        {
                            foreach (var dym in dynamics)
                            {
                                lb_searchResults.Items.Add(dym.id + "\t\t" + dym.typeOfDynamicEquipment + "\t\t" + dym.quantity);
                            }
                        }
                        else
                        {
                            foreach (var stat in statics)
                            {
                                lb_searchResults.Items.Add(stat.roomName + "\t\t" + stat.id + "\t" + stat.typeOdStaticEquipment + "\t\t" + stat.quantity);
                            }
                        }
                    }
                    else
                    {
                        if (ComboBox2.Text.Equals("ID-U") && Textbox2.Text.ToLower().Equals("DINAMICKA".ToLower()))
                        {
                            foreach (var dym in dynamics)
                            {
                                if (dym.id == Convert.ToInt32(Textbox1.Text))
                                    lb_searchResults.Items.Add(dym.id + "\t\t" + dym.typeOfDynamicEquipment + "\t\t" + dym.quantity);
                            }
                        }

                        else if (ComboBox2.Text.Equals("NAZIVU") && Textbox2.Text.ToLower().Equals("DINAMICKA".ToLower()))
                        {
                            foreach (var dym in dynamics)
                            {
                                if (dym.typeOfDynamicEquipment.Equals(Textbox1.Text))
                                    lb_searchResults.Items.Add(dym.id + "\t\t" + dym.typeOfDynamicEquipment + "\t\t" + dym.quantity);
                            }
                        }

                        else if (ComboBox2.Text.Equals("KOLICINI") && Textbox2.Text.ToLower().Equals("DINAMICKA".ToLower()))
                        {
                            foreach (var dym in dynamics)
                            {
                                if (dym.quantity == Convert.ToInt32(Textbox1.Text))
                                    lb_searchResults.Items.Add(dym.id + "\t\t" + dym.typeOfDynamicEquipment + "\t\t" + dym.quantity);
                            }
                        }

                        else if (ComboBox2.Text.Equals("ROOM NAME-U") && Textbox2.Text.ToLower().Equals("DINAMICKA".ToLower()))
                        {
                            MessageBox.Show("Dinamicka oprema nema odredjenu prostoriju!");
                        }

                        else if (ComboBox2.Text.Equals("ROOM NAME-U") && Textbox2.Text.ToLower().Equals("STATICKA".ToLower()))
                        {
                            foreach (var stat in statics)
                            {
                                if (stat.roomName.Equals(Textbox1.Text))
                                    lb_searchResults.Items.Add(stat.roomName + "\t\t" + stat.id + "\t" + stat.typeOdStaticEquipment + "\t\t" + stat.quantity);
                            }
                        }
                        else if (ComboBox2.Text.Equals("ID-U") && Textbox2.Text.ToLower().Equals("STATICKA".ToLower()))
                        {
                            foreach (var stat in statics)
                            {
                                if (stat.id == Convert.ToInt32(Textbox1.Text))
                                    lb_searchResults.Items.Add(stat.roomName + "\t\t" + stat.id + "\t" + stat.typeOdStaticEquipment + "\t\t" + stat.quantity);
                            }
                        }

                        else if (ComboBox2.Text.Equals("NAZIVU") && Textbox2.Text.ToLower().Equals("STATICKA".ToLower()))
                        {
                            foreach (var stat in statics)
                            {
                                if (stat.typeOdStaticEquipment.Equals(Textbox1.Text))
                                    lb_searchResults.Items.Add(stat.roomName + "\t\t" + stat.id + "\t" + stat.typeOdStaticEquipment + "\t\t" + stat.quantity);
                            }
                        }

                        else if (ComboBox2.Text.Equals("KOLICINI") && Textbox2.Text.ToLower().Equals("STATICKA".ToLower()))
                        {
                            foreach (var stat in statics)
                            {
                                if (stat.quantity == Convert.ToInt32(Textbox1.Text))
                                    lb_searchResults.Items.Add(stat.roomName + "\t\t" + stat.id + "\t" + stat.typeOdStaticEquipment + "\t\t" + stat.quantity);
                            }
                        }

                    }
                }
            }
            else if (ComboBox1.Text.Equals("ROOM NAME"))
            {
                if (String.IsNullOrEmpty(Textbox2.Text))
                {
                    MessageBox.Show("Morate uneti prostoriju!");
                }
                else
                {
                    if (String.IsNullOrEmpty(ComboBox2.Text))
                    {
                        foreach (var stat in statics)
                        {
                            if (stat.roomName.Equals(Textbox2.Text))
                            {
                                lb_searchResults.Items.Add(stat.roomName + "\t\t" + stat.id + "\t" + stat.typeOdStaticEquipment + "\t\t" + stat.quantity);
                            }
                        }
                    }
                    else
                    {
                        if (ComboBox2.Text.Equals("ID-U"))
                        {
                            foreach (var stat in statics)
                            {
                                if (stat.roomName.Equals(Textbox2.Text) && stat.id == Convert.ToInt32(Textbox1.Text))
                                {
                                    lb_searchResults.Items.Add(stat.roomName + "\t\t" + stat.id + "\t" + stat.typeOdStaticEquipment + "\t\t" + stat.quantity);
                                }
                            }
                        }
                        else if (ComboBox2.Text.Equals("NAZIVU"))
                        {
                            foreach (var stat in statics)
                            {
                                if (stat.roomName.Equals(Textbox2.Text) && stat.typeOdStaticEquipment.Equals(Textbox1.Text))
                                {
                                    lb_searchResults.Items.Add(stat.roomName + "\t\t" + stat.id + "\t" + stat.typeOdStaticEquipment + "\t\t" + stat.quantity);
                                }
                            }
                        }
                        else if (ComboBox2.Text.Equals("KOLICINI"))
                        {
                            foreach (var stat in statics)
                            {
                                if (stat.roomName.Equals(Textbox2.Text) && stat.quantity == Convert.ToInt32(Textbox1.Text))
                                {
                                    lb_searchResults.Items.Add(stat.roomName + "\t\t" + stat.id + "\t" + stat.typeOdStaticEquipment + "\t\t" + stat.quantity);
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                foreach (var dym in dynamics)
                {
                    lb_searchResults.Items.Add(dym.id + "\t\t" + dym.typeOfDynamicEquipment + "\t\t" + dym.quantity);
                }
                foreach (var stat in statics)
                {
                    lb_searchResults.Items.Add(stat.roomName + "\t\t" + stat.id + "\t" + stat.typeOdStaticEquipment + "\t\t" + stat.quantity);
                }
            }

        }
    }
}
