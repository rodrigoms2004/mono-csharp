using System;

using static System.Console;

namespace inline_if {
  class program {
    static void Main(string[] args) {

      int myNum = 3 > 2 ? 10 : 5;

      WriteLine(myNum); // 10
    }
  }
}