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
    public partial class ChooseDoctor : Window
    {
        string prebaci9;

        string c;
        string f;


        string preb1;
        string preb2;

        EmergencyController emergencyController = new EmergencyController();
        DoctorController doctorController = new DoctorController();
        public ChooseDoctor()
        {
            InitializeComponent();
        }
        //public void prebaci(string a)
        //{
        //    b = a.ToString();
        //    Textbox6.Text = a.ToString();
        //}

        private void Button_ClickClear(object sender, RoutedEventArgs e)
        {
            Textbox7.Text = "";
        }



        private void Button_ClickBack(object sender, RoutedEventArgs e)
        {
            EmergencyAppointment emergency = new EmergencyAppointment();
            emergency.Show();
            this.Hide();
        }

        private void Button_ChoseDoc(object sender, RoutedEventArgs e)
        {
            List<Doctor> doctors = JsonConvert.DeserializeObject<List<Doctor>>(File.ReadAllText("doctors.json"));


            int i = 0;
            foreach (var doctor in doctors)
            {

                if (doctor.id.Equals(Textbox7.Text))
                {

                    i = i + 1;
                }
            }

            if (i > 0)
            {
                MessageBox.Show("Doctor is chosen!");
                preb1 = Textbox6.Text;
                preb2 = Textbox7.Text;

                ScheduleAppointment app = new ScheduleAppointment();
                //app.prebacII(prebaci9.ToString());
                app.prebaci1(preb1.ToString());
                app.prebaci2(preb2.ToString());
                app.Show();
                this.Hide();


                //prebacii = Textbox111.Text;
                //prebaciii = Textbox222.Text;
                //patientAccountCRUD.prebaci3(prebaciiii.ToString());
                //patientAccountCRUD.prebaci4(prebaciiiii.ToString());
            }
            else
            {


                MessageBox.Show("Doctor does not exist! Choose another!");
                //GuestAccountCreate guest = new GuestAccountCreate();
                ////guest.prebaci(prebaci.ToString());
                //guest.Show();
                //this.Hide();


            }

            //ListAppointments listapp = new ListAppointments();
            //listapp.Show();
            //this.Hide();

        }

        private void Button_ClickReadAllDoctors(object sender, RoutedEventArgs e)
        {
            lb_doctors.Items.Clear();
            List<Doctor> doctors = doctorController.readAll();
            foreach (var doc in doctors)
            {
                lb_doctors.Items.Add(doc.id + "\t" + doc.name + "\t" + doc.surname + "\t" + doc.specialization);
            }
            //lb_doctors.Items.Clear();
            //List<Doctors> doctors = JsonConvert.DeserializeObject<List<Doctors>>(File.ReadAllText("doctors.json"));
            //foreach (var doc in doctors)
            //{
            //    lb_doctors.Items.Add(doc.id + "\t" + doc.name + "\t" + doc.surname + "\t" + doc.specialization);
            //}
        }

        public void prebaci(string a) //ZA JMBG OD PACIJENTA DA IDE U CHOOSE DOCTOR
        {
            c = a.ToString();
            Textbox6.Text = a.ToString();
        }

        public void prebaci0(string k)
        {
            f = k.ToString();
            Textbox6.Text = k.ToString();
        }

    }
}

