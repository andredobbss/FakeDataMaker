namespace FakeDataMaker.Models;

public class InformationTechnologyModel
{
    public string EmployeeName { get; set; } = string.Empty;
    public string JobTitle { get; set; } = string.Empty;
    public string Department { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string PhoneNumber { get; set; } = string.Empty;
    public DateTime HireDate { get; set; }
    public decimal Salary { get; set; }
    public string ProgrammingLanguage { get; set; } = string.Empty;
    public string ProjectName { get; set; } = string.Empty;
    public string Status { get; set; } = string.Empty;
    public bool Remote { get; set; }
    public string ManagerName { get; set; } = string.Empty;
    public DateTime LastPromotionDate { get; set; }
    public string OfficeLocation { get; set; } = string.Empty;
    public int CompletedProjects { get; set; }
}
