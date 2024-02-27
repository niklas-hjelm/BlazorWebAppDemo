namespace Shared;

public interface IAnimalService
{
    List<Animal> GetAnimalList();
    void AddAnimal(Animal animal);
}