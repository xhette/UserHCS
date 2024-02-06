using System.Collections;
using Data.Models.Users;

namespace Data.Models.Payments;

public class Fincard
{
    public int Id { get; set; }
    public string UserId { get; set; }
    public DateTime Date { get; set; }
    public virtual User User { get; set; }
    public virtual ICollection<Accrual> Accruals { get; set; }
    public virtual ICollection<Payment> Payments { get; set; }
}