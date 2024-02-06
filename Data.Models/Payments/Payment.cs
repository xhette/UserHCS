namespace Data.Models.Payments;

public class Payment
{
    public int Id { get; set; }
    public int FincardId { get; set; }
    public decimal Amount { get; set; }
    public virtual Fincard Fincard { get; set; }
}