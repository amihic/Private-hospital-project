
using System;
<<<<<<< HEAD
using Classes.Model;
using Classes.Service;
using Classes.Repository;
using Classes.Controller;
using System.Collections.Generic;
=======

>>>>>>> 83499ee84be005688bb7f3e09a0e6c98d5c5d410
namespace Classes.Service
{
   public class DynamicEquipmentService
   {
<<<<<<< HEAD
      public void CreateDynamicEquipment(Classes.Model.DynamicEquipment dynamicEquip)
=======
        DynamicEquipmentRepository dynamRepository = new DynamicEquipmentRepository();

        public void Extract(DynamicEquipment dynamicEquip)
>>>>>>> fd620a89ab765ad29524f4512b4a532feef65325
      {
            dynamRepository.ExtractFromStorage(dynamicEquip);
      }
      
<<<<<<< HEAD
      public DynamicEquipment ReadDynamicEquipment(int id)
=======
      public void Create(DynamicEquipment dynama)
>>>>>>> fd620a89ab765ad29524f4512b4a532feef65325
      {
            dynamRepository.CreateDynamicEquip(dynama);
      }
      
      public void UpdateDynamicEquipment(Classes.Model.DynamicEquipment dynamicEquip)
      {
         throw new NotImplementedException();
      }
      
<<<<<<< HEAD
      public void DeleteDynamicEquipment(int id)
=======
      public void Update(DynamicEquipment dynamicEquip)
>>>>>>> fd620a89ab765ad29524f4512b4a532feef65325
      {
            dynamRepository.UpdateDynamicEquip(dynamicEquip);
      }
      
      public List<DynamicEquipment> ReadAllDynamicEquipment()
      {
            dynamRepository.DeleteDynamicEquip(id);
      }
      
<<<<<<< HEAD
      public void Extract(string name, int quantity)
=======
      public void DeleteAll()
      {
            dynamRepository.DeleteAllDynamicEquips();
      }
      
      public List<DynamicEquipment> ReadAll()
>>>>>>> fd620a89ab765ad29524f4512b4a532feef65325
      {
         throw new NotImplementedException();
      }
      
      public Classes.Repository.DynamicEquipmentRepository dynamicEquipmentRepository;
   
   }
}