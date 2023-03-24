<<<<<<< HEAD
=======
<<<<<<< HEAD
// File:    NewsRepository.cs
// Author:  LENOVO
// Created: Tuesday, April 27, 2021 1:06:54 PM
// Purpose: Definition of Class NewsRepository

using System;

namespace Classes.Repository
{
   public class NewsRepository
   {
      public News updateNews(News news)
      {
         throw new NotImplementedException();
      }
      
      public News getById(int newsId)
      {
         throw new NotImplementedException();
      }
      
      public List<News getAllNews()
      {
         throw new NotImplementedException();
      }
      
      public void saveNews(News news)
      {
         throw new NotImplementedException();
      }
      
      public void deleteNews(int newsId)
      {
         throw new NotImplementedException();
      }
   
   }
=======
>>>>>>> 83499ee84be005688bb7f3e09a0e6c98d5c5d410
using System;
using Classes.Model;
using Classes.Service;
using Classes.Repository;
using Classes.Controller;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
namespace Classes.Repository

//namespace SIMSKT3.Repository
{
    public class NewsBoardRepository
    {
        public List<News> news = new List<News>();

        public NewsBoardRepository()
        {
            if (!File.Exists("news.json"))
            {
                File.Create("news.json").Close();
            }

            using (StreamReader r = new StreamReader("news.json"))
            {
                string json = r.ReadToEnd();
                if (json != "")
                {
                    news = JsonConvert.DeserializeObject<List<News>>(json);
                }
            }
        }
        public void writeInJson()
        {
            string json = JsonConvert.SerializeObject(news, Formatting.Indented);
            File.WriteAllText("news.json", json);
        }


        public void MakeNew(News neww)
        {
            news.Add(neww);
            writeInJson();
        }

        public void ReadFromPatientStorage(int id)
        {

        }
        
        public News readNews(int id)
        {
            return news.Find(obj => obj.id == id);
        }

        public void updateNews(News neww)
        {
            int index = news.FindIndex(obj => obj.id == neww.id);
            news[index] = neww;
            writeInJson();
        }

        public List<News> getAll()
        {
            
            return news;
        }

        public void DeleteAllNews()
        {
            foreach (var all in news.ToArray())
            {
                news.Remove(all);
            }
            writeInJson();
        }

        public void DeleteNewsById(int id)
        {
            foreach (var nee in news.ToArray())
            {
                if (nee.id == id)
                {
                    news.Remove(nee);
                    writeInJson();
                }
            }
        }

       
        public string path;
    }
<<<<<<< HEAD
=======
>>>>>>> fd620a89ab765ad29524f4512b4a532feef65325
>>>>>>> 83499ee84be005688bb7f3e09a0e6c98d5c5d410
}