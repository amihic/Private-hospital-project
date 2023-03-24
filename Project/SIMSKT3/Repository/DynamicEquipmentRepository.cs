
using System;
<<<<<<< HEAD

=======
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
using SIMSKT3;
>>>>>>> fd620a89ab765ad29524f4512b4a532feef65325
>>>>>>> 83499ee84be005688bb7f3e09a0e6c98d5c5d410
namespace Classes.Repository
{
   public class DynamicEquipmentRepository
   {
<<<<<<< HEAD
      public void CreateDynamicEquipment(Classes.Model.DynamicEquipment dynamicEquip)
      {
         throw new NotImplementedException();
      }
      
      public DynamicEquipment ReadDynamicEquipment(int id)
      {
         throw new NotImplementedException();
      }
      
      public void UpdateDynamicEquipment(Classes.Model.DynamicEquipment dynamicEquip)
=======
        public List<DynamicEquipment> dynamics = new List<DynamicEquipment>();
        public DynamicEquipmentRepository()
        {
            if (!File.Exists("warehouse.json"))
            {
                File.Create("warehouse.json").Close();
            }

            using (StreamReader r = new StreamReader("warehouse.json"))
            {
                string json = r.ReadToEnd();
                if (json != "")
                {
                    dynamics = JsonConvert.DeserializeObject<List<DynamicEquipment>>(json);
                }
            }
        }
        public void writeInJson()
        {
            string json = JsonConvert.SerializeObject(dynamics, Formatting.Indented);
            File.WriteAllText("warehouse.json", json);
        }

        public void ExtractFromStorage(DynamicEquipment dynamicEquip)
        {
            foreach (var dym in dynamics.ToArray())
            {
                if (dym.typeOfDynamicEquipment.Equals(dynamicEquip.typeOfDynamicEquipment))
                {
                    dym.typeOfDynamicEquipment = dynamicEquip.typeOfDynamicEquipment;
                    dym.quantity = dym.quantity - dynamicEquip.quantity;
                    dynamics.Remove(dym);
                    dynamics.Add(dym);
                    writeInJson();
                }
            }
            string lines = "Extracted dynamic equipment:" + dynamicEquip.typeOfDynamicEquipment + "\t" + " quantity:" + Convert.ToString(dynamicEquip.quantity) + "\n";
            File.AppendAllText("extractions.txt", lines);
        }

        public void CreateDynamicEquip(DynamicEquipment dynamicEquip)
        {
            int i = 0;
            foreach(var dym in dynamics.ToArray())
            {
                if (dym.typeOfDynamicEquipment.Equals(dynamicEquip.typeOfDynamicEquipment))
                {
                    i = i + 1;
                }
            }
            if (i == 0)
            {
                dynamics.Add(dynamicEquip);
                writeInJson();
            }
            else 
            {
                foreach (var dym in dynamics.ToArray())
                {
                    if (dym.typeOfDynamicEquipment.Equals(dynamicEquip.typeOfDynamicEquipment))
                    {
                        dym.typeOfDynamicEquipment = dynamicEquip.typeOfDynamicEquipment;
                        dym.quantity = dym.quantity + dynamicEquip.quantity;
                        dynamics.Remove(dym);
                        dynamics.Add(dym);
                        writeInJson();
                    }
                }
            }
      }
        public DynamicEquipment ReadDynamicEquip(int id)
>>>>>>> fd620a89ab765ad29524f4512b4a532feef65325
      {
         throw new NotImplementedException();
      }
      
<<<<<<< HEAD
      public void DeleteDynamicEquipment(int id)
=======
      public void UpdateDynamicEquip(DynamicEquipment dynamicEquip)
>>>>>>> fd620a89ab765ad29524f4512b4a532feef65325
      {
            int index = dynamics.FindIndex(obj => obj.id == dynamicEquip.id);
            dynamics[index] = dynamicEquip;
            writeInJson();
        }
      
      public List<DynamicEquipment> ReadAllDynamicEquipment()
      {
            int index = dynamics.FindIndex(obj => obj.id == dynamicEquipId);
            dynamics.RemoveAt(index);
            writeInJson();
        }
      
      public void Extract(string name, int quantity)
      {
<<<<<<< HEAD
         throw new NotImplementedException();
      }
=======
            foreach (var dym in dynamics.ToArray())
            {
                dynamics.Remove(dym);
            }
            writeInJson();
        }
>>>>>>> 83499ee84be005688bb7f3e09a0e6c98d5c5d410
      
      public string path;
   
   }
}