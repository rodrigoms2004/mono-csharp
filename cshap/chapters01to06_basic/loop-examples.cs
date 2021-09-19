using System;

using static System.Console;

namespace loop_examples {
  class program {
    static void Main(string[] args) {
      // For loop
      WriteLine("For loop");
      for (int i = 0; i < 5; i++) {
        WriteLine(i);
      }
      int[] myNumbers = { 10, 20, 30, 40, 50 };
      for (int i = 0; i < myNumbers.Length; i++) {
        WriteLine(myNumbers[i]);
      }

      WriteLine("\nForeach loop");
      char[] message = { 'H', 'e', 'l', 'l', 'o'};      
      foreach (char i in message) 
        Write(i);
      WriteLine('\n');

      WriteLine("\nWhile loop");
      int counter = 5;
      while (counter > 0) {
        WriteLine("Counter = {0}", counter);
        counter--;
      }

      WriteLine("\nDo while loop");
      int counter2 = 100;
      do {
        WriteLine("Counter = {0}", counter2);
        counter2++;
      } while(counter2 < 100);

      WriteLine("\nJump Statements - Break");
      for (int i = 0; i < 5; i++) {
        WriteLine("i = {0}", i);
        if (i == 2)
          break;
      }
      
      WriteLine("\nJump Statements - Continue");
      for (int i = 0; i < 5; i++) {
        WriteLine("i = {0}", i);
        if (i == 2)
          continue;
        WriteLine("I will not be printed if i=2.\n");
      }
      
    }
  }
}