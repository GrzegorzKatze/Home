using CSharpPatterns.Interfaces;
using CSharpPatterns.Objects;

namespace CSharpPatterns.Builders
{
    public class BuilderX : IBuilder
    {
        private ObjectToBuild obj = new ObjectToBuild();

        public ObjectToBuild GetObject()
        {
            return obj;
        }

        public void SetPropertyA()
        {
            obj.MyObjPropertyA = "X.A";
        }

        public void SetPropertyB()
        {
            obj.MyObjPropertyB = "X.B";
        }
    }
}
