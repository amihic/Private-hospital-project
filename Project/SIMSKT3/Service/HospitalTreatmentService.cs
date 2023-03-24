// File:    HospitalTreatmentService.cs
// Author:  LifeBook A574
// Created: Wednesday, May 12, 2021 10:28:51 AM
// Purpose: Definition of Class HospitalTreatmentService

using System;

namespace Classes.Service
{
   public class HospitalTreatmentService
   {
      public HospitalTreatment CreateHospitalTreatment(HospitalTreatment hospitalTreatment)
      {
         throw new NotImplementedException();
      }
      
      public HospitalTreatment ReadHospitalTreatmentById(int hospitalTreatmentId)
      {
         throw new NotImplementedException();
      }
      
      public void ExtendHospitalTreatment(int hospitalTreatmentId, int numberOfDays)
      {
         throw new NotImplementedException();
      }
      
      public Classes.Repository.HospitalTreatmentRepository hospitalTreatmentRepository;
   
   }
}