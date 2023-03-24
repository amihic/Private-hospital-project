/***********************************************************************
 * Module:  EmployeeType.cs
 * Author:  rakoc
 * Purpose: Definition of the Class EmployeeType
 ***********************************************************************/

using System;
using Classes.Model;
using Classes.Service;
using Classes.Repository;
using Classes.Controller;
using System.Collections.Generic;
namespace Classes.Model
{
   public enum EmployeeType
   {
      Director,
      Secretary,
      Doctor
   }
}