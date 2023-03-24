<<<<<<< HEAD
=======
<<<<<<< HEAD
>>>>>>> 83499ee84be005688bb7f3e09a0e6c98d5c5d410
// File:    MedicineRepository.cs
// Author:  LifeBook A574
// Created: Monday, April 26, 2021 4:57:31 PM
// Purpose: Definition of Class MedicineRepository

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
   public class MedicineRepository
   {
<<<<<<< HEAD
      public void VerificateMedicine(int medicineId)
=======
<<<<<<< HEAD
      public void CreateMedicine(Medicine medicine)
=======
        public List<Medicine> medicines = new List<Medicine>();

        public MedicineRepository()
        {
            if (!File.Exists("medicine.json"))
            {
                File.Create("medicine.json").Close();
            }

            using (StreamReader r = new StreamReader("medicine.json"))
            {
                string json = r.ReadToEnd();
                if (json != "")
                {
                    medicines = JsonConvert.DeserializeObject<List<Medicine>>(json);
                }
            }
        }
        public void writeInJson()
        {
            string json = JsonConvert.SerializeObject(medicines, Formatting.Indented);
            File.WriteAllText("medicine.json", json);
        }

        public void VerificateMedicine(int medicineId)
>>>>>>> fd620a89ab765ad29524f4512b4a532feef65325
>>>>>>> 83499ee84be005688bb7f3e09a0e6c98d5c5d410
      {
         throw new NotImplementedException();
      }
      
<<<<<<< HEAD
      public Medicine UpdateMedicine(Medicine medicine)
=======
<<<<<<< HEAD
      public Medicine ReadMedicine(int medicineId)
>>>>>>> 83499ee84be005688bb7f3e09a0e6c98d5c5d410
      {
         throw new NotImplementedException();
      }
      
<<<<<<< HEAD
      public Medicine ReadMedicine(int medicineId)
=======
      public void UpdateMedicine(Medicine medicine)
=======
      public void UpdateMedicine(Medicine medicine)
      {
            int index = medicines.FindIndex(obj => obj.id == medicine.id);
            medicines[index] = medicine;
            writeInJson();
        }
      
      public Medicine ReadMedicine(int medicineId)
>>>>>>> fd620a89ab765ad29524f4512b4a532feef65325
>>>>>>> 83499ee84be005688bb7f3e09a0e6c98d5c5d410
      {
         throw new NotImplementedException();
      }
      
<<<<<<< HEAD
      public void DeclineMedicine(int medicineId, string reason)
=======
<<<<<<< HEAD
      public void DeleteMedicine(int medicineId)
=======
      public void DeclineMedicine(int medicineId)
>>>>>>> fd620a89ab765ad29524f4512b4a532feef65325
>>>>>>> 83499ee84be005688bb7f3e09a0e6c98d5c5d410
      {
         throw new NotImplementedException();
      }
      
      public List<Medicine> ReadAllMedicines()
      {
         throw new NotImplementedException();
      }
      
<<<<<<< HEAD
      public Medicine CreateMedicine(Medicine medicine)
=======
<<<<<<< HEAD
      public void VerificateMedicine(int medicineId)
>>>>>>> 83499ee84be005688bb7f3e09a0e6c98d5c5d410
      {
         throw new NotImplementedException();
      }
      
<<<<<<< HEAD
      public void DeleteMedicine(int medicineId)
      {
         throw new NotImplementedException();
      }
=======
      public void DeclineMedicine(int medicineId, string reason)
      {
         throw new NotImplementedException();
      }
=======
      public void CreateMedicine(Medicine medicine)
      {
           
            medicines.Add(medicine);
            writeInJson();
      }
      
      public void DeleteMedicine(int medicineId)
      {
            int index = medicines.FindIndex(obj => obj.id == medicineId);
            medicines.RemoveAt(index);
            writeInJson();
        }
>>>>>>> fd620a89ab765ad29524f4512b4a532feef65325
>>>>>>> 83499ee84be005688bb7f3e09a0e6c98d5c5d410
      
      public string path;
   
   }
}