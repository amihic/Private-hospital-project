// File:    ReferralLetterForSpecialistService.cs
// Author:  LifeBook A574
// Created: Wednesday, April 28, 2021 10:29:11 AM
// Purpose: Definition of Class ReferralLetterForSpecialistService

using System;

namespace Classes.Service
{
   public class ReferralLetterForSpecialistService
   {
      public Classes.Controller.ReferralLetterForSpecialistController CreateReferralLetter(Classes.Controller.ReferralLetterForSpecialistController letter)
      {
         throw new NotImplementedException();
      }
      
      public Classes.Controller.ReferralLetterForSpecialistController ReadReferralLetter(int referralLetterId)
      {
         throw new NotImplementedException();
      }
      
      public List<ReferralLetter> ReadAllReferralLetter()
      {
         throw new NotImplementedException();
      }
      
      public Classes.Repository.ReferralLetterForSpecialistRepository referralLetterForSpecialistRepository;
   
   }
}