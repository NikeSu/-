using System;

namespace Design_Patterns.Abstract_Factory_Pattern
{
    public class Red : IColor
    {
        public void Fill()
        {
            Console.WriteLine("Red Fill");
        }
    }
}
