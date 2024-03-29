using System;
using Classes.Model;
using Classes.Service;
using Classes.Repository;
using Classes.Controller;
using System.Collections.Generic;
namespace Classes.Model
{
   public class Address
   {
      private int id;
      private string street;
      private int number;
      private string city;
      private string state;
      private int postalCode;
      
      public System.Collections.ArrayList user;
      
      public System.Collections.ArrayList User
      {
         get
         {
            if (user == null)
               user = new System.Collections.ArrayList();
            return user;
         }
         set
         {
            RemoveAllUser();
            if (value != null)
            {
               foreach (User oUser in value)
                  AddUser(oUser);
            }
         }
      }
      
      /// <summary>
      /// Add a new User in the collection
      /// </summary>
      /// <pdGenerated>Default Add</pdGenerated>
      public void AddUser(User newUser)
      {
         if (newUser == null)
            return;
         if (this.user == null)
            this.user = new System.Collections.ArrayList();
         if (!this.user.Contains(newUser))
            this.user.Add(newUser);
      }
      
      /// <summary>
      /// Remove an existing User from the collection
      /// </summary>
      /// <pdGenerated>Default Remove</pdGenerated>
      public void RemoveUser(User oldUser)
      {
         if (oldUser == null)
            return;
         if (this.user != null)
            if (this.user.Contains(oldUser))
               this.user.Remove(oldUser);
      }
      
      /// <summary>
      /// Remove all instances of User from the collection
      /// </summary>
      /// <pdGenerated>Default removeAll</pdGenerated>
      public void RemoveAllUser()
      {
         if (user != null)
            user.Clear();
      }
   
   }
}