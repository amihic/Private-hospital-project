<<<<<<< HEAD
// File:    RoomController.cs
// Author:  rakoc
// Created: Thursday, April 8, 2021 12:24:35 AM
// Purpose: Definition of Class RoomController

<<<<<<< HEAD
=======
using System;

=======
>>>>>>> 83499ee84be005688bb7f3e09a0e6c98d5c5d410
using System;
using Classes.Model;
using Classes.Service;
using Classes.Repository;
using Classes.Controller;
using System.Collections.Generic;
<<<<<<< HEAD
=======
using SIMSKT3;
>>>>>>> fd620a89ab765ad29524f4512b4a532feef65325
>>>>>>> 83499ee84be005688bb7f3e09a0e6c98d5c5d410
namespace Classes.Controller
{
   public class RoomController
   {
<<<<<<< HEAD
      public void CreateRoom(Classes.Model.Room room)
      {
         throw new NotImplementedException();
      }
      
      public Classes.Model.Room ReadRoom(int id)
=======
        RoomService roomService = new RoomService();
      public void create(Room rum)
>>>>>>> fd620a89ab765ad29524f4512b4a532feef65325
      {
            roomService.Save(rum);
      }
      
<<<<<<< HEAD
      public void UpdateRoom(Classes.Model.Room room)
=======
      public void read(int id)
>>>>>>> fd620a89ab765ad29524f4512b4a532feef65325
      {
            roomService.GetById(id);
      }
      
<<<<<<< HEAD
      public void DeleteRoom(int id)
=======
      public void update(Room room)
>>>>>>> fd620a89ab765ad29524f4512b4a532feef65325
      {
            roomService.Update(room);
      }
      
      public List<Room> ReadAllRooms()
      {
            roomService.removeRoom(id);
      }
      
      public void MergeRooms(List<Room> RoomsForMerge)
      {
            return roomService.GetAll();
      }
      
      public void SplitRoom(Classes.Model.Room roomForSplit, int numberOfSplits)
      {
            roomService.removeAllRooms();
      }
   }
}