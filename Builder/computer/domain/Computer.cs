namespace Builder.computer.domain;

public class Computer
{
    private Cpu Cpu { get; set; }
    private Gpu Gpu { get; set; }
    private Ram Ram { get; set; }
    private Ssd Ssd { get; set; }
    private Mouse Mouse { get; set; }
    private Keyboard Keyboard { get; set; }

    public Computer() { }

    public Computer(Cpu cpu, Gpu gpu, Ram ram, Ssd ssd)
    {
        this.Cpu = cpu;
        this.Gpu = gpu;
        this.Ram = ram;
        this.Ssd = ssd;            
    }

    public Computer(Cpu cpu, Gpu gpu, Ram ram, Ssd ssd, Mouse mouse)
    {
        this.Cpu = cpu;
        this.Gpu = gpu;
        this.Ram = ram;
        this.Ssd = ssd;
        this.Ssd = ssd;
        this.Mouse = mouse;
    }

    public Computer(Cpu cpu, Gpu gpu, Ram ram, Ssd ssd, Mouse mouse, Keyboard keyboard)
    {
        this.Cpu = cpu;
        this.Gpu = gpu;
        this.Ram = ram;
        this.Ssd = ssd;
        this.Ssd = ssd;
        this.Mouse = mouse;
        this.Keyboard = keyboard;
    }

    public void start()
    {
        Cpu.start();
        Ram.start();
        Ssd.start();            
        Gpu.start();
        
        Mouse?.start();        
        Keyboard?.start();
    
        Console.WriteLine("Computer has started.\n");
    }

    public void setCpu(Cpu cpu)
    {
        this.Cpu = cpu;
    }

    public void setRam(Ram ram)
    {
        this.Ram = ram;
    }
    
    public void setSsd(Ssd ssd)
    {
        this.Ssd = ssd;
    }

    public void setGpu(Gpu gpu)
    {
        this.Gpu = gpu;
    }

    public void setMouse(Mouse mouse)
    {
        this.Mouse = mouse;
    }

    public void setKeyboard(Keyboard keyboard)
    {
        this.Keyboard = keyboard;
    }
}
