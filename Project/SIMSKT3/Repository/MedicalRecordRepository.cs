using System;

namespace Classes.Repository
{
<<<<<<< HEAD
=======
<<<<<<< HEAD
   public class MedicalRecordRepository
   {
      public int CreateMedicalRecord(Classes.Model.MedicalRecord medicalRecord)
      {
         throw new NotImplementedException();
      }
      
      public Classes.Model.MedicalRecord UpdateMedicalRecord(Classes.Model.MedicalRecord medicalRecord)
      {
         throw new NotImplementedException();
      }
      
      public Classes.Model.MedicalRecord GetMedicalRecordById(int id)
      {
         throw new NotImplementedException();
      }
      
      public void removeMR(int id)
      {
         throw new NotImplementedException();
      }
      
      public List<MedicalRecord> GetAllMedicalRecords()
      {
         throw new NotImplementedException();
      }
      
      public Classes.Model.Allergen AddNewAllergen(string name, DateTime date)
      {
         throw new NotImplementedException();
      }
      
      public Classes.Model.Allergen UpdateAllergen(string name, DateTime date)
      {
         throw new NotImplementedException();
      }
      
      public List<Allergen> GetAllAlergens(int patientId)
      {
         throw new NotImplementedException();
      }
      
      public Classes.Model.Prescription AddPrescription(int id, string medicine, string usage, string quantity)
      {
         throw new NotImplementedException();
      }
      
      public Classes.Model.Prescription GetPrescriptionById(int prescriptionId)
      {
         throw new NotImplementedException();
      }
      
      public Classes.Model.Anamnesis CreateAnamnesis(Classes.Model.Anamnesis anamnesis)
      {
         throw new NotImplementedException();
      }
      
      public Classes.Model.Anamnesis UpdateAnamnesis(Classes.Model.Anamnesis anamnesis)
      {
         throw new NotImplementedException();
      }
      
      public string path;
   
   }
=======
>>>>>>> 83499ee84be005688bb7f3e09a0e6c98d5c5d410
    public class MedicalRecordRepository
    {
        public Classes.Model.Allergen create(string name, DateTime date)
        {
            throw new NotImplementedException();
        }

        public Classes.Model.Allergen readFromList(int id)
        {
            throw new NotImplementedException();
        }

        public Classes.Model.Allergen update(Classes.Model.Allergen allergen)
        {
            throw new NotImplementedException();
        }

        public void deleteMRFromList(int id)
        {
            throw new NotImplementedException();
        }

        public List<Allergen> getAll()
        {
            throw new NotImplementedException();
        }

        public void DeleteList()
        {
            throw new NotImplementedException();
        }

        public Classes.Model.Prescription AddPrescriptionToList(int id, string medicine, string usage, string quantity)
        {
            throw new NotImplementedException();
        }

        public Classes.Model.Prescription GetPrescription(int prescriptionId)
        {
            throw new NotImplementedException();
        }

        public string path;

    }
<<<<<<< HEAD
=======
>>>>>>> fd620a89ab765ad29524f4512b4a532feef65325
>>>>>>> 83499ee84be005688bb7f3e09a0e6c98d5c5d410
}