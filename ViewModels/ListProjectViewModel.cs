using Microsoft.EntityFrameworkCore.Internal;
using Deskbug.Models;

namespace Deskbug.ViewModels;

public class ListProjectViewModel
{
    public ICollection<Project> Projects { get; set; } = new List<Project>();
}