// File:    ReferralLetterService.cs
// Author:  LifeBook A574
// Created: Wednesday, April 28, 2021 10:29:11 AM
// Purpose: Definition of Class ReferralLetterService

using System;
using Classes.Model;
using Classes.Service;
using Classes.Repository;
using Classes.Controller;
using System.Collections.Generic;
namespace Classes.Service
{
   public class ReferralLetterService
   {
      public Classes.Controller.ReferralLetterController CreateReferralLetter(Classes.Controller.ReferralLetterController letter)
      {
         throw new NotImplementedException();
      }
      
      public Classes.Controller.ReferralLetterController ReadReferralLetter(int id)
      {
         throw new NotImplementedException();
      }
      
      public List<ReferralLetter> ReadAllReferralLetter()
      {
         throw new NotImplementedException();
      }
      
      public Classes.Repository.ReferralLetterRepository referralLetterRepository;
   
   }
}