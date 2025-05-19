namespace FakeDataMaker.Models;

public class EducationModel
{
    public string StudentName { get; set; } = string.Empty;
    public string Institution { get; set; } = string.Empty;
    public string ProgramName { get; set; } = string.Empty;
    public string Level { get; set; } = string.Empty;
    public DateTime EnrollmentDate { get; set; }
    public DateTime GraduationDate { get; set; }
    public double GPA { get; set; }
    public string Email { get; set; } = string.Empty;
    public string PhoneNumber { get; set; } = string.Empty;
    public string Country { get; set; } = string.Empty;
    public string City { get; set; } = string.Empty;
    public string StudentID { get; set; } = string.Empty;
    public bool IsFullTime { get; set; }
    public string AdvisorName { get; set; } = string.Empty;
    public string Department { get; set; } = string.Empty;
}
