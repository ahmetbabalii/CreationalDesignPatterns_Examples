using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.school.Dtos.Descriptors
{
    public class StudentDescriptor : MemberDescriptor
    {
        public StudentDescriptor(MemberDescriptor member = null) : base(member)
        {
            if (member is StudentDescriptor student)
            {
                Subjects = student.Subjects != null
                    ? student.Subjects.Clone().ToList()
                    : new List<Subject>();

                SubjectsSchedules =
                    student.SubjectsSchedules != null
                        ? student.SubjectsSchedules.Clone().ToList()
                        : new List<SubjectSchedule>();
            }
        }

        public List<Subject> Subjects { get; set; } = new List<Subject>();
        public List<SubjectSchedule> SubjectsSchedules { get; set; } = new List<SubjectSchedule>();

        public override MemberDescriptor Clone()
        {
            return new StudentDescriptor(this);
        }
    }
}
