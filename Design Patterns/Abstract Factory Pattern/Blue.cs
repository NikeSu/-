using System;

namespace Design_Patterns.Abstract_Factory_Pattern
{
    public class Blue : IColor
    {
        public void Fill()
        {
            Console.WriteLine("Blue Fill");
        }
    }
}
