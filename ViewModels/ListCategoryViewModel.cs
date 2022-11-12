using Microsoft.EntityFrameworkCore.Internal;
using Deskbug.Models;

namespace Deskbug.ViewModels;

public class ListCategoryViewModel
{
    public ICollection<Category> Categories { get; set; } = new List<Category>();
}