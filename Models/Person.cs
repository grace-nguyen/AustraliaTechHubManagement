using AustraliaTechHubManagement.Interfaces;

namespace AustraliaTechHubManagement.Models;

public abstract class Person : IPayable, ITaxable
{
  public string Name { get; set; }
  public int Id { get; set; }

  public Person(string name, int id)
  {
    Name = name;
    Id = id;
  }
  public abstract double GetPaymentAmount();
  public abstract double CalculateTax();
}