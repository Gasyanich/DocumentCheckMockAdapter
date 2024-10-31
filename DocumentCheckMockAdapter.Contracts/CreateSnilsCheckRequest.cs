using System.ComponentModel.DataAnnotations;

namespace DocumentCheckMockAdapter.Contracts;

/// <summary>
/// Запрос создания заявки на проверку СНИЛС
/// </summary>
public class CreateSnilsCheckRequest
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
    /// Пол
    /// </summary>
    [Required]
    public Gender? Gender { get; set; }

    /// <summary>
    /// СНИЛС для проверки
    /// <example>98765432109</example>
    /// </summary>
    [Required]
    public string Snils { get; set; }
}