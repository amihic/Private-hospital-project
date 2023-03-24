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

    public partial class DirectorUpdate : Window
    {
        string b;
        RoomController roomController = new RoomController();
        public DirectorUpdate()
        {
            InitializeComponent();
        }
        private void Button_ClickClear(object sender, RoutedEventArgs e)
        {
            Textbox11.Text = " ";
            Textbox22.Text = " ";
            ComboBox2.Text = " ";
            Textbox33.Text = " ";
            Textbox44.Text = " ";
        }

        private void Button_ClickBack(object sender, RoutedEventArgs e)
        {
            RoomCRUD room = new RoomCRUD();
            room.Show();
            this.Hide();
        }

        private void Button_ClickUpdate(object sender, RoutedEventArgs e)
        {
            Room rum = new Room(Convert.ToInt32(Textbox11.Text),
                                                Textbox22.Text,
                                                ComboBox2.Text,
                                                Convert.ToInt32(Textbox33.Text),
                                                Convert.ToString(Textbox44.Text));
            roomController.update(rum);
            MessageBox.Show("Room is updated so you can go back!");
        }
        public void prebaci(string a)
        {
            //b = a.ToString();
            Textbox11.Text = a.ToString();
        }
    }
}