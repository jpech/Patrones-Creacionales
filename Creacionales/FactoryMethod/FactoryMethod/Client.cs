using System;

namespace FactoryMethod
{
    public class Client
    {
        public void Main()
        {
            Console.WriteLine("App: Launched with the WindowsDialog.");
            ClientCode(new WindowsDialog());

            Console.WriteLine("");

            Console.WriteLine("App: Launched with the WebDialog.");
            ClientCode(new WebDialog());
        }

        public void ClientCode(Dialog dialog)
        {
            // ...
            Console.WriteLine("Client: I'm not aware of the creator's class," +
                "but it still works.\n" + dialog.onClick());
            // ...
        }
    }
}
