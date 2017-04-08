namespace DesignPatterns.Behavioral.Abstract_Factory
{
    class ConcreteFactory1 : IAbstractFactory
    {
        public IAbstractProductA CreateProductA()
        {
            return new ProductA1();
        }

        public IAbstractProductB CreateProductB()
        {
            return new ProductB1();
        }
    }
}
