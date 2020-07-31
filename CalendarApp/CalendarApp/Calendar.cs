using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CalendarApp
{
    public class Calendar : INotifyPropertyChanged
    {

        public Calendar() {
            this.calendarEvents = new List<CalendarEvent>();
        }
        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        private List<CalendarEvent> calendarEvents;
        public List<CalendarEvent> CalendarEvents {
            get {
                return this.calendarEvents;
            }
            set {
                if (value != calendarEvents) {
                    this.calendarEvents = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public void AddEvent(CalendarEvent calendarEvent) {
            this.CalendarEvents.Add(calendarEvent);
            NotifyPropertyChanged(nameof(CalendarEvents));

        }
    }
}
