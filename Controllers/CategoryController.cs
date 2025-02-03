using BookstoreMvc.Data;
using BookstoreMvc.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BookstoreMvc.Controllers;

public class CategoryController : Controller
{
    private readonly ApplicationDbContext _context;
    
    public CategoryController(ApplicationDbContext context)
    {
        _context = context;
    }
    
    public IActionResult Index()
    {
        List<Category> objCategoryList = _context.Categories.ToList();
        return View(objCategoryList);
    }

    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Create(Category category)
    {
        if (ModelState.IsValid)
        {
            _context.Categories.Add(category);
            _context.SaveChanges();
            TempData["success"] = "Category created successfully";
            return RedirectToAction("Index");
        }
        
        TempData["error"] = "Category creation failed";
        return View();
    }

    public IActionResult Edit(Guid? id)
    {
        if (id is null)
        {
            return NotFound();
        }
        
        Category? category = _context.Categories.FirstOrDefault(category => category.Id == id);
        
        if (category == null)
        {
            return NotFound();
        }
        
        return View(category);
    }

    [HttpPost]
    public IActionResult Edit(Category categoryViewModel)
    {
        if (ModelState.IsValid)
        {
            _context.Update(categoryViewModel);
            _context.SaveChanges();
            TempData["success"] = "Category updated successfully";
            return RedirectToAction("Index");
        }
        else
        {
            return View();
        }
    }
    
    public IActionResult Delete(Guid? id)
    {
        if (id is null)
        {
            return NotFound();
        }
        
        Category? category = _context.Categories.FirstOrDefault(category => category.Id == id);
        
        if (category == null)
        {
            return NotFound();
        }
        
        return View(category);
    }

    [HttpPost, ActionName("Delete")]
    public IActionResult DeletePOST(Guid? id)
    {
        Category? category = _context.Categories.FirstOrDefault(category => category.Id == id);
        if (category is null)
        {
            return NotFound();
        }
        
        _context.Categories.Remove(category);
        _context.SaveChanges();
        TempData["success"] = "Category deleted successfully";
        return RedirectToAction("Index");
    }
}