using Design_Patterns.FactoryPattern;
using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.Abstract_Factory_Pattern
{
    public class ColorFactory : AbstractFactory
    {
        public override IColor getColor(string color)
        {
            if (string.IsNullOrEmpty(color))
            {
                return null;
            }
            if (color.ToUpper().Equals("RED"))
            {
                return new Red();
            }
            else if (color.ToUpper().Equals("GREEN"))
            {
                return new Green();
            }
            else if (color.ToUpper().Equals("BLUE"))
            {
                return new Blue();
            }
            return null;
        }

        public override IShape getShape(string shape)
        {
            return null;
        }
    }
}
