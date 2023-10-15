using Builder.computer.domain;

namespace Builder.computer.solution1;

public class Test
{
    public static void MainTest()
    {
        ComputerBuilder computerBuilder = new ComputerBuilder();
        Computer computer = computerBuilder.build();
        computer.start();
    }
}
