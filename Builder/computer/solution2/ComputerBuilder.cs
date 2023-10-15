using Builder.computer.domain;

namespace Builder.computer.solution2;

public class ComputerBuilder : IComputerBuilder
{
    private static ComputerBuilder builder = new();    

    private Ram? ram;
    private Cpu? cpu;
    private Gpu? gpu;
    private Ssd? ssd;
    private Mouse? mouse;
    private Keyboard? keyboard;

    public IComputerBuilder buildRam() { this.ram = new Ram(); return this; }
    public IComputerBuilder buildCpu() { this.cpu = new Cpu(); return this; }
    public IComputerBuilder buildGpu() { this.gpu = new Gpu(); return this; }
    public IComputerBuilder buildSsd() { this.ssd = new Ssd(); return this; }
    public IComputerBuilder buildMouse() { this.mouse = new Mouse(); return this; }
    public IComputerBuilder buildKeyboard() { this.keyboard = new Keyboard(); return this; }

    public static ComputerBuilder getBuilder()
    {
        return builder;
    }

    public Computer build()
    {
        Computer computer = new Computer(this.cpu, this.gpu, this.ram, this.ssd, this.mouse, this.keyboard);
        return computer;
    }
}
