namespace AustraliaTechHubManagement.Models.Persons.Employees;

public class Manager : Employee
{
  public int TeamSize { get; set; }

  public Manager(string name, int id, double baseSalary, int teamSize)
    : base(name, id, baseSalary)
  {
    TeamSize = teamSize;
  }
  public override double GetPaymentAmount()
  {
    double tax = CalculateTax();
    double managementBonus = TeamSize * 100; // Simple bonus based on team size
    return (BaseSalary - tax) + managementBonus;
  }
}