using System;
using Classes.Model;
using Classes.Service;
using Classes.Repository;
using Classes.Controller;
using System.Collections.Generic;

namespace Classes.Service
//namespace SIMSKT3.Service
{
    public class ManageAllergenService
    {


        ManageAllergenRepository allergensRepository = new ManageAllergenRepository();


        public void Update(Allergen allergen)
        {
            allergensRepository.updateAllergen(allergen);
        }

        public Allergen GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Allergen> GetAll()
        {
            throw new NotImplementedException();
        }

        //public void Save(Allergen allergen)
        //{
        //    allergensRepository.createAllergen(allergen);
        //}

        public void removeAll(int id, string allergenName)
        {
            allergensRepository.DeleteAllergenById(id, allergenName);
        }
        public void DeleteAll()
        {
            allergensRepository.DeleteAllAllergens();
        }

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




        public Classes.Repository.ManageAllergenRepository manageAllergenRepository;


    }
}

