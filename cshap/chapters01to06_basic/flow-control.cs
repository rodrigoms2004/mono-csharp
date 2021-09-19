using System;

using static System.Console;


namespace flow_control {
  class program {
    static void Main(string[] args) {
      int userAge;

      Write("Please enter your age: ");
      userAge = Convert.ToInt32(ReadLine());

      if (userAge < 0 || userAge > 100) {
        WriteLine("Invalid Age");
        WriteLine("Age must be between 0 and 100");
      } else if (userAge < 18) {
        WriteLine("Sorry you are underage");
      } else if (userAge < 21) {
        WriteLine("You need parental consent");
      } else {
        WriteLine("Congratulations!");
        WriteLine("You may sign up for the event!");
      }
    } 
  }
}