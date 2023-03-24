// File:    ReminderRepository.cs
// Author:  HP-Miha
// Created: Sunday, May 16, 2021 10:05:15 PM
// Purpose: Definition of Class ReminderRepository

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
namespace Classes.Repository
{
   public class ReminderRepository
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
      
      public List<Reminder> ReadAllReminders()
      {
         throw new NotImplementedException();
      }
   
   }
}