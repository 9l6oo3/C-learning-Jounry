namespace ZooSystem;
class Program
{

    static void Main(string[] args)
    {
        bool flag = true;
        Zoo zoo = new Zoo();
        Animal animals = new Animal();

        Console.WriteLine("Welcome to the Minimalist Zoo Animal Management System!");
        

        while (flag)
        {
            Console.WriteLine("SELECT (1-5): \n" +
            "1. Add Animal \n" +
            "2. Display Animals \n" +
            "3. Add More Animals \n" +
            "4. Exit ");
            int choose;
            int.TryParse(Console.ReadLine(), out choose);

            if(choose == 1)
            {
                Console.WriteLine("Add Animal to Zoo:");
                Console.Write("Enter Animal Name:");
                string name = Console.ReadLine();

                Console.Write("Enter Animal Age:");
                int age;
                int.TryParse(Console.ReadLine(), out age);

                Console.Write("Enter Animal Species:");
                string species = Console.ReadLine();


                Console.Write("Enter Diet Type (CARNIVORE, HERBIVORE, OMNIVORE):");
                Enum.TryParse(Console.ReadLine().ToUpper(), out DietType diet);

                Animal animal = new Animal(name, age, species, diet);
                
                zoo.addAnimal(animal);
            }
            else if(choose ==2)
            {
                zoo.DisplayAnimal();
            }
            else if(choose == 3)
            {
                Console.WriteLine("Add Animal to Zoo:");
                Console.Write("Enter Animal Name:");
                string name = Console.ReadLine();

                Console.Write("Enter Animal Age:");
                int age;
                int.TryParse(Console.ReadLine(), out age);

                Console.Write("Enter Animal Species:");
                string species = Console.ReadLine();


                Console.Write("Enter Diet Type (CARNIVORE, HERBIVORE, OMNIVORE):");
                Enum.TryParse(Console.ReadLine().ToUpper(), out DietType diet);

                Animal animal = new Animal(name, age, species, diet);

                zoo.addAnimal(animal);
            }
            else
            {
                flag = false;
            }

        }
        Console.WriteLine("Thank you for using the Minimalist Zoo Animal Management System!");
        
        
    }
}

