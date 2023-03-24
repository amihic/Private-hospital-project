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
using Classes.Model;
using Classes.Service;
using Classes.Repository;
using Classes.Controller;
using Newtonsoft.Json;
using System.IO;

namespace SIMSKT3
{
    /// <summary>
    /// Interaction logic for OptionsDirector.xaml
    /// </summary>
    public partial class OptionsDirector : Window
    {
        public OptionsDirector()
        {
            InitializeComponent();
        }

        private void Button_ClickRoomCRUD(object sender, RoutedEventArgs e)
        {
            RoomCRUD director = new RoomCRUD();
            director.Show();
            this.Hide();
        }

        private void Button_ClickBack(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            this.Hide();
        }

        private void Button_ClickWarehouse(object sender, RoutedEventArgs e)
        {
            DynamicEquipmentCRUD dynam = new DynamicEquipmentCRUD();
            dynam.Show();
            this.Hide();
        }

        private void Button_ClickRenovation(object sender, RoutedEventArgs e)
        {
            Renovation renovation = new Renovation();
            renovation.Show();
            this.Hide();
        }

        private void Button_ClickStaticEquipmentCRUD(object sender, RoutedEventArgs e)
        {
            StaticEquipmentCRUD staticEquip = new StaticEquipmentCRUD();
            staticEquip.Show();
            this.Hide();
        }

        private void Button_ClickManageStaticEquipment(object sender, RoutedEventArgs e)
        {
            ManageStaticEquipment static_manage = new ManageStaticEquipment();
            static_manage.Show();
            this.Hide();
        }
<<<<<<< HEAD
=======

        private void Button_ClickMedicine(object sender, RoutedEventArgs e)
        {
            Medicine medicine = new Medicine();
            medicine.Show();
            this.Hide();
        }

        private void Button_ClickReadValidations(object sender, RoutedEventArgs e)
        {
            lb_validations.Items.Clear();
            foreach (string line in File.ReadAllLines("statusMedicine.txt"))
            {
                lb_validations.Items.Add(line);
            }
        }

        private void Button_ClickSearchEquipment(object sender, RoutedEventArgs e)
        {
            SearchEquipment search = new SearchEquipment();
            search.Show();
            this.Hide();
        }
>>>>>>> 22c5e86ff397741ea3d7633e5efd94cd720d3b2c
    }
}
