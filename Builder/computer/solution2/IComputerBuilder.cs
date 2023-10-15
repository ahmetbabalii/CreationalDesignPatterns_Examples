using Builder.computer.domain;

namespace Builder.computer.solution2;

public interface IComputerBuilder
{
    public IComputerBuilder buildRam();
    public IComputerBuilder buildCpu();
    public IComputerBuilder buildGpu();
    public IComputerBuilder buildSsd();
    public IComputerBuilder buildMouse();
    public IComputerBuilder buildKeyboard();
    public Computer build();
}
