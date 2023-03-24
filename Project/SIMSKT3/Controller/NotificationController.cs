// File:    NotificationController.cs
// Author:  LENOVO
// Created: Friday, April 9, 2021 10:11:56 PM
// Purpose: Definition of Class NotificationController

using System;

namespace Classes.Controller
{
<<<<<<< HEAD
=======
<<<<<<< HEAD
   public class NotificationController
   {
      public Classes.Model.NotificationRefferal GetNotificationById(int notificationId)
      {
         throw new NotImplementedException();
      }
      
      public List<NotificationRefferal> GetAllNotificationsFromUser(int userId)
      {
         throw new NotImplementedException();
      }
      
      public void deleteNotification(int notificationId)
      {
         throw new NotImplementedException();
      }
      
      public NotificationRefferal createNotification(Classes.Model.NotificationRefferal notification)
      {
         throw new NotImplementedException();
      }
      
      public void DeleteAllNotificationsFromUser(int userId)
      {
         throw new NotImplementedException();
      }
      
      public void SendTo(int patientId, int doctorId)
      {
         throw new NotImplementedException();
      }
      
      public Classes.Service.NotificationService notificationService;
   
   }
=======
>>>>>>> 83499ee84be005688bb7f3e09a0e6c98d5c5d410
    public class NotificationController
    {
        public Classes.Model.NotificationRefferal GetNotificationById(int notificationId)
        {
            throw new NotImplementedException();
        }

        public List<NotificationRefferal> GetAllNotificationsFromUser(int userId)
        {
            throw new NotImplementedException();
        }

        public void deleteNotification(int notificationId)
        {
            throw new NotImplementedException();
        }

        public NotificationRefferal createNotification(Classes.Model.NotificationRefferal notification)
        {
            throw new NotImplementedException();
        }

        public void DeleteAllNotificationsFromUser(int userId)
        {
            throw new NotImplementedException();
        }

        public Classes.Service.NotificationService notificationService;

    }
<<<<<<< HEAD
=======
>>>>>>> fd620a89ab765ad29524f4512b4a532feef65325
>>>>>>> 83499ee84be005688bb7f3e09a0e6c98d5c5d410
}