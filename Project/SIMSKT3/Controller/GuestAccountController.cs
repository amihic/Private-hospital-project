using System;
using Classes.Model;
using Classes.Service;
using Classes.Repository;
using Classes.Controller;
using System.Collections.Generic;
namespace Classes.Controller

//namespace SIMSKT3.Controller
{
    public class GuestAccountController
    {
        GuestAccountService guestsService = new GuestAccountService();

        public void Create(GuestAccount guest)
        {
            guestsService.Save(guest);
        }

        public Classes.Model.GuestAccount Read(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(GuestAccount guest)
        {
            guestsService.Update(guest);
        }

        /*public void Delete(int id, string allergenName)
        {
            guestsService.removeAll(id, allergenName);
        }*/

        public List<Allergen> ReadAll()
        {
            throw new NotImplementedException();
        }

        /* public void DeleteAll()
         {
             guestsService.DeleteAll();
         }*/

        /*
        public void TransferTo(string fromRoomName, string toRoomName, string typeOdStaticEquipment, int equipId, int quantity, DateTime enterDate)
        {
            allergensService.ToRoom(fromRoomName, toRoomName, typeOdStaticEquipment, equipId, quantity, enterDate);
        }

        public bool ClaimTransfer()
        {
            throw new NotImplementedException();
        }

        public void TransferSuccessfull(string notification)
        {
            throw new NotImplementedException();
        }

        public Classes.Service.StaticEquipmentService staticEquipmentService;

    }*/

        public Classes.Service.GuestAccountService guestAccountService;









    }
}
