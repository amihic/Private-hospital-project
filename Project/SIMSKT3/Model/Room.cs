<<<<<<< HEAD
=======
<<<<<<< HEAD
>>>>>>> 83499ee84be005688bb7f3e09a0e6c98d5c5d410
/***********************************************************************
 * Module:  Room.cs
 * Author:  HP-Miha
 * Purpose: Definition of the Class Room
 ***********************************************************************/

<<<<<<< HEAD
using System;
using Classes.Model;
using Classes.Service;
using Classes.Repository;
using Classes.Controller;
using System.Collections.Generic;
=======
=======
>>>>>>> fd620a89ab765ad29524f4512b4a532feef65325
using System;
>>>>>>> 83499ee84be005688bb7f3e09a0e6c98d5c5d410
namespace Classes.Model
{
   public class Room
   {
        public Room(int id, string name, string type, int floor, string description)
        {
            this.id = id;
            this.name = name;
            this.type = type;
            this.floor = floor;
            this.description = description;
        }

      public int id;
      public string name;
      public RoomType type;
      public int floor;
      public string description;
      
      public System.Collections.ArrayList staticEquipment;

      public System.Collections.ArrayList StaticEquipment
      {
         get
         {
            if (staticEquipment == null)
               staticEquipment = new System.Collections.ArrayList();
            return staticEquipment;
         }
         set
         {
            RemoveAllStaticEquipment();
            if (value != null)
            {
               foreach (StaticEquipment oStaticEquipment in value)
                  AddStaticEquipment(oStaticEquipment);
            }
         }
      }

      public void AddStaticEquipment(StaticEquipment newStaticEquipment)
      {
         if (newStaticEquipment == null)
            return;
         if (this.staticEquipment == null)
            this.staticEquipment = new System.Collections.ArrayList();
         if (!this.staticEquipment.Contains(newStaticEquipment))
         {
            this.staticEquipment.Add(newStaticEquipment);
            newStaticEquipment.Room = this;
         }
      }

      public void RemoveStaticEquipment(StaticEquipment oldStaticEquipment)
      {
         if (oldStaticEquipment == null)
            return;
         if (this.staticEquipment != null)
            if (this.staticEquipment.Contains(oldStaticEquipment))
            {
               this.staticEquipment.Remove(oldStaticEquipment);
               oldStaticEquipment.Room = null;
            }
      }

      public void RemoveAllStaticEquipment()
      {
         if (staticEquipment != null)
         {
            System.Collections.ArrayList tmpStaticEquipment = new System.Collections.ArrayList();
            foreach (StaticEquipment oldStaticEquipment in staticEquipment)
               tmpStaticEquipment.Add(oldStaticEquipment);
            staticEquipment.Clear();
            foreach (StaticEquipment oldStaticEquipment in tmpStaticEquipment)
               oldStaticEquipment.Room = null;
            tmpStaticEquipment.Clear();
         }
      }
      public System.Collections.Generic.List<Renovation> renovation;
      
      /// <summary>
      /// Property for collection of Renovation
      /// </summary>
      /// <pdGenerated>Default opposite class collection property</pdGenerated>
      public System.Collections.Generic.List<Renovation> Renovation
      {
         get
         {
            if (renovation == null)
               renovation = new System.Collections.Generic.List<Renovation>();
            return renovation;
         }
         set
         {
            RemoveAllRenovation();
            if (value != null)
            {
               foreach (Renovation oRenovation in value)
                  AddRenovation(oRenovation);
            }
         }
      }
      
      /// <summary>
      /// Add a new Renovation in the collection
      /// </summary>
      /// <pdGenerated>Default Add</pdGenerated>
      public void AddRenovation(Renovation newRenovation)
      {
         if (newRenovation == null)
            return;
         if (this.renovation == null)
            this.renovation = new System.Collections.Generic.List<Renovation>();
         if (!this.renovation.Contains(newRenovation))
         {
            this.renovation.Add(newRenovation);
            newRenovation.Room = this;
         }
      }
      
      /// <summary>
      /// Remove an existing Renovation from the collection
      /// </summary>
      /// <pdGenerated>Default Remove</pdGenerated>
      public void RemoveRenovation(Renovation oldRenovation)
      {
         if (oldRenovation == null)
            return;
         if (this.renovation != null)
            if (this.renovation.Contains(oldRenovation))
            {
               this.renovation.Remove(oldRenovation);
               oldRenovation.Room = null;
            }
      }
      
      /// <summary>
      /// Remove all instances of Renovation from the collection
      /// </summary>
      /// <pdGenerated>Default removeAll</pdGenerated>
      public void RemoveAllRenovation()
      {
         if (renovation != null)
         {
            System.Collections.ArrayList tmpRenovation = new System.Collections.ArrayList();
            foreach (Renovation oldRenovation in renovation)
               tmpRenovation.Add(oldRenovation);
            renovation.Clear();
            foreach (Renovation oldRenovation in tmpRenovation)
               oldRenovation.Room = null;
            tmpRenovation.Clear();
         }
      }
      public Employee employee;
   
   }
}