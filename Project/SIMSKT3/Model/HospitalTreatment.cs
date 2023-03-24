// File:    HospitalTreatment.cs
// Author:  LifeBook A574
// Created: Wednesday, May 12, 2021 9:38:21 AM
// Purpose: Definition of Class HospitalTreatment

using System;

namespace Classes.Model
{
   public class HospitalTreatment
   {
      public int id;
      public Room room;
      public DateTime startDate;
      public DateTime endDate;
      public bool isExtensionNeeded = false;
      
      public Patient patient;
   
   }
}