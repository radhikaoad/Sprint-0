using System;

namespace Calendar
{
     [Serializable]
     public class Event
     {
          public string Title, Location, Time, Date;

          public Event()
          {

          }

          public Event(string Title, string Location, string Time, string Date)
          {
               this.Title = Title;
               this.Location = Location;
               this.Time = Time;
               this.Date = Date;
          }

          public string getTitle()
          {
               return Title;
          }

          public string getLocation()
          {
               return Location;
          }

          public string getTime()
          {
               return Time;
          }

          public string getDate()
          {
               return Date;
          }
     }
}
