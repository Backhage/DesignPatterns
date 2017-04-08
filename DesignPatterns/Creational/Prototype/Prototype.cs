namespace DesignPatterns.Creational.Prototype
{
    public abstract class Prototype
    {
        public string Id { get; }

        protected Prototype(string identifier)
        {
            Id = identifier;
        }

        public abstract Prototype Clone();
    }
}
