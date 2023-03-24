// File:    MedicalRecordService.cs
// Author:  LENOVO
// Created: Friday, April 9, 2021 10:34:19 PM
// Purpose: Definition of Class MedicalRecordService

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
>>>>>>> fd620a89ab765ad29524f4512b4a532feef65325
>>>>>>> 83499ee84be005688bb7f3e09a0e6c98d5c5d410
namespace Classes.Service
{
   public class MedicalRecordService
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
<<<<<<< HEAD
=======
<<<<<<< HEAD
>>>>>>> 83499ee84be005688bb7f3e09a0e6c98d5c5d410
      {
         throw new NotImplementedException();
      }
      
      public Classes.Model.Allergen UpdateAllergen(string name, DateTime date)
<<<<<<< HEAD
=======
=======
>>>>>>> fd620a89ab765ad29524f4512b4a532feef65325
>>>>>>> 83499ee84be005688bb7f3e09a0e6c98d5c5d410
      {
         throw new NotImplementedException();
      }
      
<<<<<<< HEAD
=======
<<<<<<< HEAD
=======
      public Classes.Model.Allergen UpdateAllergen(string name, DateTime date)
      {
         throw new NotImplementedException();
      }
      
>>>>>>> fd620a89ab765ad29524f4512b4a532feef65325
>>>>>>> 83499ee84be005688bb7f3e09a0e6c98d5c5d410
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
      
      public Classes.Repository.MedicalRecordRepository medicalRecordRepository;
   
   }
}