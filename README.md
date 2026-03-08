# 🇦🇺 Australia Tech Hub Management System
## 🚀 Key Features
* **Multi-Entity Payroll:** Handles different payment logics for Full-time Employees, Contractors, and B2B Consulting Companies.
* **Automated Tax Calculation:** Implements a tiered taxation system based on Australian-style salary brackets.
* **Unified Payment Interface:** Uses a common IPayable interface to process payments across unrelated entities.
* **Pattern Matching:** Utilizes modern C# features to identify and display specific details for each entity type.

## 🏗 Architecture & Design Patterns
* **`Interfaces/`**: Defines the "contracts" (`IPayable`, `ITaxable`).
* **`Models/`**: Contains the base Person (Abstract Class) and B2B entities like `ConsultantCompany`.
* **`Models/Persons/`**: Contains specialized person types like `Employee` and `Contractor`.
* **`Models/Persons/Employees/`**: Contains specific corporate roles (`Developer`, `Manager`).

### Technical Concepts Applied:
* **Abstraction**: Used `abstract class Person` to prevent instantiation of generic persons and enforce property sharing.
* **Encapsulation**: Logic for tax and bonus calculation is kept private within classes, exposing only the final payment amount.
* **Polymorphism**: A single `List<IPayable>` manages multiple types, calling the correct overridden methods at runtime.
* **Interface Segregation**: Separate interfaces for `IPayable` (payment) and `ITaxable` (tax logic) to maintain high cohesion.

## 🛠 Tech Stack
* **Language**: C# 12.0
* **Framework**: .NET 8.0/9.0
* **Environment**: Cross-platform (Windows, macOS, Linux)

## 🏃 Getting Started
1. Clone the repository:
```bash
git clone https://github.com/grace-nguyen/AustraliaTechHubManagement.git
```
2. Navigate to the project folder:
```bash 
cd AustraliaTechHubManagement
```
3. Run the application:
```bash
dotnet run
```
## 📝 Example Output 

```bash
---Australia Tech Hub Management System---
Type: Developer            | Detail: Grace Nguyen    | Amount Payable: $7,999.20
Type: Manager              | Detail: John Doe        | Amount Payable: $8,900.00
Type: Contractor           | Detail: Jane Smith      | Amount Payable: $8,080.00
Type: ConsultantCompany    | Detail: Tech Solutions  | Amount Payable: $7,004.00
```