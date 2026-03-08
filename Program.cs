using System;
using System.Collections.Generic;
using AustraliaTechHubManagement.Interfaces;
using AustraliaTechHubManagement.Models;
using AustraliaTechHubManagement.Models.Persons;
using AustraliaTechHubManagement.Models.Persons.Employees;

namespace AustraliaTechHubManagement;

class Program
{
  static void Main(string[] args)
  {
    Console.WriteLine("---Australia Tech Hub Management System---");

    var hubList = new List<IPayable>
    {
      new Developer("Grace Nguyen", 1, 8888, "Excellent", "C#"),
      new Manager("John Doe", 2, 12000, 5),
      new Contractor("Jane Smith", 3, 50.5, 160),
      new ConsultantCompany("Tech Solutions", "ABN 123", 2004, 5000),
    };

    foreach (var item in hubList)
    {
      string detail = item switch
      {
        Employee e => e.Name,
        ConsultantCompany c => c.CompanyName,
        _ => "Unknown"
      };
      Console.WriteLine($"Type: {item.GetType().Name,-20} | Detail: {detail,-15} | Amount Payable: ${item.GetPaymentAmount(),5:N2}");
    }
  }
}