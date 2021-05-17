using GameGenerator.Library.Interfaces;
using GameGenerator.Library.Models.Rainforest;

namespace GameGenerator.Library.Generators
{
    public class PolarGenerator : IAbstractGenerator
    {
        public IAnimal CreateAnimal()
        {
            return new Icebear();
        }

        public IPlant CreatePlant()
        {
            return new Lichen();
        }

        public IUnderground CreateUnderground()
        {
            return new Snow();
        }
    }
}
