using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Abstract_Factory_Pattern
{
    public class FactoryProducer
    {
        public static AbstractFactory getFactory(String choice)
        {
            if (choice.ToUpper().Equals("SHAPE"))
            {
                return new ShapeFactory();
            }
            else if (choice.ToUpper().Equals("COLOR"))
            {
                return new ColorFactory();
            }
            return null;
        }
    }
}
