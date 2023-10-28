namespace MoneyManager.Models;

/// <summary>
/// Клиент
/// </summary>
public class Client
{
    /// <summary>
    /// Первичный ключ клиента
    /// </summary>
    public int Id { get; set; }
    
    /// <summary>
    /// Логин Клиента
    /// </summary>
    public string Login { get; set; }
    
    /// <summary>
    /// Пароль Клиента
    /// </summary>
    public string Password { get; set; }
    
    /// <summary>
    /// Псевдоним Клиента
    /// </summary>
    public string Nickname { get; set; }
    
    /// <summary>
    /// Дата рождения Клиента 
    /// </summary>
    public DateTime DateOfBirth { get; set; }
}