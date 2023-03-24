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

    public partial class NewsBoard : Window
    {
        string prebaci;

        NewsBoardController newsController = new NewsBoardController();


        string b1; //novo
        string b2;
        string b3;
        string b4;



        public NewsBoard()
        {
            InitializeComponent();
        }

        public void Button_Create(object sender, RoutedEventArgs e)
        {
            News ne = new News(Convert.ToInt32(Textbox1.Text),
                                                 Textbox2.Text,
                                                 Textbox6.Text,
                                                 Textbox90.Text
                                                 );
            newsController.create(ne);
            MessageBox.Show("Successfully created news!");
            /*StringBuilder sb = new StringBuilder();
            List<PatientAccount> patients = JsonConvert.DeserializeObject<List<PatientAccount>>(File.ReadAllText("patients.json"));
            var patient = new PatientAccount
            {
                id = Textbox1.Text,
                name = Textbox2.Text,
                surname = Textbox3.Text,
                age = Textbox4.Text,
                phoneNumber = Textbox5.Text,
                jmbg = Textbox6.Text

            };
            foreach (var pat in patients)
            {
                sb.Append(pat.id);
                sb.Append(",");
            }
            string a = sb.ToString();
            string[] splited = a.Split(',');

            if (splited.Contains(patient.id))
                MessageBox.Show("ID already exists!");
            else
            {
                patients.Add(patient);
                string json = JsonConvert.SerializeObject(patients, Formatting.Indented);
                File.WriteAllText("patients.json", json);
                MessageBox.Show("Successfully deleted all patients!");
            }*/
        }

        public void Button_ClickClear(object sender, RoutedEventArgs e)
        {
            Textbox1.Text = " ";
            Textbox2.Text = " ";
            Textbox6.Text = " ";
            Textbox90.Text = " ";

        }

        private void Button_DeleteAll(object sender, RoutedEventArgs e)
        {
            lb_news.Items.Clear();
            newsController.DeleteAll();
            MessageBox.Show("Successfully deleted all news!");

            /*
            lb_patients.Items.Clear();
            File.WriteAllText("patients.json", String.Empty);
            MessageBox.Show("Successfully deleted all patients!");*/
        }

        private void Button_ClickBack(object sender, RoutedEventArgs e)
        {
            OptionsSecretary options = new OptionsSecretary();
            options.Show();
            this.Hide();
        }

        public void Button_ClickReadAll(object sender, RoutedEventArgs e)
        {
            lb_news.Items.Clear();
            List<News> news = newsController.ReadAll();
            foreach (var neww in news)
            {
                lb_news.Items.Add(neww.id + "\t" + neww.title + "\t" + neww.text + "\t" + neww.date);
            }

            //lb_news.Items.Clear();
            //List<News> news = JsonConvert.DeserializeObject<List<News>>(File.ReadAllText("news.json"));
            //foreach (var neww in news)
            //{
            //    lb_news.Items.Add(neww.id + "\t" + neww.title + "\t" + neww.text + "\t" + neww.date);
            //}

            //lb_news.Items.Clear();
            ////newsController.ReadAll();
            //MessageBox.Show("Successfully deleted all news!");

        }

        private void Button_ClickRead(object sender, RoutedEventArgs e)
        {
            //newsController.Delete(Convert.ToInt32(Textbox1.Text));

            //lb_news.Items.Clear();
            News news = newsController.read(Convert.ToInt32(Textbox1.Text));
            lb_news.Items.Clear();
            lb_news.Items.Add(news.id + "\t" + news.title + "\t" + news.text + "\t" + news.date);

            //foreach (var neww in news)
            //{
            //    if (news.id.Equals(Textbox1.Text))
            //    {
            //        lb_news.Items.Clear();
            //        lb_news.Items.Add(news.id + "\t" + news.title + "\t" + news.text + "\t" + news.date);
            //    }
            //}

            //List<News> newss = JsonConvert.DeserializeObject<List<News>>(File.ReadAllText("news.json"));
            //foreach (var news in newss)
            //{
            //    if (news.id.Equals(Textbox1.Text))
            //    {
            //        lb_news.Items.Clear();
            //        lb_news.Items.Add(news.id + "\t" + news.title + "\t" + news.text + "\t" + news.date);
            //    }
            //}
        }
        private void Button_ClickDelete(object sender, RoutedEventArgs e)
        {
            newsController.Delete(Convert.ToInt32(Textbox1.Text));

            /*List<PatientAccount> patients = JsonConvert.DeserializeObject<List<PatientAccount>>(File.ReadAllText("patients.json"));
            foreach (var patient in patients.ToList())
            {
                if (patient.id.Equals(Textbox1.Text))
                {
                    patients.Remove(patient);
                }
            }
            string json = JsonConvert.SerializeObject(patients, Formatting.Indented);
            File.WriteAllText("patients.json", json);*/
        }

        private void Button_ClickUpdate(object sender, RoutedEventArgs e)
        {
            prebaci = Textbox1.Text;
            UpdateNewsBoard news_update = new UpdateNewsBoard();
            news_update.prebaci(prebaci.ToString());
            news_update.Show();
            this.Hide();


        }


        public void prebaci1(string a)
        {
            b1 = a.ToString();
            Textbox1.Text = a.ToString();




        }

        public void prebaci2(string d)
        {
            b2 = d.ToString();
            Textbox2.Text = d.ToString();
        }

        public void prebaci3(string e)
        {
            b3 = e.ToString();
            Textbox6.Text = e.ToString();
        }
        /*
        public void prebaci4(string f)
        {
            b3 = f.ToString();
            Textbox3.Text = f.ToString();
        }



    }
    public NewsBoard()
        {
            InitializeComponent();
        }
    }*/
    }
}
