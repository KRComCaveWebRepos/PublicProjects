namespace GameGenerator.Library.Interfaces
{
    public interface IAbstractGenerator
    {
        IAnimal CreateAnimal();
        IPlant CreatePlant();
        IUnderground CreateUnderground();
    }
}
