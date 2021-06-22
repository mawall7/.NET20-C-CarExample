using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Demo
    {
        private IUI ui;
        public Demo(IUI ui)
        {
            this.ui = ui;
        }
       
        public void Do()
        {
            ui.Print("Hej");
        }
    }
}
