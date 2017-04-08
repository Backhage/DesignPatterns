namespace DesignPatterns.Behavioral.Abstract_Factory
{
    interface IAbstractFactory
    {
        IAbstractProductA CreateProductA();
        IAbstractProductB CreateProductB();
    }
}
