using System.Collections.Concurrent;
using System.Reflection.Metadata;

namespace DocumentCheckMockAdapter.API.Documents;

public class DocumentCheckService
{
    private readonly ConcurrentDictionary<string, DocumentCheck> _documents = new();

    public string CreateDocumentCheck()
    {
        var id = Guid.NewGuid().ToString("N").ToUpper();

        _documents.TryAdd(id, new DocumentCheck(id, DocumentCheckStatus.InProgress));
        
        return id;
    }

    public DocumentCheck? GetDocumentCheckStatus(string id)
    {
        if (!_documents.TryGetValue(id, out var documentCheck))
            return null;
        
        // иммитация долгой проверки
        var now = DateTimeOffset.UtcNow;
        if (now - documentCheck.CreatedAt < TimeSpan.FromMinutes(5))
        {
            documentCheck.Status = DocumentCheckStatus.InProgress;
            documentCheck.Description = "Заявка в обработке";
            return documentCheck;
        }
        
        var rnd = new Random();
        var n = rnd.Next(0, 5);

        // рандомно отбиваем 40% заявок
        if (n < 2)
        {
            documentCheck.Status = DocumentCheckStatus.Failed;
            documentCheck.Description = "Запрашиваемые сведения не найдены";
        }
        else
        {
            documentCheck.Status = DocumentCheckStatus.Success;
            documentCheck.Description = "Успех";
        }
        
        return documentCheck;
    }
}