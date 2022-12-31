using System;

namespace mis221_lab4_lacyrich
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            double totalMoney = 11.00;
            
            CheckMoneyBalance(ref totalMoney);
            
            DisplayMenu();

            Console.WriteLine("Please enter your integer choice:");

            string userInput = Console.ReadLine();

            while(userInput != "4")
            {
                if(userInput != "1" && userInput != "2" && userInput != "3")
                {
                    Console.WriteLine("Invalid Choice");
                    userInput = Console.ReadLine();
                }
                else if(userInput == "1")
                {
                    BuyItem(ref totalMoney);
                }
                else if(userInput == "2")
                {
                    totalMoney = GiveHammACoin(totalMoney);
                }
                else if(userInput == "3")
                {
                    CheckMoneyBalance(ref totalMoney);
                }

                DisplayMenu();

                userInput = Console.ReadLine();
            } 

        }

        static void DisplayMenu()
        {
            Console.WriteLine("Use the following integers to select a menu choice");
            Console.WriteLine("1. Buy an item");
            Console.WriteLine("2. Give Hamm a coin");
            Console.WriteLine("3. Hamm's Money Balance");
            Console.WriteLine("4. Exit");
        }

        static void BuyItem(ref double totalMoney)
        {
            CheckMoneyBalance(ref totalMoney);

            DisplayToyItems();

            Console.WriteLine("Please enter the integer of the item you would like to purchase:");

            string userInput = Console.ReadLine();

            if(userInput == "1" || userInput == "2" || userInput == "3" || userInput == "4")
            {
                Transaction(userInput, ref totalMoney);
            }
            else
            {
                Console.WriteLine("That is not a valid option. Please try again");
            }

        }

        static void Transaction(string userInput, ref double totalMoney)
        {
            if(userInput == "1" && totalMoney >= 5)
            {
                totalMoney -= 5;
                CheckMoneyBalance(ref totalMoney);
            }
            else if(userInput == "2" && totalMoney >= 10)
            {
                totalMoney -= 10;
                CheckMoneyBalance(ref totalMoney);
            }
            else if(userInput == "3" && totalMoney >= 15)
            {
                totalMoney -= 15;
                CheckMoneyBalance(ref totalMoney);
            }
            else if(userInput == "4" && totalMoney >= 20)
            {
                totalMoney -= 20;
                CheckMoneyBalance(ref totalMoney);
            }
            else
            {   
                CheckMoneyBalance(ref totalMoney);
                Console.WriteLine("You do not have enough money to purchase this item. Hamm must be given more coins");
            }
        }

        static void DisplayToyItems()
        {
            Console.WriteLine("1. Mr. Potato head mustache | $5");
            Console.WriteLine("2. Spaceship for Buzz Lightyear | $10");
            Console.WriteLine("3. Cowboy hat for Woody | $15");
            Console.WriteLine("4. Purse for Barbie | $20");
        }

        static double GiveHammACoin(double totalMoney)
        {
            Console.WriteLine("To give me a coin just tell me what you are handing me");
            Console.WriteLine("Your options are: penny, nickel, dime, quarter");
            
            string coinChoice = Console.ReadLine();

            if(coinChoice.ToLower() == "penny")
            {
                totalMoney = totalMoney + 0.01;
                CheckMoneyBalance(ref totalMoney);
            }
            else if(coinChoice.ToLower() == "nickel")
            {
                totalMoney = totalMoney + 0.05;
                CheckMoneyBalance(ref totalMoney);
                
            }
            else if(coinChoice.ToLower() == "dime")
            {
                totalMoney = totalMoney + 0.10;
                CheckMoneyBalance(ref totalMoney);
            }
            else if(coinChoice.ToLower() == "quarter")
            {
                totalMoney = totalMoney + 0.25;
                CheckMoneyBalance(ref totalMoney);
            }
        
            return totalMoney;     
        }

        static void CheckMoneyBalance(ref double totalMoney)
        {
            Console.WriteLine("\n****** Hamm's Money Balance: $" + totalMoney.ToString("0.00") + "******\n");
        }

    }

}