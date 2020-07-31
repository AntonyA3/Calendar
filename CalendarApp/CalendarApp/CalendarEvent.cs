using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CalendarApp
{
    [Serializable]
    public class CalendarEvent
    {
        private int start_year;
        private int start_month;
        private int start_day;
        private int start_hour;
        private int start_minute;
        private int start_second;
        public DateTime StartTime { 
            get {
                return new DateTime(start_year, start_month, start_day, start_hour, start_minute, start_second);
            }
            set {
                start_year = value.Year;
                start_month = value.Month;
                start_day = value.Day;
                start_hour = value.Hour;
                start_minute = value.Minute;
                start_second = value.Second;
            }
        }
        private int end_year;
        private int end_month;
        private int end_day;
        private int end_hour;
        private int end_minute;
        private int end_second;

        public DateTime EndTime {
            get {
                return new DateTime(end_year, end_month, end_day, end_hour, end_minute, end_second);
            }
            set {
                end_year = value.Year;
                end_month = value.Month;
                end_day = value.Day;
                end_hour = value.Hour;
                end_minute = value.Minute;
                end_second = value.Second;
            }
        }

        private string event_name;
        public string EventName { get; set; }

        private string priority;
        public string Priority {
            get {
                return this.priority;
            }
            set {
                this.priority = value;
            }
        }

        private string event_type;
        public string EventType {
            get {
                return this.event_type;
            }
            set {
                this.event_type = value;
            }
        }

        private string repeat;
        public string Repeat {
            get {
                return this.repeat;
            }
            set {
                this.repeat = value;
            }
        }

     
    }
}
