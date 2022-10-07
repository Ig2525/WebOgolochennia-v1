using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Xml.Linq;
using WebOgolochennia_v1.Data;
using WebOgolochennia_v1.Data.Entities;
using WebOgolochennia_v1.Models;

namespace WebOgolochennia_v1.Controllers
{
    public class CategoriesController : Controller
    {
        //Вивід списку з БД
        private readonly MyAppContext _appContext;
        public CategoriesController(MyAppContext appContext)
        {
            _appContext = appContext;
        }
        // Відображення списку категорій чи оголошень
        public IActionResult Index()
        {
            var list = _appContext.Categories.Select(x => new CategoryItemViewModel
            {
                Id = x.Id,
                Name = x.Name,
                Advertisement = x.Advertisement,
                Price = x.Price,
                Tel1 = x.Tel1,
                Tel2 = x.Tel2,
                Other = x.Other,
                PublicInNewspaper = x.PublicInNewspaper,
                InicialData = x.InicialData,
                FinalData = x.FinalData,
                Highlighted = x.Highlighted,
                Frame = x.Frame,
                Background = x.Background,
                PublicInSite = x.PublicInSite,
                InitialWeek = x.InitialWeek,
                Up = x.Up,
                Paid = x.Paid,
            }).ToList();
            return View();
        }
        //Показуємо сторінку створення категорії
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        //Зберігаємо категорію в БД
        [HttpPost]
        public IActionResult Create(CategoryCreateViewModels model)
        {
            CategoryEntity entity = new CategoryEntity()
            {
                Name = model.Name,
                Advertisement = model.Advertisement,
                Price = model.Price,
                Tel1 = model.Tel1,
                Tel2 = model.Tel2,
                Other = model.Other,
                PublicInNewspaper = model.PublicInNewspaper,
                InicialData = model.InicialData,
                FinalData = model.FinalData,
                Highlighted = model.Highlighted,
                Frame = model.Frame,
                Background = model.Background,
                PublicInSite = model.PublicInSite,
                InitialWeek = model.InitialWeek,
                Up = model.Up,
                Paid = model.Paid,
            };
            _appContext.Categories.Add(entity);
            _appContext.SaveChanges();
            return View();
        }
    }
}
