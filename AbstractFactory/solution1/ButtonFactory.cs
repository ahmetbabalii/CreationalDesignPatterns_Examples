namespace AbstractFactory.solution1
{
    public class ButtonFactory : GUIFactory
    {
        public Component create()
        {
            return new Button();
        }
    }

}
