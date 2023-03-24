<<<<<<< HEAD
=======
<<<<<<< HEAD
// File:    AppointmentController.cs
// Author:  HP-Miha
// Created: Friday, April 9, 2021 4:41:45 PM
// Purpose: Definition of Class AppointmentController

>>>>>>> 83499ee84be005688bb7f3e09a0e6c98d5c5d410
using System;

=======
using System;
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
   public class AppointmentController
   {
<<<<<<< HEAD
=======
<<<<<<< HEAD
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
=======
>>>>>>> 83499ee84be005688bb7f3e09a0e6c98d5c5d410
        AppointmentService appointmentService = new AppointmentService();

        public Classes.Model.Appointment CreateAppointment(int id, DateTime date, DateTime startTime, DateTime endTime, Classes.Model.Doctor doctor, Classes.Model.Patient patient)
        {
            throw new NotImplementedException();
        }

        public Classes.Model.Appointment ReadAppointment(int id)
        {
            return appointmentService.GetById(id);

        }

        public void create(Appointment appointment)
        {
            appointmentService.CreateAppointment(appointment);
        }
        public Classes.Model.Appointment UpdateAppointment(int id, DateTime date, DateTime startTime, DateTime endTime, Classes.Model.Doctor doctor, Classes.Model.Patient patient)
        {
            throw new NotImplementedException();
        }

        public void DeleteAppointment(int id)
        {
            appointmentService.DeleteAppointment(id);
        }

        public void deleteAll()
        {
            throw new NotImplementedException();
        }

        public List<Appointment> readAll()
        {
            throw new NotImplementedException();
        }

        public List<Room> RoomSelection(string staticEquip)
        {
            throw new NotImplementedException();
        }

       
<<<<<<< HEAD
      
      public Classes.Model.Appointment CreateEmergency(Classes.Model.Patient patient, string specialization)
=======
      
      public Classes.Model.Appointment CreateEmergency(Classes.Model.Patient patient, string specialization)
>>>>>>> fd620a89ab765ad29524f4512b4a532feef65325
      {
         throw new NotImplementedException();
      }
      
<<<<<<< HEAD
      public List<Appointment> readAllAppointments()
=======
      public List<Appointment> ReadDoctorAppointments(int doctorId)
>>>>>>> fd620a89ab765ad29524f4512b4a532feef65325
      {
         throw new NotImplementedException();
      }
      
<<<<<<< HEAD
      public Classes.Model.Appointment CreateEmergency(Classes.Model.Patient patient, string specialization)
=======
      public List<Appointment> ReadPatientAppointments(int patientId)
>>>>>>> fd620a89ab765ad29524f4512b4a532feef65325
>>>>>>> 83499ee84be005688bb7f3e09a0e6c98d5c5d410
      {
         throw new NotImplementedException();
      }
      
<<<<<<< HEAD
=======
<<<<<<< HEAD
>>>>>>> 83499ee84be005688bb7f3e09a0e6c98d5c5d410
      public List<Appointment> ReadDoctorAppointments(int doctorId)
      {
         throw new NotImplementedException();
      }
      
      public List<Appointment> ReadPatientAppointments(int patientId)
      {
         throw new NotImplementedException();
      }
      
<<<<<<< HEAD
=======
=======
>>>>>>> fd620a89ab765ad29524f4512b4a532feef65325
>>>>>>> 83499ee84be005688bb7f3e09a0e6c98d5c5d410
      public bool CheckForInvalidInput(Classes.Model.Appointment appointment)
      {
         throw new NotImplementedException();
      }
      
      //public Classes.Service.AppointmentService appointmentService;
   
   }
}