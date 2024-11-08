using Microsoft.AspNetCore.Mvc;
using MVCProject.Models;

namespace MVCProject.Controllers;

public class ItemsController : Controller
{
    // GET
    public IActionResult Overview()
    {
        var item = new Item() { Name="keyboard" };
        return View(item);
    }

    public IActionResult Edit(int id)
    {
        return Content("id=" + id);
    }
}