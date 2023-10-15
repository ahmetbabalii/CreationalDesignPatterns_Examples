using Builder.computer.domain;

namespace Builder.computer.solution2;

internal class Test
{
    public static void MainTest()
    {
        var computerBuilder = ComputerBuilder.getBuilder().buildRam(); 

        Computer computer = computerBuilder.buildCpu().buildRam().buildGpu().buildSsd().buildMouse().buildKeyboard().build();
        computer.start();
              
    }
}
