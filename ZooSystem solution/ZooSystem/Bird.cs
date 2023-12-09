using System;
namespace ZooSystem
{
	public class Bird : Animal
	{
		public string feather{ get; set; }

		
		public Bird(string feather, string name, int age, string species, DietType Deit) : base (name, age, species, Deit)
		{
			this.feather = feather;
		}

        public void fly()
        {
            Console.WriteLine($"Can FLY! Has {feather} feather");
        }
    }
}

