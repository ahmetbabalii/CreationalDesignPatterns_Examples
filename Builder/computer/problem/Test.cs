using Builder.computer.domain;

namespace Builder.computer.problem;

public class Test
{
    public static void MainTest()
    {
        Cpu cpu = new();
        Ram ram = new();
        Ssd ssd = new();
        Gpu gpu = new();

        Computer computer1 = new(cpu, gpu, ram, ssd);
        computer1.start();

        Mouse mouse = new();
        Computer computer2 = new(cpu, gpu, ram, ssd, mouse);
        computer2.start();

        Keyboard keyboard = new();
        Computer computer3 = new(cpu, gpu, ram, ssd, mouse, keyboard);
        computer3.start();
    }
}