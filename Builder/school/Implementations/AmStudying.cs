
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
    internal class AmStudying : IAmStudying
    {
        private readonly StudentDescriptor m_Descriptor;

        public AmStudying(StudentDescriptor descriptor)
        {
            m_Descriptor = descriptor;
        }

        public IHasStudyingSchedule Studying(params Subject[] subjects)
        {
            var clone = new StudentDescriptor(m_Descriptor) { Subjects = subjects.AsEnumerable().Clone().ToList() };
            return new HasStudyingSchedule(clone);
        }
    }
}
