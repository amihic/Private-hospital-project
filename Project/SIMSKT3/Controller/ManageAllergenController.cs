using System;
using Classes.Model;
using Classes.Service;
using Classes.Repository;
using Classes.Controller;
using System.Collections.Generic;
namespace Classes.Controller
//namespace SIMSKT3.Controller
{
    class ManageAllergensController
    {
        ManageAllergenService allergensService = new ManageAllergenService();

        //public void Create(Allergen allergen)
        //{
        //    allergensService.Save(allergen);
        //}

        public Classes.Model.StaticEquipment Read(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Allergen allergen)
        {
            allergensService.Update(allergen);
        }

        public void Delete(int id, string allergenName)
        {
            allergensService.removeAll(id, allergenName);
        }

        public List<Allergen> ReadAll()
        {
            throw new NotImplementedException();
        }

        public void DeleteAll()
        {
            allergensService.DeleteAll();
        }

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

        public Classes.Service.ManageAllergenService manageAllergenService;

    }
}
