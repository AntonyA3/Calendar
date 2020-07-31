using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarApp
{
    public enum Priority {
        Low,
        Medium,
        High

    }


    public enum EventType { 
        Birthday
    }

    public enum Repeat { 
        Daily,
        Weekly,
        Monthly,
        Yearly,
    }
}
