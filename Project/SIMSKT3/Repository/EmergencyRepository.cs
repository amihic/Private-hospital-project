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
    public class EmergencyRepository
    {
        public List<Patient> patients = new List<Patient>();

        public EmergencyRepository()
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

        //public void MakeNew(PatientAccount pat)
        //{
        //    patients.Add(pat);
        //    writeInJson();
        //}

        //public void ReadFromPatientStorage(int id)
        //{

        //}

        //public void update(PatientAccount pat)
        //{
        //    int index = patients.FindIndex(obj => obj.id == pat.id);
        //    patients[index] = pat;
        //    writeInJson();
        //}

        public void deletePatientFromStorage(int id)
        {
            int index = patients.FindIndex(obj => obj.id == id);
            patients.RemoveAt(index);
            writeInJson();
        }
        //public List<PatientAccount> getAll()
        //{
        //    return patients;
        //}

        //public void DeletePatientStorage()
        //{
        //    foreach (var pati in patients.ToArray())
        //    {
        //        patients.Remove(pati);
        //    }
        //    writeInJson();
        //}

        /*
        public void ShiftStaticEquipment(Classes.Model.Room fromRoom, Classes.Model.Room toRoom, double quantity)
        {
            throw new NotImplementedException();
        }

        public void TransferSuccessfull(string notification)
        {
            throw new NotImplementedException();
        }

        public List<Room> SelectRoomByStaticEquip(string staticEquip)
        {
            throw new NotImplementedException();
        }
        */
        public string path;

    }
}


