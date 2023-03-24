<<<<<<< HEAD
=======
<<<<<<< HEAD
>>>>>>> 83499ee84be005688bb7f3e09a0e6c98d5c5d410
// File:    RenovationService.cs
// Author:  LifeBook A574
// Created: Wednesday, April 28, 2021 12:54:04 PM
// Purpose: Definition of Class RenovationService

using System;
<<<<<<< HEAD
=======

=======
using System;
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
namespace Classes.Service
{
   public class RenovationService
   {
<<<<<<< HEAD
      public Renovation SetRenovation(Renovation renovation)
=======
<<<<<<< HEAD
      public void CreateRenovation(Renovation renovation)
>>>>>>> 83499ee84be005688bb7f3e09a0e6c98d5c5d410
      {
         throw new NotImplementedException();
      }
      
<<<<<<< HEAD
      public Renovation ReadSettledRenovationById(int renovationId)
=======
      public Renovation ReadRenovation(int renovationId)
=======
      RenovationRepository renovationRepository = new RenovationRepository();
      public int SetRenovation(Renovation renovation)
      {
         return renovationRepository.SetRenovation(renovation);
      }
      
      public Renovation ReadSettledRenovationById(int renovationId)
>>>>>>> fd620a89ab765ad29524f4512b4a532feef65325
>>>>>>> 83499ee84be005688bb7f3e09a0e6c98d5c5d410
      {
         throw new NotImplementedException();
      }
      
<<<<<<< HEAD
      public Renovation UpdateSettledRenovation(Renovation renovation)
=======
<<<<<<< HEAD
      public void UpdateRenovation(Renovation renovation)
=======
      public Renovation UpdateSettledRenovation(Renovation renovation)
>>>>>>> fd620a89ab765ad29524f4512b4a532feef65325
>>>>>>> 83499ee84be005688bb7f3e09a0e6c98d5c5d410
      {
         throw new NotImplementedException();
      }
      
<<<<<<< HEAD
      public void RemoveSettledRenovationById(int renovationId)
=======
<<<<<<< HEAD
      public void DeleteRenovationById(Renovation renovation)
=======
      public void RemoveSettledRenovationById(Renovation renovation)
>>>>>>> fd620a89ab765ad29524f4512b4a532feef65325
>>>>>>> 83499ee84be005688bb7f3e09a0e6c98d5c5d410
      {
         throw new NotImplementedException();
      }
      
      public List<Renovation> ReadAllRenovations()
      {
         throw new NotImplementedException();
      }
<<<<<<< HEAD
=======
<<<<<<< HEAD
>>>>>>> 83499ee84be005688bb7f3e09a0e6c98d5c5d410
      
      public Classes.Repository.RenovationRepository renovationRepository;
   
   }
<<<<<<< HEAD
=======
=======
        //public Classes.Repository.RenovationRepository renovationRepository;
    }
>>>>>>> fd620a89ab765ad29524f4512b4a532feef65325
>>>>>>> 83499ee84be005688bb7f3e09a0e6c98d5c5d410
}