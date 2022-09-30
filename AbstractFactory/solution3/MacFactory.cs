
namespace AbstractFactory.solution3
{
    public class MacFactory : GUIFactory
    {
        public Component createButton() => new MacButton();
        public Component createCheckbox() => new MacCheckBox();        
    }
}
