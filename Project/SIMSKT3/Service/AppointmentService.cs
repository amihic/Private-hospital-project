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
   public class AppointmentService
   {
<<<<<<< HEAD
=======
<<<<<<< HEAD
      public Classes.Model.Appointment CreateAppointment(Classes.Model.Appointment appointment, int patientId)
=======
>>>>>>> 83499ee84be005688bb7f3e09a0e6c98d5c5d410
        AppointmentRepository appointmentRepository = new AppointmentRepository();

        public Classes.Model.Appointment update(Classes.Model.Appointment appointment)
        {
            throw new NotImplementedException();
        }

        public void CreateAppointment(Appointment appointment)
        {
            appointmentRepository.MakeNew(appointment);
        }
        public void DeleteAppointment(int id)
        {
            appointmentRepository.DeleteAppById(id);
        }

        public List<Appointment> PatientReadAll()
        {
            throw new NotImplementedException();
        }

        public List<Appointment> DoctorReadAll()
        {
            throw new NotImplementedException();
        }

        

        public List<String> DoctorPriority()
        {
            throw new NotImplementedException();
        }

        public List<Doctor> TimePriority()
        {
            throw new NotImplementedException();
        }

        public Appointment GetById(int id)
        {
            return appointmentRepository.readAppointment(id);
        }

      
      
      public List<Appointment> ReadDoctorAppointments(int doctorId)
      {
         throw new NotImplementedException();
      }
      
      public List<Appointment> ReadPatientAppointments(int patientId)
<<<<<<< HEAD
=======
>>>>>>> fd620a89ab765ad29524f4512b4a532feef65325
>>>>>>> 83499ee84be005688bb7f3e09a0e6c98d5c5d410
      {
         throw new NotImplementedException();
      }
      
<<<<<<< HEAD
      public Classes.Model.Appointment UpdateAppointment(Classes.Model.Appointment appointment)
=======
<<<<<<< HEAD
      public Classes.Model.Appointment ReadAppointment(int appointmentId)
=======
      public Classes.Model.Appointment UpdateAppointment(Classes.Model.Appointment appointment)
>>>>>>> fd620a89ab765ad29524f4512b4a532feef65325
>>>>>>> 83499ee84be005688bb7f3e09a0e6c98d5c5d410
      {
         throw new NotImplementedException();
      }
      
<<<<<<< HEAD
     
      
      public List<Appointment> GetAppointmetnsByDoctorPriority(int doctorId)
=======
<<<<<<< HEAD
      public Classes.Model.Appointment UpdateAppointment(Classes.Model.Appointment appointment)
=======
     
      
      public List<Appointment> GetAppointmetnsByDoctorPriority(int doctorId)
>>>>>>> fd620a89ab765ad29524f4512b4a532feef65325
>>>>>>> 83499ee84be005688bb7f3e09a0e6c98d5c5d410
      {
         throw new NotImplementedException();
      }
      
<<<<<<< HEAD
      public List<Appointment> GetAppointmetnsByTimePriority(DateTime dateTime)
=======
<<<<<<< HEAD
      public void DeleteAppointment(int appointmentId)
=======
      public List<Appointment> GetAppointmetnsByTimePriority(DateTime dateTime)
>>>>>>> fd620a89ab765ad29524f4512b4a532feef65325
>>>>>>> 83499ee84be005688bb7f3e09a0e6c98d5c5d410
      {
         throw new NotImplementedException();
      }
      
<<<<<<< HEAD
      public List<Room> RoomSelection(string staticEquip)
=======
<<<<<<< HEAD
      public List<Appointment> readAllAppointments()
=======
      public List<Room> RoomSelection(string staticEquip)
>>>>>>> fd620a89ab765ad29524f4512b4a532feef65325
>>>>>>> 83499ee84be005688bb7f3e09a0e6c98d5c5d410
      {
         throw new NotImplementedException();
      }
      
      public Classes.Model.Appointment CreateEmergency(Classes.Model.Patient patient, string specialization)
      {
         throw new NotImplementedException();
      }
      
<<<<<<< HEAD
      public bool CheckPatientStatus(int patientId)
=======
<<<<<<< HEAD
      public List<Appointment> ReadDoctorAppointments(int doctorId)
=======
      public bool CheckPatientStatus(int patientId)
>>>>>>> fd620a89ab765ad29524f4512b4a532feef65325
>>>>>>> 83499ee84be005688bb7f3e09a0e6c98d5c5d410
      {
         throw new NotImplementedException();
      }
      
<<<<<<< HEAD
      public Classes.Model.Appointment ReadAppointment(int appointmentId)
=======
<<<<<<< HEAD
      public List<Appointment> ReadPatientAppointments(int patientId)
=======
      public Classes.Model.Appointment ReadAppointment(int appointmentId)
>>>>>>> fd620a89ab765ad29524f4512b4a532feef65325
>>>>>>> 83499ee84be005688bb7f3e09a0e6c98d5c5d410
      {
         throw new NotImplementedException();
      }
      
      public bool CheckForInvalidInput(Classes.Model.Appointment appointment)
      {
         throw new NotImplementedException();
      }
      
<<<<<<< HEAD
      //public Classes.Repository.AppointmentRepository appointmentRepository;
      //public Classes.Repository.RoomRepository roomRepository;
=======
<<<<<<< HEAD
      public Classes.Repository.AppointmentRepository appointmentRepository;
      public Classes.Repository.RoomRepository roomRepository;
=======
      //public Classes.Repository.AppointmentRepository appointmentRepository;
      //public Classes.Repository.RoomRepository roomRepository;
>>>>>>> fd620a89ab765ad29524f4512b4a532feef65325
>>>>>>> 83499ee84be005688bb7f3e09a0e6c98d5c5d410
   
   }
}