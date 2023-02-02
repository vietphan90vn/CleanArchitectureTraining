using System.Globalization;
using CleanArchitecture.JT.Application.Common.Interfaces;
using CleanArchitecture.JT.Application.TodoLists.Queries.ExportTodos;
using CleanArchitecture.JT.Infrastructure.Files.Maps;
using CsvHelper;

namespace CleanArchitecture.JT.Infrastructure.Files;

public class CsvFileBuilder : ICsvFileBuilder
{
    public byte[] BuildTodoItemsFile(IEnumerable<TodoItemRecord> records)
    {
        using var memoryStream = new MemoryStream();
        using (var streamWriter = new StreamWriter(memoryStream))
        {
            using var csvWriter = new CsvWriter(streamWriter, CultureInfo.InvariantCulture);

            csvWriter.Context.RegisterClassMap<TodoItemRecordMap>();
            csvWriter.WriteRecords(records);
        }

        return memoryStream.ToArray();
    }
}
