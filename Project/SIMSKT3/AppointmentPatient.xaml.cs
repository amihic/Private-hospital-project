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
    /// Interaction logic for AppointmentPatient.xaml
    /// </summary>
    public partial class AppointmentPatient : Window
    {
        public AppointmentPatient()
        {
            InitializeComponent();
        }


        private void Button_ClickBACK(object sender, RoutedEventArgs e)
        {
            Patient win = new Patient();
            win.Show();
            this.Close();
        }

        private void Button_ClickClear(object sender, RoutedEventArgs e)
        {
            Textbox1.Text = " ";
            Textbox2.Text = " ";
            Textbox3.Text = " ";
            Datepicker.Text = " ";
            cb_doctors.Text = " ";
        }


        public void Button_Create(object sender, RoutedEventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            List<Classes.Model.Appointment> appointments = JsonConvert.DeserializeObject<List<Classes.Model.Appointment>>(File.ReadAllText("patientAppointments.json"));
            try
            {
                string[] sTime = Textbox2.Text.Split(':');
                string[] eTime = Textbox3.Text.Split(':');

                if (Convert.ToInt32(sTime[0]) > Convert.ToInt32(eTime[0]))
                {
                    MessageBox.Show("End time must be after start time");
                    return;
                }
                else if (Convert.ToInt32(sTime[0]) == Convert.ToInt32(eTime[0]))
                {
                    if (Convert.ToInt32(sTime[1]) > Convert.ToInt32(eTime[1]))
                    {
                        MessageBox.Show("End time must be after start time");
                        return;
                    }
                }

            }
            catch (Exception E)
            {
                MessageBox.Show("Time is not in valid format!");
                return;
            }

            var appointment = new Classes.Model.Appointment
            {
                id = Convert.ToInt32(Textbox1.Text),
                startTime = Textbox2.Text,
                endTime = Textbox3.Text,
                date = Datepicker.Text,
                dr = cb_doctors.Text

            };

            foreach (var app in appointments)
            {
                sb.Append(app.id);
                //sb.Append(app.startTime);
                //sb.Append(app.endTime);
                //sb.Append(app.date);
                sb.Append(",");
            }
            string a = sb.ToString();
            string[] splited = a.Split(',');
            List<string> splited1 = new List<string>(splited);


            try
            {

                if (splited1.Contains(appointment.id.ToString()))
                    MessageBox.Show("ID already exists!");
                else

                {
                    foreach (var apps in appointments)
                    {
                        if (apps.startTime == appointment.startTime && apps.endTime == appointment.endTime && apps.date == appointment.date || apps.startTime == appointment.startTime && apps.date == appointment.date || apps.endTime == appointment.endTime && apps.date == appointment.date)
                        {
                            MessageBox.Show("The appointment is busy! Change time!");
                            return;
                        }
                        else
                        {
                            appointments.Add(appointment);
                            string json = JsonConvert.SerializeObject(appointments, Formatting.Indented);
                            File.WriteAllText("patientAppointments.json", json);
                            MessageBox.Show("Appointment is successfully created!");
                        }
                    }
                }
            }
            catch (Exception E)
            {

            }
        }



        private void Button_DeleteAll(object sender, RoutedEventArgs e)
        {
            lv_appointments.Items.Clear();

            List<Classes.Model.Appointment> appointments = JsonConvert.DeserializeObject<List<Classes.Model.Appointment>>(File.ReadAllText("patientAppointments.json"));
            foreach (var app in appointments.ToList())
            {
                appointments.Remove(app);
            }
            MessageBox.Show("All appointments are successfully deleted");
            string json = JsonConvert.SerializeObject(appointments, Formatting.Indented);
            File.WriteAllText("patientAppointments.json", json);
        }


        public void read_all(object sender, RoutedEventArgs e)
        {
            try
            {
                lv_appointments.Items.Clear();
                List<Classes.Model.Appointment> appointments = JsonConvert.DeserializeObject<List<Classes.Model.Appointment>>(File.ReadAllText("patientAppointments.json"));
                foreach (var app in appointments)
                {
                    lv_appointments.Items.Add(app.id + "\t" + app.startTime + "\t" + app.endTime + "\t" + app.date + "\t" + app.dr);
                }
            }
            catch (Exception E)
            {
                MessageBox.Show("There is no appointment to be deleted");
            }
        }

        private void Button_ClickUpdate(object sender, RoutedEventArgs e)
        {
            List<Classes.Model.Appointment> appointments = JsonConvert.DeserializeObject<List<Classes.Model.Appointment>>(File.ReadAllText("patientAppointments.json"));

            try
            {
                string[] sTime = Textbox2.Text.Split(':');
                string[] eTime = Textbox3.Text.Split(':');

                if (Convert.ToInt32(sTime[0]) > Convert.ToInt32(eTime[0]))
                {
                    MessageBox.Show("End time must be after start time");
                    return;
                }
                else if (Convert.ToInt32(sTime[0]) == Convert.ToInt32(eTime[0]))
                {
                    if (Convert.ToInt32(sTime[1]) > Convert.ToInt32(eTime[1]))
                    {
                        MessageBox.Show("End time must be after start time");
                        return;
                    }
                }

            }
            catch (Exception E)
            {
                MessageBox.Show("Time is not in valid format!");
                return;
            }

            try
            {
                foreach (var app in appointments)
                {
                    if (app.id.Equals(Convert.ToInt32(Textbox1.Text)))
                    {
                        app.startTime = Textbox2.Text;
                        app.endTime = Textbox3.Text;
                        app.date = Datepicker.Text;
                        foreach (var ap in appointments)
                        {
                            string[] sTime = Textbox2.Text.Split(':');
                            string[] eTime = Textbox3.Text.Split(':');



                            if (ap.startTime == app.startTime && ap.endTime == app.endTime && ap.date == app.date || ap.startTime == app.startTime && ap.date == app.date || ap.endTime == app.endTime && ap.date == app.date)
                            {
                                MessageBox.Show("The appointment is busy! Change time!");
                                return;
                            }
                            else
                            {
                                string json = JsonConvert.SerializeObject(appointments, Formatting.Indented);
                                File.WriteAllText("patientAppointments.json", json);
                                MessageBox.Show("Appointment is successfully updated");
                                return;
                            }


                        }
                    }
                }



            }
            catch (Exception E) { }

        }


        private void Button_ClickRead(object sender, RoutedEventArgs e)
        {
            List<Classes.Model.Appointment> appointments = JsonConvert.DeserializeObject<List<Classes.Model.Appointment>>(File.ReadAllText("patientAppointments.json"));
            foreach (var app in appointments)
            {
                if (app.id.Equals(Convert.ToInt32(Textbox1.Text)))
                {
                    lv_appointments.Items.Clear();
                    lv_appointments.Items.Add(app.id + "\t" + app.startTime + "\t" + app.endTime + "\t" + app.date + "\t" + app.dr + "\t");
                }
            }
        }

        private void Button_ClickDelete(object sender, RoutedEventArgs e)
        {
            List<Classes.Model.Appointment> appointments = JsonConvert.DeserializeObject<List<Classes.Model.Appointment>>(File.ReadAllText("patientAppointments.json"));
            foreach (var app in appointments.ToList())
            {
                if (app.id.Equals(Convert.ToInt32(Textbox1.Text)))
                {
                    appointments.Remove(app);
                    MessageBox.Show("Appointment is successfully deleted");
                }
            }
            string json = JsonConvert.SerializeObject(appointments, Formatting.Indented);
            File.WriteAllText("patientAppointments.json", json);

        }

        private void lv_appointments_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void cb_doctors_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            List<Classes.Model.Doctor> doctors = JsonConvert.DeserializeObject<List<Classes.Model.Doctor>>(File.ReadAllText("doctors.json"));
            foreach (var dr in doctors.ToList())
            {
                cb_doctors.Items.Add(dr.name + " " + dr.surname + " - " + dr.specialization);

            }
        }

        private void timeRadioButton_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void doctorRadioButton_Checked(object sender, RoutedEventArgs e)
        {

        }
    }
}

