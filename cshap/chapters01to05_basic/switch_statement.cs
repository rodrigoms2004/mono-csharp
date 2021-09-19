using System;

using static System.Console;

namespace switch_statement {
  class program {
    static void Main(string[] args) {
      Write("Enter your grade: ");
      string userGrade = ReadLine();

      switch(userGrade) {
        case "A+":
        case "A":
          WriteLine("Distinction");
          break;
        case "B":
          WriteLine("B Grade");
          break;
        case "C":
          WriteLine("C Grade");
          break;
        default:
          WriteLine("Fail");
          break;
      }
    }
  }
}