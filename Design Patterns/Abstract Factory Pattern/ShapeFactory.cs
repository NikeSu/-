using Design_Patterns.FactoryPattern;

namespace Design_Patterns.Abstract_Factory_Pattern
{
    public class ShapeFactory : AbstractFactory
    {
        public override IColor getColor(string color)
        {
            return null;
        }

        public override IShape getShape(string shape)
        {
            if (string.IsNullOrEmpty(shape))
            {
                return null;
            }
            if (shape.ToUpper().Equals("CIRCLE"))
            {
                return new Circle();
            }
            else if (shape.ToUpper().Equals("RECTANGLE"))
            {
                return new Rectangle();
            }
            else if (shape.ToUpper().Equals("SQUARE"))
            {
                return new Square();
            }
            return null;
        }
    }
}
