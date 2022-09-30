


namespace AbstractFactory.solution1
{
    public class Service
    {
        public Service(GUIFactory factory)
        {
            Component component = factory.create();
            component.paint();
        }
    }
}
