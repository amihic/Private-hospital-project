// File:    NewsBoardService.cs
// Author:  LENOVO
// Created: Tuesday, April 27, 2021 1:03:26 PM
// Purpose: Definition of Class NewsBoardService

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
   public class NewsBoardService
   {
<<<<<<< HEAD
=======
<<<<<<< HEAD
      public News CreateNews(News news)
=======
>>>>>>> 83499ee84be005688bb7f3e09a0e6c98d5c5d410


        NewsBoardRepository newsRepository = new NewsBoardRepository();


        public void UpdateNews(News news)
        {
            newsRepository.updateNews(news);
        }

        public News ReadNews(int id)
        {
            return newsRepository.readNews(id);
        }

        public List<News> readAllNews()
        {
            return newsRepository.getAll();
        }

        public void Save(News neww)
        {
            newsRepository.MakeNew(neww);
        }
        //public void Save(News news)
        //{
        //    newsRepository.createNews(news);
        //}

        public void DeleteNews(int id)
        {
            newsRepository.DeleteNewsById(id);
        }
        public void DeleteAllNews()
        {
            newsRepository.DeleteAllNews();
        }



        public News CreateNews(News news)
<<<<<<< HEAD
=======
>>>>>>> fd620a89ab765ad29524f4512b4a532feef65325
      {
         throw new NotImplementedException();
      }
      
<<<<<<< HEAD
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
>>>>>>> 83499ee84be005688bb7f3e09a0e6c98d5c5d410
      {
         throw new NotImplementedException();
      }
      
<<<<<<< HEAD
=======
      public Classes.Repository.NewsRepository newsRepository;
=======
>>>>>>> 83499ee84be005688bb7f3e09a0e6c98d5c5d410
      
      
      
      
      
      
      
     
      
      //public Classes.Repository.NewsRepository newsRepository;
<<<<<<< HEAD
=======
>>>>>>> fd620a89ab765ad29524f4512b4a532feef65325
>>>>>>> 83499ee84be005688bb7f3e09a0e6c98d5c5d410
   
   }
}