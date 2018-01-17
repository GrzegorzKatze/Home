using CSharpPatterns.Objects;

namespace CSharpPatterns.Interfaces
{
    public interface IBuilder
    {
        void SetPropertyA();
        void SetPropertyB();

        ObjectToBuild GetObject();
    }
}
