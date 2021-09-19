using System;
using System.Linq;
using static System.Console;

namespace linq_example {
  class Program {
    static void Main(string[] args) {
      int[] numbers = { 0, 1, 2, 3, 4, 5, 6 };
      var evenNumQuery = 
        from num in numbers 
        where (num % 2) == 0
        select num;
      
      foreach(int i in evenNumQuery) {
        WriteLine("{0} is an even number", i);
      }
    }
  }
}

// Output
// 0 is an even number
// 2 is an even number
// 4 is an even number
// 6 is an even number