using Microsoft.AspNetCore.Mvc;
using System.Data.Common;
using Deskbug.Contexts;
using Deskbug.Models;
using Deskbug.ViewModels;

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
        //var categories = _db.Categories.OrderBy(x => x.Name).ToList();
        var categories = _db.Categories.ToList();
        var viewModel = new ListCategoryViewModel { Categories = categories };
        ViewData["Title"] = "Categorias";
        return View(viewModel);

        // outra forma de fazer - sem usar viewmodel
        //IEnumerable<Todo> objTodoList = _context.Todos;
        //return View(objTodoList);
    }

    public IActionResult Create()
    {
        ViewData["Title"] = "Cadastrar Categoria";
        return View("Form");
    }

    [HttpPost]
    public IActionResult Create(FormCategoryViewModel dados)
    {
        var category = new Category(dados.Name, dados.DisplayOrder, dados.CategoryLevel,
        dados.CategoryReference, dados.CreatedDate, dados.CategoryStatus);

        _db.Add(category);
        _db.SaveChanges();
        return RedirectToAction(nameof(Index));
    }







}