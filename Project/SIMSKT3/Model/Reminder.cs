// File:    Reminder.cs
// Author:  HP-Miha
// Created: Sunday, May 16, 2021 9:41:01 PM
// Purpose: Definition of Class Reminder

using System;
using Classes.Model;
using Classes.Service;
using Classes.Repository;
using Classes.Controller;
using System.Collections.Generic;
namespace Classes.Model
{
   public class Reminder
   {
      public string name;
      public string description;
<<<<<<< HEAD
      public DateTime timeOfReminding;
      public int period;
=======
      public DateTime alarmTime;
      
      public Prescription prescription;
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
            {
               if (this.patient != null)
               {
                  Patient oldPatient = this.patient;
                  this.patient = null;
                  oldPatient.RemoveReminder(this);
               }
               if (value != null)
               {
                  this.patient = value;
                  this.patient.AddReminder(this);
               }
            }
         }
      }
>>>>>>> fd620a89ab765ad29524f4512b4a532feef65325
   
   }
}