using Shared;

namespace BlazorWebAppDemo.Services;

public class AnimalService : IAnimalService
{
    public List<Animal> Animals { get; set; } = new();
    public List<Animal> GetAnimalList()
    {
        return Animals;
    }

    public void AddAnimal(Animal animal)
    {
        Animals.Add(animal);
    }
}