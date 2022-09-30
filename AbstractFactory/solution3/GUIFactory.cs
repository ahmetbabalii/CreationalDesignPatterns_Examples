namespace AbstractFactory.solution3
{
    public interface GUIFactory
    {
        public Component createButton();
        public Component createCheckbox();
    }
}