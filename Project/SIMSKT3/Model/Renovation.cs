<<<<<<< HEAD
=======
<<<<<<< HEAD
>>>>>>> 83499ee84be005688bb7f3e09a0e6c98d5c5d410
// File:    Renovation.cs
// Author:  LifeBook A574
// Created: Monday, April 26, 2021 4:09:49 PM
// Purpose: Definition of Class Renovation

<<<<<<< HEAD
using System;
using Classes.Model;
using Classes.Service;
using Classes.Repository;
using Classes.Controller;
using System.Collections.Generic;
namespace Classes.Model
{
   public class Renovation
   {
      public int id;
=======
=======
>>>>>>> fd620a89ab765ad29524f4512b4a532feef65325
using System;

namespace Classes.Model
{
<<<<<<< HEAD
   public class Renovation
   {
      public int id;
      public RenovationType type;
>>>>>>> 83499ee84be005688bb7f3e09a0e6c98d5c5d410
      public DateTime startTime;
      public DateTime endTime;
      public DateTime date;
      public string description;
<<<<<<< HEAD
   
   }
=======
      
      public Room room;
      
      /// <summary>
      /// Property for Room
      /// </summary>
      /// <pdGenerated>Default opposite class property</pdGenerated>
      public Room Room
      {
         get
         {
            return room;
         }
         set
         {
            if (this.room == null || !this.room.Equals(value))
            {
               if (this.room != null)
               {
                  Room oldRoom = this.room;
                  this.room = null;
                  oldRoom.RemoveRenovation(this);
               }
               if (value != null)
               {
                  this.room = value;
                  this.room.AddRenovation(this);
               }
            }
         }
      }
   
   }
=======
    public class Renovation
    {
        public Renovation(string roomName, DateTime date, DateTime startTime, DateTime endTime, string description)
        {
            this.roomName = roomName;
            this.date = date;
            this.startTime = startTime;
            this.endTime = endTime;
            this.description = description;
        }

        public string roomName{ get; set; }
        public DateTime startTime { get; set; }
        public DateTime endTime { get; set; }
        public DateTime date { get; set; }
        public string description{ get; set; }

    }
>>>>>>> fd620a89ab765ad29524f4512b4a532feef65325
>>>>>>> 83499ee84be005688bb7f3e09a0e6c98d5c5d410
}