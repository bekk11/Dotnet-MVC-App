using CouseSameerSaini.Data;
using CouseSameerSaini.Models.Domain;
using CouseSameerSaini.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CouseSameerSaini.Controllers;

public class AdminTagsController : Controller
{
    private readonly AppDBContext _appDbContext;
    
    public AdminTagsController(AppDBContext appDbContext)
    {
        _appDbContext = appDbContext;
    }
    
    [HttpGet]
    public IActionResult Add()
    {
        return View();
    }

    [HttpPost]
    [ActionName("Add")]
    public IActionResult SubmitTag(AddTagRequest addTagRequest)
    {
        var tag = new Tag
        {
            Name = addTagRequest.Name,
            DisplayName = addTagRequest.DisplayName
        };

        _appDbContext.Tags.Add(tag);
        _appDbContext.SaveChanges();
        
        return View("Add");
    }
}