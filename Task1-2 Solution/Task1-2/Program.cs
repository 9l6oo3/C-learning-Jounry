using System.ComponentModel;

namespace Task1_2;
class Program
{
    static void Main(string[] args)
    {
        //Write a program that takes two integers then prints the power.
        Console.WriteLine("--------------------- Q11 ----------------------");
        Console.WriteLine("Enter two elements: ");
        int x = Convert.ToInt32(Console.ReadLine());
        int y = Convert.ToInt32(Console.ReadLine());
        double result = Math.Pow(x, y);
        Console.WriteLine(result);


        //Write a program to enter marks of five subjects and calculate total, average and percentage.
        Console.WriteLine("--------------------- Q12 ----------------------");
        Console.WriteLine("Enter five marks: ");
        int mark1 = Convert.ToInt32(Console.ReadLine());
        int mark2 = Convert.ToInt32(Console.ReadLine());
        int mark3 = Convert.ToInt32(Console.ReadLine());
        int mark4 = Convert.ToInt32(Console.ReadLine());
        int mark5 = Convert.ToInt32(Console.ReadLine());

        int total = mark1 + mark2 + mark3 + mark4 + mark5;
        int avr = (mark1 + mark2 + mark3 + mark4 + mark5) / 5;

        Console.WriteLine($"Total marks = {total}");
        Console.WriteLine($"Average marks = {avr}");
        Console.WriteLine($"percentage marks = {avr}");

        //Write a program to input the month number and print the number of days in that month.
        Console.WriteLine("--------------------- Q13 ----------------------");
        Console.WriteLine("Month number : ");
        int month = Convert.ToInt32(Console.ReadLine());
        
        switch(month){
            case 1:
                Console.WriteLine("Day in month : 31");
                break;
            case 2:
                Console.WriteLine("Day in month : 28");

                break;
            case 3:
                Console.WriteLine("Day in month : 31");

                break;
            case 4:
                Console.WriteLine("Day in month : 30");

                break;
            case 5:
                Console.WriteLine("Day in month : 31");

                break;
            case 6:
                Console.WriteLine("Day in month : 30");

                break;
            case 7:
                Console.WriteLine("Day in month : 31");

                break;
            case 8:
                Console.WriteLine("Day in month : 31");

                break;
            case 9:
                Console.WriteLine("Day in month : 30");

                break;
            case 10:
                Console.WriteLine("Day in month : 31");

                break;
            case 11:
                Console.WriteLine("Day in month : 30");

                break;
            case 12:
                Console.WriteLine("Day in month : 31");

                break;
        }
        

        //Write a program to input marks of five subjects Physics, Chemistry, Biology, Mathematics and Computer, And Calculate percentage and grade.
        Console.WriteLine("--------------------- Q14 ----------------------");
        Console.WriteLine("Enter five marks: ");
        int Physics = Convert.ToInt32(Console.ReadLine());
        int Chemistry = Convert.ToInt32(Console.ReadLine());
        int Biology = Convert.ToInt32(Console.ReadLine());
        int Mathematics = Convert.ToInt32(Console.ReadLine());
        int Computer = Convert.ToInt32(Console.ReadLine());


        int percentage = (Physics + Chemistry + Biology + Mathematics + Computer) / 5;

        if (percentage>=90)
            Console.WriteLine($"{percentage} Grad A");
        else if (percentage >= 80)
            Console.WriteLine($"{percentage} Grad B");
        else if (percentage >= 70)
            Console.WriteLine($"{percentage} Grad C");
        else if (percentage >= 60)
            Console.WriteLine($"{percentage} Grad D");
        else if (percentage >= 50)
            Console.WriteLine($"{percentage} Grad E");
        else 
            Console.WriteLine($"{percentage} Grad F");


        //Write a program to check whether a number is positive or negative or zero.
        Console.WriteLine("--------------------- Q15 ----------------------");
        Console.WriteLine("Enter number : ");
        x = Convert.ToInt32(Console.ReadLine());

        if (x>0)
            Console.WriteLine("positive");
        else if (x<0)
            Console.WriteLine("negative");
        else
            Console.WriteLine("zero");
       

        //Write a program to create a Simple Calculator.
        Console.WriteLine("--------------------- Q16 ----------------------");

        bool repeat = true;

        while (repeat)
        {

            string[] operation = { "submition", "subtraction", "multiplication", "division", "exit" };

            for (int i = 0; i < operation.Length; i++)
            {
                Console.WriteLine($"{i + 1} . {operation[i]} ");
            }

            Console.WriteLine("choose which operation you need (1-5)? ");
            int opr = Convert.ToInt32(Console.ReadLine());
            int x, y, sum, sub, multi;
            double div;

            if (opr == 1)
            {
                Console.WriteLine("enter two elements: ");
                x = Convert.ToInt32(Console.ReadLine());
                y = Convert.ToInt32(Console.ReadLine());
                sum = x + y;
                Console.WriteLine($"the sum of elements =  {sum}");
            }
            else if (opr == 2)
            {
                Console.WriteLine("enter two elements: ");
                x = Convert.ToInt32(Console.ReadLine());
                y = Convert.ToInt32(Console.ReadLine());
                sub = x - y;
                Console.WriteLine($"the subtraction of elements =  {sub}");
            }
            else if (opr == 3)
            {
                Console.WriteLine("enter two elements: ");
                x = Convert.ToInt32(Console.ReadLine());
                y = Convert.ToInt32(Console.ReadLine());
                multi = x * y;
                Console.WriteLine($"the multiplication of elements =  {multi}");
            }
            else if (opr == 4)
            {
                Console.WriteLine("enter two elements: ");
                x = Convert.ToInt32(Console.ReadLine());
                y = Convert.ToInt32(Console.ReadLine());
                div = (double)x / (double)y;
                Console.WriteLine($"the division of elements =  {div}");
            }
            else
            {
                repeat = false;
                Console.WriteLine("Thank you for using simple calculator! ");
            }


        }


    }
}

