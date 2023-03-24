<<<<<<< HEAD
=======
<<<<<<< HEAD
// File:    PatientRepository.cs
// Author:  LENOVO
// Created: Friday, April 16, 2021 4:08:39 PM
// Purpose: Definition of Class PatientRepository

using System;

namespace Classes.Repository
{
   public class PatientRepository
   {
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
using System;
using Classes.Model;
using Classes.Service;
using Classes.Repository;
using Classes.Controller;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SIMSKT3;
namespace Classes.Repository
{
    public class PatientRepository
   {
      
      public Patient Update(Patient patient)
<<<<<<< HEAD
=======
>>>>>>> fd620a89ab765ad29524f4512b4a532feef65325
>>>>>>> 83499ee84be005688bb7f3e09a0e6c98d5c5d410
      {
         throw new NotImplementedException();
      }
      
<<<<<<< HEAD
      
      public /*GuestAccount*/ void CreateGuest(int id, string name, string surname, string jmbg)
=======
<<<<<<< HEAD
      public void deleteAll()
      {
         throw new NotImplementedException();
      }
      
      public Boolean IsJmbgValid(string jmbg)
=======
      
      public /*GuestAccount*/ void CreateGuest(int id, string name, string surname, string jmbg)
>>>>>>> fd620a89ab765ad29524f4512b4a532feef65325
>>>>>>> 83499ee84be005688bb7f3e09a0e6c98d5c5d410
      {
         throw new NotImplementedException();
      }
      
<<<<<<< HEAD
      public Classes.Model.Patient GetPatientByJMBG(int jmbg)
=======
<<<<<<< HEAD
      public Boolean IsJmbgUnique(string jmbg)
=======
      public Classes.Model.Patient GetPatientByJMBG(int jmbg)
>>>>>>> fd620a89ab765ad29524f4512b4a532feef65325
>>>>>>> 83499ee84be005688bb7f3e09a0e6c98d5c5d410
      {
         throw new NotImplementedException();
      }
      
<<<<<<< HEAD
      public Classes.Model.Patient GetPatientById(int id)
=======
<<<<<<< HEAD
      public Classes.Model.Patient GetPatientByJMBG(int jmbg)
=======
      public Classes.Model.Patient GetPatientById(int id)
>>>>>>> fd620a89ab765ad29524f4512b4a532feef65325
>>>>>>> 83499ee84be005688bb7f3e09a0e6c98d5c5d410
      {
         throw new NotImplementedException();
      }
      
      public int IncreaseCancellationCounter(int patientId)
      {
         throw new NotImplementedException();
      }
      
      public int GetNumberOfCancellations(int patientId)
      {
         throw new NotImplementedException();
      }
      
<<<<<<< HEAD
      public void DisablePatientAccount(int patientId)
=======
<<<<<<< HEAD
      public bool GetPatientStatus(int patientId)
=======
      public void DisablePatientAccount(int patientId)
>>>>>>> fd620a89ab765ad29524f4512b4a532feef65325
>>>>>>> 83499ee84be005688bb7f3e09a0e6c98d5c5d410
      {
         throw new NotImplementedException();
      }
      
<<<<<<< HEAD
      public bool GetPatientStatus(int patientId)
=======
<<<<<<< HEAD
      public bool CheckForNotifications(Classes.Model.Patient patient)
=======
      public bool GetPatientStatus(int patientId)
>>>>>>> fd620a89ab765ad29524f4512b4a532feef65325
>>>>>>> 83499ee84be005688bb7f3e09a0e6c98d5c5d410
      {
         throw new NotImplementedException();
      }
      
<<<<<<< HEAD
=======
<<<<<<< HEAD
      public string path;
   
   }
}
=======
>>>>>>> 83499ee84be005688bb7f3e09a0e6c98d5c5d410
     

        public List<Patient> patients = new List<Patient>();

        public PatientRepository()
        {
            if (!File.Exists("patients.json"))
            {
                File.Create("patients.json").Close();
            }

            using (StreamReader r = new StreamReader("patients.json"))
            {
                string json = r.ReadToEnd();
                if (json != "")
                {
                    patients = JsonConvert.DeserializeObject<List<Patient>>(json);
                }
            }
        }
        public void writeInJson()
        {
            string json = JsonConvert.SerializeObject(patients, Formatting.Indented);
            File.WriteAllText("patients.json", json);
        }

        public void MakeNew(Patient pat)
        {
            patients.Add(pat);
            writeInJson();
        }

        public Patient ReadFromPatientStorage(int id)
        {
            return patients.Find(obj => obj.id == id);
        }

        public void update(Patient pat)
        {
            int index = patients.FindIndex(obj => obj.id == pat.id);
            patients[index] = pat;
            writeInJson();
        }

        public void deletePatientFromStorage(int id)
        {
            int index = patients.FindIndex(obj => obj.id == id);
            patients.RemoveAt(index);
            writeInJson();
        }
        public List<Patient> getAll()
        {
            return patients;
        }

        public void DeletePatientStorage()
        {
            foreach (var pati in patients.ToArray())
            {
                patients.Remove(pati);
            }
            writeInJson();
        }

        
        public string path;

    }
}
<<<<<<< HEAD
=======
>>>>>>> fd620a89ab765ad29524f4512b4a532feef65325
>>>>>>> 83499ee84be005688bb7f3e09a0e6c98d5c5d410
