namespace DesignPatterns.Creational.Abstract_Factory
{
    interface IAbstractFactory
    {
        IAbstractProductA CreateProductA();
        IAbstractProductB CreateProductB();
    }
}
