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
    public partial class RoomCRUD : Window
    {
        string prebaci;
        RoomController roomController = new RoomController();
        public RoomCRUD()
        {
            InitializeComponent();
        }

        public void Button_Create(object sender, RoutedEventArgs e)
        {
            Room rum = new Room(Convert.ToInt32(Textbox1.Text),
                                                Textbox2.Text,
                                                ComboBox.Text,
                                                Convert.ToInt32(Textbox3.Text),
                                                Textbox4.Text);
            roomController.create(rum);
            MessageBox.Show("Successfully created room!");
        }

        public void Button_ClickClear(object sender, RoutedEventArgs e)
        {
            Textbox1.Text = " ";
            Textbox2.Text = " ";
            ComboBox.Text = " ";
            Textbox3.Text = " ";
            Textbox4.Text = " ";
        }

        private void Button_DeleteAll(object sender, RoutedEventArgs e)
        {
            lb_rooms.Items.Clear();
            roomController.deleteAll();
            MessageBox.Show("All rooms are deleted");
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
            List<Room> rooms = JsonConvert.DeserializeObject<List<Room>>(File.ReadAllText("rooms.json"));
            foreach (var room in rooms)
            {
                lb_rooms.Items.Add(room.id + "\t" + room.name + "\t" + room.type + "\t" + room.floor + "\t" + room.description);
            }
        }

        private void Button_ClickRead(object sender, RoutedEventArgs e)
        {
            List<Room> rooms = JsonConvert.DeserializeObject<List<Room>>(File.ReadAllText("rooms.json"));
            foreach (var room in rooms)
            {
                if (room.id == Convert.ToInt32(Textbox1.Text))
                {
                    lb_rooms.Items.Clear();
                    lb_rooms.Items.Add(room.id + "\t" + room.name + "\t" + room.type + "\t" + room.floor + "\t" + room.description);
                }
            }
        }
        private void Button_ClickDelete(object sender, RoutedEventArgs e)
        {
            roomController.delete(Convert.ToInt32(Textbox1.Text));
        }

        private void Button_ClickUpdate(object sender, RoutedEventArgs e)
        {
            prebaci = Textbox1.Text;
            DirectorUpdate director_update = new DirectorUpdate();
            director_update.prebaci(prebaci.ToString());
            director_update.Show();
            this.Hide();
        }
    }
}
