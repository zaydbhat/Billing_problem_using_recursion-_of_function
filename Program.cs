using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            shopping();
        }

        public static void shopping()
        {
            Console.WriteLine("Welcome to X-mart");

            Console.WriteLine("Press 1 for shopping");
            Console.WriteLine("Press 0 for exit");

            int decision_1 = int.Parse(Console.ReadLine());

            int total_amount1 = 0;

            

            if (decision_1 == 1)
            {
                Console.WriteLine("Items available for shopping");
                Console.WriteLine("Jeans @ 599 only");
                Console.WriteLine("T-shirts @ 399 only");
                Console.WriteLine("Hoodies @ 899 only");

                Console.WriteLine("Press J to add a Jeans to cart");
                Console.WriteLine("Press T to add a T_shirt to cart");
                Console.WriteLine("Press H to add a Hoodie to cart");

                string decision_2 = Console.ReadLine();

                if (decision_2 == "J")
                {
                    total_amount1 = total_amount1 + 599;
                   
                }
                else if (decision_2 == "T")
                {
                    total_amount1 = total_amount1 + 399;
                    
                }
                else if(decision_2 == "H")
                {
                    total_amount1 = total_amount1 + 899;
                   
                }

                Console.WriteLine(total_amount1);

            }

            reshop();

            
        }

        public static void reshop()
        {
            int total_amount = 0;

            Console.WriteLine("Do you want to continue shopping?");

            Console.WriteLine("Press 11 for YES");
            Console.WriteLine("Press 00 for NO");

            int decision_3 = int.Parse(Console.ReadLine());

            if (decision_3 == 11)
            {
                Console.WriteLine("Items available for shopping");
                Console.WriteLine("Jeans @ 599 only");
                Console.WriteLine("T-shirts @ 399 only");
                Console.WriteLine("Hoodies @ 899 only");

                Console.WriteLine("Press J to add a Jeans to cart");
                Console.WriteLine("Press T to add a T_shirt to cart");
                Console.WriteLine("Press H to add a Hoodie to cart");

                string decision_4 = Console.ReadLine();

                if (decision_4 == "J")
                {
                    total_amount = total_amount + 599;
                   
                }
                else if (decision_4 == "T")
                {
                    total_amount = total_amount + 399;
                   
                }
                else if (decision_4 == "H")
                {
                    total_amount = total_amount + 899;
                   
                }

                Console.WriteLine(total_amount);

            }
            else
            {
                Console.WriteLine("Visit again");
            }
            
        }
    }
}
