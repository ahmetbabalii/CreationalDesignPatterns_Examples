using Builder.school.Dtos.Descriptors;
using Builder.school.Dtos;
using Builder.school.Interfaces;

namespace Builder.school.Implementations
{
    internal class AmTeaching : IAmTeaching
    {
        private readonly TeacherDescriptor m_Descriptor;

        public AmTeaching(TeacherDescriptor descriptor)
        {
            m_Descriptor = descriptor;
        }

        public IHasTeachingSchedule Teaching(Subject subject)
        {
            var clone = new TeacherDescriptor(m_Descriptor) { Subject = new Subject(subject) };
            return new HasTeachingSchedule(clone);
        }
    }
}
