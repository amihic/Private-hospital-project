
using System;

namespace Classes.Model
{
<<<<<<< HEAD
=======
<<<<<<< HEAD
   public class Employee
   {
      public int salary;
      public System.TimeSpan workingHours;
      public System.TimeSpan annualVacation;
      public EmployeeType role;
      public string explenation;
      
      public User user;
      public Room room;
      public Warehouse warehouse;
      public System.Collections.Generic.List<MedicalRecord> medicalRecord;
      
      /// <summary>
      /// Property for collection of MedicalRecord
      /// </summary>
      /// <pdGenerated>Default opposite class collection property</pdGenerated>
      public System.Collections.Generic.List<MedicalRecord> MedicalRecord
      {
         get
         {
            if (medicalRecord == null)
               medicalRecord = new System.Collections.Generic.List<MedicalRecord>();
            return medicalRecord;
         }
         set
         {
            RemoveAllMedicalRecord();
            if (value != null)
=======
>>>>>>> 83499ee84be005688bb7f3e09a0e6c98d5c5d410
    public class Employee
    {
        public int salary;
        public System.TimeSpan workingHours;
        public System.TimeSpan annualVacation;
        public EmployeeType role;

        public User user;
        public Room room;
        public Warehouse warehouse;
        public System.Collections.Generic.List<MedicalRecord> medicalRecord;

        /// <summary>
        /// Property for collection of MedicalRecord
        /// </summary>
        /// <pdGenerated>Default opposite class collection property</pdGenerated>
        public System.Collections.Generic.List<MedicalRecord> MedicalRecord
        {
            get
<<<<<<< HEAD
            {
                if (medicalRecord == null)
                    medicalRecord = new System.Collections.Generic.List<MedicalRecord>();
                return medicalRecord;
            }
            set
            {
                RemoveAllMedicalRecord();
                if (value != null)
                {
                    foreach (MedicalRecord oMedicalRecord in value)
                        AddMedicalRecord(oMedicalRecord);
                }
            }
        }

        /// <summary>
        /// Add a new MedicalRecord in the collection
        /// </summary>
        /// <pdGenerated>Default Add</pdGenerated>
        public void AddMedicalRecord(MedicalRecord newMedicalRecord)
        {
            if (newMedicalRecord == null)
                return;
            if (this.medicalRecord == null)
                this.medicalRecord = new System.Collections.Generic.List<MedicalRecord>();
            if (!this.medicalRecord.Contains(newMedicalRecord))
                this.medicalRecord.Add(newMedicalRecord);
        }

        /// <summary>
        /// Remove an existing MedicalRecord from the collection
        /// </summary>
        /// <pdGenerated>Default Remove</pdGenerated>
        public void RemoveMedicalRecord(MedicalRecord oldMedicalRecord)
        {
            if (oldMedicalRecord == null)
                return;
            if (this.medicalRecord != null)
                if (this.medicalRecord.Contains(oldMedicalRecord))
                    this.medicalRecord.Remove(oldMedicalRecord);
        }

        /// <summary>
        /// Remove all instances of MedicalRecord from the collection
        /// </summary>
        /// <pdGenerated>Default removeAll</pdGenerated>
        public void RemoveAllMedicalRecord()
        {
            if (medicalRecord != null)
                medicalRecord.Clear();
        }
        public System.Collections.Generic.List<Appointment> appointment;

        /// <summary>
        /// Property for collection of Appointment
        /// </summary>
        /// <pdGenerated>Default opposite class collection property</pdGenerated>
        public System.Collections.Generic.List<Appointment> Appointment
        {
            get
            {
                if (appointment == null)
                    appointment = new System.Collections.Generic.List<Appointment>();
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
                this.appointment = new System.Collections.Generic.List<Appointment>();
            if (!this.appointment.Contains(newAppointment))
            {
                this.appointment.Add(newAppointment);
                newAppointment.Employee = this;
=======
            {
                if (medicalRecord == null)
                    medicalRecord = new System.Collections.Generic.List<MedicalRecord>();
                return medicalRecord;
            }
            set
            {
                RemoveAllMedicalRecord();
                if (value != null)
                {
                    foreach (MedicalRecord oMedicalRecord in value)
                        AddMedicalRecord(oMedicalRecord);
                }
>>>>>>> 83499ee84be005688bb7f3e09a0e6c98d5c5d410
            }
        }

        /// <summary>
<<<<<<< HEAD
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
                    oldAppointment.Employee = null;
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
                    oldAppointment.Employee = null;
                tmpAppointment.Clear();
            }
=======
        /// Add a new MedicalRecord in the collection
        /// </summary>
        /// <pdGenerated>Default Add</pdGenerated>
        public void AddMedicalRecord(MedicalRecord newMedicalRecord)
        {
            if (newMedicalRecord == null)
                return;
            if (this.medicalRecord == null)
                this.medicalRecord = new System.Collections.Generic.List<MedicalRecord>();
            if (!this.medicalRecord.Contains(newMedicalRecord))
                this.medicalRecord.Add(newMedicalRecord);
        }

        /// <summary>
        /// Remove an existing MedicalRecord from the collection
        /// </summary>
        /// <pdGenerated>Default Remove</pdGenerated>
        public void RemoveMedicalRecord(MedicalRecord oldMedicalRecord)
        {
            if (oldMedicalRecord == null)
                return;
            if (this.medicalRecord != null)
                if (this.medicalRecord.Contains(oldMedicalRecord))
                    this.medicalRecord.Remove(oldMedicalRecord);
        }

        /// <summary>
        /// Remove all instances of MedicalRecord from the collection
        /// </summary>
        /// <pdGenerated>Default removeAll</pdGenerated>
        public void RemoveAllMedicalRecord()
        {
            if (medicalRecord != null)
                medicalRecord.Clear();
        }
        public System.Collections.Generic.List<Appointment> appointment;

        /// <summary>
        /// Property for collection of Appointment
        /// </summary>
        /// <pdGenerated>Default opposite class collection property</pdGenerated>
        public System.Collections.Generic.List<Appointment> Appointment
        {
            get
            {
                if (appointment == null)
                    appointment = new System.Collections.Generic.List<Appointment>();
                return appointment;
            }
            set
>>>>>>> fd620a89ab765ad29524f4512b4a532feef65325
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
                this.appointment = new System.Collections.Generic.List<Appointment>();
            if (!this.appointment.Contains(newAppointment))
            {
                this.appointment.Add(newAppointment);
                newAppointment.Employee = this;
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
                    oldAppointment.Employee = null;
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
                    oldAppointment.Employee = null;
                tmpAppointment.Clear();
            }
>>>>>>> 83499ee84be005688bb7f3e09a0e6c98d5c5d410
        }

    }
}