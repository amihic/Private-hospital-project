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
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SIMSKT3;
>>>>>>> fd620a89ab765ad29524f4512b4a532feef65325
>>>>>>> 83499ee84be005688bb7f3e09a0e6c98d5c5d410
namespace Classes.Repository
{
   public class RoomRepository
   {
<<<<<<< HEAD
      public void CreateRoom(Classes.Model.Room room)
      {
         throw new NotImplementedException();
      }
      
      public Classes.Model.Room ReadRoom(int id)
      {
         throw new NotImplementedException();
      }
      
      public void UpdateRoom(Classes.Model.Room room)
=======
        public List<Room> rooms = new List<Room>();

        public RoomRepository()
        {
            if (!File.Exists("rooms.json"))
            {
                File.Create("rooms.json").Close();
            }

            using (StreamReader r = new StreamReader("rooms.json"))
            {
                string json = r.ReadToEnd();
                if (json != "")
                {
                    rooms = JsonConvert.DeserializeObject<List<Room>>(json);
                }
            }
        }
        public void writeInJson()
        {
            string json = JsonConvert.SerializeObject(rooms, Formatting.Indented);
            File.WriteAllText("rooms.json", json);
        }

        public void MakeNew(Room room)
        {
            rooms.Add(room);
            writeInJson();
        }

        public void ReadFromStorage(int id)
        {

        }

        public void update(Room room)
>>>>>>> fd620a89ab765ad29524f4512b4a532feef65325
      {
            int index = rooms.FindIndex(obj => obj.id == room.id);
            rooms[index] = room;
            writeInJson();
        }
      
<<<<<<< HEAD
      public void deleteRoomFromStorage(int roomId)
=======
      public void DeleteRoom(int id)
>>>>>>> 83499ee84be005688bb7f3e09a0e6c98d5c5d410
      {
            int index = rooms.FindIndex(obj => obj.id == id);
            rooms.RemoveAt(index);
            writeInJson();
      }
<<<<<<< HEAD
      
      public List<Room> ReadAllRooms()
=======
      public List<Room> getAll()
>>>>>>> fd620a89ab765ad29524f4512b4a532feef65325
      {
<<<<<<< HEAD
         throw new NotImplementedException();
      }
      
      public void DeleteAllRooms()
=======
            return rooms;
      }
      
      public void MergeRooms(List<Room> RoomsForMerge)
      {
            foreach (var roo in rooms.ToArray())
            {
                rooms.Remove(roo);
            }
            writeInJson();
      }
      
      public void SplitRoom(Classes.Model.Room roomForSplit, int numberOfSplits)
>>>>>>> 83499ee84be005688bb7f3e09a0e6c98d5c5d410
      {
         throw new NotImplementedException();
      }
      
      public string path;
   
   }
}