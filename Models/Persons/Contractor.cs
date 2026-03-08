namespace AustraliaTechHubManagement.Models.Persons;

public class Contractor : Person
{
  public double HourlyRate { get; set; }
  public int HoursWorked { get; set; }

  public Contractor(string name, int id, double hourlyRate, int hoursWorked) : base(name, id)
  {
    HourlyRate = hourlyRate;
    HoursWorked = hoursWorked;
  }

  public override double GetPaymentAmount() => HourlyRate * HoursWorked;

  public override double CalculateTax() => GetPaymentAmount() * 0.15; // Simple tax calculation for contractors
}