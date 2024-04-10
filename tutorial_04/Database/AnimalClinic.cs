namespace tutorial_04.Database;
using Models;

public class AnimalClinic
{
    public List<Animal> AnimalList { get; } = new List<Animal>();
    private List<Visit> Visits { get; } = new List<Visit>();

    public AnimalClinic()
    {
        AnimalList.Add(new Animal(){Id = 1, Name = "Bolt", Category = "Dog", FurColor = "White", Weight = 5.5});
        AnimalList.Add(new Animal(){Id = 2, Name = "Sparky", Category = "Cat", FurColor = "Orange", Weight = 3.5});
        AnimalList.Add(new Animal(){Id = 3, Name = "Messi", Category = "Goat", FurColor = "Black", Weight = 7});
        AnimalList.Add(new Animal(){Id = 4, Name = "Jack", Category = "Parrot", FurColor = "Red", Weight = 2});
        AnimalList.Add(new Animal(){Id = 5, Name = "Marty", Category = "Zebra", FurColor = "White&Black", Weight = 5.5});
    }

    public void add(Animal animal)
    {
        AnimalList.Add(animal);
    }

    public Animal getById(int id)
    {
        Animal res = new Animal() { Id = id };
        foreach (var animal in AnimalList)
        {
            if (animal.Id.Equals(id))
            {
                res = animal;
            }
        }

        return res;
    }

    public void editAnimal(int id, string name, string category, string furColor, double weight)
    {
        var animal = getById(id);
        animal.Name = name;
        animal.Category = category;
        animal.Weight = weight;
        animal.FurColor = furColor;
    }

    public void delete(int id)
    {
        AnimalList.Remove(getById(id));
    }

    public List<Visit> allVisits(Animal animal)
    {
        List<Visit> res = new List<Visit>();
        foreach (var visit in Visits)
        {
            if(visit.Animal.Equals(animal))res.Add(visit);
        }

        return res;
    }

    public void addVisit(Visit visit)
    {
        Visits.Add(visit);
    }
}