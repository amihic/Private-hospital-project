using System;
using Classes.Model;
using Classes.Service;
using Classes.Repository;
using Classes.Controller;
using System.Collections.Generic;
namespace Classes.Model
{
   public class DynamicEquipment
   {
        public DynamicEquipment(int id, string typeOfEquip, int quantity)
        {
            this.id = id;
            this.typeOfDynamicEquipment = typeOfEquip;
            this.quantity = quantity;
        }
      public int id;
<<<<<<< HEAD
      public String name;
=======
      public string typeOfDynamicEquipment;
>>>>>>> fd620a89ab765ad29524f4512b4a532feef65325
      public int quantity;
   
   }
}