using BudgetWatch.Core.Interfaces;

namespace BudgetWatch.Core.Entities
{
    public class Card: IEntity
    {
        public Guid Id { get; set; }
        public Guid WalletId { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }
        public decimal Limit { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public bool IsActive { get; set; }
    }
}
