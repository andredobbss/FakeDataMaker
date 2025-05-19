namespace FakeDataMaker.Models;

public class ManufacturingModel
{
    public string ProductName { get; set; } = string.Empty;
    public string FactoryLocation { get; set; } = string.Empty;
    public string SupervisorName { get; set; } = string.Empty;
    public string MachineCode { get; set; } = string.Empty;
    public string Shift { get; set; } = string.Empty;
    public int UnitsProduced { get; set; }
    public DateTime ProductionDate { get; set; }
    public decimal UnitCost { get; set; }
    public string QualityCheckStatus { get; set; } = string.Empty;
    public string Department { get; set; } = string.Empty;
    public bool IsAutomated { get; set; }
    public string RawMaterial { get; set; } = string.Empty;
    public string MaintenanceTechnician { get; set; } = string.Empty;
    public DateTime LastMaintenanceDate { get; set; }
    public int DefectiveUnits { get; set; }
}
