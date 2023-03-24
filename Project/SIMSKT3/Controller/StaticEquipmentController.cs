using System;

namespace Classes.Controller
{
   public class StaticEquipmentController
   {
<<<<<<< HEAD
      public void CreateStaticEquipment(Classes.Model.StaticEquipment staticEquip)
=======
      StaticEquipmentService staticService = new StaticEquipmentService();

      public void Create(StaticEquipment staticEquip)
      {
            staticService.Save(staticEquip);
      }
      
      public Classes.Model.StaticEquipment Read(int id)
      {
         throw new NotImplementedException();
      }
      
      public void Update(StaticEquipment staticEquip)
      {
            staticService.Update(staticEquip);
      }
      
      public void Delete(string roomName, int id)
>>>>>>> fd620a89ab765ad29524f4512b4a532feef65325
      {
            staticService.removeSEq(roomName, id);
      }
      
      public Classes.Model.StaticEquipment ReadStaticEquipment(int id)
      {
         throw new NotImplementedException();
      }
      
      public void UpdateStaticEquipment(Classes.Model.StaticEquipment staticEquip)
      {
            staticService.DeleteAll();
      }
      
<<<<<<< HEAD
      public void TransferTo(int fromRoomId, int toRoomId, int staticEquipId, double quantity, DateTime enterDate, DateTime startTime, DateTime endTime)
=======
<<<<<<< HEAD
      public void DeleteStaticEquipment(string roomName, int staticId)
=======
      public int TransferTo(string fromRoomName, string toRoomName, string typeOdStaticEquipment, int equipId, int quantity, DateTime enterDate, DateTime startTime, DateTime endTime)
>>>>>>> fd620a89ab765ad29524f4512b4a532feef65325
>>>>>>> 83499ee84be005688bb7f3e09a0e6c98d5c5d410
      {
            staticService.CheckDate(toRoomName, enterDate, startTime, endTime);
            //staticService.CheckToTransfer(enterDate, startTime, endTime);
            staticService.CheckQuantity(fromRoomName, equipId, quantity);
            return staticService.ToRoom(fromRoomName, toRoomName, typeOdStaticEquipment, equipId, quantity, enterDate, startTime, endTime);
      }
<<<<<<< HEAD
      
      public List<StaticEquipment> ReadAllStaticEquipment()
=======

        public bool ClaimTransfer()
>>>>>>> fd620a89ab765ad29524f4512b4a532feef65325
      {
         throw new NotImplementedException();
      }
      
      public void TransferStaticEquipment(int fromRoomId, int toRoomId, int staticEquipId, double quantity, DateTime enterDate, DateTime startTime, DateTime endTime)
      {
         throw new NotImplementedException();
      }
      
   }
}