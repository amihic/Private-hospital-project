// File:    Survey.cs
// Author:  LifeBook A574
// Created: Monday, April 26, 2021 5:46:30 PM
// Purpose: Definition of Class Survey

using System;
<<<<<<< HEAD
=======
<<<<<<< HEAD

=======
>>>>>>> 83499ee84be005688bb7f3e09a0e6c98d5c5d410
using Classes.Model;
using Classes.Service;
using Classes.Repository;
using Classes.Controller;
using System.Collections.Generic;
<<<<<<< HEAD
=======
>>>>>>> fd620a89ab765ad29524f4512b4a532feef65325
>>>>>>> 83499ee84be005688bb7f3e09a0e6c98d5c5d410
namespace Classes.Model
{
   public class Survey
   {
      public int id;
      public int review;
      public string description;
      
      public Doctor doctor;
<<<<<<< HEAD
=======
<<<<<<< HEAD
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
                  oldPatient.RemoveSurvey(this);
               }
               if (value != null)
               {
                  this.patient = value;
                  this.patient.AddSurvey(this);
               }
            }
         }
      }
=======
>>>>>>> fd620a89ab765ad29524f4512b4a532feef65325
>>>>>>> 83499ee84be005688bb7f3e09a0e6c98d5c5d410
   
   }
}