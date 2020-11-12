using System;

namespace Design_Patterns.Abstract_Factory_Pattern
{
    public class Green : IColor
    {
        public void Fill()
        {
            Console.WriteLine("Green Fill");
        }
    }
}
