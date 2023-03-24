// File:    EmployeeService.cs
// Author:  MIHA1
// Created: Saturday, May 1, 2021 1:43:51 PM
// Purpose: Definition of Class EmployeeService

using System;
<<<<<<< HEAD
=======
<<<<<<< HEAD

=======
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
   public class EmployeeService
   {
      public List<Doctor> GetDoctorBySpecialization(string specialization)
      {
         throw new NotImplementedException();
      }
      
<<<<<<< HEAD
=======
<<<<<<< HEAD
      public Classes.Model.Employee CreateEmployee(Classes.Model.Employee employee)
      {
         throw new NotImplementedException();
      }
      
      public Classes.Model.Employee ReadEmployee(int employeeId)
      {
         throw new NotImplementedException();
      }
      
      public Classes.Model.Employee UpdateEmployee(Classes.Model.Employee employee)
      {
         throw new NotImplementedException();
      }
      
      public void DeleteEmployeeById(int employeeId)
      {
         throw new NotImplementedException();
      }
      
      public List<Employee> ReadAllEmployees()
      {
         throw new NotImplementedException();
      }
      
      public boolean MarkOffDaysForDoctor(System.TimeSpan parameter1, string explanation, boolean onOffDays)
      {
         throw new NotImplementedException();
      }
      
=======
>>>>>>> fd620a89ab765ad29524f4512b4a532feef65325
>>>>>>> 83499ee84be005688bb7f3e09a0e6c98d5c5d410
      public Classes.Repository.EmployeeRepository employeeRepository;
   
   }
}