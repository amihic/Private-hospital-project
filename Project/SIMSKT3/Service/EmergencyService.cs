using System;
using Classes.Model;
using Classes.Service;
using Classes.Repository;
using Classes.Controller;
using System.Collections.Generic;
using SIMSKT3;
//namespace SIMSKT3.Service
namespace Classes.Service
{
    public class EmergencyService
    {

        EmergencyRepository emergencyRepository = new EmergencyRepository();
        public void removePatient(int id)
        {
            emergencyRepository.deletePatientFromStorage(id);
        }

        //public Classes.Repository.EmergencyRepository emergencyRepository;

        //public void Update(PatientAccount pat)
        //{
        //    patientRepository.update(pat);
        //}

        //public void GetById(int id)
        //{
        //    patientRepository.ReadFromPatientStorage(id);
        //}

        //public List<PatientAccount> GetAll()
        //{
        //    return patientRepository.getAll();
        //}


        //public void removeAllPatients()
        //{
        //    patientRepository.DeletePatientStorage();
        //}
        //public void Save(PatientAccount pat)
        //{
        //    patientRepository.MakeNew(pat);
        //}

        // public Classes.Repository.GuestAccountRepository guestAccountRepository;

    }
}

