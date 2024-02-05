using Data.Models.Devices;
using Data.Models.Users;

namespace Data.Models.Payments;

public class Accruals
{
    public int Id { get; set; }
    public int IndicationTypeId { get; set; }
    public decimal Debt { get; set; }
    public decimal Fine { get; set; }
    public decimal Accrued { get; set; }
    public decimal Prepayment { get; set; }
    public virtual User User { get; set; }
}