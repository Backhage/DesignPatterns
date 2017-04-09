using System;

namespace DesignPatterns.Creational.Builder
{
    public class ConcreteBuilder : IBuilder
    {
        private string _attributeA;
        private int _attributeB;
        private bool _attributeC;

        public Part BuildPart()
        {
            return new Part(_attributeA, _attributeB, _attributeC);
        }

        public void SetAttributeA(string value)
        {
            _attributeA = value;
        }

        public void SetAttributeB(int value)
        {
           _attributeB = value;
        }

        public void SetAttributeC(bool value)
        {
            _attributeC = value;
        }
    }
}
