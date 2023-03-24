// File:    RoomService.cs
// Author:  rakoc
// Created: Wednesday, April 7, 2021 11:23:46 PM
// Purpose: Definition of Class RoomService

using System;
<<<<<<< HEAD

=======
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
namespace Classes.Service
{
   public class RoomService
   {
<<<<<<< HEAD
      public Classes.Model.Room create(int id, string name, int floor, Classes.Model.RoomType type, string description)
      {
         throw new NotImplementedException();
      }
      
      public Classes.Model.Room read(int id)
=======
<<<<<<< HEAD
      public void CreateRoom(Classes.Model.Room room)
=======
        RoomRepository roomRepository = new RoomRepository();
      public void Update(Room room)
>>>>>>> fd620a89ab765ad29524f4512b4a532feef65325
>>>>>>> 83499ee84be005688bb7f3e09a0e6c98d5c5d410
      {
            roomRepository.update(room);
      }
      
<<<<<<< HEAD
      public Classes.Model.Room update(int id, string name, int floor, Classes.Model.RoomType type, string description)
=======
<<<<<<< HEAD
      public Classes.Model.Room ReadRoom(int id)
=======
      public void GetById(int id)
>>>>>>> fd620a89ab765ad29524f4512b4a532feef65325
>>>>>>> 83499ee84be005688bb7f3e09a0e6c98d5c5d410
      {
            roomRepository.ReadFromStorage(id);
      }
      
      public void UpdateRoom(Classes.Model.Room room)
      {
            return roomRepository.getAll();
      }
      
      public void DeleteRoom(int id)
      {
            roomRepository.deleteRoomFromStorage(id);
      }
<<<<<<< HEAD
      
<<<<<<< HEAD
      public void delete(int id)
=======
      public List<Room> ReadAllRooms()
>>>>>>> 83499ee84be005688bb7f3e09a0e6c98d5c5d410
      {
         throw new NotImplementedException();
      }
      
<<<<<<< HEAD
      public List<Room> readAll()
=======
      public void MergeRooms(List<Room> RoomsForMerge)
>>>>>>> 83499ee84be005688bb7f3e09a0e6c98d5c5d410
      {
         throw new NotImplementedException();
      }
      
<<<<<<< HEAD
      public void deleteAll()
=======
      public void SplitRoom(Classes.Model.Room roomForSplit, int numberOfSplits)
>>>>>>> 83499ee84be005688bb7f3e09a0e6c98d5c5d410
      {
         throw new NotImplementedException();
      }
      
      public Classes.Repository.RoomRepository roomRepository;
   
=======
        public void removeAllRooms()
        {
            roomRepository.DeleteStorage();
        }
        public void Save(Room room)
        {
            roomRepository.MakeNew(room);
        }   
>>>>>>> fd620a89ab765ad29524f4512b4a532feef65325
   }
}