using BudgetWatch.Core.Enum;
using BudgetWatch.Core.Interfaces;

namespace BudgetWatch.Core.Entities
{
    public class Invoice: IEntity
    {
        public Guid Id { get; set; }
        public Guid CardId { get; set; }
        public Card Card { get; set; }
        public Guid TransactionId { get; set; }
        public Transaction Transaction { get; set; }
        public DateTime ClosingDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public InvoiceStatusEnum Status { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public bool IsActive { get; set; }
    }
}
