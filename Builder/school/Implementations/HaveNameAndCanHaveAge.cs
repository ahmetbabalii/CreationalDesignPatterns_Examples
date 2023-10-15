using Builder.school.Dtos.Descriptors;
using Builder.school.Interfaces;

namespace Builder.school.Implementations
{
    internal class HaveNameAndCanHaveAge : IHaveNameAndCanHaveAge
    {
        private readonly MemberDescriptor m_Descriptor;

        public HaveNameAndCanHaveAge(MemberDescriptor descriptor)
        {
            m_Descriptor = descriptor;
        }

        public IHasRole WithAge(int age)
        {
            var clone = new MemberDescriptor(m_Descriptor) { Age = age };
            return new HasRole(clone);
        }
    }
}