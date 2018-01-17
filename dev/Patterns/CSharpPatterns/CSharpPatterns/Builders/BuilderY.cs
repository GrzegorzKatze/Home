using CSharpPatterns.Interfaces;
using CSharpPatterns.Objects;

namespace CSharpPatterns.Builders
{
    public class BuilderY : IBuilder
    {
        private ObjectToBuild obj = new ObjectToBuild();

        public ObjectToBuild GetObject()
        {
            return obj;
        }

        public void SetPropertyA()
        {
            obj.MyObjPropertyA = "Y.A";
        }

        public void SetPropertyB()
        {
            obj.MyObjPropertyB = "Y.B";
        }
    }
}
