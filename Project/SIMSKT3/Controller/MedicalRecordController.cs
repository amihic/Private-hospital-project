// File:    MedicalRecordController.cs
// Author:  LifeBook A574
// Created: Saturday, April 24, 2021 5:53:26 PM
// Purpose: Definition of Class MedicalRecordController

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
namespace Classes.Controller
{
   public class MedicalRecordController
   {
      public int CreateMedicalRecord(Classes.Model.MedicalRecord medicalRecord)
      {
         throw new NotImplementedException();
      }
      
      public Classes.Model.MedicalRecord UpdateMedicalRecord(Classes.Model.MedicalRecord medicalRecord)
      {
         throw new NotImplementedException();
      }
      
      public Classes.Model.MedicalRecord GetMedicalRecordById(int id)
      {
         throw new NotImplementedException();
      }
      
      public void removeMR(int id)
      {
         throw new NotImplementedException();
      }
      
      public List<MedicalRecord> GetAllMedicalRecords()
      {
         throw new NotImplementedException();
      }
      
      public Classes.Model.Allergen AddNewAllergen(string name, DateTime date)
      {
         throw new NotImplementedException();
      }
      
      public Classes.Model.Allergen UpdateAllergen(string name, DateTime date)
      {
         throw new NotImplementedException();
      }
      
      public List<Allergen> GetAllAlergens(int patientId)
      {
         throw new NotImplementedException();
      }
      
      public Classes.Model.Prescription AddPrescription(int id, string medicine, string usage, string quantity)
      {
         throw new NotImplementedException();
      }
      
      public Classes.Model.Prescription GetPrescriptionById(int prescriptionId)
      {
         throw new NotImplementedException();
      }
      
      public Classes.Model.Anamnesis CreateAnamnesis(Classes.Model.Anamnesis anamnesis)
      {
         throw new NotImplementedException();
      }
      
      public Classes.Model.Anamnesis UpdateAnamnesis(Classes.Model.Anamnesis anamnesis)
      {
         throw new NotImplementedException();
      }
      
      public Classes.Service.MedicalRecordService medicalRecordService;
   
   }
}