using Microsoft.EntityFrameworkCore.Internal;
using Deskbug.Models;

namespace Deskbug.ViewModels;

public class ListUserViewModel
{
    public ICollection<User> Users { get; set; } = new List<User>();
}