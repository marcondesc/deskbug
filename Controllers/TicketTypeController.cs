using Microsoft.AspNetCore.Mvc;
using Deskbug.Contexts;
using Deskbug.ViewModels;
using Deskbug.Models;

namespace Deskbug.Controllers;

public class TicketTypeController : Controller
{
    private readonly AppDbContext _db;

    public TicketTypeController(AppDbContext db)
    {
        _db = db;
    }

    public IActionResult Index()
    {
        var ticketType = _db.TicketTypes.OrderBy(x => x.Name).ToList();
        var viewModel = new ListTicketTypeViewModel { TicketTypes = ticketType };
        ViewData["Title"] = "TicketType";
        return View(viewModel);
    }

    public IActionResult Create()
    {
        ViewData["Title"] = "New TicketType";
        return View("Form");
    }

    [HttpPost]
    public IActionResult Create(FormTicketTypeViewModel dados)
    {
        var ticketType = new TicketType(dados.Name, dados.TicketTypeStatus);

        _db.Add(ticketType);
        _db.SaveChanges();
        return RedirectToAction(nameof(Index));
    }

    public IActionResult Edit(int id)
    {
        ViewData["Title"] = "Edit TicketType";

        var ticketType = _db.TicketTypes.Find(id);
        if (ticketType is null)
        {
            return NotFound();
        }
        var viewModel = new FormTicketTypeViewModel
        {
            Name = ticketType.Name,
            TicketTypeStatus = ticketType.TicketTypeStatus
        };
        return View("Form", viewModel);
    }

    [HttpPost]
    public IActionResult Edit(int id, FormTicketTypeViewModel dados)
    {
        var ticketType = _db.TicketTypes.Find(id);
        if (ticketType is null)
        {
            return NotFound();
        }
        ticketType.Name = dados.Name;
        ticketType.TicketTypeStatus = dados.TicketTypeStatus;
        _db.SaveChanges();
        return RedirectToAction(nameof(Index));
    }

    public IActionResult Delete(int id)
    {
        var ticketType = _db.TicketTypes.Find(id);
        if (ticketType is null)
        {
            return NotFound();
        }
        _db.Remove(ticketType);
        _db.SaveChanges();
        return RedirectToAction(nameof(Index));
    }
}