using Data.Models.Devices;
using Data.Models.Users;

namespace Data.Models.Payments;

public class Accrual
{
    public int Id { get; set; }
    public int IndicationTypeId { get; set; }
    public int FincardId { get; set; }
    public decimal Debt { get; set; }
    public decimal Fine { get; set; }
    public decimal Accrued { get; set; }
    public decimal Prepayment { get; set; }
    public virtual IndicationType IndicationType { get; set; }
    public virtual Fincard Fincard { get; set; }
}