using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalendarApp
{
   public class CalendarController
    {
        Calendar model;
        CalendarAppRootPanel view;

        public CalendarController(Calendar model, CalendarAppRootPanel view) {
            this.model = model;
            this.view = view;
            view.SetController(this);
        }

        public List<CalendarEvent> GetCalendarEventsDay(int year, int month, int day) {
            
            return this.model.CalendarEvents.FindAll(e =>
            {
                return year >= e.StartTime.Year && e.EndTime.Year >= year &&
                month >= e.StartTime.Month && e.EndTime.Month >= month &&
                day >= e.StartTime.Day && e.EndTime.Day >= day;
                        

            });
        }

        internal List<CalendarEvent> GetEventsInRange(DateTime firstVisibleDate, DateTime finalVisibleDate)
        {
            firstVisibleDate = new DateTime(firstVisibleDate.Year, firstVisibleDate.Month, firstVisibleDate.Day, 0, 0, 0, 0);
            finalVisibleDate = new DateTime(finalVisibleDate.Year, finalVisibleDate.Month, finalVisibleDate.Day, 23, 59, 56, 999);

            return this.model.CalendarEvents.FindAll(e =>
            {
                return e.StartTime >= firstVisibleDate && e.StartTime < finalVisibleDate;
            });
           
        }

        public CalendarEvent GetRecentlyCreatedEvent { get; private set; }

        public bool CreateEvent(string eventName, DateTime startTime, DateTime endTime, string eventType, string eventPriority, string repettition) {
            var ev = new CalendarEvent();
            ev.EventName = eventName;
            ev.StartTime = startTime;
            ev.EndTime = endTime;
            ev.EventType = eventType;
            ev.Priority = eventPriority;
            ev.Repeat = repettition;

            //TODO: Add input filtering
            var valid = true;
            if (valid)
            {
                this.model.AddEvent(ev);
                this.GetRecentlyCreatedEvent = ev;

                return true;
            }
             return false;
             
           
        }


    }
}
