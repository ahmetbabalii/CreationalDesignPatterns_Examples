using Builder.school.Dtos.Descriptors;

namespace Builder.school.Interfaces
{
    public interface ICanBeBuilt
    {
        MemberDescriptor Build();
    }
}
