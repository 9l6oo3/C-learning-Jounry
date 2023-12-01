using System.Drawing;

namespace CoffeeShop;
class Program
{
    //display_menu
    static void display_menu(string[] opt , double[] price)
    {
        for (int i = 0; i < opt.Length; i++)
        {
                Console.WriteLine($"{i+1}- {opt[i]} -- Price = {price[i]}");
        }
    }

    //place order
    static void place_order(out string withsuger, out string withmilk)
    {
        //choose type of coffee 
        int coffeOrder;
        do
        {
            Console.WriteLine("select your choise (1-3)? ");
        }
        while (!int.TryParse(Console.ReadLine(), out coffeOrder) || coffeOrder >3);

        //choose size 
        int size;
        do
        {
            Console.WriteLine("Do you want \n1.small \n2.medium \n3.large (1-3)? ");
        } while (!int.TryParse(Console.ReadLine(), out size) || size > 3);

        //with suger
        Console.WriteLine($"do you want suger (Yes/No)?");
        string suger = Console.ReadLine();
        withsuger = (suger.ToLower() == "yes") ? " with suger" : " with out suger";
        
        //with milk
        Console.WriteLine($"do you want milk (Yes/No)?");
        string milk = Console.ReadLine();
        withmilk = (milk.ToLower() ==  "yes") ? " with milk" : " with out milk";
        
    }

    //calculate price
    static double calculate_cost(string []coffeeOpt ,double[] price, string[] coffeeSize ,double[] sizePrice , int size , int opt, out double totalCost)
    {
        double coffeePrice = price[opt];
        double sizeOfCoffee = sizePrice[size];
        totalCost = coffeePrice + sizeOfCoffee;
        return totalCost;
    }

    static void display_order_summary(string[] coffeeOpt, string[] coffeeSize, string sugar, string milk, double total_cost, int opt, int size)
    {
        Console.WriteLine("Your order : ");
        Console.Write($"Your COFFEE Choise: {coffeeOpt[opt]} -");
        Console.Write($" The SIZE: {coffeeSize[size]} -");
        Console.Write($"{sugar}, ");
        Console.Write($"{milk} ");
        Console.Write($"   - Total COST: {total_cost}$ \n");
    }

    static void Main(string[] args)
    {
        int size=0, opt=0;
        string withsuger, withmilk ;
        double totalCost;
        string[] option = { "Amricano", "Latte", "Cappationo" };
        double[] priceOfCoffee = { 2.50, 3.0, 3.50 };
        string[] coffeesize = { "Small", "Medium", "Large" };
        double[] priceSize = { 1.0, 1.5, 2.0 };

        Console.WriteLine("Welcom to our coffee shop system!");

        display_menu(option, priceOfCoffee);
        place_order(out withsuger,out withmilk);
        calculate_cost(option, priceOfCoffee, coffeesize, priceSize, size, opt, out totalCost);
        display_order_summary(option, coffeesize, withsuger, withmilk, totalCost,size,opt);

        Console.WriteLine("THANK YOU.");

    }
}


