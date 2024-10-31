namespace DocumentCheckMockAdapter.Contracts;

/// <summary>
/// Статус заявки на проверку документа
/// </summary>
public class DocumentCheckStatusResponse(DocumentCheckStatus status, string description = null)
{
    /// <summary>
    /// Описание статуса
    /// </summary>
    public string Description { get; set; } = description;

    /// <summary>
    /// Статус
    /// </summary>
    public DocumentCheckStatus Status { get; set; } = status;
}

public enum DocumentCheckStatus
{
    /// <summary>
    /// В обработке
    /// </summary>
    InProgress = 1,
    
    /// <summary>
    /// Успех
    /// </summary>
    Success = 2,
    
    /// <summary>
    /// Ошибка проверки
    /// </summary>
    Failed = 3
}