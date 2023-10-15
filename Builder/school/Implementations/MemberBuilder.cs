using Builder.school.Dtos.Descriptors;
using Builder.school.Interfaces;

namespace Builder.school.Implementations
{
    public class MemberBuilder : IMemberBuilder
    {
        public IHuman New => new Human(new MemberDescriptor());
    }
}
