using System;

namespace Classes.Model
{
<<<<<<< HEAD
=======
<<<<<<< HEAD
   public class Appointment
   {
      public int id;
      public DateTime startTime;
      public DateTime endTime;
      public DateTime date;
      public Room room;
      public AppointmentType appointmentType;
      public bool isEmergency = false;
      
      public Patient patient;
      
      /// <summary>
      /// Property for Patient
      /// </summary>
      /// <pdGenerated>Default opposite class property</pdGenerated>
      public Patient Patient
      {
         get
         {
            return patient;
         }
         set
         {
            if (this.patient == null || !this.patient.Equals(value))
=======
>>>>>>> 83499ee84be005688bb7f3e09a0e6c98d5c5d410
    public class Appointment
    {

        public int id { get; set; }
<<<<<<< HEAD
        public string startTime { get; set; }
        public string endTime { get; set; }
        public string date { get; set; }
=======
        public DateTime startTime { get; set; }
        public DateTime endTime { get; set; }
        public DateTime date { get; set; }
>>>>>>> 83499ee84be005688bb7f3e09a0e6c98d5c5d410
        public string pati { get; set; }
        public string dr { get; set; }
        public string type { get; set; }
        public string room { get; set; }
<<<<<<< HEAD

=======
>>>>>>> 83499ee84be005688bb7f3e09a0e6c98d5c5d410
        public string available { get; set; }





        /*public int id;
        public DateTime startTime;
        public DateTime endTime;
        public DateTime date;
        public Room room;
        public AppointmentType appointmentType;*/

        public Patient patient;

        /// <summary>
        /// Property for Patient
        /// </summary>
        /// <pdGenerated>Default opposite class property</pdGenerated>
        public Patient Patient
        {
            get
            {
                return patient;
            }
            set
<<<<<<< HEAD
=======
>>>>>>> fd620a89ab765ad29524f4512b4a532feef65325
>>>>>>> 83499ee84be005688bb7f3e09a0e6c98d5c5d410
            {
                if (this.patient == null || !this.patient.Equals(value))
                {
                    if (this.patient != null)
                    {
                        Patient oldPatient = this.patient;
                        this.patient = null;
                        oldPatient.RemoveAppointment(this);
                    }
                    if (value != null)
                    {
                        this.patient = value;
                        this.patient.AddAppointment(this);
                    }
                }
            }
        }
        public Secretary secretary;

        /// <summary>
        /// Property for Secretary
        /// </summary>
        /// <pdGenerated>Default opposite class property</pdGenerated>
        public Secretary Secretary
        {
            get
            {
                return secretary;
            }
<<<<<<< HEAD
=======
<<<<<<< HEAD
         }
      }
      public Doctor doctor;
      
      /// <summary>
      /// Property for Doctor
      /// </summary>
      /// <pdGenerated>Default opposite class property</pdGenerated>
      public Doctor Doctor
      {
         get
         {
            return doctor;
         }
         set
         {
            if (this.doctor == null || !this.doctor.Equals(value))
=======
>>>>>>> 83499ee84be005688bb7f3e09a0e6c98d5c5d410
            set
            {
                if (this.secretary == null || !this.secretary.Equals(value))
                {
                    if (this.secretary != null)
                    {
                        Secretary oldSecretary = this.secretary;
                        this.secretary = null;
                        oldSecretary.RemoveAppointment(this);
                    }
                    if (value != null)
                    {
                        this.secretary = value;
                        this.secretary.AddAppointment(this);
                    }
                }
            }
        }
        public GuestAccount guestAccount;

        /// <summary>
        /// Property for GuestAccount
        /// </summary>
        /// <pdGenerated>Default opposite class property</pdGenerated>
        public GuestAccount GuestAccount
        {
            get
<<<<<<< HEAD
=======
>>>>>>> fd620a89ab765ad29524f4512b4a532feef65325
>>>>>>> 83499ee84be005688bb7f3e09a0e6c98d5c5d410
            {
                return guestAccount;
            }
            set
            {
                if (this.guestAccount == null || !this.guestAccount.Equals(value))
                {
                    if (this.guestAccount != null)
                    {
                        GuestAccount oldGuestAccount = this.guestAccount;
                        this.guestAccount = null;
                        oldGuestAccount.RemoveAppointment(this);
                    }
                    if (value != null)
                    {
                        this.guestAccount = value;
                        this.guestAccount.AddAppointment(this);
                    }
                }
            }
        }
        public Doctor doctor;

        /// <summary>
        /// Property for Doctor
        /// </summary>
        /// <pdGenerated>Default opposite class property</pdGenerated>
        public Doctor Doctor
        {
            get
            {
                return doctor;
            }
            set
            {
                if (this.doctor == null || !this.doctor.Equals(value))
                {
                    if (this.doctor != null)
                    {
                        Doctor oldDoctor = this.doctor;
                        this.doctor = null;
                        oldDoctor.RemoveAppointment(this);
                    }
                    if (value != null)
                    {
                        this.doctor = value;
                        this.doctor.AddAppointment(this);
                    }
                }
            }
        }
        public Employee employee;

        /// <summary>
        /// Property for Employee
        /// </summary>
        /// <pdGenerated>Default opposite class property</pdGenerated>
        public Employee Employee
        {
            get
            {
                return employee;
            }
            set
            {
                if (this.employee == null || !this.employee.Equals(value))
                {
                    if (this.employee != null)
                    {
                        Employee oldEmployee = this.employee;
                        this.employee = null;
                        oldEmployee.RemoveAppointment(this);
                    }
                    if (value != null)
                    {
                        this.employee = value;
                        this.employee.AddAppointment(this);
                    }
                }
            }
        }

    }
}