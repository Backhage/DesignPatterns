namespace DesignPatterns.Behavioral.Abstract_Factory
{
    class Client
    {
        public enum Version
        {
            One,
            Two
        }

        public Version VersionToCreate { get; set; }

        public IAbstractProductA CreateProductA()
        {
            return GetFactory().CreateProductA();
        }

        public IAbstractProductB CreateProductB()
        {
            return GetFactory().CreateProductB();
        }

        private IAbstractFactory GetFactory()
        {
            switch (VersionToCreate)
            {
                case Version.One:
                    return new ConcreteFactory1();
                case Version.Two:
                    return new ConcreteFactory2();
                default:
                    throw new System.NotImplementedException();
            }
        }
    }
}
