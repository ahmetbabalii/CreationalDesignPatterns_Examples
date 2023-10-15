using Builder.school.Dtos.Descriptors;
using Builder.school.Interfaces;

namespace Builder.school.Implementations
{
    internal class CanBeBuilt : ICanBeBuilt
    {
        private readonly MemberDescriptor m_Descriptor;

        public CanBeBuilt(MemberDescriptor descriptor)
        {
            m_Descriptor = descriptor;
        }

        public MemberDescriptor Build()
        {
            return m_Descriptor.Clone();
        }
    }
}
