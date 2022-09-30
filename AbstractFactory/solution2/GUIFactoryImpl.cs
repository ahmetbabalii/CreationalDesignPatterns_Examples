namespace AbstractFactory.solution2
{
    public class GUIFactoryImpl : GUIFactory
    {
        public Component createButton()
        {
            return new Button();
        }

        public Component createCheckbox()
        {
            return new CheckBox();
        }
    }
}
