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
using Classes.Model;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace SIMSKT3
{
    public partial class GuestAccountCreate : Window
    {
        string prebacii;
        string prebaciii;
        string prebaciiii;
        string prebaciiiii;
        string prebaciGuesta;
        string m;
        public GuestAccountCreate()
        {
            InitializeComponent();
        }

        public void Button_Create(object sender, RoutedEventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            List<GuestAccount> guests = JsonConvert.DeserializeObject<List<GuestAccount>>(File.ReadAllText("guests.json"));
            var guest = new GuestAccount
            {
                id = Convert.ToInt32(Textbox111.Text),
                name = Textbox222.Text,
                jmbg = Textbox333.Text,
                surname = Textbox444.Text
            };
            foreach (var gu in guests)
            {
                sb.Append(gu.id);
                sb.Append(",");
            }
            string a = sb.ToString();
            string[] splited = a.Split(',');

            //if (splited.Contains(guest.id))
            //MessageBox.Show("ID already exists!");
            //else
            //{
            guests.Add(guest);
            string json = JsonConvert.SerializeObject(guests, Formatting.Indented);
            File.WriteAllText("guests.json", json);
            MessageBox.Show("Successfully added all guests!");
            //}
        }

        public void Button_ClickClear(object sender, RoutedEventArgs e)
        {
            Textbox111.Text = " ";
            Textbox222.Text = " ";
            Textbox333.Text = " ";
            Textbox444.Text = " ";
        }

        private void Button_ClickBack(object sender, RoutedEventArgs e)
        {
            OptionsSecretary options = new OptionsSecretary();
            options.Show();
            this.Hide();
        }

        private void Button_ClaimGuestAccount(object sender, RoutedEventArgs e)
        {
            prebacii = Textbox111.Text;
            prebaciii = Textbox222.Text;
            prebaciiii = Textbox333.Text;
            prebaciiiii = Textbox444.Text;

            PatientAccountCRUD patientAccountCRUD = new PatientAccountCRUD();
            patientAccountCRUD.prebaci1(prebacii.ToString());
            patientAccountCRUD.prebaci2(prebaciii.ToString());
            patientAccountCRUD.prebaci3(prebaciiii.ToString());
            patientAccountCRUD.prebaci4(prebaciiiii.ToString());

            patientAccountCRUD.Show();
            this.Hide();
        }

        private void Button_ReadAllGuestAccounts(object sender, RoutedEventArgs e)
        {
            lb_guests.Items.Clear();
            List<GuestAccount> guests = JsonConvert.DeserializeObject<List<GuestAccount>>(File.ReadAllText("guests.json"));
            foreach (var guest in guests)
            {
                lb_guests.Items.Add(guest.id + "\t" + guest.name + "\t" + guest.surname + "\t" + "\t" + guest.jmbg);
            }
        }

        private void lv_guests_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Guest is chosen for emergency appointment!");
            prebaciGuesta = Textbox333.Text; //preb1
            ChooseDoctor choose = new ChooseDoctor();
            choose.prebaci0(prebaciGuesta.ToString());
            choose.Show();
            this.Hide();


        }

        public void prebacaj(string h)
        {
            m = h.ToString();
            Textbox333.Text = h.ToString();
        }
    }
}

