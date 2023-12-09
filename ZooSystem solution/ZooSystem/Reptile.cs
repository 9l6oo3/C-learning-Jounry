using System;
namespace ZooSystem
{
	public class Reptile : Animal
	{
		public string leather { get; set; }

		public Reptile(string leather, string name, int age, string species, DietType Deit) : base (name, age, species, Deit)
        {
			this.leather = leather;
		}

		public void Move()
		{
			Console.WriteLine($"Can Move! has {leather} Leather");
		}
	}
}

