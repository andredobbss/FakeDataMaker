namespace FakeDataMaker.Models;

public class HealthcareModel
{
    public string PatientName { get; set; } = string.Empty;
    public string PatientId { get; set; } = string.Empty;
    public int Age { get; set; }
    public string Gender { get; set; } = string.Empty;
    public DateTime AdmissionDate { get; set; }
    public string Diagnosis { get; set; } = string.Empty;
    public string Doctor { get; set; } = string.Empty;
    public string Department { get; set; } = string.Empty;
    public string RoomNumber { get; set; } = string.Empty;
    public string TreatmentPlan { get; set; } = string.Empty;
    public decimal TreatmentCost { get; set; }
    public string InsuranceProvider { get; set; } = string.Empty;
    public bool IsDischarged { get; set; }
    public DateTime LastCheckupDate { get; set; }
    public string Notes { get; set; } = string.Empty;
}
