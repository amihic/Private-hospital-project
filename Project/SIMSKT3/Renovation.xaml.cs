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
using System.IO;
using Classes.Service;
using Classes.Repository;
using Classes.Controller;
using Newtonsoft.Json;
using Classes.Model;

namespace SIMSKT3
{
    public partial class Renovation : Window
    {
        RenovationController renovationController = new RenovationController();
        public Renovation()
        {
            InitializeComponent();
        }
        private void Button_ClickBack(object sender, RoutedEventArgs e)
        {
            OptionsDirector options = new OptionsDirector();
            options.Show();
            this.Close();
        }

        private void Button_ClickAccept(object sender, RoutedEventArgs e)
        {
            bool passed = false;
            string s1 = String.Empty;
            string s2 = String.Empty;
            DateTime dt;
            try
            {
                s1 = Textbox2.Text;
                dt = Convert.ToDateTime(s1);
                s1 = dt.ToString("HH:mm");
                passed = true;
                try
                {
                    s2 = Textbox3.Text;
                    dt = Convert.ToDateTime(s2);
                    s2 = dt.ToString("HH:mm");
                    passed = true;

                    Classes.Model.Renovation renovation = new Classes.Model.Renovation(Textbox1.Text,
                                                                                        Convert.ToDateTime(DatePicker1.Text),
                                                                                        Convert.ToDateTime(Textbox2.Text),
                                                                                        Convert.ToDateTime(Textbox3.Text),
                                                                                        Textbox4.Text);
                    int message = renovationController.SetRenovation(renovation);

                    if (message == 1)
                        MessageBox.Show("Unet je los datum!");
                    else
                        if (message == 2)
                        MessageBox.Show("Unet je termin u kojem je vec zakazan pregled");
                    else
                        MessageBox.Show("Renoviranje je zakazano uspesno");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unet pogresan format za end time!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unet pogresan format za start time!");
            }
        }

        private void Button_ClickSeeAllRenovations(object sender, RoutedEventArgs e)
        {
            lb_renovation.Items.Clear();
            List<Classes.Model.Renovation> renovations = JsonConvert.DeserializeObject<List<Classes.Model.Renovation>>(File.ReadAllText("renovation.json"));
            foreach (var renova in renovations)
            {
                string renovadate = renova.date.ToString("MM/dd/yyyy");
                lb_renovation.Items.Add(renova.roomName + "\t" + renovadate + "\t" + Convert.ToString(renova.startTime.TimeOfDay) + "\t\t" + Convert.ToString(renova.endTime.TimeOfDay) + "\t\t" + renova.description);
            }
        }
    }
}


