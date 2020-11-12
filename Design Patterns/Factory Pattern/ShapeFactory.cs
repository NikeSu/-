using System;

namespace Design_Patterns.FactoryPattern
{
    public class ShapeFactory
    {
        public IShape getShape(String shapeType)
        {
            if (shapeType == null)
            {
                return null;
            }
            if (shapeType.ToUpper().Equals("CIRCLE"))
            {
                return new Circle();
            }
            else if (shapeType.ToUpper().Equals("RECTANGLE"))
            {
                return new Rectangle();
            }
            else if (shapeType.ToUpper().Equals("SQUARE"))
            {
                return new Square();
            }
            return null;
        }
    }
}
