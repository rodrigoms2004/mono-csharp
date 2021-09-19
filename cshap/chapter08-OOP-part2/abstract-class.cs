using System;
using static System.Console;

namespace AbstracrClassDemo {
  class Program {
    static void Main(string[] args) {
      // MyAbstractClass abClass = new MyAbstractClass();

      ClassA a = new ClassA();
      a.PrintMessage();
      a.PrintMessageAbstract();
      Read();
    }
  } // class Program

  abstract class MyAbstractClass {
    private string message = "Hello C#";
    public void PrintMessage() {
      WriteLine(message);
    }

    public abstract void PrintMessageAbstract();
  }

  class ClassA : MyAbstractClass {
    public override void PrintMessageAbstract() {
      WriteLine("C# is fun!");
    }
  }

} // end namespace