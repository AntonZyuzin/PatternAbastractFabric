using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFabric
{
    class LinuxFactory : FactoryUI
    {
        public WindowInterface Open()
        {
            return new LinuxWindow();
        }
    }
}
