using System.Globalization;
using System.Reflection;
using System.Text;

namespace FakeDataMaker.Helpers;

public static class SqlExportHelper
{
    public static string ToSqlScript<T>(this IEnumerable<T> data, string tableName)
    {
        var type = typeof(T);
        var props = type.GetProperties(BindingFlags.Public | BindingFlags.Instance);

        var sb = new StringBuilder();

        // CREATE TABLE
        sb.AppendLine($"CREATE TABLE {tableName} (");

        foreach (var prop in props)
        {
            sb.AppendLine($"  {prop.Name} {GetSqlType(prop)},");
        }

        // remove última vírgula
        sb.Length -= 3;
        sb.AppendLine("\n));");
        sb.AppendLine();

        // INSERTs
        foreach (var item in data)
        {
            var values = props.Select(p =>
            {
                var value = p.GetValue(item);
                return value switch
                {
                    null => "NULL",
                    string s => $"'{s.Replace("'", "''")}'",
                    DateTime dt => $"'{dt:yyyy-MM-dd HH:mm:ss}'",
                    bool b => b ? "1" : "0",
                    _ => Convert.ToString(value, CultureInfo.InvariantCulture)
                };
            });

            sb.AppendLine($"INSERT INTO {tableName} ({string.Join(", ", props.Select(p => p.Name))}) VALUES ({string.Join(", ", values)});");
        }

        return sb.ToString();
    }

    private static string GetSqlType(PropertyInfo prop)
    {
        var type = Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType;

        return type.Name switch
        {
            nameof(String) => "NVARCHAR(255)",
            nameof(Int32) => "INT",
            nameof(Int64) => "BIGINT",
            nameof(Boolean) => "BIT",
            nameof(Decimal) => "DECIMAL(18,2)",
            nameof(Double) => "FLOAT",
            nameof(Single) => "REAL",
            nameof(DateTime) => "DATETIME",
            _ => "NVARCHAR(255)" // fallback
        };
    }
}
