using GameGenerator.Library.Interfaces;
using GameGenerator.Library.Models.Rainforest;

namespace GameGenerator.Library.Generators
{
    public class DesertGenerator : IAbstractGenerator
    {
        public IAnimal CreateAnimal()
        {
            return new Camel();
        }

        public IPlant CreatePlant()
        {
            return new Cactus();
        }

        public IUnderground CreateUnderground()
        {
            return new Sand();
        }
    }
}
