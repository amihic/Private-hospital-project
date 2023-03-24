using System;
using Classes.Model;
using Classes.Service;
using Classes.Repository;
using Classes.Controller;
using System.Collections.Generic;

namespace Classes.Controller
{
    public class DoctorController
    {

        DoctorService doctorService = new DoctorService();

        public List<Doctor> readAll()
        {
            return doctorService.GetAll();
        }

        public List<Appointment> GetAllAppointments()
        {
            throw new NotImplementedException();
        }

        public MedicalRecord GetMedicalRecord(int patientId)
        {
            throw new NotImplementedException();
        }

        public Classes.Model.Anamnesis CreateAnamnesis(int id, string name, string description)
        {
            throw new NotImplementedException();
        }

        public Classes.Model.Anamnesis UpdateAnamnesis(int id, string name, string description)
        {
            throw new NotImplementedException();
        }

        public Classes.Model.Prescription AddPrescription(int id, string medicine, string usage, string quantity)
        {
            throw new NotImplementedException();
        }

        public Classes.Service.AppointmentService appointmentService;
        public Classes.Service.MedicalRecordService medicalRecordService;

    }
}