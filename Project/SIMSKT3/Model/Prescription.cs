// File:    Prescription.cs
// Author:  HP-Miha
// Created: Thursday, April 8, 2021 7:20:33 PM
// Purpose: Definition of Class Prescription

using System;
<<<<<<< HEAD
=======
<<<<<<< HEAD

=======
>>>>>>> 83499ee84be005688bb7f3e09a0e6c98d5c5d410
using Classes.Model;
using Classes.Service;
using Classes.Repository;
using Classes.Controller;
using System.Collections.Generic;
<<<<<<< HEAD
=======
>>>>>>> fd620a89ab765ad29524f4512b4a532feef65325
>>>>>>> 83499ee84be005688bb7f3e09a0e6c98d5c5d410
namespace Classes.Model
{
<<<<<<< Updated upstream
   public class Prescription
   {
      public int id;
      public string usage;
      public int quantity;
      
<<<<<<< HEAD
=======
<<<<<<< HEAD
      public System.Collections.Generic.List<Medicine> medicine;
      
      /// <summary>
      /// Property for collection of Medicine
      /// </summary>
      /// <pdGenerated>Default opposite class collection property</pdGenerated>
      public System.Collections.Generic.List<Medicine> Medicine
      {
         get
         {
            if (medicine == null)
               medicine = new System.Collections.Generic.List<Medicine>();
            return medicine;
         }
         set
         {
            RemoveAllMedicine();
            if (value != null)
            {
               foreach (Medicine oMedicine in value)
                  AddMedicine(oMedicine);
            }
         }
      }
      
      /// <summary>
      /// Add a new Medicine in the collection
      /// </summary>
      /// <pdGenerated>Default Add</pdGenerated>
      public void AddMedicine(Medicine newMedicine)
      {
         if (newMedicine == null)
            return;
         if (this.medicine == null)
            this.medicine = new System.Collections.Generic.List<Medicine>();
         if (!this.medicine.Contains(newMedicine))
            this.medicine.Add(newMedicine);
      }
      
      /// <summary>
      /// Remove an existing Medicine from the collection
      /// </summary>
      /// <pdGenerated>Default Remove</pdGenerated>
      public void RemoveMedicine(Medicine oldMedicine)
      {
         if (oldMedicine == null)
            return;
         if (this.medicine != null)
            if (this.medicine.Contains(oldMedicine))
               this.medicine.Remove(oldMedicine);
      }
      
      /// <summary>
      /// Remove all instances of Medicine from the collection
      /// </summary>
      /// <pdGenerated>Default removeAll</pdGenerated>
      public void RemoveAllMedicine()
      {
         if (medicine != null)
            medicine.Clear();
      }
=======
>>>>>>> fd620a89ab765ad29524f4512b4a532feef65325
>>>>>>> 83499ee84be005688bb7f3e09a0e6c98d5c5d410
      public MedicalRecord medicalRecord;
      
      /// <summary>
      /// Property for MedicalRecord
      /// </summary>
      /// <pdGenerated>Default opposite class property</pdGenerated>
<<<<<<< HEAD
=======
<<<<<<< HEAD
      public MedicalRecord MedicalRecord
      {
         get
         {
            return medicalRecord;
         }
         set
         {
            if (this.medicalRecord == null || !this.medicalRecord.Equals(value))
            {
               if (this.medicalRecord != null)
               {
                  MedicalRecord oldMedicalRecord = this.medicalRecord;
                  this.medicalRecord = null;
                  oldMedicalRecord.RemovePrescription(this);
               }
               if (value != null)
               {
                  this.medicalRecord = value;
                  this.medicalRecord.AddPrescription(this);
               }
            }
         }
      }
=======
>>>>>>> 83499ee84be005688bb7f3e09a0e6c98d5c5d410
      //public MedicalRecord MedicalRecord
      //{
      //   get
      //   {
      //      return medicalRecord;
      //   }
      //   set
      //   {
      //      if (this.medicalRecord == null || !this.medicalRecord.Equals(value))
      //      {
      //         if (this.medicalRecord != null)
      //         {
      //            MedicalRecord oldMedicalRecord = this.medicalRecord;
      //            this.medicalRecord = null;
      //            oldMedicalRecord.RemovePrescription(this);
      //         }
      //         if (value != null)
      //         {
      //            this.medicalRecord = value;
      //            this.medicalRecord.AddPrescription(this);
      //         }
      //      }
      //   }
      //}
<<<<<<< HEAD
=======
>>>>>>> fd620a89ab765ad29524f4512b4a532feef65325
>>>>>>> 83499ee84be005688bb7f3e09a0e6c98d5c5d410
   
   }
=======
    public partial class Prescription
    {
        public string id { get; set; }
        public string pati { get; set; }
        public string medicine { get; set; }
        public string usage { get; set; }
        public string quantity { get; set; }


        public Prescription() { }
        public Prescription create(int id, string medicine, string usage, string quantity)
        {
            throw new NotImplementedException();
        }

        public Prescription read(int id)
        {
            throw new NotImplementedException();
        }

        public Prescription update(int id, string medicine, string usage, string quantity)
        {
            throw new NotImplementedException();
        }

        public void delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Prescription> readAll()
        {
            throw new NotImplementedException();
        }

        public void deleteAll()
        {
            throw new NotImplementedException();
        }
    }
>>>>>>> Stashed changes
}