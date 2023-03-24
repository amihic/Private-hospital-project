// File:    SecretaryController.cs
// Author:  LENOVO
// Created: Friday, April 16, 2021 4:10:59 PM
// Purpose: Definition of Class SecretaryController
//Secretary

using System;
using Classes.Model;
using Classes.Service;
using Classes.Repository;
using Classes.Controller;
using System.Collections.Generic;

namespace Classes.Controller
{
    public class SecretaryController
    {
        public Classes.Model.Appointment CreateAppointment(Classes.Model.Appointment appointment)
        {
            throw new NotImplementedException();
        }

        public Classes.Model.Appointment ReadAppointment(int id)
        {
            throw new NotImplementedException();
        }

        public Classes.Model.Appointment UpdateAppointment(Classes.Model.Appointment appointment)
        {
            throw new NotImplementedException();
        }

        public void DeleteAppointment(Classes.Model.Appointment id)
        {
            throw new NotImplementedException();
        }

        public Classes.Model.Patient CreatePatientAccount(Classes.Model.Patient patient)
        {
            throw new NotImplementedException();
        }

        public Classes.Model.Patient ReadPatientAccount(int id)
        {
            throw new NotImplementedException();
        }

        public Classes.Model.Patient UpdatePatientAccount(Classes.Model.Patient patient)
        {
            throw new NotImplementedException();
        }

        public void DeletePatientAccount(int id)
        {
            throw new NotImplementedException();
        }

        public Classes.Model.GuestAccount CreateGuest(int id, string name, string surname, string jmbg)
        {
            throw new NotImplementedException();
        }

        public Classes.Model.Allergen AddNewAllergen(Classes.Model.Allergen allergen)
        {
            throw new NotImplementedException();
        }

        public Classes.Model.Allergen UpdateAllergen(Classes.Model.Allergen allergen)
        {
            throw new NotImplementedException();
        }

        public List<Allergen> GetAllAlergens(int patientId)
        {
            throw new NotImplementedException();
        }

        public List<Patient> GetAllPatients()
        {
            throw new NotImplementedException();
        }

        public Classes.Service.PatientService patientService;
        public Classes.Service.MedicalRecordService medicalRecordService;
        public Classes.Service.AppointmentService appointmentService;

    }
}
