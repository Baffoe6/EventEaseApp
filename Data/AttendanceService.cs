using System.Collections.Generic;

namespace EventEaseApp.Data
{
    public class AttendanceService
    {
        private readonly Dictionary<string, List<string>> eventAttendance = new Dictionary<string, List<string>>();

        public void RegisterAttendance(string eventName, string userName)
        {
            if (!eventAttendance.ContainsKey(eventName))
            {
                eventAttendance[eventName] = new List<string>();
            }
            eventAttendance[eventName].Add(userName);
        }

        public List<string> GetAttendance(string eventName)
        {
            return eventAttendance.ContainsKey(eventName) ? eventAttendance[eventName] : new List<string>();
        }
    }
}