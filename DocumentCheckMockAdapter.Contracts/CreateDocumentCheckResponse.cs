namespace DocumentCheckMockAdapter.Contracts;

/// <summary>
/// Ответ на запрос создания заявки проверки документа
/// </summary>
public class CreateDocumentCheckResponse(string taskId)
{
    /// <summary>
    /// Id задачи для запроса статуса
    /// </summary>
    public string TaskId { get; set; } = taskId;
}