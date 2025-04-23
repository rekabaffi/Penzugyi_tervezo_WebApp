using Penzugyi_tervezo_WebApp.Models;

namespace Penzugyi_tervezo_WebApp.Services
{
    public class MockTransactionService : ITransactionService
    {
        //private readonly ITransactionService _transactionService;

        //public MockTransactionService (ITransactionService transactionService)
        //{
        //    _transactionService = transactionService;
        //}

        private List<Transaction> _transactions = new()
        {
            new Transaction { Id = 1, Amount = 150000, Type = "Income", Category = "Fizetés", Date = DateTime.Now.AddDays(-5), Description = "Havi fizetés" },
            new Transaction { Id = 2, Amount = 25000, Type = "Expense", Category = "Élelmiszer", Date = DateTime.Now.AddDays(-2), Description = "Bevásárlás" }
        };

        public Task<List<Transaction>> GetTransactionsAsync()
        {
            return Task.FromResult(_transactions);
        }

        public Task AddTransactionAsync(Transaction transaction)
        {
            transaction.Id = _transactions.Max(t => t.Id) + 1;
            _transactions.Add(transaction);
            return Task.CompletedTask;
        }
    }
}
