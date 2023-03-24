using System;
using Classes.Model;
using Classes.Service;
using Classes.Repository;
using Classes.Controller;
using System.Collections.Generic;

namespace Classes.Service
//namespace SIMSKT3.Service
{
    public class GuestAccountService
    {

        GuestAccountRepository guestsRepository = new GuestAccountRepository();


        public void Update(GuestAccount guest)
        {
            guestsRepository.updateGuest(guest);
        }

        public GuestAccount GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<GuestAccount> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Save(GuestAccount guest)
        {
            guestsRepository.createGuest(guest);
        }

        /*public void removeAll(int id, string name)
        {
            guestsRepository.DeleteGuestById(id, name);
        }
        public void DeleteAll()
        {
            guestsRepository.DeleteAllGuests();
        }*/

        /*
        public void ToRoom(string fromRoomName, string toRoomName, string typeOdStaticEquipment, int equipId, int quantity, DateTime enterDate)
        {
            allergensRepository.ShiftStaticEquipment(fromRoomName, toRoomName, typeOdStaticEquipment, equipId, quantity, enterDate);
        }

        public Boolean CheckDate(DateTime transferDate)
        {
            throw new NotImplementedException();
        }

        public Boolean CheckToTransfer(DateTime transferDate)
        {
            throw new NotImplementedException();
        }

        public Boolean CheckQuantity(double quantity)
        {
            throw new NotImplementedException();
        }

        public bool ClaimTransfer()
        {
            throw new NotImplementedException();
        }

        public void TransferSuccessfull(string notification)
        {
            throw new NotImplementedException();
        }

        public Classes.Repository.RoomRepository roomRepository;

    }*/




        public Classes.Repository.GuestAccountRepository guestAccountRepository;

    }
}
