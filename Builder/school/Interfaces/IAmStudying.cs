using Builder.school.Dtos;

namespace Builder.school.Interfaces
{
    public interface IAmStudying
    {
        IHasStudyingSchedule Studying(params Subject[] subjects);
    }
}
