using System;
using static System.Console;

namespace struct_example {
  struct MyStruct {
      // Fields
      private int x, y;
      private AnotherClass myClass;
      private Days myDays;

      // Constructor 
      public MyStruct(int a, int b, int c) {
        myClass = new AnotherClass();
        myClass.number = a;
        x = b;
        y = c;
        myDays = Days.Mon;
      }

      // Method
      public void PrintStatement() {
        WriteLine("x = {0}, y = {1}, myDays = {2}", x, y, myDays);
      }
    }
  class AnotherClass {
    public int number;
  }

  enum Days { Mon, Tues, Wed }

  class Program {
    static void Main(string[] args) {
      MyStruct example = new MyStruct(2, 3, 5);
      example.PrintStatement();    
    }
  }
}