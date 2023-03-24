// File:    PatientController.cs
// Author:  LifeBook A574
// Created: Monday, April 26, 2021 3:37:05 PM
// Purpose: Definition of Class PatientController

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
namespace Classes.Controller
{
   public class PatientController
   {
<<<<<<< HEAD
=======
<<<<<<< HEAD
      public Classes.Model.Patient CreatePatient(Classes.Model.Patient patient)
=======
>>>>>>> 83499ee84be005688bb7f3e09a0e6c98d5c5d410
      
      
     
      
      public Classes.Model.Patient UpdatePatientAccount(Classes.Model.Patient patient)
      {
         throw new NotImplementedException();
      }
      
      
      
      public /*GuestAccount*/ void CreateGuest(int id, string name, string surname, string jmbg)
      {
         throw new NotImplementedException();
      }
      
      public Boolean IsJmbgValid(string jmbg)
      {
         throw new NotImplementedException();
      }
      
      public Boolean IsJmbgUnique(string jmbg)
      {
         throw new NotImplementedException();
      }
      
      public Classes.Model.Patient GetPatientById(int id)
      {
         throw new NotImplementedException();
      }
      
      public Classes.Model.Patient GetPatientByJMBG(int jmbg)
<<<<<<< HEAD
=======
>>>>>>> fd620a89ab765ad29524f4512b4a532feef65325
      {
         throw new NotImplementedException();
      }
      
<<<<<<< HEAD
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
      {
         throw new NotImplementedException();
      }
      
      public void deleteAll()
      {
         throw new NotImplementedException();
      }
      
      public Boolean IsJmbgValid(string jmbg)
      {
         throw new NotImplementedException();
      }
      
      public Boolean IsJmbgUnique(string jmbg)
      {
         throw new NotImplementedException();
      }
      
      public Classes.Model.Patient GetPatientByJMBG(int jmbg)
      {
         throw new NotImplementedException();
      }
      
=======
>>>>>>> fd620a89ab765ad29524f4512b4a532feef65325
      public int IncreaseCancellationCounter(int patientId)
>>>>>>> 83499ee84be005688bb7f3e09a0e6c98d5c5d410
      {
         throw new NotImplementedException();
      }
      
<<<<<<< HEAD
      public int IncreaseCancellationCounter(int patientId)
      {
         throw new NotImplementedException();
      }
      
=======
>>>>>>> 83499ee84be005688bb7f3e09a0e6c98d5c5d410
      public int GetNumberOfCancellations(int patientId)
      {
         throw new NotImplementedException();
      }
      
      public bool GetPatientStatus(int patientId)
      {
         throw new NotImplementedException();
      }
      
      public bool CheckForNotifications(Classes.Model.Patient patient)
      {
         throw new NotImplementedException();
      }
      
<<<<<<< HEAD
=======
<<<<<<< HEAD
      public Classes.Service.PatientService patientService;
   
   }
=======
>>>>>>> 83499ee84be005688bb7f3e09a0e6c98d5c5d410
      //public Classes.Service.PatientService patientService;



        public Classes.Service.AppointmentService appointmentService;

        PatientService patientService = new PatientService();
        public void CreatePatientAccount(Patient pat)
        {
            patientService.CreatePatientAccount(pat);
        }

        public Patient ReadPatientAccount(int id)
        {
            return patientService.ReadPatientAccount(id);
        }

        public void DeletePatientAccount(int id)
        {
            patientService.DeletePatientAccount(id);
        }

        public List<Patient> GetAllPatientAccounts()
        {
            return patientService.GetAllPatientAccounts();
        }

        public void deleteAll()
        {
            patientService.removeAllPatients();
        }

    }
<<<<<<< HEAD
=======
>>>>>>> fd620a89ab765ad29524f4512b4a532feef65325
>>>>>>> 83499ee84be005688bb7f3e09a0e6c98d5c5d410
}