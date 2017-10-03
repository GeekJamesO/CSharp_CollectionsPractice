using System;
using System.Collections.Generic;

namespace CollectionPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //Three Basic Arrays
            Console.WriteLine("Create an array to hold integer values 0 through 9");
            int[] tenInts = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            WriteArray(tenInts);

            Console.WriteLine("Create an array of the names \"Tim\", \"Martin\", \"Nikki\", & \"Sara\"");
            string[] friends = new string[] { "Tim", "Martin", "Nikki", "Sara" };
            WriteArray(friends);

            Console.WriteLine("Create an array of length 10 that alternates between true and false values, starting with true");
            var bools = new Boolean[10];
            for (int i = 0; i < bools.Length; i++)
            {
                bools[i] = (0 == i % 2);
            }
            WriteArray(bools);


            Console.WriteLine("Multiplication Table");
            Console.WriteLine("With the values 1-10, use code to generate a multiplication table like the one below.");
            Console.WriteLine("Use a multidimensional array to store all values");
            int[,] MultiTable = new int[10, 10];
            GenerateTable(MultiTable);

            PrintTable(MultiTable);

			//List of Flavors
			Console.WriteLine("Create a list of Ice Cream flavors that holds at least 5 different flavors(feel free to add more than 5!)");

            List<string> IcecreamFlavors = new List<string>() 
            {
				"Almond", "Apple Pie", 
                "Bacon",  "Banana", "Banana Split", "Barbeque", "Bastani Sonnati - Persian", "Bear Claw", "Beer", "Black Cherry", "Black Raspberry", "Black Walnut", "Blackberry","Blue Moon",
				"Blueberries", "Blueberry Pie", "Bosenberry", "Brown bread", "Brownie Nut", "Bubblegum", "Butter Brickle", "Butter Pecan", "Butter Rum", "Butter Pecan Caramel", "Butterscotch Waitrose",
                "Cake Batter", "Candy Bar whirls", "Cappuccino Crunch", "Caramel Cream", "Caramel Nut Cluster", "Caramel Peanut Butter", "Carrot Cake", "Cat (Japan)", "Cheese", "Cheese and Corn", 
                "Cherry", "Cherry Cordial", "Choco Lava", "Chocolate", "Chocolate Almond", "Chocolate Cherry Fudge", "Chocolate Chip", "Chocolate chip cookie dough", "Coconut milk", "Coffee", 
                "Coffee and Cookie", "Cookie dough", "Cookies and Cream", "Corn", "Cotton Candy", "Crab", "Cranberry", "Cucumber", "Curry",
                "Dandelion", "Dark Chocolate", "Dog", "Donnatella", "Dulce de Leche", "Durian",
                "Elephant Tracks", "English toffee", "Espresso", "Espresso Fudge",
                "French Vanilla", "Fried Ice Cream", "Frutti Tutti", "Fudge Mountain", "Fudge Ripple",
                "Garlic", "Ginger", "Grape", "Grape nut", "Green Monster", "Green Tea", "Guinness",
                "Hallietans", "Halva", "Heavenly Hash", "Hokey Pokey", "Honeycomb",
                "Irish Cream",
                "Jam", "Jelly Bean", "Jelly Tip", "Jik Jak",
                "Key Lime Pie", "Kiwi",
                "Lemon", "Lemon custard", "Licorice", "Lucuma",
                "Madagascar Vanilla", "Mamey", "Mango", "Maple", "Maple Walnut", "Mint", "Mint Chocolate Chip", "Moon Mist", "Moose Tracks",
                "Neapolitan", "Nuts for nuts", 
                "Octopus", "Orange Sherbert", "Oreo", "Oyster", "Panda Paws", "Peach", "Peanut", "Peanut Butter Panic", "Pecan", "Peppermint", "Phish Foo", "PineapplevPistachio", "Praline", "Praline Crunch", "Pralines and Cream",
                "Quarterback Crunch", "Queen of Cricket",
                "Rainbow", "Raisin Rum", "Raspberry", "Raspberry Ripple", "Raspberry Rum", "Reeses Peanut Butter Cup", "Rice", "Rocky Mountain Raspberry", "Rocky Road", "Root Beer",
                "Salmon", "Samoa", "Sherbert", "Spumoni", "Squid ink", "Stracciatella", "Strawberry", "Strawberry Cheesecake", "Strawberry Shortcake", "Superman",
                "Take the Cake", "Tapioca", "Teaberry", "Thin mint", "Tiger", "Tiger Tail", "Toffee Temptations", "Triple Strawberry", "Tutti frutti",
                "Upsidedown Downsideup",
                "Vanilla", "Vanilla Bean", "Vanilla Caramel Brownie", "Vanilla Stick",
                "Watermelon",
                "Yaslum",
                "Zylaphenes"
			};
            WriteList(IcecreamFlavors);

			Console.WriteLine("Output the length of this list after building it");
            Console.WriteLine("  List of this length is " + IcecreamFlavors.Count); 
			Console.WriteLine("Output the third flavor in the list, then remove this value.");
            Console.WriteLine("  The third entry in the list is " + IcecreamFlavors[2]);
            IcecreamFlavors.Remove(IcecreamFlavors[2]);
			Console.WriteLine("Output the new length of the list(Note it should just be one less~)");
			Console.WriteLine("  List of this length is " + IcecreamFlavors.Count);
		}

        private static void PrintTable(int[,] MultiTable)
        {
            for (int x = 0; x < 10; x++)
            {
                if (x == 0)
                    Console.Write(string.Format("          {0,3}, ", x + 1));
                else
                    Console.Write(string.Format("{0,3}, ", x + 1));
            }
            Console.WriteLine();
            Console.WriteLine("         ____________________________________________________");

            for (int x = 0; x < 10; x++)
            {
                Console.Write(string.Format("   {0,2} | [ ", x + 1));
                for (int k = 0; k < 10; k++)
                {
                    Console.Write(string.Format("{0,3}, ", MultiTable[x, k]));
                }
                Console.WriteLine(string.Format(" ] "));
            }
            Console.WriteLine("         ____________________________________________________");
        }

        private static void GenerateTable(int[,] MultiTable)
        {
            for (int x = 0; x < 10; x++)
            {
                for (int k = 0; k < 10; k++)
                {
                    MultiTable[x, k] = (x + 1) * (k + 1);
                }
            }
        }

        private static void WriteArray<T>(T[] arry )
        {
            Console.Write("   [ ");
			for (int i = 0; i < arry.Length; i++)
			{
                if (i+1 < arry.Length)
				    Console.Write(arry[i] + ", ");
                else
				    Console.WriteLine(arry[i] + " ] ");
			}
		}

		private static void WriteList<T>(List<T> alist)
		{
			Console.Write("   [ ");
            foreach (object node in alist)
			{
				Console.Write(node + ", ");
			}
			Console.WriteLine(" ] ");
		}

	}
}


//User Info Dictionary
//    Create a Dictionary that will store both string keys as well as string values
//    For each name in the array of names you made previously, add it as a new key in this dictionary with value null
//    For each name key, select a random flavor from the flavor list above and store it as the value
//    Loop through the Dictionary and print out each user's name and their associated ice cream flavor.

