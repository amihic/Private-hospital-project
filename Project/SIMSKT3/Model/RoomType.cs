// File:    TipProstorije.cs
// Author:  rakoc
// Created: Monday, March 22, 2021 10:29:08 PM
// Purpose: Definition of Enum TipProstorije

using System;
using Classes.Model;
using Classes.Service;
using Classes.Repository;
using Classes.Controller;
using System.Collections.Generic;
namespace Classes.Model
{
   public enum RoomType
   {
      operatingRoom,
      ordination,
      intensiveCare
   }
}