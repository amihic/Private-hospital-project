<<<<<<< HEAD
=======
<<<<<<< HEAD
>>>>>>> 83499ee84be005688bb7f3e09a0e6c98d5c5d410
// File:    RenovationRepository.cs
// Author:  LifeBook A574
// Created: Wednesday, April 28, 2021 12:54:39 PM
// Purpose: Definition of Class RenovationRepository

using System;
<<<<<<< HEAD
=======
=======
using System;
>>>>>>> 83499ee84be005688bb7f3e09a0e6c98d5c5d410
using Classes.Model;
using Classes.Service;
using Classes.Repository;
using Classes.Controller;
using System.Collections.Generic;
<<<<<<< HEAD
=======
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
>>>>>>> fd620a89ab765ad29524f4512b4a532feef65325

>>>>>>> 83499ee84be005688bb7f3e09a0e6c98d5c5d410
namespace Classes.Repository
{
   public class RenovationRepository
   {
<<<<<<< HEAD
      public int SetRenovation(Renovation renovation)
=======
<<<<<<< HEAD
      public void CreateRenovation(Renovation renovation)
>>>>>>> 83499ee84be005688bb7f3e09a0e6c98d5c5d410
      {
         throw new NotImplementedException();
      }
      
<<<<<<< HEAD
      public Renovation ReadSettledRenovationById(int renovationId)
=======
      public Renovation ReadRenovation(int renovationId)
>>>>>>> 83499ee84be005688bb7f3e09a0e6c98d5c5d410
      {
         throw new NotImplementedException();
      }
      
<<<<<<< HEAD
      public bool CheckIfDateIsOK(Renovation renovation)
=======
      public void UpdateRenovation(Renovation renovation)
=======
        public List<Renovation> renovations = new List<Renovation>();
        public List<Appointment> appointments = new List<Appointment>();

        public RenovationRepository()
        {
            // deserializuje renovation.json
            if (!File.Exists("renovation.json"))
            {
                File.Create("renovation.json").Close();
            }

            using (StreamReader r = new StreamReader("renovation.json"))
            {
                string json = r.ReadToEnd();
                if (json != "")
                {
                    renovations = JsonConvert.DeserializeObject<List<Renovation>>(json);
                }
            }

            // deserializuje appointment.json
            if (!File.Exists("appointment.json"))
            {
                File.Create("appointment.json").Close();
            }

            using (StreamReader r = new StreamReader("appointment.json"))
            {
                string json = r.ReadToEnd();
                if (json != "")
                {
                    appointments = JsonConvert.DeserializeObject<List<Appointment>>(json);
                }
            }
        }
        // upisuje promene u json
        public void writeInJson()
        {
            string json = JsonConvert.SerializeObject(renovations, Formatting.Indented);
            File.WriteAllText("renovation.json", json);
        }

          public int SetRenovation(Renovation renovation)
          {
                int message = 0; //flag za gresku
                bool DateStatus = CheckIfDateIsOK(renovation);
                bool TermStatus = CheckIfTermIsAvailable(renovation);
            
                if(DateStatus == false)
                {
                    return message = 1;
                }
                else
                {
                    if(TermStatus == false)
                    {
                        return message = 2;
                    }
                    else
                    {
                        renovations.Add(renovation);
                        writeInJson();
                        return message = 3;
                    }
                }
                return message;
          }
      
          public Renovation ReadSettledRenovationById(int renovationId)
          {
             throw new NotImplementedException();
          }
        public bool CheckIfDateIsOK(Renovation renovation)
        {
            bool isDateOK = true;           // flag da li je dobro unet datum

            DateTime dt1 = renovation.date; // u dt1 je datum kada je renoviranje
            DateTime dt2 = DateTime.Now;    // u dt2 je trenutni datum

            //provera da li je datum koje je unet vec prosao
            if (dt1.Date < dt2.Date)
            {
                isDateOK = false;
            }

            //provera da li je vreme kraja termina pre vremena pocetka termina
            else if (renovation.startTime > renovation.endTime)
            {
                isDateOK = false;
            }

            return isDateOK;
        }

        public bool CheckIfTermIsAvailable(Renovation renovation)
        {
            string start = renovation.startTime.ToString("HH:mm");
            string end = renovation.endTime.ToString("HH:mm");
            string enterdate = renovation.date.ToString("M/dd/yyyy");

            bool isAvailable = true;            // flag da li je slobodan termin
            
            // proverava da li je ovaj termin vec zauzet u appointmentima
            foreach (var apps in appointments)
            {
                if (apps.room.Equals(renovation.roomName) && apps.date.Date == renovation.date.Date)
                {
                    string appstart = apps.startTime.ToString("HH:mm"); // stavlja se u isti format kao i start da bi moglo da se uporedi sa njim
                    string append = apps.endTime.ToString("HH:mm");     // stavlja se u isti format kao i end da bi moglo da se uporedi sa njim
                    if (appstart.Equals(start))
                    {
                        isAvailable = false;
                    }
                }
            }

            return isAvailable;
        }
        public Renovation UpdateSettledRenovation(Renovation renovation)
>>>>>>> fd620a89ab765ad29524f4512b4a532feef65325
>>>>>>> 83499ee84be005688bb7f3e09a0e6c98d5c5d410
      {
         throw new NotImplementedException();
      }
      
<<<<<<< HEAD
      public bool CheckIfTermIsAvailable(Renovation renovation)
=======
<<<<<<< HEAD
      public void DeleteRenovationById(Renovation renovation)
=======
      public void RemoveSettledRenovationById(Renovation renovation)
>>>>>>> fd620a89ab765ad29524f4512b4a532feef65325
>>>>>>> 83499ee84be005688bb7f3e09a0e6c98d5c5d410
      {
         throw new NotImplementedException();
      }
      
<<<<<<< HEAD
      public Renovation UpdateSettledRenovation(Renovation renovation)
      {
         throw new NotImplementedException();
      }
      
      public void RemoveSettledRenovationById(int renovationId)
=======
      public List<Renovation> ReadAllRenovations()
      {
         throw new NotImplementedException();
      }
<<<<<<< HEAD
      
      public bool CheckIfDateIsOK(Renovation renovation)
>>>>>>> 83499ee84be005688bb7f3e09a0e6c98d5c5d410
      {
         throw new NotImplementedException();
      }
      
<<<<<<< HEAD
      public List<Renovation> ReadAllRenovations()
      {
         throw new NotImplementedException();
      }
=======
      public bool CheckIfTermIsAvailable(Renovation renovation)
      {
         throw new NotImplementedException();
      }
=======
>>>>>>> fd620a89ab765ad29524f4512b4a532feef65325
>>>>>>> 83499ee84be005688bb7f3e09a0e6c98d5c5d410
   
   }
}