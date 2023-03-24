<<<<<<< HEAD
=======
<<<<<<< HEAD
// File:    Allergen.cs
// Author:  LENOVO
// Created: Friday, April 9, 2021 8:59:39 PM
// Purpose: Definition of Class Allergen
=======
>>>>>>> fd620a89ab765ad29524f4512b4a532feef65325
>>>>>>> 83499ee84be005688bb7f3e09a0e6c98d5c5d410

using System;

namespace Classes.Model
{
<<<<<<< HEAD
   public class Allergen
   {
      public string name;
      public DateTime diagnosisDate;
      
      public MedicalRecord[] medicalRecord;
   
   }
=======
    public class Allergen
    {

        public int id { get; set; }
        public string allergenName { get; set; }
        public string diagnosisDate { get; set; }
        public Allergen(int id, string allergenName, string diagnosisDate)
        {
            this.id = id;
            this.allergenName = allergenName;
            this.diagnosisDate = diagnosisDate;
        }



        public Allergen() { }


        public Allergen read(int id)
        {
            throw new NotImplementedException();
        }

        public Allergen update(string name, string diagnosisDate)
        {
            throw new NotImplementedException();
        }

        public void delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Allergen> readAll()
        {
            throw new NotImplementedException();
        }

        public void deleteAll()
        {
            throw new NotImplementedException();
        }

        internal static IEnumerable<object> ToArray()
        {
            throw new NotImplementedException();
        }
    }
>>>>>>> fd620a89ab765ad29524f4512b4a532feef65325
}