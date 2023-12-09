using System;
namespace ZooSystem
{
    public enum DietType
    {
        CARNIVORE,
        HERBIVORE,
        OMNIVORE
    }

    public class Animal
	{

		public string name { get; set; }
		public int age { get; set; }
		public string species { get; set; }
        public DietType Deit { get; set; }

		public Animal(){ }

        public Animal(string name, int age, string species, DietType Deit)
		{
			this.name = name;
			this.age = age;
			this.species = species;
			this.Deit = Deit;
		}
	}
}

