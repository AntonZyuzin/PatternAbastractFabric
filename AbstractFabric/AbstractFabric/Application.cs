using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFabric
{
    class Application
    {
        private WindowInterface window;

        public Application(FactoryUI factory)
        {
            window = factory.Open();
        }

        public void Repaint()
        {
            window.Repaint();
        }
        public void ToggleExpand()
        {
            window.ToggleExpand();
        }
    }
}
