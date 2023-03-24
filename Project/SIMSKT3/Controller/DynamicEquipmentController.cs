<<<<<<< HEAD
<<<<<<<< HEAD:Project/SIMSKT3/Controller/DynamicEquipmentController.cs
=======
>>>>>>> 83499ee84be005688bb7f3e09a0e6c98d5c5d410
// File:    DynamicEquipmentController.cs
// Author:  rakoc
// Created: Thursday, April 8, 2021 12:46:37 AM
// Purpose: Definition of Class DynamicEquipmentController

<<<<<<< HEAD
========
>>>>>>>> 83499ee84be005688bb7f3e09a0e6c98d5c5d410:Project/SIMSKT3/Controller/WarehouseController.cs
using System;
=======
using System;
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
namespace Classes.Controller
{
   public class DynamicEquipmentController
   {
<<<<<<< HEAD
      DynamicEquipmentService dynamService = new DynamicEquipmentService();

      public void Extract(DynamicEquipment dynamicEquip)
      {
            dynamService.Extract(dynamicEquip);
      }
      
      public void Create(DynamicEquipment dynama)
      {
            dynamService.Create(dynama);
      }
      
      public DynamicEquipment Read(int id)
=======
<<<<<<< HEAD
      public void CreateDynamicEquipment(Classes.Model.DynamicEquipment dynamicEquip)
=======
      public Classes.Model.DynamicEquipment Extract(string name, int quantity)
      {
         throw new NotImplementedException();
      }
      
      public int Create(string typeOfEquip, int quantity)
>>>>>>> fd620a89ab765ad29524f4512b4a532feef65325
      {
         throw new NotImplementedException();
      }
      
<<<<<<< HEAD
      public DynamicEquipment ReadDynamicEquipment(int id)
=======
      public DynamicEquipment Read(int id)
>>>>>>> fd620a89ab765ad29524f4512b4a532feef65325
>>>>>>> 83499ee84be005688bb7f3e09a0e6c98d5c5d410
      {
         throw new NotImplementedException();
      }
      
<<<<<<< HEAD
      public void Update(DynamicEquipment dynamicEquip)
      {
            dynamService.Update(dynamicEquip);
      }
      
      public void Delete(int id)
      {
            dynamService.Delete(id);
      }
      
      public void DeleteAll()
      {
            dynamService.DeleteAll();
      }
      
      public List<DynamicEquipment> ReadAll()
=======
<<<<<<< HEAD
      public void UpdateDynamicEquipment(Classes.Model.DynamicEquipment dynamicEquip)
=======
      public DynamicEquipment Update(string typeOfEquip, int quantity)
>>>>>>> fd620a89ab765ad29524f4512b4a532feef65325
      {
         throw new NotImplementedException();
      }
      
<<<<<<< HEAD
      public void DeleteDynamicEquipment(int id)
=======
      public void Delete(int id)
>>>>>>> fd620a89ab765ad29524f4512b4a532feef65325
      {
         throw new NotImplementedException();
      }
      
<<<<<<< HEAD
      public List<DynamicEquipment> ReadAllDynamicEquipment()
=======
      public void DeleteAll()
>>>>>>> fd620a89ab765ad29524f4512b4a532feef65325
      {
         throw new NotImplementedException();
      }
      
<<<<<<< HEAD
      public void Extract(string name, int quantity)
=======
      public List<DynamicEquipment> ReadAll()
>>>>>>> fd620a89ab765ad29524f4512b4a532feef65325
>>>>>>> 83499ee84be005688bb7f3e09a0e6c98d5c5d410
      {
         throw new NotImplementedException();
      }
      
<<<<<<< HEAD
=======
      public Classes.Service.DynamicEquipmentService dynamicEquipmentService;
   
>>>>>>> 83499ee84be005688bb7f3e09a0e6c98d5c5d410
   }
}