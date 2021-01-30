using System;

namespace AbstractFabric
{
    class Program
    {
        static void Main(string[] args)
        {
            Application app = configureApplication();
            app.Repaint();
            app.ToggleExpand();
        }

        private static Application configureApplication()
        {
            Console.WriteLine("Введите название системы");
            string osName = Console.ReadLine();
            Application app;
            FactoryUI factory;
            if (osName.Equals("Windows"))
            {
                factory = new WindowsFactory();
            }
            else
            {

                factory = new LinuxFactory();
            }
            app = new Application(factory);
            return app;
        }
    }
}
