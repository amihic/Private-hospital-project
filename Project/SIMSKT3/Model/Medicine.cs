<<<<<<< HEAD
=======
<<<<<<< HEAD
>>>>>>> 83499ee84be005688bb7f3e09a0e6c98d5c5d410
// File:    Medicine.cs
// Author:  LifeBook A574
// Created: Monday, April 26, 2021 4:28:29 PM
// Purpose: Definition of Class Medicine

using System;
<<<<<<< HEAD
using Classes.Model;
=======
=======
using System;
>>>>>>> 83499ee84be005688bb7f3e09a0e6c98d5c5d410
using Classes.Service;
using Classes.Repository;
using Classes.Controller;
using System.Collections.Generic;
<<<<<<< HEAD
=======
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
>>>>>>> fd620a89ab765ad29524f4512b4a532feef65325

>>>>>>> 83499ee84be005688bb7f3e09a0e6c98d5c5d410
namespace Classes.Model
{
   public class Medicine
   {
<<<<<<< HEAD
=======
<<<<<<< HEAD
>>>>>>> 83499ee84be005688bb7f3e09a0e6c98d5c5d410
      public int id;
      public string name;
      public StatusType status;
      public string description;
      public List<String> ingredients;
      public List<Medicine> alternatives;
<<<<<<< HEAD
   
   }
=======
      public string reason = null;
      
      public System.Collections.Generic.List<Medicine> medicineB;
      
      /// <summary>
      /// Property for collection of Medicine
      /// </summary>
      /// <pdGenerated>Default opposite class collection property</pdGenerated>
      public System.Collections.Generic.List<Medicine> MedicineB
      {
         get
         {
            if (medicineB == null)
               medicineB = new System.Collections.Generic.List<Medicine>();
            return medicineB;
         }
         set
         {
            RemoveAllMedicineB();
            if (value != null)
            {
               foreach (Medicine oMedicine in value)
                  AddMedicineB(oMedicine);
            }
         }
      }
      
      /// <summary>
      /// Add a new Medicine in the collection
      /// </summary>
      /// <pdGenerated>Default Add</pdGenerated>
      public void AddMedicineB(Medicine newMedicine)
      {
         if (newMedicine == null)
            return;
         if (this.medicineB == null)
            this.medicineB = new System.Collections.Generic.List<Medicine>();
         if (!this.medicineB.Contains(newMedicine))
            this.medicineB.Add(newMedicine);
      }
      
      /// <summary>
      /// Remove an existing Medicine from the collection
      /// </summary>
      /// <pdGenerated>Default Remove</pdGenerated>
      public void RemoveMedicineB(Medicine oldMedicine)
      {
         if (oldMedicine == null)
            return;
         if (this.medicineB != null)
            if (this.medicineB.Contains(oldMedicine))
               this.medicineB.Remove(oldMedicine);
      }
      
      /// <summary>
      /// Remove all instances of Medicine from the collection
      /// </summary>
      /// <pdGenerated>Default removeAll</pdGenerated>
      public void RemoveAllMedicineB()
      {
         if (medicineB != null)
            medicineB.Clear();
      }
      public Prescription[] prescription;
   
   }
=======
        public Medicine(int id, string name, string status, string description, string ingredients, string alternatives)
        {
            this.id = id;
            this.name = name;
            this.status = status;
            this.description = description;
            this.ingredients = ingredients;
            this.alternatives = alternatives;
        }

        public int id { get; set; }
        public string name { get; set; }
        public string status { get; set; }
        public string description { get; set; }
        public string ingredients { get; set; }
        public string alternatives { get; set; }

    }
>>>>>>> fd620a89ab765ad29524f4512b4a532feef65325
>>>>>>> 83499ee84be005688bb7f3e09a0e6c98d5c5d410
}