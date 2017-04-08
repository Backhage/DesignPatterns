namespace DesignPatterns.Creational.Prototype
{
    class ConcretePrototype2 : Prototype
    {
        public ConcretePrototype2(string identifier) : base(identifier)
        {
        }

        public override Prototype Clone()
        {
            return (Prototype)MemberwiseClone();
        }
    }
}
