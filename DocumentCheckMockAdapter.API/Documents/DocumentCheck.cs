namespace DocumentCheckMockAdapter.API.Documents;

public class DocumentCheck
{
    public DocumentCheck(string id, DocumentCheckStatus status, string? description = null)
    {
        Id = id;
        Status = status;
        Description = description;
        CreatedAt = DateTimeOffset.UtcNow;
    }

    public string Id { get; set; }

    public DocumentCheckStatus Status { get; set; }

    public string? Description { get; set; }

    public DateTimeOffset CreatedAt { get; set; }
}