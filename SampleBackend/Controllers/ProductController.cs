using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SampleBackend.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ProductController : Controller
{
    // GET: api/Product
    [HttpGet]
    public ActionResult Index()
    {
        return View();
    }

    // GET: api/Product/Details/5
    [HttpGet("{id}")]
    public ActionResult Details(int id)
    {
        return View();
    }

    // GET: api/Product/Create
    [HttpGet("create")]
    public ActionResult Create()
    {
        return View();
    }

    // POST: api/Product/Create
    [HttpPost("create")]
    [ValidateAntiForgeryToken]
    public ActionResult Create(IFormCollection collection)
    {
        try
        {
            return RedirectToAction(nameof(Index));
        }
        catch
        {
            return View();
        }
    }

    // GET: api/Product/Edit/5
    [HttpGet("edit/{id}")]
    public ActionResult Edit(int id)
    {
        return View();
    }

    // POST: api/Product/Edit/5
    [HttpPost("edit/{id}")]
    [ValidateAntiForgeryToken]
    public ActionResult Edit(int id, IFormCollection collection)
    {
        try
        {
            return RedirectToAction(nameof(Index));
        }
        catch
        {
            return View();
        }
    }

    // GET: api/Product/Delete/5
    [HttpGet("delete/{id}")]
    public ActionResult Delete(int id)
    {
        return View();
    }

    // POST: api/Product/Delete/5
    [HttpPost("delete/{id}")]
    [ValidateAntiForgeryToken]
    public ActionResult Delete(int id, IFormCollection collection)
    {
        try
        {
            return RedirectToAction(nameof(Index));
        }
        catch
        {
            return View();
        }
    }
}