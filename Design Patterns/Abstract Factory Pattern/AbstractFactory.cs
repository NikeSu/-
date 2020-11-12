using Design_Patterns.FactoryPattern;
using System;

namespace Design_Patterns.Abstract_Factory_Pattern
{
    public abstract class AbstractFactory
    {
        public abstract IColor getColor(String color);
        public abstract IShape getShape(String shape);
    }
}
