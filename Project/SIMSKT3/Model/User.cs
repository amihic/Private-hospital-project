using System;

namespace Classes.Model
{
    public class User
    {
        public int id;
        public string username;
        public string password;
        public string firstName;
        public string lastName;
        public string jmbg;
        public string phoneNumber;
        public string feedback;
        public string address;
        public string email;
        public DateTime dateOfBirth;

        public System.Collections.Generic.List<NotificationRefferal> notificationRefferal;

        /// <summary>
        /// Property for collection of NotificationRefferal
        /// </summary>
        /// <pdGenerated>Default opposite class collection property</pdGenerated>
        public System.Collections.Generic.List<NotificationRefferal> NotificationRefferal
        {
            get
            {
                if (notificationRefferal == null)
                    notificationRefferal = new System.Collections.Generic.List<NotificationRefferal>();
                return notificationRefferal;
            }
            set
            {
                RemoveAllNotificationRefferal();
                if (value != null)
                {
                    foreach (NotificationRefferal oNotificationRefferal in value)
                        AddNotificationRefferal(oNotificationRefferal);
                }
            }
        }

        /// <summary>
        /// Add a new NotificationRefferal in the collection
        /// </summary>
        /// <pdGenerated>Default Add</pdGenerated>
        public void AddNotificationRefferal(NotificationRefferal newNotificationRefferal)
        {
            if (newNotificationRefferal == null)
                return;
            if (this.notificationRefferal == null)
                this.notificationRefferal = new System.Collections.Generic.List<NotificationRefferal>();
            if (!this.notificationRefferal.Contains(newNotificationRefferal))
                this.notificationRefferal.Add(newNotificationRefferal);
        }

        /// <summary>
        /// Remove an existing NotificationRefferal from the collection
        /// </summary>
        /// <pdGenerated>Default Remove</pdGenerated>
        public void RemoveNotificationRefferal(NotificationRefferal oldNotificationRefferal)
        {
            if (oldNotificationRefferal == null)
                return;
            if (this.notificationRefferal != null)
                if (this.notificationRefferal.Contains(oldNotificationRefferal))
                    this.notificationRefferal.Remove(oldNotificationRefferal);
        }

        /// <summary>
        /// Remove all instances of NotificationRefferal from the collection
        /// </summary>
        /// <pdGenerated>Default removeAll</pdGenerated>
        public void RemoveAllNotificationRefferal()
        {
            if (notificationRefferal != null)
                notificationRefferal.Clear();
        }

    }
}