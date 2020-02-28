using System;
using System.Collections.Generic;

class Program {
  static void Main () {
    
    string[] Array1 = {"red", "green", "blue"};
    
    Console.WriteLine("Select an index from my first array to display the item. Type 0, 1 or 2:");

    int IndexSelection1 = Convert.ToInt32(Console.ReadLine());

    if (IndexSelection1 >= 3 || IndexSelection1 < 0)
    {
      Console.WriteLine("You need to type 0, 1, or 2. There are no other options.");
      Environment.Exit(-1);
    }

    Console.WriteLine("The item is: ");
    Console.WriteLine(Array1[IndexSelection1]);

    int[] Array2 = {2, 1, 5};
    
    Console.WriteLine("Select an index from my second array to display the item. Type 0, 1 or 2:");

    int IndexSelection2 = Convert.ToInt32(Console.ReadLine());

     if (IndexSelection2 >= 3 || IndexSelection2 < 0)
    {
      Console.WriteLine("You need to type 0, 1, or 2. There are no other options.");
      Environment.Exit(-1);
    }

    Console.WriteLine("The item is: ");
    Console.WriteLine(Array2[IndexSelection2]);

    List<string> List1 = new List<string>();
    List1.Add("oranges");
    List1.Add("apples");
    List1.Add("bananas");
    List1.Add("grapefruit");
    List1.Add("pomegranite");

    Console.WriteLine("Select an index from my first list to display the item. Type 0, 1, 2, 3, or 4: ");

    int ListSelection1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("The item is: ");
    Console.WriteLine(List1[ListSelection1]);

  }
}