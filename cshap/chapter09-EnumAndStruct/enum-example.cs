using System;
using static System.Console;


namespace enum_example {
  class Program {
    enum DaysOfWeek { 
      Sun, Mon, Tues, Wed, Thurs, Fri, Sat 
    }

    enum DaysOfWeekTwo {
      Sun = 5, Mon = 10, Tues, Wed, Thurs, Fri, Sat 
    }

    enum DaysOfWeekThree : byte {
      Sun, Mon, Tues, Wed, Thurs, Fri, Sat 
    }


    static void Main(string[] args) {
      DaysOfWeek myDays = DaysOfWeek.Mon;
      WriteLine(myDays);              // Mon
      WriteLine((int)myDays);         // 1
      WriteLine((DaysOfWeek)1);       // Mon

      WriteLine('\n');

      DaysOfWeekTwo myDays2 = DaysOfWeekTwo.Wed;
      WriteLine(myDays2);             // Wed
      WriteLine((int)myDays2);        // 12
      WriteLine((DaysOfWeekTwo)12);   // Wed

      WriteLine('\n');
  
      DaysOfWeekThree myDays3 = DaysOfWeekThree.Thurs;
      WriteLine(myDays3);             // Thurs
      WriteLine((int)myDays3);        // 4
      WriteLine((DaysOfWeekThree)4);  // Thurs

    }
  }
}
