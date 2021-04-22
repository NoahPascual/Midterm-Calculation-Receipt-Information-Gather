// Noah Pascual
// MIS 3033
// Midterm One - Task Two

// Instructions:
// Congratulations! You are the proud owner of a new coffee shop.  
// You have decided to put your excellent MIS skills to the test and automate your ordering process at your store
// Create a console application that allows a user to specify their order according to the following list.
// Espresso	$2.15
// Cappuccino	$4.20
// Latte	$5.00
// Americano	$3.55
// Drip	$1.25
// Shot of Vanilla	+ $0.75 each shot
// Shot of Espresso	+ $0.80 each shot

// The console application should wait until the user comes to the computer and types any variation of "hello".
// Once the user inputs hello, prompt them with a courtesy greeting and display the menu above (with the prices)
// For simplicity, assume the user will only order one Coffee beverage at a time
// Once they have chosen their drink, display the additional menu of extra shots and ask if they would like to add a type of shot.  
// If they say Yes or Y, ask them which type (Vanilla or Espresso) and the quantity of shots.  
// Once you have a line item ready, add it to a collection (if you want good practice you can come up with your own class and store that) with the total.  
// Prompt the user if they want any other drink, and if so repeat the process.  
// Once they say that they are finished, output each line item (either price or the order based upon how far you want to go) and then the total for the order
// Make sure to include a sales tax of 7.5% on the total order.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {

            // Main constant variables
            const double expresso = 2.15;
            const double cappuccino = 4.20;
            const double latte = 5.00;
            const double americano = 3.55;
            const double drip = 1.15;
            const double vanillaShot = 0.75;
            const double expressoShot = 0.80;
            const double salesTax = 1.075;

            // Other Main variables
            int userInput = 0;
            string userGreeting;
            double shotQty = 0;
            double costTotal = 0;
            double drinkTotal = 0;
            double shotTotal = 0;
            double extraTotal = 0;
            double taxTotal = 0;

            // Title (Midterm)
            string title = "--- Midterm One: Task Two ---";
            Console.SetCursorPosition((Console.WindowWidth - title.Length) / 2, Console.CursorTop);
            Console.WriteLine(title);

            // Console won't start till customer types "hello" (in any form)
            Console.WriteLine("");
            userGreeting = Console.ReadLine();
            userGreeting = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(userGreeting.ToLower());
            if (userGreeting == ("Hello"))
            {
                Console.WriteLine("Greetings! I hope you're having a wonderful day! What can I get for you? Enter which drink you'd like by number [1-5]\n\r");
            }

            while (true)
            {
                userInput = StoreMenu();
                switch (userInput)
                {
                    case 1:
                        drinkTotal = drinkTotal + expresso;
                        break;
                    case 2:
                        drinkTotal = drinkTotal + cappuccino;
                        break;
                    case 3:
                        drinkTotal = drinkTotal + latte;
                        break;
                    case 4:
                        drinkTotal = drinkTotal + americano;
                        break;
                    case 5:
                        drinkTotal = drinkTotal + drip;
                        break;
                }

                Console.WriteLine("Would you like to add extra shots (Yes or Y)?");
                string inputShot = ReadLine().ToLower();
                if (inputShot.Equals("yes") || inputShot.Equals("y"))
                {
                    userInput = 0;
                    userInput = ExtraShot();

                    switch (userInput)
                    {
                        case 1:
                            shotTotal = shotTotal + vanillaShot;
                            break;
                        case 2:
                            shotTotal = shotTotal + expressoShot;
                            break;
                    }
                    Console.WriteLine("How many shots would you like with your drink?");
                    shotQty = Convert.ToInt32(ReadLine());
                }

                Console.WriteLine("Would you like to add another drink? (Y or N)");
                string recallOrder = ReadLine().ToLower();
                if (recallOrder.Equals("n"))
                {
                    break;
                }
            }

            // Cost of shots (Qty * Shot price)
            extraTotal = shotQty * shotTotal;
            // Total Price with drink, shot (w/ quantity) and sales tax
            costTotal = ((extraTotal + drinkTotal) * salesTax);
            taxTotal = ((extraTotal + drinkTotal) * 0.075);

            // Output Receipt to customer
            Console.WriteLine($"\t Drink Price:    {drinkTotal.ToString("C2")}");
            Console.WriteLine($"\t Shot Price:     {extraTotal.ToString("C2")}");
            Console.WriteLine($"\t Shot Amout:     {shotQty}");
            Console.WriteLine($"\t Total Price:    {costTotal.ToString("C2")}");
            Console.WriteLine($"\t Tax Amout:      {taxTotal:C2}");

            // Exit
            Console.WriteLine("\n\rPress any key to exit the application.");

            //Readkey
            Console.ReadKey();
        }


        // Function with Menu
        public static int StoreMenu()
        {
            int UserMenu;
            Console.WriteLine("Menu           Price");
            Console.WriteLine("Espresso       $2.15");
            Console.WriteLine("Cappuccino     $4.20");
            Console.WriteLine("Latte          $5.00");
            Console.WriteLine("Americano      $3.55");
            Console.WriteLine("Drip           $1.25");
            Console.Write("Enter your menu choice[1-5]: ");
            int.TryParse(Console.ReadLine(), out UserMenu);
            return UserMenu;
        }
        // Function with extra shot and their price increase
        public static int ExtraShot()
        {          
            int userShot;
            Console.WriteLine("Extra            Price Increase");
            Console.WriteLine("Vanilla Shot     $0.75");
            Console.WriteLine("Expresso Shot    $0.80");
            Console.Write("Enter your menu choice[1-2]: ");
            int.TryParse(Console.ReadLine(), out userShot);
            return userShot;
        }
    }
}
