using CSharpPatterns.Interfaces;

namespace CSharpPatterns.Director
{
   public class Director
    {
        public void BuildObject(IBuilder builder)
        {
            builder.SetPropertyA();
            builder.SetPropertyB();
        }
    }
}
