using System;
using System.Collections.Generic;
using System.IO;
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

namespace SIMSKT3
{
    /// <summary>
    /// Interaction logic for Notifications.xaml
    /// </summary>
    public partial class Notifications : Window
    {
        public Notifications()
        {
            InitializeComponent();
        }

        public void read_all(object sender, RoutedEventArgs e)
        {
            try
            {
                lv_notifications.Items.Clear();
                List<Classes.Model.Reminder> notifications = JsonConvert.DeserializeObject<List<Classes.Model.Reminder>>(File.ReadAllText("reminders.json"));
                foreach (var not in notifications)
                {
                    lv_notifications.Items.Add(not.name + "\t" + not.description);
                }
            }
            catch (Exception E)
            {
                MessageBox.Show("There is no appointment to be deleted");
            }
        }

        private void lv_notifications_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_ClickBACK(object sender, RoutedEventArgs e)
        {
            Patient win = new Patient();
            win.Show();
            this.Close();
        }
    }
}
