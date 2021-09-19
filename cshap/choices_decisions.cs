using System;

using static System.Console;

namespace choices_decisions {
  class program {
    static void Main(string[] args) {
      WriteLine(5 != 2); // True
      WriteLine(6 != 6); // False

      WriteLine(5 == 5 && 2 > 1 && 3 != 7); // True
      WriteLine(5 == 5 && 2 < 1 && 3 != 7); // False


      WriteLine(5 == 5 || 2 < 1 || 3 == 7); // True
      WriteLine(5 == 6 || 2 < 1 || 3 == 7); // False

    }
  }
}