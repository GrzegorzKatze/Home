using CSharpPatterns.Builders;
using CSharpPatterns.Director;
using CSharpPatterns.Interfaces;
using CSharpPatterns.Objects;

namespace CSharpPatterns_Builder
{
    public class Program
    {
        static void Main(string[] args)
        {
            var director = new Director();
            IBuilder xBuilder = new BuilderX();
            IBuilder yBuilder = new BuilderY();

            director.BuildObject(xBuilder);
            director.BuildObject(yBuilder);

            ObjectToBuild objX = xBuilder.GetObject();
            ObjectToBuild objY = yBuilder.GetObject();
        }
    }
}
