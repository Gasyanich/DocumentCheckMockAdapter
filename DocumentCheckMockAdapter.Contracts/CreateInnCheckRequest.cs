using System.ComponentModel.DataAnnotations;

namespace DocumentCheckMockAdapter.Contracts;

/// <summary>
/// Запрос создания заявки на проверку ИНН
/// </summary>
public class CreateInnCheckRequest
{
    /// <summary>
    /// Фамилия
    /// </summary>
    [Required]
    public string LastName { get; set; }

    /// <summary>
    /// Имя
    /// </summary>
    [Required]
    public string FirstName { get; set; }

    /// <summary>
    /// Отчество
    /// </summary>
    public string MiddleName { get; set; }

    /// <summary>
    /// Дата рождения
    /// </summary>
    [Required]
    public DateTime? BirthDate { get; set; }

    /// <summary>
    /// Серия ДУЛ
    /// </summary>
    /// <example>4444</example>
    [Required]
    public string PassportSeries { get; set; }

    /// <summary>
    /// Номер ДУЛ
    /// </summary>
    /// <example>666666</example>
    [Required]
    public string PassportNumber { get; set; }

    /// <summary>
    /// Дата выдачи паспорта
    /// </summary>
    [Required]
    public DateTime? PassportIssueDate { get; set; }

    /// <summary>
    /// ИНН для проверки
    /// <example>325507450247</example>
    /// </summary>
    [Required]
    public string Inn { get; set; }
}