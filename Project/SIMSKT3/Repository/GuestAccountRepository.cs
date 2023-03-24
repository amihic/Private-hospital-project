<<<<<<< HEAD
using System;
using Classes.Model;
using Classes.Service;
using Classes.Repository;
using Classes.Controller;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Classes.Repository
{
=======
<<<<<<< HEAD
// File:    GuestAccountRepository.cs
// Author:  LENOVO
// Created: Friday, April 30, 2021 12:02:15 PM
// Purpose: Definition of Class GuestAccountRepository

using System;

namespace Classes.Repository
{
   public class GuestAccountRepository
   {
      public List<Patient> GetAllGuests()
      {
         throw new NotImplementedException();
      }
      
      public void SaveGuest(Patient patient)
      {
         throw new NotImplementedException();
      }
      
      public Patient UpdateGuest(Patient patient)
      {
         throw new NotImplementedException();
      }
      
      public void removePAcc(Patient patient)
      {
         throw new NotImplementedException();
      }
      
      public Classes.Model.Patient CreateGuest(int patientId, string name, string surname, string jmbg)
      {
         throw new NotImplementedException();
      }
      
      public Classes.Model.Patient GetGuestByJMBG(int jmbg)
      {
         throw new NotImplementedException();
      }
      
      public Classes.Model.Patient GetGuestById(int id)
      {
         throw new NotImplementedException();
      }
      
      public string path;
   
   }
=======
using System;
using Classes.Model;
using Classes.Service;
using Classes.Repository;
using Classes.Controller;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Classes.Repository
{
>>>>>>> 83499ee84be005688bb7f3e09a0e6c98d5c5d410
    public class GuestAccountRepository
    {
        public List<GuestAccount> guests = new List<GuestAccount>();

        public GuestAccountRepository()
        {
            if (!File.Exists("guests.json"))
            {
                File.Create("guests.json").Close();
            }

            using (StreamReader r = new StreamReader("guests.json"))
            {
                string json = r.ReadToEnd();
                if (json != "")
                {
                    guests = JsonConvert.DeserializeObject<List<GuestAccount>>(json);
                }
            }
        }
        public void writeInJson()
        {
            string json = JsonConvert.SerializeObject(guests, Formatting.Indented);
            File.WriteAllText("guests.json", json);
        }


        public void createGuest(GuestAccount gues)
        {
            /*
            int i = 0;
            // sluzi kao pokazatelj da li postoji staticka oprema koja treba da bude kreirana
            foreach (var stat in allergens.ToArray())
            {
                if (stat.typeOdStaticEquipment.Equals(all.typeOdStaticEquipment))
                {
                    i = i + 1;
                }
            }
            // ako je i=0 onda ne postoji oprema i kreira se
            if (i == 0)
            {
                allergens.Add(all);
                writeInJson();
            }
            // else znaci da postoji oprema i samo se kolicina dodaje na postojecu
            // pri cemu index i naziv ostaju isti kao oni sto su bili prvobitno u statickoj opremi
            else
            {
                foreach (var stat in allergens.ToArray())
                {
                    if (stat.typeOdStaticEquipment.Equals(all.typeOdStaticEquipment))
                    {
                        stat.typeOdStaticEquipment = all.typeOdStaticEquipment;
                        stat.quantity = stat.quantity + all.quantity;
                        allergens.Remove(stat);
                        allergens.Add(stat);
                        writeInJson();
                    }
                }
            }*/
        }


        public StaticEquipment readGuest(int id)
        {
            throw new NotImplementedException();
        }

        public void updateGuest(GuestAccount gues)
        {
            int index = guests.FindIndex(obj => obj.id == gues.id);
            guests[index] = gues;
            writeInJson();
        }

        public List<GuestAccount> getAll()
        {
            throw new NotImplementedException();
        }

        public void DeleteAllGuests()
        {
            foreach (var gues in guests.ToArray())
            {
                guests.Remove(gues);
            }
            writeInJson();
        }

        /*public void DeleteGuestById(int id)
        {
            foreach (var gue in guests.ToArray())
            {
                if (gue.id == id)
                {
                    guests.Remove(gue);
                    writeInJson();
                }
            }
        }*/

        /*
        public void ShiftStaticEquipment(string fromRoomName, string toRoomName, string typeOdStaticEquipment, int equipId, int quantity, DateTime enterDate)
        {
            int i = 0;
            //koristi se kao pokazatelj da li vec postoji oprema u prostoriji u koju se oprema premesta
            foreach (var stat in statics.ToArray())
            {
                if (stat.roomName.Equals(toRoomName) && stat.typeOdStaticEquipment.Equals(typeOdStaticEquipment))
                {
                    i = i + 1;
                }
            }
            //ako je i=0, znaci da oprema ne postoji u prostoriju u koju se premesta i onda se pravi nova oprema u toj prostoriji
            if (i == 0)
            {
                StaticEquipment sta = new StaticEquipment(toRoomName, equipId, typeOdStaticEquipment, quantity);
                statics.Add(sta);
                writeInJson();
                foreach (var stat in statics.ToArray())
                {
                    if (stat.typeOdStaticEquipment.Equals(typeOdStaticEquipment) && stat.roomName.Equals(fromRoomName))
                    {
                        stat.typeOdStaticEquipment = typeOdStaticEquipment;
                        stat.quantity = stat.quantity - quantity;
                        statics.Remove(stat);
                        statics.Add(stat);
                        writeInJson();
                    }
                }
            }
            // u suprotnom oprema vec postoji u prostoriji i onda se samo na postojecu nadodaje kolicina koja se prebacuje
            else
            {
                //ovaj for sluzi da doda kolicinu na postojecu opremu u prostoriji
                foreach (var stat in statics.ToArray())
                {
                    if (stat.typeOdStaticEquipment.Equals(typeOdStaticEquipment) && stat.roomName.Equals(toRoomName))
                    {
                        stat.typeOdStaticEquipment = typeOdStaticEquipment;
                        stat.quantity = stat.quantity + quantity;
                        statics.Remove(stat);
                        statics.Add(stat);
                        writeInJson();
                    }
                }
                // ovaj for oduzima opremu iz prostorije iz koje se iznosi
                foreach (var stat in statics.ToArray())
                {
                    if (stat.typeOdStaticEquipment.Equals(typeOdStaticEquipment) && stat.roomName.Equals(fromRoomName))
                    {
                        stat.typeOdStaticEquipment = typeOdStaticEquipment;
                        stat.quantity = stat.quantity - quantity;
                        statics.Remove(stat);
                        statics.Add(stat);
                        writeInJson();
                    }
                }
            }

        }

        public void TransferSuccessfull(string notification)
        {
            throw new NotImplementedException();
        }

        public Boolean CheckQuantity(int staticEquipId, double quantity)
        {
            throw new NotImplementedException();
        }
        */
        public string path;

    }
<<<<<<< HEAD
=======
>>>>>>> fd620a89ab765ad29524f4512b4a532feef65325
>>>>>>> 83499ee84be005688bb7f3e09a0e6c98d5c5d410
}