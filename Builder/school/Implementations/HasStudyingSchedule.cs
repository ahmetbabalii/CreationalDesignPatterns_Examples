using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Builder.school.Dtos.Descriptors;
using Builder.school.Dtos;
using Builder.school.Interfaces;

namespace Builder.school.Implementations
{
    internal class HasStudyingSchedule : IHasStudyingSchedule
    {
        private readonly StudentDescriptor m_Descriptor;

        public HasStudyingSchedule(StudentDescriptor descriptor)
        {
            m_Descriptor = descriptor;
        }

        public ICanBeBuilt WithSchedule(params SubjectSchedule[] subjectsSchedules)
        {
            if (m_Descriptor.Subjects.Any(s => !subjectsSchedules.Select(ss => ss.Subject).Contains(s)))
            {
                throw new ArgumentException("Some of the registered subjects are not scheduled.");
            }

            if (subjectsSchedules.Select(ss => ss.Subject).Any(s => !m_Descriptor.Subjects.Contains(s)))
            {
                throw new ArgumentException("Some of the scheduled subjects are not registered.");
            }

            var clone = new StudentDescriptor(m_Descriptor)
            {
                SubjectsSchedules = subjectsSchedules.AsEnumerable().Clone().ToList()
            };

            return new CanBeBuilt(clone);
        }
    }
}
