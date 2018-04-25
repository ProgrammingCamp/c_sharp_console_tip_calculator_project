using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tip_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isReplay = true;

            do
            {
                Console.Write("Please enter cost");
                int cost = int.Parse(Console.ReadLine());

                Console.WriteLine("Please select quality of service");
                Console.WriteLine("enter 1 for good");
                Console.WriteLine("enter 2 for very good");
                Console.WriteLine("enter 3 for excellent");

                int choice = int.Parse(Console.ReadLine());

                if (choice == 1)
                {
                    int totalCost = cost + 5;
                    Console.WriteLine("The total cost is: " + totalCost);
                }
                else if (choice == 2)
                {
                    int totalCost = cost + 10;
                    Console.WriteLine("The total cost is: " + totalCost);
                }
                else if (choice == 3)
                {
                    int totalCost = cost + 20;
                    Console.WriteLine("The total cost is: " + totalCost);
                }
                else
                {
                    Console.WriteLine("Incorrect choice, Please enter the correct choice");
                }

                Console.Write("Do you want to replay? 1=yes 2=no");
                int answer = int.Parse(Console.ReadLine());

                if (answer == 1)
                {
                    isReplay = true;
                }
                else
                {
                    isReplay = false;
                }

                Console.ReadLine();

            } while (isReplay == true);

        }
    }
}
