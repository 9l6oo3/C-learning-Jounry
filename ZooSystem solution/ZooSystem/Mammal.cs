using System;
namespace ZooSystem
{
	public class Mammal : Animal
	{
		public string Fur { get; set; }

		public Mammal(string Fur, string name, int age, string species, DietType Deit) : base(name, age, species, Deit)
        {
			this.Fur = Fur;
		}

		public void walk()
		{
			Console.WriteLine($"Walking! Has {Fur} Fur.");
		}
	}
}

