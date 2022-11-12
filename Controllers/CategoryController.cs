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

    public IActionResult Edit(int id)
    {
        ViewData["Title"] = "Editar Tarefa";

        var category = _db.Categories.Find(id);
        if (category is null)
        {
            return NotFound();
        }
        var viewModel = new FormCategoryViewModel
        {
            Name = category.Name,
            DisplayOrder = category.DisplayOrder,
            CategoryLevel = category.CategoryLevel,
            CategoryReference = category.CategoryReference,
            CreatedDate = category.CreatedDate,
            CategoryStatus = category.CategoryStatus
        };
        return View("Form", viewModel);
    }

    [HttpPost]
    public IActionResult Edit(int id, FormCategoryViewModel dados)
    {
        var category = _db.Categories.Find(id);
        if (category is null)
        {
            return NotFound();
        }
        category.Name = dados.Name;
        category.DisplayOrder = dados.DisplayOrder;
        category.CategoryLevel = dados.CategoryLevel;
        category.CategoryReference = dados.CategoryReference;
        category.CreatedDate = dados.CreatedDate;
        category.CategoryStatus = dados.CategoryStatus;
        _db.SaveChanges();
        return RedirectToAction(nameof(Index));
    }

    public IActionResult Delete(int id)
    {
        var category = _db.Categories.Find(id);
        if (category is null)
        {
            return NotFound();
        }
        _db.Remove(category);
        _db.SaveChanges();
        return RedirectToAction(nameof(Index));
    }

}