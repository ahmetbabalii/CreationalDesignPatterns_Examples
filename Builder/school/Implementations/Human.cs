using Builder.school.Dtos.Descriptors;
using Builder.school.Interfaces;

namespace Builder.school.Implementations
{
    internal class Human : IHuman
    {
        private readonly MemberDescriptor m_Descriptor;

        public Human(MemberDescriptor descriptor)
        {
            m_Descriptor = descriptor;
        }

        public IHaveNameAndCanHaveAge WithName(string name)
        {
            var clone = new MemberDescriptor(m_Descriptor) { Name = name };
            return new HaveNameAndCanHaveAge(clone);
        }

        public IHaveAgeAndCanHaveName WithAge(int age)
        {
            var clone = new MemberDescriptor(m_Descriptor) { Age = age };
            return new HaveAgeAndCanHaveName(clone);
        }
    }
}
