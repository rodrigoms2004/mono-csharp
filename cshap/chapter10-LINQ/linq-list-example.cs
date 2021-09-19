using System;
using System.Linq;
using System.Collections.Generic;
using static System.Console;

namespace linq_example {
  class Customer {
    
    private string name;
    public string Name { 
      get {
        return name;
      }
    }
    
    private string phone;
    private string address;

    private decimal balance;
    public decimal Balance { 
      get {
        return balance;
      }
    }

    public Customer(string pname, string pphone, string paddress, decimal pbalance) {
      name = pname;
      phone = pphone;
      address = paddress;
      balance = pbalance;
    }
  }

  class Program {
    static void Main(string[] args) {
      List<Customer> customers = new List<Customer>();

      customers.Add(new Customer("Alan", "80911291", "ABC Street", 25.60m));
      customers.Add(new Customer("Bill", "19872131", "DEF Street", -32.1m));
      customers.Add(new Customer("Carl", "29812371", "GHI Street", -12.2m));
      customers.Add(new Customer("David", "78612312", "JKL Street", 12.6m));

      var overdue = 
        from cust in customers
        where cust.Balance < 0
        orderby cust.Balance ascending
        select new { cust.Name, cust.Balance };

      foreach (var cust in overdue) 
        WriteLine("Name = {0}, Balance = {1}", cust.Name, cust.Balance);
    }
  }
}

// OUTPUT
// Name = Bill, Balance = -32.1
// Name = Carl, Balance = -12.2