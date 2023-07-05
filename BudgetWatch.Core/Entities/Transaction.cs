using BudgetWatch.Core.Interfaces;

namespace BudgetWatch.Core.Entities
{
    public class Transaction: IEntity
    {
        public Guid Id { get; set; }
        public Guid WalletId { get; set; }
        public Wallet Wallet { get; set; }
        public string Name { get; set; }
        public decimal Amount { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool IsCreditCardTransaction { get; set; }
        public Guid InvoiceId { get; set; }
        public DateTime UpdatedAt { get; set; }
        public bool IsActive { get; set; }
    }
}
