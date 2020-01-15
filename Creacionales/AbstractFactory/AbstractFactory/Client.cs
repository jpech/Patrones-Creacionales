using System;

namespace AbstractFactory
{
    public class Client
    {
        public void Main()
        {
            // The client code can work with any concrete factory class.
            Console.WriteLine("Client: Testing client code with the WinFactory...");
            ClientMethod(new WinFactory());
            Console.WriteLine();

            Console.WriteLine("Client: Testing the same client code with the MacFactory...");
            ClientMethod(new MacFactory());
        }


        public void ClientMethod(IGUIFactory factory)
        {
            var productA = factory.CreateButton();
            var productB = factory.CreateCheckBox();
            var productC = factory.CreateRadioButton();

            Console.WriteLine(productA.UsefulFunctioButton());
            Console.WriteLine(productB.UsefulFunctionCheckBox());
            Console.WriteLine(productC.UsefulFunctionRadioButton());
        }
    }
}
