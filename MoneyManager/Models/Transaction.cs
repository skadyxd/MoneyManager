namespace MoneyManager.Models;

/// <summary>
/// Транзакция
/// </summary>
public class Transaction
{
    /// <summary>
    /// Первичный ключ Транзакции
    /// </summary>
    public int Id { get; set; }
    
    /// <summary>
    /// Внешний ключ для связи с Клиентом
    /// </summary>
    public int ClientId { get; set; }
    
    /// <summary>
    /// Название Транзакции
    /// </summary>
    public string Title { get; set; }
    
    /// <summary>
    /// Описание Транзакции
    /// </summary>
    public string Description { get; set; }
    
    /// <summary>
    /// Сумма Транзакции
    /// </summary>
    public decimal Amount { get; set; }
    
    /// <summary>
    /// Связанный объект Клиент
    /// </summary>
    public Client Client { get; set; }
    
}