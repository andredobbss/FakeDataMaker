namespace FakeDataMaker.Services.Interfaces;

public interface IFileExporterService
{
    Task ExportCsvAsync<T>(IEnumerable<T> data, string baseFileName);
    Task ExportXlsxAsync<T>(IEnumerable<T> data, string baseFileName);
    Task ExportSqlAsync<T>(IEnumerable<T> data, string baseFileName);
}
