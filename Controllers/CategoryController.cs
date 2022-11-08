using Microsoft.AspNetCore.Mvc;
using System.Data.Common;
using Deskbug.Contexts;


namespace Deskbug.Controllers;

public class CategoryController : Controller
{
    private readonly AppDbContext _db;

    public CategoryController(AppDbContext db)
    {
        _db = db;
    }

    public IActionResult Index()
    {
        //var todos = _context.Todos.OrderBy(x => x.Date).ToList();
        //var viewModel = new ListTodoViewModel { Todos = todos };
        ViewData["Title"] = "Categorias";
        return View();

        // outra forma de fazer - sem usar viewmodel
        //IEnumerable<Todo> objTodoList = _context.Todos;
        //return View(objTodoList);
    }



}