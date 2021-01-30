using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFabric
{
    class WindowsFactory : FactoryUI
    {
        public WindowInterface Open()
        {
            return new WindowsWindow();
        }
    }
}
