<<<<<<< HEAD
=======
<<<<<<< HEAD
// File:    NewsBoardController.cs
// Author:  LENOVO
// Created: Tuesday, April 27, 2021 12:53:43 PM
// Purpose: Definition of Class NewsBoardController

using System;

namespace Classes.Controller
{
   public class NewsBoardController
   {
      public News CreateNews(News news)
      {
         throw new NotImplementedException();
      }
      
      public News ReadNews(int newsId)
      {
         throw new NotImplementedException();
      }
      
      public News UpdateNews(News news)
      {
         throw new NotImplementedException();
      }
      
      public void DeleteNews(int newsId)
      {
         throw new NotImplementedException();
      }
      
      public List<News> ReadAllNews()
      {
         throw new NotImplementedException();
      }
      
      public void DeleteAllNews()
      {
         throw new NotImplementedException();
      }
      
      public Classes.Service.NewsBoardService newsBoardService;
   
   }
=======
>>>>>>> 83499ee84be005688bb7f3e09a0e6c98d5c5d410
using System;
using Classes.Model;
using Classes.Service;
using Classes.Repository;
using Classes.Controller;
using System.Collections.Generic;
namespace Classes.Controller

//namespace SIMSKT3.Controller
{
    class NewsBoardController
    {
        NewsBoardService newsService = new NewsBoardService();

        public void create(News neww)
        {
            newsService.Save(neww);
        }
        //public void Create(News news)
        //{
        //    newsService.Save(news);
        //}

        public Classes.Model.StaticEquipment Read(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(News news)
        {
            newsService.UpdateNews(news);
        }

        public void Delete(int id)
        {
            newsService.DeleteNews(id);
        }

        public List<News> ReadAll()
        {
            return newsService.readAllNews();
        }

        public void DeleteAll()
        {
            newsService.DeleteAllNews();
        }

        public News read(int id)
        {
            return newsService.ReadNews(id);
        }
        /*
        public void TransferTo(string fromRoomName, string toRoomName, string typeOdStaticEquipment, int equipId, int quantity, DateTime enterDate)
        {
            allergensService.ToRoom(fromRoomName, toRoomName, typeOdStaticEquipment, equipId, quantity, enterDate);
        }

        public bool ClaimTransfer()
        {
            throw new NotImplementedException();
        }

        public void TransferSuccessfull(string notification)
        {
            throw new NotImplementedException();
        }

        public Classes.Service.StaticEquipmentService staticEquipmentService;

    }*/

        public Classes.Service.NewsBoardService newsBoardService;

    }
<<<<<<< HEAD
=======
>>>>>>> fd620a89ab765ad29524f4512b4a532feef65325
>>>>>>> 83499ee84be005688bb7f3e09a0e6c98d5c5d410
}