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
    public partial class Appointment : Window
    {
        //string path = @"C:\Users\rakoc\OneDrive\Desktop\FTN NOVI SAD\SEMESTAR 6\SIMS\SIMS2kt\Appointment";
        string path = @"C:\Users\HP-Miha\Desktop\sims 2\SIMS2kt\Appointment";


        public Appointment()
        {
            InitializeComponent();

        }

        private void Button_ClickBack(object sender, RoutedEventArgs e)
        {
            Doctor win = new Doctor();
            win.Show();
            this.Close();
        }

        private void Button_ClickClear(object sender, RoutedEventArgs e)
        {
            Textbox1.Text = " ";
            Textbox2.Text = " ";
            Textbox3.Text = " ";
            Datepicker.Text = " ";
            cb_patients.Text = " ";
            cb_type.Text = " ";
        }


        public void Button_Create(object sender, RoutedEventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            List<Classes.Model.Appointment> appointments = JsonConvert.DeserializeObject<List<Classes.Model.Appointment>>(File.ReadAllText("appointment.json"));
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
                pati = cb_patients.Text,
                room = cb_rooms.Text,
                type = cb_type.Text

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
<<<<<<< Updated upstream
<<<<<<< HEAD
                appointments.Add(appointment);
                string json = JsonConvert.SerializeObject(appointments, Formatting.Indented);
                File.WriteAllText("appointment.json", json);
                MessageBox.Show("Appointment is successfully created!");
=======
=======
>>>>>>> Stashed changes

                if (splited1.Contains(appointment.id.ToString()))
                    MessageBox.Show("ID already exists!");
                else

                {
                    foreach (var apps in appointments)
<<<<<<< Updated upstream
                    {
=======
                    {                  
>>>>>>> Stashed changes
                        if (apps.startTime == appointment.startTime && apps.endTime == appointment.endTime && apps.date == appointment.date && apps.room == appointment.room || apps.startTime == appointment.startTime && apps.date == appointment.date && apps.room == appointment.room || apps.endTime == appointment.endTime && apps.date == appointment.date && apps.room == appointment.room)
                        {
                            MessageBox.Show("The appointment is busy! Change time!");
                            return;
                        }
                        else
                        {
                            appointments.Add(appointment);
                            string json = JsonConvert.SerializeObject(appointments, Formatting.Indented);
                            File.WriteAllText("appointment.json", json);
                            MessageBox.Show("Appointment is successfully created!");
                        }
                    }
                }
            }
<<<<<<< Updated upstream
            catch (Exception E)
            {

>>>>>>> 83499ee84be005688bb7f3e09a0e6c98d5c5d410
=======
            catch (Exception E) {
               
>>>>>>> Stashed changes
            }
        }



        private void Button_DeleteAll(object sender, RoutedEventArgs e)
        {
            lv_appointments.Items.Clear();
            File.WriteAllText("appointment.json", String.Empty);
            MessageBox.Show("All appointments are successfully deleted!");
        }


        public void read_all(object sender, RoutedEventArgs e)
        {
            try
            {
                lv_appointments.Items.Clear();
                List<Classes.Model.Appointment> appointments = JsonConvert.DeserializeObject<List<Classes.Model.Appointment>>(File.ReadAllText("appointment.json"));
                foreach (var app in appointments)
                {
                    lv_appointments.Items.Add(app.id + "\t" + app.startTime + "\t" + app.endTime + "\t" + app.date + "\t" + app.pati + "\t\t" + app.room + "\t\t" + app.type);
                }
            }
            catch (Exception E)
            {
                MessageBox.Show("There isn't any appointment");
            }
        }

        private void Button_ClickUpdate(object sender, RoutedEventArgs e)
        {
            List<Classes.Model.Appointment> appointments = JsonConvert.DeserializeObject<List<Classes.Model.Appointment>>(File.ReadAllText("appointment.json"));

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
                                File.WriteAllText("appointment.json", json);
                                MessageBox.Show("Appointment is successfully updated");
                                return;
                            }


                        }
                    }
                }


<<<<<<< Updated upstream

=======
                
>>>>>>> Stashed changes
            }
            catch (Exception E) { }

        }


        private void Button_ClickRead(object sender, RoutedEventArgs e)
        {
            List<Classes.Model.Appointment> appointments = JsonConvert.DeserializeObject<List<Classes.Model.Appointment>>(File.ReadAllText("appointment.json"));
            foreach (var app in appointments)
            {
                if (app.id.Equals(Convert.ToInt32(Textbox1.Text)))
                {
                    lv_appointments.Items.Clear();
                    lv_appointments.Items.Add(app.id + "\t" + app.startTime + "\t" + app.endTime + "\t" + app.date + "\t" + app.pati + "\t\t" + app.room + "\t\t" + app.type);
                }
            }
        }

        private void Button_ClickDelete(object sender, RoutedEventArgs e)
        {
            List<Classes.Model.Appointment> appointments = JsonConvert.DeserializeObject<List<Classes.Model.Appointment>>(File.ReadAllText("appointment.json"));
            foreach (var app in appointments.ToList())
            {
                if (app.id.Equals(Convert.ToInt32(Textbox1.Text)))
                {
                    appointments.Remove(app);
                    MessageBox.Show("Appointment is successfully deleted");
                }
            }
            string json = JsonConvert.SerializeObject(appointments, Formatting.Indented);
            File.WriteAllText("appointment.json", json);

        }

        private void lv_appointments_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void cb_patients_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            List<Classes.Model.PatientAccount> patients = JsonConvert.DeserializeObject<List<Classes.Model.PatientAccount>>(File.ReadAllText("patients.json"));
            foreach (var pat in patients.ToList())
            {
                cb_patients.Items.Add(pat.name + " " + pat.surname + " " + pat.jmbg);

            }
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void cb_rooms_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            List<Classes.Model.StaticEquipment> seq = JsonConvert.DeserializeObject<List<Classes.Model.StaticEquipment>>(File.ReadAllText("staticequipment.json"));
            foreach (var se in seq.ToList())
            {
                cb_rooms.Items.Add(se.roomName + " " + se.typeOdStaticEquipment);

            }
        }
    }
}
