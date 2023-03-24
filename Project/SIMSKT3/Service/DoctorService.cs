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
    public class DoctorService
    {
        DoctorRepository doctorRepository = new DoctorRepository();


        public List<Doctor> GetAll()
        {
            return doctorRepository.getAll();
        }
    }
}
