<<<<<<< HEAD
=======
<<<<<<< HEAD
>>>>>>> 83499ee84be005688bb7f3e09a0e6c98d5c5d410
// File:    StaticEquipmentRepository.cs
// Author:  LifeBook A574
// Created: Saturday, April 24, 2021 5:58:21 PM
// Purpose: Definition of Class StaticEquipmentRepository

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
   public class StaticEquipmentRepository
   {
<<<<<<< HEAD
      public Classes.Model.StaticEquipment createStaticEquipment(int id, string name, int floor, Classes.Model.RoomType type, string description)
=======
<<<<<<< HEAD
      public void CreateStaticEquipment(Classes.Model.StaticEquipment staticEquip)
>>>>>>> 83499ee84be005688bb7f3e09a0e6c98d5c5d410
      {
         throw new NotImplementedException();
      }
      
<<<<<<< HEAD
      public Classes.Model.StaticEquipment readStaticEquip(int id)
=======
      public Classes.Model.StaticEquipment ReadStaticEquipment(int id)
=======
      public List<StaticEquipment> statics = new List<StaticEquipment>();
      public List<ManageTransfer> manageTransfers = new List<ManageTransfer>();
      public List<Appointment> appointments = new List<Appointment>();

        public StaticEquipmentRepository()
        {
            // deserializuje staticequipment.json
            if (!File.Exists("staticequipment.json"))
            {
                File.Create("staticequipment.json").Close();
            }

            using (StreamReader r = new StreamReader("staticequipment.json"))
            {
                string json = r.ReadToEnd();
                if (json != "")
                {
                    statics = JsonConvert.DeserializeObject<List<StaticEquipment>>(json);
                }
            }
            // deserializuje managestatic.json
            if (!File.Exists("managestatic.json"))
            {
                File.Create("managestatic.json").Close();
            }
            using (StreamReader r = new StreamReader("managestatic.json"))
            {
                string json = r.ReadToEnd();
                if (json != "")
                {
                    manageTransfers = JsonConvert.DeserializeObject<List<ManageTransfer>>(json);
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
        public void writeInJson()// sluzi za pisanje staticke u json fajl 
        {
            string json = JsonConvert.SerializeObject(statics, Formatting.Indented);
            File.WriteAllText("staticequipment.json", json);
        }
        public void writeInJsonManage()// sluzi za pisanje premestanja u json fajl 
        {
            string json = JsonConvert.SerializeObject(manageTransfers, Formatting.Indented);
            File.WriteAllText("managestatic.json", json);
        }

        public void createStaticEquipment(StaticEquipment staticEquip)
        {
            int i = 0;
            // sluzi kao pokazatelj da li postoji staticka oprema koja treba da bude kreirana
            foreach (var stat in statics.ToArray())
            {
                if (stat.typeOdStaticEquipment.Equals(staticEquip.typeOdStaticEquipment) && stat.roomName.Equals(staticEquip.roomName))
                {
                    i = i + 1;
                }
            }
            // ako je i=0 onda ne postoji oprema i kreira se
            if (i == 0)
            {
                statics.Add(staticEquip);
                writeInJson();
            }
            // else znaci da postoji oprema i samo se kolicina dodaje na postojecu
            // pri cemu index i naziv ostaju isti kao oni sto su bili
            else
            {
                foreach (var stat in statics.ToArray())
                {
                    if (stat.typeOdStaticEquipment.Equals(staticEquip.typeOdStaticEquipment))
                    {
                        stat.typeOdStaticEquipment = staticEquip.typeOdStaticEquipment;
                        stat.quantity = stat.quantity + staticEquip.quantity;
                        statics.Remove(stat);
                        statics.Add(stat);
                        writeInJson();
                    }
                }
            }
        }
      public StaticEquipment readStaticEquip(int id)
>>>>>>> fd620a89ab765ad29524f4512b4a532feef65325
>>>>>>> 83499ee84be005688bb7f3e09a0e6c98d5c5d410
      {
         throw new NotImplementedException();
      }
      
<<<<<<< HEAD
      public Classes.Model.StaticEquipment updateStaticEquip(Classes.Model.StaticEquipment staticEquip)
=======
<<<<<<< HEAD
      public void UpdateStaticEquipment(Classes.Model.StaticEquipment staticEquip)
>>>>>>> 83499ee84be005688bb7f3e09a0e6c98d5c5d410
      {
         throw new NotImplementedException();
      }
      
<<<<<<< HEAD
      public void deleteRoomFromStorage(int id)
      {
         throw new NotImplementedException();
      }
      
      public List<StaticEquipment> getAll()
=======
      public void DeleteStaticEquipment(string roomName, int staticId)
=======
      public void updateStaticEquip(StaticEquipment staticEquip)
      {
            int index = statics.FindIndex(obj => obj.id == staticEquip.id);
            statics[index] = staticEquip;
            writeInJson();
        }
      
      public List<StaticEquipment> getAll()
>>>>>>> fd620a89ab765ad29524f4512b4a532feef65325
>>>>>>> 83499ee84be005688bb7f3e09a0e6c98d5c5d410
      {
         throw new NotImplementedException();
      }
      
<<<<<<< HEAD
      public void DeleteAllStaticEquipment()
      {
         throw new NotImplementedException();
      }
      
      public void ShiftStaticEquipment(Classes.Model.Room fromRoomId, Classes.Model.Room toRoomId, int staticEquipId, double quantity, DateTime enterDate)
=======
<<<<<<< HEAD
      public List<StaticEquipment> ReadAllStaticEquipment()
>>>>>>> 83499ee84be005688bb7f3e09a0e6c98d5c5d410
      {
         throw new NotImplementedException();
      }
      
<<<<<<< HEAD
      public void TransferSuccessfull(string notification)
=======
      public void TransferStaticEquipment(int fromRoomId, int toRoomId, int staticEquipId, double quantity, DateTime enterDate, DateTime startTime, DateTime endTime)
>>>>>>> 83499ee84be005688bb7f3e09a0e6c98d5c5d410
      {
         throw new NotImplementedException();
      }
      
      public Boolean CheckQuantity(int staticEquipId, double quantity)
      {
         throw new NotImplementedException();
      }
      
      public string path;
   
<<<<<<< HEAD
=======
=======
      public void DeleteAllStaticEquipment()
      {
            foreach (var stat in statics.ToArray())
            {
                statics.Remove(stat);
            }
            writeInJson();
        }

      public void DeleteStaticEquipmentById(string roomName, int id)
      {
            foreach (var stat in statics.ToArray())
            {
                if (stat.id == id && stat.roomName.Equals(roomName))
                {
                    statics.Remove(stat);
                    writeInJson();
                }
            }  
        }
        public int ShiftStaticEquipment(string fromRoomName, string toRoomName, string typeOdStaticEquipment, int equipId, int quantity, DateTime enterDate, DateTime startTime, DateTime endTime)
        {
            int message=0;// flag za gresku
            bool isDateOK= CheckDate(toRoomName, enterDate, startTime, endTime);
            bool isQuantityGood = CheckQuantity(fromRoomName, equipId, quantity);
            string start = startTime.ToString("HH:mm");
            string end = endTime.ToString("HH:mm");
            string enterdate = enterDate.ToString("MM/dd/yyyy");
            
            if (isDateOK==false)
            {
                return message = 1;
            }
            else
            {       
                if(isQuantityGood==false)
                {
                    return message = 2;
                }
                else
                {

                        ManageTransfer manage = new ManageTransfer(fromRoomName,
                                                                   toRoomName,
                                                                   typeOdStaticEquipment,
                                                                   equipId,
                                                                   quantity,
                                                                   enterdate,
                                                                   start,
                                                                   end);
                        manageTransfers.Add(manage);
                        writeInJsonManage();


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
                    return message = 3;
                }

            }
            return message;
        }
       public Boolean CheckDate(string toRoomName, DateTime transferDate, DateTime startTime, DateTime endTime)
        {
            string start = startTime.ToString("HH:mm");
            string end = endTime.ToString("HH:mm");
            string enterdate = transferDate.ToString("M/dd/yyyy");
            bool isOK = true;

            DateTime dt1 = transferDate;
            DateTime dt2 = DateTime.Now;

            //provera da li je datum koje je unet vec prosao
            if (dt1.Date < dt2.Date)
            {
                isOK = false;

            }
            //provera da li je vreme pocetka termina vece od vremena kraja termina
            else if(startTime > endTime)
            {
                isOK = false;   
            }

            // proverava da li je ovaj termin vec zauzet u appointmentima
            foreach(var apps in appointments)
            {
                if (apps.room.Equals(toRoomName) && apps.date.Date == transferDate.Date)
                {
                    string appstart = apps.startTime.ToString("HH:mm");
                    string append = apps.endTime.ToString("HH:mm");
                    if (appstart.Equals(start))
                    {
                        isOK = false;
                    }
                }
            }
            return isOK;
        }

        public void CheckToTransfer(DateTime transferDate, DateTime startTime, DateTime endTime)
        {
            //ne radi nista trenutno
        }

        public void TransferSuccessfull(string notification)
        {
            throw new NotImplementedException();
        }
      
      public Boolean CheckQuantity(string fromRoomName, int staticEquipId, int quantity)
      {
         bool isQuantityGood = true;
         foreach(var stat in statics)
         {
            if(stat.roomName.Equals(fromRoomName) && stat.id == staticEquipId)
            {
                 if(stat.quantity < quantity)
                    isQuantityGood = false;
            }
         }
         return isQuantityGood;
      }
      public string path;
>>>>>>> fd620a89ab765ad29524f4512b4a532feef65325
>>>>>>> 83499ee84be005688bb7f3e09a0e6c98d5c5d410
   }
}