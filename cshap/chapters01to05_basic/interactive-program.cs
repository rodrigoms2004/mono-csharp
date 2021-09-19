using System;

using static System.Console;

namespace interactive_program {
  class interactive_program {
    static void Main(string[] args) {
      WriteLine("Hello " + "World");

      int results = 79;
      WriteLine("{0}! You scored {1} marks for your test.", "Good morning", results);

      WriteLine("The number is {0:F3}",  123.45678); // 123.457

      WriteLine("Deposit = {0:C}. Account balance = {1:C}.", 2125, 12345.678); // Deposit = $2,125.00. Account balance = $12,345.68

      // User input

      WriteLine("Input some number:");
      string userInput = ReadLine();
      WriteLine(userInput);

      // Convert string to a Number

      int newUserInput = Convert.ToInt32(userInput);
      WriteLine(newUserInput);
      
    }
  }
}

