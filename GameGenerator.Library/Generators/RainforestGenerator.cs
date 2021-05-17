using GameGenerator.Library.Interfaces;
using GameGenerator.Library.Models.Rainforest;

namespace GameGenerator.Library.Generators
{
    public class RainforestGenerator : IAbstractGenerator
    {
        public IAnimal CreateAnimal()
        {
            return new Elephant();
        }

        public IPlant CreatePlant()
        {
            return new Tree();
        }

        public IUnderground CreateUnderground()
        {
            return new Gras();
        }
    }
}
