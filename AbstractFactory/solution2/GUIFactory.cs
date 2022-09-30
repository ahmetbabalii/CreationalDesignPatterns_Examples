namespace AbstractFactory.solution2
{
    public interface GUIFactory
    {
        public Component createButton();
        public Component createCheckbox();
    }
}