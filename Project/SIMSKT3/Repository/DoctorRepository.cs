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
    public class DoctorRepository
    {


        public List<Doctor> doctors = new List<Doctor>();

        public DoctorRepository()
        {
            if (!File.Exists("doctors.json"))
            {
                File.Create("doctors.json").Close();
            }

            using (StreamReader r = new StreamReader("doctors.json"))
            {
                string json = r.ReadToEnd();
                if (json != "")
                {
                    doctors = JsonConvert.DeserializeObject<List<Doctor>>(json);
                }
            }
        }
        public void writeInJson()
        {
            string json = JsonConvert.SerializeObject(doctors, Formatting.Indented);
            File.WriteAllText("doctors.json", json);
        }
        public List<Doctor> getAll()
        {
            return doctors;
        }

        public void save(Classes.Model.Doctor doctor)
        {
            throw new NotImplementedException();
        }

        public void delete(int id)
        {
            throw new NotImplementedException();
        }

        public Classes.Model.Doctor getById(int id)
        {
            throw new NotImplementedException();
        }

        public Classes.Model.Doctor update(Classes.Model.Doctor doctor)
        {
            throw new NotImplementedException();
        }

        public string path;

    }
}