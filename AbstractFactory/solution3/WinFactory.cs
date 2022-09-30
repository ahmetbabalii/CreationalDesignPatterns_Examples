namespace AbstractFactory.solution3
{
    internal class WinFactory : GUIFactory
    {
        public Component createButton() => new WinButton();
        public Component createCheckbox() => new WinCheckbox();     
    }    
}
