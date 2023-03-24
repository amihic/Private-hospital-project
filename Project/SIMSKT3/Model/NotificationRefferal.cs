// File:    NotificationRefferal.cs
// Author:  LENOVO
// Created: Friday, April 9, 2021 9:35:22 PM
// Purpose: Definition of Class NotificationRefferal

using System;
using Classes.Model;
using Classes.Service;
using Classes.Repository;
using Classes.Controller;
using System.Collections.Generic;
namespace Classes.Model
{
   public class NotificationRefferal
   {
      public int id;
      public string name;
      public string description;
      
      public Appointment appointment;
      
      /// <summary>
      /// Property for Appointment
      /// </summary>
      /// <pdGenerated>Default opposite class property</pdGenerated>
      public Appointment Appointment
      {
         get
         {
            return appointment;
         }
         set
         {
            this.appointment = value;
         }
      }
   
   }
}