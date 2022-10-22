namespace WebStore.ViewModels.VM;
public class JwtOptionsVm
{
    public string Issuer { get; set; } = default!;
    public string Audience { get; set; } = default!;
    public string SecretKey { get; set; } = default!;
    public int TokenExpirationMinutes { get; set; }
}
using System.ComponentModel.DataAnnotations;
namespace WebStore.ViewModels.VM;
public class LoginUserVm
{
    [Required]
    [StringLength(50, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength
    = 6)]
    [Display(Name = "Email")]
    public string Login { get; set; } = default!;
    [Required]
    [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.",
    MinimumLength = 6)]
    [DataType(DataType.Password)]
    public string Password { get; set; } = default!;
}