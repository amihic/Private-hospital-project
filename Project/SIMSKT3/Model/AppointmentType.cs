// File:    AppointmentType.cs
// Author:  HP-Miha
// Created: Saturday, April 17, 2021 6:13:48 PM
// Purpose: Definition of Enum AppointmentType

using System;
using Classes.Model;
using Classes.Service;
using Classes.Repository;
using Classes.Controller;
using System.Collections.Generic;
namespace Classes.Model
{
   public enum AppointmentType
   {
      examination,
      operation
   }
}