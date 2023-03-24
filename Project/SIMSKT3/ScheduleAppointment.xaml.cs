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
    public partial class ScheduleAppointment : Window
    {
        //string prebaci;

        string c1;
        string c2;
        string b7;
        AppointmentController appointmentController = new AppointmentController();
        public ScheduleAppointment()
        {
            InitializeComponent();
        }
        public void prebacII(string a)
        {
            b7 = a.ToString();
            Textbox6.Text = a.ToString();
        }



        private void Button_ClickBack(object sender, RoutedEventArgs e)
        {
            ChooseDoctor choose = new ChooseDoctor();
            choose.Show();
            this.Hide();
        }


        //private void Button_ClickReadAllDoctors(object sender, RoutedEventArgs e)
        //{
        //    lb_app.Items.Clear();
        //    List<Appointments> appointments = JsonConvert.DeserializeObject<List<Appointments>>(File.ReadAllText("appointments.json"));
        //    foreach (var app in appointments)
        //    {
        //        lb_app.Items.Add(app.id + "\t" + app.startTime + "\t" + app.endTime + "\t" + app.date + "\t" + app.type + "\t" + app.room);
        //    }
        //}

        private void Button_ScheduleApp(object sender, RoutedEventArgs e)
        {
            //ako je termin slobodan prelazi available u zauzet
            List<Appointment> appointments = JsonConvert.DeserializeObject<List<Appointment>>(File.ReadAllText("Appoint.json"));


            int i = 0;
            foreach (var app in appointments)
            {

                if (app.available.Equals("slobodan"))
                {

                    i = i + 1;

                }
                //app.available = "zauzet";
                //MessageBox.Show("First available appointment is scheduled for emergency!");

            }

            if (i > 0)
            {

                Appointment appo = appointmentController.ReadAppointment(i - 1);
                appointmentController.DeleteAppointment(i - 1);

                appo.available = "zauzet";
                appointmentController.create(appo);


                MessageBox.Show("First available appointment is scheduled for emergency!");


            }
            else
            {


                MessageBox.Show("Done!");



            }









            MessageBox.Show("Appointment is scheduled! You can see it in appointment list!");
        }

        private void Button_ClickReadAllpp(object sender, RoutedEventArgs e)
        {

            try
            {
                lb_app.Items.Clear();
                List<Classes.Model.Appointment> appointments = JsonConvert.DeserializeObject<List<Classes.Model.Appointment>>(File.ReadAllText("Appoint.json"));
                foreach (var app in appointments)
                {
                    lb_app.Items.Add(app.id + "\t" + app.startTime + "\t" + app.endTime + "\t" + app.date + "\t" + "\t" + app.dr + "\t" + "\t" + app.available);
                }
            }
            catch (Exception E)
            {
                MessageBox.Show("There isn't any appointment");
            }

        }


        public void prebaci1(string i)
        {
            c1 = i.ToString();
            Textbox6.Text = i.ToString();




        }
        public void prebaci2(string j)
        {
            c2 = j.ToString();
            Textbox7.Text = j.ToString();




        }
    }
}

