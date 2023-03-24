// File:    ReferralLetterController.cs
// Author:  LifeBook A574
// Created: Monday, April 26, 2021 6:58:47 PM
// Purpose: Definition of Class ReferralLetterController

using System;
using Classes.Model;
using Classes.Service;
using Classes.Repository;
using Classes.Controller;
using System.Collections.Generic;
namespace Classes.Controller
{
   public class ReferralLetterController
   {
      public ReferralLetterController CreateReferralLetter(ReferralLetterController letter)
      {
         throw new NotImplementedException();
      }
      
      public ReferralLetterController ReadReferralLetter(int id)
      {
         throw new NotImplementedException();
      }
      
      public List<ReferralLetter> ReadAllReferralLetter()
      {
         throw new NotImplementedException();
      }
      
      public Classes.Service.ReferralLetterService referralLetterService;
   
   }
}