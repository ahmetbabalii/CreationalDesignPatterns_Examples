


namespace AbstractFactory.solution2
{
    public class Service
    {
        public Service(GUIFactory factory)
        {
            Component btnComponent = factory.createButton();
            btnComponent.paint();

            Component chcComponent = factory.createCheckbox();
            chcComponent.paint();
        }
    }
}
