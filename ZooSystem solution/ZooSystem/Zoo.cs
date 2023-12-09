using System;
namespace ZooSystem
{
	public class Zoo
	{

		DietType Diet;
		List<Animal> animals;

		public Zoo()
		{
			animals = new List<Animal>();
		}

		public void addAnimal(Animal animal)
		{
            animals.Add(animal);
			Console.WriteLine("Animal Added Successfully!");
            Console.WriteLine("--------------------------------------------------------");
        }

		public void DisplayAnimal()
		{
			foreach (Animal animal in animals)
			{
				Console.WriteLine($"Animal: {animal.name} , Age:{animal.age} , Species: {animal.species}, Dite: {animal.Deit} ");
                Console.WriteLine("--------------------------------------------------------");

            }
        }
	}
}

