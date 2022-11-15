using Microsoft.AspNetCore.Mvc;
using Deskbug.Contexts;
using Deskbug.ViewModels;
using Deskbug.Models;

namespace Deskbug.Controllers;

public class ProjectController : Controller
{
    private readonly AppDbContext _db;

    public ProjectController(AppDbContext db)
    {
        _db = db;
    }

    public IActionResult Index()
    {
        var projects = _db.Projects.OrderBy(x => x.ShortName).ToList();
        var viewModel = new ListProjectViewModel { Projects = projects };
        ViewData["Title"] = "Projects";
        return View(viewModel);
    }

    public IActionResult Create()
    {
        ViewData["Title"] = "New Project";
        return View("Form");
    }

    [HttpPost]
    public IActionResult Create(FormProjectViewModel dados)
    {
        var project = new Project(dados.Name, dados.ShortName, dados.Description,
        dados.ProjectColor, dados.CreatedDate, dados.ProjectStatus);

        _db.Add(project);
        _db.SaveChanges();
        return RedirectToAction(nameof(Index));
    }

    public IActionResult Edit(int id)
    {
        ViewData["Title"] = "Edit Project";

        var project = _db.Projects.Find(id);
        if (project is null)
        {
            return NotFound();
        }
        var viewModel = new FormProjectViewModel
        {
            Name = project.Name,
            ShortName = project.ShortName,
            Description = project.Description,
            ProjectColor = project.ProjectColor,
            CreatedDate = project.CreatedDate,
            ProjectStatus = project.ProjectStatus
        };
        return View("Form", viewModel);
    }

    [HttpPost]
    public IActionResult Edit(int id, FormProjectViewModel dados)
    {
        var project = _db.Projects.Find(id);
        if (project is null)
        {
            return NotFound();
        }
        project.Name = dados.Name;
        project.ShortName = dados.ShortName;
        project.Description = dados.Description;
        project.ProjectColor = dados.ProjectColor;
        project.CreatedDate = dados.CreatedDate;
        project.ProjectStatus = dados.ProjectStatus;
        _db.SaveChanges();
        return RedirectToAction(nameof(Index));
    }

    public IActionResult Delete(int id)
    {
        var project = _db.Projects.Find(id);
        if (project is null)
        {
            return NotFound();
        }
        _db.Remove(project);
        _db.SaveChanges();
        return RedirectToAction(nameof(Index));
    }
}