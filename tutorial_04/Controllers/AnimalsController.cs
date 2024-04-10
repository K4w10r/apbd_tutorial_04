using tutorial_04.Database;
using tutorial_04.Models;

namespace tutorial_04.Controllers;
using Microsoft.AspNetCore.Mvc;


[ApiController]
[Route("[controller]")]
public class AnimalsController : ControllerBase
{
    private AnimalClinic Clinic = new AnimalClinic();

    [HttpGet]
    public IActionResult GetAnimals()
    {
        var Animals = Clinic.AnimalList;
        return Ok(Animals);
    }

    [HttpPost]
    public IResult AddAnimal(string name, string furColor, string category, double weight)
    {
        var Animals = Clinic.AnimalList;
        Animals.Add(new Animal(){Id = Animals.Count, Category = category, Weight = weight, Name = name, FurColor = furColor});
        return Results.Created();
    }

    [HttpPut]
    public IResult UpdateAnimal(int id, string name, string furColor, string category, double weight)
    {
        Clinic.editAnimal(id,name,category,furColor,weight);
        return Results.Created();
    }

    [HttpDelete]
    public IResult DeleteAnimal(int id)
    {
        Clinic.delete(id);
        return Results.Accepted();
    }

}