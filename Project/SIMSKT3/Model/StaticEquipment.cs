<<<<<<< HEAD

=======
>>>>>>> 22c5e86ff397741ea3d7633e5efd94cd720d3b2c
using System;
using Classes.Model;
using Classes.Service;
using Classes.Repository;
using Classes.Controller;
using System.Collections.Generic;
namespace Classes.Model
{
   public class StaticEquipment
   {
<<<<<<< Updated upstream
<<<<<<< HEAD
      public string roomName;
=======
<<<<<<< HEAD
>>>>>>> 22c5e86ff397741ea3d7633e5efd94cd720d3b2c
      public int id;
<<<<<<< HEAD
      public String typeOdStaticEquipment;
=======
      public String name;
      
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
                  oldRoom.RemoveStaticEquipment(this);
               }
               if (value != null)
               {
                  this.room = value;
                  this.room.AddStaticEquipment(this);
               }
            }
         }
      }
>>>>>>> 83499ee84be005688bb7f3e09a0e6c98d5c5d410
   
=======
        public string roomName { get; set; }
        public string id { get; set; }
        public string typeOdStaticEquipment { get; set; }
        public string quantity { get; set; }






      /*public int id;
      public String typeOdStaticEquipment;
      public int quantity;*/
>>>>>>> Stashed changes
   }
=======
        public StaticEquipment(string roomName, int id, string typeOdStaticEquipment, int quantity)
        {
            this.roomName = roomName;
            this.id = id;
            this.typeOdStaticEquipment = typeOdStaticEquipment;
            this.quantity = quantity;
        }
        
        public string roomName { get; set; }
        public int id { get; set; }
        public string typeOdStaticEquipment { get; set; }
        public int quantity { get; set; }
    }
>>>>>>> fd620a89ab765ad29524f4512b4a532feef65325
}