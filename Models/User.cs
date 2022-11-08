namespace Deskbug.Models;

public class User
{
    public int Id { get; set; }
    public string FullName { get; set; } = string.Empty;
    public string UserName { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Token { get; set; } = string.Empty;
    public DateTime TokenDate { get; set; }
    public int UserStatus { get; set; }

    public User(string fullName, string userName, string password, string email, string token, DateTime tokenDate, int userStatus)
    {
        FullName = fullName;
        UserName = userName;
        Password = password;
        Email = email;
        Token = token;
        TokenDate = tokenDate;
        UserStatus = userStatus;
    }

    public User(int id, string fullName, string userName, string password, string email, string token, DateTime tokenDate, int userStatus)
    {
        Id = id;
        FullName = fullName;
        UserName = userName;
        Password = password;
        Email = email;
        Token = token;
        TokenDate = tokenDate;
        UserStatus = userStatus;
    }

}