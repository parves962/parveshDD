using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Assignment.CommentObserver
{
    public class Observer
    {
        public int EventId;

        public string UserName;

        public DateTime Timestamp;

        public string Comment;

        public  static List<Observer> Com = new List<Observer>();

        public Observer(int eventid,string username,string comment)
        {
            this.EventId = eventid;
            this.UserName = username;
            this.Comment = comment;
        }

        public void Notify(Observer obj)
        {
            Com.Add(obj);
        }
    }
}
