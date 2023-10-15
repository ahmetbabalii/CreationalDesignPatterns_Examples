using Builder.school.Dtos;

namespace Builder.school.Interfaces
{
    public interface IAmTeaching
    {
        IHasTeachingSchedule Teaching(Subject subject);
    }
}
