using Builder.school.Dtos.Descriptors;
using Builder.school.Dtos;
using Builder.school.Interfaces;

namespace Builder.school.Implementations
{
    internal class HasTeachingSchedule : IHasTeachingSchedule
    {
        private readonly TeacherDescriptor m_Descriptor;

        public HasTeachingSchedule(TeacherDescriptor descriptor)
        {
            m_Descriptor = descriptor;
        }

        public ICanBeBuilt WithSchedule(params Schedule[] schedules)
        {
            var clone = new TeacherDescriptor(m_Descriptor)
            {
                Schedules = schedules.AsEnumerable().Clone().ToList()
            };

            return new CanBeBuilt(clone);
        }
    }
}
