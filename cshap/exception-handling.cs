using System;

using static System.Console;

namespace exception_handling {
  class program {
    static void Main(string[] args) {
      int numerator, denominator;

      Write("Please enter the numerator: ");
      numerator = Convert.ToInt32(ReadLine());
      
      Write("Please enter the denominator: ");
      denominator = Convert.ToInt32(ReadLine());

      try {
        WriteLine("The result is {0}.", numerator/denominator);
      } catch(Exception e) {
        WriteLine(e.Message);
      } finally {
        WriteLine("---- End of Error Handling Example ----");
      }

    }
  }
}