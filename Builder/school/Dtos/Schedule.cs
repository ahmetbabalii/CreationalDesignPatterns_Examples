using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.school.Dtos
{
    public class Schedule
    {
        public Schedule(DateTime from, DateTime to)
        {
            From = from;
            To = to;
        }

        public Schedule(Schedule other)
        {
            if (other != null)
            {
                From = other.From;
                To = other.To;
            }
        }

        public DateTime From { get; }
        public DateTime To { get; }
    }

    public static class ScheduleExtensions
    {
        public static IEnumerable<Schedule> Clone(this IEnumerable<Schedule> schedules)
        {
            return schedules != null
                ? schedules
                  .Where(s => s != null)
                  .Select(s => new Schedule(s))
                : new List<Schedule>();
        }
    }
}
