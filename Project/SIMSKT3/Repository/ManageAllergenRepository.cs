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
//namespace SIMSKT3.Repository
{
    public class ManageAllergenRepository
    {
        public List<Allergen> allergens = new List<Allergen>();

        public ManageAllergenRepository()
        {
            if (!File.Exists("allergens.json"))
            {
                File.Create("allergens.json").Close();
            }

            using (StreamReader r = new StreamReader("allergens.json"))
            {
                string json = r.ReadToEnd();
                if (json != "")
                {
                    allergens = JsonConvert.DeserializeObject<List<Allergen>>(json);
                }
            }
        }
        public void writeInJson()
        {
            string json = JsonConvert.SerializeObject(allergens, Formatting.Indented);
            File.WriteAllText("allergens.json", json);
        }


        


        public StaticEquipment readAllergen(int id)
        {
            throw new NotImplementedException();
        }

        public void updateAllergen(Allergen all)
        {
            int index = allergens.FindIndex(obj => obj.id == all.id);
            allergens[index] = all;
            writeInJson();
        }

        public List<Allergen> getAll()
        {
            throw new NotImplementedException();
        }

        public void DeleteAllAllergens()
        {
            foreach (var all in allergens.ToArray())
            {
                allergens.Remove(all);
            }
            writeInJson();
        }

        public void DeleteAllergenById(int id, string allergenName)
        {
            foreach (var al in allergens.ToArray())
            {
                if (al.id == id && al.allergenName.Equals(allergenName))
                {
                    allergens.Remove(al);
                    writeInJson();
                }
            }
        }

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
}
