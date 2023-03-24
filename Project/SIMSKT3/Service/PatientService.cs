// File:    PatientService.cs
// Author:  HP-Miha
// Created: Friday, April 16, 2021 10:41:45 PM
// Purpose: Definition of Class PatientService

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
namespace Classes.Service
{
   public class PatientService
   {
<<<<<<< HEAD
=======
<<<<<<< HEAD
      public Classes.Model.Patient CreatePatient(Classes.Model.Patient patient)
      {
         throw new NotImplementedException();
      }
      
      public Classes.Model.Patient ReadPatient(int patientId)
      {
         throw new NotImplementedException();
      }
      
      public Classes.Model.Patient UpdatePatient(Classes.Model.Patient patient)
      {
         throw new NotImplementedException();
      }
      
      public void DeletePatient(int patientId)
      {
         throw new NotImplementedException();
      }
      
      public List<Patient> GetAllPatients()
=======
>>>>>>> 83499ee84be005688bb7f3e09a0e6c98d5c5d410

        PatientRepository patientRepository = new PatientRepository();
        public void UpdatePatientAccount(Patient pat)
        {
            patientRepository.update(pat);
        }

        public Patient ReadPatientAccount(int id)
        {
            return patientRepository.ReadFromPatientStorage(id);
        }

        public List<Patient> GetAllPatientAccounts()
        {
            return patientRepository.getAll();
        }

        public void DeletePatientAccount(int id)
        {
            patientRepository.deletePatientFromStorage(id);
        }
        public void removeAllPatients()
        {
            patientRepository.DeletePatientStorage();
        }
        public void CreatePatientAccount(Patient pat)
        {
            patientRepository.MakeNew(pat);
        }

        //public Classes.Repository.PatientRepository patientRepository;
        public Classes.Repository.GuestAccountRepository guestAccountRepository;

    
      public /*GuestAccount*/void CreateGuest(int id, string name, string surname, string jmbg)
<<<<<<< HEAD
=======
>>>>>>> fd620a89ab765ad29524f4512b4a532feef65325
>>>>>>> 83499ee84be005688bb7f3e09a0e6c98d5c5d410
      {
         throw new NotImplementedException();
      }
      
<<<<<<< HEAD
      public Boolean IsJmbgValid(string jmbg)
=======
<<<<<<< HEAD
      public void deleteAll()
=======
      public Boolean IsJmbgValid(string jmbg)
>>>>>>> fd620a89ab765ad29524f4512b4a532feef65325
>>>>>>> 83499ee84be005688bb7f3e09a0e6c98d5c5d410
      {
         throw new NotImplementedException();
      }
      
<<<<<<< HEAD
      public Boolean IsJmbgUnique(string jmbg)
=======
<<<<<<< HEAD
      public Boolean IsJmbgValid(string jmbg)
=======
      public Boolean IsJmbgUnique(string jmbg)
>>>>>>> fd620a89ab765ad29524f4512b4a532feef65325
>>>>>>> 83499ee84be005688bb7f3e09a0e6c98d5c5d410
      {
         throw new NotImplementedException();
      }
      
<<<<<<< HEAD
      public Classes.Model.Patient GetPatientById(int id)
=======
<<<<<<< HEAD
      public Boolean IsJmbgUnique(string jmbg)
=======
      public Classes.Model.Patient GetPatientById(int id)
>>>>>>> fd620a89ab765ad29524f4512b4a532feef65325
>>>>>>> 83499ee84be005688bb7f3e09a0e6c98d5c5d410
      {
         throw new NotImplementedException();
      }
      
      public Classes.Model.Patient GetPatientByJMBG(int jmbg)
      {
         throw new NotImplementedException();
      }
      
      public int IncreaseCancellationCounter(int patientId)
      {
         throw new NotImplementedException();
      }
      
<<<<<<< HEAD
      public bool GetPatientStatus(int patientId)
=======
<<<<<<< HEAD
      public int GetNumberOfCancellations(int patientId)
=======
      public bool GetPatientStatus(int patientId)
>>>>>>> fd620a89ab765ad29524f4512b4a532feef65325
>>>>>>> 83499ee84be005688bb7f3e09a0e6c98d5c5d410
      {
         throw new NotImplementedException();
      }
      
<<<<<<< HEAD
      public bool CheckNumberOfCancellations(int patientId)
=======
<<<<<<< HEAD
      public bool GetPatientStatus(int patientId)
=======
      public bool CheckNumberOfCancellations(int patientId)
>>>>>>> fd620a89ab765ad29524f4512b4a532feef65325
>>>>>>> 83499ee84be005688bb7f3e09a0e6c98d5c5d410
      {
         throw new NotImplementedException();
      }
      
      public bool CheckForNotifications(Classes.Model.Patient patient)
      {
         throw new NotImplementedException();
      }
      
<<<<<<< HEAD
      //public Classes.Repository.PatientRepository patientRepository;
=======
<<<<<<< HEAD
      public Classes.Repository.PatientRepository patientRepository;
=======
      //public Classes.Repository.PatientRepository patientRepository;
>>>>>>> fd620a89ab765ad29524f4512b4a532feef65325
>>>>>>> 83499ee84be005688bb7f3e09a0e6c98d5c5d410
   
   }
}