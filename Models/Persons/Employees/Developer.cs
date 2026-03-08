namespace AustraliaTechHubManagement.Models.Persons.Employees;

public class Developer : Employee
{
  public string Performance { get; set; } 
  public string ProgrammingLanguage { get; set; }

  public Developer(string name, int id, double baseSalary, string performance, string programmingLanguage)
    : base(name, id, baseSalary)
  {
    Performance = performance;
    ProgrammingLanguage = programmingLanguage;
  }
  
  public override double GetPaymentAmount()
  {
    double tax = CalculateTax();
    double bonus = Performance switch
    {
      "Excellent" => BaseSalary * 0.1,
      "Good" => BaseSalary * 0.05,
      _ => 0
    };
    return (BaseSalary - tax) + bonus;
  }
}