namespace AbstractFactory.solution1
{
    public class CheckBoxFactory : GUIFactory
    {
        public Component create()
        {
            return new CheckBox();
        }
    }
}
