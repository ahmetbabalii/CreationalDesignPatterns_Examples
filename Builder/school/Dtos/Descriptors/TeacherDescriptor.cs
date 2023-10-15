using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.school.Dtos.Descriptors
{
    public class TeacherDescriptor : MemberDescriptor
    {
        public TeacherDescriptor(MemberDescriptor member = null) : base(member)
        {
            if (member is TeacherDescriptor teacher)
            {
                Subject = teacher.Subject != null ? new Subject(teacher.Subject) : null;

                Schedules = teacher.Schedules != null
                    ? teacher.Schedules.Clone().ToList()
                    : new List<Schedule>();
            }
        }

        public Subject Subject { get; set; }
        public List<Schedule> Schedules { get; set; } = new List<Schedule>();

        public override MemberDescriptor Clone()
        {
            return new TeacherDescriptor(this);
        }
    }
}
