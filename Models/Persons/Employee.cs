namespace AustraliaTechHubManagement.Models.Persons;

public class Employee : Person
{
  public double BaseSalary { get; set; }

  public Employee(string name, int id, double baseSalary) : base(name, id)
  {
    BaseSalary = baseSalary;
  }
  public override double GetPaymentAmount() => BaseSalary - CalculateTax();
  public override double CalculateTax()
  {
    if (BaseSalary > 10000) return BaseSalary * 0.3;
    if (BaseSalary > 5000) return BaseSalary * 0.2;
    return BaseSalary * 0.1;
  }
}