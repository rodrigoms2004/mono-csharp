using System;

using static System.Console;

namespace staff_example {
  class Staff {
    private string nameOfStaff;
    private const int hourlyRate = 30;
    private int hWorked;

    public int HoursWorked {
      get {
        return hWorked;
      }
      set {
        if (value > 0)
          hWorked = value;
        else 
          hWorked = 0;
      }
    }

    public void PrintMessage() {
      WriteLine("Calculating Pay...");
    }

    public int CalculatePay() {
      PrintMessage();

      int staffPay;
      staffPay = hWorked * hourlyRate;

      if (hWorked > 0) 
        return staffPay;
      else
        return 0;
    }

    public int CalculatePay(int bonus, int allowance) {
      PrintMessage();

      if (hWorked > 0)
        return hWorked * hourlyRate + bonus + allowance;
      else
        return 0;
    }

    public override string ToString() {
      return "Name of Staff = " + nameOfStaff + ", hourlyRate = " + hourlyRate + ", hWorked = " + hWorked;
    }

    // Constructor
    public Staff(string name) {
      nameOfStaff = name;
      WriteLine("\n" + nameOfStaff);
      WriteLine("-----------------------------");
    }

    public Staff(string firstName, string lastName) {
      nameOfStaff = firstName + " " + lastName;
      WriteLine("\n" + nameOfStaff);
      WriteLine("-----------------------------");
    }

  } // end class

  class program {
    static void Main(string[] args) {
      int pay;
      Staff staff1 = new Staff("Peter");
      staff1.HoursWorked = 160;
      pay = staff1.CalculatePay(1000, 400);
      

      Staff staff2 = new Staff("Jane", "Lee");
      staff2.HoursWorked = 160;
      pay = staff2.CalculatePay();
      WriteLine("Pay = {0}", pay);

      Staff staff3 = new Staff("Carol");
      staff3.HoursWorked = -10;
      pay = staff3.CalculatePay();
      WriteLine("Pay = {0}", pay);
    }
  }
} // end namespace