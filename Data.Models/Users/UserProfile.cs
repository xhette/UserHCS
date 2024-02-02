namespace Data.Models.Users;

public class UserProfile
{
    public int Id { get; set; }
    
    public string Surname { get; set; }
    public string Name { get; set; }
    public string Patronymic { get; set; }
    public string UserId { get; set; }
    public virtual User User { get; set; }
}