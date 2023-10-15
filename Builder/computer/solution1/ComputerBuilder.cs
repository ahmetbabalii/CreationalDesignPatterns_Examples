using Builder.computer.domain;

namespace Builder.computer.solution1;

public class ComputerBuilder
{
    private Computer computer;

    private void buildRAM()
    {
        Ram ram = new Ram();
        computer.setRam(ram);
    }

    private void buildCPU()
    {
        Cpu cpu = new Cpu();
        computer.setCpu(cpu);
    }
    private void buildGpu()
    {
        Gpu gpu = new Gpu();
        computer.setGpu(gpu);
    }

    private void buildSsd()
    {

        Ssd ssd = new Ssd();
        computer.setSsd(ssd);
    }

    private void buildMouse()
    {
        Mouse mouse = new Mouse();
        computer.setMouse(mouse);
    }

    private void buildKeyboard()
    {
        Keyboard keyboard = new Keyboard();
        computer.setKeyboard(keyboard);
    }

    public Computer build()
    {
        var computer1= new Computer();
        buildCPU();
        buildGpu();
        buildRAM();
        buildSsd();
        buildMouse();
        buildKeyboard();
        return computer1;
    }    
}
