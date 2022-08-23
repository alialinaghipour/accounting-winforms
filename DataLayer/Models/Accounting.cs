namespace DataLayer.Models
{
    public class Accounting
    {
        public int Id { get; set; }
        public int Amount { get; set; }
        public string Description { get; set; } = default!;
        public DateTime CreationDate { get; set; }
        public AccountingType Type { get; set; }

        public int ContactId { get; set; }
        public Contact Contact { get; set; } = default!;
    }

    public enum AccountingType
    {
        Pay=1,
        Recive=2
    }
}
