// File:    ReferralLetterForSpecialist.cs
// Author:  LifeBook A574
// Created: Monday, April 26, 2021 5:09:31 PM
// Purpose: Definition of Class ReferralLetterForSpecialist

using System;

namespace Classes.Model
{
   public class ReferralLetterForSpecialist
   {
      public int id;
      public string reason;
      public bool isUsed;
      
      public Doctor doctor;
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
                  oldPatient.RemoveReferralLetterForSpecialist(this);
               }
               if (value != null)
               {
                  this.patient = value;
                  this.patient.AddReferralLetterForSpecialist(this);
               }
            }
         }
      }
   
   }
}