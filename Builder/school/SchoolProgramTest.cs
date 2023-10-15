using Builder.school.Dtos;
using Builder.school.Implementations;

namespace Builder.school
{
    public static class SchoolProgramTest
    {
        public static void MainTest()
        {
            var memberBuilder = new MemberBuilder();

            var ahmet =
                        memberBuilder
                            .New                            
                            .WithName("Ahmet")
                            .WithAge(36)
                            .AsTeacher
                            .Teaching(new Subject("Software Engineering"))
                            .WithSchedule(
                                new Schedule
                                (
                                    new DateTime(2021, 11, 20),
                                    new DateTime(2021, 12, 20)
                                ), new Schedule
                                (
                                    new DateTime(2022, 1, 5),
                                    new DateTime(2021, 3, 5)
                                ))
                            .Build();

            var subjectsToStudy = new Subject[]
                      {
                new Subject("Software Engineering"),
                new Subject("Physics")
                      };

            var babali =
                    memberBuilder
                        .New
                        .WithAge(15)
                        .WithName("Babali")
                        .AsStudent
                        .Studying(subjectsToStudy)
                        .WithSchedule
                        (
                            new SubjectSchedule
                            (
                                subjectsToStudy[0],
                                new Schedule
                                (
                                    new DateTime(2021, 11, 20),
                                    new DateTime(2021, 12, 20)
                                )
                            ),
                            new SubjectSchedule
                            (
                                subjectsToStudy[1],
                                new Schedule
                                (
                                    new DateTime(2021, 11, 20),
                                    new DateTime(2021, 12, 20)
                                )
                            )
                        )
                        .Build();

            Console.ReadLine();
        }
    }
}
