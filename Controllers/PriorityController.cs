using Microsoft.AspNetCore.Mvc;
using Deskbug.Contexts;
using Deskbug.ViewModels;
using Deskbug.Models;

namespace Deskbug.Controllers;

public class PriorityController : Controller
{
    private readonly AppDbContext _db;

    public PriorityController(AppDbContext db)
    {
        _db = db;
    }

    public IActionResult Index()
    {
        var priority = _db.Priorities.OrderBy(x => x.Grade).ToList();
        var viewModel = new ListPriorityViewModel { Priorities = priority };
        ViewData["Title"] = "Priorities";
        return View(viewModel);
    }

    /*     public IActionResult Create()
        {
            ViewData["Title"] = "New Company";
            return View("Form");
        } */

    /*     [HttpPost]
        public IActionResult Create(FormCompanyViewModel dados)
        {
            var company = new Company(dados.Name, dados.ShortName,
            dados.Description, dados.CreatedDate, dados.CompanyStatus);

            _db.Add(company);
            _db.SaveChanges();
            return RedirectToAction(nameof(Index));
        } */

    /*     public IActionResult Edit(int id)
        {
            ViewData["Title"] = "Edit Company";

            var company = _db.Companies.Find(id);
            if (company is null)
            {
                return NotFound();
            }
            var viewModel = new FormCompanyViewModel
            {
                Name = company.Name,
                ShortName = company.ShortName,
                Description = company.Description,
                CreatedDate = company.CreatedDate,
                CompanyStatus = company.CompanyStatus
            };
            return View("Form", viewModel);
        } */

    /*     [HttpPost]
        public IActionResult Edit(int id, FormCompanyViewModel dados)
        {
            var company = _db.Companies.Find(id);
            if (company is null)
            {
                return NotFound();
            }
            company.Name = dados.Name;
            company.ShortName = dados.ShortName;
            company.Description = dados.Description;
            company.CreatedDate = dados.CreatedDate;
            company.CompanyStatus = dados.CompanyStatus;
            _db.SaveChanges();
            return RedirectToAction(nameof(Index));
        } */

    /*     public IActionResult Delete(int id)
        {
            var company = _db.Companies.Find(id);
            if (company is null)
            {
                return NotFound();
            }
            _db.Remove(company);
            _db.SaveChanges();
            return RedirectToAction(nameof(Index));
        } */
}