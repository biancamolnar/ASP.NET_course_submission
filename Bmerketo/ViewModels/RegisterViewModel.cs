using Bmerketo.Models.Entities;

namespace Bmerketo.ViewModels;

public class RegisterViewModel
{
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public string Email { get; set; } = null!;
    public string Password { get; set; } = null!;

    public static implicit operator UserEntity(RegisterViewModel model)
    {
        return new UserEntity
        {
            FirstName = model.FirstName,
            LastName = model.LastName,
            Email = model.Email,
            UserName = model.Email,
        };
    }
}
