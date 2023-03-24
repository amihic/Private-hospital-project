<<<<<<< HEAD
=======
<<<<<<< HEAD
>>>>>>> 83499ee84be005688bb7f3e09a0e6c98d5c5d410
// File:    MedicineController.cs
// Author:  LifeBook A574
// Created: Monday, April 26, 2021 4:49:04 PM
// Purpose: Definition of Class MedicineController

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
>>>>>>> fd620a89ab765ad29524f4512b4a532feef65325

>>>>>>> 83499ee84be005688bb7f3e09a0e6c98d5c5d410
namespace Classes.Controller
{
   public class MedicineController
   {
<<<<<<< HEAD
      public void VerificateMedicine(int medicineId)
=======
<<<<<<< HEAD
      public void CreateMedicine(Medicine medicine)
=======
        MedicineService medicineService = new MedicineService();

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
            medicineService.UpdateMedicine(medicine);
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
=======
      public void DeclineMedicine(int medicineId, string reason)
>>>>>>> 83499ee84be005688bb7f3e09a0e6c98d5c5d410
      {
         throw new NotImplementedException();
      }
      
      public Classes.Service.MedicineService medicineService;
<<<<<<< HEAD
=======
=======
      public void CreateMedicine(Medicine medicine)
      {
            medicineService.CreateMedicine(medicine);
      }
      
      public void DeleteMedicine(int medicineId)
      {
            medicineService.DeleteMedicine(medicineId);
        }
>>>>>>> fd620a89ab765ad29524f4512b4a532feef65325
>>>>>>> 83499ee84be005688bb7f3e09a0e6c98d5c5d410
   
   }
}