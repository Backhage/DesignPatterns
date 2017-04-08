namespace DesignPatterns.Creational.Prototype
{
    class ConcretePrototype1 : Prototype
    {
        public ConcretePrototype1(string identifier) : base(identifier)
        {
        }

        public override Prototype Clone()
        {
            return (Prototype)MemberwiseClone();
        }
    }
}
