using Microsoft.AspNetCore.Mvc;
using LupoonWeb.Models.ViewModels;
using LupoonWeb.Data;
using LupoonWeb.Models.Domain;

namespace LupoonWeb.Controllers
{
    public class AdminTagsController : Controller
    {
        private readonly LupoonDbContext lupoonDbContext;

        public AdminTagsController(LupoonDbContext lupoonDbContext)
        {
            this.lupoonDbContext = lupoonDbContext;
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]//  Connect and make it to transfer the data t database
        [ActionName("Add")]
        public IActionResult Add(AddTagRequest addTagRequest)
        {
            //Mapping Add tag request to Tag domain model
            var tag = new Tag
            {
                Name = addTagRequest.Name,
                DisplayName = addTagRequest.DisplayName
            };

            lupoonDbContext.Tags.Add(tag);
            lupoonDbContext.SaveChanges();
                return View("Add");

            
            
        }
    }
}
