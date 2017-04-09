namespace DesignPatterns.Creational.Builder
{
    public class Part
    {
        public string AttributeA { get; }
        public int AttributeB { get; }
        public bool AttributeC { get; }

        public Part(string attributeA, int attributeB, bool attributeC)
        {
            AttributeA = attributeA;
            AttributeB = attributeB;
            AttributeC = attributeC;
        }
    }
}
