using System;
using System.Collections.Generic;
namespace Classes.Model
{
<<<<<<< HEAD
=======
<<<<<<< HEAD
   public class Doctor : Employee
   {
      public string specialization;
      public boolean onOffDays = false;
      
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
=======
>>>>>>> 83499ee84be005688bb7f3e09a0e6c98d5c5d410
    public class Doctor : Employee
    {
        public string id { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public string specialization { get; set; }

        public Doctor(string id, string name, string surname, string specialization)
        {
            this.id = id;
            this.name = name;
            this.surname = surname;
            this.specialization = specialization;
        }

        public System.Collections.ArrayList appointment;

        /// <summary>
        /// Property for collection of Appointment
        /// </summary>
        /// <pdGenerated>Default opposite class collection property</pdGenerated>
        public System.Collections.ArrayList Appointment
        {
            get
<<<<<<< HEAD
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
=======
>>>>>>> fd620a89ab765ad29524f4512b4a532feef65325
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
<<<<<<< HEAD
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
               oldAppointment.Doctor = null;
            tmpAppointment.Clear();
         }
      }
      public System.Collections.Generic.List<HospitalTreatment> hospitalTreatment;
      
      /// <summary>
      /// Property for collection of HospitalTreatment
      /// </summary>
      /// <pdGenerated>Default opposite class collection property</pdGenerated>
      public System.Collections.Generic.List<HospitalTreatment> HospitalTreatment
      {
         get
         {
            if (hospitalTreatment == null)
               hospitalTreatment = new System.Collections.Generic.List<HospitalTreatment>();
            return hospitalTreatment;
         }
         set
         {
            RemoveAllHospitalTreatment();
            if (value != null)
            {
               foreach (HospitalTreatment oHospitalTreatment in value)
                  AddHospitalTreatment(oHospitalTreatment);
            }
         }
      }
      
      /// <summary>
      /// Add a new HospitalTreatment in the collection
      /// </summary>
      /// <pdGenerated>Default Add</pdGenerated>
      public void AddHospitalTreatment(HospitalTreatment newHospitalTreatment)
      {
         if (newHospitalTreatment == null)
            return;
         if (this.hospitalTreatment == null)
            this.hospitalTreatment = new System.Collections.Generic.List<HospitalTreatment>();
         if (!this.hospitalTreatment.Contains(newHospitalTreatment))
            this.hospitalTreatment.Add(newHospitalTreatment);
      }
      
      /// <summary>
      /// Remove an existing HospitalTreatment from the collection
      /// </summary>
      /// <pdGenerated>Default Remove</pdGenerated>
      public void RemoveHospitalTreatment(HospitalTreatment oldHospitalTreatment)
      {
         if (oldHospitalTreatment == null)
            return;
         if (this.hospitalTreatment != null)
            if (this.hospitalTreatment.Contains(oldHospitalTreatment))
               this.hospitalTreatment.Remove(oldHospitalTreatment);
      }
      
      /// <summary>
      /// Remove all instances of HospitalTreatment from the collection
      /// </summary>
      /// <pdGenerated>Default removeAll</pdGenerated>
      public void RemoveAllHospitalTreatment()
      {
         if (hospitalTreatment != null)
            hospitalTreatment.Clear();
      }
      public ReferralLetterForSpecialist[] referralLetterForSpecialist;
   
   }
=======
>>>>>>> 83499ee84be005688bb7f3e09a0e6c98d5c5d410
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
                newAppointment.Doctor = this;
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
                    oldAppointment.Doctor = null;
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
                    oldAppointment.Doctor = null;
                tmpAppointment.Clear();
            }
        }

    }
<<<<<<< HEAD
=======
>>>>>>> fd620a89ab765ad29524f4512b4a532feef65325
>>>>>>> 83499ee84be005688bb7f3e09a0e6c98d5c5d410
}