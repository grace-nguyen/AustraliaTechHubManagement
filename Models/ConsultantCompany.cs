using AustraliaTechHubManagement.Interfaces;

namespace AustraliaTechHubManagement.Models;

public class ConsultantCompany : IPayable, ITaxable
{
  public string CompanyName { get; set; }
  public string ABN { get; set; }
  public double MonthlyRetainerFee { get; set; }
  public double AdditionalServiceFee { get; set; }

  public ConsultantCompany(string companyName, string abn, double monthlyRetainerFee, double additionalServiceFee)
  {
    CompanyName = companyName;
    ABN = abn;
    MonthlyRetainerFee = monthlyRetainerFee;
    AdditionalServiceFee = additionalServiceFee;
  }

  public double GetPaymentAmount() => MonthlyRetainerFee + AdditionalServiceFee;
  public double CalculateTax() => GetPaymentAmount() * 0.25; // Simple tax calculation for companies

}