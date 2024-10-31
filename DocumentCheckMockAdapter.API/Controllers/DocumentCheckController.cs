using DocumentCheckMockAdapter.API.Documents;
using DocumentCheckMockAdapter.Contracts;
using Microsoft.AspNetCore.Mvc;
using DocumentCheckStatus = DocumentCheckMockAdapter.Contracts.DocumentCheckStatus;

namespace DocumentCheckMockAdapter.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class DocumentCheckController(DocumentCheckService documentCheckService) : ControllerBase
{
    /// <summary>
    ///     Инициировать проверку ИНН
    /// </summary>
    /// <returns></returns>
    [HttpPost("inn")]
    public ActionResult<CreateDocumentCheckResponse> CreateInn([FromBody] CreateInnCheckRequest _)
    {
        return CreateDocumentCheckResult();
    }

    /// <summary>
    ///     Инициировать проверку СНИЛС
    /// </summary>
    [HttpPost("snils")]
    public ActionResult<CreateDocumentCheckResponse> CreateSnils([FromBody] CreateSnilsCheckRequest _)
    {
        return CreateDocumentCheckResult();
    }

    /// <summary>
    ///     Получить статус заявки на проверку документа
    /// </summary>
    [HttpGet("status/{id}")]
    public ActionResult<DocumentCheckStatusResponse> GetInnStatus(string id)
    {
        return GetStatus(id);
    }
    

    private ActionResult<DocumentCheckStatusResponse> GetStatus(string id)
    {
        var check = documentCheckService.GetDocumentCheckStatus(id);
        
        if (check == null)
            return NotFound();

        return new DocumentCheckStatusResponse((DocumentCheckStatus) check.Status, check.Description);
    }

    private ActionResult<CreateDocumentCheckResponse> CreateDocumentCheckResult()
    {
        var taskId = documentCheckService.CreateDocumentCheck();
        
        return new CreateDocumentCheckResponse(taskId);
    }
}