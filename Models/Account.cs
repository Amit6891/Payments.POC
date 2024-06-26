namespace PaymentsPOC.Models
{
    public class Account
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string FinalSettlement { get; set; }
        public string RefNum { get; set; }
        public decimal Amount { get; set; }
        public string Email { get; set; }
    }
}
