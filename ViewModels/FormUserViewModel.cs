namespace Deskbug.ViewModels;

public class FormUserViewModel
{
    public int Id { get; set; }
    public string FullName { get; set; } = string.Empty;
    public string UserName { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Token { get; set; } = string.Empty;
    public DateTime TokenDate { get; set; }
    public int UserStatus { get; set; }
}