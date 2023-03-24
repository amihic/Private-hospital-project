<<<<<<< HEAD
=======
<<<<<<< HEAD
/***********************************************************************
 * Module:  Patient.cs
 * Author:  8470
 * Purpose: Definition of the Class Patient
 ***********************************************************************/

=======
>>>>>>> fd620a89ab765ad29524f4512b4a532feef65325
>>>>>>> 83499ee84be005688bb7f3e09a0e6c98d5c5d410
using System;
using Classes.Model;
using Classes.Service;
using Classes.Repository;
using Classes.Controller;
using System.Collections.Generic;
namespace Classes.Model
{
   public class Patient
   {
      public double weight;
      public double beight;
      public string bloodType;
      public int healthInsuranceNumber;
      public bool isTroll = false;
      public bool isDisabled = false;
      public int cancellationCounter;
<<<<<<< HEAD
=======
<<<<<<< HEAD
      public DateTime dateOfCancelation;
      
      public System.Collections.Generic.List<MedicineAlert> medicineAlert;
=======
>>>>>>> 83499ee84be005688bb7f3e09a0e6c98d5c5d410
        private List<Patient> patients;
        public int id { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public string age { get; set; }
        public string jmbg { get; set; }
        public string phoneNumber { get; set; }

        public Patient()
        {
            //var patientAccount = new PatientAccount { Id = 1, Name = "Ksenija", Surname = "Nikolic", Age = 25, Jmbg = "1408996234011", PhoneNumber = "061100100" };
            //patients.Add(patientAccount);
        }
        public Patient(int id, string name, string surname, string age, string phoneNumber, string jmbg)
        {

            this.id = id;
            this.name = name;
            this.surname = surname;
            this.age = age;
            this.phoneNumber = phoneNumber;
            this.jmbg = jmbg;
        }

        /*
        public PatientAccount create(int id, string name, string surname, int age, int jmbg, int phoneNumber)
        {
            //patients.Add();
        }

        public PatientAccount read(int id)
        {
            //return patients.Find();
        }*/

        public Patient update(int id, string name, string surname, int age, int jmbg, int phoneNumber)
        {
            throw new NotImplementedException();
        }

        public void delete(int id)
        {
            //patients.RemoveAt(Id);
        }

        public List<Patient> readtAll()
        {
            return patients;
        }

        public void deleteAll()
        {
            patients.Clear();
        }

        public System.Collections.Generic.List<Reminder> reminder;
<<<<<<< HEAD
=======
>>>>>>> fd620a89ab765ad29524f4512b4a532feef65325
>>>>>>> 83499ee84be005688bb7f3e09a0e6c98d5c5d410
      
      /// <summary>
      /// Property for collection of MedicineAlert
      /// </summary>
      /// <pdGenerated>Default opposite class collection property</pdGenerated>
      public System.Collections.Generic.List<MedicineAlert> MedicineAlert
      {
         get
         {
            if (medicineAlert == null)
               medicineAlert = new System.Collections.Generic.List<MedicineAlert>();
            return medicineAlert;
         }
         set
         {
            RemoveAllMedicineAlert();
            if (value != null)
            {
               foreach (MedicineAlert oMedicineAlert in value)
                  AddMedicineAlert(oMedicineAlert);
            }
         }
      }
      
      /// <summary>
      /// Add a new MedicineAlert in the collection
      /// </summary>
      /// <pdGenerated>Default Add</pdGenerated>
      public void AddMedicineAlert(MedicineAlert newMedicineAlert)
      {
         if (newMedicineAlert == null)
            return;
         if (this.medicineAlert == null)
            this.medicineAlert = new System.Collections.Generic.List<MedicineAlert>();
         if (!this.medicineAlert.Contains(newMedicineAlert))
         {
            this.medicineAlert.Add(newMedicineAlert);
            newMedicineAlert.Patient = this;
         }
      }
      
      /// <summary>
      /// Remove an existing MedicineAlert from the collection
      /// </summary>
      /// <pdGenerated>Default Remove</pdGenerated>
      public void RemoveMedicineAlert(MedicineAlert oldMedicineAlert)
      {
         if (oldMedicineAlert == null)
            return;
         if (this.medicineAlert != null)
            if (this.medicineAlert.Contains(oldMedicineAlert))
            {
               this.medicineAlert.Remove(oldMedicineAlert);
               oldMedicineAlert.Patient = null;
            }
      }
      
      /// <summary>
      /// Remove all instances of MedicineAlert from the collection
      /// </summary>
      /// <pdGenerated>Default removeAll</pdGenerated>
      public void RemoveAllMedicineAlert()
      {
         if (medicineAlert != null)
         {
            System.Collections.ArrayList tmpMedicineAlert = new System.Collections.ArrayList();
            foreach (MedicineAlert oldMedicineAlert in medicineAlert)
               tmpMedicineAlert.Add(oldMedicineAlert);
            medicineAlert.Clear();
            foreach (MedicineAlert oldMedicineAlert in tmpMedicineAlert)
               oldMedicineAlert.Patient = null;
            tmpMedicineAlert.Clear();
         }
      }
      public User user;
      public System.Collections.Generic.List<ReferralLetterForSpecialist> referralLetterForSpecialist;
      
      /// <summary>
      /// Property for collection of ReferralLetterForSpecialist
      /// </summary>
      /// <pdGenerated>Default opposite class collection property</pdGenerated>
      public System.Collections.Generic.List<ReferralLetterForSpecialist> ReferralLetterForSpecialist
      {
         get
         {
            if (referralLetterForSpecialist == null)
               referralLetterForSpecialist = new System.Collections.Generic.List<ReferralLetterForSpecialist>();
            return referralLetterForSpecialist;
         }
         set
         {
            RemoveAllReferralLetterForSpecialist();
            if (value != null)
            {
               foreach (ReferralLetterForSpecialist oReferralLetterForSpecialist in value)
                  AddReferralLetterForSpecialist(oReferralLetterForSpecialist);
            }
         }
      }
      
      /// <summary>
      /// Add a new ReferralLetterForSpecialist in the collection
      /// </summary>
      /// <pdGenerated>Default Add</pdGenerated>
      public void AddReferralLetterForSpecialist(ReferralLetterForSpecialist newReferralLetterForSpecialist)
      {
         if (newReferralLetterForSpecialist == null)
            return;
         if (this.referralLetterForSpecialist == null)
            this.referralLetterForSpecialist = new System.Collections.Generic.List<ReferralLetterForSpecialist>();
         if (!this.referralLetterForSpecialist.Contains(newReferralLetterForSpecialist))
         {
            this.referralLetterForSpecialist.Add(newReferralLetterForSpecialist);
            newReferralLetterForSpecialist.Patient = this;
         }
      }
      
      /// <summary>
      /// Remove an existing ReferralLetterForSpecialist from the collection
      /// </summary>
      /// <pdGenerated>Default Remove</pdGenerated>
      public void RemoveReferralLetterForSpecialist(ReferralLetterForSpecialist oldReferralLetterForSpecialist)
      {
         if (oldReferralLetterForSpecialist == null)
            return;
         if (this.referralLetterForSpecialist != null)
            if (this.referralLetterForSpecialist.Contains(oldReferralLetterForSpecialist))
            {
               this.referralLetterForSpecialist.Remove(oldReferralLetterForSpecialist);
               oldReferralLetterForSpecialist.Patient = null;
            }
      }
      
      /// <summary>
      /// Remove all instances of ReferralLetterForSpecialist from the collection
      /// </summary>
      /// <pdGenerated>Default removeAll</pdGenerated>
      public void RemoveAllReferralLetterForSpecialist()
      {
         if (referralLetterForSpecialist != null)
         {
            System.Collections.ArrayList tmpReferralLetterForSpecialist = new System.Collections.ArrayList();
            foreach (ReferralLetterForSpecialist oldReferralLetterForSpecialist in referralLetterForSpecialist)
               tmpReferralLetterForSpecialist.Add(oldReferralLetterForSpecialist);
            referralLetterForSpecialist.Clear();
            foreach (ReferralLetterForSpecialist oldReferralLetterForSpecialist in tmpReferralLetterForSpecialist)
               oldReferralLetterForSpecialist.Patient = null;
            tmpReferralLetterForSpecialist.Clear();
         }
      }
      public System.Collections.Generic.List<Survey> survey;
      
      /// <summary>
      /// Property for collection of Survey
      /// </summary>
      /// <pdGenerated>Default opposite class collection property</pdGenerated>
      public System.Collections.Generic.List<Survey> Survey
      {
         get
         {
            if (survey == null)
               survey = new System.Collections.Generic.List<Survey>();
            return survey;
         }
         set
         {
            RemoveAllSurvey();
            if (value != null)
            {
               foreach (Survey oSurvey in value)
                  AddSurvey(oSurvey);
            }
         }
      }
      
      /// <summary>
      /// Add a new Survey in the collection
      /// </summary>
      /// <pdGenerated>Default Add</pdGenerated>
      public void AddSurvey(Survey newSurvey)
      {
         if (newSurvey == null)
            return;
         if (this.survey == null)
            this.survey = new System.Collections.Generic.List<Survey>();
         if (!this.survey.Contains(newSurvey))
         {
            this.survey.Add(newSurvey);
            newSurvey.Patient = this;
         }
      }
      
      /// <summary>
      /// Remove an existing Survey from the collection
      /// </summary>
      /// <pdGenerated>Default Remove</pdGenerated>
      public void RemoveSurvey(Survey oldSurvey)
      {
         if (oldSurvey == null)
            return;
         if (this.survey != null)
            if (this.survey.Contains(oldSurvey))
            {
               this.survey.Remove(oldSurvey);
               oldSurvey.Patient = null;
            }
      }
      
      /// <summary>
      /// Remove all instances of Survey from the collection
      /// </summary>
      /// <pdGenerated>Default removeAll</pdGenerated>
      public void RemoveAllSurvey()
      {
         if (survey != null)
         {
            System.Collections.ArrayList tmpSurvey = new System.Collections.ArrayList();
            foreach (Survey oldSurvey in survey)
               tmpSurvey.Add(oldSurvey);
            survey.Clear();
            foreach (Survey oldSurvey in tmpSurvey)
               oldSurvey.Patient = null;
            tmpSurvey.Clear();
         }
      }
      public Reminder[] reminder;
      public MedicalRecord medicalRecord;
      public System.Collections.ArrayList appointment;
      
      /// <summary>
      /// Property for collection of Appointment
      /// </summary>
      /// <pdGenerated>Default opposite class collection property</pdGenerated>
      public System.Collections.ArrayList Appointment
      {
         get
         {
            if (appointment == null)
               appointment = new System.Collections.ArrayList();
            return appointment;
         }
         set
         {
            RemoveAllAppointment();
            if (value != null)
            {
               foreach (Appointment oAppointment in value)
                  AddAppointment(oAppointment);
            }
         }
      }
      
      /// <summary>
      /// Add a new Appointment in the collection
      /// </summary>
      /// <pdGenerated>Default Add</pdGenerated>
      public void AddAppointment(Appointment newAppointment)
      {
         if (newAppointment == null)
            return;
         if (this.appointment == null)
            this.appointment = new System.Collections.ArrayList();
         if (!this.appointment.Contains(newAppointment))
         {
            this.appointment.Add(newAppointment);
            newAppointment.Patient = this;
         }
      }
      
      /// <summary>
      /// Remove an existing Appointment from the collection
      /// </summary>
      /// <pdGenerated>Default Remove</pdGenerated>
      public void RemoveAppointment(Appointment oldAppointment)
      {
         if (oldAppointment == null)
            return;
         if (this.appointment != null)
            if (this.appointment.Contains(oldAppointment))
            {
               this.appointment.Remove(oldAppointment);
               oldAppointment.Patient = null;
            }
      }
      
      /// <summary>
      /// Remove all instances of Appointment from the collection
      /// </summary>
      /// <pdGenerated>Default removeAll</pdGenerated>
      public void RemoveAllAppointment()
      {
         if (appointment != null)
         {
            System.Collections.ArrayList tmpAppointment = new System.Collections.ArrayList();
            foreach (Appointment oldAppointment in appointment)
               tmpAppointment.Add(oldAppointment);
            appointment.Clear();
            foreach (Appointment oldAppointment in tmpAppointment)
               oldAppointment.Patient = null;
            tmpAppointment.Clear();
         }
      }
      public HospitalTreatment hospitalTreatment;
   
   }
}