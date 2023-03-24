<<<<<<< HEAD
=======
<<<<<<< HEAD
// File:    AppointmentRepository.cs
// Author:  HP-Miha
// Created: Friday, April 9, 2021 5:43:56 PM
// Purpose: Definition of Class AppointmentRepository

using System;

namespace Classes.Repository
{
   public class AppointmentRepository
   {
      public Classes.Model.Appointment CreateAppointment(Classes.Model.Appointment appointment, int patientId)
      {
         throw new NotImplementedException();
      }
      
      public Classes.Model.Appointment ReadAppointment(int appointmentId)
      {
         throw new NotImplementedException();
      }
      
      public Classes.Model.Appointment UpdateAppointment(Classes.Model.Appointment appointment)
      {
         throw new NotImplementedException();
      }
      
      public void DeleteAppointment(int appointmentId)
      {
         throw new NotImplementedException();
      }
      
      public List<Appointment> readAllAppointments()
      {
         throw new NotImplementedException();
      }
      
      public Classes.Model.Appointment CreateEmergency(Classes.Model.Patient patient, string specialization)
      {
         throw new NotImplementedException();
      }
      
      public List<Appointment> ReadDoctorAppointments(int doctorId)
      {
         throw new NotImplementedException();
      }
      
      public List<Appointment> ReadPatientAppointments(int patientId)
      {
         throw new NotImplementedException();
      }
      
      public bool CheckForInvalidInput(Classes.Model.Appointment appointment)
      {
         throw new NotImplementedException();
      }
      
      public string path;
   
   }
}
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
namespace Classes.Repository
{
    public class AppointmentRepository
    {
        public List<Appointment> appointments = new List<Appointment>();

        public AppointmentRepository()
        {
            if (!File.Exists("Appoint.json"))
            {
                File.Create("Appoint.json").Close();
            }

            using (StreamReader r = new StreamReader("Appoint.json"))
            {
                string json = r.ReadToEnd();
                if (json != "")
                {
                    appointments = JsonConvert.DeserializeObject<List<Appointment>>(json);
                }
            }
        }
        public void writeInJson()
        {
            string json = JsonConvert.SerializeObject(appointments, Formatting.Indented);
            File.WriteAllText("Appoint.json", json);
        }
        public void MakeNew(Appointment appointment)
        {
            appointments.Add(appointment);
            writeInJson();
        }
        public Appointment readAppointment(int id)
        {
            return appointments.Find(obj => obj.id == id);
        }

        public void DeleteAppById(int id)
        {
            foreach (var ap in appointments.ToArray())
            {
                if (ap.id == id)
                {
                    appointments.Remove(ap);
                    writeInJson();
                }
            }
        }


        public Classes.Model.Appointment update(Classes.Model.Appointment appointment)
        {
            throw new NotImplementedException();
        }

        //public Classes.Model.Appointment readAppointment(int appointmentId)
        //{
        //    throw new NotImplementedException();
        //}

        public List<Appointment> getAll()
        {
            throw new NotImplementedException();
        }

        public void deleteAppointment(int appointmentId, int patientId)
        {
            throw new NotImplementedException();
        }

        public void save(Classes.Model.Appointment appointment)
        {
            throw new NotImplementedException();
        }

        public Classes.Model.Appointment CreateEmergency(Classes.Model.Patient patient, string specialization)
        {
            throw new NotImplementedException();
        }

        public Classes.Model.Appointment CreateAppointment(Classes.Model.Appointment appointment, int patientId)
        {
            throw new NotImplementedException();
        }

        public List<Appointment> ReadDoctorAppointments(int doctorId)
        {
            throw new NotImplementedException();
        }

        public List<Appointment> ReadPatientAppointments(int patientId)
        {
            throw new NotImplementedException();
        }

        public bool CheckForInvalidInput(Classes.Model.Appointment appointment)
        {
            throw new NotImplementedException();
        }

        public string path;

    }
}
<<<<<<< HEAD
=======
>>>>>>> fd620a89ab765ad29524f4512b4a532feef65325
>>>>>>> 83499ee84be005688bb7f3e09a0e6c98d5c5d410
