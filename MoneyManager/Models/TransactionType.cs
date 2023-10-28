namespace MoneyManager.Models;

/// <summary>
/// Тип Транзакции
/// </summary>
public class TransactionType
{
    /// <summary>
    /// Первичный ключ для Типа транзакции
    /// </summary>
    public int Id { get; set; }
    
    /// <summary>
    /// Внешний ключ для связи с Транзакцией
    /// </summary>
    public int TransactionId { get; set; }
    
    /// <summary>
    /// Название Типа транзакции
    /// </summary>
    public int Title { get; set; }
    
    /// <summary>
    /// Связанный объект Транзакция
    /// </summary>
    public Transaction Transaction { get; set; }
}