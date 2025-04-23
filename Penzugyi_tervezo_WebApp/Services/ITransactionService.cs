using Penzugyi_tervezo_WebApp.Models;

namespace Penzugyi_tervezo_WebApp.Services
{
    public interface ITransactionService
    {
        Task<List<Transaction>> GetTransactionsAsync();
        Task AddTransactionAsync(Transaction transaction);
    }
}
