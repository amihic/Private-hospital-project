// File:    ReminderController.cs
// Author:  HP-Miha
// Created: Sunday, May 16, 2021 9:55:51 PM
// Purpose: Definition of Class ReminderController

using System;
<<<<<<< HEAD

=======
using Classes.Model;
using Classes.Service;
using Classes.Repository;
using Classes.Controller;
using System.Collections.Generic;
<<<<<<< HEAD
=======
>>>>>>> fd620a89ab765ad29524f4512b4a532feef65325
>>>>>>> 83499ee84be005688bb7f3e09a0e6c98d5c5d410
namespace Classes.Controller
{
   public class ReminderController
   {
      public Reminder CreateReminder(Reminder reminder)
      {
         throw new NotImplementedException();
      }
      
      public Reminder UpdateReminder(Reminder reminder)
      {
         throw new NotImplementedException();
      }
      
      public Reminder ReadReminder(int reminderId)
      {
         throw new NotImplementedException();
      }
      
      public void DeleteReminder(int reminderId)
      {
         throw new NotImplementedException();
      }
      
<<<<<<< HEAD
      public List<Reminder> ReadAllReminders()
=======
      public void DeleteAllRemindersFromPatient(int patientId)
<<<<<<< HEAD
=======
>>>>>>> fd620a89ab765ad29524f4512b4a532feef65325
>>>>>>> 83499ee84be005688bb7f3e09a0e6c98d5c5d410
      {
         throw new NotImplementedException();
      }
      
      public Classes.Service.ReminderService reminderService;
   
   }
}