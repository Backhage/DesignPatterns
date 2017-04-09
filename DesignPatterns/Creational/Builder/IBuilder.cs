namespace DesignPatterns.Creational.Builder
{
    public interface IBuilder
    {
        void SetAttributeA(string value);
        void SetAttributeB(int value);
        void SetAttributeC(bool value);

        Part BuildPart();
    }
}
