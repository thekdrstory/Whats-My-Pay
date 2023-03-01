using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Timer
{
    public class PayLog
    {
        public DateTime inTime { get; set; }
        public DateTime outTime { get; set;}
        public TimeSpan duration { get; set; }
        
        public PayLog(DateTime aInTime, DateTime aOutTime, TimeSpan aDuration)
        {
            inTime = aInTime;
            outTime = aOutTime;
            duration = aDuration;
        }

    }
}
