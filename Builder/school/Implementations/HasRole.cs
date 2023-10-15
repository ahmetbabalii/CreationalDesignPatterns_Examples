using Builder.school.Dtos.Descriptors;
using Builder.school.Dtos;
using Builder.school.Interfaces;

namespace Builder.school.Implementations
{
    internal class HasRole : IHasRole
    {
        private readonly MemberDescriptor m_Descriptor;

        public HasRole(MemberDescriptor descriptor)
        {
            m_Descriptor = descriptor;
        }
        public IAmTeaching AsTeacher =>
            new AmTeaching(new TeacherDescriptor(m_Descriptor) { Role = MemberRole.Teacher });
        public IAmStudying AsStudent =>
            new AmStudying(new StudentDescriptor(m_Descriptor) { Role = MemberRole.Student });
    }
}