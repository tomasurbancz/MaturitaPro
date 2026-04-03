using EFCore.Models.Base;

namespace EFCore.Models;

public class UserEntity : BaseEntity
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string Nickname { get; set; }

    public override string ToString()
    {
        return $"----------\n{FirstName} {LastName}: \nEmail: {Email}\nNickname:{Nickname}\n----------";
    }
}