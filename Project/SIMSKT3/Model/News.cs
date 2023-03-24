<<<<<<< HEAD
=======
<<<<<<< HEAD
// File:    News.cs
// Author:  LENOVO
// Created: Tuesday, April 27, 2021 12:56:54 PM
// Purpose: Definition of Class News

using System;

namespace Classes.Model
{
   public class News
   {
      public int id;
      public string title;
      public string text;
      public DateTime date;
      
      public NewsBoard newsBoard;
   
   }
=======
>>>>>>> 83499ee84be005688bb7f3e09a0e6c98d5c5d410
using System;
using System.Collections.Generic;
namespace Classes.Model
{
    public class News
    {

        public int id { get; set; }
        public string title { get; set; }
        public string text { get; set; }
        public string date { get; set; }

        public News(int id, string title, string text, string date)
        {
            this.id = id;
            this.title = title;
            this.text = text;
            this.date = date;

        }



        public News() { }


        public News read(int id)
        {
            throw new NotImplementedException();
        }

        public News update(string name, string diagnosisDate)
        {
            throw new NotImplementedException();
        }

        public void delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<News> readAll()
        {
            throw new NotImplementedException();
        }

        public void deleteAll()
        {
            throw new NotImplementedException();
        }

        internal static IEnumerable<object> ToArray()
        {
            throw new NotImplementedException();
        }
    }
<<<<<<< HEAD
=======
>>>>>>> fd620a89ab765ad29524f4512b4a532feef65325
>>>>>>> 83499ee84be005688bb7f3e09a0e6c98d5c5d410
}