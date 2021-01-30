using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFabric
{
    class WindowsWindow : WindowInterface
    {
        public void Repaint()
        {
            Console.WriteLine("Окно перерисовано");
        }

        public void ToggleExpand()
        {
            Console.WriteLine("Окно свернуто/развернуто");
        }
    }
}
