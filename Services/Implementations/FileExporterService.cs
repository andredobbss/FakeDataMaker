using BlazorDownloadFile;
using ClosedXML.Excel;
using CsvHelper;
using FakeDataMaker.Helpers;
using FakeDataMaker.Services.Interfaces;
using System.Globalization;
using System.Text;

namespace FakeDataMaker.Services.Implementations;

public class FileExporterService : IFileExporterService
{
    private readonly IBlazorDownloadFileService _downloadFileService;

    public FileExporterService(IBlazorDownloadFileService downloadFileService)
    {
        _downloadFileService = downloadFileService;
    }
    public async Task ExportCsvAsync<T>(IEnumerable<T> data, string baseFileName)
    {
        using var memoryStream = new MemoryStream();
        using var streamWriter = new StreamWriter(memoryStream, Encoding.UTF8);
        using var csvWriter = new CsvWriter(streamWriter, CultureInfo.InvariantCulture);

        csvWriter.WriteRecords(data);
        streamWriter.Flush();
        memoryStream.Position = 0;

        var fileName = $"{baseFileName}_export_{DateTime.Now:yyyyMMdd_HHmmss}.csv";
        await _downloadFileService.DownloadFile(fileName, memoryStream.ToArray(), "text/csv");
    }
    public async Task ExportXlsxAsync<T>(IEnumerable<T> data, string baseFileName)
    {
        using XLWorkbook wb = new();
        var ws = wb.AddWorksheet(baseFileName);
        ws.Cell(1, 1).InsertTable(data).Theme = XLTableTheme.TableStyleLight1;
        ws.Columns().AdjustToContents();

        using var stream = new MemoryStream();
        wb.SaveAs(stream);
        stream.Position = 0;

        var fileName = $"{baseFileName}_export_{DateTime.Now:yyyyMMdd_HHmmss}.xlsx";
        await _downloadFileService.DownloadFile(fileName, stream.ToArray(), "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet");
    }
    public async Task ExportSqlAsync<T>(IEnumerable<T> data, string baseFileName)
    {
        string sqlScript = data.ToSqlScript(baseFileName);

        var fileName = $"{baseFileName}_export_{DateTime.Now:yyyyMMdd_HHmmss}.sql";
        var fileBytes = Encoding.UTF8.GetBytes(sqlScript);

        await _downloadFileService.DownloadFile(fileName, fileBytes, "application/sql");
    }
}

