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
   public class StaticEquipmentService
   {
<<<<<<< HEAD
      public Classes.Model.StaticEquipment createStaticEquipment(int id, string name, int floor, Classes.Model.RoomType type, string description)
=======
<<<<<<< HEAD
      public void CreateStaticEquipment(Classes.Model.StaticEquipment staticEquip)
=======
        StaticEquipmentRepository staticRepository = new StaticEquipmentRepository();

      public void Update(StaticEquipment staticEquip)
>>>>>>> fd620a89ab765ad29524f4512b4a532feef65325
>>>>>>> 83499ee84be005688bb7f3e09a0e6c98d5c5d410
      {
            staticRepository.updateStaticEquip(staticEquip);
      }
      
<<<<<<< HEAD
      public Classes.Model.StaticEquipment readStaticEquip(int id)
=======
<<<<<<< HEAD
      public Classes.Model.StaticEquipment ReadStaticEquipment(int id)
=======
      public StaticEquipment GetById(int id)
>>>>>>> fd620a89ab765ad29524f4512b4a532feef65325
>>>>>>> 83499ee84be005688bb7f3e09a0e6c98d5c5d410
      {
         throw new NotImplementedException();
      }
      
<<<<<<< HEAD
      public Classes.Model.StaticEquipment updateStaticEquip(Classes.Model.StaticEquipment staticEquip)
=======
      public void UpdateStaticEquipment(Classes.Model.StaticEquipment staticEquip)
>>>>>>> 83499ee84be005688bb7f3e09a0e6c98d5c5d410
      {
         throw new NotImplementedException();
      }
      
<<<<<<< HEAD
      public void deleteRoomFromStorage(int id)
=======
<<<<<<< HEAD
      public void DeleteStaticEquipment(string roomName, int staticId)
>>>>>>> 83499ee84be005688bb7f3e09a0e6c98d5c5d410
      {
         throw new NotImplementedException();
      }
      
<<<<<<< HEAD
      public List<StaticEquipment> getAll()
=======
      public List<StaticEquipment> ReadAllStaticEquipment()
>>>>>>> 83499ee84be005688bb7f3e09a0e6c98d5c5d410
      {
         throw new NotImplementedException();
      }
      
<<<<<<< HEAD
      public void DeleteAllStaticEquipment()
=======
      public void TransferStaticEquipment(int fromRoomId, int toRoomId, int staticEquipId, double quantity, DateTime enterDate, DateTime startTime, DateTime endTime)
>>>>>>> 83499ee84be005688bb7f3e09a0e6c98d5c5d410
      {
         throw new NotImplementedException();
      }
      
<<<<<<< HEAD
      public void ToRoom(int fromRoomId, int toRoomId, int staticEquipId, double quantity, DateTime enterDate, DateTime startTime, DateTime endTime)
=======
      public Boolean CheckDate(DateTime transferDate)
=======
      public void Save(StaticEquipment staticEquip)
>>>>>>> fd620a89ab765ad29524f4512b4a532feef65325
>>>>>>> 83499ee84be005688bb7f3e09a0e6c98d5c5d410
      {
            staticRepository.createStaticEquipment(staticEquip);
      }
      
<<<<<<< HEAD
      public Boolean CheckDate(DateTime transferDate)
=======
      public void removeSEq(string roomName, int id)
>>>>>>> 83499ee84be005688bb7f3e09a0e6c98d5c5d410
      {
            staticRepository.DeleteStaticEquipmentById(roomName, id);
      }
<<<<<<< HEAD
      
<<<<<<< HEAD
      public Boolean CheckToTransfer(DateTime transferDate)
=======
      public bool ClaimTransfer()
=======
        public void DeleteAll()
        {
            staticRepository.DeleteAllStaticEquipment();
        }

        public int ToRoom(string fromRoomName, string toRoomName, string typeOdStaticEquipment, int equipId, int quantity, DateTime enterDate, DateTime startTime, DateTime endTime)
        {
            return staticRepository.ShiftStaticEquipment(fromRoomName, toRoomName, typeOdStaticEquipment, equipId, quantity, enterDate, startTime, endTime);
        }

        public void CheckDate(string toRoomName, DateTime transferDate, DateTime startTime, DateTime endTime)
>>>>>>> fd620a89ab765ad29524f4512b4a532feef65325
>>>>>>> 83499ee84be005688bb7f3e09a0e6c98d5c5d410
      {
            staticRepository.CheckDate(toRoomName, transferDate, startTime, endTime);
      }

        public void CheckToTransfer(DateTime transferDate, DateTime startTime, DateTime endTime)
        {
            staticRepository.CheckToTransfer(transferDate, startTime, endTime);
        }

        public void CheckQuantity(string fromRoomName, int equipId, int quantity)
        {
            staticRepository.CheckQuantity(fromRoomName, equipId, quantity);
        }
      
      public void TransferSuccessfull(string notification)
      {
         throw new NotImplementedException();
      }
      
      public Boolean CheckQuantity(int staticEquipId, double quantity)
      {
         throw new NotImplementedException();
      }
<<<<<<< HEAD
      
<<<<<<< HEAD
      public Boolean CheckQuantity(int staticEquipId, double quantity)
      {
         throw new NotImplementedException();
      }
      
      public Classes.Repository.StaticEquipmentRepository staticEquipmentRepository;
=======
      public Classes.Repository.StaticEquipmentRepository staticEquipmentRepository;
=======
>>>>>>> fd620a89ab765ad29524f4512b4a532feef65325
>>>>>>> 83499ee84be005688bb7f3e09a0e6c98d5c5d410
   
   }
}