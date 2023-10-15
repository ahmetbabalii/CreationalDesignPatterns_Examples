using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.school.Dtos
{
    public class SubjectSchedule
    {
        public SubjectSchedule(Subject subject, Schedule schedule)
        {
            Subject = subject;
            Schedule = schedule;
        }

        public SubjectSchedule(SubjectSchedule other)
        {
            if (other != null)
            {
                Subject = new Subject(other.Subject);
                Schedule = new Schedule(other.Schedule);
            }
        }

        public Subject Subject { get; }
        public Schedule Schedule { get; }
    }

    public static class SubjectScheduleExtensions
    {
        public static IEnumerable<SubjectSchedule> Clone(this IEnumerable<SubjectSchedule> subjectsSchedules)
        {
            return subjectsSchedules != null
                ? subjectsSchedules
                  .Where(s => s != null)
                  .Select(s => new SubjectSchedule(s))
                : new List<SubjectSchedule>();
        }
    }
}
